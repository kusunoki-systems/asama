Public Class CM_DrugService

    'Public Function CM_ToSearch(db As AsamaEntities, conditionModel As CM_DrugCondition, MasterType As Integer) As List(Of CM_Drug)

    '    Dim dtNow As DateTime = DateTime.Now
    '    Dim query = From e In db.CM_Drug
    '                Where e.CDRG_ValidDateTo >= dtNow
    '                Select e

    '    'タイプによって絞込みを変更
    '    Select Case MasterType
    '        Case 1
    '            query = From q In query Where (q.CDRG_DosageFormClass.Contains("1") _
    '                                    OrElse q.CDRG_DosageFormClass.Contains("4") _
    '                                    OrElse q.CDRG_DosageFormClass.Contains("6"))
    '        Case 2
    '            query = From q In query Where q.CDRG_DosageFormClass.Contains("3")
    '        Case 3
    '            query = From q In query Where q.CDRG_DrugName.Contains("日赤")
    '    End Select

    '    'CDRG_HotCode
    '    If Not String.IsNullOrEmpty(conditionModel.Model.CDRG_Hot7Code) Then
    '        query = From q In query Where q.CDRG_Hot7Code + q.CDRG_CompanyCode = conditionModel.Model.CDRG_Hot7Code
    '    End If

    '    'CDRG_DrugName 部分一致
    '    If Not String.IsNullOrEmpty(conditionModel.Model.CDRG_DrugName) Then
    '        query = From q In query Where q.CDRG_DrugName.Contains(conditionModel.Model.CDRG_DrugName)
    '    End If

    '    Return query.ToList()

    'End Function

    'Public Function GM_ToSearch(db As AsamaEntities, conditionModel As CM_DrugCondition, MasterType As Integer) As List(Of CM_DrugEX)

    '    Dim dtNow As DateTime = DateTime.Now
    '    Dim query = From e In db.CM_Drug
    '                Group Join g In db.GM_Drug On e.CDRG_Hot7Code + e.CDRG_CompanyCode Equals g.GDRG_HotCode Into ords = Group
    '                From g In ords.DefaultIfEmpty
    '                Where e.CDRG_ValidDateTo >= dtNow
    '                Order By e.CDRG_Hot7Code, e.CDRG_CompanyCode, e.CDRG_PackUnit, e.CDRG_ValidDateFrom, e.CDRG_PublicCode Descending
    '                Select New With {.CDRG_StandardCode = e.CDRG_StandardCode,
    '                                 .HotCode = e.CDRG_Hot7Code + e.CDRG_CompanyCode,
    '                                 .CDRG_DosageFormClass = e.CDRG_DosageFormClass,
    '                                 .CDRG_ReceiptCode = e.CDRG_ReceiptCode,
    '                                 .CDRG_DrugName = e.CDRG_DrugName,
    '                                 .CDRG_DrugKana = e.CDRG_DrugKana,
    '                                 .CDRG_SalesName = e.CDRG_SalesName,
    '                                 .CDRG_PublicName = e.CDRG_PublicName,
    '                                 .CDRG_ComponentName = e.CDRG_ComponentName,
    '                                 .CDRG_OriginalName = e.CDRG_OriginalName,
    '                                 .CDRG_ValidDateFrom = e.CDRG_ValidDateFrom,
    '                                 .CDRG_ValidDateTo = e.CDRG_ValidDateTo,
    '                                 .GDRG_HotCode = g.GDRG_HotCode}

    '    'タイプによって絞込みを変更
    '    Select Case MasterType
    '        Case 1
    '            query = From q In query Where (q.CDRG_DosageFormClass.Contains("1") _
    '                                    OrElse q.CDRG_DosageFormClass.Contains("4") _
    '                                    OrElse q.CDRG_DosageFormClass.Contains("6"))
    '        Case 2
    '            query = From q In query Where q.CDRG_DosageFormClass.Contains("3")
    '        Case 3
    '            query = From q In query Where q.CDRG_DrugName.Contains("日赤")
    '    End Select

    '    'CDRG_HotCode
    '    If Not String.IsNullOrEmpty(conditionModel.Model.CDRG_Hot7Code) Then
    '        query = From q In query Where q.HotCode.Contains(conditionModel.Model.CDRG_Hot7Code)
    '    End If

    '    'CDRG_DrugName 部分一致
    '    If Not String.IsNullOrEmpty(conditionModel.Model.CDRG_DrugName) Then
    '        Dim strDrugName As String = conditionModel.Model.CDRG_DrugName
    '        query = From q In query Where (q.CDRG_DrugName.Contains(strDrugName) _
    '                                OrElse q.CDRG_DrugKana.Contains(strDrugName) _
    '                                OrElse q.CDRG_SalesName.Contains(strDrugName) _
    '                                OrElse q.CDRG_PublicName.Contains(strDrugName) _
    '                                OrElse q.CDRG_ComponentName.Contains(strDrugName) _
    '                                OrElse q.CDRG_OriginalName.Contains(strDrugName))
    '    End If

    '    'MDRG_DosageFormClass
    '    If Not String.IsNullOrEmpty(conditionModel.Model.CDRG_DosageFormClass) Then
    '        Dim strKey As String() = conditionModel.Model.CDRG_DosageFormClass.Split(",")
    '        query = From q In query Where strKey.Contains(q.CDRG_DosageFormClass)
    '    End If

    '    'CM_DrugEXに詰め替える
    '    Dim mdls As New List(Of CM_DrugEX)

    '    For Each Item In query.ToList

    '        Dim mdl As New CM_DrugEX
    '        mdl.CDRG_StandardCode = Item.CDRG_StandardCode
    '        mdl.CDRG_Hot7Code = Item.HotCode
    '        mdl.CDRG_ReceiptCode = Item.CDRG_ReceiptCode
    '        mdl.CDRG_DrugName = Item.CDRG_DrugName
    '        mdl.CDRG_DrugKana = Item.CDRG_DrugKana
    '        mdl.CDRG_SalesName = Item.CDRG_SalesName
    '        mdl.CDRG_PublicName = Item.CDRG_PublicName
    '        mdl.CDRG_ComponentName = Item.CDRG_ComponentName
    '        mdl.CDRG_OriginalName = Item.CDRG_OriginalName
    '        mdl.CDRG_DosageFormClass = Item.CDRG_DosageFormClass
    '        mdl.CDRG_ValidDateFrom = Item.CDRG_ValidDateFrom
    '        mdl.CDRG_ValidDateTo = Item.CDRG_ValidDateTo

    '        'gのHotCodeが存在するか確認
    '        If Item.GDRG_HotCode Is Nothing Then
    '            '存在しない場合はFalseを入れる
    '            mdl.Optiont_CheckFlag = False
    '        Else
    '            '存在した場合はTureを入れる
    '            mdl.Optiont_CheckFlag = True
    '        End If

    '        mdls.Add(mdl)
    '    Next

    '    Return mdls

    'End Function

    'Public Function M_ToSearch(db As AsamaEntities, conditionModel As CM_DrugCondition, MasterType As Integer, FacilityID As String) As List(Of CM_DrugEX)
    '    'And m.MDRG_FacilityID = FacilityID
    '    Dim dtNow As DateTime = DateTime.Now
    '    'REP START 2017-08-08 FSI星野 #11912 病院の薬品マスタ(M_Drug)に存在しないものが表示されない
    '    'Dim query = From e In db.CM_Drug _
    '    '            Group Join m In db.M_Drug On e.CDRG_Hot7Code + e.CDRG_CompanyCode Equals m.MDRG_HotCode Into ords = Group
    '    '            From m In ords.DefaultIfEmpty
    '    '            Where e.CDRG_ValidDateTo >= dtNow And m.MDRG_FacilityID = FacilityID
    '    '            Order By e.CDRG_Hot7Code, e.CDRG_CompanyCode, e.CDRG_PackUnit, e.CDRG_ValidDateFrom, e.CDRG_PublicCode Descending
    '    '            Select New With {.CDRG_StandardCode = e.CDRG_StandardCode,
    '    '                             .HotCode = e.CDRG_Hot7Code + e.CDRG_CompanyCode,
    '    '                             .CDRG_DosageFormClass = e.CDRG_DosageFormClass,
    '    '                             .CDRG_ReceiptCode = e.CDRG_ReceiptCode,
    '    '                             .CDRG_DrugName = e.CDRG_DrugName,
    '    '                             .CDRG_DrugKana = e.CDRG_DrugKana,
    '    '                             .CDRG_SalesName = e.CDRG_SalesName,
    '    '                             .CDRG_PublicName = e.CDRG_PublicName,
    '    '                             .CDRG_ComponentName = e.CDRG_ComponentName,
    '    '                             .CDRG_OriginalName = e.CDRG_OriginalName,
    '    '                             .CDRG_ValidDateFrom = e.CDRG_ValidDateFrom,
    '    '                             .CDRG_ValidDateTo = e.CDRG_ValidDateTo,
    '    '                             .MDRG_HotCode = m.MDRG_HotCode}
    '    Dim mDurg = From m In db.M_Drug
    '                Where m.MDRG_FacilityID = FacilityID
    '                Select m

    '    Dim query = From e In db.CM_Drug
    '                Group Join m In mDurg On e.CDRG_Hot7Code + e.CDRG_CompanyCode Equals m.MDRG_HotCode Into ords = Group
    '                From m In ords.DefaultIfEmpty
    '                Where e.CDRG_ValidDateTo >= dtNow
    '                Select New With {.CDRG_StandardCode = e.CDRG_StandardCode,
    '                                 .HotCode = e.CDRG_Hot7Code + e.CDRG_CompanyCode,
    '                                 .CDRG_DosageFormClass = e.CDRG_DosageFormClass,
    '                                 .CDRG_ReceiptCode = e.CDRG_ReceiptCode,
    '                                 .CDRG_MakerCompany = e.CDRG_MakerCompany,
    '                                 .CDRG_SalesCompany = e.CDRG_SalesCompany,
    '                                 .CDRG_DrugName = e.CDRG_DrugName,
    '                                 .CDRG_DrugKana = e.CDRG_DrugKana,
    '                                 .CDRG_SalesName = e.CDRG_SalesName,
    '                                 .CDRG_PublicName = e.CDRG_PublicName,
    '                                 .CDRG_ComponentName = e.CDRG_ComponentName,
    '                                 .CDRG_OriginalName = e.CDRG_OriginalName,
    '                                 .CDRG_ValidDateFrom = e.CDRG_ValidDateFrom,
    '                                 .CDRG_ValidDateTo = e.CDRG_ValidDateTo,
    '                                 .MDRG_FacilityID = m.MDRG_FacilityID,
    '                                 .MDRG_HotCode = m.MDRG_HotCode,
    '                                 .MDRG_DelFlag = If(m.MDRG_DelFlag = Nothing, m.MDRG_DelFlag, 1)}
    '    'REP END   2017-08-08 FSI星野 #11912 病院の薬品マスタ(M_Drug)に存在しないものが表示されない

    '    'タイプによって絞込みを変更
    '    Select Case MasterType
    '        Case 1
    '            query = From q In query Where (q.CDRG_DosageFormClass.Contains("1") _
    '                                    OrElse q.CDRG_DosageFormClass.Contains("4") _
    '                                    OrElse q.CDRG_DosageFormClass.Contains("6"))
    '        Case 2
    '            query = From q In query Where q.CDRG_DosageFormClass.Contains("3")
    '        Case 3
    '            query = From q In query Where q.CDRG_DrugName.Contains("日赤")
    '    End Select

    '    'CDRG_HotCode
    '    If Not String.IsNullOrEmpty(conditionModel.Model.CDRG_Hot7Code) Then
    '        query = From q In query Where q.HotCode.Contains(conditionModel.Model.CDRG_Hot7Code)
    '    End If

    '    'CDRG_DrugName 部分一致
    '    If Not String.IsNullOrEmpty(conditionModel.Model.CDRG_DrugName) Then
    '        Dim strDrugName As String = conditionModel.Model.CDRG_DrugName
    '        query = From q In query Where (q.CDRG_DrugName.Contains(strDrugName) _
    '                                OrElse q.CDRG_DrugKana.Contains(strDrugName) _
    '                                OrElse q.CDRG_SalesName.Contains(strDrugName) _
    '                                OrElse q.CDRG_PublicName.Contains(strDrugName) _
    '                                OrElse q.CDRG_ComponentName.Contains(strDrugName) _
    '                                OrElse q.CDRG_OriginalName.Contains(strDrugName))
    '    End If

    '    'MDRG_DosageFormClass
    '    If Not String.IsNullOrEmpty(conditionModel.Model.CDRG_DosageFormClass) Then
    '        Dim s As String() = conditionModel.Model.CDRG_DosageFormClass.Split(",")
    '        query = From q In query Where s.Contains(q.CDRG_DosageFormClass)
    '    End If

    '    'ADD START 2017-08-08 FSI星野 #11912 病院の薬品マスタ(M_Drug)に存在しないものが表示されない
    '    'Distinct掛ける
    '    query = (From q In query Select q).Distinct
    '    query = From q In query Order By q.HotCode, q.CDRG_ValidDateFrom
    '    'ADD END   2017-08-08 FSI星野 #11912 病院の薬品マスタ(M_Drug)に存在しないものが表示されない

    '    'GM_DrugEXに詰め替える
    '    Dim mdls As New List(Of CM_DrugEX)
    '    Dim HotCode As String = String.Empty

    '    For Each Item In query.ToList

    '        If HotCode <> Item.HotCode Then
    '            Dim mdl As New CM_DrugEX
    '            mdl.CDRG_StandardCode = Item.CDRG_StandardCode
    '            mdl.CDRG_Hot7Code = Item.HotCode
    '            mdl.CDRG_ReceiptCode = Item.CDRG_ReceiptCode
    '            mdl.CDRG_MakerCompany = Item.CDRG_MakerCompany
    '            mdl.CDRG_SalesCompany = Item.CDRG_SalesCompany
    '            mdl.CDRG_DrugName = Item.CDRG_DrugName
    '            mdl.CDRG_DrugKana = Item.CDRG_DrugKana
    '            mdl.CDRG_SalesName = Item.CDRG_SalesName
    '            mdl.CDRG_PublicName = Item.CDRG_PublicName
    '            mdl.CDRG_ComponentName = Item.CDRG_ComponentName
    '            mdl.CDRG_OriginalName = Item.CDRG_OriginalName
    '            mdl.CDRG_DosageFormClass = Item.CDRG_DosageFormClass
    '            mdl.CDRG_ValidDateFrom = Item.CDRG_ValidDateFrom
    '            mdl.CDRG_ValidDateTo = Item.CDRG_ValidDateTo

    '            'MのHotCodeが存在するか確認
    '            If Item.MDRG_HotCode Is Nothing OrElse Item.MDRG_DelFlag = "1" Then
    '                '存在しない場合はFalseを入れる
    '                mdl.Optiont_CheckFlag = False
    '            Else
    '                '存在した場合はTureを入れる
    '                mdl.Optiont_CheckFlag = True
    '            End If
    '            mdls.Add(mdl)
    '        End If
    '        HotCode = Item.HotCode
    '    Next

    '    Return mdls

    'End Function

    '''' <summary>
    '''' CMマスタからGMマスタへコピーを行う
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="dicCheckItem"></param>
    '''' <param name="MasterType"></param>
    '''' <param name="FacilityId"></param>
    '''' <param name="StaffID"></param>
    '''' <param name="MachineName"></param>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Function GM_ToCopy(db As AsamaEntities, dicCheckItem As Dictionary(Of String, String), MasterType As Integer, FacilityId As String, StaffID As String, MachineName As String) As List(Of GM_DrugEX)

    '    Dim gm_DrugEX As New GM_DrugEX
    '    Dim gm_DrugUnitEX As New GM_DrugUnitEX

    '    Dim cm_Drug
    '    Dim strItemKey As String = String.Empty
    '    Dim dtNow As DateTime = DateTime.Now

    '    For Each Item In dicCheckItem
    '        If String.IsNullOrEmpty(strItemKey) Then
    '            strItemKey = Item.Key
    '        Else
    '            strItemKey += "," & Item.Key
    '        End If
    '        cm_Drug = From e In db.CM_Drug
    '                  Where e.CDRG_Hot7Code + e.CDRG_CompanyCode = Item.Key And e.CDRG_StandardCode = Item.Value
    '                  Select New With
    '                       {.GDRG_FacilityID = FacilityId,
    '                        .GDRG_StatusClass = "1",
    '                        .GDRG_HotCode = e.CDRG_Hot7Code + e.CDRG_CompanyCode,
    '                        .GDRG_LogNo = 1,
    '                        .GDRG_UpdateDate = dtNow,
    '                        .GDRG_UpdateClientName = MachineName,
    '                        .GDRG_UpdateStaffID = StaffID,
    '                        .GDRG_DelFlag = 0,
    '                        .GDRG_ValidDateFrom = CType("1900/01/01", Date),
    '                        .GDRG_ValidDateTo = CType("2900/12/31", Date),
    '                        .GDRG_ReceiptCode = e.CDRG_ReceiptCode,
    '                        .GDRG_StandardCode = e.CDRG_StandardCode,
    '                        .GDRG_MHLWCode = e.CDRG_MhlwCode,
    '                        .GDRG_PublicCode = e.CDRG_PublicCode,
    '                        .GDRG_DrugName = e.CDRG_DrugName,
    '                        .GDRG_DrugKana = e.CDRG_DrugKana,
    '                        .GDRG_SalesName = e.CDRG_SalesName,
    '                        .GDRG_PublicName = e.CDRG_PublicName,
    '                        .GDRG_DisplayDrugName = "",
    '                        .GDRG_SearchKeyword = "",
    '                        .GDRG_ComponentName = e.CDRG_ComponentName,
    '                        .GDRG_OriginalName = e.CDRG_OriginalName,
    '                        .GDRG_UnitInit = "1",
    '                        .GDRG_UnitReceipt = "1",
    '                        .GDRG_UnitPharm = "0",
    '                        .GDRG_NarcoticClass = e.CDRG_NarcoticClass,
    '                        .GDRG_DosageFormClass = e.CDRG_DosageFormClass,
    '                        .GDRG_DrugFormType = "",
    '                        .GDRG_Syringeful = e.CDRG_Syringeful,
    '                        .GDRG_UsageCode = "0",
    '                        .GDRG_ExternalPartCode = "",
    '                        .GDRG_DosageClass = "",
    '                        .GDRG_DoseTimes = -99999999,
    '                        .GDRG_DoseDays = -99999999,
    '                        .GDRG_IntervalDays = -99999999,
    '                        .GDRG_Dosage = -1,
    '                        .GDRG_OnceMaxDosage = -1,
    '                        .GDRG_DailyMaxDosage = -1,
    '                        .GDRG_AdoptClass = "0",
    '                        .GDRG_OrderMedicineFlag = 0,
    '                        .GDRG_OrderInjectionFlag = 0,
    '                        .GDRG_OrderTransfusionFlag = 0,
    '                        .GDRG_NerveDestroyFlag = e.CDRG_NerveDestroyFlag,
    '                        .GDRG_BiologyFlag = e.CDRG_BiologyFlag,
    '                        .GDRG_GenericFlag = e.CDRG_GenericFlag,
    '                        .GDRG_DentistrySpecialtyFlag = e.CDRG_DentistrySpecialtyFlag,
    '                        .GDRG_ContrastMediumFlag = e.CDRG_ContrastMediumFlag,
    '                        .GDRG_GrindFlag = 0,
    '                        .GDRG_MixFlag = 0,
    '                        .GDRG_DissolveFlag = 0,
    '                        .GDRG_PTPFlag = 0,
    '                        .GDRG_OneDosePackagFlag = 0,
    '                        .GDRG_HospitalPreparationFlag = 0,
    '                        .GDRG_INDFlag = 0,
    '                        .GDRG_ExtraDrugFlag = 0,
    '                        .GDRG_DiabetesFlag = 0,
    '                        .GDRG_AnticancerDrugFlag = 0,
    '                        .GDRG_SubstituteHotCode1 = "",
    '                        .GDRG_SubstituteHotCode2 = "",
    '                        .GDRG_LabelPrintFlag = 0,
    '                        .GDRG_PatientLimitedFlag = 0,
    '                        .GDRG_Remarks = "",
    '                        .GDUT_HotCode = e.CDRG_Hot7Code + e.CDRG_CompanyCode,
    '                        .GDUT_StatusClass = "1",
    '                        .GDUT_FacilityID = FacilityId,
    '                        .GDUT_UnitNo = 1,
    '                        .GDUT_UpdateDate = dtNow,
    '                        .GDUT_UpdateClientName = MachineName,
    '                        .GDUT_UpdateStaffID = StaffID,
    '                        .GDUT_DelFlag = 0,
    '                        .GDUT_UnitCode = e.CDRG_UnitCode,
    '                        .GDUT_UnitRatio = 1,
    '                        .GDUT_CalculateFlag = 1
    '                       }

    '        'インサートの実施
    '        Dim GM_Drug
    '        Dim GM_DrugUnit
    '        For Each c In cm_Drug
    '            GM_Drug = CM_DrugToGM_Drug(c)
    '            GM_DrugUnit = CM_DrugUnitToGM_DrugUnit(c)
    '            'GDRG_ExternalPartCode
    '            If MasterType = "1" AndAlso GM_Drug.GDRG_DosageFormClass = "6" Then
    '                GM_Drug.GDRG_ExternalPartCode = ExternalPartCode(GM_Drug.GDRG_MHLWCode, GM_Drug.GDRG_DrugName)
    '            End If
    '            'GDRG_OrderMedicineFlag
    '            If MasterType = "1" AndAlso (GM_Drug.GDRG_DosageFormClass = "1" OrElse GM_Drug.GDRG_DosageFormClass = "6") Then
    '                GM_Drug.GDRG_OrderMedicineFlag = 1
    '            Else
    '                GM_Drug.GDRG_OrderMedicineFlag = 0
    '            End If
    '            'GDRG_OrderInjectionFlag
    '            If MasterType = "1" AndAlso GM_Drug.GDRG_DosageFormClass = "4" Then
    '                GM_Drug.GDRG_OrderInjectionFlag = 1
    '            Else
    '                GM_Drug.GDRG_OrderInjectionFlag = 0
    '            End If
    '            'GDRG_OrderTransfusionFlag
    '            If MasterType = "3" Then
    '                GM_Drug.GDRG_OrderTransfusionFlag = 1
    '            Else
    '                GM_Drug.GDRG_OrderTransfusionFlag = 0
    '            End If

    '            db.GM_Drug.Add(GM_Drug)
    '            db.GM_DrugUnit.Add(GM_DrugUnit)
    '        Next

    '        db.SaveChanges()
    '    Next

    '    'GMに登録したデータの取得
    '    Dim strKey As String() = strItemKey.Split(",")
    '    Dim query = From g In db.GM_Drug
    '                Where g.GDRG_DelFlag = 0 And g.GDRG_ValidDateTo >= dtNow And strKey.Contains(g.GDRG_HotCode)
    '                Select g

    '    'GM_DrugEXに詰め替える
    '    Dim mdls As New List(Of GM_DrugEX)

    '    For Each item In query.ToList
    '        Dim mdl As New GM_DrugEX
    '        mdl.SetFromOriginalModel(item)
    '        mdls.Add(mdl)
    '    Next

    '    Return mdls

    'End Function

    '''' <summary>
    '''' CMマスタからMマスタへコピーを行う
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="dicCheckItem"></param>
    '''' <param name="MasterType"></param>
    '''' <param name="FacilityId"></param>
    '''' <param name="StaffID"></param>
    '''' <param name="MachineName"></param>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Function M_ToCopy(db As AsamaEntities, dicCheckItem As Dictionary(Of String, String), MasterType As Integer, FacilityId As String, StaffID As String, MachineName As String, ByRef ErrMsg As String) As List(Of M_DrugEX)

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


    '        'CMDrugの該当レコードを取得する
    '        Dim cm_Drug = From e In db.CM_Drug
    '                      Where e.CDRG_Hot7Code + e.CDRG_CompanyCode = Item.Key And e.CDRG_StandardCode = Item.Value
    '                      Select New With
    '                       {.MDRG_FacilityID = FacilityId,
    '                        .MDRG_StatusClass = "3",
    '                        .MDRG_HotCode = e.CDRG_Hot7Code + e.CDRG_CompanyCode,
    '                        .MDRG_LogNo = LogNo,
    '                        .MDRG_UpdateDate = dtNow,
    '                        .MDRG_UpdateClientName = MachineName,
    '                        .MDRG_UpdateStaffID = StaffID,
    '                        .MDRG_DelFlag = "0",
    '                        .MDRG_ValidDateFrom = CType("1900/01/01", Date),
    '                        .MDRG_ValidDateTo = CType("2900/12/31", Date),
    '                        .MDRG_ReceiptCode = e.CDRG_ReceiptCode,
    '                        .MDRG_StandardCode = e.CDRG_StandardCode.Trim,
    '                        .MDRG_MHLWCode = e.CDRG_MhlwCode,
    '                        .MDRG_PublicCode = e.CDRG_PublicCode,
    '                        .MDRG_DrugName = e.CDRG_DrugName,
    '                        .MDRG_DrugKana = e.CDRG_DrugKana,
    '                        .MDRG_SalesName = e.CDRG_SalesName,
    '                        .MDRG_PublicName = e.CDRG_PublicName,
    '                        .MDRG_DisplayDrugName = "",
    '                        .MDRG_SearchKeyword = "",
    '                        .MDRG_ComponentName = e.CDRG_ComponentName,
    '                        .MDRG_OriginalName = e.CDRG_OriginalName,
    '                        .MDRG_UnitInit = "1",
    '                        .MDRG_UnitReceipt = "1",
    '                        .MDRG_UnitPharm = "0",
    '                        .MDRG_NarcoticClass = e.CDRG_NarcoticClass,
    '                        .MDRG_DosageFormClass = e.CDRG_DosageFormClass,
    '                        .MDRG_DrugFormType = "",
    '                        .MDRG_Syringeful = e.CDRG_Syringeful,
    '                        .MDRG_UsageCode = "0",
    '                        .MDRG_ExternalPartCode = "",
    '                        .MDRG_DosageClass = "",
    '                        .MDRG_DoseTimes = -99999999,
    '                        .MDRG_DoseDays = -99999999,
    '                        .MDRG_IntervalDays = -99999999,
    '                        .MDRG_Dosage = -1,
    '                        .MDRG_OnceMaxDosage = -1,
    '                        .MDRG_DailyMaxDosage = -1,
    '                        .MDRG_AdoptClass = "0",
    '                        .MDRG_OrderMedicineFlag = 0,
    '                        .MDRG_OrderInjectionFlag = 0,
    '                        .MDRG_OrderTransfusionFlag = 0,
    '                        .MDRG_NerveDestroyFlag = e.CDRG_NerveDestroyFlag,
    '                        .MDRG_BiologyFlag = e.CDRG_BiologyFlag,
    '                        .MDRG_GenericFlag = e.CDRG_GenericFlag,
    '                        .MDRG_DentistrySpecialtyFlag = e.CDRG_DentistrySpecialtyFlag,
    '                        .MDRG_ContrastMediumFlag = e.CDRG_ContrastMediumFlag,
    '                        .MDRG_GrindFlag = 0,
    '                        .MDRG_MixFlag = 0,
    '                        .MDRG_DissolveFlag = 0,
    '                        .MDRG_PTPFlag = 0,
    '                        .MDRG_OneDosePackagFlag = 0,
    '                        .MDRG_HospitalPreparationFlag = 0,
    '                        .MDRG_INDFlag = 0,
    '                        .MDRG_ExtraDrugFlag = 0,
    '                        .MDRG_DiabetesFlag = 0,
    '                        .MDRG_AnticancerDrugFlag = 0,
    '                        .MDRG_SubstituteHotCode1 = "",
    '                        .MDRG_SubstituteHotCode2 = "",
    '                        .MDRG_LabelPrintFlag = 0,
    '                        .MDRG_PatientLimitedFlag = 0,
    '                        .MDRG_Remarks = "",
    '                        .MDUT_FacilityID = FacilityId,
    '                        .MDUT_StatusClass = "3",
    '                        .MDUT_HotCode = e.CDRG_Hot7Code + e.CDRG_CompanyCode,
    '                        .MDUT_UnitNo = 1,
    '                        .MDUT_UpdateDate = dtNow,
    '                        .MDUT_UpdateClientName = MachineName,
    '                        .MDUT_UpdateStaffID = StaffID,
    '                        .MDUT_DelFlag = 0,
    '                        .MDUT_UnitCode = e.CDRG_UnitCode,
    '                        .MDUT_UnitRatio = 1,
    '                        .MDUT_CalculateFlag = 1
    '                       }
    '        '名称確認用
    '        Dim UnitCode As String = String.Empty
    '        'インサートの実施
    '        For Each c In cm_Drug.ToList
    '            'MDrugの作成
    '            Dim M_Drug = CM_DrugToM_Drug(c)
    '            'MDRG_ExternalPartCode
    '            If MasterType = "1" AndAlso M_Drug.MDRG_DosageFormClass = "6" Then
    '                M_Drug.MDRG_ExternalPartCode = ExternalPartCode(M_Drug.MDRG_MHLWCode, M_Drug.MDRG_DrugName)
    '            End If
    '            'MDRG_OrderMedicineFlag
    '            If MasterType = "1" AndAlso (M_Drug.MDRG_DosageFormClass = "1" OrElse M_Drug.MDRG_DosageFormClass = "6") Then
    '                M_Drug.MDRG_OrderMedicineFlag = 1
    '            Else
    '                M_Drug.MDRG_OrderMedicineFlag = 0
    '            End If
    '            'MDRG_OrderInjectionFlag
    '            If MasterType = "1" AndAlso M_Drug.MDRG_DosageFormClass = "4" Then
    '                M_Drug.MDRG_OrderInjectionFlag = 1
    '            Else
    '                M_Drug.MDRG_OrderInjectionFlag = 0
    '            End If
    '            'MDRG_OrderTransfusionFlag
    '            If MasterType = "3" Then
    '                M_Drug.MDRG_OrderTransfusionFlag = 1
    '            Else
    '                M_Drug.MDRG_OrderTransfusionFlag = 0
    '            End If

    '            db.M_Drug.Add(M_Drug)

    '            'MDrugUnitの作成
    '            If mUnit.Count > 0 Then
    '                'M_DrugUnitの修正
    '                For Each model In mUnit.ToList()
    '                    Dim rtnex As M_DrugUnit = db.M_DrugUnit.Find(model.MDUT_FacilityID, model.MDUT_HotCode, model.MDUT_UnitNo)
    '                    If model.MDUT_UnitNo = 1 Then
    '                        rtnex.MDUT_FacilityID = If(model.MDUT_FacilityID = c.MDUT_FacilityID, model.MDUT_FacilityID, c.MDUT_FacilityID)
    '                        rtnex.MDUT_StatusClass = If(model.MDUT_StatusClass = c.MDUT_StatusClass, model.MDUT_StatusClass, c.MDUT_StatusClass)
    '                        rtnex.MDUT_HotCode = If(model.MDUT_HotCode = c.MDUT_HotCode, model.MDUT_HotCode, c.MDUT_HotCode)
    '                        rtnex.MDUT_UnitNo = If(model.MDUT_UnitNo = c.MDUT_UnitNo, model.MDUT_UnitNo, c.MDUT_UnitNo)
    '                        rtnex.MDUT_UpdateDate = If(model.MDUT_UpdateDate = c.MDUT_UpdateDate, model.MDUT_UpdateDate, c.MDUT_UpdateDate)
    '                        rtnex.MDUT_UpdateClientName = If(model.MDUT_UpdateClientName = c.MDUT_UpdateClientName, model.MDUT_UpdateClientName, c.MDUT_UpdateClientName)
    '                        rtnex.MDUT_UpdateStaffID = If(model.MDUT_UpdateStaffID = c.MDUT_UpdateStaffID, model.MDUT_UpdateStaffID, c.MDUT_UpdateStaffID)
    '                        rtnex.MDUT_DelFlag = If(model.MDUT_DelFlag = c.MDUT_DelFlag, model.MDUT_DelFlag, c.MDUT_DelFlag)
    '                        rtnex.MDUT_UnitCode = If(model.MDUT_UnitCode = c.MDUT_UnitCode, model.MDUT_UnitCode, c.MDUT_UnitCode)
    '                        rtnex.MDUT_UnitRatio = If(model.MDUT_UnitRatio = c.MDUT_UnitRatio, model.MDUT_UnitRatio, c.MDUT_UnitRatio)
    '                        rtnex.MDUT_CalculateFlag = If(model.MDUT_CalculateFlag = c.MDUT_CalculateFlag, model.MDUT_CalculateFlag, c.MDUT_CalculateFlag)
    '                    Else
    '                        rtnex.MDUT_DelFlag = 1
    '                    End If
    '                    db.Entry(rtnex).State = EntityState.Modified
    '                Next
    '            Else
    '                'M_DrugUnitの新規追加
    '                Dim M_DrugUnit = CM_DrugUnitToM_DrugUnit(c)
    '                db.M_DrugUnit.Add(M_DrugUnit)

    '                '変数のクリア
    '                M_DrugUnit = Nothing
    '            End If

    '            '変数のクリア
    '            M_Drug = Nothing

    '            '名称確認用に変数に保存
    '            UnitCode = c.MDUT_UnitCode
    '        Next

    '        '名称マスタから名称が取れるか確認する
    '        Dim VM_Name = From e In db.VM_Name
    '                      Where e.VNAM_DelFlag = 0 And e.VNAM_NameClass = "CM04" And e.VNAM_FacilityID = FacilityId And e.VNAM_ValidDateFrom < dtNow And e.VNAM_NameCode = UnitCode
    '                      Select e

    '        If VM_Name.count = 0 Then
    '            '名称が取得できない場合エラーとする
    '            ErrMsg = String.Format("単位名称が不足している為、{0}は登録できません。", cm_Drug.ToList(0).MDRG_DrugName.ToString)
    '            Continue For
    '        End If

    '        '変更を登録する
    '        db.SaveChanges()
    '    Next

    '    'Mに登録したデータの取得
    '    Dim strKey As String() = strItemKey.Split(",")
    '    Dim query = From m In db.M_Drug
    '                Where m.MDRG_DelFlag = 0 And m.MDRG_ValidDateTo >= dtNow And strKey.Contains(m.MDRG_HotCode) And m.MDRG_FacilityID = FacilityId
    '                Select m

    '    'M_DrugEXに詰め替える
    '    Dim mdls As New List(Of M_DrugEX)

    '    For Each item In query.ToList
    '        Dim mdl As New M_DrugEX
    '        mdl.SetFromOriginalModel(item)
    '        mdl.MaxLog = item.MDRG_LogNo
    '        mdls.Add(mdl)
    '    Next

    '    Return mdls

    'End Function

    '''' <summary>
    '''' GM_Drugの形式に詰め替え
    '''' </summary>
    '''' <param name="model"></param>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Private Function CM_DrugToGM_Drug(ByVal model As Object) As GM_Drug

    '    Dim g As New GM_Drug

    '    'g.gDRG_FacilityID = model.GDRG_FacilityID
    '    'g.gDRG_StatusClass = model.GDRG_StatusClass
    '    g.GDRG_HotCode = model.GDRG_HotCode
    '    g.GDRG_LogNo = model.GDRG_LogNo
    '    g.GDRG_UpdateDate = model.GDRG_UpdateDate
    '    g.GDRG_UpdateClientName = model.GDRG_UpdateClientName
    '    g.GDRG_UpdateStaffID = model.GDRG_UpdateStaffID
    '    g.GDRG_DelFlag = model.GDRG_DelFlag
    '    g.GDRG_ValidDateFrom = model.GDRG_ValidDateFrom
    '    g.GDRG_ValidDateTo = model.GDRG_ValidDateTo
    '    g.GDRG_ReceiptCode = model.GDRG_ReceiptCode
    '    g.GDRG_StandardCode = model.GDRG_StandardCode
    '    g.GDRG_MHLWCode = model.GDRG_MHLWCode
    '    g.GDRG_PublicCode = model.GDRG_PublicCode
    '    g.GDRG_DrugName = model.GDRG_DrugName
    '    g.GDRG_DrugKana = model.GDRG_DrugKana
    '    g.GDRG_SalesName = model.GDRG_SalesName
    '    g.GDRG_PublicName = model.GDRG_PublicName
    '    g.GDRG_DisplayDrugName = model.GDRG_DisplayDrugName
    '    g.GDRG_SearchKeyword = model.GDRG_SearchKeyword
    '    g.GDRG_ComponentName = model.GDRG_ComponentName
    '    g.GDRG_OriginalName = model.GDRG_OriginalName
    '    g.GDRG_UnitInit = model.GDRG_UnitInit
    '    g.GDRG_UnitReceipt = model.GDRG_UnitReceipt
    '    g.GDRG_UnitPharm = model.GDRG_UnitPharm
    '    g.GDRG_NarcoticClass = model.GDRG_NarcoticClass
    '    g.GDRG_DosageFormClass = model.GDRG_DosageFormClass
    '    g.GDRG_DrugFormType = model.GDRG_DrugFormType
    '    g.GDRG_Syringeful = model.GDRG_Syringeful
    '    g.GDRG_UsageCode = model.GDRG_UsageCode
    '    g.GDRG_ExternalPartCode = model.GDRG_ExternalPartCode
    '    g.GDRG_DosageClass = model.GDRG_DosageClass
    '    g.GDRG_DoseTimes = CType(model.GDRG_DoseTimes, Integer)
    '    g.GDRG_DoseDays = CType(model.GDRG_DoseDays, Integer)
    '    g.GDRG_IntervalDays = CType(model.GDRG_IntervalDays, Integer)
    '    g.GDRG_Dosage = CType(model.GDRG_Dosage, Decimal)
    '    g.GDRG_OnceMaxDosage = CType(model.GDRG_OnceMaxDosage, Decimal)
    '    g.GDRG_DailyMaxDosage = CType(model.GDRG_DailyMaxDosage, Decimal)
    '    g.GDRG_AdoptClass = model.GDRG_AdoptClass
    '    g.GDRG_OrderMedicineFlag = model.GDRG_OrderMedicineFlag
    '    g.GDRG_OrderInjectionFlag = model.GDRG_OrderInjectionFlag
    '    g.GDRG_NerveDestroyFlag = model.GDRG_NerveDestroyFlag
    '    g.GDRG_BiologyFlag = model.GDRG_BiologyFlag
    '    g.GDRG_GenericFlag = model.GDRG_GenericFlag
    '    g.GDRG_DentistrySpecialtyFlag = model.GDRG_DentistrySpecialtyFlag
    '    g.GDRG_ContrastMediumFlag = model.GDRG_ContrastMediumFlag
    '    g.GDRG_GrindFlag = model.GDRG_GrindFlag
    '    g.GDRG_MixFlag = model.GDRG_MixFlag
    '    g.GDRG_DissolveFlag = model.GDRG_DissolveFlag
    '    g.GDRG_PTPFlag = model.GDRG_PTPFlag
    '    g.GDRG_OneDosePackagFlag = model.GDRG_OneDosePackagFlag
    '    g.GDRG_HospitalPreparationFlag = model.GDRG_HospitalPreparationFlag
    '    g.GDRG_INDFlag = model.GDRG_INDFlag
    '    g.GDRG_ExtraDrugFlag = model.GDRG_ExtraDrugFlag
    '    g.GDRG_DiabetesFlag = model.GDRG_DiabetesFlag
    '    g.GDRG_AnticancerDrugFlag = model.GDRG_AnticancerDrugFlag
    '    g.GDRG_SubstituteHotCode1 = model.GDRG_SubstituteHotCode1
    '    g.GDRG_SubstituteHotCode2 = model.GDRG_SubstituteHotCode2
    '    g.GDRG_LabelPrintFlag = model.GDRG_LabelPrintFlag

    '    Return g

    'End Function

    '''' <summary>
    '''' GM_DrugUnitの形式に詰め替え
    '''' </summary>
    '''' <param name="model"></param>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Private Function CM_DrugUnitToGM_DrugUnit(ByVal model As Object) As GM_DrugUnit

    '    Dim g As New GM_DrugUnit

    '    'g.gDUT_FacilityID = model.GDUT_FacilityID
    '    'g.gDUT_StatusClass = model.GDUT_StatusClass
    '    g.GDUT_HotCode = model.GDUT_HotCode
    '    g.GDUT_UnitNo = model.GDUT_UnitNo
    '    g.GDUT_UpdateDate = model.GDUT_UpdateDate
    '    g.GDUT_UpdateClientName = model.GDUT_UpdateClientName
    '    g.GDUT_UpdateStaffID = model.GDUT_UpdateStaffID
    '    g.GDUT_DelFlag = model.GDUT_DelFlag
    '    g.GDUT_UnitCode = model.GDUT_UnitCode
    '    g.GDUT_UnitRatio = model.GDUT_UnitRatio
    '    g.GDUT_CalculateFlag = model.GDUT_CalculateFlag

    '    Return g

    'End Function

    '''' <summary>
    '''' M_Drugの形式に詰め替え
    '''' </summary>
    '''' <param name="model"></param>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Private Function CM_DrugToM_Drug(ByVal model As Object) As M_Drug

    '    Dim m As New M_Drug

    '    m.MDRG_FacilityID = model.MDRG_FacilityID
    '    m.MDRG_StatusClass = model.MDRG_StatusClass
    '    m.MDRG_HotCode = model.MDRG_HotCode
    '    m.MDRG_LogNo = model.MDRG_LogNo
    '    m.MDRG_UpdateDate = model.MDRG_UpdateDate
    '    m.MDRG_UpdateClientName = model.MDRG_UpdateClientName
    '    m.MDRG_UpdateStaffID = model.MDRG_UpdateStaffID
    '    m.MDRG_DelFlag = model.MDRG_DelFlag
    '    m.MDRG_ValidDateFrom = model.MDRG_ValidDateFrom
    '    m.MDRG_ValidDateTo = model.MDRG_ValidDateTo
    '    m.MDRG_ReceiptCode = model.MDRG_ReceiptCode
    '    m.MDRG_StandardCode = model.MDRG_StandardCode
    '    m.MDRG_MHLWCode = model.MDRG_MHLWCode
    '    m.MDRG_PublicCode = model.MDRG_PublicCode
    '    m.MDRG_DrugName = model.MDRG_DrugName
    '    m.MDRG_DrugKana = model.MDRG_DrugKana
    '    m.MDRG_SalesName = model.MDRG_SalesName
    '    m.MDRG_PublicName = model.MDRG_PublicName
    '    m.MDRG_DisplayDrugName = model.MDRG_DisplayDrugName
    '    m.MDRG_SearchKeyword = model.MDRG_SearchKeyword
    '    m.MDRG_ComponentName = model.MDRG_ComponentName
    '    m.MDRG_OriginalName = model.MDRG_OriginalName
    '    m.MDRG_UnitInit = model.MDRG_UnitInit
    '    m.MDRG_UnitReceipt = model.MDRG_UnitReceipt
    '    m.MDRG_UnitPharm = model.MDRG_UnitPharm
    '    m.MDRG_NarcoticClass = model.MDRG_NarcoticClass
    '    m.MDRG_DosageFormClass = model.MDRG_DosageFormClass
    '    m.MDRG_DrugFormType = model.MDRG_DrugFormType
    '    m.MDRG_Syringeful = model.MDRG_Syringeful
    '    m.MDRG_UsageCode = model.MDRG_UsageCode
    '    m.MDRG_ExternalPartCode = model.MDRG_ExternalPartCode
    '    m.MDRG_DosageClass = model.MDRG_DosageClass
    '    m.MDRG_DoseTimes = CType(model.MDRG_DoseTimes, Integer)
    '    m.MDRG_DoseDays = CType(model.MDRG_DoseDays, Integer)
    '    m.MDRG_IntervalDays = CType(model.MDRG_IntervalDays, Integer)
    '    m.MDRG_Dosage = CType(model.MDRG_Dosage, Decimal)
    '    m.MDRG_OnceMaxDosage = CType(model.MDRG_OnceMaxDosage, Decimal)
    '    m.MDRG_DailyMaxDosage = CType(model.MDRG_DailyMaxDosage, Decimal)
    '    m.MDRG_AdoptClass = model.MDRG_AdoptClass
    '    m.MDRG_OrderMedicineFlag = model.MDRG_OrderMedicineFlag
    '    m.MDRG_OrderInjectionFlag = model.MDRG_OrderInjectionFlag
    '    m.MDRG_NerveDestroyFlag = model.MDRG_NerveDestroyFlag
    '    m.MDRG_BiologyFlag = model.MDRG_BiologyFlag
    '    m.MDRG_GenericFlag = model.MDRG_GenericFlag
    '    m.MDRG_DentistrySpecialtyFlag = model.MDRG_DentistrySpecialtyFlag
    '    m.MDRG_ContrastMediumFlag = model.MDRG_ContrastMediumFlag
    '    m.MDRG_GrindFlag = model.MDRG_GrindFlag
    '    m.MDRG_MixFlag = model.MDRG_MixFlag
    '    m.MDRG_DissolveFlag = model.MDRG_DissolveFlag
    '    m.MDRG_PTPFlag = model.MDRG_PTPFlag
    '    m.MDRG_OneDosePackagFlag = model.MDRG_OneDosePackagFlag
    '    m.MDRG_HospitalPreparationFlag = model.MDRG_HospitalPreparationFlag
    '    m.MDRG_INDFlag = model.MDRG_INDFlag
    '    m.MDRG_ExtraDrugFlag = model.MDRG_ExtraDrugFlag
    '    m.MDRG_DiabetesFlag = model.MDRG_DiabetesFlag
    '    m.MDRG_AnticancerDrugFlag = model.MDRG_AnticancerDrugFlag
    '    m.MDRG_SubstituteHotCode1 = model.MDRG_SubstituteHotCode1
    '    m.MDRG_SubstituteHotCode2 = model.MDRG_SubstituteHotCode2
    '    m.MDRG_LabelPrintFlag = model.MDRG_LabelPrintFlag

    '    Return m

    'End Function

    '''' <summary>
    '''' M_DrugUnitの形式に詰め替え
    '''' </summary>
    '''' <param name="model"></param>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Private Function CM_DrugUnitToM_DrugUnit(ByVal model As Object) As M_DrugUnit

    '    Dim m As New M_DrugUnit

    '    m.MDUT_FacilityID = model.MDUT_FacilityID
    '    m.MDUT_StatusClass = model.MDUT_StatusClass
    '    m.MDUT_HotCode = model.MDUT_HotCode
    '    m.MDUT_UnitNo = model.MDUT_UnitNo
    '    m.MDUT_UpdateDate = model.MDUT_UpdateDate
    '    m.MDUT_UpdateClientName = model.MDUT_UpdateClientName
    '    m.MDUT_UpdateStaffID = model.MDUT_UpdateStaffID
    '    m.MDUT_DelFlag = model.MDUT_DelFlag
    '    m.MDUT_UnitCode = model.MDUT_UnitCode
    '    m.MDUT_UnitRatio = model.MDUT_UnitRatio
    '    m.MDUT_CalculateFlag = model.MDUT_CalculateFlag

    '    Return m

    'End Function

    '''' <summary>
    '''' ExternalPartCodeの値を取得する
    '''' </summary>
    '''' <param name="MHLWCode"></param>
    '''' <param name="DrugName"></param>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Private Function ExternalPartCode(MHLWCode As String, DrugName As String) As String
    '    '8バイト目の文字を設定
    '    MHLWCode = MHLWCode.Substring(7, 1)

    '    Dim Code As String = "OTHE"
    '    '設定した文字で条件分岐する
    '    Select Case MHLWCode
    '        Case "Q", "M"
    '            '薬品名に「眼」が含まれているか
    '            If DrugName.IndexOf("眼") > 0 Then
    '                Code = "EYE" '点眼薬・眼軟膏
    '                Exit Select
    '            End If
    '            '薬品名に「耳」が含まれているか
    '            If DrugName.IndexOf("耳") > 0 Then
    '                Code = "EAR" '点耳薬
    '                Exit Select
    '            End If
    '            '薬品名に「鼻」が含まれているか
    '            If DrugName.IndexOf("鼻") > 0 Then
    '                Code = "NOSE" '点鼻薬
    '                Exit Select
    '            End If
    '        Case "S", "T"
    '            Code = "T-SU" '貼付（循環器・気管支・精神神経・麻薬）貼付（湿布）	

    '        Case "M", "N", "P", "R", "V"
    '            '薬品名に「口」が含まれているか
    '            If DrugName.IndexOf("口") > 0 Then
    '                Code = "L-OR" '口腔 塗り薬（軟膏・液・スプレー）
    '            Else '含まれていない場合
    '                Code = "L-SU" '外科・整形外科 塗り薬（軟膏・液・スプレー・その他）
    '            End If

    '        Case "X"
    '            Code = "L-DE" '皮膚科・婦人科・消毒 塗り薬（軟膏・液・スプレー）

    '        Case "E", "F"
    '            Code = "ORAL" 'うがい トローチ

    '        Case "J", "K"
    '            Code = "SUPP" '座薬 浣腸

    '        Case "H"
    '            Code = "VAG"  '膣剤

    '        Case "G"
    '            Code = "INHA" '吸入

    '        Case Else
    '            Code = "OTHE" 'その他
    '    End Select

    '    '設定したコードを返却する
    '    Return Code

    'End Function

End Class

Public Class CM_DrugCondition

    'Public Property Model As New CM_Drug

End Class
