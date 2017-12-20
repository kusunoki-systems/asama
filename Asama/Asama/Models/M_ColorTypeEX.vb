Imports System.ComponentModel.DataAnnotations
''' <summary>
''' M_ColorTypeEXモデル
''' </summary>
''' <remarks></remarks>
<MetadataType(GetType(M_ColorTypeMetaData))>
Public Class M_ColorTypeEX
    Inherits M_ColorType

    Public Sub New()
        MyBase.New()
    End Sub
    'Public Sub New(db As AsamaEntities)
    '    MyBase.New()
    'End Sub
    '''' <summary>
    '''' 規定モデルから値をセット
    '''' </summary>
    '''' <param name="model"></param>
    'Public Sub SetFromOriginalModel(model As M_ColorType)

    '    Me.ColorTypeCd = model.ColorTypeCd
    '    Me.ColorTypeName = model.ColorTypeName
    '    Me.InsertedAt = model.InsertedAt
    '    Me.InsertedBy = model.InsertedBy
    '    Me.UpdatedAt = model.UpdatedAt
    '    Me.UpdatedBy = model.UpdatedBy

    'End Sub
    '''' <summary>
    '''' 規定モデルを取得
    '''' </summary>
    '''' <returns>M_ColorType</returns>
    'Public Function GetOriginalModel() As M_ColorType

    '    Dim model As New M_ColorType

    '    model.ColorTypeCd = Me.ColorTypeCd
    '    model.ColorTypeName = Me.ColorTypeName
    '    model.InsertedAt = Me.InsertedAt
    '    model.InsertedBy = Me.InsertedBy
    '    model.UpdatedAt = Me.UpdatedAt
    '    model.UpdatedBy = Me.UpdatedBy

    '    Return model

    'End Function

End Class
