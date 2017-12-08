@ModelType IEnumerable(Of kusunoki.GM_DrugEX)
@Code
    ViewData("Title") = "医薬品グループ" & ViewBag.MasterTypeTitle & "検索結果一覧"
End Code
@imports kusunoki.Helpers
<div class="form-horizontal">
    <div class="form-group">
        <div class="col-md-12">
            @Html.ActionLink("TOP", "Index", "", Nothing, "")
            > @Html.ActionLink("病院限定 " & ViewBag.MasterTypeTitle.ToString, "Index", "M_Drug", Nothing, "")
            > 医薬品グループ @ViewBag.MasterTypeTitle 検索結果一覧
        </div>
    </div>
    <hr />
    <div class="form-group">
        <div class="col-md-12">
            <h2>医薬品グループ @ViewBag.MasterTypeTitle</h2>
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
                    @HtmlHelperEditor.CheckBoxEditor(ViewBag.GM_DosageFormClass1, "GM_DosageFormClass1", ViewBag.OptionList_DosageFormClass, 1, True)
                </div>
                <div class="col-md-1">
                    @HtmlHelperEditor.CheckBoxEditor(ViewBag.GM_DosageFormClass6, "GM_DosageFormClass6", ViewBag.OptionList_DosageFormClass, 6, True)
                </div>
                <div class="col-md-1">
                    @HtmlHelperEditor.CheckBoxEditor(ViewBag.GM_DosageFormClass4, "GM_DosageFormClass4", ViewBag.OptionList_DosageFormClass, 4, True)
                </div>
            </div>
        End If
    </div>

    <hr />

    <div class="col-md-6 text-right">
        <div class="h3">検索結果一覧</div>
    </div>
    <label class="control-label col-md-2">
        （@Model.Count.ToString 件）
    </label>

    @Using (Html.BeginForm("ListGM", "M_Drug"))
        @Html.AntiForgeryToken()

        @<div class="form-horizontal">
             <table class="drug-table table">
                 <thead>
                     <tr>
                         <th class="w1" style="text-align:center;">
                             <input type="checkbox" name="check" id="row_all" style="height:20px;width:20px;vertical-align:central;" />
                             <label for="check">選択</label>
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

                 <tbody id="rows">
                     @Code
                         Dim count As Integer = 0
                     End Code
                     @For Each item In Model
                 @code
                     count += 1
                 End Code
                 @<tr>
                     <td class="row_field" style="line-height: 200%;text-align:center;">
                         @HtmlHelperEditor.CheckBoxEditorSingle(count, "row", item.GDRG_HotCode, item.GDRG_LogNo, item.Optiont_CheckFlag)
                     </td>
                     <td>
                         @Html.DisplayFor(Function(modelItem) item.GDRG_HotCode)
                     </td>
                     <td>
                         @Html.DisplayFor(Function(modelItem) item.GDRG_ReceiptCode)
                     </td>
                     <td>
                         @Html.DisplayFor(Function(modelItem) item.GDRG_DrugKana)<br />
                         @Html.DisplayFor(Function(modelItem) item.GDRG_DrugName)
                     </td>
                     <td>
                         @Html.DisplayFor(Function(modelItem) item.GDRG_PublicName)<br />
                         @Html.DisplayFor(Function(modelItem) item.GDRG_ComponentName)
                     </td>
                     <td>
                         @Html.DisplayFor(Function(modelItem) item.GDRG_OriginalName)
                     </td>
                     <td>
                         @HtmlHelperDisplay.DateDisplay(item.GDRG_ValidDateFrom)
                     </td>
                     <td>
                         @HtmlHelperDisplay.DateDisplay(item.GDRG_ValidDateTo)
                     </td>
                 </tr>
                     Next
                 </tbody>
             </table>

            <input type="hidden" id="ListType" value="GM_Drug">
            <hr />
            <div class="form-group">
                <div class="col-md-offset-1 col-md-1">
                    @If DirectCast(ViewBag.Auth, AuthorityInfo).AuthInsert Then
                        @<button type="submit" name="SubmitButton" value="Regist" id="Submit" class="btn btn-primary btn-block" disabled="">登録</button>
                    Else
                        @<button type="submit" name="SubmitButton" value="Regist" id="SubmitRegist" class="btn btn-primary btn-block" disabled="">登録</button>
                    End If
                </div>
            </div>
        </div>
    End Using
</div>
<div class="form-group">
    <div class="col-md-12">
        @Html.ActionLink("病院限定 " & ViewBag.MasterTypeTitle.ToString & "へ戻る", "Index", "M_Drug")
    </div>
</div>
