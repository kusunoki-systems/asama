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
    Public Class M_ColorTypeController
        Inherits BaseController

        ' GET: M_ColorType
        Function Index() As ActionResult
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, db.M_ColorType.ToList())
        End Function

        ' GET: M_ColorType/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_ColorType As M_ColorType = db.M_ColorType.Find(id)
            If IsNothing(m_ColorType) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, m_ColorType)
        End Function

        ' GET: M_ColorType/Create
        Function Create() As ActionResult
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Function

        ' POST: M_ColorType/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ColorTypeCd,ColorTypeName,SortNo,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal m_ColorType As M_ColorType) As ActionResult
            If ModelState.IsValid Then
                m_ColorType.InsertedAt = Date.Now()
                m_ColorType.UpdatedAt = Date.Now()
                m_ColorType.InsertedBy = User.Identity.Name
                m_ColorType.UpdatedBy = User.Identity.Name
                db.M_ColorType.Add(m_ColorType)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, m_ColorType)
        End Function

        ' GET: M_ColorType/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_ColorType As M_ColorType = db.M_ColorType.Find(id)
            If IsNothing(m_ColorType) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, m_ColorType)
        End Function

        ' POST: M_ColorType/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ColorTypeCd,ColorTypeName,SortNo,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal m_ColorType As M_ColorType) As ActionResult
            If ModelState.IsValid Then
                m_ColorType.UpdatedAt = Date.Now()
                m_ColorType.UpdatedBy = User.Identity.Name
                db.Entry(m_ColorType).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, m_ColorType)
        End Function

        ' GET: M_ColorType/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_ColorType As M_ColorType = db.M_ColorType.Find(id)
            If IsNothing(m_ColorType) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, m_ColorType)
        End Function

        ' POST: M_ColorType/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim m_ColorType As M_ColorType = db.M_ColorType.Find(id)
            db.M_ColorType.Remove(m_ColorType)
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
