Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
''' <summary>
''' 医療材料用モデル
''' </summary>
<MetadataType(GetType(M_DrugExMaterialMetaData))>
Public Class M_DrugExMaterial
    Inherits M_DrugEX

    Sub New()
        MyBase.New()
    End Sub

    'Sub New(db As AsamaEntities, FacilityId As String, model As M_Drug)
    '    MyBase.New(db, FacilityId, model)
    'End Sub

End Class

