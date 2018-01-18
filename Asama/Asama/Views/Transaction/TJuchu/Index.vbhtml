@ModelType IEnumerable(Of Asama.T_JuchuHeader)
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
            @Html.DisplayNameFor(Function(model) model.JuchuDate)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CustomerCd)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.JuchuDate)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.JuchuNo }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.JuchuNo }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.JuchuNo })
        </td>
    </tr>
Next

</table>
