@ModelType Asama.M_Size
@Code
    ViewData("Title") = "Delete"
End Code

<h2>削除</h2>

<h3>削除しますか？</h3>
<div>
    <h4>サイズマスタ</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.SizeName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SizeName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.InsertedBy)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.InsertedBy)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.InsertedAt)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.InsertedAt)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UpdatedBy)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UpdatedBy)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UpdatedAt)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UpdatedAt)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.M_SizeType.SizeTypeName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.M_SizeType.SizeTypeName)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="削除" class="btn btn-default" /> |
            @Html.ActionLink("一覧へ戻る", "Index")
        </div>
    End Using
</div>
