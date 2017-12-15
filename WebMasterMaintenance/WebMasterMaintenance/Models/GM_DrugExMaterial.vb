Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
''' <summary>
''' 医療材料用モデル
''' </summary>
<MetadataType(GetType(GM_DrugExMaterialMetaData))>
Public Class GM_DrugExMaterial
    Inherits GM_DrugEX

    Sub New()
        MyBase.New()
    End Sub

    'Sub New(db As AsamaEntities, FacilityId As String, model As GM_Drug)
    '    MyBase.New(db, FacilityId, model)
    'End Sub

End Class

