Option Strict On
'******************************************************************
'*	システム名	：	Aloe
'*	ファイル名	：	LoginAD
'*	概要		：	ログインユーザコントロールアプリケーションデータ
'*
'*	Copyright  (c) 2014-2015 Medis Co., Ltd.
'*
'*	【履歴】
'*　日付	　担当		Ver.	チケット#	変更理由
'* ----------------------------------------------------------------
'*　2017/06/29	KSI 中村	0.0.1	#--------	uclLoginADよりコピー
'******************************************************************

Public Class LoginAD

    Public HasError As Boolean = False

    ''施設情報
    'Public Property FacilityList As New SortedList(Of String, String)

    Public Property MinPasswordList As New List(Of Integer)


    '基本情報
    Public Property LoginID As String
    Public Property StaffID As String
    Public Property Password As String
    Public Property LastName As String
    Public Property MiddleName As String
    Public Property FirstName As String
    Public Property KanaLastName As String
    Public Property KanaMiddleName As String
    Public Property KanaFirstName As String
    Public Property SexType As String
    Public Property BirthDate As DateTime
    Public Property RitireDate As DateTime
    Public Property EnterDate As DateTime

    '職種情報
    Public Property JobCodes As String()

    '診療情報
    Public Property DepartmentCode As String

    'アクセス権限
    Public Property AccessAuth As String

    '免許情報
    Public Property LicenseClass As String
    Public Property LicenseNo As String

    'パスワード情報
    Public Property OldPassword As String
    Public Property NewPassword As String
    Public Property Result As Integer

    ''' <summary>
    ''' 機能名
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FunctionName As String = "ログインユーザコントロール"

    ''' <summary>
    ''' ログイン試行カウント
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property LoginCount As Integer

End Class

