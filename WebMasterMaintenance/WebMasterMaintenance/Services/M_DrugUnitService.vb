Imports System.Data.Entity

Public Class M_DrugUnitService

    '''' <summary>
    '''' 重複チェック
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="mdl"></param>
    '''' <param name="msg"></param>
    '''' <returns></returns>
    'Public Function DupllicateCheck(db As AsamaEntities, mdl As M_DrugUnit, ByRef msg As String) As Boolean

    '    Dim query = From e In db.M_DrugUnit
    '                Where e.MDUT_FacilityID = mdl.MDUT_FacilityID And
    '                    e.MDUT_HotCode = mdl.MDUT_HotCode And
    '                    e.MDUT_UnitNo <> mdl.MDUT_UnitNo And
    '                    e.MDUT_UnitCode = mdl.MDUT_UnitCode And
    '                    e.MDUT_DelFlag = 0
    '                Select e

    '    If query.Count > 0 Then
    '        msg = Message.MSG_DUPLICATE_UNIT
    '        Return False
    '    End If

    '    Return True

    'End Function

End Class
