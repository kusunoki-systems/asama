Imports System.Data.Entity
Imports Asama

Public Class GM_DrugService

    'Public Function GM_ToSearch(db As AsamaEntities, conditionModel As GM_DrugCondition, MasterType As Integer) As List(Of GM_DrugEX)

    '    Dim dtNow As DateTime = DateTime.Now
    '    'LogNo最大値取得
    '    Dim maxgroup = From m In db.GM_Drug
    '                   Where m.GDRG_DelFlag = 0
    '                   Group m By m.GDRG_HotCode Into maxlog = Group
    '                   Select GDRG_HotCode, MaxLogNo = maxlog.Max(Function(x) x.GDRG_LogNo)

    '    Dim query = From e In db.GM_Drug
    '                Group Join m In maxgroup On e.GDRG_HotCode Equals m.GDRG_HotCode
    '                    Into maxgrp = Group
    '                From m In maxgrp.DefaultIfEmpty
    '                Where e.GDRG_DelFlag = 0
    '                Order By e.GDRG_HotCode, e.GDRG_ValidDateFrom
    '                Select e, m

    '    'タイプによって絞込みを変更
    '    Select Case MasterType
    '        Case 1
    '            query = From q In query Where (q.e.GDRG_DosageFormClass.Contains("1") _
    '                                    OrElse q.e.GDRG_DosageFormClass.Contains("4") _
    '                                    OrElse q.e.GDRG_DosageFormClass.Contains("6"))
    '        Case 2
    '            query = From q In query Where q.e.GDRG_DosageFormClass.Contains("3")
    '        Case 3
    '            query = From q In query Where q.e.GDRG_OrderTransfusionFlag = "1"
    '    End Select

    '    'MDRG_HotCode
    '    If Not String.IsNullOrEmpty(conditionModel.Model.GDRG_HotCode) Then
    '        query = From q In query Where q.e.GDRG_HotCode.Contains(conditionModel.Model.GDRG_HotCode)
    '    End If

    '    'MDRG_DrugName 部分一致
    '    If Not String.IsNullOrEmpty(conditionModel.Model.GDRG_DrugName) Then
    '        Dim strDrugName As String = conditionModel.Model.GDRG_DrugName
    '        query = From q In query Where (q.e.GDRG_DrugName.Contains(strDrugName) _
    '                                OrElse q.e.GDRG_DrugKana.Contains(strDrugName) _
    '                                OrElse q.e.GDRG_SalesName.Contains(strDrugName) _
    '                                OrElse q.e.GDRG_PublicName.Contains(strDrugName) _
    '                                OrElse q.e.GDRG_ComponentName.Contains(strDrugName) _
    '                                OrElse q.e.GDRG_OriginalName.Contains(strDrugName))
    '    End If

    '    'MDRG_DosageFormClass
    '    If Not String.IsNullOrEmpty(conditionModel.Model.GDRG_DosageFormClass) Then
    '        Dim s As String() = conditionModel.Model.GDRG_DosageFormClass.Split(",")
    '        query = From q In query Where s.Contains(q.e.GDRG_DosageFormClass)
    '    End If

    '    'GM_DrugEXに詰め替える
    '    Dim mdls As New List(Of GM_DrugEX)

    '    For Each Item In query.ToList
    '        Dim mdl As New GM_DrugEX
    '        mdl.SetFromOriginalModel(Item.e)
    '        mdl.MaxLog = Item.m.MaxLogNo
    '        mdls.Add(mdl)
    '    Next

    '    Return mdls

    'End Function

    'Public Function M_ToSearch(db As AsamaEntities, conditionModel As GM_DrugCondition, MasterType As Integer, FacilityID As String) As List(Of GM_DrugEX)

    '    Dim dtNow As DateTime = DateTime.Now
    '    'REP START 2017-08-08 FSI星野 #11912 病院の薬品マスタ(M_Drug)に存在しないものが表示されない
    '    'Dim query = From e In db.GM_Drug _
    '    '            Group Join m In db.M_Drug On e.GDRG_HotCode Equals m.MDRG_HotCode Into ords = Group _
    '    '            From m In ords.DefaultIfEmpty
    '    '            Where e.GDRG_DelFlag = 0 And e.GDRG_ValidDateTo >= dtNow And m.MDRG_FacilityID = FacilityID
    '    '            Order By e.GDRG_HotCode, e.GDRG_ValidDateFrom
    '    '            Select New With {e, m}
    '    Dim mDurg = From m In db.M_Drug
    '                Where m.MDRG_FacilityID = FacilityID
    '                Select m
    '    Dim query = From e In db.GM_Drug
    '                Group Join m In mDurg On e.GDRG_HotCode Equals m.MDRG_HotCode Into ords = Group
    '                From m In ords.DefaultIfEmpty
    '                Where e.GDRG_DelFlag = 0 And e.GDRG_ValidDateTo >= dtNow
    '                Select New With {.GDRG_LogNo = e.GDRG_LogNo,
    '                                 .GDRG_HotCode = e.GDRG_HotCode,
    '                                 .GDRG_UpdateDate = e.GDRG_UpdateDate,
    '                                 .GDRG_UpdateClientName = e.GDRG_UpdateClientName,
    '                                 .GDRG_UpdateStaffID = e.GDRG_UpdateStaffID,
    '                                 .GDRG_DelFlag = e.GDRG_DelFlag,
    '                                 .GDRG_ValidDateFrom = e.GDRG_ValidDateFrom,
    '                                 .GDRG_ValidDateTo = e.GDRG_ValidDateTo,
    '                                 .GDRG_ReceiptCode = e.GDRG_ReceiptCode,
    '                                 .GDRG_StandardCode = e.GDRG_StandardCode,
    '                                 .GDRG_MHLWCode = e.GDRG_MHLWCode,
    '                                 .GDRG_PublicCode = e.GDRG_PublicCode,
    '                                 .GDRG_DrugName = e.GDRG_DrugName,
    '                                 .GDRG_DrugKana = e.GDRG_DrugKana,
    '                                 .GDRG_SalesName = e.GDRG_SalesName,
    '                                 .GDRG_PublicName = e.GDRG_PublicName,
    '                                 .GDRG_ComponentName = e.GDRG_ComponentName,
    '                                 .GDRG_OriginalName = e.GDRG_OriginalName,
    '                                 .GDRG_DisplayDrugName = e.GDRG_DisplayDrugName,
    '                                 .GDRG_SearchKeyword = e.GDRG_SearchKeyword,
    '                                 .GDRG_UnitInit = e.GDRG_UnitInit,
    '                                 .GDRG_UnitReceipt = e.GDRG_UnitReceipt,
    '                                 .GDRG_UnitPharm = e.GDRG_UnitPharm,
    '                                 .GDRG_NarcoticClass = e.GDRG_NarcoticClass,
    '                                 .GDRG_DosageFormClass = e.GDRG_DosageFormClass,
    '                                 .GDRG_DrugFormType = e.GDRG_DrugFormType,
    '                                 .GDRG_Syringeful = e.GDRG_Syringeful,
    '                                 .GDRG_UsageCode = e.GDRG_UsageCode,
    '                                 .GDRG_ExternalPartCode = e.GDRG_ExternalPartCode,
    '                                 .GDRG_DosageClass = e.GDRG_DosageClass,
    '                                 .GDRG_DoseTimes = e.GDRG_DoseTimes,
    '                                 .GDRG_DoseDays = e.GDRG_DoseDays,
    '                                 .GDRG_IntervalDays = e.GDRG_IntervalDays,
    '                                 .GDRG_Dosage = e.GDRG_Dosage,
    '                                 .GDRG_OnceMaxDosage = e.GDRG_OnceMaxDosage,
    '                                 .GDRG_DailyMaxDosage = e.GDRG_DailyMaxDosage,
    '                                 .GDRG_AdoptClass = e.GDRG_AdoptClass,
    '                                 .GDRG_OrderMedicineFlag = e.GDRG_OrderMedicineFlag,
    '                                 .GDRG_OrderInjectionFlag = e.GDRG_OrderInjectionFlag,
    '                                 .GDRG_NerveDestroyFlag = e.GDRG_NerveDestroyFlag,
    '                                 .GDRG_BiologyFlag = e.GDRG_BiologyFlag,
    '                                 .GDRG_GenericFlag = e.GDRG_GenericFlag,
    '                                 .GDRG_DentistrySpecialtyFlag = e.GDRG_DentistrySpecialtyFlag,
    '                                 .GDRG_ContrastMediumFlag = e.GDRG_ContrastMediumFlag,
    '                                 .GDRG_GrindFlag = e.GDRG_GrindFlag,
    '                                 .GDRG_MixFlag = e.GDRG_MixFlag,
    '                                 .GDRG_DissolveFlag = e.GDRG_DissolveFlag,
    '                                 .GDRG_PTPFlag = e.GDRG_PTPFlag,
    '                                 .GDRG_OneDosePackagFlag = e.GDRG_OneDosePackagFlag,
    '                                 .GDRG_HospitalPreparationFlag = e.GDRG_HospitalPreparationFlag,
    '                                 .GDRG_INDFlag = e.GDRG_INDFlag,
    '                                 .GDRG_ExtraDrugFlag = e.GDRG_ExtraDrugFlag,
    '                                 .GDRG_DiabetesFlag = e.GDRG_DiabetesFlag,
    '                                 .GDRG_AnticancerDrugFlag = e.GDRG_AnticancerDrugFlag,
    '                                 .GDRG_SubstituteHotCode1 = e.GDRG_SubstituteHotCode1,
    '                                 .GDRG_SubstituteHotCode2 = e.GDRG_SubstituteHotCode2,
    '                                 .GDRG_LabelPrintFlag = e.GDRG_LabelPrintFlag,
    '                                 .GDRG_TransfusionUnit = e.GDRG_TransfusionUnit,
    '                                 .GDRG_OrderTransfusionFlag = e.GDRG_OrderTransfusionFlag,
    '                                 .GDRG_PatientLimitedFlag = e.GDRG_PatientLimitedFlag,
    '                                 .GDRG_Remarks = e.GDRG_Remarks,
    '                                 .MDRG_FacilityID = m.MDRG_FacilityID,
    '                                 .MDRG_HotCode = m.MDRG_HotCode,
    '                                 .MDRG_DelFlag = If(m.MDRG_DelFlag = Nothing, m.MDRG_DelFlag, 1)}
    '    'REP END   2017-08-08 FSI星野 #11912 病院の薬品マスタ(M_Drug)に存在しないものが表示されない

    '    'タイプによって絞込みを変更
    '    Select Case MasterType
    '        Case 1
    '            query = From q In query Where (q.GDRG_DosageFormClass.Contains("1") _
    '                                    OrElse q.GDRG_DosageFormClass.Contains("4") _
    '                                    OrElse q.GDRG_DosageFormClass.Contains("6")) _
    '                                    And q.GDRG_OrderTransfusionFlag <> "1"
    '        Case 2
    '            query = From q In query Where q.GDRG_DosageFormClass.Contains("3")
    '        Case 3
    '            query = From q In query Where q.GDRG_OrderTransfusionFlag = "1"
    '    End Select

    '    'MDRG_HotCode
    '    If Not String.IsNullOrEmpty(conditionModel.Model.GDRG_HotCode) Then
    '        query = From q In query Where q.GDRG_HotCode.Contains(conditionModel.Model.GDRG_HotCode)
    '    End If

    '    'MDRG_DrugName 部分一致
    '    If Not String.IsNullOrEmpty(conditionModel.Model.GDRG_DrugName) Then
    '        Dim strDrugName As String = conditionModel.Model.GDRG_DrugName
    '        query = From q In query Where (q.GDRG_DrugName.Contains(strDrugName) _
    '                                OrElse q.GDRG_DrugKana.Contains(strDrugName) _
    '                                OrElse q.GDRG_SalesName.Contains(strDrugName) _
    '                                OrElse q.GDRG_PublicName.Contains(strDrugName) _
    '                                OrElse q.GDRG_ComponentName.Contains(strDrugName) _
    '                                OrElse q.GDRG_OriginalName.Contains(strDrugName))
    '    End If

    '    'MDRG_DosageFormClass
    '    If Not String.IsNullOrEmpty(conditionModel.Model.GDRG_DosageFormClass) Then
    '        Dim s As String() = conditionModel.Model.GDRG_DosageFormClass.Split(",")
    '        query = From q In query Where s.Contains(q.GDRG_DosageFormClass)
    '    End If

    '    'ADD START 2017-08-08 FSI星野 #11912 病院の薬品マスタ(M_Drug)に存在しないものが表示されない
    '    'Distinct掛ける
    '    query = (From q In query Select q).Distinct
    '    query = From q In query Order By q.GDRG_HotCode, q.GDRG_ValidDateFrom
    '    'ADD END   2017-08-08 FSI星野 #11912 病院の薬品マスタ(M_Drug)に存在しないものが表示されない

    '    'GM_DrugEXに詰め替える
    '    Dim mdls As New List(Of GM_DrugEX)
    '    Dim HotCode As String = String.Empty

    '    'REP START 2017-08-08 FSI星野 #11912 病院の薬品マスタ(M_Drug)に存在しないものが表示されない
    '    'For Each eg_Item In query.ToList
    '    '    Dim mdl As New GM_DrugEX
    '    '    mdl.SetFromOriginalModel(eg_Item.e)

    '    '    'MのHotCodeが存在するか確認
    '    '    If eg_Item.m Is Nothing Then

    '    For Each Item In query.ToList

    '        If HotCode <> Item.GDRG_HotCode Then
    '            Dim mdl As New GM_DrugEX
    '            mdl.GDRG_LogNo = Item.GDRG_LogNo
    '            mdl.GDRG_HotCode = Item.GDRG_HotCode
    '            mdl.GDRG_UpdateDate = Item.GDRG_UpdateDate
    '            mdl.GDRG_UpdateClientName = Item.GDRG_UpdateClientName
    '            mdl.GDRG_UpdateStaffID = Item.GDRG_UpdateStaffID
    '            mdl.GDRG_DelFlag = Item.GDRG_DelFlag
    '            mdl.GDRG_ValidDateFrom = Item.GDRG_ValidDateFrom
    '            mdl.GDRG_ValidDateTo = Item.GDRG_ValidDateTo
    '            mdl.GDRG_ReceiptCode = Item.GDRG_ReceiptCode
    '            mdl.GDRG_StandardCode = Item.GDRG_StandardCode
    '            mdl.GDRG_MHLWCode = Item.GDRG_MHLWCode
    '            mdl.GDRG_PublicCode = Item.GDRG_PublicCode
    '            mdl.GDRG_DrugName = Item.GDRG_DrugName
    '            mdl.GDRG_DrugKana = Item.GDRG_DrugKana
    '            mdl.GDRG_SalesName = Item.GDRG_SalesName
    '            mdl.GDRG_PublicName = Item.GDRG_PublicName
    '            mdl.GDRG_ComponentName = Item.GDRG_ComponentName
    '            mdl.GDRG_OriginalName = Item.GDRG_OriginalName
    '            mdl.GDRG_DisplayDrugName = Item.GDRG_DisplayDrugName
    '            mdl.GDRG_SearchKeyword = Item.GDRG_SearchKeyword
    '            mdl.GDRG_UnitInit = Item.GDRG_UnitInit
    '            mdl.GDRG_UnitReceipt = Item.GDRG_UnitReceipt
    '            mdl.GDRG_UnitPharm = Item.GDRG_UnitPharm
    '            mdl.GDRG_NarcoticClass = Item.GDRG_NarcoticClass
    '            mdl.GDRG_DosageFormClass = Item.GDRG_DosageFormClass
    '            mdl.GDRG_DrugFormType = Item.GDRG_DrugFormType
    '            mdl.GDRG_Syringeful = Item.GDRG_Syringeful
    '            mdl.GDRG_UsageCode = Item.GDRG_UsageCode
    '            mdl.GDRG_ExternalPartCode = Item.GDRG_ExternalPartCode
    '            mdl.GDRG_DosageClass = Item.GDRG_DosageClass
    '            mdl.GDRG_DoseTimes = Item.GDRG_DoseTimes
    '            mdl.GDRG_DoseDays = Item.GDRG_DoseDays
    '            mdl.GDRG_IntervalDays = Item.GDRG_IntervalDays
    '            mdl.GDRG_Dosage = Item.GDRG_Dosage
    '            mdl.GDRG_OnceMaxDosage = Item.GDRG_OnceMaxDosage
    '            mdl.GDRG_DailyMaxDosage = Item.GDRG_DailyMaxDosage
    '            mdl.GDRG_AdoptClass = Item.GDRG_AdoptClass
    '            mdl.GDRG_OrderMedicineFlag = Item.GDRG_OrderMedicineFlag
    '            mdl.GDRG_OrderInjectionFlag = Item.GDRG_OrderInjectionFlag
    '            mdl.GDRG_NerveDestroyFlag = Item.GDRG_NerveDestroyFlag
    '            mdl.GDRG_BiologyFlag = Item.GDRG_BiologyFlag
    '            mdl.GDRG_GenericFlag = Item.GDRG_GenericFlag
    '            mdl.GDRG_DentistrySpecialtyFlag = Item.GDRG_DentistrySpecialtyFlag
    '            mdl.GDRG_ContrastMediumFlag = Item.GDRG_ContrastMediumFlag
    '            mdl.GDRG_GrindFlag = Item.GDRG_GrindFlag
    '            mdl.GDRG_MixFlag = Item.GDRG_MixFlag
    '            mdl.GDRG_DissolveFlag = Item.GDRG_DissolveFlag
    '            mdl.GDRG_PTPFlag = Item.GDRG_PTPFlag
    '            mdl.GDRG_OneDosePackagFlag = Item.GDRG_OneDosePackagFlag
    '            mdl.GDRG_HospitalPreparationFlag = Item.GDRG_HospitalPreparationFlag
    '            mdl.GDRG_INDFlag = Item.GDRG_INDFlag
    '            mdl.GDRG_ExtraDrugFlag = Item.GDRG_ExtraDrugFlag
    '            mdl.GDRG_DiabetesFlag = Item.GDRG_DiabetesFlag
    '            mdl.GDRG_AnticancerDrugFlag = Item.GDRG_AnticancerDrugFlag
    '            mdl.GDRG_SubstituteHotCode1 = Item.GDRG_SubstituteHotCode1
    '            mdl.GDRG_SubstituteHotCode2 = Item.GDRG_SubstituteHotCode2
    '            mdl.GDRG_LabelPrintFlag = Item.GDRG_LabelPrintFlag
    '            mdl.GDRG_TransfusionUnit = Item.GDRG_TransfusionUnit
    '            mdl.GDRG_OrderTransfusionFlag = Item.GDRG_OrderTransfusionFlag
    '            mdl.GDRG_PatientLimitedFlag = Item.GDRG_PatientLimitedFlag
    '            mdl.GDRG_Remarks = Item.GDRG_Remarks

    '            'MのHotCodeが存在するか確認
    '            If Item.MDRG_HotCode Is Nothing OrElse Item.MDRG_DelFlag = "1" Then
    '                '存在しない場合はFalseを入れる
    '                mdl.Optiont_CheckFlag = False
    '            Else
    '                '存在した場合はTrueを入れる
    '                mdl.Optiont_CheckFlag = True
    '            End If
    '            mdls.Add(mdl)
    '        End If
    '        HotCode = Item.GDRG_HotCode

    '    Next
    '    'REP END   2017-08-08 FSI星野 #11912 病院の薬品マスタ(M_Drug)に存在しないものが表示されない

    '    Return mdls

    'End Function

    '''' <summary>
    '''' GMマスタからMマスタへコピーを行う
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="dicCheckItem"></param>
    '''' <param name="FacilityId"></param>
    '''' <param name="StaffID"></param>
    '''' <param name="MachineName"></param>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Function M_ToCopy(db As AsamaEntities, dicCheckItem As Dictionary(Of String, String), MasterType As String, FacilityId As String, StaffID As String, MachineName As String) As List(Of M_DrugEX)

    '    Dim m_DrugEX As New M_DrugEX
    '    Dim m_DrugUnitEX As New M_DrugUnitEX

    '    Dim strItemKey As String = String.Empty
    '    Dim dtNow As DateTime = DateTime.Now

    '    For Each Item In dicCheckItem
    '        If String.IsNullOrEmpty(strItemKey) Then
    '            strItemKey = Item.Key
    '        Else
    '            strItemKey += "," & Item.Key
    '        End If

    '        'MDrugに該当レコードがあるか調べる
    '        Dim maxgroup = From m In db.M_Drug
    '                       Where m.MDRG_FacilityID = FacilityId And m.MDRG_HotCode = Item.Key
    '                       Group m By m.MDRG_FacilityID, m.MDRG_HotCode Into maxlog = Group
    '                       Select MDRG_FacilityID, MDRG_HotCode, MaxLogNo = maxlog.Max(Function(x) x.MDRG_LogNo)
    '        Dim LogNo As String = "1"
    '        'LogNoの取得
    '        If maxgroup.Count > 0 Then
    '            'Maxの値をLogNoとする
    '            For Each m In maxgroup
    '                LogNo = m.MaxLogNo + 1
    '            Next
    '        End If

    '        'MDrugUnitの有無確認
    '        Dim mUnit = From m In db.M_DrugUnit
    '                    Where m.MDUT_FacilityID = FacilityId And m.MDUT_HotCode = Item.Key
    '                    Select m

    '        'GMDrugの該当レコードを取得する
    '        Dim gm_Drug = From e In db.GM_Drug
    '                      Where e.GDRG_HotCode = Item.Key And e.GDRG_LogNo = Item.Value
    '                      Select New With
    '                         {.MDRG_FacilityID = FacilityId,
    '                          .MDRG_StatusClass = "1",
    '                          .MDRG_HotCode = e.GDRG_HotCode,
    '                          .MDRG_LogNo = LogNo,
    '                          .MDRG_UpdateDate = dtNow,
    '                          .MDRG_UpdateClientName = MachineName,
    '                          .MDRG_UpdateStaffID = StaffID,
    '                          .MDRG_DelFlag = 0,
    '                          .MDRG_ValidDateFrom = CType("1900/01/01", Date),
    '                          .MDRG_ValidDateTo = CType("2900/12/31", Date),
    '                          .MDRG_ReceiptCode = e.GDRG_ReceiptCode,
    '                          .MDRG_StandardCode = e.GDRG_StandardCode,
    '                          .MDRG_MHLWCode = e.GDRG_MHLWCode,
    '                          .MDRG_PublicCode = e.GDRG_PublicCode,
    '                          .MDRG_DrugName = e.GDRG_DrugName,
    '                          .MDRG_DrugKana = e.GDRG_DrugKana,
    '                          .MDRG_SalesName = e.GDRG_SalesName,
    '                          .MDRG_PublicName = e.GDRG_PublicName,
    '                          .MDRG_DisplayDrugName = e.GDRG_DisplayDrugName,
    '                          .MDRG_SearchKeyword = e.GDRG_SearchKeyword,
    '                          .MDRG_ComponentName = e.GDRG_ComponentName,
    '                          .MDRG_OriginalName = e.GDRG_OriginalName,
    '                          .MDRG_UnitInit = e.GDRG_UnitInit,
    '                          .MDRG_UnitReceipt = e.GDRG_UnitReceipt,
    '                          .MDRG_UnitPharm = e.GDRG_UnitPharm,
    '                          .MDRG_NarcoticClass = e.GDRG_NarcoticClass,
    '                          .MDRG_DosageFormClass = e.GDRG_DosageFormClass,
    '                          .MDRG_DrugFormType = e.GDRG_DrugFormType,
    '                          .MDRG_Syringeful = e.GDRG_Syringeful,
    '                          .MDRG_UsageCode = e.GDRG_UsageCode,
    '                          .MDRG_ExternalPartCode = e.GDRG_ExternalPartCode,
    '                          .MDRG_DosageClass = e.GDRG_DosageClass,
    '                          .MDRG_DoseTimes = e.GDRG_DoseTimes,
    '                          .MDRG_DoseDays = e.GDRG_DoseDays,
    '                          .MDRG_IntervalDays = e.GDRG_IntervalDays,
    '                          .MDRG_Dosage = e.GDRG_Dosage,
    '                          .MDRG_OnceMaxDosage = e.GDRG_OnceMaxDosage,
    '                          .MDRG_DailyMaxDosage = e.GDRG_DailyMaxDosage,
    '                          .MDRG_AdoptClass = e.GDRG_AdoptClass,
    '                          .MDRG_OrderMedicineFlag = e.GDRG_OrderMedicineFlag,
    '                          .MDRG_OrderInjectionFlag = e.GDRG_OrderInjectionFlag,
    '                          .MDRG_OrderTransfusionFlag = e.GDRG_OrderTransfusionFlag,
    '                          .MDRG_NerveDestroyFlag = e.GDRG_NerveDestroyFlag,
    '                          .MDRG_BiologyFlag = e.GDRG_BiologyFlag,
    '                          .MDRG_GenericFlag = e.GDRG_GenericFlag,
    '                          .MDRG_DentistrySpecialtyFlag = e.GDRG_DentistrySpecialtyFlag,
    '                          .MDRG_ContrastMediumFlag = e.GDRG_ContrastMediumFlag,
    '                          .MDRG_GrindFlag = e.GDRG_GrindFlag,
    '                          .MDRG_MixFlag = e.GDRG_MixFlag,
    '                          .MDRG_DissolveFlag = e.GDRG_DissolveFlag,
    '                          .MDRG_PTPFlag = e.GDRG_PTPFlag,
    '                          .MDRG_OneDosePackagFlag = e.GDRG_OneDosePackagFlag,
    '                          .MDRG_HospitalPreparationFlag = e.GDRG_HospitalPreparationFlag,
    '                          .MDRG_INDFlag = e.GDRG_INDFlag,
    '                          .MDRG_ExtraDrugFlag = e.GDRG_ExtraDrugFlag,
    '                          .MDRG_DiabetesFlag = e.GDRG_DiabetesFlag,
    '                          .MDRG_AnticancerDrugFlag = e.GDRG_AnticancerDrugFlag,
    '                          .MDRG_SubstituteHotCode1 = e.GDRG_SubstituteHotCode1,
    '                          .MDRG_SubstituteHotCode2 = e.GDRG_SubstituteHotCode2,
    '                          .MDRG_LabelPrintFlag = e.GDRG_LabelPrintFlag
    '                         }

    '        Dim gm_DrugUnit = From u In db.GM_DrugUnit
    '                          Where u.GDUT_HotCode = Item.Key
    '                          Select New With
    '                             {.MDUT_FacilityID = FacilityId,
    '                              .MDUT_StatusClass = "1",
    '                              .MDUT_HotCode = u.GDUT_HotCode,
    '                              .MDUT_UnitNo = u.GDUT_UnitNo,
    '                              .MDUT_UpdateDate = dtNow,
    '                              .MDUT_UpdateClientName = MachineName,
    '                              .MDUT_UpdateStaffID = StaffID,
    '                              .MDUT_DelFlag = 0,
    '                              .MDUT_UnitCode = u.GDUT_UnitCode,
    '                              .MDUT_UnitRatio = u.GDUT_UnitRatio,
    '                              .MDUT_CalculateFlag = 1
    '                             }

    '        'インサートの実施
    '        For Each g In gm_Drug
    '            Dim M_Drug = GM_DrugToM_Drug(g)
    '            db.M_Drug.Add(M_Drug)

    '            '変数のクリア
    '            M_Drug = Nothing
    '        Next

    '        'REP START 2017-08-21 FSI星野 #11960 GMからのコピー時にシステムエラーが発生する
    '        'For Each g In gm_DrugUnit
    '        For Each g In gm_DrugUnit.ToList()
    '            'REP END   2017-08-21 FSI星野 #11960 GMからのコピー時にシステムエラーが発生する
    '            'MDrugUnitの作成
    '            If mUnit.Count > 0 Then
    '                'M_DrugUnitの修正
    '                For Each model In mUnit.ToList()
    '                    Dim rtnex As M_DrugUnit = db.M_DrugUnit.Find(model.MDUT_FacilityID, model.MDUT_HotCode, model.MDUT_UnitNo)
    '                    If model.MDUT_UnitNo = 1 Then
    '                        rtnex.MDUT_FacilityID = If(model.MDUT_FacilityID = g.MDUT_FacilityID, model.MDUT_FacilityID, g.MDUT_FacilityID)
    '                        rtnex.MDUT_StatusClass = If(model.MDUT_StatusClass = g.MDUT_StatusClass, model.MDUT_StatusClass, g.MDUT_StatusClass)
    '                        rtnex.MDUT_HotCode = If(model.MDUT_HotCode = g.MDUT_HotCode, model.MDUT_HotCode, g.MDUT_HotCode)
    '                        rtnex.MDUT_UnitNo = If(model.MDUT_UnitNo = g.MDUT_UnitNo, model.MDUT_UnitNo, g.MDUT_UnitNo)
    '                        rtnex.MDUT_UpdateDate = If(model.MDUT_UpdateDate = g.MDUT_UpdateDate, model.MDUT_UpdateDate, g.MDUT_UpdateDate)
    '                        rtnex.MDUT_UpdateClientName = If(model.MDUT_UpdateClientName = g.MDUT_UpdateClientName, model.MDUT_UpdateClientName, g.MDUT_UpdateClientName)
    '                        rtnex.MDUT_UpdateStaffID = If(model.MDUT_UpdateStaffID = g.MDUT_UpdateStaffID, model.MDUT_UpdateStaffID, g.MDUT_UpdateStaffID)
    '                        rtnex.MDUT_DelFlag = If(model.MDUT_DelFlag = g.MDUT_DelFlag, model.MDUT_DelFlag, g.MDUT_DelFlag)
    '                        rtnex.MDUT_UnitCode = If(model.MDUT_UnitCode = g.MDUT_UnitCode, model.MDUT_UnitCode, g.MDUT_UnitCode)
    '                        rtnex.MDUT_UnitRatio = If(model.MDUT_UnitRatio = g.MDUT_UnitRatio, model.MDUT_UnitRatio, g.MDUT_UnitRatio)
    '                        rtnex.MDUT_CalculateFlag = If(model.MDUT_CalculateFlag = g.MDUT_CalculateFlag, model.MDUT_CalculateFlag, g.MDUT_CalculateFlag)
    '                    Else
    '                        rtnex.MDUT_DelFlag = 1
    '                    End If
    '                    db.Entry(rtnex).State = EntityState.Modified
    '                Next
    '            Else
    '                'M_DrugUnitの新規追加
    '                Dim M_DrugUnit = GM_DrugUnitToM_DrugUnit(g)
    '                db.M_DrugUnit.Add(M_DrugUnit)

    '                '変数のクリア
    '                M_DrugUnit = Nothing
    '            End If
    '        Next

    '        db.SaveChanges()
    '    Next

    '    'Mに登録したデータの取得
    '    Dim strKey As String() = strItemKey.Split(",")
    '    Dim query = From m In db.M_Drug
    '                Where m.MDRG_DelFlag = 0 And m.MDRG_ValidDateTo >= dtNow And strKey.Contains(m.MDRG_HotCode) And m.MDRG_FacilityID = FacilityId
    '                Select m

    '    'M_DrugEXに詰め替える
    '    Dim mdls As New List(Of M_DrugEX)

    '    For Each Item In query.ToList
    '        Dim mdl As New M_DrugEX
    '        mdl.SetFromOriginalModel(Item)
    '        mdl.MaxLog = Item.MDRG_LogNo
    '        mdls.Add(mdl)
    '    Next

    '    Return mdls

    'End Function

    '''' <summary>
    '''' M_Drugの形式に詰め替え
    '''' </summary>
    '''' <param name="g"></param>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Private Function GM_DrugToM_Drug(ByVal g As Object) As M_Drug

    '    Dim m As New M_Drug

    '    m.MDRG_StatusClass = g.MDRG_StatusClass
    '    m.MDRG_HotCode = g.MDRG_HotCode
    '    m.MDRG_LogNo = g.MDRG_LogNo
    '    m.MDRG_UpdateDate = g.MDRG_UpdateDate
    '    m.MDRG_UpdateClientName = g.MDRG_UpdateClientName
    '    m.MDRG_UpdateStaffID = g.MDRG_UpdateStaffID
    '    m.MDRG_DelFlag = g.MDRG_DelFlag
    '    m.MDRG_ValidDateFrom = g.MDRG_ValidDateFrom
    '    m.MDRG_ValidDateTo = g.MDRG_ValidDateTo
    '    m.MDRG_ReceiptCode = g.MDRG_ReceiptCode
    '    m.MDRG_StandardCode = g.MDRG_StandardCode
    '    m.MDRG_MHLWCode = g.MDRG_MHLWCode
    '    m.MDRG_PublicCode = g.MDRG_PublicCode
    '    m.MDRG_DrugName = g.MDRG_DrugName
    '    m.MDRG_DrugKana = g.MDRG_DrugKana
    '    m.MDRG_SalesName = g.MDRG_SalesName
    '    m.MDRG_PublicName = g.MDRG_PublicName
    '    m.MDRG_DisplayDrugName = g.MDRG_DisplayDrugName
    '    m.MDRG_SearchKeyword = g.MDRG_SearchKeyword
    '    m.MDRG_ComponentName = g.MDRG_ComponentName
    '    m.MDRG_OriginalName = g.MDRG_OriginalName
    '    m.MDRG_UnitInit = g.MDRG_UnitInit
    '    m.MDRG_UnitReceipt = g.MDRG_UnitReceipt
    '    m.MDRG_UnitPharm = g.MDRG_UnitPharm
    '    m.MDRG_NarcoticClass = g.MDRG_NarcoticClass
    '    m.MDRG_DosageFormClass = g.MDRG_DosageFormClass
    '    m.MDRG_DrugFormType = g.MDRG_DrugFormType
    '    m.MDRG_Syringeful = g.MDRG_Syringeful
    '    m.MDRG_UsageCode = g.MDRG_UsageCode
    '    m.MDRG_ExternalPartCode = g.MDRG_ExternalPartCode
    '    m.MDRG_DosageClass = g.MDRG_DosageClass
    '    m.MDRG_DoseTimes = g.MDRG_DoseTimes
    '    m.MDRG_DoseDays = g.MDRG_DoseDays
    '    m.MDRG_IntervalDays = g.MDRG_IntervalDays
    '    m.MDRG_Dosage = g.MDRG_Dosage
    '    m.MDRG_OnceMaxDosage = g.MDRG_OnceMaxDosage
    '    m.MDRG_DailyMaxDosage = g.MDRG_DailyMaxDosage
    '    m.MDRG_AdoptClass = g.MDRG_AdoptClass
    '    m.MDRG_OrderMedicineFlag = g.MDRG_OrderMedicineFlag
    '    m.MDRG_OrderInjectionFlag = g.MDRG_OrderInjectionFlag
    '    m.MDRG_OrderTransfusionFlag = g.MDRG_OrderTransfusionFlag
    '    m.MDRG_NerveDestroyFlag = g.MDRG_NerveDestroyFlag
    '    m.MDRG_BiologyFlag = g.MDRG_BiologyFlag
    '    m.MDRG_GenericFlag = g.MDRG_GenericFlag
    '    m.MDRG_DentistrySpecialtyFlag = g.MDRG_DentistrySpecialtyFlag
    '    m.MDRG_ContrastMediumFlag = g.MDRG_ContrastMediumFlag
    '    m.MDRG_GrindFlag = g.MDRG_GrindFlag
    '    m.MDRG_MixFlag = g.MDRG_MixFlag
    '    m.MDRG_DissolveFlag = g.MDRG_DissolveFlag
    '    m.MDRG_PTPFlag = g.MDRG_PTPFlag
    '    m.MDRG_OneDosePackagFlag = g.MDRG_OneDosePackagFlag
    '    m.MDRG_HospitalPreparationFlag = g.MDRG_HospitalPreparationFlag
    '    m.MDRG_INDFlag = g.MDRG_INDFlag
    '    m.MDRG_ExtraDrugFlag = g.MDRG_ExtraDrugFlag
    '    m.MDRG_DiabetesFlag = g.MDRG_DiabetesFlag
    '    m.MDRG_AnticancerDrugFlag = g.MDRG_AnticancerDrugFlag
    '    m.MDRG_SubstituteHotCode1 = g.MDRG_SubstituteHotCode1
    '    m.MDRG_SubstituteHotCode2 = g.MDRG_SubstituteHotCode2
    '    m.MDRG_LabelPrintFlag = g.MDRG_LabelPrintFlag

    '    m.MDRG_FacilityID = g.MDRG_FacilityID

    '    Return m

    'End Function

    '''' <summary>
    '''' M_DrugUnitの形式に詰め替え
    '''' </summary>
    '''' <param name="g"></param>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Private Function GM_DrugUnitToM_DrugUnit(ByVal g As Object) As M_DrugUnit

    '    Dim m As New M_DrugUnit

    '    m.MDUT_FacilityID = g.MDUT_FacilityID
    '    m.MDUT_HotCode = g.MDUT_HotCode
    '    m.MDUT_StatusClass = g.MDUT_StatusClass
    '    m.MDUT_UnitCode = g.MDUT_UnitCode
    '    m.MDUT_UnitNo = g.MDUT_UnitNo
    '    m.MDUT_UnitRatio = g.MDUT_UnitRatio

    '    m.MDUT_UpdateClientName = g.MDUT_UpdateClientName
    '    m.MDUT_UpdateDate = g.MDUT_UpdateDate
    '    m.MDUT_UpdateStaffID = g.MDUT_UpdateStaffID

    '    Return m

    'End Function

    '''' <summary>
    '''' UPDATE
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="gm_Drug"></param>
    '''' <param name="SaveChange"></param>
    'Public Function Update(db As AsamaEntities, gm_Drug As GM_DrugEX, staffId As String, HostName As String, Optional SaveChange As Boolean = False) As GM_DrugEX

    '    '*** 履歴保存する

    '    '変更前を削除
    '    Dim rtnex As GM_Drug = db.GM_Drug.Find(gm_Drug.GDRG_HotCode, gm_Drug.GDRG_LogNo)
    '    rtnex.GDRG_DelFlag = 1
    '    db.Entry(rtnex).State = EntityState.Modified

    '    '削除時は抜ける
    '    If gm_Drug.GDRG_DelFlag = "1" Then
    '        If SaveChange Then
    '            db.SaveChanges()
    '        End If
    '        Return gm_Drug
    '    End If

    '    '変更後を新規
    '    Dim newmdl As New GM_DrugEX()
    '    newmdl.SetFromOriginalModel(gm_Drug.GetOriginalModel())
    '    'LogNo取得
    '    Dim brothers = From e In db.GM_Drug
    '                   Where e.GDRG_HotCode = gm_Drug.GDRG_HotCode
    '    newmdl.GDRG_LogNo = brothers.Max(Function(x) x.GDRG_LogNo) + 1
    '    Me.Insert(db, newmdl, staffId, HostName)

    '    If SaveChange Then
    '        db.SaveChanges()
    '    End If
    '    Return newmdl

    'End Function

    '''' <summary>
    '''' 
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="gm_Drug"></param>
    '''' <param name="staffId"></param>
    '''' <param name="HostName"></param>
    '''' <param name="SaveChange"></param>
    '''' <remarks></remarks>
    'Public Sub Insert(db As AsamaEntities, gm_Drug As GM_DrugEX, staffId As String, HostName As String, Optional SaveChange As Boolean = False)

    '    gm_Drug.GDRG_UpdateStaffID = staffId
    '    gm_Drug.GDRG_UpdateClientName = HostName
    '    gm_Drug.GDRG_UpdateDate = Now()

    '    '必須項目の置き換え
    '    gm_Drug.GDRG_ReceiptCode = If(gm_Drug.GDRG_ReceiptCode Is Nothing, Common.DefaultOfType(gm_Drug.GDRG_ReceiptCode), gm_Drug.GDRG_ReceiptCode)
    '    gm_Drug.GDRG_StandardCode = If(gm_Drug.GDRG_StandardCode Is Nothing, Common.DefaultOfType(gm_Drug.GDRG_StandardCode), gm_Drug.GDRG_StandardCode)
    '    gm_Drug.GDRG_MHLWCode = If(gm_Drug.GDRG_MHLWCode Is Nothing, Common.DefaultOfType(gm_Drug.GDRG_MHLWCode), gm_Drug.GDRG_MHLWCode)
    '    gm_Drug.GDRG_DrugName = If(gm_Drug.GDRG_DrugName Is Nothing, Common.DefaultOfType(gm_Drug.GDRG_DrugName), gm_Drug.GDRG_DrugName)
    '    gm_Drug.GDRG_DrugKana = If(gm_Drug.GDRG_DrugKana Is Nothing, Common.DefaultOfType(gm_Drug.GDRG_DrugKana), gm_Drug.GDRG_DrugKana)
    '    gm_Drug.GDRG_SalesName = If(gm_Drug.GDRG_SalesName Is Nothing, Common.DefaultOfType(gm_Drug.GDRG_SalesName), gm_Drug.GDRG_SalesName)
    '    gm_Drug.GDRG_NarcoticClass = If(gm_Drug.GDRG_NarcoticClass Is Nothing, Common.DefaultOfType(gm_Drug.GDRG_NarcoticClass), gm_Drug.GDRG_NarcoticClass)
    '    gm_Drug.GDRG_DosageFormClass = If(gm_Drug.GDRG_DosageFormClass Is Nothing, Common.DefaultOfType(gm_Drug.GDRG_DosageFormClass), gm_Drug.GDRG_DosageFormClass)
    '    gm_Drug.GDRG_AdoptClass = If(gm_Drug.GDRG_AdoptClass Is Nothing, Common.DefaultOfType(gm_Drug.GDRG_AdoptClass), gm_Drug.GDRG_AdoptClass)

    '    db.Entry(gm_Drug.GetOriginalModel).State = EntityState.Modified

    'End Sub

    'Public Sub CopyRegist(db As AsamaEntities, gm_Drug As GM_DrugEX, staffid As String, host As String)

    '    Using tran = db.Database.BeginTransaction
    '        Try
    '            'LogNo取得
    '            Dim brothers = From e In db.GM_Drug
    '                           Where e.GDRG_HotCode = gm_Drug.GDRG_HotCode
    '            gm_Drug.GDRG_LogNo = brothers.Max(Function(x) x.GDRG_LogNo) + 1
    '            Me.Insert(db, gm_Drug, staffid, host)

    '            db.SaveChanges()

    '            tran.Commit()

    '        Catch ex As Exception
    '            tran.Rollback()
    '            Throw
    '        End Try

    '    End Using

    'End Sub

    '''' <summary>
    '''' 削除時チェック
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="mdl"></param>
    '''' <param name="msg"></param>
    '''' <returns></returns>
    'Public Function CheckDeleteDrug(db As AsamaEntities, mdl As GM_Drug, ByRef msg As String) As Boolean
    '    Return True
    'End Function

    '''' <summary>
    '''' 
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="mdl"></param>
    '''' <param name="msg"></param>
    '''' <returns></returns>
    'Public Function CheckUpdateDrug(db As AsamaEntities, mdl As GM_Drug, ByRef msg As String, Optional CopyFlg As Boolean = False) As Boolean

    '    '関連チェック
    '    If mdl.GDRG_ValidDateFrom > mdl.GDRG_ValidDateTo Then
    '        '日付矛盾エラー
    '        msg = Message.MSG_20000035
    '        Return False
    '    End If

    '    '有効期限が重複しています。
    '    If Not CheckValidateDate(db, mdl, CopyFlg) Then
    '        msg = Message.MSG_DUPLICATE_VALIDDATE
    '        Return False
    '    End If

    '    Return True

    'End Function

    '''' <summary>
    '''' 有効期限チェック
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="mdl"></param>
    '''' <returns></returns>
    'Public Function CheckValidateDate(db As AsamaEntities, mdl As GM_Drug, CopyFlg As Boolean) As Boolean

    '    Dim bro = From e In db.GM_Drug
    '              Where e.GDRG_HotCode = mdl.GDRG_HotCode And
    '                    e.GDRG_DelFlag = 0 And
    '                    e.GDRG_ValidDateTo >= mdl.GDRG_ValidDateFrom And
    '                    e.GDRG_ValidDateFrom <= mdl.GDRG_ValidDateTo
    '              Select e

    '    If Not CopyFlg Then
    '        bro = From e In bro Where e.GDRG_LogNo <> mdl.GDRG_LogNo
    '    End If

    '    If bro.Count > 0 Then
    '        'エラー
    '        Return False
    '    End If

    '    Return True

    'End Function

End Class

Public Class GM_DrugCondition

    'Public Property Model As New GM_Drug

End Class

