'Imports System.ComponentModel
'Imports System.ComponentModel.DataAnnotations
'''' <summary>
'''' M_Drugモデル
'''' </summary>
'''' <remarks></remarks>
'<MetadataType(GetType(M_DrugEXMetaData))>
'Public Class M_DrugEX
'    Inherits M_Drug

'    'Public Property MDRG_ValidDateFromCheck As Integer
'    Public Property MDRG_ValidDateToCheck As Integer

'    Public Property Unit As List(Of M_DrugUnit)     'この医薬品の使用単位全件
'    Public Property UnitName As List(Of VM_Name)    '単位名称マスタ
'    Public Property OptionList_ValidCheck As Dictionary(Of String, String)
'    Public Property OptionList_NarcoticClass As Dictionary(Of String, String)
'    Public Property OptionList_DosageFormClass As Dictionary(Of String, String)
'    Public Property OptionList_Flag1 As Dictionary(Of String, String)
'    Public Property OptionList_AdoptClass As Dictionary(Of String, String)
'    Public Property OptionList_ExternalPartCode As Dictionary(Of String, String)
'    Public Property OptionList_NerveDestroyFlag As Dictionary(Of String, String)
'    Public Property OptionList_BiologyFlag As Dictionary(Of String, String)
'    Public Property OptionList_GenericFlag As Dictionary(Of String, String)
'    Public Property OptionList_DentistrySpecialtyFlag As Dictionary(Of String, String)
'    Public Property OptionList_ContrastMediumFlag As Dictionary(Of String, String)
'    Public Property OptionList_GrindFlag As Dictionary(Of String, String)
'    Public Property OptionList_MixFlag As Dictionary(Of String, String)
'    Public Property OptionList_DissolveFlag As Dictionary(Of String, String)
'    Public Property OptionList_PTPFlag As Dictionary(Of String, String)
'    Public Property OptionList_OneDosePackagFlag As Dictionary(Of String, String)
'    Public Property OptionList_HospitalPreparationFlag As Dictionary(Of String, String)
'    Public Property OptionList_INDFlag As Dictionary(Of String, String)
'    Public Property OptionList_ExtraDrugFlag As Dictionary(Of String, String)
'    Public Property OptionList_DiabetesFlag As Dictionary(Of String, String)
'    Public Property OptionList_AnticancerDrugFlag As Dictionary(Of String, String)
'    Public Property OptionList_PatientLimitedFlag As Dictionary(Of String, String)
'    Public Property UpdateStaffName As String

'    '検索画面用
'    Public Property CDRG_HotCode As String
'    Public Property CDRG_DrugName As String
'    Public Property GDRG_HotCode As String
'    Public Property GDRG_DrugName As String
'    Public Property CM_DosageFormClass1 As String
'    Public Property CM_DosageFormClass4 As String
'    Public Property CM_DosageFormClass6 As String
'    Public Property GM_DosageFormClass1 As String
'    Public Property GM_DosageFormClass4 As String
'    Public Property GM_DosageFormClass6 As String
'    Public Property M_DosageFormClass1 As String
'    Public Property M_DosageFormClass4 As String
'    Public Property M_DosageFormClass6 As String
'    Public Property MaxLog As Integer
'    Public Property Authority As Boolean

'    Public Sub New()
'        MyBase.New()
'    End Sub
'    Public Sub New(db As AloeEntities, FacilityID As String)
'        MyBase.New()
'        Dim opt As New Options()
'        opt.db = db
'        '単位
'        'Me.UnitName = db.VM_Name.Where(Function(e) e.VNAM_NameClass = "CM04").ToList
'        Me.OptionList_ValidCheck = Options.GetOption_ValidCheckbox
'        Me.OptionList_DosageFormClass = opt.GetOption_DosageFormClass(FacilityID)
'        Me.OptionList_NarcoticClass = opt.GetOption_NarcoticClass(FacilityID)
'        Me.OptionList_Flag1 = Options.GetOption_Flag1
'        Me.OptionList_ExternalPartCode = opt.GetOption_ExternalPartCode(FacilityID)
'        Me.OptionList_AdoptClass = Options.GetOption_AdoptClass
'        Me.OptionList_NerveDestroyFlag = Options.GetOption_NerveDestroyFlag
'        Me.OptionList_BiologyFlag = Options.GetOption_BiologyFlag
'        Me.OptionList_GenericFlag = Options.GetOption_GenericFlag
'        Me.OptionList_DentistrySpecialtyFlag = Options.GetOption_DentistrySpecialtyFlag
'        Me.OptionList_ContrastMediumFlag = Options.GetOption_ContrastMediumFlag
'        Me.OptionList_GrindFlag = Options.GetOption_GrindFlag
'        Me.OptionList_MixFlag = Options.GetOption_MixFlag
'        Me.OptionList_DissolveFlag = Options.GetOption_DissolveFlag
'        Me.OptionList_PTPFlag = Options.GetOption_PTPFlag
'        Me.OptionList_OneDosePackagFlag = Options.GetOption_OneDosePackagFlag
'        Me.OptionList_HospitalPreparationFlag = Options.GetOption_HospitalPreparationFlag
'        Me.OptionList_INDFlag = Options.GetOption_INDFlag
'        Me.OptionList_ExtraDrugFlag = Options.GetOption_ExtraDrugFlag
'        Me.OptionList_DiabetesFlag = Options.GetOption_DiabetesFlag
'        Me.OptionList_AnticancerDrugFlag = Options.GetOption_AnticancerDrugFlag
'        Me.OptionList_PatientLimitedFlag = Options.GetOption_PatientLimitedFlag

'    End Sub
'    Public Sub New(db As AloeEntities, FacilityId As String, model As M_Drug)
'        Me.New(db, FacilityID)
'        Try
'            Me.SetFromOriginalModel(model)
'            '使用単位の取得
'            Me.Unit = db.M_DrugUnit.Where(Function(e) e.MDUT_FacilityID = Me.MDRG_FacilityID And e.MDUT_HotCode = Me.MDRG_HotCode).ToList

'            '使用単位の取得
'            Dim dtNow As DateTime = DateTime.Now
'            Dim query = From e In db.VM_Name
'                        Where e.VNAM_DelFlag = 0 And e.VNAM_NameClass = "CM04" And e.VNAM_FacilityID = Me.MDRG_FacilityID And e.VNAM_ValidDateFrom < dtNow
'                        Select e.VNAM_Name, e.VNAM_NameCode

'            Me.UnitName = New List(Of VM_Name)
'            For Each item In query.ToList
'                Dim mdl As New VM_Name
'                mdl.VNAM_Name = item.VNAM_Name
'                mdl.VNAM_NameCode = item.VNAM_NameCode
'                Me.UnitName.Add(mdl)
'            Next
'            '職員名
'            If Not String.IsNullOrWhiteSpace(Me.MDRG_UpdateStaffID) Then
'                Dim maxgroup = (From m In db.M_StaffBase
'                                Where m.MSTB_DelFlag = 0 And
'                                              m.MSTB_FacilityID = Me.MDRG_FacilityID And
'                                              m.MSTB_StaffID = Me.MDRG_UpdateStaffID
'                                Select m.MSTB_LogNo).ToList()

'                Dim maxval As Integer
'                If maxgroup.Count > 0 Then
'                    maxval = maxgroup.Max
'                    Dim staff = (From s As M_StaffBase In db.M_StaffBase
'                                 Where s.MSTB_FacilityID = Me.MDRG_FacilityID And
'                            s.MSTB_StaffID = Me.MDRG_UpdateStaffID And
'                            s.MSTB_DelFlag = 0 And
'                            s.MSTB_LogNo = maxval
'                                 Select New With {.staffname = s.MSTB_LastName & s.MSTB_MiddleName & s.MSTB_FirstName}).FirstOrDefault

'                    Me.UpdateStaffName = staff.staffname
'                End If

'            End If
'        Catch ex As Exception
'            Throw New Exception("Public Sub New(db As AloeEntities, model As M_Drug)" & ex.Message & ex.StackTrace)
'        End Try

'    End Sub

'    ''' <summary>
'    ''' 規定モデルから値をセット
'    ''' </summary>
'    ''' <param name="model"></param>
'    Public Sub SetFromOriginalModel(model As M_Drug)
'        Me.MDRG_FacilityID = If(String.IsNullOrEmpty(model.MDRG_FacilityID), model.MDRG_FacilityID, model.MDRG_FacilityID.Trim())
'        Me.MDRG_StatusClass = If(String.IsNullOrEmpty(model.MDRG_StatusClass), model.MDRG_StatusClass, model.MDRG_StatusClass.Trim())
'        Me.MDRG_HotCode = If(String.IsNullOrEmpty(model.MDRG_HotCode), model.MDRG_HotCode, model.MDRG_HotCode.Trim())
'        Me.MDRG_LogNo = model.MDRG_LogNo
'        Me.MDRG_UpdateDate = model.MDRG_UpdateDate
'        Me.MDRG_UpdateClientName = If(String.IsNullOrEmpty(model.MDRG_UpdateClientName), model.MDRG_UpdateClientName, model.MDRG_UpdateClientName.Trim())
'        Me.MDRG_UpdateStaffID = If(String.IsNullOrEmpty(model.MDRG_UpdateStaffID), model.MDRG_UpdateStaffID, model.MDRG_UpdateStaffID.Trim())
'        Me.MDRG_DelFlag = model.MDRG_DelFlag
'        Me.MDRG_ValidDateFrom = model.MDRG_ValidDateFrom
'        'Me.MDRG_ValidDateFromCheck = If(MDRG_ValidDateFrom.Date = UndefDateMin, 1, 0)
'        Me.MDRG_ValidDateTo = model.MDRG_ValidDateTo
'        Me.MDRG_ValidDateToCheck = If(MDRG_ValidDateTo.Date = UndefDateMax, 1, 0)
'        Me.MDRG_ReceiptCode = If(String.IsNullOrEmpty(model.MDRG_ReceiptCode), model.MDRG_ReceiptCode, model.MDRG_ReceiptCode.Trim())
'        Me.MDRG_StandardCode = If(String.IsNullOrEmpty(model.MDRG_StandardCode), model.MDRG_StandardCode, model.MDRG_StandardCode.Trim())
'        Me.MDRG_MHLWCode = If(String.IsNullOrEmpty(model.MDRG_MHLWCode), model.MDRG_MHLWCode, model.MDRG_MHLWCode.Trim())
'        Me.MDRG_PublicCode = If(String.IsNullOrEmpty(model.MDRG_PublicCode), model.MDRG_PublicCode, model.MDRG_PublicCode.Trim())
'        Me.MDRG_DrugName = If(String.IsNullOrEmpty(model.MDRG_DrugName), model.MDRG_DrugName, model.MDRG_DrugName.Trim())
'        Me.MDRG_DrugKana = If(String.IsNullOrEmpty(model.MDRG_DrugKana), model.MDRG_DrugKana, model.MDRG_DrugKana.Trim())
'        Me.MDRG_SalesName = If(String.IsNullOrEmpty(model.MDRG_SalesName), model.MDRG_SalesName, model.MDRG_SalesName.Trim())
'        Me.MDRG_PublicName = If(String.IsNullOrEmpty(model.MDRG_PublicName), model.MDRG_PublicName, model.MDRG_PublicName.Trim())
'        Me.MDRG_FormulationCode = If(String.IsNullOrEmpty(model.MDRG_FormulationCode), model.MDRG_FormulationCode, model.MDRG_FormulationCode.Trim())
'        Me.MDRG_DisplayDrugName = If(String.IsNullOrEmpty(model.MDRG_DisplayDrugName), model.MDRG_DisplayDrugName, model.MDRG_DisplayDrugName.Trim())
'        Me.MDRG_SearchKeyword = If(String.IsNullOrEmpty(model.MDRG_SearchKeyword), model.MDRG_SearchKeyword, model.MDRG_SearchKeyword.Trim())
'        Me.MDRG_ComponentName = If(String.IsNullOrEmpty(model.MDRG_ComponentName), model.MDRG_ComponentName, model.MDRG_ComponentName.Trim())
'        Me.MDRG_OriginalName = If(String.IsNullOrEmpty(model.MDRG_OriginalName), model.MDRG_OriginalName, model.MDRG_OriginalName.Trim())
'        Me.MDRG_UnitInit = model.MDRG_UnitInit
'        Me.MDRG_UnitReceipt = model.MDRG_UnitReceipt
'        Me.MDRG_UnitPharm = model.MDRG_UnitPharm
'        Me.MDRG_NarcoticClass = If(String.IsNullOrEmpty(model.MDRG_NarcoticClass), model.MDRG_NarcoticClass, model.MDRG_NarcoticClass.Trim())
'        Me.MDRG_DosageFormClass = If(String.IsNullOrEmpty(model.MDRG_DosageFormClass), model.MDRG_DosageFormClass, model.MDRG_DosageFormClass.Trim())
'        Me.MDRG_DrugFormType = If(String.IsNullOrEmpty(model.MDRG_DrugFormType), model.MDRG_DrugFormType, model.MDRG_DrugFormType.Trim())
'        Me.MDRG_Syringeful = model.MDRG_Syringeful
'        Me.MDRG_TransfusionUnit = model.MDRG_TransfusionUnit
'        Me.MDRG_UsageCode = If(String.IsNullOrEmpty(model.MDRG_UsageCode), model.MDRG_UsageCode, model.MDRG_UsageCode.Trim())
'        Me.MDRG_ExternalPartCode = If(String.IsNullOrEmpty(model.MDRG_ExternalPartCode), model.MDRG_ExternalPartCode, model.MDRG_ExternalPartCode.Trim())
'        Me.MDRG_DosageClass = If(String.IsNullOrEmpty(model.MDRG_DosageClass), model.MDRG_DosageClass, model.MDRG_DosageClass.Trim())
'        Me.MDRG_DoseTimes = model.MDRG_DoseTimes
'        Me.MDRG_DoseDays = model.MDRG_DoseDays
'        Me.MDRG_IntervalDays = model.MDRG_IntervalDays
'        Me.MDRG_Dosage = model.MDRG_Dosage
'        Me.MDRG_OnceMaxDosage = model.MDRG_OnceMaxDosage
'        Me.MDRG_DailyMaxDosage = model.MDRG_DailyMaxDosage
'        Me.MDRG_AdoptClass = If(String.IsNullOrEmpty(model.MDRG_AdoptClass), model.MDRG_AdoptClass, model.MDRG_AdoptClass.Trim())
'        Me.MDRG_OrderMedicineFlag = model.MDRG_OrderMedicineFlag
'        Me.MDRG_OrderInjectionFlag = model.MDRG_OrderInjectionFlag
'        Me.MDRG_OrderTransfusionFlag = model.MDRG_OrderTransfusionFlag
'        Me.MDRG_NerveDestroyFlag = model.MDRG_NerveDestroyFlag
'        Me.MDRG_BiologyFlag = model.MDRG_BiologyFlag
'        Me.MDRG_GenericFlag = model.MDRG_GenericFlag
'        Me.MDRG_DentistrySpecialtyFlag = model.MDRG_DentistrySpecialtyFlag
'        Me.MDRG_ContrastMediumFlag = model.MDRG_ContrastMediumFlag
'        Me.MDRG_GrindFlag = model.MDRG_GrindFlag
'        Me.MDRG_MixFlag = model.MDRG_MixFlag
'        Me.MDRG_DissolveFlag = model.MDRG_DissolveFlag
'        Me.MDRG_PTPFlag = model.MDRG_PTPFlag
'        Me.MDRG_OneDosePackagFlag = model.MDRG_OneDosePackagFlag
'        Me.MDRG_HospitalPreparationFlag = model.MDRG_HospitalPreparationFlag
'        Me.MDRG_INDFlag = model.MDRG_INDFlag
'        Me.MDRG_ExtraDrugFlag = model.MDRG_ExtraDrugFlag
'        Me.MDRG_DiabetesFlag = model.MDRG_DiabetesFlag
'        Me.MDRG_AnticancerDrugFlag = model.MDRG_AnticancerDrugFlag
'        Me.MDRG_SubstituteHotCode1 = If(String.IsNullOrEmpty(model.MDRG_SubstituteHotCode1), model.MDRG_SubstituteHotCode1, model.MDRG_SubstituteHotCode1.Trim())
'        Me.MDRG_SubstituteHotCode2 = If(String.IsNullOrEmpty(model.MDRG_SubstituteHotCode2), model.MDRG_SubstituteHotCode2, model.MDRG_SubstituteHotCode2.Trim())
'        Me.MDRG_LabelPrintFlag = model.MDRG_LabelPrintFlag
'        Me.MDRG_PatientLimitedFlag = model.MDRG_PatientLimitedFlag
'        Me.MDRG_Remarks = If(String.IsNullOrEmpty(model.MDRG_Remarks), model.MDRG_Remarks, model.MDRG_Remarks.Trim())

'        Me.MDRG_FacilityID = model.MDRG_FacilityID
'    End Sub
'    ''' <summary>
'    ''' 規定モデルを取得
'    ''' </summary>
'    ''' <returns>M_Drug</returns>
'    Public Function GetOriginalModel() As M_Drug

'        Dim model As New M_Drug
'        model.MDRG_FacilityID = If(String.IsNullOrEmpty(Me.MDRG_FacilityID), Me.MDRG_FacilityID, Me.MDRG_FacilityID.Trim())
'        model.MDRG_StatusClass = If(String.IsNullOrEmpty(Me.MDRG_StatusClass), Me.MDRG_StatusClass, Me.MDRG_StatusClass.Trim())
'        model.MDRG_HotCode = If(String.IsNullOrEmpty(Me.MDRG_HotCode), Me.MDRG_HotCode, Me.MDRG_HotCode.Trim())
'        model.MDRG_LogNo = Me.MDRG_LogNo
'        model.MDRG_UpdateDate = Me.MDRG_UpdateDate
'        model.MDRG_UpdateClientName = If(String.IsNullOrEmpty(Me.MDRG_UpdateClientName), Me.MDRG_UpdateClientName, Me.MDRG_UpdateClientName.Trim())
'        model.MDRG_UpdateStaffID = If(String.IsNullOrEmpty(Me.MDRG_UpdateStaffID), Me.MDRG_UpdateStaffID, Me.MDRG_UpdateStaffID.Trim())
'        model.MDRG_DelFlag = Me.MDRG_DelFlag
'        model.MDRG_ValidDateFrom = Me.MDRG_ValidDateFrom
'        model.MDRG_ValidDateTo = Me.MDRG_ValidDateTo
'        model.MDRG_ReceiptCode = If(String.IsNullOrEmpty(Me.MDRG_ReceiptCode), Me.MDRG_ReceiptCode, Me.MDRG_ReceiptCode.Trim())
'        model.MDRG_StandardCode = If(String.IsNullOrEmpty(Me.MDRG_StandardCode), Me.MDRG_StandardCode, Me.MDRG_StandardCode.Trim())
'        model.MDRG_MHLWCode = If(String.IsNullOrEmpty(Me.MDRG_MHLWCode), Me.MDRG_MHLWCode, Me.MDRG_MHLWCode.Trim())
'        model.MDRG_PublicCode = If(String.IsNullOrEmpty(Me.MDRG_PublicCode), Me.MDRG_PublicCode, Me.MDRG_PublicCode.Trim())
'        model.MDRG_FormulationCode = If(String.IsNullOrEmpty(Me.MDRG_FormulationCode), Me.MDRG_FormulationCode, Me.MDRG_FormulationCode.Trim())
'        model.MDRG_DrugName = If(String.IsNullOrEmpty(Me.MDRG_DrugName), Me.MDRG_DrugName, Me.MDRG_DrugName.Trim())
'        model.MDRG_DrugKana = If(String.IsNullOrEmpty(Me.MDRG_DrugKana), Me.MDRG_DrugKana, Me.MDRG_DrugKana.Trim())
'        model.MDRG_SalesName = If(String.IsNullOrEmpty(Me.MDRG_SalesName), Me.MDRG_SalesName, Me.MDRG_SalesName.Trim())
'        model.MDRG_PublicName = If(String.IsNullOrEmpty(Me.MDRG_PublicName), Me.MDRG_PublicName, Me.MDRG_PublicName.Trim())
'        model.MDRG_DisplayDrugName = If(String.IsNullOrEmpty(Me.MDRG_DisplayDrugName), Me.MDRG_DisplayDrugName, Me.MDRG_DisplayDrugName.Trim())
'        model.MDRG_SearchKeyword = If(String.IsNullOrEmpty(Me.MDRG_SearchKeyword), Me.MDRG_SearchKeyword, Me.MDRG_SearchKeyword.Trim())
'        model.MDRG_ComponentName = If(String.IsNullOrEmpty(Me.MDRG_ComponentName), Me.MDRG_ComponentName, Me.MDRG_ComponentName.Trim())
'        model.MDRG_OriginalName = If(String.IsNullOrEmpty(Me.MDRG_OriginalName), Me.MDRG_OriginalName, Me.MDRG_OriginalName.Trim())
'        model.MDRG_UnitInit = Me.MDRG_UnitInit
'        model.MDRG_UnitReceipt = Me.MDRG_UnitReceipt
'        model.MDRG_UnitPharm = Me.MDRG_UnitPharm
'        model.MDRG_NarcoticClass = If(String.IsNullOrEmpty(Me.MDRG_NarcoticClass), Me.MDRG_NarcoticClass, Me.MDRG_NarcoticClass.Trim())
'        model.MDRG_DosageFormClass = If(String.IsNullOrEmpty(Me.MDRG_DosageFormClass), Me.MDRG_DosageFormClass, Me.MDRG_DosageFormClass.Trim())
'        model.MDRG_DrugFormType = If(String.IsNullOrEmpty(Me.MDRG_DrugFormType), Me.MDRG_DrugFormType, Me.MDRG_DrugFormType.Trim())
'        model.MDRG_Syringeful = Me.MDRG_Syringeful
'        model.MDRG_TransfusionUnit = Me.MDRG_TransfusionUnit
'        model.MDRG_UsageCode = If(String.IsNullOrEmpty(Me.MDRG_UsageCode), Me.MDRG_UsageCode, Me.MDRG_UsageCode.Trim())
'        model.MDRG_ExternalPartCode = If(String.IsNullOrEmpty(Me.MDRG_ExternalPartCode), Me.MDRG_ExternalPartCode, Me.MDRG_ExternalPartCode.Trim())
'        model.MDRG_DosageClass = If(String.IsNullOrEmpty(Me.MDRG_DosageClass), Me.MDRG_DosageClass, Me.MDRG_DosageClass.Trim())
'        model.MDRG_DoseTimes = Me.MDRG_DoseTimes
'        model.MDRG_DoseDays = Me.MDRG_DoseDays
'        model.MDRG_IntervalDays = Me.MDRG_IntervalDays
'        model.MDRG_Dosage = Me.MDRG_Dosage
'        model.MDRG_OnceMaxDosage = Me.MDRG_OnceMaxDosage
'        model.MDRG_DailyMaxDosage = Me.MDRG_DailyMaxDosage
'        model.MDRG_AdoptClass = If(String.IsNullOrEmpty(Me.MDRG_AdoptClass), Me.MDRG_AdoptClass, Me.MDRG_AdoptClass.Trim())
'        model.MDRG_OrderMedicineFlag = Me.MDRG_OrderMedicineFlag
'        model.MDRG_OrderInjectionFlag = Me.MDRG_OrderInjectionFlag
'        model.MDRG_OrderTransfusionFlag = Me.MDRG_OrderTransfusionFlag
'        model.MDRG_NerveDestroyFlag = Me.MDRG_NerveDestroyFlag
'        model.MDRG_BiologyFlag = Me.MDRG_BiologyFlag
'        model.MDRG_GenericFlag = Me.MDRG_GenericFlag
'        model.MDRG_DentistrySpecialtyFlag = Me.MDRG_DentistrySpecialtyFlag
'        model.MDRG_ContrastMediumFlag = Me.MDRG_ContrastMediumFlag
'        model.MDRG_GrindFlag = Me.MDRG_GrindFlag
'        model.MDRG_MixFlag = Me.MDRG_MixFlag
'        model.MDRG_DissolveFlag = Me.MDRG_DissolveFlag
'        model.MDRG_PTPFlag = Me.MDRG_PTPFlag
'        model.MDRG_OneDosePackagFlag = Me.MDRG_OneDosePackagFlag
'        model.MDRG_HospitalPreparationFlag = Me.MDRG_HospitalPreparationFlag
'        model.MDRG_INDFlag = Me.MDRG_INDFlag
'        model.MDRG_ExtraDrugFlag = Me.MDRG_ExtraDrugFlag
'        model.MDRG_DiabetesFlag = Me.MDRG_DiabetesFlag
'        model.MDRG_AnticancerDrugFlag = Me.MDRG_AnticancerDrugFlag
'        model.MDRG_SubstituteHotCode1 = If(String.IsNullOrEmpty(Me.MDRG_SubstituteHotCode1), Me.MDRG_SubstituteHotCode1, Me.MDRG_SubstituteHotCode1.Trim())
'        model.MDRG_SubstituteHotCode2 = If(String.IsNullOrEmpty(Me.MDRG_SubstituteHotCode2), Me.MDRG_SubstituteHotCode2, Me.MDRG_SubstituteHotCode2.Trim())
'        model.MDRG_LabelPrintFlag = Me.MDRG_LabelPrintFlag
'        model.MDRG_PatientLimitedFlag = Me.MDRG_PatientLimitedFlag
'        model.MDRG_Remarks = If(String.IsNullOrEmpty(Me.MDRG_Remarks), Me.MDRG_Remarks, Me.MDRG_Remarks.Trim())

'        Return model

'    End Function

'End Class
