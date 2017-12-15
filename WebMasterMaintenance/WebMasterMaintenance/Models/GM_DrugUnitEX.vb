Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
''' <summary>
''' M_DrugUnitマスタ
''' </summary>
''' <remarks></remarks>
<MetadataType(GetType(M_DrugUnitEXMetaData))>
Public Class GM_DrugUnitEX
    'Inherits GM_DrugUnit

    'Public Property Unit As List(Of VM_Name)     'この医薬品の使用単位全件
    Public Property UnitName As String
    Public Property UpdateStaffName As String

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(db As AsamaEntities)
        MyBase.New()
        Dim opt As New Options()
        opt.db = db

    End Sub
    'Public Sub New(db As AsamaEntities, model As GM_DrugUnit)
    '    Me.New(db)
    '    Me.SetFromOriginalModel(model, db)
    '    '使用単位の取得
    '    Me.Unit = db.VM_Name.Where(Function(e) e.VNAM_NameClass = "CM04").ToList

    'End Sub
    '''' <summary>
    '''' 規定モデルから値をセット
    '''' </summary>
    '''' <param name="model"></param>
    'Public Sub SetFromOriginalModel(model As GM_DrugUnit, db As AsamaEntities)

    '    Me.GDUT_HotCode = model.GDUT_HotCode
    '    Me.GDUT_UnitCode = model.GDUT_UnitCode
    '    Me.GDUT_UnitNo = model.GDUT_UnitNo
    '    Me.GDUT_UnitRatio = model.GDUT_UnitRatio
    '    Me.GDUT_UpdateClientName = model.GDUT_UpdateClientName
    '    Me.GDUT_UpdateDate = model.GDUT_UpdateDate
    '    Me.GDUT_UpdateStaffID = model.GDUT_UpdateStaffID

    '    Me.UnitName = Me.getUnitName(db)

    'End Sub

    'Public Function getUnitName(db As AsamaEntities) As String

    '    '単位
    '    Dim e = From ent As VM_Name In db.VM_Name
    '            Where ent.VNAM_NameClass = "CM04" And ent.VNAM_NameCode = Me.GDUT_UnitCode
    '            Select ent

    '    If e.Count > 0 Then
    '        UnitName = e.First.VNAM_Name
    '    End If

    '    Return UnitName

    'End Function
End Class
