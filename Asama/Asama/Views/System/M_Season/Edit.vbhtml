@ModelType Asama.M_Season
@Code
    ViewData("Title") = "変更"
End Code
@imports Asama.Helpers
<h2>変更</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>シーズンマスタ</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })

         <div class="form-group">
             @Html.LabelFor(Function(model) model.SeasonCd, htmlAttributes:=New With {.class = "control-label col-md-2"})
             <div class="col-md-10">
                 @HtmlHelperEditor.ReadOnlyEditor(Model.SeasonCd, "SeasonCd", "")
             </div>
         </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.SeasonName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.SeasonName, New With {.htmlAttributes = New With {.class = "form-control ime-active"}})
                @Html.ValidationMessageFor(Function(model) model.SeasonName, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.InsertedBy, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @HtmlHelperEditor.ReadOnlyEditor(Model.InsertedBy, "InsertedBy", "")
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.InsertedAt, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @HtmlHelperEditor.ReadOnlyEditor(Model.InsertedAt, "InsertedBy", "")
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.UpdatedBy, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @HtmlHelperEditor.ReadOnlyEditor(Model.UpdatedBy, "UpdatedBy", "")
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.UpdatedAt, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @HtmlHelperEditor.ReadOnlyEditor(Model.UpdatedAt, "UpdatedAt", "")
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.SortNo, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @HtmlHelperEditor.ReadOnlyEditor(Model.SortNo, "SortNo", "")
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-primary" />
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
