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
    Public Class TPaymentController
        Inherits BaseController

        ' GET: TPayment
        Function Index() As ActionResult
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, db.T_PaymentHeader.ToList())
        End Function

        ' GET: TPayment/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_PaymentHeader As T_PaymentHeader = db.T_PaymentHeader.Find(id)
            If IsNothing(t_PaymentHeader) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_PaymentHeader)
        End Function

        ' GET: TPayment/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: TPayment/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="PaymentNo,SupplierCd,PaymentDate,InvoiceAmount,PaymentAmount,Deduction,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal t_PaymentHeader As T_PaymentHeader) As ActionResult
            If ModelState.IsValid Then
                db.T_PaymentHeader.Add(t_PaymentHeader)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_PaymentHeader)
        End Function

        ' GET: TPayment/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_PaymentHeader As T_PaymentHeader = db.T_PaymentHeader.Find(id)
            If IsNothing(t_PaymentHeader) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_PaymentHeader)
        End Function

        ' POST: TPayment/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="PaymentNo,SupplierCd,PaymentDate,InvoiceAmount,PaymentAmount,Deduction,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal t_PaymentHeader As T_PaymentHeader) As ActionResult
            If ModelState.IsValid Then
                db.Entry(t_PaymentHeader).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_PaymentHeader)
        End Function

        ' GET: TPayment/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_PaymentHeader As T_PaymentHeader = db.T_PaymentHeader.Find(id)
            If IsNothing(t_PaymentHeader) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_PaymentHeader)
        End Function

        ' POST: TPayment/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim t_PaymentHeader As T_PaymentHeader = db.T_PaymentHeader.Find(id)
            db.T_PaymentHeader.Remove(t_PaymentHeader)
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
