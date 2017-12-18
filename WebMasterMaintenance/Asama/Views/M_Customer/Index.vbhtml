@ModelType IEnumerable(Of Asama.M_Customer)
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
            @Html.DisplayNameFor(Function(model) model.CustomerName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CustomerContact)
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
            @Html.DisplayFor(Function(modelItem) item.CustomerName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CustomerContact)
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
            @Html.ActionLink("Edit", "Edit", New With {.id = item.CustomerCd }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.CustomerCd }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.CustomerCd })
        </td>
    </tr>
Next

</table>
