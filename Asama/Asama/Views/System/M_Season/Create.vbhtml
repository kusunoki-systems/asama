﻿@ModelType Asama.M_Season
@Code
    ViewData("Title") = "Create"
End Code

<h2>新規作成</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>シーズンマスタ</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        <div class="form-group">
            @Html.LabelFor(Function(model) model.SeasonCd, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.SeasonCd, New With {.htmlAttributes = New With {.class = "form-control ime-inactive"}})
                @Html.ValidationMessageFor(Function(model) model.SeasonCd, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.SeasonName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.SeasonName, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
                @Html.ValidationMessageFor(Function(model) model.SeasonName, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.SortNo, htmlAttributes:=New With {.class = "control-label col-md-2"})
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
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
