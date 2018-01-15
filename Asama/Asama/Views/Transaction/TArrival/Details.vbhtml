@ModelType Asama.T_ArrivalHeader
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>T_ArrivalHeader</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.SupplierCd)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SupplierCd)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ArrivalDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ArrivalDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ArrivalAmount)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ArrivalAmount)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ArrivalNo }) |
    @Html.ActionLink("Back to List", "Index")
</p>
