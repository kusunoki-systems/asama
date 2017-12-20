Public Class AsamaHotCode

    Const MDrug_PREFIX As String = "U3"
    Const GMDrug_PREFIX As String = "Z3"


    '''' <summary>
    '''' 病院限定　医療材料HotCode採番
    '''' </summary>
    '''' <param name="db"></param>
    '''' <returns></returns>
    'Public Shared Function GetHotCode_MDrug_Material(db As AsamaEntities) As String

    '    '件数取得
    '    Dim cnt = (From e In db.M_Drug
    '               Where e.MDRG_DosageFormClass = 3 And
    '                    e.MDRG_HotCode.Substring(0, 2) = MDrug_PREFIX).Count

    '    'U3&件数+1がHotCodeになる
    '    Return MDrug_PREFIX & (cnt + 1).ToString.PadLeft(7, "0")

    'End Function

    '''' <summary>
    '''' グループ統一　医療材料HotCode採番
    '''' </summary>
    '''' <param name="db"></param>
    '''' <returns></returns>
    'Public Shared Function GetHotCode_GMDrug_Material(db As AsamaEntities) As String

    '    '件数取得
    '    Dim cnt = (From e In db.GM_Drug
    '               Where e.GDRG_DosageFormClass = 3 And
    '                    e.GDRG_HotCode.Substring(0, 2) = GMDrug_PREFIX).Count

    '    'U3&件数+1がHotCodeになる
    '    Return GMDrug_PREFIX & (cnt + 1).ToString

    'End Function


End Class
