'------------------------------------------------------------------------------
' <auto-generated>
'     このコードはテンプレートから生成されました。
'
'     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
'     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class M_Maker
    Public Property MakerCd As String
    Public Property MakerName As String
    Public Property MakerContact As String
    Public Property InsertedBy As String
    Public Property InsertedAt As Nullable(Of Date)
    Public Property UpdatedBy As String
    Public Property UpdatedAt As Nullable(Of Date)
    Public Property SortNo As Nullable(Of Byte)

    Public Overridable Property M_Brand As ICollection(Of M_Brand) = New HashSet(Of M_Brand)

End Class
