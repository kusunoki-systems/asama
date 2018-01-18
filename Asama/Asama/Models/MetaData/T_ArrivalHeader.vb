Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

<MetadataType(GetType(T_ArrivalHeaderMetaData))>
Partial Public Class T_ArrivalHeader
End Class

Partial Public Class T_ArrivalHeaderMetaData

    <DisplayName("入荷番号")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property ArrivalNo As String

    <DisplayName("仕入先")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property SupplierCd As String

    <DisplayName("入荷日")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property ArrivalDate As Nullable(Of Date)

    <DisplayName("入荷数")>
    Public Property ArrivalAmount As Nullable(Of Decimal)

End Class