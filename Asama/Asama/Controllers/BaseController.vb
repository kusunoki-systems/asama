Imports System.Web
Imports System.Web.Mvc

Namespace Controllers
    Public Class BaseController
        Inherits Controller

#Region "変数"
        ''' <summary>
        ''' DBコンテキスト
        ''' </summary>
        Protected db As New AsamaEntities

        ''' <summary>
        ''' DB接続エラー
        ''' </summary>
        Protected dbError As Boolean

        ''' <summary>
        ''' スタッフ情報
        ''' </summary>
        Protected mStaffbase As M_StaffBase

        Protected Enum enmMasterType
            Other = 0
            Drug = 1
            Material = 2
            Blood = 3
        End Enum
        ''' <summary>
        ''' マスタータイプ（医薬品、医療材料、血液製剤）
        ''' </summary>
        Protected ReadOnly COOKIE_MASTER_TYPE As String = "MasterType"
        Protected MasterType As enmMasterType

        ''' <summary>
        ''' 施設ID
        ''' </summary>
        Protected ReadOnly COOKIE_FACILITY_ID As String = "FacilityId"
        Protected FacilityId As String

        ''' <summary>
        ''' 職種コード
        ''' </summary>
        Protected ReadOnly COOKIE_JOBCODE As String = "JobCode"
        Protected Jobcode As String()

        ''' <summary>
        ''' アクセス権
        ''' </summary>
        Protected AsamaGeneralData As New AsamaGeneralData(Of XElement)


        ''' <summary>
        ''' IPアドレス
        ''' </summary>
        Protected IPAddress As String

        ''' <summary>
        ''' ホスト
        ''' </summary>
        Protected HostName As String

#End Region

#Region "メソッド"

        ''' <summary>
        ''' ユーザー情報取得
        ''' </summary>
        Protected Overrides Sub Initialize(requestContext As RequestContext)
            MyBase.Initialize(requestContext)

            ''DB接続チェック
            'db.Database.Connection.Open()
            'If Not db.Database.Connection.State = ConnectionState.Open Then
            '    ViewBag.Message = "DB接続ができませんでした。ConnectionState:" & db.Database.Connection.State.ToString
            '    Throw New DatabaseNotEnabledForNotificationException
            '    dbError = True
            '    Return
            'End If

            If User.Identity.IsAuthenticated Then
                'ログイン済み

                'ViewBag
                ViewBag.ControllerName = requestContext.RouteData.Values("Controller")
                ViewBag.ActionName = requestContext.RouteData.Values("Action")
                'マスタータイプの取得（医薬品/医療材料/血液製剤）
                Select Case requestContext.RouteData.Values("Id")
                    Case "1"
                        MasterType = enmMasterType.Drug
                        SetCookie(COOKIE_MASTER_TYPE, "1")
                    Case "2"
                        MasterType = enmMasterType.Material
                        SetCookie(COOKIE_MASTER_TYPE, "2")
                    Case "3"
                        MasterType = enmMasterType.Blood
                        SetCookie(COOKIE_MASTER_TYPE, "3")
                    Case Else
                        '引数に無い場合はクッキーから読み込む
                        Dim type As String = GetCookieValueByKey(COOKIE_MASTER_TYPE)
                        'id:1（医薬品） id:2（医療材料） id:3（血液製剤）
                        Select Case type
                            Case "1"
                                MasterType = enmMasterType.Drug
                            Case "2"
                                MasterType = enmMasterType.Material
                            Case "3"
                                MasterType = enmMasterType.Blood
                        End Select
                End Select

                'Homeの場合は、クッキー削除
                If ViewBag.ControllerName = "Home" Then
                    RemoveCookie(COOKIE_MASTER_TYPE)
                    MasterType = enmMasterType.Other
                End If

                '施設情報取得
                'Me.GetFacility()

                'ユーザー情報取得
                Me.GetUser()

                'IPアドレス取得
                Me.GetIPAddress()

                '操作権限取得
                Me.GetMenuAuthority()

                'アクティブメニュー判定
                Me.SetActiveMenu()
            Else
                '未ログイン
            End If

        End Sub

        ''' <summary>
        ''' ユーザー情報取得
        ''' </summary>
        Private Sub GetUser()

            Dim svc As New UserService
            If User IsNot Nothing AndAlso User.Identity.IsAuthenticated Then
                mStaffbase = svc.GetUserInfo(db, User.Identity.Name)
                'If mStaffbase IsNot Nothing Then ViewBag.StaffName = mStaffbase.MSTB_LastName & Replace(" " & mStaffbase.MSTB_MiddleName & " ", "  ", " ") & mStaffbase.MSTB_FirstName
                If mStaffbase IsNot Nothing Then ViewBag.StaffName = mStaffbase.MSTB_Name
            End If

            '職種コード
            Dim strJob As String = GetCookieValueByKey(COOKIE_JOBCODE)
            If strJob IsNot Nothing Then
                Me.Jobcode = strJob.Split(",")
            End If
            Return
        End Sub

        '''' <summary>
        '''' 施設情報取得
        '''' </summary>
        'Private Sub GetFacility()

        '    Me.FacilityId = GetCookieValueByKey(COOKIE_FACILITY_ID)
        '    Dim svc As New S_GroupFacilityService
        '    '施設情報モデル
        '    Dim SGroupFacility As S_GroupFacility
        '    SGroupFacility = svc.GetFacilityModel(db, Me.FacilityId)
        '    If SGroupFacility IsNot Nothing Then ViewBag.FacilityName = SGroupFacility.SGFA_GenericName
        '    Return
        'End Sub

        ''' <summary>
        ''' アクティブメニュー判定
        ''' </summary>
        ''' <remarks>アクティブなメニューのViewBagに”Active”をセット</remarks>
        Private Sub SetActiveMenu()

            Dim strActive As String = "active"

            Select Case MasterType
                Case enmMasterType.Drug
                    ViewBag.ActiveMenu_Type1 = strActive
                Case enmMasterType.Material
                    ViewBag.ActiveMenu_Type2 = strActive
                Case enmMasterType.Blood
                    ViewBag.ActiveMenu_Type3 = strActive
            End Select

        End Sub
        ''' <summary>
        ''' 操作権限取得
        ''' </summary>
        Private Sub GetMenuAuthority()

            '全メニュー権限取得
            Dim Auth_M_DRUG As New AuthorityInfo
            Dim Auth_M_DRUG_MATE As New AuthorityInfo
            Dim Auth_M_DRUG_BLOOD As New AuthorityInfo
            Dim Auth_GM_DRUG As New AuthorityInfo
            Dim Auth_GM_DRUG_MATE As New AuthorityInfo
            Dim Auth_GM_DRUG_BLOO As New AuthorityInfo

            Dim xml As New XMLControlInfo

            ''病院限定薬品
            'xml.GetXMLAccessAuth(db, AsamaGeneralData, Me.FacilityId, Jobcode, Me.mStaffbase.MSTB_StaffID, Auth_M_DRUG, AsamaFunctionID.MasterMainte_M_Drug)
            'If Auth_M_DRUG.AuthSelect Then
            '    '病院薬品参照権限有
            '    ViewBag.View_M_Drug = 1
            'End If

            ''グループ統一薬品
            'xml.GetXMLAccessAuth(db, AsamaGeneralData, Me.FacilityId, Jobcode, Me.mStaffbase.MSTB_StaffID, Auth_GM_DRUG, AsamaFunctionID.MasterMainte_GM_Drug)
            'If Auth_GM_DRUG.AuthSelect Then
            '    '病院薬品参照権限有
            '    ViewBag.View_GM_Drug = 1
            'End If

            ''病院限定輸血製剤
            'xml.GetXMLAccessAuth(db, AsamaGeneralData, Me.FacilityId, Jobcode, Me.mStaffbase.MSTB_StaffID, Auth_M_DRUG_BLOOD, AsamaFunctionID.MasterMainte_M_Drug_Blood)
            'If Auth_M_DRUG_BLOOD.AuthSelect Then
            '    '病院薬品参照権限有
            '    ViewBag.View_M_Drug_Blood = 1
            'End If

            ''グループ統一輸血製剤
            'xml.GetXMLAccessAuth(db, AsamaGeneralData, Me.FacilityId, Jobcode, Me.mStaffbase.MSTB_StaffID, Auth_GM_DRUG_BLOO, AsamaFunctionID.MasterMainte_GM_Drug_Blood)
            'If Auth_GM_DRUG_BLOO.AuthSelect Then
            '    '病院薬品参照権限有
            '    ViewBag.View_GM_Drug_Blood = 1
            'End If

            ''病院限定処方用医療材料
            'xml.GetXMLAccessAuth(db, AsamaGeneralData, Me.FacilityId, Jobcode, Me.mStaffbase.MSTB_StaffID, Auth_M_DRUG_MATE, AsamaFunctionID.MasterMainte_M_Drug_Material)
            'If Auth_M_DRUG_MATE.AuthSelect Then
            '    ViewBag.View_M_Drug_Material = 1
            'End If

            ''グループ統一処方用医療材料
            'xml.GetXMLAccessAuth(db, AsamaGeneralData, Me.FacilityId, Jobcode, Me.mStaffbase.MSTB_StaffID, Auth_GM_DRUG_MATE, AsamaFunctionID.MasterMainte_GM_Drug_Material)
            'If Auth_GM_DRUG_MATE.AuthSelect Then
            '    ViewBag.View_GM_Drug_Material = 1
            'End If

            '現在のページの権限
            Select Case ViewBag.ControllerName
                Case "GM_Drug"
                    Select Case MasterType
                        Case enmMasterType.Drug
                            ViewBag.Auth = Auth_GM_DRUG
                        Case enmMasterType.Material
                            ViewBag.Auth = Auth_GM_DRUG_MATE
                        Case enmMasterType.Blood
                            ViewBag.Auth = Auth_GM_DRUG_BLOO
                    End Select
                Case "M_Drug"
                    Select Case MasterType
                        Case enmMasterType.Drug
                            ViewBag.Auth = Auth_M_DRUG
                        Case enmMasterType.Material
                            ViewBag.Auth = Auth_M_DRUG_MATE
                        Case enmMasterType.Blood
                            ViewBag.Auth = Auth_M_DRUG_BLOOD
                    End Select
            End Select


        End Sub

        ''' <summary>
        ''' IPアドレス取得
        ''' </summary>
        Private Sub GetIPAddress()

            Dim ip As String = String.Empty
            Dim host As String = String.Empty
            Dim ipHelper As New IPHelper
            ipHelper.GetIPAddress(ip, host, Request.ServerVariables("HTTP_VIA"),
                                              Request.ServerVariables("HTTP_X_FORWARDED_FOR"),
                                              Request.ServerVariables("REMOTE_ADDR"))

            Me.IPAddress = ip
            Me.HostName = host

        End Sub




        ''' <summary>
        ''' キーから、リクエストのクッキーを取得します
        ''' </summary>
        ''' <param name="key"></param>
        ''' <returns></returns>
        Protected Function GetCookieValueByKey(key As String) As String
            Dim cookie As HttpCookie = Request.Cookies(key)
            If cookie Is Nothing Then
                Return Nothing
            End If
            Return HttpUtility.UrlDecode(cookie.Value)
        End Function

        ''' <summary>
        ''' レスポンスにクッキーを設定します
        ''' </summary>
        ''' <param name="key">キー</param>
        ''' <param name="value">値</param>
        Protected Sub SetCookie(key As String, value As String)

            Dim cookie As HttpCookie = New HttpCookie(key)
            cookie.Value = HttpUtility.UrlEncode(value)
            Response.Cookies.Add(cookie)

        End Sub

        ''' <summary>
        ''' クッキーを削除します
        ''' </summary>
        ''' <param name="key">キー</param>
        Protected Sub RemoveCookie(key As String)

            Dim cookie As HttpCookie = New HttpCookie(key)
            cookie.Expires = DateTime.Now.AddDays(-1D)
            Response.Cookies.Add(cookie)

        End Sub

        Protected Function GetErrorMessage() As String

            If Not ModelState.IsValid Then
                Return String.Join(" | ", ModelState.Values.SelectMany(Function(v) v.Errors).[Select](Function(e) e.ErrorMessage))
            End If
            Return String.Empty

        End Function


#End Region

    End Class
End Namespace