Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports kusunoki

Namespace Controllers
    Public Class MStaffBaseController
        Inherits BaseController

        'Private db As New AloeEntities

        ' GET: M_StaffBase
        Function Index() As ActionResult
            Return View(db.M_StaffBase.ToList())
        End Function

        ' GET: M_StaffBase/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_StaffBase As M_StaffBase = db.M_StaffBase.Find(id)
            If IsNothing(m_StaffBase) Then
                Return HttpNotFound()
            End If
            Return View(m_StaffBase)
        End Function

        ' GET: M_StaffBase/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: M_StaffBase/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="MSTB_StaffID,MSTB_LogNo,MSTB_UpdateDate,MSTB_UpdateClientName,MSTB_UpdateStaffID,MSTB_DelFlag,MSTB_NameKana,MSTB_Name,MSTB_BirthDate,MSTB_SexType,MSTB_EnterDate,MSTB_RetireDate,MSTB_Remarks")> ByVal m_StaffBase As M_StaffBase) As ActionResult
            If ModelState.IsValid Then
                db.M_StaffBase.Add(m_StaffBase)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(m_StaffBase)
        End Function

        ' GET: M_StaffBase/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_StaffBase As M_StaffBase = db.M_StaffBase.Find(id)
            If IsNothing(m_StaffBase) Then
                Return HttpNotFound()
            End If
            Return View(m_StaffBase)
        End Function

        ' POST: M_StaffBase/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="MSTB_StaffID,MSTB_LogNo,MSTB_UpdateDate,MSTB_UpdateClientName,MSTB_UpdateStaffID,MSTB_DelFlag,MSTB_NameKana,MSTB_Name,MSTB_BirthDate,MSTB_SexType,MSTB_EnterDate,MSTB_RetireDate,MSTB_Remarks")> ByVal m_StaffBase As M_StaffBase) As ActionResult
            If ModelState.IsValid Then
                db.Entry(m_StaffBase).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(m_StaffBase)
        End Function

        ' GET: M_StaffBase/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim m_StaffBase As M_StaffBase = db.M_StaffBase.Find(id)
            If IsNothing(m_StaffBase) Then
                Return HttpNotFound()
            End If
            Return View(m_StaffBase)
        End Function

        ' POST: M_StaffBase/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim m_StaffBase As M_StaffBase = db.M_StaffBase.Find(id)
            db.M_StaffBase.Remove(m_StaffBase)
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
