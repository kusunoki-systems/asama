@ModelType kusunoki.M_StaffBase
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @*@Html.ActionLink("Edit", "Edit", New With {.id = Model.PrimaryKey}) |*@
    @Html.ActionLink("Back to List", "Index")
</p>
