'*********************************************************
'*	システム名	：	Aloe
'*	ファイル名	：	XMLControlInfo
'*	概要		：	XML制御情報クラス
'*
'*	Copyright  (c) 2014-2017 Medis Co., Ltd.
'*
'*	【履歴】
'*　日付	　担当		Ver.	チケット#	変更理由
'* ----------------------------------------------------------------
'*　2017/07/04	KSI中村	2.3.82	#--------	新規作成　Aloe.clsXMLControlInfoクラスよりコピー
'******************************************************************
Imports System.Collections.Specialized

''' <summary>
''' ［制御マスタ］の設定情報
''' </summary>
''' <remarks></remarks>
Public Class XMLControlInfo

    Private Const ATTRIBUTE_DISP As String = "Disp"
    Private Const ATTRIBUTE_FUNC As String = "Func"
    Private Const ATTRIBUTE_ID As String = "ID"
    Private Const ATTRIBUTE_AUTH As String = "authority"
    Private Const TAG_MENU As String = "Menu"
    Private Const TAG_AUTH As String = "Function"

    '******************************************************************
    '*	システム名	：	Aloe
    '*	ファイル名	：	KeyData
    '*	概要		：	制御情報取得用キーデータクラス
    '*
    '*	Copyright  (c) 2014-2015 Medis Co., Ltd.
    '*
    '*	【履歴】
    '*　日付	　　担当		Ver.	チケット#	変更理由
    '* ----------------------------------------------------------------
    '*　2014/12/25	FSI 山口	0.0.1	#XXXXXXXX	新規作成
    '******************************************************************
    Private Class KeyData

        'Public FacilityID As String
        Public GroupCode As String
        Public JobCode As String()
        Public CommonJobCode As String = "0000000"
        Public StaffID As String
        Public DeputyGroupCode As String
        Public DeputyJobCode As String
        Public DeputyCommonJobCode As String = "0000000"
        Public DeputyStaffID As String

    End Class
    '******************************************************************
    '*	システム名	：	Aloe
    '*	ファイル名	：	ConfigXMLData
    '*	概要		：	XML設定情報格納クラス
    '*
    '*	Copyright  (c) 2014-2015 Medis Co., Ltd.
    '*
    '*	【履歴】
    '*　日付	　　担当		Ver.	チケット#	変更理由
    '* ----------------------------------------------------------------
    '*　2014/12/25	FSI 山口	0.0.1	#XXXXXXXX	新規作成
    '******************************************************************
    Private Class ConfigXMLData

        Public xelElement As XElement
        Public xelElementList As IEnumerable(Of XElement)

    End Class


    '''' <summary>
    '''' 制御情報取得(アクセス権限)
    '''' </summary>
    '''' <param name="clsAuthorityInfo">アクセス権限返却用クラス</param>
    '''' <param name="strFunctionID">機能ID</param>
    '''' <returns>Integer</returns>
    '''' <remarks>
    '''' 概要：制御Gマスタおよび制御マスタのアクセス権限情報を取得する。
    ''''       取得後はAloeGeneralDataへの制御情報格納を行う。
    ''''       その後アクセス権限情報のマージ処理を行う。
    '''' 【履歴】
    '''' 　日付	　　担当	　　Ver.	チケット#	変更理由
    '''' ----------------------------------------------------------------
    '''' 2015/06/02	FSI 山口	0.0.1	#XXXXXXXX	新規作成
    '''' 2016/04/02  M.Miyoshi   2.0.15  #5814　　　 委任マスタに渡す値が逆だったので改修
    '''' 2016/04/08  M.Miyoshi   2.0.15  #5856       委任時の判断が逆なので修正
    '''' </remarks>
    'Public Function GetXMLAccessAuth(db As AloeEntities,
    '                                 AloeGeneralData As AloeGeneralData(Of XElement),
    '                                 strFacilityId As String,
    '                                 strJobCode As String(),
    '                                 strStaffId As String,
    '                                 ByRef clsAuthorityInfo As AuthorityInfo,
    '                                 ByVal strFunctionID As String) As Integer

    '    GetXMLAccessAuth = 1

    '    Dim arrConfigTag As New ArrayList
    '    Dim arrAttribute As New ArrayList

    '    Try
    '         If IsNothing(strFunctionID) = True OrElse String.IsNullOrEmpty(strFunctionID) = True Then
    '            Dim intRet As Integer = 0
    '            'Dim clsLogMessage As New LogMessage
    '            Dim arrMessage As New ArrayList
    '            arrMessage.Add("機能IDが未指定")
    '            'clsLogMessage.OutputLogMessage(intRet, strFunctionID, "90000002", "ログイン職員情報と機能IDの存在チェック", "", arrMessage)
    '            Exit Function
    '        End If

    '        'AloeGeneralDataより施設IDを取得
    '        Dim clsKeyData As New KeyData
    '        clsKeyData.FacilityID = strFacilityId
    '        clsKeyData.JobCode = strJobCode
    '        clsKeyData.StaffID = strStaffId

    '        'アクセス権限取得用のタグと属性を設定
    '        arrConfigTag.Add("Functions")
    '        arrConfigTag.Add("Function")
    '        arrAttribute.Add("ID")
    '        arrAttribute.Add("authority")
    '        Dim clsConfigXMLOutput As New ConfigXMLData

    '        'エラー判定用アプリケーションデータクラスベース、
    '        '制御Gマスタ取得用変数(職種共通とログイン職員の職種)
    '        '制御マスタ取得用変数(職種共通とログイン職員の職種)
    '        'Dim clsAloeADBase As New AloeADBase
    '        Dim clsConfigXMLGroupJob As New ConfigXMLData
    '        Dim clsConfigXMLGroupCommon As New ConfigXMLData
    '        Dim clsConfigXMLDataJob As New ConfigXMLData
    '        Dim clsConfigXMLDataCommon As New ConfigXMLData

    '        If AloeGeneralData.ContainsKey(AloeFunctionID.AccessAuthority) = False Then

    '            '制御Gマスタ情報と制御マスタ情報の制御情報取得
    '            If GetConfigControl(db, clsConfigXMLGroupJob, clsConfigXMLGroupCommon,
    '                                clsConfigXMLDataJob, clsConfigXMLDataCommon,
    '                                clsKeyData.JobCode, clsKeyData.CommonJobCode,
    '                                AloeFunctionID.AccessAuthority, arrConfigTag, arrAttribute, clsKeyData.FacilityID) <> 0 Then
    '                GetXMLAccessAuth = 2
    '                Exit Function
    '            End If

    '            '職員制御情報を取得
    '            Dim clsConfigXMLStaff As New ConfigXMLData

    '            Dim query = From e As M_StaffControl In db.M_StaffControl
    '                        Where e.MSTC_FacilityID = clsKeyData.FacilityID And
    '                            e.MSTC_FunctionID = AloeFunctionID.AccessAuthority And
    '                            clsKeyData.JobCode.Contains(e.MSTC_JobCode) And
    '                            e.MSTC_StaffID = clsKeyData.StaffID
    '                        Select e

    '            For Each e In query
    '                If String.IsNullOrEmpty(e.MSTC_ControlInfo) = False Then
    '                    Dim strStaff As String = e.MSTC_ControlInfo
    '                    clsConfigXMLStaff.xelElement = XElement.Parse(strStaff)
    '                    '職員制御情報とマージ
    '                    If MergeConfigXML(clsConfigXMLGroupCommon, clsConfigXMLStaff, arrConfigTag, arrAttribute) <> 0 Then
    '                        GetXMLAccessAuth = 2
    '                        Exit Function
    '                    End If
    '                End If
    '            Next

    '            clsConfigXMLOutput = clsConfigXMLGroupCommon
    '            'ジェネラルデータにセット
    '            AloeGeneralData.Item(AloeFunctionID.AccessAuthority) = clsConfigXMLGroupCommon.xelElement
    '        Else
    '            'ジェネラルデータからセット
    '            clsConfigXMLOutput.xelElement = AloeGeneralData.Item(AloeFunctionID.AccessAuthority)
    '        End If

    '        '設定値抽出
    '        If ReadConfigXmlData(clsAuthorityInfo, clsConfigXMLOutput, arrConfigTag, arrAttribute, strFunctionID) <> 0 Then
    '            GetXMLAccessAuth = 2
    '            Exit Function
    '        End If

    '    Catch ex As Exception

    '        Dim clsLogMessage As New LogMessage
    '        Dim intRet As Integer
    '        Dim strTag As String = "タグ「"
    '        For intTagCount As Integer = 0 To arrConfigTag.Count - 1
    '            strTag = strTag & arrConfigTag.Item(intTagCount).ToString & ","
    '        Next
    '        strTag = strTag.Substring(0, strTag.Length - 1) & "」"
    '        Dim strAttribute As String = "属性「"
    '        For intAttributeCount As Integer = 0 To arrAttribute.Count - 1
    '            strAttribute = strAttribute & arrAttribute.Item(intAttributeCount).ToString & ","
    '        Next
    '        strAttribute = strAttribute.Substring(0, strAttribute.Length - 1) & "」"
    '        Dim arrMessage As New ArrayList
    '        arrMessage.Add("制御マスタ")
    '        clsLogMessage.OutputLogMessage(intRet, strFunctionID, AloeConst.MSGID_30000002, "制御情報取得(アクセス権限)", ex.StackTrace(), arrMessage, strTag & " " & strAttribute)
    '        GetXMLAccessAuth = 2
    '        Exit Function

    '    End Try

    '    GetXMLAccessAuth = 0

    'End Function

    ''' <summary>
    ''' 制御Gマスタおよび制御マスタより制御情報を取得
    ''' </summary>
    ''' <param name="clsConfigXMLGroupJob">制御Gマスタ用設定値格納クラス(特定職種)</param>
    ''' <param name="clsConfigXMLGroupCommon">制御Gマスタ用設定値格納クラス(共通職種)</param>
    ''' <param name="clsConfigXMLFacilityJob">制御マスタ用設定値格納クラス(特定職種)</param>
    ''' <param name="clsConfigXMLFacilityCommon">制御マスタ用設定値格納クラス(共通職種)</param>
    ''' <param name="strJobCode">職種コード</param>
    ''' <param name="strCommonJobCode">共通職種コード</param>
    ''' <param name="strFunctionID">機能ID</param>
    ''' <param name="arrConfigTag">制御情報のタグ情報</param>
    ''' <param name="arrAttribute">制御情報の属性情報</param>
    ''' <returns>Integer</returns>
    ''' <remarks>
    ''' 概要：制御Gマスタおよび制御マスタの制御情報を取得する。
    '''       取得後はAloeGeneralDataへの制御情報格納を行う。
    '''       その後制御情報のマージ処理を行う。
    ''' 【履歴】
    ''' 　日付	　　担当	　　Ver.	チケット#	変更理由
    ''' ----------------------------------------------------------------
    ''' </remarks>
    Private Overloads Function GetConfigControl(db As AloeEntities, ByRef clsConfigXMLGroupJob As ConfigXMLData,
                                                ByRef clsConfigXMLGroupCommon As ConfigXMLData,
                                                ByRef clsConfigXMLFacilityJob As ConfigXMLData,
                                                ByRef clsConfigXMLFacilityCommon As ConfigXMLData,
                                                ByVal strJobCode As String(),
                                                ByVal strCommonJobCode As String,
                                                ByVal strFunctionID As String,
                                                ByVal arrConfigTag As ArrayList,
                                                ByVal arrAttribute As ArrayList,
                                                ByVal strFacilityID As String) As Integer

        GetConfigControl = 1

        Try

            ''制御Gマスタ情報を取得(特定の職種コード)
            'Dim clsControlGroup As GM_Control
            'If strJobCode.Count > 0 Then
            '    clsControlGroup = (From e As GM_Control In db.GM_Control
            '                       Where strJobCode.Contains(e.GCTL_JobCode) And
            '                        e.GCTL_FunctionID = strFunctionID
            '                       Select e).FirstOrDefault

            '    If clsControlGroup IsNot Nothing Then
            '        Dim strControlGroup As String = clsControlGroup.GCTL_ControlInfo
            '        If String.IsNullOrEmpty(strControlGroup) = False Then
            '            clsConfigXMLGroupJob.xelElement = XElement.Parse(strControlGroup)
            '        End If
            '    End If
            'End If

            ''制御Gマスタ情報を取得(職種共通コード)
            'clsControlGroup = (From e As GM_Control In db.GM_Control
            '                   Where e.GCTL_JobCode = strCommonJobCode And
            '                        e.GCTL_FunctionID = strFunctionID
            '                   Select e).FirstOrDefault
            'If clsControlGroup IsNot Nothing Then
            '    Dim strControlGroupCommon As String = clsControlGroup.GCTL_ControlInfo
            '    If String.IsNullOrEmpty(strControlGroupCommon) = False Then
            '        clsConfigXMLGroupCommon.xelElement = XElement.Parse(strControlGroupCommon)
            '    End If
            'End If

            ''制御マスタ情報を取得(特定の職種コード)
            'Dim clsControlData As M_Control
            'If strJobCode.Count > 0 Then
            '    clsControlData = (From e As M_Control In db.M_Control
            '                      Where e.MCTL_FacilityID = strFacilityID And
            '                         strJobCode.Contains(e.MCTL_JobCode) And
            '                         e.MCTL_FunctionID = strFunctionID
            '                      Select e).FirstOrDefault

            '    If clsControlData IsNot Nothing Then
            '        Dim strControlData As String = clsControlData.MCTL_ControlInfo
            '        If String.IsNullOrEmpty(strControlData) = False Then
            '            clsConfigXMLFacilityJob.xelElement = XElement.Parse(strControlData)
            '        End If
            '    End If
            'End If

            ''制御マスタ情報を取得(職種共通コード)
            'clsControlData = (From e As M_Control In db.M_Control
            '                  Where e.MCTL_FacilityID = strFacilityID And
            '                     e.MCTL_JobCode = strCommonJobCode And
            '                     e.MCTL_FunctionID = strFunctionID
            '                  Select e).FirstOrDefault

            'If clsControlData Is Nothing Then
            '    GetConfigControl = 2
            '    Exit Function
            'End If
            'If clsControlData IsNot Nothing Then
            '    Dim strControlDataCommon As String = clsControlData.MCTL_ControlInfo
            '    If String.IsNullOrEmpty(strControlDataCommon) = False Then
            '        clsConfigXMLFacilityCommon.xelElement = XElement.Parse(strControlDataCommon)
            '    End If
            'End If
            'Todo :AloeGeneralDataへの制御情報設定

            ''制御Gマスタの職種毎設定情報と制御Gマスタの共通職種設定情報のマージ
            'If MergeConfigXML(clsConfigXMLGroupCommon, clsConfigXMLGroupJob, arrConfigTag, arrAttribute, strFunctionID) <> 0 Then
            '    GetConfigControl = 2
            '    Exit Function
            'End If

            ''制御マスタの職種毎設定情報と制御マスタの共通職種設定情報のマージ
            'If IsNothing(clsConfigXMLFacilityCommon.xelElement) = False And IsNothing(clsConfigXMLFacilityJob.xelElement) = False Then
            '    If MergeConfigXML(clsConfigXMLFacilityCommon, clsConfigXMLFacilityJob, arrConfigTag, arrAttribute, strFunctionID) <> 0 Then
            '        GetConfigControl = 2
            '        Exit Function
            '    End If
            'End If

            ''制御Gマスタと制御マスタ情報設定情報のマージ
            'If MergeConfigXML(clsConfigXMLGroupCommon, clsConfigXMLFacilityCommon, arrConfigTag, arrAttribute, strFunctionID) <> 0 Then
            '    GetConfigControl = 2
            '    Exit Function
            'End If

        Catch ex As Exception

            Dim clsLogMessage As New LogMessage
            Dim intRet As Integer
            Dim strTag As String = "タグ「"
            For intTagCount As Integer = 0 To arrConfigTag.Count - 1
                strTag = strTag & arrConfigTag.Item(intTagCount).ToString & ","
            Next
            strTag = strTag.Substring(0, strTag.Length - 1) & "」"
            Dim strAttribute As String = "属性「"
            For intAttributeCount As Integer = 0 To arrAttribute.Count - 1
                strAttribute = strAttribute & arrAttribute.Item(intAttributeCount).ToString & ","
            Next
            strAttribute = strAttribute.Substring(0, strTag.Length - 1) & "」"
            Dim arrMessage As New ArrayList
            arrMessage.Add("制御マスタ")
            clsLogMessage.OutputLogMessage(intRet, strFunctionID, AloeConst.MSGID_30000002, "制御Gマスタおよび制御マスタより制御情報を取得", ex.StackTrace(), arrMessage, strTag & " " & strAttribute)
            GetConfigControl = 2
            Exit Function

        End Try

        GetConfigControl = 0

    End Function

    ''' <summary>
    ''' 制御情報のマージ処理
    ''' </summary>
    ''' <param name="clsConfigXMLTarget">マージ先設定値格納クラス</param>
    ''' <param name="clsConfigXMLMerge">マージ元設定値格納クラス</param>
    ''' <param name="arrConfigTag">制御情報のタグ情報</param>
    ''' <param name="arrAttribute">制御情報の属性情報</param>
    ''' <param name="strFunctionID">機能ID</param>
    ''' <returns>Integer</returns>
    ''' <remarks>
    ''' 概要：制御Gマスタおよび制御マスタの制御情報を取得する。
    '''       取得後はAloeGeneralDataへの制御情報格納を行う。
    '''       その後制御情報のマージ処理を行う。
    ''' 【履歴】
    ''' 　日付	　　担当	　　Ver.	チケット#	変更理由
    ''' ----------------------------------------------------------------
    ''' </remarks>
    Private Overloads Function MergeConfigXML(ByRef clsConfigXMLTarget As ConfigXMLData,
                                              ByRef clsConfigXMLMerge As ConfigXMLData,
                                              ByVal arrConfigTag As ArrayList,
                                              ByVal arrAttribute As ArrayList,
                                              ByVal strFunctionID As String) As Integer
        MergeConfigXML = 1

        Try

            '片方値なしならばそのまま返す
            If IsNothing(clsConfigXMLMerge.xelElement) = True Then
                MergeConfigXML = 0
                Exit Function
            End If

            'マージ用XMLデータが2つ存在する場合はマージ
            If Not IsNothing(clsConfigXMLTarget.xelElement) Then

                'タグで指定したXMLデータの読み込み
                If ReadXMLElementData(clsConfigXMLTarget.xelElementList,
                                      clsConfigXMLTarget.xelElement,
                                      arrConfigTag) <> 0 Then
                    MergeConfigXML = 2
                    Exit Function
                End If

                'ループが最後まで行かない場合を考慮し、-1より開始
                Dim intDataCnt As Integer = -1
                'タグで指定したXMLデータの読み込み
                If ReadXMLElementData(clsConfigXMLMerge.xelElementList,
                                          clsConfigXMLMerge.xelElement,
                                          arrConfigTag) <> 0 Then
                    MergeConfigXML = 2
                    Exit Function
                End If
                'マージ対象データが存在する場合はタグ全体で置き換え
                If clsConfigXMLMerge.xelElementList.Count > 0 Then
                    Dim xelTargetNode As XElement = Nothing
                    Dim intDataCount As Integer
                    For i As Integer = 0 To 1 Step 0
                        For j As Integer = 0 To arrConfigTag.Count - 1
                            If j = 0 Then
                                intDataCount = clsConfigXMLTarget.xelElement.Elements(arrConfigTag(j).ToString).Count
                                xelTargetNode = DirectCast(clsConfigXMLTarget.xelElement.Elements(arrConfigTag(j).ToString)(i), XElement)
                            Else
                                intDataCount = xelTargetNode.Elements(arrConfigTag(j).ToString).Count
                                xelTargetNode = DirectCast(xelTargetNode.Elements(arrConfigTag(j).ToString)(i), XElement)
                            End If
                        Next
                        '最後のノードは置き換え、その他は削除（でタグ置き換えを実現）
                        If intDataCount = 1 Then
                            xelTargetNode.ReplaceWith(clsConfigXMLMerge.xelElementList)
                            Exit For
                        Else
                            xelTargetNode.ReplaceWith("")
                        End If
                    Next
                End If
                'End If

            Else

                'マージ用XMLを返す
                clsConfigXMLTarget = clsConfigXMLMerge

            End If

        Catch ex As Exception

            Dim clsLogMessage As New LogMessage
            Dim intRet As Integer
            Dim strTag As String = "タグ「"
            For intTagCount As Integer = 0 To arrConfigTag.Count - 1
                strTag = strTag & arrConfigTag.Item(intTagCount).ToString & ","
            Next
            strTag = strTag.Substring(0, strTag.Length - 1) & "」"
            Dim strAttribute As String = "属性「"
            For intAttributeCount As Integer = 0 To arrAttribute.Count - 1
                strAttribute = strAttribute & arrAttribute.Item(intAttributeCount).ToString & ","
            Next
            strAttribute = strAttribute.Substring(0, strTag.Length - 1) & "」"
            Dim arrMessage As New ArrayList
            arrMessage.Add("制御マスタ")
            clsLogMessage.OutputLogMessage(intRet, strFunctionID, AloeConst.MSGID_30000002, "制御情報のマージ処理", ex.StackTrace(), arrMessage, strTag & " " & strAttribute)
            MergeConfigXML = 2
            Exit Function

        End Try

        MergeConfigXML = 0

    End Function

    ''' <summary>
    ''' 制御情報のマージ処理(アクセス権限用)
    ''' </summary>
    ''' <param name="clsConfigXMLTarget">マージ先設定値格納クラス</param>
    ''' <param name="clsConfigXMLMerge">マージ元設定値格納クラス</param>
    ''' <param name="arrConfigTag">制御情報のタグ情報</param>
    ''' <param name="arrAttribute">制御情報の属性情報</param>
    ''' <returns>Integer</returns>
    ''' <remarks>
    ''' 概要：制御Gマスタおよび制御マスタの制御情報を取得する。
    '''       取得後はAloeGeneralDataへの制御情報格納を行う。
    '''       その後制御情報のマージ処理を行う。
    ''' 【履歴】
    ''' 　日付	　　担当	　　Ver.	チケット#	変更理由
    ''' ----------------------------------------------------------------
    ''' 2014/12/22	FSI 山口	0.0.1	#XXXXXXX
    ''' </remarks>
    Private Overloads Function MergeConfigXML(ByRef clsConfigXMLTarget As ConfigXMLData,
                                              ByRef clsConfigXMLMerge As ConfigXMLData,
                                              ByVal arrConfigTag As ArrayList,
                                              ByVal arrAttribute As ArrayList) As Integer

        MergeConfigXML = 1

        Try

            '片方値なしならばそのまま返す
            If IsNothing(clsConfigXMLMerge.xelElement) = True Then
                MergeConfigXML = 0
                Exit Function
            End If

            'マージ用XMLデータが2つ存在する場合はマージ
            If Not IsNothing(clsConfigXMLTarget.xelElement) Then

                'タグで指定したXMLデータの読み込み
                If ReadXMLElementData(clsConfigXMLTarget.xelElementList,
                                      clsConfigXMLTarget.xelElement,
                                      arrConfigTag) <> 0 Then
                    MergeConfigXML = 2
                    Exit Function
                End If

                'ループが最後まで行かない場合を考慮し、-1より開始
                Dim intDataCnt As Integer = -1
                'XML設定ファイルのレコード単位ループ
                For Each xelElementGroup As XElement In clsConfigXMLTarget.xelElementList

                    intDataCnt += 1

                    'タグで指定したXMLデータの読み込み
                    If ReadXMLElementData(clsConfigXMLMerge.xelElementList,
                                          clsConfigXMLMerge.xelElement,
                                          arrConfigTag) <> 0 Then
                        MergeConfigXML = 2
                        Exit Function
                    End If
                    If IsNothing(clsConfigXMLMerge.xelElementList) = True Then
                        Continue For
                    End If

                    'アクセス権限情報の設定値を上書き
                    If AuthOverWriteValue(clsConfigXMLTarget, clsConfigXMLMerge,
                                          xelElementGroup, arrAttribute, intDataCnt) <> 0 Then
                        MergeConfigXML = 2
                        Exit Function
                    End If

                Next

            Else

                'マージ用XMLを返す
                clsConfigXMLTarget = clsConfigXMLMerge

            End If

        Catch ex As Exception

            Dim clsLogMessage As New LogMessage
            Dim intRet As Integer
            Dim strTag As String = "タグ「"
            For intTagCount As Integer = 0 To arrConfigTag.Count - 1
                strTag = strTag & arrConfigTag.Item(intTagCount).ToString & ","
            Next
            strTag = strTag.Substring(0, strTag.Length - 1) & "」"
            Dim strAttribute As String = "属性「"
            For intAttributeCount As Integer = 0 To arrAttribute.Count - 1
                strAttribute = strAttribute & arrAttribute.Item(intAttributeCount).ToString & ","
            Next
            strAttribute = strAttribute.Substring(0, strTag.Length - 1) & "」"
            Dim arrMessage As New ArrayList
            arrMessage.Add("制御マスタ")
            clsLogMessage.OutputLogMessage(intRet, "AUTH", AloeConst.MSGID_30000002, "制御情報のマージ処理", ex.StackTrace(), arrMessage, strTag & " " & strAttribute)
            MergeConfigXML = 2
            Exit Function

        End Try

        MergeConfigXML = 0

    End Function


    ''' <summary>
    ''' メニュー表示制御情報の設定値上書き処理
    ''' </summary>
    ''' <param name="clsConfigXMLSource">制御マスタ用設定値格納クラス(マージ先)</param>
    ''' <param name="clsConfigXMLMerge">制御マスタ用設定値格納クラス(マージ元)</param>
    ''' <param name="xelElementGroup">読み込み中の制御Gマスタ設定値(行)</param>
    ''' <param name="arrAttribute">制御情報の属性情報</param>
    ''' <param name="intDataCnt">制御Gマスタ制御情報のデータカウント</param>
    ''' <param name="strAttributeKey">キーとなる属性値</param>
    ''' <returns>Integer</returns>
    ''' <remarks>
    ''' 概要：キーとなる属性値が一致する場合、制御情報の上書き処理を行う
    ''' 【履歴】
    ''' 　日付	　　担当	　　Ver.	チケット#	変更理由
    ''' ----------------------------------------------------------------
    ''' 2014/12/22	FSI 山口	0.0.1	#XXXXXXXX	新規作成
    ''' </remarks>
    Private Function MenuOverWriteValue(ByRef clsConfigXMLSource As ConfigXMLData,
                                        ByRef clsConfigXMLMerge As ConfigXMLData,
                                        ByVal xelElementGroup As XElement,
                                        ByVal arrAttribute As ArrayList,
                                        ByVal intDataCnt As Integer,
                                        ByVal strAttributeKey As String,
                                        ByVal strFunctionID As String) As Integer

        MenuOverWriteValue = 1

        Try

            '該当する属性が存在する場合は上書き
            'マージする側のデータ件数
            Dim intMergeDataCount As Integer = -1
            For Each xelElementFacility As XElement In clsConfigXMLMerge.xelElementList
                intMergeDataCount = intMergeDataCount + 1
                'メニュー設定値については、Func属性の値が存在しない場合は次レコード読み込み
                If IsNothing(xelElementGroup.Attribute(ATTRIBUTE_FUNC)) = True Or
                    IsNothing(xelElementFacility.Attribute(ATTRIBUTE_FUNC)) = True Then

                    Continue For

                End If
                '属性キー（一致する場合は制御マスタの制御情報を優先して、値の入れ替え）
                If xelElementGroup.Attribute(strAttributeKey).Value =
                    xelElementFacility.Attribute(strAttributeKey).Value Then

                    Dim intLoopCnt2 As Integer
                    For intLoopCnt2 = 0 To arrAttribute.Count - 1
                        'グループXMLに属性が存在かつ施設XMLに属性が存在する場合は属性値更新、
                        'グループXMLに属性が存在かつ施設XMLに属性が存在しない場合は属性値削除、
                        'グループXMLに属性が存在しないかつ施設XMLに属性が存在しない場合は属性値追加のいずれかを行う。
                        '双方共に属性が存在しない場合は何もしない
                        If IsNothing(clsConfigXMLSource.xelElementList(intDataCnt).Attribute(arrAttribute(intLoopCnt2).ToString)) = False And
                            IsNothing(xelElementFacility.Attribute(arrAttribute(intLoopCnt2).ToString)) = False Then
                            clsConfigXMLSource.xelElementList(intDataCnt).Attribute(arrAttribute(intLoopCnt2).ToString).Value =
                                xelElementFacility.Attribute(arrAttribute(intLoopCnt2).ToString).Value
                        ElseIf IsNothing(clsConfigXMLSource.xelElementList(intDataCnt).Attribute(arrAttribute(intLoopCnt2).ToString)) = False And
                                IsNothing(xelElementFacility.Attribute(arrAttribute(intLoopCnt2).ToString)) = True Then
                            clsConfigXMLSource.xelElementList(intDataCnt).Attribute(arrAttribute(intLoopCnt2).ToString).Remove()
                        ElseIf IsNothing(clsConfigXMLSource.xelElementList(intDataCnt).Attribute(arrAttribute(intLoopCnt2).ToString)) = True And
                                IsNothing(xelElementFacility.Attribute(arrAttribute(intLoopCnt2).ToString)) = False Then
                            clsConfigXMLSource.xelElementList(intDataCnt).SetAttributeValue(arrAttribute(intLoopCnt2).ToString,
                                                                                           xelElementFacility.Attribute(arrAttribute(intLoopCnt2).ToString).Value)
                        End If

                    Next

                    Exit For

                End If

            Next

        Catch ex As Exception

            Dim clsLogMessage As New LogMessage
            Dim intRet As Integer
            Dim strAttribute As String = "属性「"
            For intAttributeCount As Integer = 0 To arrAttribute.Count - 1
                strAttribute = strAttribute & arrAttribute.Item(intAttributeCount).ToString & ","
            Next
            strAttribute = strAttribute.Substring(0, strAttribute.Length - 1) & "」"
            strAttribute = strAttribute & " strAttributeKey:" & strAttributeKey
            Dim arrMessage As New ArrayList
            arrMessage.Add("制御マスタ")
            clsLogMessage.OutputLogMessage(intRet, strFunctionID, AloeConst.MSGID_30000002, "メニュー表示制御情報の設定値上書き処理", ex.StackTrace(), arrMessage, strAttribute)
            MenuOverWriteValue = 2
            Exit Function

        End Try

        MenuOverWriteValue = 0

    End Function


    ' ''' <summary>
    ' ''' メニュー以外の表示制御情報の設定値上書き処理
    ' ''' </summary>
    ' ''' <param name="clsConfigXMLSource">制御マスタ用設定値格納クラス(マージ先)</param>
    ' ''' <param name="clsConfigXMLMerge">制御マスタ用設定値格納クラス(マージ元)</param>
    ' ''' <param name="arrAttribute">制御情報の属性情報</param>
    ' ''' <param name="intDataCnt">制御Gマスタ制御情報のデータカウント</param>
    ' ''' <returns>Integer</returns>
    ' ''' <remarks>
    ' ''' 概要：キーとなる属性値が一致する場合、制御情報の上書き処理を行う
    ' ''' 【履歴】
    ' ''' 　日付	　　担当	　　Ver.	チケット#	変更理由
    ' ''' ----------------------------------------------------------------
    ' ''' 2014/12/22	FSI 山口	0.0.1	#XXXXXXXX	新規作成
    ' ''' </remarks>
    'Private Function OtherOverWriteValue(ByRef clsConfigXMLSource As ConfigXMLData,
    '                                     ByRef clsConfigXMLMerge As ConfigXMLData,
    '                                     ByVal arrAttribute As ArrayList,
    '                                     ByVal intDataCnt As Integer,
    '                                     ByVal strFunctionID As String) As Integer

    '    OtherOverWriteValue = 1

    '    Try

    '        '該当する属性が存在する場合は上書き
    '        'マージする側のデータ件数
    '        Dim intMergeDataCount As Integer = -1



    '        'For Each xelElementFacility As XElement In clsConfigXMLMerge.xelElementList
    '        '    intMergeDataCount = intMergeDataCount + 1

    '        '    '属性キーが空の場合は末端のタグ全体で入れ替え(入れ替え後は処理を終える。マージ元の次のデータを読み込むため)
    '        '    If IsNothing(strAttributeKey) = True Then
    '        '        If xelElementGroup.Name = xelElementFacility.Name Then
    '        '            For i As Integer = 0 To arrAttribute.Count - 1
    '        '                '末端のタグが複数ある場合はマージ元と同じタグの入れ替えを行い、本メソッドを終了する
    '        '                If intDataCnt = intMergeDataCount Then
    '        '                    clsConfigXMLSource.xelElementList(intDataCnt).Attribute(arrAttribute(i).ToString).Value =
    '        '                        xelElementFacility.Attribute(arrAttribute(i).ToString).Value
    '        '                    'OverWriteValue = 0
    '        '                    'Exit Function
    '        '                End If
    '        '            Next
    '        '        End If
    '        '        'Continue For
    '        '    End If

    '        'Next

    '    Catch ex As Exception

    '        Dim clsLogMessage As New LogMessage
    '        Dim intRet As Integer
    '        clsLogMessage.OutputLogMessage(intRet, "", AloeConst.MSGID_30000002, "メニュー表示制御情報の設定値上書き処理", ex.StackTrace())
    '        OtherOverWriteValue = 2
    '        Exit Function

    '    End Try

    '    OtherOverWriteValue = 0

    'End Function

    ''' <summary>
    ''' アクセス権限制御情報の設定値上書き処理
    ''' </summary>
    ''' <param name="clsConfigXMLOverWrite">上書き先設定値格納クラス</param>
    ''' <param name="clsConfigXMLSource">上書き元設定値格納クラス</param>
    ''' <param name="xelElementOverWrite">読み込み中の上書き先マスタ設定値(行)</param>
    ''' <param name="arrAttribute">制御情報の属性情報</param>
    ''' <param name="intDataCnt">制御Gマスタ制御情報のデータカウント</param>
    ''' <returns>Integer</returns>
    ''' <remarks>
    ''' 概要：キーとなる属性値が一致する場合、制御情報の上書き処理を行う
    ''' 【履歴】
    ''' 　日付	　　担当	　　Ver.	チケット#	変更理由
    ''' ----------------------------------------------------------------
    ''' 2015/06/02	FSI 山口	0.0.1	#XXXXXXXX	新規作成
    ''' </remarks>
    Private Function AuthOverWriteValue(ByRef clsConfigXMLOverWrite As ConfigXMLData,
                                        ByRef clsConfigXMLSource As ConfigXMLData,
                                        ByVal xelElementOverWrite As XElement,
                                        ByVal arrAttribute As ArrayList,
                                        ByVal intDataCnt As Integer) As Integer

        AuthOverWriteValue = 1

        Try

            Dim exist As Boolean = False

            '該当する属性が存在する場合は上書き
            For Each xelElementSource As XElement In clsConfigXMLSource.xelElementList

                '値の入れ替え
                If xelElementOverWrite.Attribute(ATTRIBUTE_ID).Value =
                    xelElementSource.Attribute(ATTRIBUTE_ID).Value Then

                    clsConfigXMLOverWrite.xelElementList(intDataCnt).Attribute(ATTRIBUTE_AUTH).Value =
                                        xelElementSource.Attribute(ATTRIBUTE_AUTH).Value
                    exist = True
                End If

            Next

            If Not exist Then
                'なかったら挿入
                clsConfigXMLOverWrite.xelElementList(intDataCnt).Add(clsConfigXMLSource.xelElementList)
            End If



        Catch ex As Exception

            Dim clsLogMessage As New LogMessage
            Dim intRet As Integer
            Dim strAttribute As String = "属性「"
            For intAttributeCount As Integer = 0 To arrAttribute.Count - 1
                strAttribute = strAttribute & arrAttribute.Item(intAttributeCount).ToString & ","
            Next
            strAttribute = strAttribute.Substring(0, strAttribute.Length - 1) & "」"
            Dim arrMessage As New ArrayList
            arrMessage.Add("制御マスタ")
            clsLogMessage.OutputLogMessage(intRet, "AUTH", AloeConst.MSGID_30000002, "アクセス権限制御情報の設定値上書き処理", ex.StackTrace(), arrMessage, strAttribute)
            AuthOverWriteValue = 2
            Exit Function

        End Try

        AuthOverWriteValue = 0

    End Function

    ''' <summary>
    ''' Todo: 次のフェーズでは廃止　委任マスタアクセス権限制御情報と制御・職員マージ後アクセス権限制御情報の設定値マージ処理
    ''' </summary>
    ''' <param name="clsConfigXMLDeputy">委任マスタ制御情報格納クラス</param>
    ''' <param name="clsConfigXMLMerge">制御・職員マージ制御情報格納クラス</param>
    ''' <param name="arrConfigTag">制御情報のタグ情報</param>
    ''' <param name="arrAttribute">制御情報の属性情報</param>
    ''' <param name="strFunctionID">機能ID</param>
    ''' <returns>Integer</returns>
    ''' <remarks>
    ''' 概要：キーとなる属性値が一致する場合、制御情報の上書き処理を行う
    ''' 【履歴】
    ''' 　日付	　　担当	　　Ver.	チケット#	変更理由
    ''' ----------------------------------------------------------------
    ''' 2014/12/22	FSI 山口	0.0.1	#XXXXXXXX	新規作成
    ''' </remarks>
    Private Function MergeAuthConfigXMLDeputy(ByRef clsConfigXMLDeputy As ConfigXMLData,
                                              ByRef clsConfigXMLMerge As ConfigXMLData,
                                              ByVal arrConfigTag As ArrayList,
                                              ByVal arrAttribute As ArrayList,
                                              ByVal strFunctionID As String) As Integer

        MergeAuthConfigXMLDeputy = 1

        Try

            If IsNothing(clsConfigXMLDeputy) = True Then
                MergeAuthConfigXMLDeputy = 0
                Exit Function
            End If

            If Not IsNothing(clsConfigXMLDeputy.xelElement) Then

                'タグで指定したXMLデータの読み込み
                If ReadXMLElementData(clsConfigXMLDeputy.xelElementList,
                                      clsConfigXMLDeputy.xelElement,
                                      arrConfigTag) <> 0 Then
                    MergeAuthConfigXMLDeputy = 2
                    Exit Function
                End If

                'ループが最後まで行かない場合を考慮し、-1より開始
                Dim intDataCnt As Integer = -1
                'XML設定ファイルのレコード単位ループ
                For Each xelElementDeputy As XElement In clsConfigXMLDeputy.xelElementList

                    intDataCnt += 1

                    'タグで指定したXMLデータの読み込み
                    If ReadXMLElementData(clsConfigXMLMerge.xelElementList,
                                          clsConfigXMLMerge.xelElement,
                                          arrConfigTag) <> 0 Then
                        MergeAuthConfigXMLDeputy = 2
                        Exit Function
                    End If
                    If IsNothing(clsConfigXMLMerge.xelElementList) = True Then
                        Continue For
                    End If

                    '該当する属性が存在する場合は上書き
                    For Each xelElementMerge As XElement In clsConfigXMLMerge.xelElementList

                        '値の入れ替え
                        If xelElementDeputy.Attribute(ATTRIBUTE_ID).Value =
                            xelElementMerge.Attribute(ATTRIBUTE_ID).Value Then

                            Dim intLoopCnt2 As Integer
                            For intLoopCnt2 = 0 To arrAttribute.Count - 1
                                '委任制御情報に対して、制御・職員制御情報のアクセス権限とANDを取り、真は権限有、偽は権限無とする。
                                If IsNothing(clsConfigXMLMerge.xelElementList(intDataCnt).Attribute(arrAttribute(intLoopCnt2).ToString)) = False And
                                    IsNothing(xelElementMerge.Attribute(arrAttribute(intLoopCnt2).ToString)) = False Then

                                    ''桁数毎にANDを行う
                                    'Dim strAuthority As String
                                    ''1桁目：参照権限
                                    'If CInt(clsConfigXMLMerge.xelElementList(intDataCnt).Attribute(arrAttribute(intLoopCnt2).ToString).ToString.Substring(0, 1)) = 1 And
                                    '    CInt(clsConfigXMLDeputy.xelElementList(intDataCnt).Attribute(arrAttribute(intLoopCnt2).ToString).Value.ToString.Substring(0, 1)) = 1 Then
                                    '    strAuthority = "1"
                                    'Else
                                    '    strAuthority = "0"
                                    'End If
                                    ''2桁目：登録権限
                                    'If CInt(clsConfigXMLMerge.xelElementList(intDataCnt).Attribute(arrAttribute(intLoopCnt2).ToString).ToString.Substring(1, 1)) = 1 And
                                    '    CInt(clsConfigXMLDeputy.xelElementList(intDataCnt).Attribute(arrAttribute(intLoopCnt2).ToString).Value.ToString.Substring(1, 1)) = 1 Then
                                    '    strAuthority = strAuthority & "1"
                                    'Else
                                    '    strAuthority = strAuthority & "0"
                                    'End If
                                    ''3桁目：修正権限
                                    'If CInt(clsConfigXMLMerge.xelElementList(intDataCnt).Attribute(arrAttribute(intLoopCnt2).ToString).ToString.Substring(2, 1)) = 1 And
                                    '    CInt(clsConfigXMLDeputy.xelElementList(intDataCnt).Attribute(arrAttribute(intLoopCnt2).ToString).Value.ToString.Substring(2, 1)) = 1 Then
                                    '    strAuthority = strAuthority & "1"
                                    'Else
                                    '    strAuthority = strAuthority & "0"
                                    'End If
                                    ''4桁目：中止権限、5桁目：削除権限
                                    'If CInt(clsConfigXMLMerge.xelElementList(intDataCnt).Attribute(arrAttribute(intLoopCnt2).ToString).ToString.Substring(3, 1)) = 1 And
                                    '    CInt(clsConfigXMLDeputy.xelElementList(intDataCnt).Attribute(arrAttribute(intLoopCnt2).ToString).Value.ToString.Substring(3, 1)) = 1 Then
                                    '    strAuthority = strAuthority & "1"
                                    'Else
                                    '    strAuthority = strAuthority & "0"
                                    'End If
                                    ''5桁目：削除権限
                                    'If CInt(clsConfigXMLMerge.xelElementList(intDataCnt).Attribute(arrAttribute(intLoopCnt2).ToString).ToString.Substring(4, 1)) = 1 And
                                    '    CInt(clsConfigXMLDeputy.xelElementList(intDataCnt).Attribute(arrAttribute(intLoopCnt2).ToString).Value.ToString.Substring(4, 1)) = 1 Then
                                    '    strAuthority = strAuthority & "1"
                                    'Else
                                    '    strAuthority = strAuthority & "0"
                                    'End If

                                    ''権限の設定
                                    'clsConfigXMLDeputy.xelElementList(intDataCnt).Attribute(arrAttribute(intLoopCnt2).ToString).Value = strAuthority

                                    '設定値を数値に置き換え(置き換えられない場合は次のループへ
                                    Dim intDeputyACC As Integer
                                    If Integer.TryParse(clsConfigXMLDeputy.xelElementList(intDataCnt).Attribute(arrAttribute(intLoopCnt2).ToString).Value, intDeputyACC) = True Then
                                        intDeputyACC = Integer.Parse(clsConfigXMLDeputy.xelElementList(intDataCnt).Attribute(arrAttribute(intLoopCnt2).ToString).Value, Globalization.NumberStyles.Integer)
                                    Else
                                        Continue For
                                    End If
                                    Dim intGroupACC As Integer
                                    If Integer.TryParse(xelElementMerge.Attribute(arrAttribute(intLoopCnt2).ToString).Value, intGroupACC) = True Then
                                        intGroupACC = Integer.Parse(xelElementMerge.Attribute(arrAttribute(intLoopCnt2).ToString).Value, Globalization.NumberStyles.Integer)
                                    Else
                                        Continue For
                                    End If

                                    '権限が低い場合のみ委任制御情報に値を上書き
                                    If intDeputyACC > intGroupACC Then
                                        clsConfigXMLDeputy.xelElementList(intDataCnt).Attribute(arrAttribute(intLoopCnt2).ToString).Value =
                                            xelElementMerge.Attribute(arrAttribute(intLoopCnt2).ToString).Value
                                    End If
                                End If

                            Next

                            Exit For

                        End If

                    Next

                Next

            End If

        Catch ex As Exception

            Dim clsLogMessage As New LogMessage
            Dim intRet As Integer
            Dim strTag As String = "タグ「"
            For intTagCount As Integer = 0 To arrConfigTag.Count - 1
                strTag = strTag & arrConfigTag.Item(intTagCount).ToString & ","
            Next
            strTag = strTag.Substring(0, strTag.Length - 1) & "」"
            Dim strAttribute As String = "属性「"
            For intAttributeCount As Integer = 0 To arrAttribute.Count - 1
                strAttribute = strAttribute & arrAttribute.Item(intAttributeCount).ToString & ","
            Next
            strAttribute = strAttribute.Substring(0, strTag.Length - 1) & "」"
            Dim arrMessage As New ArrayList
            arrMessage.Add("制御マスタ")
            clsLogMessage.OutputLogMessage(intRet, strFunctionID, AloeConst.MSGID_30000002, "制御Gマスタおよび制御マスタの制御情報取得処理", ex.StackTrace(), arrMessage, strTag & " " & strAttribute)
            MergeAuthConfigXMLDeputy = 2
            Exit Function

        End Try

        MergeAuthConfigXMLDeputy = 0

    End Function

    ''' <summary>
    ''' 委任マスタアクセス権限制御情報と制御・職員マージ後アクセス権限制御情報の設定値マージ処理
    ''' </summary>
    ''' <param name="clsConfigXMLDeputy">委任マスタ制御情報格納クラス</param>
    ''' <param name="clsConfigXMLMerge">制御・職員マージ制御情報格納クラス</param>
    ''' <param name="arrConfigTag">制御情報のタグ情報</param>
    ''' <param name="arrAttribute">制御情報の属性情報</param>
    ''' <param name="strFunctionID">機能ID</param>
    ''' <returns>Integer</returns>
    ''' <remarks>
    ''' 概要：キーとなる属性値が一致する場合、制御情報の上書き処理を行う
    ''' 【履歴】
    ''' 　日付	　　担当	　　Ver.	チケット#	変更理由
    ''' ----------------------------------------------------------------
    ''' 2014/12/22	FSI 山口	0.0.1	#XXXXXXXX	新規作成
    ''' </remarks>
    Private Function MergeAuthorityXMLDeputy(ByRef clsConfigXMLDeputy As ConfigXMLData,
                                             ByRef clsConfigXMLMerge As ConfigXMLData,
                                             ByVal arrConfigTag As ArrayList,
                                             ByVal arrAttribute As ArrayList,
                                             ByVal strFunctionID As String) As Integer

        MergeAuthorityXMLDeputy = 1

        Try

            If IsNothing(clsConfigXMLDeputy) = True Then
                MergeAuthorityXMLDeputy = 0
                Exit Function
            End If

            If Not IsNothing(clsConfigXMLDeputy.xelElement) Then

                'タグで指定したXMLデータの読み込み
                If ReadXMLElementData(clsConfigXMLDeputy.xelElementList,
                                      clsConfigXMLDeputy.xelElement,
                                      arrConfigTag) <> 0 Then
                    MergeAuthorityXMLDeputy = 2
                    Exit Function
                End If

                'ループが最後まで行かない場合を考慮し、-1より開始
                Dim intDataCnt As Integer = -1
                'XML設定ファイルのレコード単位ループ
                For Each xelElementDeputy As XElement In clsConfigXMLDeputy.xelElementList

                    intDataCnt += 1

                    'タグで指定したXMLデータの読み込み
                    If ReadXMLElementData(clsConfigXMLMerge.xelElementList,
                                          clsConfigXMLMerge.xelElement,
                                          arrConfigTag) <> 0 Then
                        MergeAuthorityXMLDeputy = 2
                        Exit Function
                    End If
                    If IsNothing(clsConfigXMLMerge.xelElementList) = True Then
                        Continue For
                    End If

                    '該当する属性が存在する場合は上書き
                    For Each xelElementMerge As XElement In clsConfigXMLMerge.xelElementList

                        '値の入れ替え
                        If xelElementDeputy.Attribute(ATTRIBUTE_ID).Value =
                            xelElementMerge.Attribute(ATTRIBUTE_ID).Value Then

                            '委任制御情報に対して、制御・職員制御情報のアクセス権限とANDを取り、真は権限有、偽は権限無とする。
                            If IsNothing(xelElementDeputy.Attribute(ATTRIBUTE_AUTH).Value) = False And
                                IsNothing(xelElementMerge.Attribute(ATTRIBUTE_AUTH).Value) = False Then

                                '桁数毎にANDを行う
                                Dim strAuthority As String
                                '1桁目：参照権限
                                If CInt(xelElementDeputy.Attribute(ATTRIBUTE_AUTH).Value.ToString.Substring(0, 1)) = 1 And
                                    CInt(xelElementMerge.Attribute(ATTRIBUTE_AUTH).Value.ToString.Substring(0, 1)) = 1 Then
                                    strAuthority = "1"
                                Else
                                    strAuthority = "0"
                                End If
                                '2桁目：登録権限
                                If CInt(xelElementDeputy.Attribute(ATTRIBUTE_AUTH).Value.ToString.Substring(1, 1)) = 1 And
                                    CInt(xelElementMerge.Attribute(ATTRIBUTE_AUTH).Value.ToString.Substring(1, 1)) = 1 Then
                                    strAuthority = strAuthority & "1"
                                Else
                                    strAuthority = strAuthority & "0"
                                End If
                                '3桁目：修正権限
                                If CInt(xelElementDeputy.Attribute(ATTRIBUTE_AUTH).Value.ToString.Substring(2, 1)) = 1 And
                                    CInt(xelElementMerge.Attribute(ATTRIBUTE_AUTH).Value.ToString.Substring(2, 1)) = 1 Then
                                    strAuthority = strAuthority & "1"
                                Else
                                    strAuthority = strAuthority & "0"
                                End If
                                '4桁目：中止権限、5桁目：削除権限
                                If CInt(xelElementDeputy.Attribute(ATTRIBUTE_AUTH).Value.ToString.Substring(3, 1)) = 1 And
                                    CInt(xelElementMerge.Attribute(ATTRIBUTE_AUTH).Value.ToString.Substring(3, 1)) = 1 Then
                                    strAuthority = strAuthority & "1"
                                Else
                                    strAuthority = strAuthority & "0"
                                End If
                                '5桁目：削除権限
                                If CInt(xelElementDeputy.Attribute(ATTRIBUTE_AUTH).Value.ToString.Substring(4, 1)) = 1 And
                                    CInt(xelElementMerge.Attribute(ATTRIBUTE_AUTH).Value.ToString.Substring(4, 1)) = 1 Then
                                    strAuthority = strAuthority & "1"
                                Else
                                    strAuthority = strAuthority & "0"
                                End If

                                '権限の設定
                                clsConfigXMLDeputy.xelElementList(intDataCnt).Attribute(ATTRIBUTE_AUTH).Value = strAuthority
                            End If

                        End If

                    Next

                Next

            End If

        Catch ex As Exception

            Dim clsLogMessage As New LogMessage
            Dim intRet As Integer
            Dim strTag As String = "タグ「"
            For intTagCount As Integer = 0 To arrConfigTag.Count - 1
                strTag = strTag & arrConfigTag.Item(intTagCount).ToString & ","
            Next
            strTag = strTag.Substring(0, strTag.Length - 1) & "」"
            Dim strAttribute As String = "属性「"
            For intAttributeCount As Integer = 0 To arrAttribute.Count - 1
                strAttribute = strAttribute & arrAttribute.Item(intAttributeCount).ToString & ","
            Next
            strAttribute = strAttribute.Substring(0, strTag.Length - 1) & "」"
            Dim arrMessage As New ArrayList
            arrMessage.Add("制御マスタ")
            clsLogMessage.OutputLogMessage(intRet, "", AloeConst.MSGID_30000002, "制御Gマスタおよび制御マスタの制御情報取得処理", ex.StackTrace(), arrMessage, strTag & " " & strAttribute)
            MergeAuthorityXMLDeputy = 2
            Exit Function

        End Try

        MergeAuthorityXMLDeputy = 0

    End Function

    ''' <summary>
    ''' 制御情報の要素単位読み込み処理
    ''' </summary>
    ''' <param name="xmlElementList">制御情報行の読み込み情報</param>
    ''' <param name="xmlElement">読み込み元の制御情報</param>
    ''' <param name="arrConfigTag">読み込み対象のタグ(要素)情報</param>
    ''' <returns>Integer</returns>
    ''' <remarks>
    ''' 概要：キーとなる属性値が一致する場合、制御情報の上書き処理を行う
    ''' 【履歴】
    ''' 　日付	　　担当	　　Ver.	チケット#	変更理由
    ''' ----------------------------------------------------------------
    ''' </remarks>
    Private Function ReadXMLElementData(ByRef xmlElementList As IEnumerable(Of XElement),
                                        ByVal xmlElement As XElement,
                                        ByVal arrConfigTag As ArrayList) As Integer

        ReadXMLElementData = 1

        Try
            Dim intLoopCnt As Integer
            Dim xmlEl As IEnumerable(Of XElement) = Nothing
            For intLoopCnt = 0 To arrConfigTag.Count - 1
                If IsNothing(xmlEl) = True Then
                    xmlEl = From xEl In xmlElement.Descendants(arrConfigTag(intLoopCnt).ToString)
                            Select xEl
                Else
                    xmlEl = From xEl In xmlEl.Descendants(arrConfigTag(intLoopCnt).ToString)
                            Select xEl
                End If
            Next
            xmlElementList = xmlEl
        Catch ex As Exception

            Dim clsLogMessage As New LogMessage
            Dim intRet As Integer
            Dim strTag As String = "タグ「"
            For intTagCount As Integer = 0 To arrConfigTag.Count - 1
                strTag = strTag & arrConfigTag.Item(intTagCount).ToString & ","
            Next
            strTag = strTag.Substring(0, strTag.Length - 1) & "」"
            Dim arrMessage As New ArrayList
            arrMessage.Add("制御マスタ")
            clsLogMessage.OutputLogMessage(intRet, "", AloeConst.MSGID_30000002, "制御情報の要素単位読み込み処理", ex.StackTrace(), arrMessage, strTag)
            ReadXMLElementData = 2
            Exit Function

        End Try

        ReadXMLElementData = 0

    End Function

    ''' <summary>
    ''' XML設定データの読み込み処理
    ''' </summary>
    ''' <param name="dicConfigTagData">設定値格納用配列(Dictionary)</param>
    ''' <param name="clsXMLMerge">マージ済みXMLデータ格納クラス</param>
    ''' <param name="arrConfigTag">読み込み対象のタグ(要素)情報</param>
    ''' <param name="arrAttr">読み込み対象対象の属性</param>
    ''' <returns>Integer</returns>
    ''' <remarks>
    ''' 概要：XML設定データの読み込みを行い、設定値を出力する。
    ''' 【履歴】
    ''' 　日付	　　担当	　　Ver.	チケット#	変更理由
    ''' ----------------------------------------------------------------
    ''' </remarks>
    Private Overloads Function ReadConfigXmlData(ByRef dicConfigTagData As Dictionary(Of String, Dictionary(Of String, String)),
                                                 ByVal clsXMLMerge As ConfigXMLData,
                                                 ByVal arrConfigTag As ArrayList,
                                                 Optional ByVal arrAttr As ArrayList = Nothing) As Integer

        ReadConfigXmlData = 1

        Try

            Dim intDataCnt As Integer

            If IsNothing(dicConfigTagData) = True Then
                dicConfigTagData = New Dictionary(Of String, Dictionary(Of String, String))
            End If

            If Not IsNothing(clsXMLMerge) Then

                'タグで指定したXMLデータの読み込み
                If ReadXMLElementData(clsXMLMerge.xelElementList,
                                      clsXMLMerge.xelElement,
                                      arrConfigTag) <> 0 Then
                    ReadConfigXmlData = 2
                    Exit Function
                End If

                For Each xelElement As XElement In clsXMLMerge.xelElementList

                    Dim dicAttributeData As New Dictionary(Of String, String)
                    intDataCnt += 1

                    '属性が無い場合は次の行を読み込み
                    If xelElement.Attributes.Count = 0 Then
                        Continue For
                    End If

                    For intCnt = 0 To arrAttr.Count - 1

                        '親の情報が指定されている場合
                        If arrAttr(intCnt).ToString.IndexOf("Parent") = 0 Then
                            Dim strParentAttr As String()
                            strParentAttr = arrAttr(intCnt).ToString.Split(CChar("."))
                            '親が存在する場合のみ設定(設定値には存在しないため)
                            If IsNothing(xelElement.Parent.Attribute(strParentAttr(1))) = False Then
                                dicAttributeData.Add(arrAttr(intCnt).ToString, xelElement.Parent.Attribute(strParentAttr(1)).Value)
                            Else
                                dicAttributeData.Add(arrAttr(intCnt).ToString, "")
                            End If
                            Continue For
                        End If

                        '該当する属性が存在する場合
                        If IsNothing(xelElement.Attribute(arrAttr(intCnt).ToString())) = False Then
                            dicAttributeData.Add(arrAttr(intCnt).ToString, xelElement.Attribute(arrAttr(intCnt).ToString()).Value)
                        Else
                            dicAttributeData.Add(arrAttr(intCnt).ToString, "")
                        End If

                    Next

                    dicConfigTagData.Add(intDataCnt.ToString, dicAttributeData)

                Next
            End If

        Catch ex As Exception

            Dim clsLogMessage As New LogMessage
            Dim intRet As Integer
            Dim strTag As String = "タグ「"
            For intTagCount As Integer = 0 To arrConfigTag.Count - 1
                strTag = strTag & arrConfigTag.Item(intTagCount).ToString & ","
            Next
            strTag = strTag.Substring(0, strTag.Length - 1) & "」"
            Dim strAttribute As String = String.Empty
            If IsNothing(arrAttr) = False Then
                strAttribute = "属性「"
                For intAttributeCount As Integer = 0 To arrAttr.Count - 1
                    strAttribute = strAttribute & arrAttr.Item(intAttributeCount).ToString & ","
                Next
                strAttribute = strAttribute.Substring(0, strTag.Length - 1) & "」"
            End If
            Dim arrMessage As New ArrayList
            arrMessage.Add("制御マスタ")
            clsLogMessage.OutputLogMessage(intRet, "", AloeConst.MSGID_30000002, "制御情報の要素単位読み込み処理", ex.StackTrace(), arrMessage, strTag & " " & strAttribute)
            ReadConfigXmlData = 2
            Exit Function
        End Try

        ReadConfigXmlData = 0

    End Function


    ''' <summary>
    ''' XML設定データの読み込み処理(アクセス権限取得用)
    ''' </summary>
    ''' <param name="clsAuthorityInfo">アクセス権限格納用クラス</param>
    ''' <param name="clsXMLMerge">マージ済みXMLデータ格納クラス</param>
    ''' <param name="arrConfigTag">読み込み対象のタグ(要素)情報</param>
    ''' <param name="arrAttr">読み込み対象対象の属性</param>
    ''' <returns>Integer</returns>
    ''' <remarks>
    ''' 概要：XML設定データの読み込みを行い、設定値を出力する。
    ''' 【履歴】
    ''' 　日付	　　担当	　　Ver.	チケット#	変更理由
    ''' ----------------------------------------------------------------
    ''' </remarks>
    Private Overloads Function ReadConfigXmlData(ByRef clsAuthorityInfo As AuthorityInfo,
                                                 ByVal clsXMLMerge As ConfigXMLData,
                                                 ByVal arrConfigTag As ArrayList,
                                                 ByVal arrAttr As ArrayList,
                                                 ByVal strFunctionID As String) As Integer

        ReadConfigXmlData = 1

        Try

            Dim intDataCnt As Integer

            If IsNothing(clsAuthorityInfo) = True Then
                clsAuthorityInfo = New AuthorityInfo
            End If

            If Not IsNothing(clsXMLMerge) Then

                'タグで指定したXMLデータの読み込み
                If ReadXMLElementData(clsXMLMerge.xelElementList,
                                      clsXMLMerge.xelElement,
                                      arrConfigTag) <> 0 Then
                    ReadConfigXmlData = 2
                    Exit Function
                End If

                For Each xelElement As XElement In clsXMLMerge.xelElementList

                    Dim dicAttributeData As New Dictionary(Of String, String)
                    intDataCnt += 1

                    '属性が無い場合は次の行を読み込み
                    If xelElement.Attributes.Count = 0 Then
                        Continue For
                    End If

                    '0番目の値は機能ID、1番目の値は権限(Authority)
                    If xelElement.Attribute(arrAttr(0).ToString()).Value = strFunctionID Then
                        clsAuthorityInfo.AuthSelect = CBool(If(xelElement.Attribute(arrAttr(1).ToString).Value.Substring(0, 1).ToString = "1", True, False))
                        clsAuthorityInfo.AuthInsert = CBool(If(xelElement.Attribute(arrAttr(1).ToString).Value.Substring(1, 1).ToString = "1", True, False))
                        clsAuthorityInfo.AuthUpdate = CBool(If(xelElement.Attribute(arrAttr(1).ToString).Value.Substring(2, 1).ToString = "1", True, False))
                        clsAuthorityInfo.AuthCancel = CBool(If(xelElement.Attribute(arrAttr(1).ToString).Value.Substring(3, 1).ToString = "1", True, False))
                        clsAuthorityInfo.AuthDelete = CBool(If(xelElement.Attribute(arrAttr(1).ToString).Value.Substring(4, 1).ToString = "1", True, False))
                    End If

                Next
            End If

        Catch ex As Exception

            Dim clsLogMessage As New LogMessage
            Dim intRet As Integer
            Dim strTag As String = "タグ「"
            For intTagCount As Integer = 0 To arrConfigTag.Count - 1
                strTag = strTag & arrConfigTag.Item(intTagCount).ToString & ","
            Next
            strTag = strTag.Substring(0, strTag.Length - 1) & "」"
            Dim strAttribute As String = String.Empty
            If IsNothing(arrAttr) = False Then
                strAttribute = "属性「"
                For intAttributeCount As Integer = 0 To arrAttr.Count - 1
                    strAttribute = strAttribute & arrAttr.Item(intAttributeCount).ToString & ","
                Next
                strAttribute = strAttribute.Substring(0, strTag.Length - 1) & "」"
            End If
            Dim arrMessage As New ArrayList
            arrMessage.Add("制御マスタ")
            clsLogMessage.OutputLogMessage(intRet, "AUTH", AloeConst.MSGID_30000002, "制御情報の要素単位読み込み処理", ex.StackTrace(), arrMessage, strTag & " " & strAttribute)
            ReadConfigXmlData = 2
            Exit Function
        End Try

        ReadConfigXmlData = 0

    End Function

End Class
