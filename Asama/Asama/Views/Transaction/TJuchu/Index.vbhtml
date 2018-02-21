@ModelType Asama.T_JuchuHeaderEx
@Code
    ViewData("Title") = "受注一覧"
End Code

<h2>受注一覧</h2>

<p>
    @Html.ActionLink("新規作成", "Create", "", New With {.class = "btn btn-primary"})
</p>
<div class="form-horizontal">
    <h4>検索条件</h4>
    <div class="form-group">
        @Html.LabelFor(Function(model) model.SearchCustomerCd, htmlAttributes:=New With {.class = "control-label col-md-1"})
        <div class="col-md-2">
            <!-- 2 つ目の引数を null にして ViewBag から SelectList を取得 -->
            @Html.DropDownList("SearchCustomerCd", Nothing, htmlAttributes:=New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.SearchCustomerCd, "", New With {.class = "text-danger"})
        </div>
    </div>
</div>
<hr />
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Exs(0).JuchuNo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Exs(0).CustomerCd)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Exs(0).JuchuDate)
        </th>
        <th></th>
    </tr>

@For Each item In Model.Exs
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.JuchuNo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CustomerCd)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.JuchuDate)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.JuchuNo}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.JuchuNo}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.JuchuNo})
        </td>
    </tr>
Next

</table>
