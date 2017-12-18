@ModelType Asama.M_SizeType
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>M_SizeType</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.SizeTypeName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SizeTypeName)
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
            @Html.DisplayNameFor(Function(model) model.UpdateAt)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UpdateAt)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.SizeTypeCd }) |
    @Html.ActionLink("Back to List", "Index")
</p>
