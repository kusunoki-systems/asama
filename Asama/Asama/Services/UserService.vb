''' <summary>
''' ユーザーサービス
''' </summary>
Public Class UserService

#Region "定数"
    Private Const _ACCESS_AUTHORITY As String = "ACC"
#End Region

    '''' <summary>
    '''' グループ施設マスタ取得
    '''' </summary>
    '''' <param name="db"></param>
    '''' <returns></returns>
    'Public Function GetGroupFacility(db As AsamaEntities) As List(Of S_GroupFacility)

    '    Dim mdls = From e In db.S_GroupFacility
    '               Where e.SGFA_DelFlag = 0
    '               Order By e.SGFA_SortNo Ascending
    '               Select e

    '    Return mdls.ToList

    'End Function

    ''' <summary>
    ''' 認証
    ''' </summary>
    ''' <returns></returns>
    Public Function LoginAuthority(db As Entities, model As UserModel, ErrorCount As Object) As LoginAD

        'If model.Id = "hoge" AndAlso model.Password = "hoge" Then
        '    Return Nothing
        'End If

        'エラーカウントを復元
        Dim cnt As Integer
        If IsNumeric(ErrorCount) Then
            cnt = CInt(ErrorCount)
        Else
            cnt = 0
        End If

        '認証処理
        Dim bl As New UclLoginBL
        Dim appdata As New LoginAD
        'appdata.FacilityID = model.FacilityID
        appdata.StaffID = model.Id
        appdata.Password = model.Password
        'ログイン処理
        appdata = bl.DoMain(db, appdata)
        model.JobCodes = appdata.JobCodes

        If appdata.HasError Then
            Return appdata
        End If

        Return appdata

    End Function



    Public Function GetUserInfo(db As Entities, id As String) As M_StaffBase

        Dim model = (From e In db.M_StaffBase
                     Where e.MSTB_StaffID = id And e.MSTB_DelFlag = 0
                     Order By e.MSTB_LogNo Descending).FirstOrDefault

        Return model

    End Function

    ''' <summary>
    ''' 権限情報のマージ
    ''' </summary>
    ''' <param name="dicControlInfo"></param>
    ''' <param name="dicPair"></param>
    Private Sub setMergeAuthDic(ByRef dicControlInfo As Dictionary(Of String, String), dicPair As KeyValuePair(Of String, String))

        If dicControlInfo.Keys.Contains(dicPair.Key) Then 'キーがかぶっていたら、マージする。
            '数値に変換
            Dim intdic As Integer = Convert.ToInt32(dicControlInfo(dicPair.Key), 2)
            '数値に変換
            Dim intctrl As Integer = Convert.ToInt32(dicPair.Value, 2)
            'OR演算
            Dim intRet As Integer = intdic Or intctrl
            '文字列に変換
            dicControlInfo(dicPair.Key) = Convert.ToString(intRet, 2)
        Else '新しいキーはそのままDictionaryに加える
            dicControlInfo.Add(dicPair.Key, dicPair.Value)
        End If

    End Sub


End Class
