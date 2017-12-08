'******************************************************************
'*	システム名	：	Aloe
'*	ファイル名	：	clsLoginStaffInfo.vb
'*	概要		：	Aloeで使用するAloeGeneraData・ログイン者情報を定義します。
'*
'*
'*	Copyright  (c) 2014-2015 Medis Co., Ltd.
'*
'*	【履歴】
'*　日付	　担当		Ver.	チケット#	変更理由
'* ----------------------------------------------------------------
'*　2017/06/29	KSI 中村	0.0.1	#--------	clsLoginStaffInfoよりコピー
'******************************************************************

''' <summary>AloeGeneraData・ログイン者情報</summary>
Public Class LoginStaffInfo
    ''' <summary>AloeGeneraData・ログイン者　職員ID</summary>
    Public Property StaffID As String = String.Empty
    ''' <summary>AloeGeneraData・ログイン者　表示用漢字氏名</summary>
    Public Property DisplayName As String = String.Empty
    ''' <summary>AloeGeneraData・ログイン者　職種コード</summary>
    Public Property JobCode As String()
    ''' <summary>AloeGeneraData・ログイン者　表示用職種名</summary>
    Public Property JobName As String = String.Empty
    ''' <summary>AloeGeneraData・ログイン者　表示用職種略称</summary>
    Public Property JobShortName As String = String.Empty
    ''' <summary>AloeGeneraData・ログイン者　パスワード</summary>
    Public Property Password As String = String.Empty
    ''' <summary>AloeGeneraData・ログイン者　グループコード</summary>
    Public Property GroupCode As String = String.Empty
    ''' <summary>AloeGeneraData・ログイン者　診療科コード</summary>
    Public Property DepartmentCode As String = String.Empty
End Class
