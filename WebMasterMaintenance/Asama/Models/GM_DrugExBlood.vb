Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
''' <summary>
''' 輸血製剤モデル
''' </summary>
<MetadataType(GetType(GM_DrugExBloodMetaData))>
Public Class GM_DrugExBlood
    Inherits GM_DrugEX

    Sub New()
        MyBase.New()
    End Sub

    'Sub New(db As AsamaEntities, FacilityId As String, model As GM_Drug)
    '    MyBase.New(db, FacilityId, model)
    'End Sub

End Class

