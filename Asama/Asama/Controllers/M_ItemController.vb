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
    Public Class M_ItemController
        Inherits BaseController

        ' GET: M_Item
        Function Index() As ActionResult
            Dim m_Item = db.M_Item.Include(Function(m) m.M_ColorType).Include(Function(m) m.M_SizeType)
            Return View(m_Item.ToList())
        End Function

        ' GET: M_Item/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_Item As M_Item = db.M_Item.Find(id)
            If IsNothing(m_Item) Then
                Return HttpNotFound()
            End If
            Return View(m_Item)
        End Function

        ' GET: M_Item/Create
        Function Create() As ActionResult
            ViewBag.ColorTypeCd = New SelectList(db.M_ColorType, "ColorTypeCd", "ColorTypeName")
            ViewBag.SizeTypeCd = New SelectList(db.M_SizeType, "SizeTypeCd", "SizeTypeName")
            Return View()
        End Function

        ' POST: M_Item/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ItemCd,ItemName,Season,MakerCd,SizeTypeCd,ColorTypeCd,RetailPrice,CostPrice,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal m_Item As M_Item) As ActionResult
            If ModelState.IsValid Then
                m_Item.InsertedAt = Date.Now()
                m_Item.UpdatedAt = Date.Now()
                m_Item.InsertedBy = User.Identity.Name
                m_Item.UpdatedBy = User.Identity.Name
                db.M_Item.Add(m_Item)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.ColorTypeCd = New SelectList(db.M_ColorType, "ColorTypeCd", "ColorTypeName", m_Item.ColorTypeCd)
            ViewBag.SizeTypeCd = New SelectList(db.M_SizeType, "SizeTypeCd", "SizeTypeName", m_Item.SizeTypeCd)
            Return View(m_Item)
        End Function

        ' GET: M_Item/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_Item As M_Item = db.M_Item.Find(id)
            If IsNothing(m_Item) Then
                Return HttpNotFound()
            End If
            ViewBag.ColorTypeCd = New SelectList(db.M_ColorType, "ColorTypeCd", "ColorTypeName", m_Item.ColorTypeCd)
            ViewBag.SizeTypeCd = New SelectList(db.M_SizeType, "SizeTypeCd", "SizeTypeName", m_Item.SizeTypeCd)
            Return View(m_Item)
        End Function

        ' POST: M_Item/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ItemCd,ItemName,Season,MakerCd,SizeTypeCd,ColorTypeCd,RetailPrice,CostPrice,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal m_Item As M_Item) As ActionResult
            If ModelState.IsValid Then
                m_Item.UpdatedAt = Date.Now()
                m_Item.UpdatedBy = User.Identity.Name
                db.Entry(m_Item).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.ColorTypeCd = New SelectList(db.M_ColorType, "ColorTypeCd", "ColorTypeName", m_Item.ColorTypeCd)
            ViewBag.SizeTypeCd = New SelectList(db.M_SizeType, "SizeTypeCd", "SizeTypeName", m_Item.SizeTypeCd)
            Return View(m_Item)
        End Function

        ' GET: M_Item/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_Item As M_Item = db.M_Item.Find(id)
            If IsNothing(m_Item) Then
                Return HttpNotFound()
            End If
            Return View(m_Item)
        End Function

        ' POST: M_Item/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim m_Item As M_Item = db.M_Item.Find(id)
            db.M_Item.Remove(m_Item)
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
