﻿Imports System
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
    Public Class M_SizeTypeController
        Inherits BaseController

        ' GET: M_SizeType
        Function Index() As ActionResult
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, db.M_SizeType.ToList())
        End Function

        ' GET: M_SizeType/Create
        Function Create() As ActionResult
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Function

        ' POST: M_SizeType/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="SizeTypeCd,SizeTypeName,SortNo,InsertedBy,InsertedAt,UpdatedBy,UpdateAt")> ByVal m_SizeType As M_SizeType) As ActionResult
            If ModelState.IsValid Then
                m_SizeType.InsertedAt = Date.Now()
                m_SizeType.UpdatedAt = Date.Now()
                m_SizeType.InsertedBy = User.Identity.Name
                m_SizeType.UpdatedBy = User.Identity.Name
                db.M_SizeType.Add(m_SizeType)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, m_SizeType)
        End Function

        ' GET: M_SizeType/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_SizeType As M_SizeType = db.M_SizeType.Find(id)
            If IsNothing(m_SizeType) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, m_SizeType)
        End Function

        ' POST: M_SizeType/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="SizeTypeCd,SizeTypeName,SortNo,InsertedBy,InsertedAt,UpdatedBy,UpdateAt")> ByVal m_SizeType As M_SizeType) As ActionResult
            If ModelState.IsValid Then
                m_SizeType.UpdatedAt = Date.Now()
                m_SizeType.UpdatedBy = User.Identity.Name
                db.Entry(m_SizeType).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, m_SizeType)
        End Function

        ' GET: M_SizeType/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_SizeType As M_SizeType = db.M_SizeType.Find(id)
            If IsNothing(m_SizeType) Then
                Return HttpNotFound()
            End If
            Return MyBase.View(System.Reflection.MethodBase.GetCurrentMethod.Name, m_SizeType)
        End Function

        ' POST: M_SizeType/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim m_SizeType As M_SizeType = db.M_SizeType.Find(id)
            db.M_SizeType.Remove(m_SizeType)
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
