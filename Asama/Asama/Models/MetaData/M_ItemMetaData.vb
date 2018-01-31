Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
<MetadataType(GetType(M_ItemMetaData))>
Partial Public Class M_Item
End Class


Public Class M_ItemMetaData

    <DisplayName("商品コード")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(20, ErrorMessage:="20字以内で入力して下さい")>
    Public Property ItemCd As String

    <DisplayName("商品名")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(100, ErrorMessage:="100字以内で入力して下さい")>
    Public Property ItemName As String

    <DisplayName("シーズン")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(100, ErrorMessage:="100字以内で入力して下さい")>
    Public Property SeasonCd As String

    <DisplayName("シーズン")>
    Public Overridable Property M_Season As M_Season

    <DisplayName("ブランドコード")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(20, ErrorMessage:="20字以内で入力して下さい")>
    Public Property BrandCd As String

    <DisplayName("サイズ")>
    Public Overridable Property M_SizeType As M_SizeType

    <DisplayName("サイズ種類コード")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(20, ErrorMessage:="20字以内で入力して下さい")>
    Public Property SizeTypeCd As String

    <DisplayName("色種類")>
    Public Overridable Property M_ColorType As M_ColorType

    <DisplayName("色種類コード")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(20, ErrorMessage:="20字以内で入力して下さい")>
    Public Property ColorTypeCd As String

    <DisplayName("定価")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <RegularExpression("[0-9]+", ErrorMessage:="{0}は数字で入力して下さい")>
    Public Property RetailPrice As Nullable(Of Decimal)

    <DisplayName("仕入値")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <RegularExpression("[0-9]+", ErrorMessage:="{0}は数字で入力して下さい")>
    Public Property CostPrice As Nullable(Of Decimal)

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

    '<RegularExpression("^[+-]?[0-9]*[\.]?[0-9]+$", ErrorMessage:="{0}は数字で入力して下さい")>
    '<Range(-9999.99999, 9999.99999, ErrorMessage:="整数4桁、小数5桁以内で入力してください")>

End Class
