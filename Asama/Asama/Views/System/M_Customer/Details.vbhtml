@ModelType Asama.M_Customer
@Code
    ViewData("Title") = "Details"
End Code

<h2>詳細</h2>

<div>
    <h4>顧客マスタ</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.CustomerName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CustomerContact)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerContact)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SortNo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SortNo)
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
    @Html.ActionLink("変更", "Edit", New With { .id = Model.CustomerCd }) |
    @Html.ActionLink("一覧へ戻る", "Index")
</p>
