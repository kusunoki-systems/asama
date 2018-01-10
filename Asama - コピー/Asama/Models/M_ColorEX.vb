Imports System.ComponentModel.DataAnnotations
''' <summary>
''' M_ColorEXモデル
''' </summary>
''' <remarks></remarks>
<MetadataType(GetType(M_ColorMetaData))>
Public Class M_ColorEX
    Inherits M_Color

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
    'Public Sub SetFromOriginalModel(model As M_Color)

    '    Me.ColorCd = model.ColorCd
    '    Me.ColorName = model.ColorName
    '    Me.ColorTypeCd = model.ColorTypeCd
    '    Me.InsertedAt = model.InsertedAt
    '    Me.InsertedBy = model.InsertedBy
    '    Me.UpdatedAt = model.UpdatedAt
    '    Me.UpdatedBy = model.UpdatedBy

    'End Sub
    '''' <summary>
    '''' 規定モデルを取得
    '''' </summary>
    '''' <returns>M_Color</returns>
    'Public Function GetOriginalModel() As M_Color

    '    Dim model As New M_Color

    '    model.ColorCd = Me.ColorCd
    '    model.ColorName = Me.ColorName
    '    model.ColorTypeCd = Me.ColorTypeCd
    '    model.InsertedAt = Me.InsertedAt
    '    model.InsertedBy = Me.InsertedBy
    '    model.UpdatedAt = Me.UpdatedAt
    '    model.UpdatedBy = Me.UpdatedBy

    '    Return model

    'End Function

End Class
