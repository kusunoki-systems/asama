@ModelType IEnumerable(Of Asama.M_Season)
@Code
    ViewData("Title") = "シーズン一覧"
End Code

<h2>シーズン一覧</h2>

<p>
    @Html.ActionLink("新規作成", "Create", "", New With {.class = "btn btn-primary"})
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.SeasonCd)
        </th>
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
            @Html.ActionLink(item.SeasonCd, "Edit", New With {.id = item.SeasonCd}, New With {.class = ""})
        </td>
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
            @Html.ActionLink("削除", "Delete", New With {.id = item.SeasonCd}, New With {.class = "btn btn-danger btn-sm"})
        </td>
    </tr>
Next

</table>
