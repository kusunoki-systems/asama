Public Class Common

    ''' <summary>
    ''' NVL　Nothingの場合に、rtnValueを返す
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <param name="rtnValue"></param>
    ''' <returns></returns>
    Public Shared Function NVL(ByVal dt As Nullable(Of DateTime), rtnValue As DateTime) As DateTime

        If dt Is Nothing Then Return rtnValue

        Return dt

    End Function

    Public Shared Function DefaultOfType(val As Integer) As Integer
        Return 0
    End Function
    Public Shared Function DefaultOfType(val As String) As String
        Return String.Empty
    End Function
    Public Shared Function DefaultOfType(val As Date) As Date
        Return CDate("1900-01-01")
    End Function


End Class
