@ModelType Asama.M_Item
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>M_Item</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.ItemName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ItemName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Season)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Season)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.MakerCd)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MakerCd)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.RetailPrice)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.RetailPrice)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CostPrice)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CostPrice)
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

        <dt>
            @Html.DisplayNameFor(Function(model) model.M_ColorType.ColorTypeName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.M_ColorType.ColorTypeName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.M_SizeType.SizeTypeName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.M_SizeType.SizeTypeName)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ItemCd }) |
    @Html.ActionLink("Back to List", "Index")
</p>
