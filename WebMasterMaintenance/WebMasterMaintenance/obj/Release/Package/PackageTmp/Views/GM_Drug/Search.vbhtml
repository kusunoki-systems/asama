@ModelType IEnumerable(Of WebMasterMaintenance.GM_DrugEX)
@Code
    ViewData("Title") = "グループ" & ViewBag.MasterTypeTitle & "検索結果一覧"
End Code
@imports WebMasterMaintenance.Helpers
<div class="form-horizontal">
    <div class="form-group">
        <div class="col-md-12">
            @Html.ActionLink("TOP", "Index", "", Nothing, "")
            > @Html.ActionLink("グループ " & ViewBag.MasterTypeTitle.ToString, "Index", "GM_Drug", Nothing, "")
            > 医薬品グループ @ViewBag.MasterTypeTitle 検索結果一覧
        </div>
    </div>
    <hr />
    <div class="form-group">
        <div class="col-md-12">
            <h2>医薬品グループ @ViewBag.MasterTypeTitle </h2>
        </div>
    </div>
    <hr />
    <div class="form-group">
        <div class="col-md-3">
            <h4>検索条件</h4>
        </div>
    </div>
    <div class="form-group">
        <label class="control-label col-md-2" for="">HOT9コード</label>
        <div class="col-md-2">
            @HtmlHelperEditor.ReadOnlyEditor(ViewBag.GDRG_HotCode, "Condition_GDRG_HotCode", "")
        </div>
        <label class="control-label col-md-1" for="">名称</label>
        <div class="col-md-2">
            @HtmlHelperEditor.ReadOnlyEditor(ViewBag.GDRG_DrugName, "Condition_GDRG_DrugName", "")
        </div>
        <div class="col-md-1"></div>
        @If ViewBag.MasterType = "1" Then
            @<div class="form-group check-group">
                <div class="col-md-1">
                    @HtmlHelperEditor.CheckBoxEditor((ViewBag.GM_DosageFormClass1 = "1"), "GM_DosageFormClass1", ViewBag.OptionList_DosageFormClass, 1, True)
                </div>
                <div class="col-md-1">
                    @HtmlHelperEditor.CheckBoxEditor((ViewBag.GM_DosageFormClass6 = "6"), "GM_DosageFormClass6", ViewBag.OptionList_DosageFormClass, 6, True)
                </div>
                <div class="col-md-1">
                    @HtmlHelperEditor.CheckBoxEditor((ViewBag.GM_DosageFormClass4 = "4"), "GM_DosageFormClass4", ViewBag.OptionList_DosageFormClass, 4, True)
                </div>
            </div>
        End If
    </div>

    <hr />

    <div class="form-group">
        <div class="col-md-6 text-right">
            <div class="h3">検索結果一覧</div>
        </div>
        <label class="control-label col-md-1">
            （@Model.Count.ToString 件）
        </label>
    </div>

    <table class="table">
        <thead>
            <tr>
                <th class="w1" style="text-align:center;">

                </th>
                <th class="w1">
                    @GM_Drug_Columns.COLUMN_NAME_GDRG_HotCode
                </th>
                <th class="w1">
                    @GM_Drug_Columns.COLUMN_NAME_GDRG_ReceiptCode
                </th>
                <th class="w10">
                    @GM_Drug_Columns.COLUMN_NAME_GDRG_DrugKana<br />
                    @GM_Drug_Columns.COLUMN_NAME_GDRG_DrugName
                </th>
                <th class="w10">
                    @GM_Drug_Columns.COLUMN_NAME_GDRG_PublicName<br />
                    @GM_Drug_Columns.COLUMN_NAME_GDRG_ComponentName
                </th>
                <th class="w5">
                    @GM_Drug_Columns.COLUMN_NAME_GDRG_OriginalName
                </th>
                <th class="w1">
                    @GM_Drug_Columns.COLUMN_NAME_GDRG_ValidDateFrom
                </th>
                <th class="w1">
                    @GM_Drug_Columns.COLUMN_NAME_GDRG_ValidDateTo
                </th>
            </tr>
        </thead>

        <tbody>
            @For Each item In Model
                @If item.GDRG_ValidDateFrom < DateTime.Now AndAlso item.GDRG_ValidDateTo > DateTime.Now Then
                    @:<tr class="maxlog">
                Else
                    @:<tr class="oldlog">
                End If
                @<td style="line-height: 200%;" class="text-right">
                    <ul style="list-style:none;">
                        <li>
                            @If ViewBag.MasterType = "1" Then
                                @If item.GDRG_ValidDateFrom < DateTime.Now AndAlso item.GDRG_ValidDateTo > DateTime.Now Then
                                    @Html.ActionLink("修正", "Edit", New With {.id = item.GDRG_HotCode & "," & item.GDRG_LogNo}, New With {.class = "btn btn-xs btn-info load-start"})
                                Else
                                    @Html.ActionLink("参照", "Edit", New With {.id = item.GDRG_HotCode & "," & item.GDRG_LogNo}, New With {.class = "btn btn-xs btn-info load-start"})
                                End If
                            ElseIf ViewBag.MasterType = "2" Then
                                @Html.ActionLink("修正", "EditMaterial", New With {.id = item.GDRG_HotCode & "," & item.GDRG_LogNo}, New With {.class = "btn btn-xs btn-info load-start"})
                            ElseIf ViewBag.MasterType = "3" Then
                                @Html.ActionLink("修正", "EditBlood", New With {.id = item.GDRG_HotCode & "," & item.GDRG_LogNo}, New With {.class = "btn btn-xs btn-info load-start"})
                            End If
                        </li>

                        @*最大Logの行のみ複写可*@
                        <li>
                            @If DirectCast(ViewBag.Auth, AuthorityInfo).AuthUpdate Then
                                @Html.ActionLink("複写", "Copy", New With {.id = item.GDRG_HotCode & "," & item.GDRG_LogNo}, New With {.class = "btn btn-xs btn-primary load-start"})
                            End If
                        </li>
                    </ul>

                </td>
                @<td>
                    @Html.DisplayFor(Function(modelItem) item.GDRG_HotCode)
                </td>
                @<td>
                    @Html.DisplayFor(Function(modelItem) item.GDRG_ReceiptCode)
                </td>
                @<td>
                    @Html.DisplayFor(Function(modelItem) item.GDRG_DrugKana)<br />
                    @Html.DisplayFor(Function(modelItem) item.GDRG_DrugName)
                </td>
                @<td>
                    @Html.DisplayFor(Function(modelItem) item.GDRG_PublicName)<br />
                    @Html.DisplayFor(Function(modelItem) item.GDRG_ComponentName)
                </td>
                @<td>
                    @Html.DisplayFor(Function(modelItem) item.GDRG_OriginalName)
                </td>
                @<td>
                    @HtmlHelperDisplay.DateDisplay(item.GDRG_ValidDateFrom)
                </td>
                @<td>
                    @HtmlHelperDisplay.DateDisplay(item.GDRG_ValidDateTo)
                </td>
                @:</tr>
            Next
        </tbody>
    </table>
    <div class="form-group">
        <div class="col-md-4">
            @Html.ActionLink("グループ " & ViewBag.MasterTypeTitle.ToString & "へ戻る", "Index", "M_Drug")
        </div>
    </div>
</div>
