﻿@ModelType IEnumerable(Of Asama.M_Color)
@Code
    ViewData("Title") = "色一覧"
End Code

<h2>色一覧</h2>

<p>
    <input type="button" value="新規作成" class="btn btn-primary" onclick="location.href='@Url.Action("Create", "M_Color")'" />
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.ColorCd)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ColorName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SortNo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.M_ColorType.ColorTypeName)
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
            @Html.ActionLink(item.ColorCd, "Edit", New With {.id = item.ColorCd}, New With {.class = ""})
        </td>
         <td>
             @Html.DisplayFor(Function(modelItem) item.ColorName)
         </td>
         <td>
             @Html.DisplayFor(Function(modelItem) item.SortNo)
         </td>
         <td>
             @Html.DisplayFor(Function(modelItem) item.M_ColorType.ColorTypeName)
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
             @Html.ActionLink("削除", "Delete", New With {.id = item.ColorCd}, New With {.class = "btn btn-danger btn-sm"})
         </td>
    </tr>
Next

</table>
