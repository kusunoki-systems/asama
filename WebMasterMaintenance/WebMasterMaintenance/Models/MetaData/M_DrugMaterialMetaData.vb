Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
''' <summary>
''' 医療材料用メタデータ
''' </summary>
Public Class M_DrugExMaterialMetaData

    <DisplayName(M_Drug_Columns.COLUMN_NAME_MDRG_DrugName)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(60, ErrorMessage:="{0}は、{1}文字以下で入力してください")>
    Public Property MDRG_DrugName As String

    <DisplayName(M_Drug_Columns.COLUMN_NAME_MDRG_DrugKana)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(30, ErrorMessage:="{0}は、{1}文字以下で入力してください")>
    Public Property MDRG_DrugKana As String

    <DisplayName("表示用医療材料名")>
    <MaxLength(60, ErrorMessage:="{0}は、{1}文字以下で入力してください")>
    Public Property MDRG_DisplayDrugName As String

    <DisplayName("医事連携コード")>
    <MaxLength(9, ErrorMessage:="9字以内で入力して下さい")>
    <RegularExpression("[0-9]+", ErrorMessage:="{0}は数字で入力して下さい")>
    Public Property MDRG_ReceiptCode As Integer

End Class
