@ModelType kusunoki.M_StaffBase
@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>M_StaffBase</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        @Html.HiddenFor(Function(model) model.MSTB_StaffID)

        @Html.HiddenFor(Function(model) model.MSTB_LogNo)

        @Html.HiddenFor(Function(model) model.MSTB_UpdateDate)

        @Html.HiddenFor(Function(model) model.MSTB_UpdateClientName)

        @Html.HiddenFor(Function(model) model.MSTB_UpdateStaffID)

        @Html.HiddenFor(Function(model) model.MSTB_DelFlag)

        @Html.HiddenFor(Function(model) model.MSTB_NameKana)

        @Html.HiddenFor(Function(model) model.MSTB_Name)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.MSTB_BirthDate, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.MSTB_BirthDate, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.MSTB_BirthDate, "", New With { .class = "text-danger" })
            </div>
        </div>

        @Html.HiddenFor(Function(model) model.MSTB_SexType)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.MSTB_EnterDate, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.MSTB_EnterDate, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.MSTB_EnterDate, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.MSTB_RetireDate, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.MSTB_RetireDate, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.MSTB_RetireDate, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.MSTB_Remarks, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.MSTB_Remarks, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.MSTB_Remarks, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-default" />
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
