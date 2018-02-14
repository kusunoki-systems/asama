@ModelType Asama.M_SizeType
@Code
    ViewData("Title") = "変更"
End Code
@imports Asama.helpers

<h2>変更</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>サイズ種類</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })

         <div class="form-group">
             @Html.LabelFor(Function(model) model.SizeTypeCd, htmlAttributes:=New With {.class = "control-label col-md-2"})
             <div class="col-md-10">
                 @HtmlHelperEditor.ReadOnlyEditor(Model.SizeTypeCd, "SizeTypeCd", "")
             </div>
         </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.SizeTypeName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.SizeTypeName, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.SizeTypeName, "", New With {.class = "text-danger"})
            </div>
        </div>

         <div class="form-group">
             @Html.LabelFor(Function(model) model.SortNo, "SortNo", htmlAttributes:=New With {.class = "control-label col-md-2"})
             <div class="col-md-10">
                 @Html.EditorFor(Function(model) model.SortNo, New With {.htmlAttributes = New With {.class = "form-control"}})
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
