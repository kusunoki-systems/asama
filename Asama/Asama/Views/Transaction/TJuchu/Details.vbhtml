@ModelType Asama.T_JuchuHeader
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>T_JuchuHeader</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.CustomerCd)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerCd)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.JuchuDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.JuchuDate)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.JuchuNo }) |
    @Html.ActionLink("一覧へ戻る", "Index")
</p>
