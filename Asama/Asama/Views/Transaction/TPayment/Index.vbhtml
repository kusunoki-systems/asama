@ModelType IEnumerable(Of Asama.T_PaymentHeader)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.SupplierCd)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PaymentDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.InvoiceAmount)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PaymentAmount)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Deduction)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.InsertedBy)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.InsertedAt)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.UpdatedBy)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.UpdatedAt)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SupplierCd)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PaymentDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.InvoiceAmount)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PaymentAmount)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Deduction)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.InsertedBy)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.InsertedAt)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.UpdatedBy)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.UpdatedAt)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.PaymentNo }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.PaymentNo }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.PaymentNo })
        </td>
    </tr>
Next

</table>
