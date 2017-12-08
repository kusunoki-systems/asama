@ModelType IEnumerable(Of WebMasterMaintenance.CM_DrugEX)
@Code
    ViewData("Title") = "医薬品標準" & ViewBag.MasterTypeTitle & "検索結果一覧"
End Code
@imports WebMasterMaintenance.Helpers
<div class="form-horizontal">
    <div class="form-group">
        <div class="col-md-12">
            @Html.ActionLink("TOP", "Index", "", Nothing, "")
            > @Html.ActionLink("医薬品グループ " & ViewBag.MasterTypeTitle.ToString, "Index", "GM_Drug", Nothing, "")
            > 医薬品標準 @ViewBag.MasterTypeTitle マスタ検索結果一覧
        </div>
    </div>
    <hr />
    <div class="form-group">
        <div class="col-md-5">
            <h2>医薬品標準 @ViewBag.MasterTypeTitle </h2>
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
            @HtmlHelperEditor.ReadOnlyEditor(ViewBag.CDRG_HotCode, "Condition_CDRG_HotCode", "")
        </div>
        <label class="control-label col-md-1" for="">名称</label>
        <div class="col-md-2">
            @HtmlHelperEditor.ReadOnlyEditor(ViewBag.CDRG_DrugName, "Condition_CDRG_DrugName", "")
        </div>
        <div class="col-md-1"></div>
        @If ViewBag.MasterType = "1" Then
            @<div class="form-group check-group">
                <div class="col-md-1">
                    @HtmlHelperEditor.CheckBoxEditor(ViewBag.CM_DosageFormClass1, "CM_DosageFormClass1", ViewBag.OptionList_DosageFormClass, 1, True)
                </div>
                <div class="col-md-1">
                    @HtmlHelperEditor.CheckBoxEditor(ViewBag.CM_DosageFormClass6, "CM_DosageFormClass6", ViewBag.OptionList_DosageFormClass, 6, True)
                </div>
                <div class="col-md-1">
                    @HtmlHelperEditor.CheckBoxEditor(ViewBag.CM_DosageFormClass4, "CM_DosageFormClass4", ViewBag.OptionList_DosageFormClass, 4, True)
                </div>
            </div>
        End If
    </div>

    <hr />

    <div class="col-md-6 text-right">
        <div class="h3">検索結果一覧</div>
    </div>
    <label class="control-label col-md-1">
        （@Model.Count.ToString 件）
    </label>

<style>
    table {
        table-layout: fixed;
    }

    th {
        width: 60px;
    }

    .w1 {
        width: 80px;
    }

    .w2 {
        width: 100px;
    }

    .w3 {
        width: 120px;
    }

    .w4 {
        width: 140px;
    }

    .w5 {
        width: 160px;
    }
</style>
@Using (Html.BeginForm("List", "GM_Drug"))
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <table class="table">
            <thead>
                <tr>
                    <th class="w1" style="text-align:center;">
                        <input type="checkbox" name="check" id="row_all" style="height:20px;width:20px;vertical-align:central;" />
                        <label for="check">選択</label>
                    </th>
                    <th class="w2">
                        HOT9コード
                    </th>
                    <th class="w2">
                        @CM_Drug_Columns.COLUMN_NAME_CDRG_ReceiptCode
                    </th>
                    <th class="w5">
                        @CM_Drug_Columns.COLUMN_NAME_CDRG_DrugName
                    </th>
                    <th class="w5">
                        @CM_Drug_Columns.COLUMN_NAME_CDRG_DrugKana
                    </th>
                    <th class="w5">
                        @CM_Drug_Columns.COLUMN_NAME_CDRG_PublicName
                    </th>
                    <th class="w5">
                        @CM_Drug_Columns.COLUMN_NAME_CDRG_ComponentName
                    </th>
                    <th class="w5">
                        @CM_Drug_Columns.COLUMN_NAME_CDRG_OriginalName
                    </th>
                    <th class="w2">
                        @CM_Drug_Columns.COLUMN_NAME_CDRG_ValidDateFrom
                    </th>
                    <th class="w2">
                        @CM_Drug_Columns.COLUMN_NAME_CDRG_ValidDateTo
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
                            @HtmlHelperEditor.CheckBoxEditorSingle(count, "row", item.CDRG_Hot7Code, item.CDRG_StandardCode, item.Optiont_CheckFlag)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(model) item.CDRG_Hot7Code)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelitem) item.CDRG_ReceiptCode)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelItem) item.CDRG_DrugName)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelItem) item.CDRG_DrugKana)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelItem) item.CDRG_PublicName)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelItem) item.CDRG_ComponentName)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelItem) item.CDRG_OriginalName)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelItem) item.CDRG_ValidDateFrom)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelItem) item.CDRG_ValidDateTo)
                        </td>
                    </tr>
                Next
            </tbody>
        </table>
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

<div class="form-group">
    <div class="col-md-12">
        <a href="javascript:history.back()">戻る</a>
    </div>
</div>


