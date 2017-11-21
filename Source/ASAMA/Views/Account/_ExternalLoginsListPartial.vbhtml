﻿@ModelType ExternalLoginListViewModel
@Imports Microsoft.Owin.Security
@Code
    Dim loginProviders = Context.GetOwinContext().Authentication.GetExternalAuthenticationTypes()
End Code
<h4>別のサービスを使用してログインしてください。</h4>
<hr />
@If loginProviders.Count() = 0 Then
    @<div>
          <p>
              There are no external authentication services configured. See <a href="https://go.microsoft.com/fwlink/?LinkId=403804">this article</a>
              for details on setting up this ASP.NET application to support logging in via external services.
          </p>
    </div>
Else
    @Using Html.BeginForm("ExternalLogin", "Account", New With {.ReturnUrl = Model.ReturnUrl}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
        @Html.AntiForgeryToken()
        @<div id="socialLoginList">
           <p>
               @For Each p As AuthenticationDescription In loginProviders
                   @<button type="submit" class="btn btn-default" id="@p.AuthenticationType" name="provider" value="@p.AuthenticationType" title="@p.Caption アカウントを使用してログイン">@p.AuthenticationType</button>
               Next
           </p>
        </div>
    End Using
End If
