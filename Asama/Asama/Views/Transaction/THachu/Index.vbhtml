@ModelType IEnumerable(Of Asama.T_HachuHeader)
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
            @Html.DisplayNameFor(Function(model) model.HachuDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.HachuAmount)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.OrderNo)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SupplierCd)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.HachuDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.HachuAmount)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.OrderNo)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.HachuNo }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.HachuNo }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.HachuNo })
        </td>
    </tr>
Next

</table>
