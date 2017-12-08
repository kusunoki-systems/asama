@ModelType kusunoki.M_DrugExBlood
@Code
    If ViewBag.Insert = True Then
        ViewData("Title") = "新規作成"
    Else
        ViewData("Title") = "修正"
    End If
    @:<!--EditBlood.vbhtml-->
End Code
@imports kusunoki.Helpers
<span>
    @Html.ActionLink("TOP", "Index", "", Nothing, "")
    > @Html.ActionLink("病院限定" & ViewBag.MasterTypeTitle.ToString, "Index", "M_Drug", Nothing, "")
    @If ViewBag.Insert = True Then
        @<text>> 病院限定 @ViewBag.MasterTypeTitle 新規作成</text>
    ElseIf ViewBag.Copy = True Then
        @:> @Html.ActionLink("病院限定" & ViewBag.MasterTypeTitle.ToString & "検索結果一覧", "Index", "M_Drug", New With {.retry = "OK"}, New With {.class = "load-start"})
        @<text>> 病院限定 @ViewBag.MasterTypeTitle 新規（複写）</text>
    Else
        @:> @Html.ActionLink("病院限定" & ViewBag.MasterTypeTitle.ToString & "検索結果一覧", "Index", "M_Drug", New With {.retry = "OK"}, New With {.class = "load-start"})
        If Model.Authority Then
        @<text>> 病院限定 @ViewBag.MasterTypeTitle 修正</text>
        Else
        @<text>> 病院限定 @ViewBag.MasterTypeTitle 参照</text>
        End If
    End If
</span>
@If ViewBag.Insert = True Then
    @<h2>病院限定 @ViewBag.MasterTypeTitle 新規作成</h2>
ElseIf ViewBag.Copy = True Then
    @<h2>病院限定 @ViewBag.MasterTypeTitle 新規（複写）</h2>
Else
    If Model.Authority Then
    @<h2>病院限定 @ViewBag.MasterTypeTitle 修正</h2>
Else
    @<h2>病院限定 @ViewBag.MasterTypeTitle 参照</h2>
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
        @Html.HiddenFor(Function(model) model.MDRG_PublicName)
        @Html.HiddenFor(Function(model) model.MDRG_OriginalName)
        @Html.HiddenFor(Function(model) model.MDRG_NarcoticClass)
        @Html.HiddenFor(Function(model) model.MDRG_DrugFormType)
        @Html.HiddenFor(Function(model) model.MDRG_UsageCode)
        @Html.HiddenFor(Function(model) model.MDRG_ExternalPartCode)
        @Html.HiddenFor(Function(model) model.MDRG_DosageClass)
        @Html.HiddenFor(Function(model) model.MDRG_DoseTimes)
        @Html.HiddenFor(Function(model) model.MDRG_DoseDays)
        @Html.HiddenFor(Function(model) model.MDRG_IntervalDays)
        @Html.HiddenFor(Function(model) model.MDRG_Dosage)
        @Html.HiddenFor(Function(model) model.MDRG_OnceMaxDosage)
        @Html.HiddenFor(Function(model) model.MDRG_DailyMaxDosage)
        @Html.HiddenFor(Function(model) model.MDRG_OrderInjectionFlag)
        @Html.HiddenFor(Function(model) model.MDRG_OrderTransfusionFlag)
        @Html.HiddenFor(Function(model) model.MDRG_NerveDestroyFlag)
        @Html.HiddenFor(Function(model) model.MDRG_BiologyFlag)
        @Html.HiddenFor(Function(model) model.MDRG_GenericFlag)
        @Html.HiddenFor(Function(model) model.MDRG_DentistrySpecialtyFlag)
        @Html.HiddenFor(Function(model) model.MDRG_ContrastMediumFlag)
        @Html.HiddenFor(Function(model) model.MDRG_GrindFlag)
        @Html.HiddenFor(Function(model) model.MDRG_MixFlag)
        @Html.HiddenFor(Function(model) model.MDRG_DissolveFlag)
        @Html.HiddenFor(Function(model) model.MDRG_PTPFlag)
        @Html.HiddenFor(Function(model) model.MDRG_OneDosePackagFlag)
        @Html.HiddenFor(Function(model) model.MDRG_HospitalPreparationFlag)
        @Html.HiddenFor(Function(model) model.MDRG_INDFlag)
        @Html.HiddenFor(Function(model) model.MDRG_ExtraDrugFlag)
        @Html.HiddenFor(Function(model) model.MDRG_AnticancerDrugFlag)
        @Html.HiddenFor(Function(model) model.MDRG_SubstituteHotCode1)
        @Html.HiddenFor(Function(model) model.MDRG_SubstituteHotCode2)
        @Html.HiddenFor(Function(model) model.MDRG_PatientLimitedFlag)
         @Html.HiddenFor(Function(model) model.MDRG_Remarks)
         @Html.HiddenFor(Function(model) model.MDRG_DiabetesFlag)
         @Html.HiddenFor(Function(model) model.MDRG_LabelPrintFlag)
         @Html.HiddenFor(Function(model) model.MDRG_OrderMedicineFlag)

        <div class="form-group">
            <!--有効開始日時-->
            @*@Html.LabelFor(Function(Model) Model.MDRG_ValidDateFrom, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_ValidDateFrom, htmlAttributes:=New With {.class = "control-label col-md-2"})
           <div class="col-md-2">
                @*@If Model.MDRG_ValidDateFromCheck = "1" Then
                    @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_ValidDateFrom, "MDRG_ValidDateFrom", "yyyy-MM-dd")
                Else*@
                    @Html.EditorFor(Function(model) model.MDRG_ValidDateFrom, M_Drug_Columns.COLUMN_NAME_MDRG_ValidDateFrom, "MDRG_ValidDateFrom")
                @*End If*@
                @Html.ValidationMessageFor(Function(model) model.MDRG_ValidDateFrom, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-2">
                @*@HtmlHelperEditor.FlagCheckBoxEditor(Model.MDRG_ValidDateFromCheck, "MDRG_ValidDateFromCheck", Model.OptionList_ValidCheck)*@
            </div>
            <!--HOT9コード-->
            @*@Html.LabelFor(Function(Model) Model.MDRG_HotCode, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_HotCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @If ViewBag.Insert = True Then
                    @HtmlHelperEditor.ReadOnlyEditor("<自動採番>", "MDRG_HotCode", "")
                Else
                    @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_HotCode, "MDRG_HotCode", "")
                End If
                @Html.ValidationMessageFor(Function(model) model.MDRG_HotCode, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <!--有効終了日時 -->
            @*@Html.LabelFor(Function(Model) Model.MDRG_ValidDateTo, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
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
            <!--医事連携コード（医薬品コード）-->
            @*@Html.LabelFor(Function(Model) Model.MDRG_ReceiptCode, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
            <label class="control-label col-md-2">医事連携コード</label>
            <div class="col-md-2">
                @Html.EditorFor(Function(model) model.MDRG_ReceiptCode, New With {.htmlAttributes = New With {.class = "form-control ime-inactive", .maxlength = "9"}})
                @Html.ValidationMessageFor(Function(model) model.MDRG_ReceiptCode, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <!--漢字名称 -->
            @*@Html.LabelFor(Function(Model) Model.MDRG_DrugName, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_DrugName, htmlAttributes:=New With {.class = "control-label col-md-2"})
          <div class="col-md-4">
                @Html.EditorFor(Function(model) model.MDRG_DrugName, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
                @Html.ValidationMessageFor(Function(model) model.MDRG_DrugName, "", New With {.class = "text-danger"})
            </div>
            <!--基準番号（HOT番号）-->
            @*@Html.LabelFor(Function(model) model.MDRG_StandardCode, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_StandardCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_StandardCode, "MDRG_StandardCode", "")
            </div>
        </div>

        <div class="form-group">
            <!--カナ名称-->
            @*@Html.LabelFor(Function(Model) Model.MDRG_DrugKana, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_DrugKana, htmlAttributes:=New With {.class = "control-label col-md-2"})
           <div class="col-md-4">
                @Html.EditorFor(Function(model) model.MDRG_DrugKana, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
                @Html.ValidationMessageFor(Function(model) model.MDRG_DrugKana, "", New With {.class = "text-danger"})
            </div>
            <!--薬価基準コード -->
            @*@Html.LabelFor(Function(model) model.MDRG_MHLWCode, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_MHLWCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_MHLWCode, "MDRG_MHLWCode", "")
            </div>
        </div>

        <div class="form-group">
            <!--表示用輸血製剤名-->
            @*@Html.LabelFor(Function(Model) Model.MDRG_DisplayDrugName, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
           <label class="control-label col-md-2">表示用輸血製剤名</label>
           <div class="col-md-4">
                @Html.EditorFor(Function(model) model.MDRG_DisplayDrugName, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
                @Html.ValidationMessageFor(Function(model) model.MDRG_DisplayDrugName, "", New With {.class = "text-danger"})
            </div>
            <!--一般名コード-->
            @*@Html.LabelFor(Function(model) model.MDRG_PublicCode, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_PublicCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_PublicCode, "MDRG_PublicCode", "")
            </div>
        </div>

        <div class="form-group">
            <!--オーダ初期表示単位-->
            @*@Html.LabelFor(Function(Model) Model.MDRG_UnitInit, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_UnitInit, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @If ViewBag.Insert = True Then
                    @HtmlHelperEditor.DropDownEditorUnit(Model.MDRG_UnitInit.ToString.PadLeft(4, "0"), "MDRG_UnitInit", Model.UnitName)
                Else
                    @HtmlHelperEditor.DropDownEditor(Model.MDRG_UnitInit.ToString.PadLeft(4, "0"), "MDRG_UnitInit", Model.Unit, Model.UnitName)
                End If
                @Html.ValidationMessageFor(Function(model) model.MDRG_UnitInit, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-2">
                @If Not ViewBag.Insert = True Then
                    @If DirectCast(ViewBag.Auth, AuthorityInfo).AuthUpdate And Model.Authority Then
                        @Html.ActionLink("単位メンテナンス", "Index", "M_DrugUnit", New With {.id = Model.MDRG_HotCode, .name = Model.MDRG_DrugName, .logno = Model.MDRG_LogNo}, New With {.class = "btn btn-info"})
                    Else
                        @Html.ActionLink("単位メンテナンス", "Index", "M_DrugUnit", New With {.id = Model.MDRG_HotCode, .name = Model.MDRG_DrugName, .logno = Model.MDRG_LogNo}, New With {.class = "btn btn-info", .target = "_blank", .disabled = ""})
                    End If
                End If
            </div>
            <!--販売名-->
            @*@Html.LabelFor(Function(model) model.MDRG_SalesName, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_SalesName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-4">
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_SalesName, "MDRG_SalesName", "")
            </div>
        </div>

        <div class="form-group">
            <!--医事算定単位-->
            @*@Html.LabelFor(Function(Model) Model.MDRG_UnitReceipt, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_UnitReceipt, htmlAttributes:=New With {.class = "control-label col-md-2"})
           <div class="col-md-2">
                @If ViewBag.Insert = True Then
                    @HtmlHelperEditor.DropDownEditorUnit(Model.MDRG_UnitReceipt.ToString.PadLeft(4, "0"), "MDRG_UnitReceipt", Model.UnitName, True)
                    @<div style="display:block; width:280px;">登録後、修正画面で変更できます。</div>
                    Else
                    @HtmlHelperEditor.DropDownEditor(Model.MDRG_UnitReceipt.ToString.PadLeft(4, "0"), "MDRG_UnitReceipt", Model.Unit, Model.UnitName)
                End If
                @Html.ValidationMessageFor(Function(model) model.MDRG_UnitReceipt, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-2"></div>
            <!--成分名-->
            @*@Html.LabelFor(Function(model) model.MDRG_ComponentName, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
            @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_ComponentName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-4">
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_ComponentName, "MDRG_ComponentName", "")
            </div>
        </div>

         <div class="form-group">
             <!--調剤送信単位-->
             @*@Html.LabelFor(Function(model) model.MDRG_UnitPharm, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
             @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_UnitPharm, htmlAttributes:=New With {.class = "control-label col-md-2"})
             <div class="col-md-2">
                 @If ViewBag.Insert = True Then
                     @HtmlHelperEditor.DropDownEditorUnit(Model.MDRG_UnitPharm.ToString.PadLeft(4, "0"), "MDRG_UnitPharm", Model.UnitName, True)
                     @<text>登録後、修正画面で変更できます。</text>
                 Else
                     @HtmlHelperEditor.DropDownEditor(Model.MDRG_UnitPharm.ToString.PadLeft(4, "0"), "MDRG_UnitPharm", Model.Unit, Model.UnitName)
                 End If
                 @Html.ValidationMessageFor(Function(model) model.MDRG_UnitPharm, "", New With {.class = "text-danger"})
             </div>
             <div class="col-md-2"></div>
             <!--剤形区分-->
             @*@Html.LabelFor(Function(Model) Model.MDRG_DosageFormClass, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
             @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_DosageFormClass, htmlAttributes:=New With {.class = "control-label col-md-2"})
             <div class="col-md-2">
                 @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_DosageFormClass, "MDRG_DosageFormClass", Model.OptionList_DosageFormClass)
             </div>
         </div>

         <div class="form-group">
             <!--輸血製剤単位-->
             @*@Html.LabelFor(Function(model) model.MDRG_UnitPharm, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
             @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_TransfusionUnit, htmlAttributes:=New With {.class = "control-label col-md-2"})
             <div class="col-md-2">
                 @If ViewBag.Insert = True Then
                     @HtmlHelperEditor.DropDownEditorUnit(Model.MDRG_TransfusionUnit.ToString.PadLeft(4, "0"), "MDRG_TransfusionUnit", Model.UnitName, True)
                     @<text>登録後、修正画面で変更できます。</text>
                 Else
                     @HtmlHelperEditor.DropDownEditor(Model.MDRG_TransfusionUnit.ToString.PadLeft(4, "0"), "MDRG_TransfusionUnit", Model.Unit, Model.UnitName)
                 End If
                 @Html.ValidationMessageFor(Function(model) model.MDRG_TransfusionUnit, "", New With {.class = "text-danger"})
             </div>
             <div class="col-md-2"></div>
             <!--容量-->
             @*@Html.LabelFor(Function(model) model.MDRG_Syringeful, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
             @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_Syringeful, htmlAttributes:=New With {.class = "control-label col-md-2"})
             <div class="col-md-2">
                 @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_Syringeful, "MDRG_Syringeful", "")
             </div>
         </div>

         <div class="form-group">
             <!--採用区分-->
             @*@Html.LabelFor(Function(Model) Model.MDRG_AdoptClass, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
             @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_AdoptClass, htmlAttributes:=New With {.class = "control-label col-md-2"})
             <div class="col-md-4">
                 @HtmlHelperEditor.FlagRadioButtonEditor(Model.MDRG_AdoptClass, "MDRG_AdoptClass", Model.OptionList_AdoptClass)
                 @Html.ValidationMessageFor(Function(model) model.MDRG_AdoptClass, "", New With {.class = "text-danger"})
             </div>
         </div>
         <div class="form-group">
             <!--輸血英字略称-->
             @*@Html.LabelFor(Function(Model) Model.MDRG_SearchKeyword, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
             <label class="control-label col-md-2">輸血英字略称</label>
             <div class="col-md-4">
                 @Html.EditorFor(Function(model) model.MDRG_SearchKeyword, New With {.htmlAttributes = New With {.class = "form-control ime-inactive"}})
                 @Html.ValidationMessageFor(Function(model) model.MDRG_SearchKeyword, "", New With {.class = "text-danger"})
             </div>
         </div>
         <div class="form-group">
             <!--血液製剤コード-->
             @*@Html.LabelFor(Function(Model) Model.MDRG_SearchKeyword, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
             <label class="control-label col-md-2">血液製剤コード</label>
             <div class="col-md-4">
                 @Html.EditorFor(Function(model) model.MDRG_FormulationCode, New With {.htmlAttributes = New With {.class = "form-control ime-inactive", .maxlength = "7"}})
                 @Html.ValidationMessageFor(Function(model) model.MDRG_FormulationCode, "", New With {.class = "text-danger"})
                 <span id="FormulationCode" class="text-danger">
                 @If Model.MDRG_FormulationCode = "" Then
                         @<text>輸血製剤コードが未入力の場合、輸血オーダで表示されません</text>         
                     End If
                </span>
             </div>
         </div>


        @If ViewBag.Insert <> True AndAlso ViewBag.Copy <> True Then
            @<div class="form-group">
                <div class="col-md-6"></div>
                @*@Html.LabelFor(Function(Model) Model.MDRG_UpdateDate, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
                @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_UpdateDate, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-3">
                    @Html.TextBox("MDRG_UpdateDate", String.Format("{0:yyyy-MM-dd HH:mm:ss}", Model.MDRG_UpdateDate), New With {.class = "form-control text-box single-line", .ReadOnly = "true", .disabled = "disabled"})
                </div>
            </div>

            @<div class="form-group">
                <div class="col-md-6"></div>
                @*@Html.LabelFor(Function(Model) Model.MDRG_UpdateClientName, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
                @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_UpdateClientName, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-3">
                    @HtmlHelperEditor.ReadOnlyEditor(Model.MDRG_UpdateClientName, "MDRG_UpdateClientName", "")
                </div>
            </div>

            @<div class="form-group">
                <div class="col-md-6"></div>
                @*@Html.LabelFor(Function(Model) Model.MDRG_UpdateStaffID, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
                @Html.Label(M_Drug_Columns.COLUMN_NAME_MDRG_UpdateStaffID, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-3">
                    @HtmlHelperEditor.ReadOnlyEditor(Model.UpdateStaffName, "MDRG_UpdateStaffID", "")
                </div>
            </div>
        End If
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
    @Scripts.Render("~/Scripts/MDrugBloodEdit.js")
End Section
