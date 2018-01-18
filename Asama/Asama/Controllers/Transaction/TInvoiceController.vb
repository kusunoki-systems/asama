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
    Public Class TInvoiceController
        Inherits BaseController

        ' GET: TInvoice
        Function Index() As ActionResult
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, db.T_InvoiceHeader.ToList())
        End Function

        ' GET: TInvoice/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_InvoiceHeader As T_InvoiceHeader = db.T_InvoiceHeader.Find(id)
            If IsNothing(t_InvoiceHeader) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_InvoiceHeader)
        End Function

        ' GET: TInvoice/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: TInvoice/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="InvoiceNo,CustomerCd,InvoiceDate,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal t_InvoiceHeader As T_InvoiceHeader) As ActionResult
            If ModelState.IsValid Then
                db.T_InvoiceHeader.Add(t_InvoiceHeader)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_InvoiceHeader)
        End Function

        ' GET: TInvoice/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_InvoiceHeader As T_InvoiceHeader = db.T_InvoiceHeader.Find(id)
            If IsNothing(t_InvoiceHeader) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_InvoiceHeader)
        End Function

        ' POST: TInvoice/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="InvoiceNo,CustomerCd,InvoiceDate,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal t_InvoiceHeader As T_InvoiceHeader) As ActionResult
            If ModelState.IsValid Then
                db.Entry(t_InvoiceHeader).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_InvoiceHeader)
        End Function

        ' GET: TInvoice/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_InvoiceHeader As T_InvoiceHeader = db.T_InvoiceHeader.Find(id)
            If IsNothing(t_InvoiceHeader) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_InvoiceHeader)
        End Function

        ' POST: TInvoice/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim t_InvoiceHeader As T_InvoiceHeader = db.T_InvoiceHeader.Find(id)
            db.T_InvoiceHeader.Remove(t_InvoiceHeader)
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
