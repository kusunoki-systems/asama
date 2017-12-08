@ModelType IEnumerable(Of kusunoki.M_DrugEX)
@Code
    ViewData("Title") = "病院限定 " & ViewBag.MasterTypeTitle & "検索結果一覧"
End Code
@imports kusunoki.Helpers
<div class="form-horizontal">
    <div class="form-group">
        <div class="col-md-12">
            @Html.ActionLink("TOP", "Index", "", Nothing, "")
            > @Html.ActionLink("病院限定 " & ViewBag.MasterTypeTitle.ToString, "Index", "M_Drug")
            > 病院限定 @ViewBag.MasterTypeTitle 検索結果一覧
        </div>
    </div>
    <hr />
    <div class="form-group">
        <div class="col-md-12">
            <h2>病院限定 @ViewBag.MasterTypeTitle </h2>
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
            @HtmlHelperEditor.ReadOnlyEditor(ViewBag.MDRG_HotCode, "Condition_MDRG_HotCode", "")
        </div>
        <label class="control-label col-md-1" for="">名称</label>
        <div class="col-md-2">
            @HtmlHelperEditor.ReadOnlyEditor(ViewBag.MDRG_DrugName, "Condition_MDRG_DrugName", "")
        </div>
        <div class="col-md-1"></div>
        @If ViewBag.MasterType = "1" Then
            @<div class="form-group check-group">
                <div class="col-md-1">
                    @HtmlHelperEditor.CheckBoxEditor((ViewBag.M_DosageFormClass1 = "1"), "M_DosageFormClass1", ViewBag.OptionList_DosageFormClass, 1, True)
                </div>
                <div class="col-md-1">
                    @HtmlHelperEditor.CheckBoxEditor((ViewBag.M_DosageFormClass6 = "6"), "M_DosageFormClass6", ViewBag.OptionList_DosageFormClass, 6, True)
                </div>
                <div class="col-md-1">
                    @HtmlHelperEditor.CheckBoxEditor((ViewBag.M_DosageFormClass4 = "4"), "M_DosageFormClass4", ViewBag.OptionList_DosageFormClass, 4, True)
                </div>
            </div>
        End If
    </div>

    <hr />

    <div class="form-group">
        <div class="col-md-6 text-right">
            <div class="h3">検索結果一覧</div>
        </div>
        <label class="control-label col-md-2">
            （@Model.Count.ToString 件）
        </label>
        @*<div class="col-lg-offset-4 col-md-1">
            <button id="btnCsvDownload" class="btn btn-xs btn-primary load-start" type="button">CSV出力</button>
        </div>*@
    </div>

    <table class="drug-table table">
        <thead>
            <tr>
                <th class="w1">
                </th>
                <th class="w1">
                    @M_Drug_Columns.COLUMN_NAME_MDRG_HotCode
                </th>
                <th class="w1">
                    @M_Drug_Columns.COLUMN_NAME_MDRG_ReceiptCode
                </th>
                <th class="w10">
                    @M_Drug_Columns.COLUMN_NAME_MDRG_DrugKana<br />
                    @M_Drug_Columns.COLUMN_NAME_MDRG_DrugName
                </th>
                <th class="w10">
                    @M_Drug_Columns.COLUMN_NAME_MDRG_PublicName<br />
                    @M_Drug_Columns.COLUMN_NAME_MDRG_ComponentName
                </th>
                <th class="w5">
                    @M_Drug_Columns.COLUMN_NAME_MDRG_OriginalName
                </th>
                <th class="w1">
                    @M_Drug_Columns.COLUMN_NAME_MDRG_ValidDateFrom
                </th>
                <th class="w1">
                    @M_Drug_Columns.COLUMN_NAME_MDRG_ValidDateTo
                </th>
            </tr>
        </thead>
        <tbody>

            @For Each item In Model
                @If item.MDRG_ValidDateTo >= CType(DateTime.Now.ToShortDateString, Date).AddDays(1).AddSeconds(-1) Then
                    @:<tr class="maxlog">
                Else
                    @:<tr class="oldlog">
                End If
                @<td style="line-height: 200%;" class="text-right">
                    <ul style="list-style:none;">
                        <li>
                            @If ViewBag.MasterType = "1" Then
                                @If DirectCast(ViewBag.Auth, AuthorityInfo).AuthUpdate And item.MDRG_ValidDateTo >= CType(DateTime.Now.ToShortDateString, Date).AddDays(1).AddSeconds(-1) Then
                                    @Html.ActionLink("修正", "Edit", "M_Drug", New With {.id = item.MDRG_FacilityID & "," & item.MDRG_HotCode & "," & item.MDRG_LogNo}, New With {.class = "btn btn-xs btn-info load-start"})
                                Else
                                    @Html.ActionLink("参照", "Edit", "M_Drug", New With {.id = item.MDRG_FacilityID & "," & item.MDRG_HotCode & "," & item.MDRG_LogNo}, New With {.class = "btn btn-xs btn-info load-start"})
                                End If
                            ElseIf ViewBag.MasterType = "2" Then
                                @If DirectCast(ViewBag.Auth, AuthorityInfo).AuthUpdate And item.MDRG_ValidDateTo >= CType(DateTime.Now.ToShortDateString, Date).AddDays(1).AddSeconds(-1) Then
                                　  @Html.ActionLink("修正", "EditMaterial", "M_Drug", New With {.id = item.MDRG_FacilityID & "," & item.MDRG_HotCode & "," & item.MDRG_LogNo}, New With {.class = "btn btn-xs btn-info load-start"})
                                Else
                          　　      @Html.ActionLink("参照", "EditMaterial", "M_Drug", New With {.id = item.MDRG_FacilityID & "," & item.MDRG_HotCode & "," & item.MDRG_LogNo}, New With {.class = "btn btn-xs btn-info load-start"})
                                End If
                            ElseIf ViewBag.MasterType = "3" Then
                                @If DirectCast(ViewBag.Auth, AuthorityInfo).AuthUpdate And item.MDRG_ValidDateTo >= CType(DateTime.Now.ToShortDateString, Date).AddDays(1).AddSeconds(-1) Then
                                    @Html.ActionLink("修正", "EditBlood", "M_Drug", New With {.id = item.MDRG_FacilityID & "," & item.MDRG_HotCode & "," & item.MDRG_LogNo}, New With {.class = "btn btn-xs btn-info load-start"})
                                Else
                                    @Html.ActionLink("参照", "EditBlood", "M_Drug", New With {.id = item.MDRG_FacilityID & "," & item.MDRG_HotCode & "," & item.MDRG_LogNo}, New With {.class = "btn btn-xs btn-info load-start"})
                                End If
                            End If
                        </li>
                        <li>
                            @If DirectCast(ViewBag.Auth, AuthorityInfo).AuthUpdate Then
                                @Html.ActionLink("複写", "Copy", New With {.id = item.MDRG_FacilityID & "," & item.MDRG_HotCode & "," & item.MDRG_LogNo}, New With {.class = "btn btn-xs btn-primary load-start"})
                            End If
                        </li>
                    </ul>
               </td>
                @<td>
                    @Html.DisplayFor(Function(modelItem) item.MDRG_HotCode)
                </td>
                @<td>
                    @Html.DisplayFor(Function(modelItem) item.MDRG_ReceiptCode)
                </td>
                @<td>
                    @Html.DisplayFor(Function(modelItem) item.MDRG_DrugKana)<br />
                    @Html.DisplayFor(Function(modelItem) item.MDRG_DrugName)
                </td>
                @<td>
                    @Html.DisplayFor(Function(modelItem) item.MDRG_PublicName)<br />
                    @Html.DisplayFor(Function(modelItem) item.MDRG_ComponentName)
                </td>
                @<td>
                    @Html.DisplayFor(Function(modelItem) item.MDRG_OriginalName)
                </td>
                @<td>
                    @HtmlHelperDisplay.DateDisplay(item.MDRG_ValidDateFrom)
                </td>
                @<td>
                    @HtmlHelperDisplay.DateDisplay(item.MDRG_ValidDateTo)
                </td>
            @:</tr>
            Next
        </tbody>
    </table>
    <div class="form-group">
        <div class="col-md-4">
            @Html.ActionLink("病院限定 " & ViewBag.MasterTypeTitle.ToString & "へ戻る", "Index", "M_Drug")
        </div>
    </div>

</div>
