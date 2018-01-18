@ModelType IEnumerable(Of Asama.T_ArrivalHeader)
@Code
    ViewData("Title") = "入荷一覧"
End Code

<h2>入荷一覧</h2>

<p>
    @Html.ActionLink("新規作成", "Create", "", New With {.class = "btn btn-default"})
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.ArrivalNo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SupplierCd)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ArrivalDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ArrivalAmount)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
         <td>
             @Html.DisplayFor(Function(modelItem) item.ArrivalNo)
         </td>
         <td>
             @Html.DisplayFor(Function(modelItem) item.SupplierCd)
         </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ArrivalDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ArrivalAmount)
        </td>
        <td>
            @Html.ActionLink("変更", "Edit", New With {.id = item.ArrivalNo}, New With {.class = "btn btn-default"}) |
            @Html.ActionLink("詳細", "Details", New With {.id = item.ArrivalNo}, New With {.class = "btn btn-default"}) |
            @Html.ActionLink("削除", "Delete", New With {.id = item.ArrivalNo}, New With {.class = "btn btn-default"})
        </td>
    </tr>
Next

</table>
