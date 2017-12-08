Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Public Class UserModel

    <DisplayName("ログインID")>
    Public Property Id As String
    <DisplayName("パスワード")>
    Public Property Password As String
    <DisplayName("パスワードを記憶")>
    Public Property RememberMe As Boolean
    '<DisplayName("施設")>
    'Public Property FacilityID As String
    '<DisplayName("施設")>
    'Public Property FacilityModels As New Dictionary(Of String, String)
    '<DisplayName("職種コード（配列）")>
    'Public Property JobCodes As String()

    '''' <summary>
    '''' 施設格納
    '''' </summary>
    '''' <param name="mdls"></param>
    'Public Sub SetFacilityModels(mdls As List(Of S_GroupFacility))

    '    For Each mdl As S_GroupFacility In mdls
    '        FacilityModels.Add(mdl.SGFA_FacilityID, mdl.SGFA_GenericName)
    '    Next

    'End Sub

End Class
