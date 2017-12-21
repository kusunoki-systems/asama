﻿Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

<MetadataType(GetType(M_SizeTypeMetaData))>
Partial Public Class M_SizeType
End Class

''' <summary>
''' メタデータ
''' </summary>
Public Class M_SizeTypeMetaData

    <DisplayName("サイズ種類コード")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(20, ErrorMessage:="20字以内で入力して下さい")>
    Public Property SizeTypeCd As String

    <DisplayName("サイズ種類")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(100, ErrorMessage:="100字以内で入力して下さい")>
    Public Property SizeTypeName As String

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
