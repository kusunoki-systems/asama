@Modeltype UserModel
@Code
    ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
    <!--<h1>Asama </h1>
    <p class="lead">Asama </p>-->
</div>

<div class="row">
    <div class="col-md-offset-2 col-md-10">
        @If User.Identity.IsAuthenticated Then
            @<div>上部メニューより、マスタを選択してください。</div>
        Else
            @Html.Partial("_Login", Model)
        End If
    </div>
</div>
