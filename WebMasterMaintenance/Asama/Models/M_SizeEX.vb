'Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
''' <summary>
''' M_SizeEXモデル
''' </summary>
''' <remarks></remarks>
<MetadataType(GetType(M_SizeMetaData))>
Public Class M_SizeEX
    Inherits M_Size

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
    Public Sub SetFromOriginalModel(model As M_Size)

        Me.SizeCd = model.SizeCd
        Me.SizeName = model.SizeName
        Me.InsertedAt = model.InsertedAt
        Me.InsertedBy = model.InsertedBy
        Me.UpdatedAt = model.UpdatedAt
        Me.UpdatedBy = model.UpdatedBy

    End Sub
    ''' <summary>
    ''' 規定モデルを取得
    ''' </summary>
    ''' <returns>M_Size</returns>
    Public Function GetOriginalModel() As M_Size

        Dim model As New M_Size

        model.SizeCd = Me.SizeCd
        model.SizeName = Me.SizeName
        model.InsertedAt = Me.InsertedAt
        model.InsertedBy = Me.InsertedBy
        model.UpdatedAt = Me.UpdatedAt
        model.UpdatedBy = Me.UpdatedBy

        Return model

    End Function

End Class
