@ModelType WebMasterMaintenance.M_DrugUnitEX
@Code
    ViewData("Title") = "Create"
End Code
@imports WebMasterMaintenance.Helpers

<span>
    @Html.ActionLink("TOP", "Index", "", Nothing, "")
    > @Html.ActionLink("病院限定" & ViewBag.MasterTypeTitle.ToString, "Index", "M_Drug", Nothing, "")
    > @Html.ActionLink(ViewBag.HotCode & " " & ViewBag.DrugName, "Edit", "M_Drug", New With {.id = ViewBag.FacilityID & "," & ViewBag.HotCode & "," & ViewBag.LogNo}, New With {.class = "load-start"})
    > @ViewBag.HotCode @ViewBag.DrugName 単位新規追加
</span>

<h2>@ViewBag.MasterTypeTitle 追加</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>M_DrugUnit</h4>
        <hr />
        <h3>
            @If ViewBag.MasterType = "1" Then
                @Html.ActionLink(Model.MDUT_HotCode & " " & Model.DrugName, "Edit", "M_Drug", New With {.id = Model.MDUT_FacilityID & "," & Model.MDUT_HotCode & "," & ViewBag.LogNo}, New With {.class = "load-start"})
            Else
                @Html.ActionLink(Model.MDUT_HotCode & " " & Model.DrugName, "EditMaterial", "M_Drug", New With {.id = Model.MDUT_FacilityID & "," & Model.MDUT_HotCode & "," & ViewBag.LogNo}, New With {.class = "load-start"})
            End If
        </h3>
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        @Html.HiddenFor(Function(model) model.MDUT_FacilityID)
        @Html.HiddenFor(Function(model) model.MDUT_StatusClass)
        @Html.HiddenFor(Function(model) model.MDUT_HotCode)
        @Html.HiddenFor(Function(model) model.MDUT_UnitNo)
        @Html.HiddenFor(Function(model) model.DrugName)

        <div class="form-group">
            @Html.Label("基準単位", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                <input type="text" class="form-control" value="@ViewBag.BaseUnit" disabled />
            </div>
        </div>

        <div class="form-group">
            @Html.Label("単位", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @HtmlHelperEditor.DropDownEditorUnit(Model.MDUT_UnitCode, "MDUT_UnitCode", Model.Unit)
                @Html.ValidationMessageFor(Function(model) model.MDUT_UnitCode, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.Label(M_DrugUnit_Columns.COLUMN_NAME_MDUT_UnitRatio, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.MDUT_UnitRatio, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.MDUT_UnitRatio, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <label class="control-label col-md-2">乗除</label>
            <div class="col-md-1">
                @code
                    Dim dic As New Dictionary(Of String, String)
                    dic.Add("1", "×")
                    dic.Add("2", "÷")
                End Code
                @HtmlHelperEditor.FlagRadioButtonEditor(New String("1"), "MDUT_CalculateFlag", dic)
            </div>
        </div>

        <div class="form-group">
            @Html.Label(M_DrugUnit_Columns.COLUMN_NAME_MDUT_UpdateDate, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDUT_UpdateDate, "MDUT_UpdateDate", "yyyy-MM-dd")
                @Html.ValidationMessageFor(Function(model) model.MDUT_UpdateDate, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.Label(M_DrugUnit_Columns.COLUMN_NAME_MDUT_UpdateClientName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @HtmlHelperEditor.ReadOnlyEditor(Model.MDUT_UpdateClientName, "MDUT_UpdateClientName", "yyyy-MM-dd")
                @Html.ValidationMessageFor(Function(model) model.MDUT_UpdateClientName, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.Label(M_DrugUnit_Columns.COLUMN_NAME_MDUT_UpdateStaffID, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @HtmlHelperEditor.ReadOnlyEditor(Model.UpdateStaffName, "MDUT_UpdateStaffID", "yyyy-MM-dd")
                @Html.ValidationMessageFor(Function(model) model.MDUT_UpdateStaffID, "", New With {.class = "text-danger"})
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
    @Html.ActionLink(Model.MDUT_HotCode & " " & Model.DrugName & " 単位一覧へ戻る", "Index", "M_DrugUnit", New With {.id = Model.MDUT_HotCode, .name = Model.DrugName, .logno = ViewBag.LogNo}, New With {.class = "load-start"})
</div>
@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section