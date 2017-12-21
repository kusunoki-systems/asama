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
    Public Class M_SizeController
        Inherits BaseController

        ''' <summary>
        ''' Index
        ''' </summary>
        ''' <returns></returns>
        Function Index() As ActionResult
            Dim service As New M_SizeService
            Return View(service.search(db))
        End Function

        ' GET: M_Size/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_Size As M_Size = db.M_Size.Find(id)
            If IsNothing(m_Size) Then
                Return HttpNotFound()
            End If
            Return View(m_Size)
        End Function

        ' GET: M_Size/Create
        Function Create() As ActionResult
            'DropDownListFor で指定したプロパティと同じ名前でViewBagに SelectList を入れておくと良い感じに使ってくれる
            ViewBag.SizeTypeCd = New SelectList(db.M_SizeType, "SizeTypeCd", "SizeTypeName")
            Return View()
        End Function

        ' POST: M_Size/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="SizeCd,SizeName,SizeTypeCd,SortNo,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal m_Size As M_Size) As ActionResult
            If ModelState.IsValid Then
                m_Size.InsertedAt = Date.Now
                m_Size.UpdatedAt = Date.Now
                m_Size.InsertedBy = User.Identity.Name
                m_Size.UpdatedBy = User.Identity.Name
                db.M_Size.Add(m_Size)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.SizeTypeCd = New SelectList(db.M_SizeType, "SizeTypeCd", "SizeTypeName", m_Size.SizeTypeCd)
            Return View(m_Size)
        End Function

        ' GET: M_Size/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_Size As M_Size = db.M_Size.Find(id)
            If IsNothing(m_Size) Then
                Return HttpNotFound()
            End If
            ViewBag.SizeTypeCd = New SelectList(db.M_SizeType, "SizeTypeCd", "SizeTypeName", m_Size.SizeTypeCd)
            Return View(m_Size)
        End Function

        ' POST: M_Size/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="SizeCd,SizeName,SizeTypeCd,SortNo,InsertedBy,InsertedAt,UpdatedBy,UpdatedAt")> ByVal m_Size As M_Size) As ActionResult
            If ModelState.IsValid Then
                m_Size.UpdatedAt = Date.Now
                m_Size.UpdatedBy = User.Identity.Name
                db.Entry(m_Size).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.SizeTypeCd = New SelectList(db.M_SizeType, "SizeTypeCd", "SizeTypeName", m_Size.SizeTypeCd)
            Return View(m_Size)
        End Function

        ' GET: M_Size/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_Size As M_Size = db.M_Size.Find(id)
            If IsNothing(m_Size) Then
                Return HttpNotFound()
            End If
            Return View(m_Size)
        End Function

        ' POST: M_Size/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim m_Size As M_Size = db.M_Size.Find(id)
            db.M_Size.Remove(m_Size)
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
