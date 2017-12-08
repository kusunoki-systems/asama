@Modeltype UserModel
@imports WebMasterMaintenance.Helpers
<h2></h2>
@Using (Html.BeginForm("Login", "User"))
    @<div class="form-horizontal">
        <h4>Aloeログイン</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

        <div class="form-group">
            @Html.LabelFor(Function(model) model.FacilityID, New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @HtmlHelperEditor.DropDownEditor(Model.FacilityID, "FacilityID", Model.FacilityModels)
                @Html.ValidationMessageFor(Function(model) model.Id, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Id, New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Id, New With {.htmlAttributes = New With {.class = "form-control", .style = "", .PlaceHolder = "ログインIDを入力してください"}})
                @Html.ValidationMessageFor(Function(model) model.Id, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Password, New With {.class = "control-label col-md-2"})
            <div class="col-md-9">
                @Html.PasswordFor(Function(model) model.Password, New With {.class = "form-control", .style = "", .PlaceHolder = "パスワードを入力してください"})
                @Html.ValidationMessageFor(Function(model) model.Id, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="ログイン" class="btn btn-primary" />
            </div>
        </div>
    </div>


End Using
