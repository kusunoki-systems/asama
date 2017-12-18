Option Strict On

'******************************************************************
'*	システム名	：	メディスカルテ
'*	ファイル名	：	clsLogMessageTbl.vb
'*	概要		：	メッセージ一覧のＯを行う。（参照のみ）
'*
'*	Copyright  (c) 2014-2015 Medis Co., Ltd.
'******************************************************************
''' <summary>
''' メッセージ一覧アクセスクラス
''' </summary>
''' <remarks>
''' <para>日付			作業者		#ﾁｹｯﾄ	メソッド名/概要</para>
''' </remarks>
Public Class LogMessageTbl
#Region "定数定義"
    ''' <summary>テーブル名</summary>
    Private Const TABLE_NAME As String = "S_Message"
    ''' <summary>テーブルプリフィックス</summary>
    Private Const TABLE_PREFIX As String = "SMSG"
    ''' <summary>Data取得時のキーフィールド</summary>
    Private Const KEY_FIELD As String = "MessageID"
#End Region

#Region "LogMessageMember"
    ''' <summary>
    ''' <para>Messageテーブルの列を扱うクラス</para>
    ''' </summary>
    ''' <remarks>
    ''' <para>Messageの列をプロパティで公開する。</para>
    ''' <para>テーブルアダプタとプロパティとの連携を行う。</para>
    ''' <para>(メンバの初期値がAsamaConst.UndefXXX未使用だが、使用するのがLogMessage内のみで他に影響ないためそのままとする)</para>
    ''' </remarks>
    Public MustInherit Class LogMessageMember

        Protected clsLogMessage As New LogMessage

#Region "定数定義"
        Protected m_HasData As Boolean = False
        Protected m_MessageID As String = Nothing      'メッセージID(KEY)
        Protected m_UpdateDate As Date = Nothing
        Protected m_UpdateStaffID As String = Nothing
        Protected m_DelFlag As Integer = -1
        Protected m_LogLevelForm As Integer = -1
        Protected m_LogLevelFile As Integer = -1
        Protected m_MessageIcon As Integer = -1
        Protected m_MessageDetail As String = Nothing
        Protected m_ButtonType As Integer = -1
        Protected m_ButtonPosition As Integer = -1
        Protected m_InsertDate As Date = Nothing
#End Region

#Region "Property"
        ''' <summary>
        ''' <para>データ有無</para>
        ''' <para>GetDataのNew時にデータ取得できたかどうかを持つ</para>
        ''' <para>True=データあり</para>
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property HasData() As Boolean
            Get
                Return m_HasData
            End Get
        End Property
        ''' <summary>
        ''' <para>メッセージID 8byte</para>
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property MessageID() As String
            Get
                Return m_MessageID
            End Get
        End Property
        ''' <summary>
        ''' <para>ログレベル(画面) 1byte</para>
        ''' <para>0：未出力、1：通常、2：デバッグ</para>
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property LogLevelForm() As Integer
            Get
                Return m_LogLevelForm
            End Get
        End Property
        ''' <summary>
        ''' <para>ログレベル(ログファイル) 1byte</para>
        ''' <para>0：未出力、1：通常、2：デバッグ</para>
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property LogLevelFile() As Integer
            Get
                Return m_LogLevelFile
            End Get
        End Property
        ''' <summary>
        ''' <para>メッセージアイコン</para>
        ''' <para>64:情報、48:警告、32:確認、16:エラー</para>
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property MessageIcon() As Integer
            Get
                Return m_MessageIcon
            End Get
        End Property
        ''' <summary>
        ''' メッセージ内容 1000byte
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MessageDetail() As String
            Get
                Return m_MessageDetail
            End Get
            Set(value As String)
                If value Is Nothing Then
                    m_MessageDetail = AsamaConst.UndefString
                Else
                    m_MessageDetail = value
                End If
            End Set
        End Property
        ''' <summary>
        ''' <para>ボタン種別 1byte</para>
        ''' <para>0:OKOnly、4:YesNo、3:YesNoCancel、1:OkCancel、5:RetryCancel</para>
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property ButtonType() As Integer
            Get
                Return m_ButtonType
            End Get
        End Property
        ''' <summary>
        ''' <para>デフォルトボタン</para>
        ''' <para>0:Button1、256:Button2、512:Button3</para>
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property ButtonPosition() As Integer
            Get
                Return m_ButtonPosition
            End Get
        End Property
#End Region

    End Class
#End Region

#Region "LogMessageData"
    ''' <summary>
    ''' Messageの1データを取り扱うクラス【AsamaGeneralData使用】
    ''' </summary>
    ''' <remarks></remarks>
    Public Class LogMessageData
        Inherits LogMessageMember

        ''' <summary>
        ''' コンストラクタ（新規挿入用読み込みなし）
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()
            '最初に基本クラスのコンストラクタを呼び出す
            MyBase.New()
        End Sub
        ''' <summary>
        ''' コンストラクタ（キー指定で対象データを取得）
        ''' </summary>
        ''' <param name="appData">エラー受渡し用AsamaADBase</param>
        ''' <param name="strMessageID">メッセージID</param>
        ''' <remarks></remarks>
        Public Sub New(ByRef appData As AsamaEntities, ByVal strMessageID As String)
            '最初に基本クラスのコンストラクタを呼び出す
            MyBase.New()

            GetData(appData, strMessageID)
        End Sub

        ''' <summary>
        ''' <para>指定条件のデータをAsamaGeneralDataから取得する</para>
        ''' </summary>
        ''' <param name="appData">エラー受渡し用AsamaADBase</param>
        ''' <param name="strMessageID">メッセージID</param>
        ''' <remarks></remarks>
        Private Sub GetData(ByVal appData As AsamaEntities, ByVal strMessageID As String)
            Try

            Catch ex As Exception

            End Try
        End Sub

    End Class
#End Region

End Class
