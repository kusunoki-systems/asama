@Modeltype UserModel
@Code
    ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
    <h1>販売管理システム</h1>
    <p class="lead">アキート</p>
</div>

<div class="row">
    <div class="col-md-offset-2 col-md-10">
        @If User.Identity.IsAuthenticated Then
            @<div>上部メニューより、処理を選択してください。</div>
        Else
            @Html.Partial("_Login", Model)
        End If
    </div>
</div>
