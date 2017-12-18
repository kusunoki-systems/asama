@ModelType Asama.M_Color
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>M_Color</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.ColorName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ColorName)
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

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ColorCd }) |
    @Html.ActionLink("Back to List", "Index")
</p>
