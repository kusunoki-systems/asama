@ModelType Asama.T_PaymentHeader
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>T_PaymentHeader</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.SupplierCd)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SupplierCd)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PaymentDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PaymentDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.InvoiceAmount)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.InvoiceAmount)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PaymentAmount)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PaymentAmount)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Deduction)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Deduction)
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-primary" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
