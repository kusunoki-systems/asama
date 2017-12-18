'******************************************************************
'*	システム名	：	Asama
'*	ファイル名	：	UclLoginBL
'*	概要		：	ログインユーザコントロールビジネスロジック
'*
'*	Copyright  (c) 2014-2015 Medis Co., Ltd.
'*
'*	【履歴】
'*　日付	　担当		Ver.	チケット#	変更理由
'* ----------------------------------------------------------------
''*　2017/06/29	KSI 中村	0.0.1	#--------	uclLoginBLよりコピー
'******************************************************************
Option Strict On
Imports System.Security.Cryptography
Imports System.Text
Imports System.Xml.Linq
Imports System.Linq
Imports System.Data.Entity
Imports System.Data.Entity.Core.Objects

Public Class UclLoginBL

#Region "定数"
    Private Const _ACCESS_AUTHORITY As String = "ACC"
#End Region

#Region "メソッド"

    ''' <summary>
    ''' DoMain
    ''' </summary>
    ''' <remarks>
    ''' 概要： 有効なログインユーザであるか確認した後、ログイン情報の取得をする。
    ''' 【履歴】
    '''  日付    担当    Ver. チケット# 変更理由
    '''  ----------------------------------------------------------------
    ''' </remarks>
    Public Function DoMain(db As AsamaEntities, LoginAppData As LoginAD) As LoginAD
        Try
            Const l_PASSWORDINPUTALLOWTIMES As String = "PasswordInputAllowTimes"
            Const l_PASSWORDVALIDDAYS As String = "PasswordValidDays"

            Dim blEof As Boolean = True
            Dim intPasswordInputAllowTimes As Integer = 99
            Dim intPasswordValidDays As Integer = 9999
            Dim isValidDate As Boolean = True
            Dim isAllowTime As Boolean = True
            Dim isWorkCodeSelect As Boolean = True
            Dim strGetFacilityID As String = String.Empty
            Dim staffJobList As List(Of String) = New List(Of String)
            Dim dicControlInfo As Dictionary(Of String, String) = New Dictionary(Of String, String)

            Dim loginStaffInfo As LoginStaffInfo = New LoginStaffInfo()
            loginStaffInfo.StaffID = LoginAppData.LoginID
            loginStaffInfo.Password = LoginAppData.Password

            '******************* GM_CONTROL ********************

            'コントロールマスタから、システムデータを取得する。
            'Dim ctrlInfo As String = (From e In db.GM_Control
            '                          Where e.GCTL_FunctionID = "COM" And e.GCTL_JobCode = "0000000"
            '                          Select e.GCTL_ControlInfo).FirstOrDefault
            'Dim controlInfoDictionary As IReadOnlyDictionary(Of String, String) = GetControlInfo(ctrlInfo, LoginAppData)
            ''パスワード制限回数
            'Integer.TryParse(controlInfoDictionary(l_PASSWORDINPUTALLOWTIMES), intPasswordInputAllowTimes)
            ''パスワード制限日数
            'Integer.TryParse(controlInfoDictionary(l_PASSWORDVALIDDAYS), intPasswordValidDays)

            ''******************* M_STAFFBASE ********************
            ''最新LogNoを取得
            'Dim maxlogno = (From e As M_StaffBase In db.M_StaffBase
            '                Where e.MSTB_StaffID = LoginAppData.StaffID And
            '                    e.MSTB_FacilityID = LoginAppData.FacilityID
            '                Select e.MSTB_LogNo).Max

            '有効なユーザーの取得
            'Dim staffbase = (From e As M_StaffBase In db.M_StaffBase
            '                 Where e.MSTB_DisplayStaffID = LoginAppData.StaffID And
            '                    e.MSTB_DelFlag = 0 And
            '                    e.MSTB_ValidDateFrom <= Now() And
            '                    Now() <= e.MSTB_ValidDateTo And
            '                    e.MSTB_LogNo = maxlogno And
            '                    e.MSTB_FacilityID = LoginAppData.FacilityID
            '                 Select e).FirstOrDefault
            Dim staffbase = (From e As M_StaffBase In db.M_StaffBase
                             Where e.MSTB_StaffID = LoginAppData.StaffID And
                                e.MSTB_DelFlag = 0 And
                                e.MSTB_LogNo = 0
                             Select e).FirstOrDefault
            If staffbase IsNot Nothing Then '有効なログインIDである時、職員基本情報の取得を行う。
                LoginAppData.SexType = staffbase.MSTB_SexType
                LoginAppData.BirthDate = CDate(staffbase.MSTB_BirthDate)
                'LoginAppData.FirstName = staffbase.MSTB_FirstName
                'LoginAppData.MiddleName = staffbase.MSTB_MiddleName
                'LoginAppData.LastName = staffbase.MSTB_LastName
                'LoginAppData.KanaFirstName = staffbase.MSTB_FirstNameKana
                'LoginAppData.KanaMiddleName = staffbase.MSTB_MiddleNameKana
                'LoginAppData.KanaLastName = staffbase.MSTB_LastNameKana
                LoginAppData.RitireDate = Common.NVL(staffbase.MSTB_RetireDate, AsamaConst.UndefDateMin)
                LoginAppData.EnterDate = Common.NVL(staffbase.MSTB_EnterDate, AsamaConst.UndefDateMin)
                'If staffbase.MSTB_ValidType = "2" Then
                '    LoginAppData.HasError = True
                '    Return LoginAppData
                'End If
            Else
                '存在しないログインIDです。
                LoginAppData.HasError = True
                Return LoginAppData
            End If

            ''******************* PASSWORD ********************
            ''最新LogNoを取得
            'maxlogno = (From e As M_StaffPassword In db.M_StaffPassword
            '            Where e.MSTP_StaffID = LoginAppData.StaffID And
            '                e.MSTP_FacilityID = LoginAppData.FacilityID
            '            Select e.MSTP_LogNo).Max

            '上記最新LogNoの要素を取得
            'Dim staffPassword = (From e As M_StaffPassword In db.M_StaffPassword
            '                     Where e.MSTP_StaffID = LoginAppData.StaffID And
            '                     e.MSTP_LogNo = (maxlogno) And
            '                     e.MSTP_FacilityID = LoginAppData.FacilityID
            '                     Select e).FirstOrDefault
            Dim staffPassword = (From e As M_StaffPassword In db.M_StaffPassword
                                 Where e.MSTP_StaffID = LoginAppData.StaffID And
                                 e.MSTP_LogNo = 0
                                 Select e).FirstOrDefault

            If IsNothing(staffPassword.MSTP_Password) Then
                '存在しないログインIDです。
                LoginAppData.HasError = True
                Return LoginAppData
            End If

            '入力許容回数のチェック
            If LoginAppData.LoginCount = intPasswordInputAllowTimes Then
                isAllowTime = False
            End If

            If isAllowTime Then
                If staffPassword.MSTP_Password.Equals(GetSha256(LoginAppData.Password)) Then
                    'ここでログイン情報をゲットする

                    '有効期限切れのチェック
                    If DateTime.Compare(staffPassword.MSTP_UpdateDate.AddDays(intPasswordValidDays), DateTime.Now) < 0 Then
                        isValidDate = False
                    End If


                    '有効期限切れの判定を行う
                    If isValidDate Then

                    Else
                        '2:有効期限切れ
                        LoginAppData.HasError = True
                    End If
                Else
                    LoginAppData.LoginCount += 1
                    '3:ログインユーザ、パスワード入力ミス
                    LoginAppData.HasError = True
                End If

                ''職種コードの取得

                ''JOBコードでGroupBy
                'Dim grp = From e As M_StaffJobType In db.M_StaffJobType
                '          Group By e.MSJT_JobCode, e.MSJT_FacilityID, e.MSJT_StaffID, e.MSJT_LogNo
                '                  Into jobgroup = Group
                '          Select New With {.jobcode = MSJT_JobCode, .facilityid = MSJT_FacilityID, .staffid = MSJT_StaffID, .maxlogno = jobgroup.Max(Function(x) x.MSJT_LogNo)}

                'Dim query = From e As M_StaffJobType In db.M_StaffJobType
                '            From g In grp
                '            Where e.MSJT_FacilityID = g.facilityid And
                '                    e.MSJT_StaffID = g.staffid And
                '                    e.MSJT_JobCode = g.jobcode And
                '                    e.MSJT_LogNo = g.maxlogno And
                '                    e.MSJT_StaffID = LoginAppData.StaffID And
                '                    e.MSJT_FacilityID = LoginAppData.FacilityID And
                '                    e.MSJT_DelFlag = 0
                '            Select e

                'If query.Count > 0 Then
                '    Dim arr As New ArrayList
                '    For Each e In query
                '        arr.Add(DirectCast(e.MSJT_JobCode, String))
                '    Next
                '    LoginAppData.JobCodes = CType(arr.ToArray(GetType(String)), String())
                'End If
            Else
                '4:ログイン許容回数越え
                LoginAppData.HasError = True
            End If
        Catch ex As Exception
            Dim aryMsg As New ArrayList
            aryMsg.Add(ex.Message)
            LoginAppData.HasError = True
            Return LoginAppData
        Finally
        End Try
        Return LoginAppData
    End Function

    ''' <summary>
    ''' GetControlInfo
    ''' </summary>
    ''' <remarks>
    ''' 概要： システム制御情報の取得する。
    ''' 【履歴】
    '''  日付    担当    Ver. チケット# 変更理由
    '''  ----------------------------------------------------------------
    ''' </remarks>
    Private Function GetControlInfo(strXMLControlInfo As String, appData As LoginAD) As IReadOnlyDictionary(Of String, String)
        Dim controlInfoDictionary As Dictionary(Of String, String) = New Dictionary(Of String, String)
        Try
            Dim xmlElement As XElement = XElement.Parse(strXMLControlInfo)
            If Not IsNothing(xmlElement) Then
                Dim result = From xEl In xmlElement...<PasswordInputAllowTimes> Select xEl
                For Each element As XElement In result
                    controlInfoDictionary.Add(element.Name.ToString(), element.@Value)
                Next element
                result = From xEl In xmlElement...<PasswordValidDays> Select xEl
                For Each element As XElement In result
                    controlInfoDictionary.Add(element.Name.ToString(), element.@Value)
                Next element
            End If
        Catch ex As Exception
            Dim aryMsg As New ArrayList
            aryMsg.Add(ex.Message)
        Finally
        End Try
        Return controlInfoDictionary
    End Function

#Region "ハッシュ化"
    ''' <summary>'
    ''' 文字列から SHA256 のハッシュ値を取得'
    ''' </summary>'
    Public Shared Function GetSha256(ByVal target As String) As String
        Try
            Dim mySHA256 As SHA256 = SHA256Managed.Create()
            Dim byteValue As Byte() = Encoding.UTF8.GetBytes(target)
            Dim hash As Byte() = mySHA256.ComputeHash(byteValue)

            Dim buf As StringBuilder = New StringBuilder()

            For i = 0 To hash.Length - 1
                buf.AppendFormat("{0:x2}", hash(i))
            Next

            Return buf.ToString()
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function
#End Region

    ''' <summary>
    ''' アクセス権限取得
    ''' </summary>
    ''' <param name="strXMLAccessAuth">アクセス権限XMLの文字列</param>
    ''' <returns>IReadOnlyDictionary</returns>
    ''' <remarks>
    ''' 概要：　アクセス権限の文字列を読み込み、読み込んだアクセス権限をIReadOnlyDictionaryに保持する。
    ''' 【履歴】
    ''' 　日付	　　担当	　　Ver.	チケット#	変更理由
    ''' ----------------------------------------------------------------
    ''' </remarks>
    Private Function GetAccessAuth(strXMLAccessAuth As String) As Dictionary(Of String, String)
        Dim accessAuthDictionary As Dictionary(Of String, String) = New Dictionary(Of String, String)
        Try
            Dim xmlElement As XElement = XElement.Parse(strXMLAccessAuth)
            If Not IsNothing(xmlElement) Then
                Dim xmlElementList As IEnumerable(Of XElement) = From xEl In xmlElement...<Function> Select xEl
                For Each element As XElement In xmlElementList
                    If accessAuthDictionary.ContainsKey(element.@ID.ToString()) Then
                        accessAuthDictionary(element.@ID.ToString()) = element.@authority.ToString()
                    Else
                        accessAuthDictionary.Add(element.@ID.ToString(), element.@authority.ToString())
                    End If
                Next
            End If
        Catch
        End Try
        Return accessAuthDictionary
    End Function

    '''' <summary>
    '''' <para>現在保持している情報の現任種別を変更して、履歴番号を採番してInsertする</para>
    '''' <para>（編集履歴を保持するためUpdateは行いません）</para>
    '''' <para>ValidType=0(有効)ならば2(停止)のレコードを物理削除。但し変更前が0(有効),1(退職)の場合はエラー(HasError=True)</para>
    '''' <para>ValidType=1(退職)ならば現在の有効期間のまま現任種別を1で更新</para>
    '''' <para>ValidType=2(停止)ならば有効期間min-maxで停止レコードをInsert。但し変更前が2(停止)の場合はエラー(HasError=True)</para>
    '''' </summary>
    '''' <param name="db">context</param>
    '''' <param name="LoginAppData">エラー受渡し用AsamaADBase</param>
    '''' <param name="strValidType">現任種別 0:有効、1:退職、2:停止</param>
    '''' <returns>AsamaADBase</returns>
    '''' <remarks></remarks>
    'Public Function UpdateValidType(ByVal db As AsamaEntities, LoginAppData As LoginAD, ByVal strValidType As String) As Boolean
    '    Try
    '        Dim mdl As M_StaffBase = (From e As M_StaffBase In db.M_StaffBase
    '                                  Where e.MSTB_StaffID = LoginAppData.StaffID
    '                                  Select e
    '                                    ).FirstOrDefault
    '        If mdl Is Nothing Then Throw New Exception("対象データがありません")

    '        '変更前データチェック
    '        If ((mdl.MSTB_ValidType = "0" Or mdl.MSTB_ValidType = "1") And strValidType = "0") OrElse
    '            (mdl.MSTB_ValidType = "2" And strValidType = "2") Then
    '            Throw New Exception("ValidTypeエラー")
    '        End If

    '        Select Case strValidType
    '            Case "0"    '有効
    '                '停止状態のデータを物理削除

    '                db.M_StaffBase.Remove(mdl)

    '            Case "1"    '退職
    '                '指定された値で現認種別を変更

    '                '更新
    '                mdl.MSTB_ValidType = strValidType
    '                mdl.MSTB_UpdateDate = Now()
    '                db.Entry(mdl).State = EntityState.Modified
    '                db.SaveChanges()

    '            Case "2"    '停止
    '                '更新
    '                'appData = SetData(appData)
    '                Dim newmdl As New M_StaffBase
    '                newmdl.MSTB_StaffID = mdl.MSTB_StaffID
    '                newmdl.MSTB_ValidType = strValidType
    '                newmdl.MSTB_ValidDateFrom = AsamaConst.UndefDateMin
    '                newmdl.MSTB_ValidDateTo = AsamaConst.UndefDateMax
    '                db.M_StaffBase.Add(newmdl)
    '                db.SaveChanges()
    '            Case Else

    '        End Select

    '    Catch ex As Exception

    '    End Try

    '    '更新
    '    Return True
    'End Function

#End Region

End Class
