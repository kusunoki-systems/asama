Option Strict On
'******************************************************************
'*	システム名	：	Asama
'*	ファイル名	：	clsAuthorityInfo.vb
'*	概要		：	制御マスタ戻り値格納用クラス
'*
'*	Copyright  (c) 2014-2015 Medis Co., Ltd.
'*
'*	【履歴】
'*　日付	　担当		Ver.	チケット#	変更理由
'* ----------------------------------------------------------------
'*　2017/07/04	KSI中村	2.3.82	#--------	新規作成　Asama.clsXMLControlInfoクラスよりコピー
'******************************************************************
''' <summary>
''' 制御マスタ戻り値格納用クラス
''' </summary>
''' <remarks>
''' </remarks>
Public Class AuthorityInfo

    Public Sub SetAuth(val As String)
        Me.AuthSelect = CBool(val.Substring(0, 1).ToString = "1")
        Me.AuthInsert = CBool(val.Substring(1, 1).ToString = "1")
        Me.AuthUpdate = CBool(val.Substring(2, 1).ToString = "1")
        Me.AuthCancel = CBool(val.Substring(3, 1).ToString = "1")
        Me.AuthDelete = CBool(val.Substring(4, 1).ToString = "1")
    End Sub
    ''' <summary>
    ''' 権限（参照）
    ''' </summary>
    ''' <value></value>
    ''' <returns>TRUE=権限あり、FALSE=権限なし</returns>
    ''' <remarks></remarks>
    Public Property AuthSelect() As Boolean

    ''' <summary>
    ''' 権限（登録）
    ''' </summary>
    ''' <value></value>
    ''' <returns>TRUE=権限あり、FALSE=権限なし</returns>
    ''' <remarks></remarks>
    Public Property AuthInsert() As Boolean

    ''' <summary>
    ''' 権限（修正）
    ''' </summary>
    ''' <value></value>
    ''' <returns>TRUE=権限あり、FALSE=権限なし</returns>
    ''' <remarks></remarks>
    Public Property AuthUpdate() As Boolean

    ''' <summary>
    ''' 権限（中止）
    ''' </summary>
    ''' <value></value>
    ''' <returns>TRUE=権限あり、FALSE=権限なし</returns>
    ''' <remarks></remarks>
    Public Property AuthCancel() As Boolean

    ''' <summary>
    ''' 権限（削除）
    ''' </summary>
    ''' <value></value>
    ''' <returns>TRUE=権限あり、FALSE=権限なし</returns>
    ''' <remarks></remarks>
    Public Property AuthDelete() As Boolean


End Class
