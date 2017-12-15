<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - ASaMa Acchito Sales Management System.</title>
    @Styles.Render("~/Content/css")
    @Styles.Render("~/Content/jqueryui")
    @Scripts.Render("~/bundles/modernizr")

</head>
<body>

    <nav class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#gnavi">
                    <span class="sr-only">メニュー</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Acchito Sales Management System.", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            @If User.Identity.IsAuthenticated Then
                @<div id="gnavi" Class="collapse navbar-collapse">
                    <ul class="nav navbar-nav">
                        <li Class="dropdown">
                            <a href="#" Class="dropdown-toggle" data-toggle="dropdown" role="button"><span class="fa fa-fax"></span> 受注 <span Class="caret"></span></a>
                            <ul Class="dropdown-menu" role="menu">
                                <li>@Html.ActionLink("受注入力", "Index", "M_Drug", New With {.id = "1"}, New With {.class = ""})</li>
                            </ul>
                        </li>
                        <li Class="dropdown">
                            <a href="#" Class="dropdown-toggle" data-toggle="dropdown" role="button"><span class="fa fa-plane"></span> 発注 <span Class="caret"></span></a>
                            <ul Class="dropdown-menu" role="menu">
                                <li>@Html.ActionLink("発注入力", "Index", "M_Drug", New With {.id = "1"}, New With {.class = ""})</li>
                            </ul>
                        </li>
                        <li Class="dropdown">
                            <a href="#" Class="dropdown-toggle" data-toggle="dropdown" role="button"><span class="fa fa-ship"></span> 入荷 <span Class="caret"></span></a>
                            <ul Class="dropdown-menu" role="menu">
                                <li>@Html.ActionLink("入荷入力", "Index", "M_Drug", New With {.id = "2"}, New With {.class = ""})</li>
                            </ul>
                        </li>
                        <li Class="dropdown">
                            <a href="#" Class="dropdown-toggle" data-toggle="dropdown" role="button"><span class="fa fa-truck"></span> 出荷 <span Class="caret"></span></a>
                            <ul Class="dropdown-menu" role="menu">
                                <li>@Html.ActionLink("出荷入力", "Index", "M_Drug", New With {.id = "2"}, New With {.class = ""})</li>
                            </ul>
                        </li>
                        <li Class="dropdown">
                            <a href="#" Class="dropdown-toggle" data-toggle="dropdown" role="button"><span class="fa fa-print"></span> 請求 <span Class="caret"></span></a>
                            <ul Class="dropdown-menu" role="menu">
                                <li>@Html.ActionLink("請求入力", "Index", "M_Drug", New With {.id = "2"}, New With {.class = ""})</li>
                            </ul>
                        </li>
                        <li Class="dropdown">
                            <a href="#" Class="dropdown-toggle" data-toggle="dropdown" role="button"><span class="fa fa-jpy"></span> 入金 <span Class="caret"></span></a>
                            <ul Class="dropdown-menu" role="menu">
                                <li>@Html.ActionLink("入金入力", "Index", "M_Drug", New With {.id = "2"}, New With {.class = ""})</li>
                            </ul>
                        </li>
                        <li Class="dropdown">
                            <a href="#" Class="dropdown-toggle" data-toggle="dropdown" role="button"><span class="fa fa-gear"></span> システム管理 <span Class="caret"></span></a>
                            <ul Class="dropdown-menu" role="menu">
                                <li>@Html.ActionLink("マスター", "Index", "system", New With {.id = "2"}, New With {.class = ""})</li>
                            </ul>
                        </li>
                    </ul>
                    <ul Class="nav navbar-nav navbar-right">
                        <li>
                            @Html.ActionLink("ログアウト（" & ViewBag.StaffName.ToString & "）", "Logout", "User")
                        </li>
                    </ul>
             </div>
            Else
                    @<ul Class="nav navbar-nav navbar-right">
                        <li>
                            @Html.ActionLink("ログイン", "Login", "Account")
                        </li>
                    </ul>

            End If
                       
        </div>
    </nav>

    <!--ローディング画像-->
    <div id="loading">
        <img src="~/images/loading.gif" />
    </div>

    <div Class="container body-content">
        <p Class="message">@ViewBag.Message</p>
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - Asama Project.</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @Scripts.Render("~/bundles/jqueryui")
    @Scripts.Render("~/bundles/script")

    @RenderSection("scripts", required:=False)
</body>
</html>
