<section>
    @ModelType WebMasterMaintenance.M_DrugEX
@Code
    ViewData("Title") = "修正"
End Code

@imports WebMasterMaintenance.Helpers
<span>
    @Html.ActionLink("TOP", "Index", "", Nothing, "")
    > @Html.ActionLink("病院限定" & ViewBag.MasterTypeTitle.ToString, "Index", "M_Drug", Nothing, "")
    > @Html.ActionLink("病院限定" & ViewBag.MasterTypeTitle.ToString & "検索結果一覧", "Index", "M_Drug", New With {.retry = "OK"}, New With {.class = "load-start"})
    @If ViewBag.Copy = True Then
        @<text>> 病院限定 @ViewBag.MasterTypeTitle 新規（複写）</text>
    Else
        If Model.Authority Then
        @<text>> 病院限定 @ViewBag.MasterTypeTitle 修正</text>
        Else
        @<text>> 病院限定 @ViewBag.MasterTypeTitle 参照</text>
        End If
    End If

</span>
@If ViewBag.Copy = True Then
    @<h2>病院限定 @ViewBag.MasterTypeTitle 新規（複写）</h2>
Else
    If Model.Authority Then
    @<h2>病院限定 @ViewBag.MasterTypeTitle 修正 </h2>
Else
    @<h2>病院限定 @ViewBag.MasterTypeTitle 参照 </h2>
End If
End If

<h4>M_Drug</h4>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        @Html.HiddenFor(Function(model) model.MDRG_FacilityID)
        @Html.HiddenFor(Function(model) model.MDRG_StatusClass)
        @Html.HiddenFor(Function(model) model.MDRG_LogNo)
        @Html.HiddenFor(Function(model) model.MDRG_DelFlag)
        @Html.HiddenFor(Function(model) model.MDRG_SearchKeyword)
        @Html.HiddenFor(Function(model) model.MDRG_UsageCode)
        @Html.HiddenFor(Function(model) model.MDRG_DosageClass)
        @Html.HiddenFor(Function(model) model.MDRG_DoseTimes)
        @*@Html.HiddenFor(Function(model) model.MDRG_DoseDays)*@
        @Html.HiddenFor(Function(model) model.MDRG_IntervalDays)
        @Html.HiddenFor(Function(model) model.MDRG_Dosage)
        @Html.HiddenFor(Function(model) model.MDRG_OrderTransfusionFlag)
        @Html.HiddenFor(Function(model) model.MDRG_SubstituteHotCode1)
        @Html.HiddenFor(Function(model) model.MDRG_SubstituteHotCode2)

        <div class="form-group">
            <!--有効開始日時-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_ValidDateFrom, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @*@If Model.MDRG_ValidDateFromCheck = "1" Then*@
                @*@HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_ValidDateFrom, "MDRG_ValidDateFrom", "yyyy-MM-dd")
                    Else*@
                @Html.EditorFor(Function(model) model.MDRG_ValidDateFrom, M_Drug_Columns.COLUMN_NAME_MDRG_ValidDateFrom, "MDRG_ValidDateFrom")
                @*End If*@
                @Html.ValidationMessageFor(Function(model) model.MDRG_ValidDateFrom, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-2">
                <!--HtmlHelperEditor.FlagCheckBoxEditor(Model.MDRG_ValidDateFromCheck, "MDRG_ValidDateFromCheck", Model.OptionList_ValidCheck)-->
            </div>
            <!--HOT9コード-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_HotCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_HotCode, "MDRG_HotCode", "")
            </div>
        </div>

        <div class="form-group">
            <!--有効終了日時 -->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_ValidDateTo, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @If Model.MDRG_ValidDateToCheck = "1" Then
                    @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_ValidDateTo, "MDRG_ValidDateTo", "yyyy-MM-dd")
                Else
                    @Html.EditorFor(Function(model) model.MDRG_ValidDateTo, M_Drug_Columns.COLUMN_NAME_MDRG_ValidDateTo, "MDRG_ValidDateTo")
                End If
                @Html.ValidationMessageFor(Function(model) model.MDRG_ValidDateTo, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-2">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.MDRG_ValidDateToCheck, "MDRG_ValidDateToCheck", Model.OptionList_ValidCheck)
            </div>
            <!--医薬品コード -->
            @*@Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_ReceiptCode, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
            <label class="control-label col-md-2">医事連携コード</label>
    　      <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_ReceiptCode, "MDRG_ReceiptCode", "")
            </div>
        </div>

        <div class="form-group">
            <!--漢字名称 -->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_DrugName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @Html.EditorFor(Function(model) model.MDRG_DrugName, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
                @Html.ValidationMessageFor(Function(model) model.MDRG_DrugName, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-1"></div>
            <!--基準番号(HOT番号) -->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_StandardCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_StandardCode, "MDRG_StandardCode", "")
            </div>
        </div>

        <div class="form-group">
            <!--カナ名称 -->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_DrugKana, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @Html.EditorFor(Function(model) model.MDRG_DrugKana, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
                @Html.ValidationMessageFor(Function(model) model.MDRG_DrugKana, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-1"></div>
            <!--薬価基準コード -->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_MHLWCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_MHLWCode, "MDRG_MHLWCode", "")
            </div>
        </div>

        <div class="form-group">
            <!--一般名 -->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_PublicName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @Html.EditorFor(Function(model) model.MDRG_PublicName, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.MDRG_PublicName, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-1"></div>
            <!--一般名コード -->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_PublicCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_PublicCode, "MDRG_PublicCode", "")
            </div>
        </div>

        <div class="form-group">
            <!--表示用薬品名 -->
            @*@Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_DisplayDrugName, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
            <label class="control-label col-md-2">表示用薬品名</label>
            <div class="col-md-3">
                @Html.EditorFor(Function(model) model.MDRG_DisplayDrugName, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
                @Html.ValidationMessageFor(Function(model) model.MDRG_DisplayDrugName, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-1"></div>
            <!--販売名- -->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_SalesName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_SalesName, "MDRG_SalesName", "")
                @Html.ValidationMessageFor(Function(model) model.MDRG_SalesName, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <!--オーダ初期表示単位-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_UnitInit, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @HtmlHelperEditor.DropDownEditor(Model.MDRG_UnitInit, "MDRG_UnitInit", Model.Unit, Model.UnitName)
                @Html.ValidationMessageFor(Function(model) model.MDRG_UnitInit, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-2">
                @If DirectCast(ViewBag.Auth, AuthorityInfo).AuthUpdate And Model.Authority Then
                    @Html.ActionLink("単位メンテナンス", "Index", "M_DrugUnit", New With {.id = Model.MDRG_HotCode, .name = Model.MDRG_DrugName, .logno = Model.MDRG_LogNo}, New With {.class = "btn btn-info"})
                Else
                    @Html.ActionLink("単位メンテナンス", "Index", "M_DrugUnit", New With {.id = Model.MDRG_HotCode, .name = Model.MDRG_DrugName, .logno = Model.MDRG_LogNo}, New With {.class = "btn btn-info", .target = "_blank", .disabled = ""})
                End If
            </div>
            <!--成分名 -->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_ComponentName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_ComponentName, "MDRG_ComponentName", "")
                @Html.ValidationMessageFor(Function(model) model.MDRG_ComponentName, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <!--医事算定単位 -->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_UnitReceipt, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @HtmlHelperEditor.DropDownEditor(Model.MDRG_UnitReceipt, "MDRG_UnitReceipt", Model.Unit, Model.UnitName)
                @Html.ValidationMessageFor(Function(model) model.MDRG_UnitReceipt, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-2"></div>
            <!--先発品名 -->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_OriginalName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_OriginalName, "MDRG_OriginalName", "")
                @Html.ValidationMessageFor(Function(model) model.MDRG_OriginalName, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <!--調剤送信単位 -->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_UnitPharm, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @HtmlHelperEditor.DropDownEditor(Model.MDRG_UnitPharm, "MDRG_UnitPharm", Model.Unit, Model.UnitName)
                @Html.ValidationMessageFor(Function(model) model.MDRG_UnitPharm, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-2"></div>
            <!--麻毒区分-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_NarcoticClass, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_NarcoticClass, "MDRG_NarcoticClass", Model.OptionList_NarcoticClass)
                @Html.ValidationMessageFor(Function(model) model.MDRG_NarcoticClass, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <!--採用区分-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_AdoptClass, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagRadioButtonEditor(Model.MDRG_AdoptClass, "MDRG_AdoptClass", Model.OptionList_AdoptClass)
                @Html.ValidationMessageFor(Function(model) model.MDRG_AdoptClass, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-1"></div>
            <!--剤形区分-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_DosageFormClass, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_DosageFormClass, "MDRG_DosageFormClass", Model.OptionList_DosageFormClass)
                @Html.ValidationMessageFor(Function(model) model.MDRG_DosageFormClass, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <!--処方オーダ対象-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_OrderMedicineFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.MDRG_OrderMedicineFlag, "MDRG_OrderMedicineFlag", Options.GetOption_CheckFlag)
            </div>
            <div class="col-md-1"></div>
            <!--薬品形態種別-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_DrugFormType, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_DrugFormType, "MDRG_DrugFormType", "")
                @Html.ValidationMessageFor(Function(model) model.MDRG_DrugFormType, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <!--注射オーダー対象-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_OrderInjectionFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @If Model.MDRG_DosageFormClass = "4" Then
                    @HtmlHelperEditor.FlagCheckBoxEditor(Model.MDRG_OrderInjectionFlag, "MDRG_OrderInjectionFlag", Options.GetOption_CheckFlag)
                Else
                    @HtmlHelperEditor.FlagCheckBoxEditor(Model.MDRG_OrderInjectionFlag, "MDRG_OrderInjectionFlag", Options.GetOption_CheckFlag, True)
                End If
            </div>
            <div class="col-md-1"></div>
            <!--外用部位分類-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_ExternalPartCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @If Model.MDRG_DosageFormClass = "6" Then@*外用薬の場合のみ有効*@
                @HtmlHelperEditor.DropDownEditor(Model.MDRG_ExternalPartCode, "MDRG_ExternalPartCode", Model.OptionList_ExternalPartCode)
                Else
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_ExternalPartCode, "MDRG_ExternalPartCode", "")
                End If
                @Html.ValidationMessageFor(Function(model) model.MDRG_ExternalPartCode, "", New With {.class = "text-danger"})
            </div>
        </div>
        <div class="form-group">
            <!--治験薬フラグ-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_INDFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.MDRG_INDFlag, "MDRG_INDFlag", Options.GetOption_CheckFlag)
            </div>
            <div class="col-md-1"></div>
            <!--注射容量-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_Syringeful, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @If Model.MDRG_DosageFormClass = "4" Then@*注射の場合のみ有効*@
                @Html.EditorFor(Function(model) model.MDRG_Syringeful, New With {.htmlAttributes = New With {.class = "form-control text-right"}})
                Else
                @Html.EditorFor(Function(model) model.MDRG_Syringeful, New With {.htmlAttributes = New With {.class = "form-control text-right", .disabled = "disabled"}})
                @Html.HiddenFor(Function(model) model.MDRG_Syringeful)
                End If
                @Html.ValidationMessageFor(Function(model) model.MDRG_Syringeful, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-2">
                <label class="control-label">mL</label>
            </div>
        </div>
        <div class="form-group">
            <!--臨時薬フラグ-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_ExtraDrugFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.MDRG_ExtraDrugFlag, "MDRG_ExtraDrugFlag", Options.GetOption_CheckFlag)
            </div>
            <div class="col-md-1"></div>
            <!--最大投与日数-->
            <label class="control-label col-md-2">最大投与日数</label>
            <div class="col-md-2">
                @If (Model.MDRG_DoseDays = -99999999) Then
                        Model.MDRG_DoseDays = 0
                    End If
                @If Model.MDRG_DosageFormClass = "1" Then@*内服の場合のみ有効*@
                @Html.EditorFor(Function(model) model.MDRG_DoseDays, New With {.htmlAttributes = New With {.class = "form-control text-right"}})
                Else
                @Html.EditorFor(Function(model) model.MDRG_DoseDays, New With {.htmlAttributes = New With {.class = "form-control text-right", .disabled = "disabled"}})
                End If
                @Html.ValidationMessageFor(Function(model) model.MDRG_DoseDays, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-2">
                <label class="control-label">日</label>
            </div>
        </div>

        <div class="form-group">
            <!--糖尿病薬フラグ-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_DiabetesFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.MDRG_DiabetesFlag, "MDRG_DiabetesFlag", Options.GetOption_CheckFlag)
            </div>
            <div class="col-md-1"></div>
            <!--1回MAX量-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_OnceMaxDosage, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @If (Model.MDRG_OnceMaxDosage = -1.0) Then
                        Model.MDRG_OnceMaxDosage = 0
                    End If
                @Html.EditorFor(Function(model) model.MDRG_OnceMaxDosage, New With {.htmlAttributes = New With {.class = "form-control text-right"}})
                @*@HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_OnceMaxDosage, "MDRG_OnceMaxDosage", "")*@
                @Html.ValidationMessageFor(Function(model) model.MDRG_OnceMaxDosage, "", New With {.class = "text-danger", .style = "display: block; width: 280px;"})
            </div>
        </div>

        <div class="form-group">
            <!--抗癌薬フラグ-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_AnticancerDrugFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.MDRG_AnticancerDrugFlag, "MDRG_AnticancerDrugFlag", Options.GetOption_CheckFlag)
            </div>
            <div class="col-md-1"></div>
            <!--1日MAX量-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_DailyMaxDosage, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @If (Model.MDRG_DailyMaxDosage = -1.0) Then
                        Model.MDRG_DailyMaxDosage = 0
                    End If
                @Html.EditorFor(Function(model) model.MDRG_DailyMaxDosage, New With {.htmlAttributes = New With {.class = "form-control text-right"}})
                @*@HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_DailyMaxDosage, "MDRG_DailyMaxDosage", "")*@
                @Html.ValidationMessageFor(Function(model) model.MDRG_DailyMaxDosage, "", New With {.class = "text-danger", .style = "display: block; width: 280px;"})
            </div>
        </div>

        <div class="form-group">
            <!--ラベル印刷対象フラグ-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_LabelPrintFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.MDRG_LabelPrintFlag, "MDRG_LabelPrintFlag", Options.GetOption_CheckFlag)
            </div>
            <div class="col-md-1"></div>
            <!--神経破壊剤-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_NerveDestroyFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_NerveDestroyFlag, "MDRG_NerveDestroyFlag", Model.OptionList_NerveDestroyFlag)
            </div>
        </div>

        <div class="form-group">
            <!--患者限定採用フラグ-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_PatientLimitedFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.MDRG_PatientLimitedFlag, "MDRG_PatientLimitedFlag", Options.GetOption_CheckFlag)
            </div>
            <div class="col-md-1"></div>
            <!--生物学的製剤-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_BiologyFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_BiologyFlag, "MDRG_BiologyFlag", Model.OptionList_BiologyFlag)
            </div>
        </div>
        <div class="form-group">
            <!--備考-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_Remarks, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-4">
                <textarea id="MDRG_Remarks" name="MDRG_Remarks" cols="150" rows="5" class="form-control">@Model.MDRG_Remarks</textarea>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <!--後発品-->
                    @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_GenericFlag, htmlAttributes:=New With {.class = "control-label col-md-4"})
                    <div class="col-md-6">
                        @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_GenericFlag, "MDRG_GenericFlag", Model.OptionList_GenericFlag)
                    </div>
                </div>
                <div class="form-group">
                    <!--造影剤-->
                    @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_ContrastMediumFlag, htmlAttributes:=New With {.class = "control-label col-md-4"})
                    <div class="col-md-6">
                        @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_ContrastMediumFlag, "MDRG_ContrastMediumFlag", Model.OptionList_ContrastMediumFlag)
                    </div>
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-6"></div>
            @If ViewBag.Copy <> True Then
                @<!--更新日時-->
                @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_UpdateDate, htmlAttributes:=New With {.class = "control-label col-md-2"})
                @<div class="col-md-3">
                    @Html.TextBox("MDRG_UpdateDate", String.Format("{0:yyyy-MM-dd HH:mm:ss}", Model.MDRG_UpdateDate), New With {.class = "form-control text-box single-line", .ReadOnly = "true", .disabled = "disabled"})
                </div>
            End If
        </div>
        <div class="form-group">
            <div class="col-md-6"></div>
            @If ViewBag.Copy <> True Then
                @<!--更新端末名-->
                @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_UpdateClientName, htmlAttributes:=New With {.class = "control-label col-md-2"})
                @<div class="col-md-3">
                    @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_UpdateClientName, "MDRG_UpdateClientName", "")
                </div>
            End If
        </div>

        <div class="form-group">
            <div class="col-md-6"></div>
            @If ViewBag.Copy <> True Then
                @<!--更新職員ID-->
                @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_UpdateStaffID, htmlAttributes:=New With {.class = "control-label col-md-2"})
                @<div class="col-md-3">
                    @HtmlHelperEditor.ReadOnlyEditor(Model.UpdateStaffName, "MDRG_UpdateStaffID", "")
                </div>
            End If
        </div>
        @*
            <!--粉砕-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_GrindFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.MDRG_GrindFlag, "MDRG_GrindFlag", Model.OptionList_GrindFlag)
            </div>
            <!--混合-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_MixFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.MDRG_MixFlag, "MDRG_MixFlag", Model.OptionList_MixFlag)
            </div>
            <!--溶解-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_DissolveFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.MDRG_DissolveFlag, "MDRG_DissolveFlag", Model.OptionList_DissolveFlag)
            </div>
            <!--PTP-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_PTPFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.MDRG_PTPFlag, "MDRG_PTPFlag", Model.OptionList_PTPFlag)
            </div>
            <!--一包化-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_OneDosePackagFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.MDRG_OneDosePackagFlag, "MDRG_OneDosePackagFlag", Model.OptionList_OneDosePackagFlag)
            </div>
            <!--院内製剤-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_HospitalPreparationFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.MDRG_HospitalPreparationFlag, "MDRG_HospitalPreparationFlag", Model.OptionList_HospitalPreparationFlag)
            </div>
            <!--歯科特定医薬品-->
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_DentistrySpecialtyFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.MDRG_DentistrySpecialtyFlag, "MDRG_DentistrySpecialtyFlag", Options.GetOption_CheckFlag)
            </div>
        *@

        <div class="form-group">
            @If ViewBag.Insert = True OrElse ViewBag.Copy = True Then
                @<div class="col-md-offset-2 col-md-1">
                    @If DirectCast(ViewBag.Auth, AuthorityInfo).AuthInsert AndAlso Model.Authority Then
                        @<button type="submit" name="SubmitButton" value="Regist" id="SubmitRegist" class="btn btn-primary btn-block">登録</button>
                        @*Else
                            @<button type="submit" name="SubmitButton" value="Regist" id="SubmitRegist" class="btn btn-primary btn-block" disabled="">登録</button>*@
                    End If
                </div>
            Else
                @<div class="col-md-offset-0 col-md-1">
                    @If DirectCast(ViewBag.Auth, AuthorityInfo).AuthCancel AndAlso Model.Authority Then
                        @<button type="submit" name="SubmitButton" value="Delete" id="SubmitDelete" class="btn btn-warning btn-block">削除</button>
                        @*Else
                            @<button type="submit" name="SubmitButton" value="Delete" id="SubmitDelete" class="btn btn-warning btn-block" disabled="">削除</button>*@
                    End If
                </div>
                @<div class="col-md-offset-1 col-md-1">
                    @If DirectCast(ViewBag.Auth, AuthorityInfo).AuthUpdate AndAlso Model.Authority Then
                        @<button type="submit" name="SubmitButton" value="Regist" id="SubmitRegist" class="btn btn-primary btn-block">登録</button>
                        @*Else
                            @<button type="submit" name="SubmitButton" value="Regist" id="SubmitRegist" class="btn btn-primary btn-block" disabled="">登録</button>*@
                    End If
                </div>
            End If
        </div>
    </div>

End Using

<div>
    @If ViewBag.Insert = True OrElse ViewBag.Copy = True Then
        @Html.ActionLink("病院限定 " & ViewBag.MasterTypeTitle.ToString & "へ戻る", "Index", "M_Drug")
    Else
        @Html.ActionLink("検索結果一覧へ戻る", "Index", "M_Drug", New With {.retry = "OK"}, New With {.class = "load-start"})
    End If
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
    @Scripts.Render("~/Scripts/MDrugEdit.js")
End section