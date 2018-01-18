@ModelType IEnumerable(Of Asama.T_DeliverHeader)
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
            @Html.DisplayNameFor(Function(model) model.CustomerCd)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DeliverDate)
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
            @Html.DisplayFor(Function(modelItem) item.CustomerCd)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DeliverDate)
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
            @Html.ActionLink("Edit", "Edit", New With {.id = item.DeliverNo }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.DeliverNo }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.DeliverNo })
        </td>
    </tr>
Next

</table>
