@ModelType kusunoki.M_DrugEX

@Code
    ViewData("Title") = "病院限定 " & ViewBag.MasterTypeTitle
    Html.EnableClientValidation(False)
End Code
@imports kusunoki.Helpers

<span>@Html.ActionLink("TOP", "Index", "Home", Nothing, New With {.class = ""}) > 病院限定 @ViewBag.MasterTypeTitle</span>

<h2>病院限定 @ViewBag.MasterTypeTitle</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <hr />
        <h3 class="">標準マスタより新規作成</h3>
        <div class="form-group" id="CM_Drug_Index">
            <label class="control-label col-md-2" for="">HOT9コード</label>
            <div class="col-md-3">
                @Html.EditorFor(Function(model) model.CDRG_HotCode, New With {.htmlAttributes = New With {.class = "form-control ime-inactive", .maxlength = "9"}})
            </div>
        </div>
        <div class="form-group">
            <label class="control-label col-md-2" for="">名称</label>
            <div class="col-md-3">
                @Html.EditorFor(Function(model) model.CDRG_DrugName, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
            </div>
            @If Not ViewBag.MasterType = "1" Then
                @<div class="col-md-1">
                    <Button type="submit" name="SubmitButton" value="CMDrug" id="SubmitCMDrug" Class="btn btn-primary btn-block load-start" >検索</Button>
                </div>
            End If
        </div>
            @If ViewBag.MasterType = "1" Then
             @<div Class="form-group check-group">
                 <div Class="col-md-1 col-md-offset-2">
                    @HtmlHelperEditor.CheckBoxEditor(True, "CM_DosageFormClass1", Model.OptionList_DosageFormClass, 1)
                 </div>
                 <div Class="col-md-1">
                    @HtmlHelperEditor.CheckBoxEditor(True, "CM_DosageFormClass6", Model.OptionList_DosageFormClass, 6)
                 </div>
                 <div Class="col-md-1">
                    @HtmlHelperEditor.CheckBoxEditor(True, "CM_DosageFormClass4", Model.OptionList_DosageFormClass, 4)
                 </div>
                 <div Class="col-md-1">
                     <Button type="submit" name="SubmitButton" value="CMDrug" id="SubmitCMDrug" Class="btn btn-primary btn-block load-start" >検索</Button>
                 </div>
            </div>
            End If
        <hr />
        <h3 class="">グループ統一薬マスタより新規作成</h3>
        <div class="form-group" id="GM_Drug_Index">
            <label class="control-label col-md-2" for="">HOT9コード</label>
            <div class="col-md-3">
                @Html.EditorFor(Function(model) model.GDRG_HotCode, New With {.htmlAttributes = New With {.class = "form-control ime-inactive", .maxlength = "9"}})
            </div>
        </div>
        <div class="form-group">
            <label class="control-label col-md-2" for="">名称</label>
            <div class="col-md-3">
                @Html.EditorFor(Function(model) model.GDRG_DrugName, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
            </div>
            @If Not ViewBag.MasterType = "1" Then
                @<div class="col-md-1">
                    <Button type="submit" name="SubmitButton" value="GMDrug" id="SubmitGMDrug" Class="btn btn-primary btn-block load-start" >検索</Button>
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
                    <Button  type="submit" name="SubmitButton" value="GMDrug" id="SubmitGMDrug" Class="btn btn-primary btn-block load-start" >検索</Button>
                </div>
            </div>
        End If

        <hr />
        <h3 class="">病院限定 @ViewBag.MasterTypeTitle 検索</h3>
        <div class="form-group" id="M_Drug_Index">
            <label class="control-label col-md-2" for="">HOT9コード</label>
            <div class="col-md-3">
                @Html.EditorFor(Function(model) model.MDRG_HotCode, New With {.htmlAttributes = New With {.class = "form-control ime-inactive", .maxlength = "9"}})
            </div>
        </div>
        <div class="form-group">
            <label class="control-label col-md-2" for="">名称</label>
            <div class="col-md-3">
                @Html.EditorFor(Function(model) model.MDRG_DrugName, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
                @*@Html.ValidationMessageFor(Function(model) model.MDRG_DrugName, "", New With {.class = "text-danger"})*@
            </div>
            @If Not ViewBag.MasterType = "1" Then
                @<div class="col-md-1">
                    <Button  type="submit" name="SubmitButton" value="MDrug" id="SubmitMDrug" Class="btn btn-primary btn-block load-start">検索</Button>
                </div>
                @If ViewBag.MasterType = "2" Then
                    @<div class="col-md-1">
                        <Button type="submit" name="SubmitButton" value="MDrugCreate" id="SubmitMDrug" Class="btn btn-primary btn-block">新規作成</Button>
                    </div>
                End If
            End If
        </div>
        @If ViewBag.MasterType = "1" Then
            @<div class="form-group check-group">
                <div class="col-md-1 col-md-offset-2">
                    @HtmlHelperEditor.CheckBoxEditor(True, "M_DosageFormClass1", Model.OptionList_DosageFormClass, 1)
                </div>
                <div class="col-md-1">
                    @HtmlHelperEditor.CheckBoxEditor(True, "M_DosageFormClass6", Model.OptionList_DosageFormClass, 6)
                </div>
                <div class="col-md-1">
                    @HtmlHelperEditor.CheckBoxEditor(True, "M_DosageFormClass4", Model.OptionList_DosageFormClass, 4)
                </div>
                <div class="col-md-1">
                    <Button type="submit" name="SubmitButton" value="MDrug" id="SubmitMDrug" Class="btn btn-primary btn-block load-start">検索</Button>
                </div>
            </div>
        End If
        <hr />
         @*<input type="text" name="name" list="options" />
    <datalist id="options">
        <option value="東京都"></option>
        <option value="神奈川県"></option>
        <option value="千葉県"></option>
    </datalist>　*@
    </div>
End Using

<div>
    <a href="javascript:history.back()">戻る</a>
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
