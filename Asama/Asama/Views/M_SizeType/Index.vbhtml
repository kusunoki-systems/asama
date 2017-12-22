@ModelType IEnumerable(Of Asama.M_SizeType)
@Code
ViewData("Title") = "Index"
End Code

<h2>サイズ種類一覧</h2>

<p>
    <input type="button" value="新規作成" class="btn btn-default" onclick="location.href='@Url.Action("Create", "M_SizeType")'"/>
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.SizeTypeName)
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
             @Html.DisplayFor(Function(modelItem) item.SizeTypeName)
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
            @Html.ActionLink("変更", "Edit", New With {.id = item.SizeTypeCd}) |
            @Html.ActionLink("詳細", "Details", New With {.id = item.SizeTypeCd}) |
            @Html.ActionLink("削除", "Delete", New With {.id = item.SizeTypeCd})
        </td>
    </tr>
Next

</table>
