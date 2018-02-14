﻿@ModelType Asama.M_Color
@Code
    ViewData("Title") = "変更"
End Code
@imports Asama.Helpers

<h2>変更</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>色マスタ</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
         @*Html.HiddenFor(Function(model) model.ColorCd)*@
         @Html.HiddenFor(Function(model) model.InsertedAt)
         @Html.HiddenFor(Function(model) model.InsertedBy)

         <div class="form-group">
             @Html.LabelFor(Function(model) model.ColorCd, htmlAttributes:=New With {.class = "control-label col-md-2"})
             <div class="col-md-10">
                 @HtmlHelperEditor.ReadOnlyEditor(Model.ColorCd, "ColorCd", "")
             </div>
         </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ColorName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ColorName, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
                @Html.ValidationMessageFor(Function(model) model.ColorName, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ColorTypeCd, "ColorTypeCd", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.DropDownList("ColorTypeCd", Nothing, htmlAttributes:=New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.ColorTypeCd, "", New With {.class = "text-danger"})
            </div>
        </div>

         <div class="form-group">
             @Html.LabelFor(Function(model) model.SortNo, "SortNo", htmlAttributes:=New With {.class = "control-label col-md-2"})
             <div class="col-md-10">
                 @Html.EditorFor(Function(model) model.SortNo, New With {.htmlAttributes = New With {.class = "form-control ime-inactive"}})
                 @Html.ValidationMessageFor(Function(model) model.SortNo, "", New With {.class = "text-danger"})
             </div>
         </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="登録" class="btn btn-primary" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("一覧へ戻る", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
