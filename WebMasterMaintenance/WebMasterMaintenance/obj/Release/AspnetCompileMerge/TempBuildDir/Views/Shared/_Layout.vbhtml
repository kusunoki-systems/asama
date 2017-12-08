@Imports WebMasterMaintenance.Helpers

<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Aloeマスタメンテナンス</title>
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
                @Html.ActionLink("Aloeマスタメンテナンス", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            @If User.Identity.IsAuthenticated Then
                @<div id="gnavi" Class="collapse navbar-collapse">
                    <ul class="nav navbar-nav">
                        <!--医薬品マスタ 操作権限の判定-->
                        @if ViewBag.View_M_Drug = 1 Or ViewBag.View_GM_Drug = 1 Or ViewBag.View_CM_Drug = 1 Then
                        @<li Class="dropdown @ViewBag.ActiveMenu_Type1">
                            <a href = "#" Class="dropdown-toggle" data-toggle="dropdown" role="button">医薬品マスタ <span Class="caret"></span></a>
                            <ul Class="dropdown-menu" role="menu">
                                @If ViewBag.View_M_Drug = 1 Then
                                    @<li>@Html.ActionLink("病院限定薬品マスタ", "Index", "M_Drug", New With {.id = "1"}, New With {.class = ""})</li>
                                End If
                                @If ViewBag.View_GM_Drug = 1 Then
                                    @<li>@Html.ActionLink("グループ統一薬マスタ", "Index", "GM_Drug", New With {.id = "1"}, New With {.class = ""})</li>
                                End If
                                @If ViewBag.View_CM_Drug = 1 Then
                                    @*<li>@Html.ActionLink("標準医薬品", "Index", "CM_Drug", New With {.id = "1"}, New With {.class = ""})</li>*@
                                End If
                            </ul>
                        </li>
                        End If
                        <!--医療材料マスタ 操作権限の判定-->
                        @If ViewBag.View_M_Drug_Material = 1 Or ViewBag.View_GM_Drug_Material = 1 Then
                            @<li Class="dropdown @ViewBag.ActiveMenu_Type2">
                                <a href = "#" Class="dropdown-toggle" data-toggle="dropdown" role="button">処方用医療材料マスタ <span Class="caret"></span></a>
                                <ul Class="dropdown-menu" role="menu">
                                    @If ViewBag.View_M_Drug_Material = 1 Then
                                        @<li>@Html.ActionLink("病院限定処方用医療材料マスタ", "Index", "M_Drug", New With {.id = "2"}, New With {.class = ""})</li>
                                    End If
                                    @If ViewBag.View_GM_Drug_Material = 1 Then
                                        @<li>@Html.ActionLink("グループ統一処方用医療材料マスタ", "Index", "GM_Drug", New With {.id = "2"}, New With {.class = ""})</li>
                                    End If
                                    @If ViewBag.View_CM_Drug_Material = 1 Then
                                        @*<li>@Html.ActionLink("標準医薬品", "Index", "CM_Drug", New With {.id = "2"}, New With {.class = ""})</li>*@
                                    End If
                                </ul>
                            </li>
                        End If
                        <!--血液製剤マスタ 操作権限の判定-->
                        @if ViewBag.View_M_Drug_Blood = 1 Or ViewBag.View_GM_Drug_Blood = 1 Or ViewBag.View_CM_Drug_Blood = 1 Then
                            @<li Class="dropdown @ViewBag.ActiveMenu_Type3">
                                <a href = "#" Class="dropdown-toggle" data-toggle="dropdown" role="button">血液製剤マスタ <span Class="caret"></span></a>
                                <ul Class="dropdown-menu" role="menu">
                                    @If ViewBag.View_M_Drug_Blood = 1 Then
                                        @<li>@Html.ActionLink("病院限定輸血製剤マスタ", "Index", "M_Drug", New With {.id = "3"}, New With {.class = ""})</li>
                                    End If
                                    @If ViewBag.View_GM_Drug_Blood = 1 Then
                                        @<li>@Html.ActionLink("グループ統一輸血製剤マスタ", "Index", "GM_Drug", New With {.id = "3"}, New With {.class = ""})</li>
                                    End If
                                    @If ViewBag.View_CM_Drug_Blood = 1 Then
                                        @*<li>@Html.ActionLink("標準医薬品", "Index", "CM_Drug", New With {.id = "3"}, New With {.class = ""})</li>*@
                                    End If
                                </ul>
                            </li>
                        End If
                        </ul>
                        <ul Class="nav navbar-nav navbar-right">
                            <li>
                                @Html.ActionLink("ログアウト（" & ViewBag.FacilityName.ToString & ":" & ViewBag.StaffName.ToString & "）", "Logout", "User")
                            </li>
                        </ul>
             </div>
            Else
                    @<ul Class="nav navbar-nav navbar-right">
                        <li>
                            @Html.ActionLink("ログイン", "Login", "User")
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
            <p>&copy; @DateTime.Now.Year - Medis Co., Ltd.</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @Scripts.Render("~/bundles/jqueryui")
    @Scripts.Render("~/bundles/script")

    @RenderSection("scripts", required:=False)
</body>
</html>
