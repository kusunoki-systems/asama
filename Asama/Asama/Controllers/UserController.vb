Imports System.Web.Mvc

Namespace Controllers
    Public Class UserController
        Inherits Controllers.BaseController

        Function Login() As ActionResult
            Dim svc As New UserService
            Dim model As New UserModel
            'model.SetFacilityModels(svc.GetGroupFacility(db))
            Return MyBase.View(model)
        End Function

        ''' <summary>
        ''' ログイン POST: User
        ''' </summary>
        ''' <param name="model"></param>
        ''' <param name="returnurl"></param>
        ''' <returns></returns>
        <HttpPost()>
        Function Login(model As UserModel, returnurl As String) As ActionResult

            '認証
            Dim svc As New UserService
            Dim page As New Page
            Dim var = page.Session("PASSERROR:" & model.Id)

            If String.IsNullOrWhiteSpace(model.Id) Then
                Me.ModelState.AddModelError(String.Empty, "ログインIDを入力してください。")
                'model.SetFacilityModels(svc.GetGroupFacility(db))
                Return Me.View(model)
            End If

            '認証処理
            'model.Id = model.Id.PadLeft(12, "0")
            model.Id = model.Id
            Dim loginAD As LoginAD = svc.LoginAuthority(db, model, var)

            If Not loginAD.HasError Then
                'ユーザー認証 成功
                FormsAuthentication.SetAuthCookie(model.Id, model.RememberMe)
                '施設IDをクッキーへ保存
                'SetCookie(COOKIE_FACILITY_ID, model.FacilityID)
                '職種コードをクッキーへ保存
                'Dim strJob As String = String.Join(",", model.JobCodes)
                'SetCookie(COOKIE_JOBCODE, strJob)

                If returnurl Is Nothing Then
                    Return Me.RedirectToAction("Index", "Home")
                Else
                    Return Me.Redirect(returnurl)
                End If
            Else
                'ユーザー認証 失敗
                Me.ModelState.AddModelError(String.Empty, "指定されたログインIDまたはパスワードが正しくありません。")

                'model.SetFacilityModels(svc.GetGroupFacility(db))

                Return Me.View(model)
            End If

        End Function

        ''' <summary>
        ''' ログアウト
        ''' </summary>
        ''' <returns></returns>
        <Authorize>
        Function Logout() As ActionResult

            FormsAuthentication.SignOut()

            Return Me.Redirect("/")

        End Function

    End Class


End Namespace