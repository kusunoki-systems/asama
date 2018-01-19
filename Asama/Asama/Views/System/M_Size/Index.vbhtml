@ModelType IEnumerable(Of Asama.M_Size)
@Code
ViewData("Title") = "Index"
End Code

<h2>サイズ一覧</h2>

<p>
    @Html.ActionLink("新規作成", "Create", "", New With {.class = "btn btn-primary"})
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.SizeCd)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.M_SizeType.SizeTypeName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SizeName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SortNo)
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
             @Html.ActionLink(item.SizeCd, "Edit", New With {.id = item.SizeCd}, New With {.class = ""})
         </td>
         <td>
             @Html.DisplayFor(Function(modelItem) item.M_SizeType.SizeTypeName)
         </td>
         <td>
             @Html.DisplayFor(Function(modelItem) item.SizeName)
         </td>
         <td>
             @Html.DisplayFor(Function(modelItem) item.SortNo)
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
            @Html.ActionLink("削除", "Delete", New With {.id = item.SizeCd}, New With {.class = "btn btn-danger btn-sm"})
        </td>
    </tr>
Next

</table>
