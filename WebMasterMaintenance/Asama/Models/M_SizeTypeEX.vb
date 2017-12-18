'Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
''' <summary>
''' M_SizeTypeEXモデル
''' </summary>
''' <remarks></remarks>
<MetadataType(GetType(M_SizeTypeMetaData))>
Public Class M_SizeTypeEX
    Inherits M_SizeType

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(db As AsamaEntities)
        MyBase.New()
    End Sub
    ''' <summary>
    ''' 規定モデルから値をセット
    ''' </summary>
    ''' <param name="model"></param>
    Public Sub SetFromOriginalModel(model As M_SizeType)

        Me.SizeTypeCd = model.SizeTypeCd
        Me.SizeTypeName = model.SizeTypeName
        Me.InsertedAt = model.InsertedAt
        Me.InsertedBy = model.InsertedBy
        Me.UpdateAt = model.UpdateAt
        Me.UpdatedBy = model.UpdatedBy

    End Sub
    ''' <summary>
    ''' 規定モデルを取得
    ''' </summary>
    ''' <returns>M_SizeType</returns>
    Public Function GetOriginalModel() As M_SizeType

        Dim model As New M_SizeType

        model.SizeTypeCd = Me.SizeTypeCd
        model.SizeTypeName = Me.SizeTypeName
        model.InsertedAt = Me.InsertedAt
        model.InsertedBy = Me.InsertedBy
        model.UpdateAt = Me.UpdateAt
        model.UpdatedBy = Me.UpdatedBy

        Return model

    End Function

End Class
