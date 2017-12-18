@ModelType IEnumerable(Of Asama.M_Item)
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
            @Html.DisplayNameFor(Function(model) model.ItemName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Season)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.MakerCd)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.RetailPrice)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CostPrice)
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
        <th>
            @Html.DisplayNameFor(Function(model) model.M_ColorType.ColorTypeName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.M_SizeType.SizeTypeName)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ItemName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Season)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MakerCd)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.RetailPrice)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CostPrice)
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
            @Html.DisplayFor(Function(modelItem) item.M_ColorType.ColorTypeName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.M_SizeType.SizeTypeName)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ItemCd }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ItemCd }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.ItemCd })
        </td>
    </tr>
Next

</table>
