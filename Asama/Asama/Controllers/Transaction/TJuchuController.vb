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
    Public Class TJuchuController
        Inherits BaseController

        ' GET: TJuchu
        Function Index() As ActionResult
            Dim t_JuchuHeader = (db.T_JuchuHeader.Include(Function(m) m.M_Customer))    '顧客マスタ
            Dim ex As New T_JuchuHeaderEx
            ex.Exs = t_JuchuHeader
            ViewBag.SearchCustomerCd = New SelectList(db.M_Customer, "CustomerCd", "CustomerName")
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, ex)
        End Function

        ' GET: TJuchu/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_JuchuHeader As T_JuchuHeader = db.T_JuchuHeader.Find(id)
            If IsNothing(t_JuchuHeader) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_JuchuHeader)
        End Function

        ' GET: TJuchu/Create
        Function Create() As ActionResult
            ViewBag.CustomerCd = New SelectList(db.M_Customer, "CustomerCd", "CustomerName")
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Function

        ' POST: TJuchu/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="JuchuNo,CustomerCd,JuchuDate")> ByVal t_JuchuHeader As T_JuchuHeader) As ActionResult
            If ModelState.IsValid Then
                db.T_JuchuHeader.Add(t_JuchuHeader)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_JuchuHeader)
        End Function

        ' GET: TJuchu/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_JuchuHeader As T_JuchuHeader = db.T_JuchuHeader.Find(id)
            If IsNothing(t_JuchuHeader) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_JuchuHeader)
        End Function

        ' POST: TJuchu/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="JuchuNo,CustomerCd,JuchuDate")> ByVal t_JuchuHeader As T_JuchuHeader) As ActionResult
            If ModelState.IsValid Then
                db.Entry(t_JuchuHeader).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_JuchuHeader)
        End Function

        ' GET: TJuchu/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_JuchuHeader As T_JuchuHeader = db.T_JuchuHeader.Find(id)
            If IsNothing(t_JuchuHeader) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_JuchuHeader)
        End Function

        ' POST: TJuchu/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim t_JuchuHeader As T_JuchuHeader = db.T_JuchuHeader.Find(id)
            db.T_JuchuHeader.Remove(t_JuchuHeader)
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
