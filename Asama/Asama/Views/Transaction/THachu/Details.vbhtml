@ModelType Asama.T_HachuHeader
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>T_HachuHeader</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.SupplierCd)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SupplierCd)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.HachuDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.HachuDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.HachuAmount)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.HachuAmount)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.OrderNo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.OrderNo)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.HachuNo }) |
    @Html.ActionLink("Back to List", "Index")
</p>
