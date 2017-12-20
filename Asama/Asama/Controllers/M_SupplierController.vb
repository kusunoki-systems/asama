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
    Public Class M_SupplierController
        Inherits BaseController

        ' GET: M_Supplier
        Function Index() As ActionResult
            Return View(db.M_Supplier.ToList())
        End Function

        ' GET: M_Supplier/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_Supplier As M_Supplier = db.M_Supplier.Find(id)
            If IsNothing(m_Supplier) Then
                Return HttpNotFound()
            End If
            Return View(m_Supplier)
        End Function

        ' GET: M_Supplier/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: M_Supplier/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="SupplierCd,SupplierName,SupplierContact,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal m_Supplier As M_Supplier) As ActionResult
            If ModelState.IsValid Then
                m_Supplier.InsertedAt = Date.Now()
                m_Supplier.UpdatedAt = Date.Now()
                m_Supplier.InsertedBy = User.Identity.Name
                m_Supplier.UpdatedBy = User.Identity.Name
                db.M_Supplier.Add(m_Supplier)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(m_Supplier)
        End Function

        ' GET: M_Supplier/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_Supplier As M_Supplier = db.M_Supplier.Find(id)
            If IsNothing(m_Supplier) Then
                Return HttpNotFound()
            End If
            Return View(m_Supplier)
        End Function

        ' POST: M_Supplier/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="SupplierCd,SupplierName,SupplierContact,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal m_Supplier As M_Supplier) As ActionResult
            If ModelState.IsValid Then
                m_Supplier.UpdatedAt = Date.Now()
                m_Supplier.UpdatedBy = User.Identity.Name
                db.Entry(m_Supplier).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(m_Supplier)
        End Function

        ' GET: M_Supplier/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_Supplier As M_Supplier = db.M_Supplier.Find(id)
            If IsNothing(m_Supplier) Then
                Return HttpNotFound()
            End If
            Return View(m_Supplier)
        End Function

        ' POST: M_Supplier/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim m_Supplier As M_Supplier = db.M_Supplier.Find(id)
            db.M_Supplier.Remove(m_Supplier)
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
