@ModelType IEnumerable(Of Asama.T_ArrivalHeader)
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
            @Html.DisplayNameFor(Function(model) model.ArrivalDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ArrivalAmount)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SupplierCd)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ArrivalDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ArrivalAmount)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ArrivalNo }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ArrivalNo }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.ArrivalNo })
        </td>
    </tr>
Next

</table>
