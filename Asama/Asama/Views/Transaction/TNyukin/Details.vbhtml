@ModelType Asama.T_Nyukin
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>T_Nyukin</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.CustomerCd)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerCd)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Amount)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Amount)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NyukinDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NyukinDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NyukinMethod)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NyukinMethod)
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
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.NyukinNo }) |
    @Html.ActionLink("一覧へ戻る", "Index")
</p>
