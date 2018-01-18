Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Asama

Namespace Controllers
    Public Class TNyukinController
        Inherits BaseController

        ' GET: TNyukin
        Function Index() As ActionResult
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, db.T_Nyukin.ToList())
        End Function

        ' GET: TNyukin/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_Nyukin As T_Nyukin = db.T_Nyukin.Find(id)
            If IsNothing(t_Nyukin) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_Nyukin)
        End Function

        ' GET: TNyukin/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: TNyukin/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="NyukinNo,CustomerCd,Amount,NyukinDate,NyukinMethod,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal t_Nyukin As T_Nyukin) As ActionResult
            If ModelState.IsValid Then
                db.T_Nyukin.Add(t_Nyukin)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_Nyukin)
        End Function

        ' GET: TNyukin/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_Nyukin As T_Nyukin = db.T_Nyukin.Find(id)
            If IsNothing(t_Nyukin) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_Nyukin)
        End Function

        ' POST: TNyukin/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="NyukinNo,CustomerCd,Amount,NyukinDate,NyukinMethod,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal t_Nyukin As T_Nyukin) As ActionResult
            If ModelState.IsValid Then
                db.Entry(t_Nyukin).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_Nyukin)
        End Function

        ' GET: TNyukin/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_Nyukin As T_Nyukin = db.T_Nyukin.Find(id)
            If IsNothing(t_Nyukin) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_Nyukin)
        End Function

        ' POST: TNyukin/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim t_Nyukin As T_Nyukin = db.T_Nyukin.Find(id)
            db.T_Nyukin.Remove(t_Nyukin)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
