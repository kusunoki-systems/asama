Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
''' <summary>
''' M_DurugUnitマスタ
''' </summary>
''' <remarks></remarks>
<MetadataType(GetType(M_DrugUnitEXMetaData))>
Public Class M_DrugUnitEX
    'Inherits M_DrugUnit

    'Public Property Unit As List(Of VM_Name)     'この医薬品の使用単位全件
    Public Property UnitName As String
    Public Property UpdateStaffName As String
    Public Property DrugName As String

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(db As AsamaEntities)
        MyBase.New()
        Dim opt As New Options()
        opt.db = db

    End Sub
    'Public Sub New(db As AsamaEntities, model As M_DrugUnit)
    '    Me.New(db)
    '    Me.SetFromOriginalModel(model, db)
    '    '使用単位の取得
    '    Dim dtNow As DateTime = DateTime.Now
    '    Dim query = From e In db.VM_Name
    '                Where e.VNAM_DelFlag = 0 And e.VNAM_NameClass = "CM04" And e.VNAM_FacilityID = Me.MDUT_FacilityID And e.VNAM_ValidDateFrom < dtNow
    '                Select e.VNAM_Name, e.VNAM_NameCode

    '    Me.Unit = New List(Of VM_Name)
    '    For Each item In query.ToList
    '        Dim mdl As New VM_Name
    '        mdl.VNAM_Name = item.VNAM_Name
    '        mdl.VNAM_NameCode = item.VNAM_NameCode
    '        Me.Unit.Add(mdl)
    '    Next

    '    '単位名の取得
    '    Me.UnitName = (From e In Unit Where e.VNAM_NameCode = Me.MDUT_UnitCode Select e.VNAM_Name).FirstOrDefault

    '    'スタッフ名の取得
    '    Dim StaffName = From e In db.M_StaffBase Where e.MSTB_StaffID = Me.MDUT_UpdateStaffID Select e
    '    For Each item In StaffName.ToList
    '        Me.UpdateStaffName = item.MSTB_LastName & Replace(" " & item.MSTB_MiddleName & " ", "  ", " ") & item.MSTB_FirstName
    '    Next

    'End Sub

    '''' <summary>
    '''' 規定モデルから値をセット
    '''' </summary>
    '''' <param name="model"></param>
    'Public Sub SetFromOriginalModel(model As M_DrugUnit, db As AsamaEntities)

    '    Me.MDUT_FacilityID = model.MDUT_FacilityID
    '    Me.MDUT_HotCode = model.MDUT_HotCode
    '    Me.MDUT_StatusClass = model.MDUT_StatusClass
    '    Me.MDUT_UnitCode = model.MDUT_UnitCode
    '    Me.MDUT_UnitNo = model.MDUT_UnitNo
    '    Me.MDUT_UnitRatio = model.MDUT_UnitRatio
    '    Me.MDUT_UpdateClientName = model.MDUT_UpdateClientName
    '    Me.MDUT_UpdateDate = model.MDUT_UpdateDate
    '    Me.MDUT_UpdateStaffID = model.MDUT_UpdateStaffID
    '    Me.MDUT_CalculateFlag = model.MDUT_CalculateFlag

    '    Me.UnitName = Me.getUnitName(db)

    'End Sub

    'Public Function getUnitName(db As AsamaEntities) As String

    '    '単位
    '    Dim e = From ent As VM_Name In db.VM_Name
    '            Where ent.VNAM_NameClass = "CM04" And ent.VNAM_NameCode = Me.MDUT_UnitCode
    '            Select ent

    '    If e.Count > 0 Then
    '        UnitName = e.First.VNAM_Name
    '    End If

    '    Return UnitName

    'End Function
End Class
