@ModelType IEnumerable(Of kusunoki.M_StaffBase)
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
            @Html.DisplayNameFor(Function(model) model.MSTB_BirthDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.MSTB_EnterDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.MSTB_RetireDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.MSTB_Remarks)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MSTB_BirthDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MSTB_EnterDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MSTB_RetireDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MSTB_Remarks)
        </td>
        <td>
            @*@Html.ActionLink("Edit", "Edit", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.PrimaryKey})*@
        </td>
    </tr>
Next

</table>
