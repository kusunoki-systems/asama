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
    Public Class M_MakerController
        Inherits BaseController

        ' GET: M_Maker
        Function Index() As ActionResult
            Return View(db.M_Maker.ToList())
        End Function

        ' GET: M_Maker/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_Maker As M_Maker = db.M_Maker.Find(id)
            If IsNothing(m_Maker) Then
                Return HttpNotFound()
            End If
            Return View(m_Maker)
        End Function

        ' GET: M_Maker/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: M_Maker/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="MakerCd,MakerName,MakerContact,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal m_Maker As M_Maker) As ActionResult
            If ModelState.IsValid Then
                m_Maker.InsertedAt = Date.Now()
                m_Maker.UpdatedAt = Date.Now()
                m_Maker.InsertedBy = User.Identity.Name
                m_Maker.UpdatedBy = User.Identity.Name
                db.M_Maker.Add(m_Maker)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(m_Maker)
        End Function

        ' GET: M_Maker/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_Maker As M_Maker = db.M_Maker.Find(id)
            If IsNothing(m_Maker) Then
                Return HttpNotFound()
            End If
            Return View(m_Maker)
        End Function

        ' POST: M_Maker/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="MakerCd,MakerName,MakerContact,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal m_Maker As M_Maker) As ActionResult
            If ModelState.IsValid Then
                m_Maker.UpdatedAt = Date.Now()
                m_Maker.UpdatedBy = User.Identity.Name
                db.Entry(m_Maker).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(m_Maker)
        End Function

        ' GET: M_Maker/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_Maker As M_Maker = db.M_Maker.Find(id)
            If IsNothing(m_Maker) Then
                Return HttpNotFound()
            End If
            Return View(m_Maker)
        End Function

        ' POST: M_Maker/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim m_Maker As M_Maker = db.M_Maker.Find(id)
            db.M_Maker.Remove(m_Maker)
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
