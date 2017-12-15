Public Class CM_DrugEX
    'Inherits CM_Drug

    'Public Property Unit As List(Of GM_DrugUnit)     'この医薬品の使用単位全件
    'Public Property UnitName As List(Of VM_Name)    '単位名称マスタ
    'Public Property OptionList_NarcoticClass As Dictionary(Of String, String)
    'Public Property OptionList_DosageFormClass As Dictionary(Of String, String)
    'Public Property OptionList_Flag1 As Dictionary(Of String, String)
    'Public Property OptionList_AdoptClass As Dictionary(Of String, String)
    'Public Property OptionList_NerveDestroyFlag As Dictionary(Of String, String)
    'Public Property OptionList_BiologyFlag As Dictionary(Of String, String)
    'Public Property OptionList_GenericFlag As Dictionary(Of String, String)
    'Public Property OptionList_DentistrySpecialtyFlag As Dictionary(Of String, String)
    'Public Property OptionList_ContrastMediumFlag As Dictionary(Of String, String)
    'Public Property OptionList_GrindFlag As Dictionary(Of String, String)
    'Public Property OptionList_MixFlag As Dictionary(Of String, String)
    'Public Property OptionList_DissolveFlag As Dictionary(Of String, String)
    'Public Property OptionList_PTPFlag As Dictionary(Of String, String)
    'Public Property OptionList_OneDosePackagFlag As Dictionary(Of String, String)
    'Public Property OptionList_HospitalPreparationFlag As Dictionary(Of String, String)
    'Public Property OptionList_INDFlag As Dictionary(Of String, String)
    'Public Property OptionList_ExtraDrugFlag As Dictionary(Of String, String)
    'Public Property OptionList_DiabetesFlag As Dictionary(Of String, String)
    'Public Property OptionList_AnticancerDrugFlag As Dictionary(Of String, String)
    'Public Property UpdateStaffName As String

    '検索画面用
    Public Property Count As Integer
    Public Property Optiont_CheckFlag As Boolean

    Public Sub New()
        MyBase.New()
    End Sub
    'Public Sub New(db As AsamaEntities)
    '    MyBase.New()
    '    Dim opt As New Options()
    '    opt.db = db
    '    '単位
    '    Me.UnitName = db.VM_Name.Where(Function(e) e.VNAM_NameClass = "CM04").ToList
    '    Me.OptionList_DosageFormClass = opt.GetOption_DosageFormClass
    '    Me.OptionList_NarcoticClass = opt.GetOption_NarcoticClass
    '    Me.OptionList_Flag1 = Options.GetOption_Flag1
    '    Me.OptionList_AdoptClass = Options.GetOption_AdoptClass
    '    Me.OptionList_NerveDestroyFlag = Options.GetOption_NerveDestroyFlag
    '    Me.OptionList_BiologyFlag = Options.GetOption_BiologyFlag
    '    Me.OptionList_GenericFlag = Options.GetOption_GenericFlag
    '    Me.OptionList_DentistrySpecialtyFlag = Options.GetOption_DentistrySpecialtyFlag
    '    Me.OptionList_ContrastMediumFlag = Options.GetOption_ContrastMediumFlag
    '    Me.OptionList_GrindFlag = Options.GetOption_GrindFlag
    '    Me.OptionList_MixFlag = Options.GetOption_MixFlag
    '    Me.OptionList_DissolveFlag = Options.GetOption_DissolveFlag
    '    Me.OptionList_PTPFlag = Options.GetOption_PTPFlag
    '    Me.OptionList_OneDosePackagFlag = Options.GetOption_OneDosePackagFlag
    '    Me.OptionList_HospitalPreparationFlag = Options.GetOption_HospitalPreparationFlag
    '    Me.OptionList_INDFlag = Options.GetOption_INDFlag
    '    Me.OptionList_ExtraDrugFlag = Options.GetOption_ExtraDrugFlag
    '    Me.OptionList_DiabetesFlag = Options.GetOption_DiabetesFlag
    '    Me.OptionList_AnticancerDrugFlag = Options.GetOption_AnticancerDrugFlag

    'End Sub
    'Public Sub New(db As AsamaEntities, model As GM_Drug)
    '    Me.New(db)
    '    Me.SetFromOriginalModel(model)
    '    '使用単位の取得
    '    Me.Unit = db.GM_DrugUnit.Where(Function(e) e.GDUT_HotCode = Me.GDRG_HotCode).ToList
    'End Sub
    '''' <summary>
    '''' 規定モデルから値をセット
    '''' </summary>
    '''' <param name="model"></param>
    ''Public Sub SetFromOriginalModel(model As CM_Drug)

    '    CDRG_StandardCode = model.CDRG_StandardCode
    '    CDRG_JANCode = model.CDRG_JANCode
    '    CDRG_PackUnit = model.CDRG_PackUnit
    '    CDRG_PackTotalUnit = model.CDRG_PackTotalUnit
    '    CDRG_MakerCompany = model.CDRG_MakerCompany
    '    CDRG_SalesCompany = model.CDRG_SalesCompany
    '    CDRG_Hot7Code = model.CDRG_Hot7Code
    '    CDRG_CompanyCode = model.CDRG_CompanyCode
    '    CDRG_ReceiptCode = model.CDRG_ReceiptCode
    '    CDRG_MhlwCode = model.CDRG_MhlwCode
    '    CDRG_IndividualCode = model.CDRG_IndividualCode
    '    CDRG_PublicCode = model.CDRG_PublicCode
    '    CDRG_DrugName = model.CDRG_DrugName
    '    CDRG_DrugKana = model.CDRG_DrugKana
    '    CDRG_SalesName = model.CDRG_SalesName
    '    CDRG_PublicName = model.CDRG_PublicName
    '    CDRG_ComponentName = model.CDRG_ComponentName
    '    CDRG_OriginalName = model.CDRG_OriginalName
    '    CDRG_UnitCode = model.CDRG_UnitCode
    '    CDRG_NarcoticClass = model.CDRG_NarcoticClass
    '    CDRG_DosageFormClass = model.CDRG_DosageFormClass
    '    CDRG_Syringeful = model.CDRG_Syringeful
    '    CDRG_NerveDestroyFlag = model.CDRG_NerveDestroyFlag
    '    CDRG_BiologyFlag = model.CDRG_BiologyFlag
    '    CDRG_GenericFlag = model.CDRG_GenericFlag
    '    CDRG_DentistrySpecialtyFlag = model.CDRG_DentistrySpecialtyFlag
    '    CDRG_ContrastMediumFlag = model.CDRG_ContrastMediumFlag
    '    CDRG_ValidDateFrom = model.CDRG_ValidDateFrom
    '    CDRG_ValidDateTo = model.CDRG_ValidDateTo

    'End Sub
    '''' <summary>
    '''' 規定モデルを取得
    '''' </summary>
    '''' <returns>GM_Drug</returns>
    'Public Function GetOriginalModel() As CM_Drug

    '    Dim model As New CM_Drug

    '    model.CDRG_StandardCode = CDRG_StandardCode
    '    model.CDRG_JANCode = CDRG_JANCode
    '    model.CDRG_PackUnit = CDRG_PackUnit
    '    model.CDRG_PackTotalUnit = CDRG_PackTotalUnit
    '    model.CDRG_MakerCompany = CDRG_MakerCompany
    '    model.CDRG_SalesCompany = CDRG_SalesCompany
    '    model.CDRG_Hot7Code = CDRG_Hot7Code
    '    model.CDRG_CompanyCode = CDRG_CompanyCode
    '    model.CDRG_ReceiptCode = CDRG_ReceiptCode
    '    model.CDRG_MhlwCode = CDRG_MhlwCode
    '    model.CDRG_IndividualCode = CDRG_IndividualCode
    '    model.CDRG_PublicCode = CDRG_PublicCode
    '    model.CDRG_DrugName = CDRG_DrugName
    '    model.CDRG_DrugKana = CDRG_DrugKana
    '    model.CDRG_SalesName = CDRG_SalesName
    '    model.CDRG_PublicName = CDRG_PublicName
    '    model.CDRG_ComponentName = CDRG_ComponentName
    '    model.CDRG_OriginalName = CDRG_OriginalName
    '    model.CDRG_UnitCode = CDRG_UnitCode
    '    model.CDRG_NarcoticClass = CDRG_NarcoticClass
    '    model.CDRG_DosageFormClass = CDRG_DosageFormClass
    '    model.CDRG_Syringeful = CDRG_Syringeful
    '    model.CDRG_NerveDestroyFlag = CDRG_NerveDestroyFlag
    '    model.CDRG_BiologyFlag = CDRG_BiologyFlag
    '    model.CDRG_GenericFlag = CDRG_GenericFlag
    '    model.CDRG_DentistrySpecialtyFlag = CDRG_DentistrySpecialtyFlag
    '    model.CDRG_ContrastMediumFlag = CDRG_ContrastMediumFlag
    '    model.CDRG_ValidDateFrom = CDRG_ValidDateFrom
    '    model.CDRG_ValidDateTo = CDRG_ValidDateTo

    '    Return model

    'End Function

End Class
