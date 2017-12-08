Option Strict On

''' <summary>
''' Aloeジェネラルデータ
''' </summary>
''' <typeparam name="TData"></typeparam>
''' <remarks></remarks>
Public Class AloeGeneralData(Of TData)
    Private dict As Dictionary(Of String, TData) = New Dictionary(Of String, TData)

    Public Property Item(ByVal key As String) As TData
        Get
            If dict(key) Is Nothing Then
                Return Nothing
            Else
                Return dict(key)
            End If
        End Get
        Set(value As TData)
            If dict.ContainsKey(key) Then
                dict.Remove(key)
            End If
            dict.Add(key, value)
        End Set
    End Property

    Public Sub Remove(ByVal key As String)
        dict.Remove(key)
    End Sub

    Public Sub RemoveAll()
        dict.Clear()
    End Sub

    Public ReadOnly Property Keys() As ICollection
        Get
            Return dict.Keys
        End Get
    End Property

    Public Sub Add(ByVal key As String, ByVal value As TData)
        dict.Add(key, value)
    End Sub

    Public Function ContainsKey(ByVal key As String) As Boolean
        Return dict.ContainsKey(key)
    End Function

End Class
