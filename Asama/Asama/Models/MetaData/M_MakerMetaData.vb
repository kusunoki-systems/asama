Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
<MetadataType(GetType(M_MakerMetaData))>
Partial Public Class M_Maker
End Class

Public Class M_MakerMetaData

    <DisplayName("メーカーコード")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(20, ErrorMessage:="20字以内で入力して下さい")>
    Public Property MakerCd As String

    <DisplayName("メーカー名")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(100, ErrorMessage:="100字以内で入力して下さい")>
    Public Property MakerName As String

    <DisplayName("連絡先")>
    Public Property MakerContact As String

    <DisplayName("作成者")>
    Public Property InsertedBy As String
    <DisplayName("作成日時")>
    Public Property InsertedAt As Nullable(Of Date)
    <DisplayName("更新者")>
    Public Property UpdatedBy As String
    <DisplayName("更新日時")>
    Public Property UpdatedAt As Nullable(Of Date)

End Class
