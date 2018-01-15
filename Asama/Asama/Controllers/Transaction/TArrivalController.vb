Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Asama

Namespace Controllers.Transaction
    Public Class TArrivalController
        Inherits BaseController

        ' GET: TArrival
        Function Index() As ActionResult
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, db.T_ArrivalHeader.ToList())
        End Function

        ' GET: TArrival/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_ArrivalHeader As T_ArrivalHeader = db.T_ArrivalHeader.Find(id)
            If IsNothing(t_ArrivalHeader) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_ArrivalHeader)
        End Function

        ' GET: TArrival/Create
        Function Create() As ActionResult
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Function

        ' POST: TArrival/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ArrivalNo,SupplierCd,ArrivalDate,ArrivalAmount")> ByVal t_ArrivalHeader As T_ArrivalHeader) As ActionResult
            If ModelState.IsValid Then
                db.T_ArrivalHeader.Add(t_ArrivalHeader)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_ArrivalHeader)
        End Function

        ' GET: TArrival/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_ArrivalHeader As T_ArrivalHeader = db.T_ArrivalHeader.Find(id)
            If IsNothing(t_ArrivalHeader) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_ArrivalHeader)
        End Function

        ' POST: TArrival/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ArrivalNo,SupplierCd,ArrivalDate,ArrivalAmount")> ByVal t_ArrivalHeader As T_ArrivalHeader) As ActionResult
            If ModelState.IsValid Then
                db.Entry(t_ArrivalHeader).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_ArrivalHeader)
        End Function

        ' GET: TArrival/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_ArrivalHeader As T_ArrivalHeader = db.T_ArrivalHeader.Find(id)
            If IsNothing(t_ArrivalHeader) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_ArrivalHeader)
        End Function

        ' POST: TArrival/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim t_ArrivalHeader As T_ArrivalHeader = db.T_ArrivalHeader.Find(id)
            db.T_ArrivalHeader.Remove(t_ArrivalHeader)
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
