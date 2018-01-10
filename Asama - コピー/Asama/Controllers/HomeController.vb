Namespace Controllers

    <AllowAnonymous>
    Public Class HomeController
        Inherits Controllers.BaseController

        Function Index() As ActionResult

            MyBase.RemoveCookie("Delete")

            If MyBase.dbError Then
                Return View()
            End If
            Dim model As New UserModel
            Dim svc As New UserService
            '施設一覧取得
            'model.SetFacilityModels(svc.GetGroupFacility(db))
            Return View(model)

        End Function


    End Class
End Namespace
