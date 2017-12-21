''' <summary>
''' サイズサービス
''' </summary>
Public Class M_SizeService

    ''' <summary>
    ''' 検索
    ''' </summary>
    ''' <param name="db"></param>
    ''' <returns></returns>
    Public Function search(db As AsamaEntities) As List(Of M_Size)

        Return db.M_Size.OrderBy(Function(m) m.SortNo).ToList()

    End Function
End Class
