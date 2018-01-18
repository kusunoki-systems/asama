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
    Public Class TDeliverController
        Inherits BaseController

        ' GET: TDeliver
        Function Index() As ActionResult
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, db.T_DeliverHeader.ToList())
        End Function

        ' GET: TDeliver/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_DeliverHeader As T_DeliverHeader = db.T_DeliverHeader.Find(id)
            If IsNothing(t_DeliverHeader) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_DeliverHeader)
        End Function

        ' GET: TDeliver/Create
        Function Create() As ActionResult
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Function

        ' POST: TDeliver/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="DeliverNo,CustomerCd,DeliverDate,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal t_DeliverHeader As T_DeliverHeader) As ActionResult
            If ModelState.IsValid Then
                db.T_DeliverHeader.Add(t_DeliverHeader)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_DeliverHeader)
        End Function

        ' GET: TDeliver/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_DeliverHeader As T_DeliverHeader = db.T_DeliverHeader.Find(id)
            If IsNothing(t_DeliverHeader) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_DeliverHeader)
        End Function

        ' POST: TDeliver/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="DeliverNo,CustomerCd,DeliverDate,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal t_DeliverHeader As T_DeliverHeader) As ActionResult
            If ModelState.IsValid Then
                db.Entry(t_DeliverHeader).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_DeliverHeader)
        End Function

        ' GET: TDeliver/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_DeliverHeader As T_DeliverHeader = db.T_DeliverHeader.Find(id)
            If IsNothing(t_DeliverHeader) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, t_DeliverHeader)
        End Function

        ' POST: TDeliver/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim t_DeliverHeader As T_DeliverHeader = db.T_DeliverHeader.Find(id)
            db.T_DeliverHeader.Remove(t_DeliverHeader)
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
