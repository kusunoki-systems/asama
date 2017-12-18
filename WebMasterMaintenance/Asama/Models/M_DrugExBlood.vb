Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
''' <summary>
''' 輸血製剤モデル
''' </summary>
<MetadataType(GetType(M_DrugExBloodMetaData))>
Public Class M_DrugExBlood
    Inherits M_DrugEX

    Sub New()
        MyBase.New()
    End Sub

    'Sub New(db As AsamaEntities, FacilityId As String, model As M_Drug)
    '    MyBase.New(db, FacilityId, model)
    'End Sub

End Class

