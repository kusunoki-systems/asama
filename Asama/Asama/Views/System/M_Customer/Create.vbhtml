﻿@ModelType Asama.M_Customer
@Code
    ViewData("Title") = "新規作成"
End Code

<h2>新規作成</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>顧客マスタ</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        <div class="form-group">
            @Html.LabelFor(Function(model) model.CustomerCd, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.CustomerCd, New With {.htmlAttributes = New With {.class = "form-control ime-inactive"}})
                @Html.ValidationMessageFor(Function(model) model.CustomerCd, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CustomerName, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.CustomerName, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
                @Html.ValidationMessageFor(Function(model) model.CustomerName, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CustomerContact, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.CustomerContact, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
                @Html.ValidationMessageFor(Function(model) model.CustomerContact, "", New With {.class = "text-danger"})
            </div>
        </div>

         <div class="form-group">
             @Html.LabelFor(Function(model) model.InitialRatio, htmlAttributes:=New With {.class = "control-label col-md-2"})
             <div class="col-md-10">
                 @Html.EditorFor(Function(model) model.InitialRatio, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
                 @Html.ValidationMessageFor(Function(model) model.InitialRatio, "", New With {.class = "text-danger"})
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
    @Html.ActionLink("一覧へ戻る", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
