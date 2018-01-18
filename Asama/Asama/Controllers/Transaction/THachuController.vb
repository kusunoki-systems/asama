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
    Public Class THachuController
        Inherits BaseController

        ' GET: THachu
        Function Index() As ActionResult
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, db.T_HachuHeader.ToList())
        End Function

        ' GET: THachu/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_HachuHeader As T_HachuHeader = db.T_HachuHeader.Find(id)
            If IsNothing(t_HachuHeader) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_HachuHeader)
        End Function

        ' GET: THachu/Create
        Function Create() As ActionResult
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Function

        ' POST: THachu/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="HachuNo,SupplierCd,HachuDate,HachuAmount,OrderNo")> ByVal t_HachuHeader As T_HachuHeader) As ActionResult
            If ModelState.IsValid Then
                db.T_HachuHeader.Add(t_HachuHeader)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_HachuHeader)
        End Function

        ' GET: THachu/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_HachuHeader As T_HachuHeader = db.T_HachuHeader.Find(id)
            If IsNothing(t_HachuHeader) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_HachuHeader)
        End Function

        ' POST: THachu/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="HachuNo,SupplierCd,HachuDate,HachuAmount,OrderNo")> ByVal t_HachuHeader As T_HachuHeader) As ActionResult
            If ModelState.IsValid Then
                db.Entry(t_HachuHeader).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_HachuHeader)
        End Function

        ' GET: THachu/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_HachuHeader As T_HachuHeader = db.T_HachuHeader.Find(id)
            If IsNothing(t_HachuHeader) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_HachuHeader)
        End Function

        ' POST: THachu/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim t_HachuHeader As T_HachuHeader = db.T_HachuHeader.Find(id)
            db.T_HachuHeader.Remove(t_HachuHeader)
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
