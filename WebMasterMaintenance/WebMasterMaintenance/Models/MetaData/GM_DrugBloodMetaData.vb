Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
''' <summary>
''' 医療材料用メタデータ
''' </summary>
Public Class GM_DrugExBloodMetaData
    Public Property GDRG_FacilityID As String
    Public Property GDRG_StatusClass As String

    <DisplayName("HOT9コード")>
    Public Property GDRG_HotCode As String
    Public Property GDRG_LogNo As Integer
    <DisplayName("更新日時")>
    Public Property GDRG_UpdateDate As Date
    <DisplayName("更新端末名")>
    Public Property GDRG_UpdateClientName As String
    <DisplayName("更新職員")>
    Public Property GDRG_UpdateStaffID As String
    Public Property GDRG_DelFlag As Integer

    <DisplayName("有効期限開始")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property GDRG_ValidDateFrom As Date

    <DisplayName("有効期限終了")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property GDRG_ValidDateTo As Date

    <DisplayName("医薬品コード")>
    <MaxLength(9, ErrorMessage:="9字以内で入力して下さい")>
    <RegularExpression("[0-9]+", ErrorMessage:="{0}は数字で入力して下さい")>
    Public Property GDRG_ReceiptCode As Integer

    <DisplayName("基準番号（HOT番号）")>
    Public Property GDRG_StandardCode As String

    <DisplayName("薬価基準コード")>
    Public Property GDRG_MHLWCode As String

    <DisplayName("一般名コード")>
    Public Property GDRG_PublicCode As String

    <DisplayName("漢字名称")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(60, ErrorMessage:="60字以内で入力して下さい")>
    Public Property GDRG_DrugName As String

    <DisplayName("カナ名称")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(30, ErrorMessage:="30字以内で入力して下さい")>
    Public Property GDRG_DrugKana As String

    <DisplayName("販売名")>
    Public Property GDRG_SalesName As String
    Public Property GDRG_PublicName As String

    <DisplayName("表示名")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(60, ErrorMessage:="60字以内で入力して下さい")>
    Public Property GDRG_DisplayDrugName As String

    <DisplayName("輸血英字略称")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <MaxLength(60, ErrorMessage:="100字以内で入力して下さい")>
    Public Property GDRG_SearchKeyword As String

    <DisplayName("成分名")>
    Public Property GDRG_ComponentName As String
    Public Property GDRG_OriginalName As String

    <DisplayName("オーダ初期表示単位")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property GDRG_UnitInit As Integer

    <DisplayName("医事算定単位")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property GDRG_UnitReceipt As Integer

    <DisplayName("調剤送信単位")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    Public Property GDRG_UnitPharm As Integer

    Public Property GDRG_NarcoticClass As String

    <DisplayName("剤形区分")>
    Public Property GDRG_DosageFormClass As String
    Public Property GDRG_DrugFormType As String

    <DisplayName("容量")>
    Public Property GDRG_Syringeful As Integer
    Public Property GDRG_UsageCode As String
    Public Property GDRG_ExternalPartCode As String
    Public Property GDRG_DosageClass As String
    Public Property GDRG_DoseTimes As Nullable(Of Integer)
    Public Property GDRG_DoseDays As Nullable(Of Integer)
    Public Property GDRG_IntervalDays As Nullable(Of Integer)
    Public Property GDRG_Dosage As Nullable(Of Decimal)
    Public Property GDRG_OnceMaxDosage As Nullable(Of Decimal)
    Public Property GDRG_DailyMaxDosage As Nullable(Of Decimal)
    <DisplayName("採用区分")>
    Public Property GDRG_AdoptClass As String
    Public Property GDRG_OrderMedicineFlag As Integer
    Public Property GDRG_OrderInjectionFlag As Integer
    Public Property GDRG_NerveDestroyFlag As Integer
    Public Property GDRG_BiologyFlag As Integer
    Public Property GDRG_GenericFlag As Integer
    Public Property GDRG_DentistrySpecialtyFlag As Integer
    Public Property GDRG_ContrastMediumFlag As Integer
    Public Property GDRG_GrindFlag As Integer
    Public Property GDRG_MixFlag As Integer
    Public Property GDRG_DissolveFlag As Integer
    Public Property GDRG_PTPFlag As Integer
    Public Property GDRG_OneDosePackagFlag As Integer
    Public Property GDRG_HospitalPreparationFlag As Integer
    Public Property GDRG_INDFlag As Integer
    Public Property GDRG_ExtraDrugFlag As Integer
    Public Property GDRG_DiabetesFlag As Integer
    Public Property GDRG_AnticancerDrugFlag As Integer
    Public Property GDRG_SubstituteHotCode1 As String
    Public Property GDRG_SubstituteHotCode2 As String
    Public Property GDRG_LabelPrintFlag As Integer

    <DisplayName("輸血製剤単位数")>
    <RegularExpression("[0-9]+", ErrorMessage:="{0}は数字で入力して下さい")>
    Public Property GDRG_TransfusionUnit As Integer

    Public Property GDRG_OrderTransfusionFlag As Integer
    Public Property GDRG_PatientLimitedFlag As Integer
    Public Property GDRG_Remarks As String

End Class
