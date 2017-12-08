@ModelType WebMasterMaintenance.M_DrugExBlood
@Code
    If ViewBag.Insert = True Then
        ViewData("Title") = "新規作成"
    Else
        ViewData("Title") = "修正"
    End If
    @:<!--EditBlood.vbhtml-->
End Code
@imports WebMasterMaintenance.Helpers
<span>
    @Html.ActionLink("TOP", "Index", "", Nothing, "")
    > @Html.ActionLink("グループ統一" & ViewBag.MasterTypeTitle.ToString, "Index", "M_Drug", Nothing, "")
    @If ViewBag.Insert = True Then
        @<text>> グループ統一 @ViewBag.MasterTypeTitle 新規作成</text>
    ElseIf ViewBag.Copy = True Then
        @:> @Html.ActionLink("グループ統一" & ViewBag.MasterTypeTitle.ToString & "検索結果一覧", "Index", "M_Drug", New With {.retry = "OK"}, New With {.class = "load-start"})
        @<text>> グループ統一 @ViewBag.MasterTypeTitle 新規（複写）</text>
    Else
        @:> @Html.ActionLink("グループ統一" & ViewBag.MasterTypeTitle.ToString & "検索結果一覧", "Index", "M_Drug", New With {.retry = "OK"}, New With {.class = "load-start"})
        If Model.Authority Then
        @<text>> グループ統一 @ViewBag.MasterTypeTitle 修正</text>
        Else
        @<text>> グループ統一 @ViewBag.MasterTypeTitle 参照</text>
        End If
    End If
</span>
@If ViewBag.Insert = True Then
    @<h2>グループ統一 @ViewBag.MasterTypeTitle 新規作成</h2>
ElseIf ViewBag.Copy = True Then
    @<h2>グループ統一 @ViewBag.MasterTypeTitle 新規（複写）</h2>
Else
    If Model.Authority Then
    @<h2>グループ統一 @ViewBag.MasterTypeTitle 修正</h2>
Else
    @<h2>グループ統一 @ViewBag.MasterTypeTitle 参照</h2>
End If
End If
<h4>M_Drug</h4>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        @Html.HiddenFor(Function(model) model.GDRG_FacilityID)
        @Html.HiddenFor(Function(model) model.GDRG_StatusClass)
        @Html.HiddenFor(Function(model) model.GDRG_LogNo)
        @Html.HiddenFor(Function(model) model.GDRG_DelFlag)
        @Html.HiddenFor(Function(model) model.GDRG_PublicName)
        @Html.HiddenFor(Function(model) model.GDRG_OriginalName)
        @Html.HiddenFor(Function(model) model.GDRG_NarcoticClass)
        @Html.HiddenFor(Function(model) model.GDRG_DrugFormType)
        @Html.HiddenFor(Function(model) model.GDRG_TransfusionUnit)
        @Html.HiddenFor(Function(model) model.GDRG_UsageCode)
        @Html.HiddenFor(Function(model) model.GDRG_ExternalPartCode)
        @Html.HiddenFor(Function(model) model.GDRG_DosageClass)
        @Html.HiddenFor(Function(model) model.GDRG_DoseTimes)
        @Html.HiddenFor(Function(model) model.GDRG_DoseDays)
        @Html.HiddenFor(Function(model) model.GDRG_IntervalDays)
        @Html.HiddenFor(Function(model) model.GDRG_Dosage)
        @Html.HiddenFor(Function(model) model.GDRG_OnceMaxDosage)
        @Html.HiddenFor(Function(model) model.GDRG_DailyMaxDosage)
        @Html.HiddenFor(Function(model) model.GDRG_OrderInjectionFlag)
        @Html.HiddenFor(Function(model) model.GDRG_OrderTransfusionFlag)
        @Html.HiddenFor(Function(model) model.GDRG_NerveDestroyFlag)
        @Html.HiddenFor(Function(model) model.GDRG_BiologyFlag)
        @Html.HiddenFor(Function(model) model.GDRG_GenericFlag)
        @Html.HiddenFor(Function(model) model.GDRG_DentistrySpecialtyFlag)
        @Html.HiddenFor(Function(model) model.GDRG_ContrastMediumFlag)
        @Html.HiddenFor(Function(model) model.GDRG_GrindFlag)
        @Html.HiddenFor(Function(model) model.GDRG_MixFlag)
        @Html.HiddenFor(Function(model) model.GDRG_DissolveFlag)
        @Html.HiddenFor(Function(model) model.GDRG_PTPFlag)
        @Html.HiddenFor(Function(model) model.GDRG_OneDosePackagFlag)
        @Html.HiddenFor(Function(model) model.GDRG_HospitalPreparationFlag)
        @Html.HiddenFor(Function(model) model.GDRG_INDFlag)
        @Html.HiddenFor(Function(model) model.GDRG_ExtraDrugFlag)
        @Html.HiddenFor(Function(model) model.GDRG_AnticancerDrugFlag)
        @Html.HiddenFor(Function(model) model.GDRG_SubstituteHotCode1)
        @Html.HiddenFor(Function(model) model.GDRG_SubstituteHotCode2)
        @Html.HiddenFor(Function(model) model.GDRG_PatientLimitedFlag)
         @Html.HiddenFor(Function(model) model.GDRG_Remarks)
         @Html.HiddenFor(Function(model) model.GDRG_DiabetesFlag)
         @Html.HiddenFor(Function(model) model.GDRG_LabelPrintFlag)
         @Html.HiddenFor(Function(model) model.GDRG_OrderMedicineFlag)

        <div class="form-group">
            <!--有効開始日時-->
            @Html.LabelFor(Function(Model) Model.GDRG_ValidDateFrom, htmlAttributes:=New With {.class = "control-label col-md-2"})
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
            @Html.LabelFor(Function(Model) Model.GDRG_HotCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @If ViewBag.Insert = True Then
                    @HtmlHelperEditor.ReadOnlyEditor("<自動採番>", "GDRG_HotCode", "")
                Else
                    @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_HotCode, "GDRG_HotCode", "")
                End If
                @Html.ValidationMessageFor(Function(model) model.GDRG_HotCode, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <!--有効終了日時 -->
            @Html.LabelFor(Function(Model) Model.GDRG_ValidDateTo, htmlAttributes:=New With {.class = "control-label col-md-2"})
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
            <!--医事連携コード（医薬品コード）-->
            @*@Html.LabelFor(Function(Model) Model.GDRG_ReceiptCode, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
            <label class="control-label col-md-2">医事連携コード</label>
            <div class="col-md-2">
                @Html.EditorFor(Function(model) model.GDRG_ReceiptCode, New With {.htmlAttributes = New With {.class = "form-control ime-inactive", .maxlength = "9"}})
                @Html.ValidationMessageFor(Function(model) model.GDRG_ReceiptCode, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(Model) Model.GDRG_DrugName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-4">
                @Html.EditorFor(Function(model) model.GDRG_DrugName, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
                @Html.ValidationMessageFor(Function(model) model.GDRG_DrugName, "", New With {.class = "text-danger"})
            </div>
            <!--基準番号（HOT番号）-->
            @Html.LabelFor(Function(model) model.GDRG_StandardCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_StandardCode, "GDRG_StandardCode", "")
            </div>
        </div>

        <div class="form-group">
            <!--カナ名称-->
            @Html.LabelFor(Function(Model) Model.GDRG_DrugKana, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-4">
                @Html.EditorFor(Function(model) model.GDRG_DrugKana, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
                @Html.ValidationMessageFor(Function(model) model.GDRG_DrugKana, "", New With {.class = "text-danger"})
            </div>
            <!--基準番号（HOT番号）-->
            @Html.LabelFor(Function(model) model.GDRG_MHLWCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_MHLWCode, "GDRG_MHLWCode", "")
            </div>
        </div>

        <div class="form-group">
            <!--表示用輸血製剤名-->
            @Html.LabelFor(Function(Model) Model.GDRG_DisplayDrugName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-4">
                @Html.EditorFor(Function(model) model.GDRG_DisplayDrugName, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
                @Html.ValidationMessageFor(Function(model) model.GDRG_DisplayDrugName, "", New With {.class = "text-danger"})
            </div>
            <!--一般名コード-->
            @Html.LabelFor(Function(model) model.GDRG_PublicCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_PublicCode, "GDRG_PublicCode", "")
            </div>
        </div>

        <div class="form-group">
            <!--オーダ初期表示単位-->
            @Html.LabelFor(Function(Model) Model.GDRG_UnitInit, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @If ViewBag.Insert = True Then
                    @HtmlHelperEditor.DropDownEditorUnit(Model.GDRG_UnitInit.ToString.PadLeft(4, "0"), "GDRG_UnitInit", Model.UnitName)
                Else
                    @HtmlHelperEditor.DropDownEditor(Model.GDRG_UnitInit.ToString.PadLeft(4, "0"), "GDRG_UnitInit", Model.Unit, Model.UnitName)
                End If
                @Html.ValidationMessageFor(Function(model) model.GDRG_UnitInit, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-2">
                @If Not ViewBag.Insert = True Then
                    @If DirectCast(ViewBag.Auth, AuthorityInfo).AuthUpdate And Model.Authority Then
                        @Html.ActionLink("単位メンテナンス", "Index", "M_DrugUnit", New With {.id = Model.GDRG_HotCode, .name = Model.GDRG_DrugName, .logno = Model.GDRG_LogNo}, New With {.class = "btn btn-info"})
                    Else
                        @Html.ActionLink("単位メンテナンス", "Index", "M_DrugUnit", New With {.id = Model.GDRG_HotCode, .name = Model.GDRG_DrugName, .logno = Model.GDRG_LogNo}, New With {.class = "btn btn-info", .target = "_blank", .disabled = ""})
                    End If
                End If
            </div>
            <!--販売名-->
            @Html.LabelFor(Function(model) model.GDRG_SalesName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-4">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_SalesName, "GDRG_SalesName", "")
            </div>
        </div>

        <div class="form-group">
            <!--医事算定単位-->
            @Html.LabelFor(Function(Model) Model.GDRG_UnitReceipt, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-2">
                @If ViewBag.Insert = True Then
                    @HtmlHelperEditor.DropDownEditorUnit(Model.GDRG_UnitReceipt.ToString.PadLeft(4, "0"), "GDRG_UnitReceipt", Model.UnitName, True)
                    @<text>登録後、修正画面で変更できます。</text>
                Else
                    @HtmlHelperEditor.DropDownEditor(Model.GDRG_UnitReceipt.ToString.PadLeft(4, "0"), "GDRG_UnitReceipt", Model.Unit, Model.UnitName)
                End If
                @Html.ValidationMessageFor(Function(model) model.GDRG_UnitReceipt, "", New With {.class = "text-danger"})
            </div>
            <div class="col-md-2"></div>
            <!--成分名-->
            @Html.LabelFor(Function(model) model.GDRG_ComponentName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-4">
                @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_ComponentName, "GDRG_ComponentName", "")
            </div>
        </div>

         <div class="form-group">
             <!--調剤送信単位-->
             @Html.LabelFor(Function(model) model.GDRG_UnitPharm, htmlAttributes:=New With {.class = "control-label col-md-2"})
             <div class="col-md-2">
                 @If ViewBag.Insert = True Then
                     @HtmlHelperEditor.DropDownEditorUnit(Model.GDRG_UnitPharm.ToString.PadLeft(4, "0"), "GDRG_UnitPharm", Model.UnitName, True)
                     @<text>登録後、修正画面で変更できます。</text>
                 Else
                     @HtmlHelperEditor.DropDownEditor(Model.GDRG_UnitPharm.ToString.PadLeft(4, "0"), "GDRG_UnitPharm", Model.Unit, Model.UnitName)
                 End If
                 @Html.ValidationMessageFor(Function(model) model.GDRG_UnitReceipt, "", New With {.class = "text-danger"})
             </div>
             <div class="col-md-2"></div>
             <!--剤形区分-->
             @Html.LabelFor(Function(Model) Model.GDRG_DosageFormClass, htmlAttributes:=New With {.class = "control-label col-md-2"})
             <div class="col-md-2">
                 @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_DosageFormClass, "GDRG_DosageFormClass", Model.OptionList_DosageFormClass)
             </div>
         </div>

         <div class="form-group">
             <!--採用区分-->
             @Html.LabelFor(Function(Model) Model.GDRG_AdoptClass, htmlAttributes:=New With {.class = "control-label col-md-2"})
             <div class="col-md-4">
                 @HtmlHelperEditor.FlagRadioButtonEditor(Model.GDRG_AdoptClass, "GDRG_AdoptClass", Model.OptionList_AdoptClass)
                 @Html.ValidationMessageFor(Function(model) model.GDRG_AdoptClass, "", New With {.class = "text-danger"})
             </div>
             <!--容量-->
             @Html.LabelFor(Function(model) model.GDRG_Syringeful, htmlAttributes:=New With {.class = "control-label col-md-2"})
             <div class="col-md-2">
                 @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_Syringeful, "GDRG_Syringeful", "")
             </div>
         </div>

         <div class="form-group">
             <!--輸血英字略称-->
             @Html.LabelFor(Function(Model) Model.GDRG_SearchKeyword, htmlAttributes:=New With {.class = "control-label col-md-2"})
             <div class="col-md-4">
                 @Html.EditorFor(Function(model) model.GDRG_SearchKeyword, New With {.htmlAttributes = New With {.class = "form-control ime-inactive"}})
                 @Html.ValidationMessageFor(Function(model) model.GDRG_SearchKeyword, "", New With {.class = "text-danger"})
             </div>
         </div>

        @If ViewBag.Insert <> True AndAlso ViewBag.Copy <> True Then
            @<div class="form-group">
                <div class="col-md-6"></div>
                @Html.LabelFor(Function(Model) Model.GDRG_UpdateDate, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-3">
                    @Html.TextBox("GDRG_UpdateDate", String.Format("{0:yyyy-MM-dd HH:mm:ss}", Model.GDRG_UpdateDate), New With {.class = "form-control text-box single-line", .ReadOnly = "true", .disabled = "disabled"})
                </div>
            </div>

            @<div class="form-group">
                 <div class="col-md-6"></div>
                @Html.LabelFor(Function(Model) Model.GDRG_UpdateClientName, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-3">
                    @HtmlHelperEditor.ReadOnlyEditor(Model.GDRG_UpdateClientName, "GDRG_UpdateClientName", "")
                </div>
            </div>

            @<div class="form-group">
                 <div class="col-md-6"></div>
                @Html.LabelFor(Function(Model) Model.GDRG_UpdateStaffID, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-3">
                    @HtmlHelperEditor.ReadOnlyEditor(Model.UpdateStaffName, "GDRG_UpdateStaffID", "")
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
    @Html.ActionLink("グループ統一 " & ViewBag.MasterTypeTitle.ToString & "へ戻る", "Index", "GM_Drug")
Else
    @Html.ActionLink("検索結果一覧へ戻る", "Index", "GM_Drug", New With {.retry = "OK"}, New With {.class = "load-start"})
End If
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
    @Scripts.Render("~/Scripts/MDrugBloodEdit.js")
End Section
