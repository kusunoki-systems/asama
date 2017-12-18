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
    Public Class M_ColorController
        Inherits System.Web.Mvc.Controller

        Private db As New AsamaEntities

        ' GET: M_Color
        Function Index() As ActionResult
            Dim m_Color = db.M_Color.Include(Function(m) m.M_ColorType)
            Return View(m_Color.ToList())
        End Function

        ' GET: M_Color/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_Color As M_Color = db.M_Color.Find(id)
            If IsNothing(m_Color) Then
                Return HttpNotFound()
            End If
            Return View(m_Color)
        End Function

        ' GET: M_Color/Create
        Function Create() As ActionResult
            ViewBag.ColorTypeCd = New SelectList(db.M_ColorType, "ColorTypeCd", "ColorTypeName")
            Return View()
        End Function

        ' POST: M_Color/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ColorCd,ColorName,ColorTypeCd,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal m_Color As M_Color) As ActionResult
            If ModelState.IsValid Then
                db.M_Color.Add(m_Color)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.ColorTypeCd = New SelectList(db.M_ColorType, "ColorTypeCd", "ColorTypeName", m_Color.ColorTypeCd)
            Return View(m_Color)
        End Function

        ' GET: M_Color/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_Color As M_Color = db.M_Color.Find(id)
            If IsNothing(m_Color) Then
                Return HttpNotFound()
            End If
            ViewBag.ColorTypeCd = New SelectList(db.M_ColorType, "ColorTypeCd", "ColorTypeName", m_Color.ColorTypeCd)
            Return View(m_Color)
        End Function

        ' POST: M_Color/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ColorCd,ColorName,ColorTypeCd,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal m_Color As M_Color) As ActionResult
            If ModelState.IsValid Then
                db.Entry(m_Color).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.ColorTypeCd = New SelectList(db.M_ColorType, "ColorTypeCd", "ColorTypeName", m_Color.ColorTypeCd)
            Return View(m_Color)
        End Function

        ' GET: M_Color/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_Color As M_Color = db.M_Color.Find(id)
            If IsNothing(m_Color) Then
                Return HttpNotFound()
            End If
            Return View(m_Color)
        End Function

        ' POST: M_Color/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim m_Color As M_Color = db.M_Color.Find(id)
            db.M_Color.Remove(m_Color)
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
