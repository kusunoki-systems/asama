Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports Asama
''' <summary>
''' メタデータ
''' </summary>
Public Class M_SizeMetaData

    <DisplayName("サイズコード")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(20, ErrorMessage:="20字以内で入力して下さい")>
    Public Property SizeCd As String

    <DisplayName("サイズ")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(20, ErrorMessage:="20字以内で入力して下さい")>
    Public Property SizeName As String

    <DisplayName("サイズ種類コード")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(20, ErrorMessage:="20字以内で入力して下さい")>
    Public Property SizeTypeCd As String

    <DisplayName("作成者")>
    Public Property InsertedBy As String
    <DisplayName("作成日時")>
    Public Property InsertedAt As Nullable(Of Date)
    <DisplayName("更新者")>
    Public Property UpdatedBy As String
    <DisplayName("更新日時")>
    Public Property UpdatedAt As Nullable(Of Date)

End Class
