@ModelType kusunoki.M_StaffBase
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>M_StaffBase</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.MSTB_BirthDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MSTB_BirthDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.MSTB_EnterDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MSTB_EnterDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.MSTB_RetireDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MSTB_RetireDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.MSTB_Remarks)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MSTB_Remarks)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
