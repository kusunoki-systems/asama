@ModelType WebMasterMaintenance.GM_DrugEX
@Code
        ViewData("Title") = "修正"
End Code

@imports WebMasterMaintenance.Helpers
<span>
    @Html.ActionLink("TOP", "Index", "", Nothing, "")
    > @Html.ActionLink("グループ統一" & ViewBag.MasterTypeTitle.ToString, "Index", "M_Drug", Nothing, "")
    > @Html.ActionLink("グループ統一" & ViewBag.MasterTypeTitle.ToString & "検索結果一覧", "Index", "M_Drug", New With {.retry = "OK"}, New With {.class = "load-start"})
    @If ViewBag.Copy = True Then
        @<text>> グループ統一 @ViewBag.MasterTypeTitle 新規（複写）</text>
    Else
        If Model.Authority Then
        @<text>> グループ統一 @ViewBag.MasterTypeTitle 修正</text>
        Else
        @<text>> グループ統一 @ViewBag.MasterTypeTitle 参照</text>
        End If
    End If
        
</span>
@If ViewBag.Copy = True Then
    @<h2>グループ統一 @ViewBag.MasterTypeTitle 新規（複写）</h2>
Else
    If Model.Authority Then
        @<h2>グループ統一 @ViewBag.MasterTypeTitle 修正 </h2>
    Else
        @<h2>グループ統一 @ViewBag.MasterTypeTitle 参照 </h2>
    End If
End If

<h4>GM_Drug</h4>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        @Html.HiddenFor(Function(model) model.GDRG_LogNo)
        @Html.HiddenFor(Function(model) model.GDRG_DelFlag)
        @Html.HiddenFor(Function(model) model.GDRG_SearchKeyword)
        @Html.HiddenFor(Function(model) model.GDRG_UsageCode)
        @Html.HiddenFor(Function(model) model.GDRG_DosageClass)
        @Html.HiddenFor(Function(model) model.GDRG_DoseTimes)
        @Html.HiddenFor(Function(model) model.GDRG_DoseDays)
        @Html.HiddenFor(Function(model) model.GDRG_IntervalDays)
        @Html.HiddenFor(Function(model) model.GDRG_Dosage)
        @Html.HiddenFor(Function(model) model.GDRG_OrderTransfusionFlag)
        @Html.HiddenFor(Function(model) model.GDRG_SubstituteHotCode1)
        @Html.HiddenFor(Function(model) model.GDRG_SubstituteHotCode2)

        <div class="form-group">
            <!--有効開始日時-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_ValidDateFrom, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @If Model.GDRG_ValidDateFromCheck = "1" Then
                    @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_ValidDateFrom, "GDRG_ValidDateFrom", "yyyy-MM-dd")
                Else
                    @Html.EditorFor(Function(model) model.GDRG_ValidDateFrom, GM_Drug_Columns.COLUMN_NAME_GDRG_ValidDateFrom, "GDRG_ValidDateFrom")
                End If
                @Html.ValidationMessageFor(Function(model) model.GDRG_ValidDateFrom, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-2">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.GDRG_ValidDateFromCheck, "GDRG_ValidDateFromCheck", Model.OptionList_ValidCheck)
            </div>
            <!--HOT9コード-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_HotCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_HotCode, "GDRG_HotCode", "")
            </div>
        </div>

        <div class="form-group">
            <!--有効終了日時 -->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_ValidDateTo, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @If Model.GDRG_ValidDateToCheck = "1" Then
                    @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_ValidDateTo, "GDRG_ValidDateTo", "yyyy-MM-dd")
                Else
                    @Html.EditorFor(Function(model) model.GDRG_ValidDateTo, GM_Drug_Columns.COLUMN_NAME_GDRG_ValidDateTo, "GDRG_ValidDateTo")
                End If
                @Html.ValidationMessageFor(Function(model) model.GDRG_ValidDateTo, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-2">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.GDRG_ValidDateToCheck, "GDRG_ValidDateToCheck", Model.OptionList_ValidCheck)
            </div>
            <!--医薬品コード -->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_ReceiptCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_ReceiptCode, "GDRG_ReceiptCode", "")
            </div>
        </div>

        <div class="form-group">
            <!--漢字名称 -->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_DrugName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @Html.EditorFor(Function(model) model.GDRG_DrugName, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
                @Html.ValidationMessageFor(Function(model) model.GDRG_DrugName, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-1"></div>
            <!--基準番号(HOT番号) -->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_StandardCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_StandardCode, "GDRG_StandardCode", "")
            </div>
        </div>

        <div class="form-group">
            <!--カナ名称 -->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_DrugKana, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @Html.EditorFor(Function(model) model.GDRG_DrugKana, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
                @Html.ValidationMessageFor(Function(model) model.GDRG_DrugKana, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-1"></div>
            <!--薬価基準コード -->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_MHLWCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_MHLWCode, "GDRG_MHLWCode", "")
            </div>
        </div>

        <div class="form-group">
            <!--一般名 -->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_PublicName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @Html.EditorFor(Function(model) model.GDRG_PublicName, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.GDRG_PublicName, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-1"></div>
            <!--一般名コード -->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_PublicCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_PublicCode, "GDRG_PublicCode", "")
            </div>
        </div>

        <div class="form-group">
            <!--表示用薬品名 -->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_DisplayDrugName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @Html.EditorFor(Function(model) model.GDRG_DisplayDrugName, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
                @Html.ValidationMessageFor(Function(model) model.GDRG_DisplayDrugName, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-1"></div>
            <!--販売名- -->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_SalesName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_SalesName, "GDRG_SalesName", "")
                @Html.ValidationMessageFor(Function(model) model.GDRG_SalesName, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <!--オーダ初期表示単位-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_UnitInit, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @HtmlHelperEditor.DropDownEditor(Model.GDRG_UnitInit, "GDRG_UnitInit", Model.Unit, Model.UnitName)
                @Html.ValidationMessageFor(Function(model) model.GDRG_UnitInit, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-2">
                @If DirectCast(ViewBag.Auth, AuthorityInfo).AuthUpdate And Model.Authority Then
                    @Html.ActionLink("単位メンテナンス", "Index", "M_DrugUnit", New With {.id = Model.GDRG_HotCode, .name = Model.GDRG_DrugName, .logno = Model.GDRG_LogNo}, New With {.class = "btn btn-info"})
                Else
                    @Html.ActionLink("単位メンテナンス", "Index", "M_DrugUnit", New With {.id = Model.GDRG_HotCode, .name = Model.GDRG_DrugName, .logno = Model.GDRG_LogNo}, New With {.class = "btn btn-info", .target = "_blank", .disabled = ""})
                End If
            </div>
            <!--成分名 -->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_ComponentName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_ComponentName, "GDRG_ComponentName", "")
                @Html.ValidationMessageFor(Function(model) model.GDRG_ComponentName, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <!--医事算定単位 -->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_UnitReceipt, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @HtmlHelperEditor.DropDownEditor(Model.GDRG_UnitReceipt, "GDRG_UnitReceipt", Model.Unit, Model.UnitName)
                @Html.ValidationMessageFor(Function(model) model.GDRG_UnitReceipt, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-2"></div>
            <!--先発品名 -->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_OriginalName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_OriginalName, "GDRG_OriginalName", "")
                @Html.ValidationMessageFor(Function(model) model.GDRG_OriginalName, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <!--調剤送信単位 -->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_UnitPharm, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @HtmlHelperEditor.DropDownEditor(Model.GDRG_UnitPharm, "GDRG_UnitPharm", Model.Unit, Model.UnitName)
                @Html.ValidationMessageFor(Function(model) model.GDRG_UnitPharm, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-2"></div>
            <!--麻毒区分-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_NarcoticClass, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_NarcoticClass, "GDRG_NarcoticClass", Model.OptionList_NarcoticClass)
                @Html.ValidationMessageFor(Function(model) model.GDRG_NarcoticClass, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <!--採用区分-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_AdoptClass, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagRadioButtonEditor(Model.GDRG_AdoptClass, "GDRG_AdoptClass", Model.OptionList_AdoptClass)
                @Html.ValidationMessageFor(Function(model) model.GDRG_AdoptClass, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-1"></div>
            <!--剤形区分-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_DosageFormClass, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_DosageFormClass, "GDRG_DosageFormClass", Model.OptionList_DosageFormClass)
                @Html.ValidationMessageFor(Function(model) model.GDRG_DosageFormClass, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <!--処方オーダ対象-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_OrderMedicineFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.GDRG_OrderMedicineFlag, "GDRG_OrderMedicineFlag", Options.GetOption_CheckFlag)
            </div>
            <div class="col-md-1"></div>
            <!--薬品形態種別-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_DrugFormType, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_DrugFormType, "GDRG_DrugFormType", "")
                @Html.ValidationMessageFor(Function(model) model.GDRG_DrugFormType, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <!--注射オーダー対象-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_OrderInjectionFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @If Model.GDRG_DosageFormClass = "4" Then
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.GDRG_OrderInjectionFlag, "GDRG_OrderInjectionFlag", Options.GetOption_CheckFlag)
                Else
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.GDRG_OrderInjectionFlag, "GDRG_OrderInjectionFlag", Options.GetOption_CheckFlag, True)
                End If    
            </div>
            <div class="col-md-1"></div>
            <!--外用部位分類-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_ExternalPartCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @If Model.GDRG_DosageFormClass = "6" Then@*外用薬の場合のみ有効*@
                @HtmlHelperEditor.DropDownEditor(Model.GDRG_ExternalPartCode, "GDRG_ExternalPartCode", Model.OptionList_ExternalPartCode)
                Else
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_ExternalPartCode, "GDRG_ExternalPartCode", "")
                End If
                @Html.ValidationMessageFor(Function(model) model.GDRG_ExternalPartCode, "", New With {.class = "text-danger"})
            </div>

        </div>
        <div class="form-group">
            <!--治験薬フラグ-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_INDFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.GDRG_INDFlag, "GDRG_INDFlag", Options.GetOption_CheckFlag)
            </div>
            <div class="col-md-1"></div>
            <!--注射容量-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_Syringeful, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @If Model.GDRG_DosageFormClass = "4" Then@*注射の場合のみ有効*@
                @Html.EditorFor(Function(model) model.GDRG_Syringeful, New With {.htmlAttributes = New With {.class = "form-control text-right"}})
                Else
                @Html.EditorFor(Function(model) model.GDRG_Syringeful, New With {.htmlAttributes = New With {.class = "form-control text-right", .disabled = "disabled"}})
                @Html.HiddenFor(Function(model) model.GDRG_Syringeful)
                End If
                @Html.ValidationMessageFor(Function(model) model.GDRG_Syringeful, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-2">
                <label class="control-label">mL</label>
            </div>
        </div>
        <div class="form-group">
            <!--臨時薬フラグ-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_ExtraDrugFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.GDRG_ExtraDrugFlag, "GDRG_ExtraDrugFlag", Options.GetOption_CheckFlag)
            </div>
            <div class="col-md-1"></div>
            <!--1回MAX量-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_OnceMaxDosage, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_OnceMaxDosage, "GDRG_OnceMaxDosage", "")
                @Html.ValidationMessageFor(Function(model) model.GDRG_OnceMaxDosage, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <!--糖尿病薬フラグ-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_DiabetesFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.GDRG_DiabetesFlag, "GDRG_DiabetesFlag", Options.GetOption_CheckFlag)
            </div>
            <div class="col-md-1"></div>
            <!--1日MAX量-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_DailyMaxDosage, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_DailyMaxDosage, "GDRG_DailyMaxDosage", "")
                @Html.ValidationMessageFor(Function(model) model.GDRG_DailyMaxDosage, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <!--抗癌薬フラグ-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_AnticancerDrugFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.GDRG_AnticancerDrugFlag, "GDRG_AnticancerDrugFlag", Options.GetOption_CheckFlag)
            </div>
            <div class="col-md-1"></div>
            <!--神経破壊剤-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_NerveDestroyFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_NerveDestroyFlag, "GDRG_NerveDestroyFlag", Model.OptionList_NerveDestroyFlag)
            </div>
        </div>

        <div class="form-group">
            <!--ラベル印刷対象フラグ-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_LabelPrintFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.GDRG_LabelPrintFlag, "GDRG_LabelPrintFlag", Options.GetOption_CheckFlag)
            </div>
            <div class="col-md-1"></div>
            <!--生物学的製剤-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_BiologyFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_BiologyFlag, "GDRG_BiologyFlag", Model.OptionList_BiologyFlag)
            </div>
        </div>

        <div class="form-group">
            <!--患者限定採用フラグ-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_PatientLimitedFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.GDRG_PatientLimitedFlag, "GDRG_PatientLimitedFlag", Options.GetOption_CheckFlag)
            </div>
            <div class="col-md-1"></div>
            <!--後発品-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_GenericFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_GenericFlag, "GDRG_GenericFlag", Model.OptionList_GenericFlag)
            </div>
        </div>
        <div class="form-group">
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_Remarks, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-4">
                <textarea id="GDRG_Remarks" name="GDRG_Remarks" cols="150" rows="5" class="form-control">@Model.GDRG_Remarks</textarea>
            </div>
            <!--造影剤-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_ContrastMediumFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_ContrastMediumFlag, "GDRG_ContrastMediumFlag", Model.OptionList_ContrastMediumFlag)
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-6"></div>
            @If ViewBag.Copy <> True Then
                @<!--更新日時-->
                @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_UpdateDate, htmlAttributes:=New With {.class = "control-label col-md-2"})
                @<div class="col-md-3">
                    @Html.TextBox("GDRG_UpdateDate", String.Format("{0:yyyy-MM-dd HH:mm:ss}", Model.GDRG_UpdateDate), New With {.class = "form-control text-box single-line", .ReadOnly = "true", .disabled = "disabled"})
                </div>
            End If
        </div>
        <div class="form-group">
            <div class="col-md-6"></div>
            @If ViewBag.Copy <> True Then
                @<!--更新端末名-->
                @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_UpdateClientName, htmlAttributes:=New With {.class = "control-label col-md-2"})
                @<div class="col-md-3">
                    @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_UpdateClientName, "GDRG_UpdateClientName", "")
                </div>
            End If
        </div>

        <div class="form-group">
            <div class="col-md-6"></div>
            @If ViewBag.Copy <> True Then
                @<!--更新職員ID-->
                @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_UpdateStaffID, htmlAttributes:=New With {.class = "control-label col-md-2"})
                @<div class="col-md-3">
                    @HtmlHelperEditor.ReadOnlyEditor(Model.UpdateStaffName, "GDRG_UpdateStaffID", "")
                </div>
            End If
        </div>
        @*
            <!--粉砕-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_GrindFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.GDRG_GrindFlag, "GDRG_GrindFlag", Model.OptionList_GrindFlag)
            </div>
            <!--混合-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_MixFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.GDRG_MixFlag, "GDRG_MixFlag", Model.OptionList_MixFlag)
            </div>
            <!--溶解-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_DissolveFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.GDRG_DissolveFlag, "GDRG_DissolveFlag", Model.OptionList_DissolveFlag)
            </div>
            <!--PTP-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_PTPFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.GDRG_PTPFlag, "GDRG_PTPFlag", Model.OptionList_PTPFlag)
            </div>
            <!--一包化-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_OneDosePackagFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.GDRG_OneDosePackagFlag, "GDRG_OneDosePackagFlag", Model.OptionList_OneDosePackagFlag)
            </div>
            <!--院内製剤-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_HospitalPreparationFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.GDRG_HospitalPreparationFlag, "GDRG_HospitalPreparationFlag", Model.OptionList_HospitalPreparationFlag)
            </div>
            <!--歯科特定医薬品-->
            @Html.Label(GM_Drug_Columns.COLUMN_NAME_GDRG_DentistrySpecialtyFlag, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-3">
                @HtmlHelperEditor.FlagCheckBoxEditor(Model.GDRG_DentistrySpecialtyFlag, "GDRG_DentistrySpecialtyFlag", Options.GetOption_CheckFlag)
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
    @Html.ActionLink("グループ統一 " & ViewBag.MasterTypeTitle.ToString & "へ戻る", "Index", "GM_Drug")
 Else
    @Html.ActionLink("検索結果一覧へ戻る", "Index", "GM_Drug", New With {.retry = "OK"}, New With {.class = "load-start"})
 End If
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
    @Scripts.Render("~/Scripts/GMDrugEdit.js")
End Section
