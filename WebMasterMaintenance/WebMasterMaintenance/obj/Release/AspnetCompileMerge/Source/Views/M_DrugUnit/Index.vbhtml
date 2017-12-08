@ModelType IEnumerable(Of WebMasterMaintenance.M_DrugUnitEX)
@Code
    ViewData("Title") = "Index"
End Code
<span>
    @Html.ActionLink("TOP", "Index", "", Nothing, "")
    > @Html.ActionLink("病院限定" & ViewBag.MasterTypeTitleDrug.ToString, "Index", "M_Drug", Nothing, "")
    > @Html.ActionLink("病院限定" & ViewBag.MasterTypeTitleDrug.ToString & "検索結果一覧", "Index", "M_Drug", New With {.retry = "OK"}, New With {.class = "load-start"})
    @If ViewBag.MasterType = "1" Then
        @:> @Html.ActionLink(ViewBag.HotCode & " " & ViewBag.DrugName, "Edit", "M_Drug", New With {.id = ViewBag.FacilityID & "," & ViewBag.HotCode & "," & ViewBag.LogNo}, New With {.class = "load-start"})
    ElseIf ViewBag.MasterType = "2" Then
        @:> @Html.ActionLink(ViewBag.HotCode & " " & ViewBag.DrugName, "EditMaterial", "M_Drug", New With {.id = ViewBag.FacilityID & "," & ViewBag.HotCode & "," & ViewBag.LogNo}, New With {.class = "load-start"})
    Else
        @:> @Html.ActionLink(ViewBag.HotCode & " " & ViewBag.DrugName, "EditBlood", "M_Drug", New With {.id = ViewBag.FacilityID & "," & ViewBag.HotCode & "," & ViewBag.LogNo}, New With {.class = "load-start"})
    End If
    > @ViewBag.HotCode @ViewBag.DrugName 単位一覧
</span>


<h2>@ViewBag.MasterTypeTitle一覧</h2>

<h3>
    @If ViewBag.MasterType = "1" Then
        @Html.ActionLink(ViewBag.HotCode & " " & ViewBag.DrugName, "Edit", "M_Drug", New With {.id = ViewBag.FacilityID & "," & ViewBag.HotCode & "," & ViewBag.LogNo}, New With {.class = "load-start"})
    Else
        @Html.ActionLink(ViewBag.HotCode & " " & ViewBag.DrugName, "EditMaterial", "M_Drug", New With {.id = ViewBag.FacilityID & "," & ViewBag.HotCode & "," & ViewBag.LogNo}, New With {.class = "load-start"})
    End If
</h3>

<p>
    @Html.ActionLink("追加", "Create", New With {.id = ViewBag.HotCode, .logno = ViewBag.LogNo}, New With {.class = "btn btn-xs btn-primary"})
</p>
<table class="table">
    <tr>
        <th></th>
        <th>単位</th>
        <th>単位換算</th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @code
                If item.MDUT_UnitNo <> 1 Then

                @Html.ActionLink("修正", "Edit", New With {.id = item.MDUT_HotCode, .logno = ViewBag.LogNo, .Key = item.MDUT_UnitNo}, New With {.class = "btn btn-xs btn-primary"})
                    End If
                End Code
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.UnitName)
            </td>
            <td>
                @code
                If item.MDUT_UnitNo <> 1 Then
                Dim UnitRatio As String = Format(item.MDUT_UnitRatio, "#.#####")
                '第２単位以降
                    If item.MDUT_CalculateFlag = 1 Then
                    @<text>1</text>  @item.UnitName @<text>=</text> @UnitRatio @ViewBag.BaseUnit
                    Else
                    @<text>1</text>  @ViewBag.BaseUnit @<text>=</text> @UnitRatio @item.UnitName
                    End If
                End If
                End Code
            </td>
        </tr>
    Next

</table>