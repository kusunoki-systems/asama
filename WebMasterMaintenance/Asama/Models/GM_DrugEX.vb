Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
''' <summary>
''' M_Drugモデル
''' </summary>
''' <remarks></remarks>
<MetadataType(GetType(GM_DrugMetaData))>
Public Class GM_DrugEX
    'Inherits GM_Drug

    Public Property GDRG_ValidDateFromCheck As Integer
    Public Property GDRG_ValidDateToCheck As Integer

    'Public Property Unit As List(Of GM_DrugUnit)     'この医薬品の使用単位全件
    'Public Property UnitName As List(Of GM_Name)    '単位名称マスタ
    Public Property OptionList_ValidCheck As Dictionary(Of String, String)
    Public Property OptionList_NarcoticClass As Dictionary(Of String, String)
    Public Property OptionList_DosageFormClass As Dictionary(Of String, String)
    Public Property OptionList_Flag1 As Dictionary(Of String, String)
    Public Property OptionList_ExternalPartCode As Dictionary(Of String, String)
    Public Property OptionList_AdoptClass As Dictionary(Of String, String)
    Public Property OptionList_NerveDestroyFlag As Dictionary(Of String, String)
    Public Property OptionList_BiologyFlag As Dictionary(Of String, String)
    Public Property OptionList_GenericFlag As Dictionary(Of String, String)
    Public Property OptionList_DentistrySpecialtyFlag As Dictionary(Of String, String)
    Public Property OptionList_ContrastMediumFlag As Dictionary(Of String, String)
    Public Property OptionList_GrindFlag As Dictionary(Of String, String)
    Public Property OptionList_MixFlag As Dictionary(Of String, String)
    Public Property OptionList_DissolveFlag As Dictionary(Of String, String)
    Public Property OptionList_PTPFlag As Dictionary(Of String, String)
    Public Property OptionList_OneDosePackagFlag As Dictionary(Of String, String)
    Public Property OptionList_HospitalPreparationFlag As Dictionary(Of String, String)
    Public Property OptionList_INDFlag As Dictionary(Of String, String)
    Public Property OptionList_ExtraDrugFlag As Dictionary(Of String, String)
    Public Property OptionList_DiabetesFlag As Dictionary(Of String, String)
    Public Property OptionList_AnticancerDrugFlag As Dictionary(Of String, String)
    Public Property OptionList_PatientLimitedFlag As Dictionary(Of String, String)
    Public Property UpdateStaffName As String

    '検索画面用
    Public Property CDRG_HotCode As String
    Public Property CDRG_DrugName As String

    Public Property CM_DosageFormClass1 As String
    Public Property CM_DosageFormClass4 As String
    Public Property CM_DosageFormClass6 As String
    Public Property GM_DosageFormClass1 As String
    Public Property GM_DosageFormClass4 As String
    Public Property GM_DosageFormClass6 As String

    Public Property Optiont_CheckFlag As Boolean
    Public Property MaxLog As Integer
    Public Property Authority As Boolean


    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(db As AsamaEntities, FacilityID As String)
        MyBase.New()
        Dim opt As New Options()
        opt.db = db
        '単位
        'Me.UnitName = db.GM_Name.Where(Function(e) e.GNAM_NameClass = "CM04").ToList
        Me.OptionList_ValidCheck = Options.GetOption_ValidCheckbox
        'Me.OptionList_DosageFormClass = opt.GetOption_DosageFormClass(FacilityID)
        'Me.OptionList_NarcoticClass = opt.GetOption_NarcoticClass(FacilityID)
        Me.OptionList_Flag1 = Options.GetOption_Flag1
        'Me.OptionList_ExternalPartCode = opt.GetOption_ExternalPartCode(FacilityID)
        Me.OptionList_AdoptClass = Options.GetOption_AdoptClass
        Me.OptionList_NerveDestroyFlag = Options.GetOption_NerveDestroyFlag
        Me.OptionList_BiologyFlag = Options.GetOption_BiologyFlag
        Me.OptionList_GenericFlag = Options.GetOption_GenericFlag
        Me.OptionList_DentistrySpecialtyFlag = Options.GetOption_DentistrySpecialtyFlag
        Me.OptionList_ContrastMediumFlag = Options.GetOption_ContrastMediumFlag
        Me.OptionList_GrindFlag = Options.GetOption_GrindFlag
        Me.OptionList_MixFlag = Options.GetOption_MixFlag
        Me.OptionList_DissolveFlag = Options.GetOption_DissolveFlag
        Me.OptionList_PTPFlag = Options.GetOption_PTPFlag
        Me.OptionList_OneDosePackagFlag = Options.GetOption_OneDosePackagFlag
        Me.OptionList_HospitalPreparationFlag = Options.GetOption_HospitalPreparationFlag
        Me.OptionList_INDFlag = Options.GetOption_INDFlag
        Me.OptionList_ExtraDrugFlag = Options.GetOption_ExtraDrugFlag
        Me.OptionList_DiabetesFlag = Options.GetOption_DiabetesFlag
        Me.OptionList_AnticancerDrugFlag = Options.GetOption_AnticancerDrugFlag
        Me.OptionList_PatientLimitedFlag = Options.GetOption_PatientLimitedFlag

    End Sub
    'Public Sub New(db As AsamaEntities, FacilityId As String, model As GM_Drug)
    '    Me.New(db, FacilityId)
    '    Me.SetFromOriginalModel(model)
    '    '使用単位の取得
    '    Me.Unit = db.GM_DrugUnit.Where(Function(e) e.GDUT_HotCode = Me.GDRG_HotCode).ToList

    'End Sub
    '''' <summary>
    '''' 規定モデルから値をセット
    '''' </summary>
    '''' <param name="model"></param>
    'Public Sub SetFromOriginalModel(model As GM_Drug)

    '    Me.GDRG_HotCode = model.GDRG_HotCode
    '    Me.GDRG_LogNo = model.GDRG_LogNo
    '    Me.GDRG_UpdateDate = model.GDRG_UpdateDate
    '    Me.GDRG_UpdateClientName = model.GDRG_UpdateClientName
    '    Me.GDRG_UpdateStaffID = model.GDRG_UpdateStaffID
    '    Me.GDRG_DelFlag = model.GDRG_DelFlag
    '    Me.GDRG_ValidDateFrom = model.GDRG_ValidDateFrom
    '    Me.GDRG_ValidDateFromCheck = If(GDRG_ValidDateFrom = UndefDateMin, 1, 0)
    '    Me.GDRG_ValidDateTo = model.GDRG_ValidDateTo
    '    Me.GDRG_ValidDateToCheck = If(GDRG_ValidDateTo = UndefDateMax, 1, 0)
    '    Me.GDRG_ReceiptCode = If(String.IsNullOrEmpty(model.GDRG_ReceiptCode), model.GDRG_ReceiptCode, model.GDRG_ReceiptCode.Trim())
    '    Me.GDRG_StandardCode = model.GDRG_StandardCode
    '    Me.GDRG_MHLWCode = model.GDRG_MHLWCode
    '    Me.GDRG_PublicCode = model.GDRG_PublicCode
    '    Me.GDRG_DrugName = model.GDRG_DrugName
    '    Me.GDRG_DrugKana = model.GDRG_DrugKana
    '    Me.GDRG_SalesName = model.GDRG_SalesName
    '    Me.GDRG_PublicName = model.GDRG_PublicName
    '    Me.GDRG_ComponentName = model.GDRG_ComponentName
    '    Me.GDRG_OriginalName = model.GDRG_OriginalName
    '    Me.GDRG_DisplayDrugName = model.GDRG_DisplayDrugName
    '    Me.GDRG_SearchKeyword = model.GDRG_SearchKeyword
    '    Me.GDRG_UnitInit = model.GDRG_UnitInit
    '    Me.GDRG_UnitReceipt = model.GDRG_UnitReceipt
    '    Me.GDRG_UnitPharm = model.GDRG_UnitPharm
    '    Me.GDRG_NarcoticClass = model.GDRG_NarcoticClass
    '    Me.GDRG_DosageFormClass = model.GDRG_DosageFormClass
    '    Me.GDRG_DrugFormType = model.GDRG_DrugFormType
    '    Me.GDRG_Syringeful = model.GDRG_Syringeful
    '    Me.GDRG_TransfusionUnit = model.GDRG_TransfusionUnit
    '    Me.GDRG_UsageCode = model.GDRG_UsageCode
    '    Me.GDRG_ExternalPartCode = model.GDRG_ExternalPartCode
    '    Me.GDRG_DosageClass = model.GDRG_DosageClass
    '    Me.GDRG_DoseTimes = model.GDRG_DoseTimes
    '    Me.GDRG_DoseDays = model.GDRG_DoseDays
    '    Me.GDRG_IntervalDays = model.GDRG_IntervalDays
    '    Me.GDRG_Dosage = model.GDRG_Dosage
    '    Me.GDRG_OnceMaxDosage = model.GDRG_OnceMaxDosage
    '    Me.GDRG_DailyMaxDosage = model.GDRG_DailyMaxDosage
    '    Me.GDRG_AdoptClass = model.GDRG_AdoptClass
    '    Me.GDRG_OrderMedicineFlag = model.GDRG_OrderMedicineFlag
    '    Me.GDRG_OrderInjectionFlag = model.GDRG_OrderInjectionFlag
    '    Me.GDRG_OrderTransfusionFlag = model.GDRG_OrderTransfusionFlag
    '    Me.GDRG_NerveDestroyFlag = model.GDRG_NerveDestroyFlag
    '    Me.GDRG_BiologyFlag = model.GDRG_BiologyFlag
    '    Me.GDRG_GenericFlag = model.GDRG_GenericFlag
    '    Me.GDRG_DentistrySpecialtyFlag = model.GDRG_DentistrySpecialtyFlag
    '    Me.GDRG_ContrastMediumFlag = model.GDRG_ContrastMediumFlag
    '    Me.GDRG_GrindFlag = model.GDRG_GrindFlag
    '    Me.GDRG_MixFlag = model.GDRG_MixFlag
    '    Me.GDRG_DissolveFlag = model.GDRG_DissolveFlag
    '    Me.GDRG_PTPFlag = model.GDRG_PTPFlag
    '    Me.GDRG_OneDosePackagFlag = model.GDRG_OneDosePackagFlag
    '    Me.GDRG_HospitalPreparationFlag = model.GDRG_HospitalPreparationFlag
    '    Me.GDRG_INDFlag = model.GDRG_INDFlag
    '    Me.GDRG_ExtraDrugFlag = model.GDRG_ExtraDrugFlag
    '    Me.GDRG_DiabetesFlag = model.GDRG_DiabetesFlag
    '    Me.GDRG_AnticancerDrugFlag = model.GDRG_AnticancerDrugFlag
    '    Me.GDRG_SubstituteHotCode1 = model.GDRG_SubstituteHotCode1
    '    Me.GDRG_SubstituteHotCode2 = model.GDRG_SubstituteHotCode2
    '    Me.GDRG_LabelPrintFlag = model.GDRG_LabelPrintFlag
    '    Me.GDRG_PatientLimitedFlag = model.GDRG_PatientLimitedFlag
    '    Me.GDRG_Remarks = model.GDRG_Remarks

    'End Sub
    '''' <summary>
    '''' 規定モデルを取得
    '''' </summary>
    '''' <returns>GM_Drug</returns>
    'Public Function GetOriginalModel() As GM_Drug

    '    Dim model As New GM_Drug

    '    model.GDRG_HotCode = Me.GDRG_HotCode
    '    model.GDRG_LogNo = Me.GDRG_LogNo
    '    model.GDRG_UpdateDate = Me.GDRG_UpdateDate
    '    model.GDRG_UpdateClientName = Me.GDRG_UpdateClientName
    '    model.GDRG_UpdateStaffID = Me.GDRG_UpdateStaffID
    '    model.GDRG_DelFlag = Me.GDRG_DelFlag
    '    model.GDRG_ValidDateFrom = Me.GDRG_ValidDateFrom
    '    model.GDRG_ValidDateTo = Me.GDRG_ValidDateTo
    '    model.GDRG_ReceiptCode = Me.GDRG_ReceiptCode
    '    model.GDRG_StandardCode = Me.GDRG_StandardCode
    '    model.GDRG_MHLWCode = Me.GDRG_MHLWCode
    '    model.GDRG_PublicCode = Me.GDRG_PublicCode
    '    model.GDRG_DrugName = Me.GDRG_DrugName
    '    model.GDRG_DrugKana = Me.GDRG_DrugKana
    '    model.GDRG_SalesName = Me.GDRG_SalesName
    '    model.GDRG_PublicName = Me.GDRG_PublicName
    '    model.GDRG_ComponentName = Me.GDRG_ComponentName
    '    model.GDRG_OriginalName = Me.GDRG_OriginalName
    '    model.GDRG_DisplayDrugName = Me.GDRG_DisplayDrugName
    '    model.GDRG_SearchKeyword = Me.GDRG_SearchKeyword
    '    model.GDRG_UnitInit = Me.GDRG_UnitInit
    '    model.GDRG_UnitReceipt = Me.GDRG_UnitReceipt
    '    model.GDRG_UnitPharm = Me.GDRG_UnitPharm
    '    model.GDRG_NarcoticClass = Me.GDRG_NarcoticClass
    '    model.GDRG_DosageFormClass = Me.GDRG_DosageFormClass
    '    model.GDRG_DrugFormType = Me.GDRG_DrugFormType
    '    model.GDRG_Syringeful = Me.GDRG_Syringeful
    '    model.GDRG_TransfusionUnit = Me.GDRG_TransfusionUnit
    '    model.GDRG_UsageCode = Me.GDRG_UsageCode
    '    model.GDRG_ExternalPartCode = Me.GDRG_ExternalPartCode
    '    model.GDRG_DosageClass = Me.GDRG_DosageClass
    '    model.GDRG_DoseTimes = Me.GDRG_DoseTimes
    '    model.GDRG_DoseDays = Me.GDRG_DoseDays
    '    model.GDRG_IntervalDays = Me.GDRG_IntervalDays
    '    model.GDRG_Dosage = Me.GDRG_Dosage
    '    model.GDRG_OnceMaxDosage = Me.GDRG_OnceMaxDosage
    '    model.GDRG_DailyMaxDosage = Me.GDRG_DailyMaxDosage
    '    model.GDRG_AdoptClass = Me.GDRG_AdoptClass
    '    model.GDRG_OrderMedicineFlag = Me.GDRG_OrderMedicineFlag
    '    model.GDRG_OrderInjectionFlag = Me.GDRG_OrderInjectionFlag
    '    model.GDRG_OrderTransfusionFlag = Me.GDRG_OrderTransfusionFlag
    '    model.GDRG_NerveDestroyFlag = Me.GDRG_NerveDestroyFlag
    '    model.GDRG_BiologyFlag = Me.GDRG_BiologyFlag
    '    model.GDRG_GenericFlag = Me.GDRG_GenericFlag
    '    model.GDRG_DentistrySpecialtyFlag = Me.GDRG_DentistrySpecialtyFlag
    '    model.GDRG_ContrastMediumFlag = Me.GDRG_ContrastMediumFlag
    '    model.GDRG_GrindFlag = Me.GDRG_GrindFlag
    '    model.GDRG_MixFlag = Me.GDRG_MixFlag
    '    model.GDRG_DissolveFlag = Me.GDRG_DissolveFlag
    '    model.GDRG_PTPFlag = Me.GDRG_PTPFlag
    '    model.GDRG_OneDosePackagFlag = Me.GDRG_OneDosePackagFlag
    '    model.GDRG_HospitalPreparationFlag = Me.GDRG_HospitalPreparationFlag
    '    model.GDRG_INDFlag = Me.GDRG_INDFlag
    '    model.GDRG_ExtraDrugFlag = Me.GDRG_ExtraDrugFlag
    '    model.GDRG_DiabetesFlag = Me.GDRG_DiabetesFlag
    '    model.GDRG_AnticancerDrugFlag = Me.GDRG_AnticancerDrugFlag
    '    model.GDRG_SubstituteHotCode1 = Me.GDRG_SubstituteHotCode1
    '    model.GDRG_SubstituteHotCode2 = Me.GDRG_SubstituteHotCode2
    '    model.GDRG_LabelPrintFlag = Me.GDRG_LabelPrintFlag
    '    model.GDRG_PatientLimitedFlag = Me.GDRG_PatientLimitedFlag
    '    model.GDRG_Remarks = Me.GDRG_Remarks

    '    Return model

    'End Function

End Class
