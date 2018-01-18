@ModelType IEnumerable(Of Asama.T_Nyukin)
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
            @Html.DisplayNameFor(Function(model) model.Amount)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.NyukinDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.NyukinMethod)
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
            @Html.DisplayFor(Function(modelItem) item.Amount)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NyukinDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NyukinMethod)
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
            @Html.ActionLink("Edit", "Edit", New With {.id = item.NyukinNo }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.NyukinNo }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.NyukinNo })
        </td>
    </tr>
Next

</table>
