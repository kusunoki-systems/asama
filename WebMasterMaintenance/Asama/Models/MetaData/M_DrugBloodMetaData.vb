Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
''' <summary>
''' 医療材料用メタデータ
''' </summary>
Public Class M_DrugExBloodMetaData
    Public Property MDRG_FacilityID As String
    Public Property MDRG_StatusClass As String

    <DisplayName(M_Drug_Columns.COLUMN_NAME_MDRG_HotCode)>
    Public Property MDRG_HotCode As String
    Public Property MDRG_LogNo As Integer
    <DisplayName("更新日時")>
    Public Property MDRG_UpdateDate As Date
    <DisplayName("更新端末名")>
    Public Property MDRG_UpdateClientName As String
    <DisplayName("更新職員")>
    Public Property MDRG_UpdateStaffID As String
    Public Property MDRG_DelFlag As Integer

    <DisplayName(M_Drug_Columns.COLUMN_NAME_MDRG_ValidDateFrom)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property MDRG_ValidDateFrom As Date

    <DisplayName(M_Drug_Columns.COLUMN_NAME_MDRG_ValidDateTo)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property MDRG_ValidDateTo As Date

    <DisplayName("医事連携コード")>
    <MaxLength(9, ErrorMessage:="{0}は、{1}文字以下で入力してください")>
    <RegularExpression("[0-9]+", ErrorMessage:="{0}は数字で入力して下さい")>
    Public Property MDRG_ReceiptCode As Integer

    <DisplayName("基準番号（HOT番号）")>
    Public Property MDRG_StandardCode As String

    <DisplayName("薬価基準コード")>
    Public Property MDRG_MHLWCode As String

    <DisplayName("一般名コード")>
    Public Property MDRG_PublicCode As String

    <DisplayName(M_Drug_Columns.COLUMN_NAME_MDRG_DrugName)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(60, ErrorMessage:="{0}は、{1}文字以下で入力してください")>
    Public Property MDRG_DrugName As String

    <DisplayName(M_Drug_Columns.COLUMN_NAME_MDRG_DrugKana)>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(30, ErrorMessage:="{0}は、{1}文字以下で入力してください")>
    Public Property MDRG_DrugKana As String

    <DisplayName("販売名")>
    Public Property MDRG_SalesName As String
    Public Property MDRG_PublicName As String

    'DEL 2017-08-22 FSI星野 #11976 必須入力項目が記入されていない場合削除ができない
    '<Required(ErrorMessage:="{0}を入力して下さい")>
    <DisplayName("表示用輸血製剤名")>
    <MaxLength(60, ErrorMessage:="{0}は、{1}文字以下で入力してください")>
    Public Property MDRG_DisplayDrugName As String

    'DEL 2017-09-06 FSI星野 #11976 必須入力項目が記入されていない場合削除ができない
    '<Required(ErrorMessage:="{0}を入力して下さい")>
    <DisplayName("輸血英字略称")>
    <MaxLength(100, ErrorMessage:="{0}は、{1}文字以下で入力してください")>
    Public Property MDRG_SearchKeyword As String

    <DisplayName("成分名")>
    Public Property MDRG_ComponentName As String
    Public Property MDRG_OriginalName As String

    <DisplayName("オーダ初期表示単位")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property MDRG_UnitInit As Integer

    <DisplayName("医事算定単位")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property MDRG_UnitReceipt As Integer

    <DisplayName("調剤送信単位")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property MDRG_UnitPharm As Integer

    Public Property MDRG_NarcoticClass As String

    <DisplayName("剤形区分")>
    Public Property MDRG_DosageFormClass As String
    Public Property MDRG_DrugFormType As String

    <DisplayName("容量")>
    Public Property MDRG_Syringeful As Integer
    Public Property MDRG_UsageCode As String
    Public Property MDRG_ExternalPartCode As String
    Public Property MDRG_DosageClass As String
    Public Property MDRG_DoseTimes As Nullable(Of Integer)
    Public Property MDRG_DoseDays As Nullable(Of Integer)
    Public Property MDRG_IntervalDays As Nullable(Of Integer)
    Public Property MDRG_Dosage As Nullable(Of Decimal)
    Public Property MDRG_OnceMaxDosage As Nullable(Of Decimal)
    Public Property MDRG_DailyMaxDosage As Nullable(Of Decimal)
    <DisplayName("採用区分")>
    Public Property MDRG_AdoptClass As String
    Public Property MDRG_OrderMedicineFlag As Integer
    Public Property MDRG_OrderInjectionFlag As Integer
    Public Property MDRG_NerveDestroyFlag As Integer
    Public Property MDRG_BiologyFlag As Integer
    Public Property MDRG_GenericFlag As Integer
    Public Property MDRG_DentistrySpecialtyFlag As Integer
    Public Property MDRG_ContrastMediumFlag As Integer
    Public Property MDRG_GrindFlag As Integer
    Public Property MDRG_MixFlag As Integer
    Public Property MDRG_DissolveFlag As Integer
    Public Property MDRG_PTPFlag As Integer
    Public Property MDRG_OneDosePackagFlag As Integer
    Public Property MDRG_HospitalPreparationFlag As Integer
    Public Property MDRG_INDFlag As Integer
    Public Property MDRG_ExtraDrugFlag As Integer
    Public Property MDRG_DiabetesFlag As Integer
    Public Property MDRG_AnticancerDrugFlag As Integer
    Public Property MDRG_SubstituteHotCode1 As String
    Public Property MDRG_SubstituteHotCode2 As String
    Public Property MDRG_LabelPrintFlag As Integer

    <DisplayName("輸血製剤単位数")>
    <RegularExpression("[0-9]+", ErrorMessage:="{0}は数字で入力して下さい")>
    Public Property MDRG_TransfusionUnit As Integer

    Public Property MDRG_OrderTransfusionFlag As Integer
    Public Property MDRG_PatientLimitedFlag As Integer
    Public Property MDRG_Remarks As String

    <DisplayName("血液製剤コード")>
    <MaxLength(7, ErrorMessage:="{0}は、{1}文字以下で入力してください")>
    <RegularExpression("[0-9]+", ErrorMessage:="{0}は数字で入力して下さい")>
    Public Property MDRG_FormulationCode As Integer



End Class
