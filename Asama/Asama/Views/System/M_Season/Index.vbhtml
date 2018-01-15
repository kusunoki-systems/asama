@ModelType IEnumerable(Of Asama.M_Season)
@Code
ViewData("Title") = "Index"
End Code

<h2>シーズン一覧</h2>

<p>
    <input type="button" value="新規作成" class="btn btn-default" onclick="location.href='@Url.Action("Create", "M_Size")'" />
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.SeasonName)
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
            @Html.DisplayNameFor(Function(model) model.SortNo)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SeasonName)
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
            @Html.DisplayFor(Function(modelItem) item.SortNo)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.SeasonCd }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.SeasonCd }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.SeasonCd })
        </td>
    </tr>
Next

</table>
