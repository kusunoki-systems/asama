@ModelType Asama.T_JuchuHeader
@Code
    ViewData("Title") = "Create"
End Code
@imports Asama.Helpers

<h2>Create</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>T_JuchuHeader</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        <div class="form-group">
            @Html.LabelFor(Function(model) model.JuchuNo, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.JuchuNo, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.JuchuNo, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CustomerCd, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("CustomerCd", Nothing, htmlAttributes:=New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.CustomerCd, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.JuchuDate, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @*HtmlHelperEditor.DateEditor(Model.JuchuDate, "JuchuDate")*@
                @Html.EditorFor(Function(model) model.JuchuDate, New With {.htmlAttributes = New With {.class = "form-control datepicker"}})
                @*Html.DatePickerFor(Function(model) model.JuchuDate, "autoclose=true", "todayBtn=true", "todayHighlight=true")*@
                @Html.ValidationMessageFor(Function(model) model.JuchuDate, "", New With {.Class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-primary" />
            </div>
        </div>
    </div>
End Using

                        <div>
    @Html.ActionLink("一覧へ戻る", "Index")
</div>
