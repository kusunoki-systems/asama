Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
<MetadataType(GetType(M_SeasonMetaData))>
Partial Public Class M_Season
End Class

Public Class M_SeasonMetaData

    <DisplayName("シーズンコード")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(20, ErrorMessage:="20字以内で入力して下さい")>
    Public Property SeasonCd As String

    <DisplayName("シーズン名")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(20, ErrorMessage:="20字以内で入力して下さい")>
    Public Property SeasonName As String

    <DisplayName("表示順")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <RegularExpression("[0-9]+", ErrorMessage:="{0}は数字で入力して下さい")>
    Public Property SortNo As Byte?

    <DisplayName("作成者")>
    Public Property InsertedBy As String
    <DisplayName("作成日時")>
    Public Property InsertedAt As Nullable(Of Date)
    <DisplayName("更新者")>
    Public Property UpdatedBy As String
    <DisplayName("更新日時")>
    Public Property UpdatedAt As Nullable(Of Date)

End Class