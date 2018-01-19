Imports System
Imports System.Collections.Generic
'Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Asama

Namespace Controllers
    <Authorize>
    Public Class M_CustomerController
        Inherits BaseController

        ' GET: M_Customer
        Function Index() As ActionResult
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, db.M_Customer.ToList())
        End Function

        ' GET: M_Customer/Create
        Function Create() As ActionResult
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Function

        ' POST: M_Customer/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="CustomerCd,CustomerName,CustomerContact,SortNo,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal m_Customer As M_Customer) As ActionResult
            If ModelState.IsValid Then
                m_Customer.InsertedAt = Date.Now()
                m_Customer.UpdatedAt = Date.Now()
                m_Customer.InsertedBy = User.Identity.Name
                m_Customer.UpdatedBy = User.Identity.Name
                db.M_Customer.Add(m_Customer)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, m_Customer)
        End Function

        ' GET: M_Customer/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_Customer As M_Customer = db.M_Customer.Find(id)
            If IsNothing(m_Customer) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, m_Customer)
        End Function

        ' POST: M_Customer/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="CustomerCd,CustomerName,CustomerContact,SortNo,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal m_Customer As M_Customer) As ActionResult
            If ModelState.IsValid Then
                m_Customer.UpdatedAt = Date.Now()
                m_Customer.UpdatedBy = User.Identity.Name
                db.Entry(m_Customer).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, m_Customer)
        End Function

        ' GET: M_Customer/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_Customer As M_Customer = db.M_Customer.Find(id)
            If IsNothing(m_Customer) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, m_Customer)
        End Function

        ' POST: M_Customer/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim m_Customer As M_Customer = db.M_Customer.Find(id)
            db.M_Customer.Remove(m_Customer)
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
