@ModelType Asama.T_HachuHeader
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-primary" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
