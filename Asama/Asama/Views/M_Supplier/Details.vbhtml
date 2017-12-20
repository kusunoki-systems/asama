@ModelType Asama.M_Supplier
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>M_Supplier</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.SupplierName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SupplierName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SupplierContact)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SupplierContact)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.InsertedBy)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.InsertedBy)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.InsertedAt)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.InsertedAt)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UpdatedBy)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UpdatedBy)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UpdatedAt)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UpdatedAt)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.SupplierCd }) |
    @Html.ActionLink("Back to List", "Index")
</p>
