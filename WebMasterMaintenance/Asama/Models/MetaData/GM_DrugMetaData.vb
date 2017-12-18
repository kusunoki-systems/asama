Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Public Class GM_DrugMetaData

    <DisplayName(GM_Drug_Columns.COLUMN_NAME_GDRG_ValidDateFrom)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property GDRG_ValidDateFrom As Date

    <DisplayName(GM_Drug_Columns.COLUMN_NAME_GDRG_ValidDateTo)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property GDRG_ValidDateTo As Date

    <DisplayName(GM_Drug_Columns.COLUMN_NAME_GDRG_DrugName)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(60, ErrorMessage:="60字以内で入力して下さい")>
    Public Property GDRG_DrugName As String

    <DisplayName(GM_Drug_Columns.COLUMN_NAME_GDRG_DrugKana)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(30, ErrorMessage:="30字以内で入力して下さい")>
    Public Property GDRG_DrugKana As String

    <DisplayName(GM_Drug_Columns.COLUMN_NAME_GDRG_DisplayDrugName)>
    <MaxLength(60, ErrorMessage:="60字以内で入力して下さい")>
    Public Overridable Property GDRG_DisplayDrugName As String

    <DisplayName(GM_Drug_Columns.COLUMN_NAME_GDRG_UnitInit)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property GDRG_UnitInit As Integer

    <DisplayName(GM_Drug_Columns.COLUMN_NAME_GDRG_UnitReceipt)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property GDRG_UnitReceipt As Integer

    <DisplayName(GM_Drug_Columns.COLUMN_NAME_GDRG_UnitPharm)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property GDRG_UnitPharm As Integer

    <DisplayName(GM_Drug_Columns.COLUMN_NAME_GDRG_ReceiptCode)>
    <MaxLength(9, ErrorMessage:="9字以内で入力して下さい")>
    <RegularExpression("[0-9]+", ErrorMessage:="{0}は数字で入力して下さい")>
    Public Property GDRG_ReceiptCode As Integer
End Class
