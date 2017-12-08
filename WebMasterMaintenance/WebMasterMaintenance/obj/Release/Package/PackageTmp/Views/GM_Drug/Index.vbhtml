@ModelType WebMasterMaintenance.GM_DrugEX
@Code
    ViewData("Title") = "グループ統一 " & ViewBag.MasterTypeTitle
    Html.EnableClientValidation(False)
End Code
@imports WebMasterMaintenance.Helpers

<span>@Html.ActionLink("TOP", "Index", "Home", Nothing, New With {.class = ""}) > グループ統一 @ViewBag.MasterTypeTitle</span>

<h2>グループ統一 @ViewBag.MasterTypeTitle</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <input type="hidden" value="GM_Drug" name="PageType" id="PageType" />
        <hr />
        <h3 class="">標準マスタより新規作成</h3>
        <div class="form-group" id="CM_Drug_Index">
            <label class="control-label col-md-2" for="">HOT9コード</label>
            <div class="col-md-3">
                @Html.EditorFor(Function(model) model.CDRG_HotCode, New With {.htmlAttributes = New With {.class = "form-control"}})
            </div>
        </div>
        <div class="form-group">
            <label class="control-label col-md-2" for="">名称</label>
            <div class="col-md-3">
                @Html.EditorFor(Function(model) model.CDRG_DrugName, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
            </div>
            @If Not ViewBag.MasterType = "1" Then
                @<div class="col-md-1">
                    <button type="submit" name="SubmitButton" value="CMDrug" id="SubmitCMDrug" class="btn btn-primary btn-block">検索</button>
                </div>
            End If
        </div>
        @If ViewBag.MasterType = "1" Then
            @<div class="form-group check-group">
                <div class="col-md-1 col-md-offset-2">
                    @HtmlHelperEditor.CheckBoxEditor(True, "CM_DosageFormClass1", Model.OptionList_DosageFormClass, 1)
                </div>
                <div class="col-md-1">
                    @HtmlHelperEditor.CheckBoxEditor(True, "CM_DosageFormClass6", Model.OptionList_DosageFormClass, 6)
                </div>
                <div class="col-md-1">
                    @HtmlHelperEditor.CheckBoxEditor(True, "CM_DosageFormClass4", Model.OptionList_DosageFormClass, 4)
                </div>
                <div class="col-md-1">
                    <button type="submit" name="SubmitButton" value="CMDrug" id="SubmitCMDrug" class="btn btn-primary btn-block">検索</button>
                </div>
            </div>
        End If
        <hr />
        <h3 class="">グループ統一薬マスタ検索</h3>
        <div class="form-group" id="GM_Drug_Index">
            <label class="control-label col-md-2" for="">HOT9コード</label>
            <div class="col-md-3">
                @Html.EditorFor(Function(model) model.GDRG_HotCode, New With {.htmlAttributes = New With {.class = "form-control"}})
            </div>
        </div>
        <div class="form-group">
            <label class="control-label col-md-2" for="">名称</label>
            <div class="col-md-3">
                @Html.EditorFor(Function(model) model.GDRG_DrugName, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
            </div>
            @If Not ViewBag.MasterType = "1" Then
                @<div class="col-md-1">
                    <button type="submit" name="SubmitButton" value="GMDrug" id="SubmitGMDrug" class="btn btn-primary btn-block">検索</button>
                </div>
            End If
        </div>
        @If ViewBag.MasterType = "1" Then
            @<div class="form-group check-group">
                <div class="col-md-1 col-md-offset-2">
                    @HtmlHelperEditor.CheckBoxEditor(True, "GM_DosageFormClass1", Model.OptionList_DosageFormClass, 1)
                </div>
                <div class="col-md-1">
                    @HtmlHelperEditor.CheckBoxEditor(True, "GM_DosageFormClass6", Model.OptionList_DosageFormClass, 6)
                </div>
                <div class="col-md-1">
                    @HtmlHelperEditor.CheckBoxEditor(True, "GM_DosageFormClass4", Model.OptionList_DosageFormClass, 4)
                </div>
                <div class="col-md-1">
                    <button type="submit" name="SubmitButton" id="SubmitGMDrug" value="GMDrug" class="btn btn-primary btn-block load-start">検索</button>
                </div>
            </div>
        End If
    </div>
End Using

<div>
    @Html.ActionLink("Back to Top", "Index", "Home")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
