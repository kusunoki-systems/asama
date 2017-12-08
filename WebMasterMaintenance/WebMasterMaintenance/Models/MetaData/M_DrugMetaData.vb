Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
''' <summary>
''' 薬品用メタデータ
''' </summary>
''' <remarks></remarks>
Public Class M_DrugEXMetaData

    <DisplayName(M_Drug_Columns.COLUMN_NAME_MDRG_ValidDateFrom)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property MDRG_ValidDateFrom As Date

    <DisplayName(M_Drug_Columns.COLUMN_NAME_MDRG_ValidDateTo)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property MDRG_ValidDateTo As Date

    <DisplayName(M_Drug_Columns.COLUMN_NAME_MDRG_DrugName)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(60, ErrorMessage:="{0}は、{1}文字以下で入力してください")>
    Public Property MDRG_DrugName As String

    <DisplayName(M_Drug_Columns.COLUMN_NAME_MDRG_DrugKana)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(30, ErrorMessage:="{0}は、{1}文字以下で入力してください")>
    Public Property MDRG_DrugKana As String

    'ADD START 2017-08-22 病院限定薬品の一般名の入力時に桁数チェックが入っていない
    <DisplayName(M_Drug_Columns.COLUMN_NAME_MDRG_PublicName)>
    <MaxLength(100, ErrorMessage:="{0}は、{1}文字以下で入力してください")>
    Public Overridable Property MDRG_PublicName As String
    'ADD END   2017-08-22 病院限定薬品の一般名の入力時に桁数チェックが入っていない

    <DisplayName(M_Drug_Columns.COLUMN_NAME_MDRG_DisplayDrugName)>
    <MaxLength(60, ErrorMessage:="{0}は、{1}文字以下で入力してください")>
    Public Overridable Property MDRG_DisplayDrugName As String

    <DisplayName(M_Drug_Columns.COLUMN_NAME_MDRG_UnitInit)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property MDRG_UnitInit As Integer

    <DisplayName(M_Drug_Columns.COLUMN_NAME_MDRG_UnitReceipt)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property MDRG_UnitReceipt As Integer

    <DisplayName(M_Drug_Columns.COLUMN_NAME_MDRG_UnitPharm)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property MDRG_UnitPharm As Integer

    <DisplayName(M_Drug_Columns.COLUMN_NAME_MDRG_ReceiptCode)>
    <MaxLength(9, ErrorMessage:="{0}は、{1}文字以下で入力してください。")>
    <RegularExpression("[0-9]+", ErrorMessage:="{0}は数字で入力して下さい")>
    Public Property MDRG_ReceiptCode As Integer

    'ADD START 2017-09-05 FSI星野 #12043 最大投与日数の項目追加
    <DisplayName(M_Drug_Columns.COLUMN_NAME_MDRG_OnceMaxDosage)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <RegularExpression("^[+-]?[0-9]*[\.]?[0-9]+$", ErrorMessage:="{0}は数字で入力して下さい")>
    <Range(-9999.99999, 9999.99999, ErrorMessage:="整数4桁、小数5桁以内で入力してください")>
    Public Property MDRG_OnceMaxDosage As Decimal

    <DisplayName(M_Drug_Columns.COLUMN_NAME_MDRG_DailyMaxDosage)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <RegularExpression("^[+-]?[0-9]*[\.]?[0-9]+$", ErrorMessage:="{0}は数字で入力して下さい")>
    <Range(-9999.99999, 9999.99999, ErrorMessage:="整数4桁、小数5桁以内で入力してください")>
    Public Property MDRG_DailyMaxDosage As Decimal
    'ADD END   2017-09-05 FSI星野 #12043 最大投与日数の項目追加


End Class

