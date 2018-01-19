@ModelType Asama.M_Size
@Code
    ViewData("Title") = "Edit"
End Code
@imports Asama.Helpers

<h2>変更</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>サイズマスタ</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
         @Html.HiddenFor(Function(model) model.InsertedAt)
         @Html.HiddenFor(Function(model) model.InsertedBy)

         <div class="form-group">
             @Html.LabelFor(Function(model) model.SizeCd, htmlAttributes:=New With {.class = "control-label col-md-2"})
             <div class="col-md-10">
                 @HtmlHelperEditor.ReadOnlyEditor(Model.SizeCd, "SizeCd", "")
             </div>
         </div>
    
        <div class="form-group">
            @Html.LabelFor(Function(model) model.SizeName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.SizeName, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.SizeName, "", New With { .class = "text-danger" })
            </div>
        </div>

         <div class="form-group">
             @Html.LabelFor(Function(model) model.SizeTypeCd, "SizeTypeCd", htmlAttributes:=New With {.class = "control-label col-md-2"})
             <div class="col-md-10">
                 @Html.DropDownList("SizeTypeCd", Nothing, htmlAttributes:=New With {.class = "form-control"})
                 @Html.ValidationMessageFor(Function(model) model.SizeTypeCd, "", New With {.class = "text-danger"})
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
            @Html.LabelFor(Function(model) model.InsertedBy, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DisplayFor(Function(model) model.InsertedBy, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.InsertedBy, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.InsertedAt, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DisplayFor(Function(model) model.InsertedAt, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.InsertedAt, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.UpdatedBy, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DisplayFor(Function(model) model.UpdatedBy, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.UpdatedBy, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.UpdatedAt, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DisplayFor(Function(model) model.UpdatedAt, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.UpdatedAt, "", New With { .class = "text-danger" })
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
