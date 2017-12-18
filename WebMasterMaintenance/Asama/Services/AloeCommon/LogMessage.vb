Option Strict On
'******************************************************************
'*	システム名	：	メディスカルテ
'*	ファイル名	：	clsLogMessage.vb
'*	概要		：	ログメッセージ出力用クラス
'*
'*	Copyright  (c) 2014-2015 Medis Co., Ltd.
'*
'*	【履歴】
'*　日付	　　担当		Ver.	チケット#	変更理由
'* ----------------------------------------------------------------
'*　2014/08/12	FSI 山口	0.0.1	#XXXXXXXX	新規作成
'******************************************************************


Imports System.IO
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text.RegularExpressions

Public Class LogMessage

#Region "定数"
    Private Const NULL_String As String = Nothing
    Private Const NULL_Integer As Integer = -1
    Private Const NULL_DateTime As DateTime = Nothing
    Private Const NULL_Decimal As Decimal = -1
    Private Const NULL_Boolean As Boolean = Nothing
    Private Const NULL_MAXDATE As Date = #12/31/9999#
    Private Const NULL_MINDATE As Date = #1/1/1800#

    Private Const MESSAGE_TYPE_INFOMATION_TEXT As String = "情報"
    Private Const MESSAGE_TYPE_CONFIRM_TEXT As String = "確認"
    Private Const MESSAGE_TYPE_WARNING_TEXT As String = "警告"
    Private Const MESSAGE_TYPE_ERROR_TEXT As String = "エラー"
    Private Const MESSAGE_TYPE_LOG_MESSAGE_INFO_ERROR_TEXT As String = "ログ・メッセージエラー"

    Private Const MESSAGE_TYPE_INFOMATION As Integer = 64
    Private Const MESSAGE_TYPE_CONFIRM As Integer = 32
    Private Const MESSAGE_TYPE_WARNING As Integer = 48
    Private Const MESSAGE_TYPE_ERROR As Integer = 16

    Private Const LOG_WRITE_MUTEX_NAME As String = "LOG"
#End Region

#Region "Enum定義"
    '取得対象データタイプ
    Public Enum enmTargetType
        ValidData       'ある時点で有効な全データ
        DelData         '現在削除されている全データ→削除データは最新からの復元のため
        LogData         '履歴データ
    End Enum
    '日付タイプ
    Public Enum enmDateType
        NonDate '日付指定なし
        DateOn  '日まで
        TimeOn  '時間まで
    End Enum
    '削除タイプ
    Public Enum enmDelType
        NonDel  'DelFlagなし
        DelOn   '削除データ
        DelOff  '有効データ
    End Enum
    '並び順タイプ
    Public Enum enmOrderType
        Kana    'カナ順
        Code    'Code/ID順
        DayTime '日付順
    End Enum
#End Region

    Private g_LogFilePath As String = ConfigurationManager.AppSettings("LogFilePath")
    Private g_LogLevel As String = ConfigurationManager.AppSettings("LogLevel") 'ADD 20151016 FSI山口 ログレベル取得 #2646

#Region "プロパティ群"

#Region "ログメッセージ情報"
    Private _datLogMessage As LogMessageTbl.LogMessageData
    Protected Friend Property LogMessage() As LogMessageTbl.LogMessageData
        Get
            LogMessage = _datLogMessage
        End Get
        Set(value As LogMessageTbl.LogMessageData)
            _datLogMessage = value
        End Set
    End Property
#End Region

#Region "エラーメッセージ"
    Private _ErrMessage As String
    Protected Friend Property ErrMessage() As String
        Get
            ErrMessage = _ErrMessage
        End Get
        Set(value As String)
            _ErrMessage = value
        End Set
    End Property
#End Region

#Region "フォームID"
    Private _FormID As String
    Protected Friend Property FormID() As String
        Get
            FormID = _FormID
        End Get
        Set(value As String)
            _FormID = value
        End Set
    End Property
#End Region

#Region "メッセージID"
    Private _MessageID As String
    Protected Friend Property MessageID() As String
        Get
            MessageID = _MessageID
        End Get
        Set(value As String)
            _MessageID = value
        End Set
    End Property
#End Region

#Region "ログファイル名"
    Private _LogFileName As String
    Protected Friend Property LogFileName() As String
        Get
            LogFileName = _LogFileName
        End Get
        Set(value As String)
            _LogFileName = value
        End Set
    End Property
#End Region

#Region "メッセージタイトル"
    Private _MessageTitle As String
    Protected Friend Property MessageTitle() As String
        Get
            MessageTitle = _MessageTitle
        End Get
        Set(value As String)
            _MessageTitle = value
        End Set
    End Property
#End Region

#Region "エラー発生場所"
    Private _ErrorOccurrencePosition As String
    Protected Friend Property ErrorOccurrencePosition() As String
        Get
            ErrorOccurrencePosition = _ErrorOccurrencePosition
        End Get
        Set(value As String)
            _ErrorOccurrencePosition = value
        End Set
    End Property
#End Region

#Region "メッセージ本文"
    Private _MessageDetail As String
    Protected Friend Property MessageDetail() As String
        Get
            MessageDetail = _MessageDetail
        End Get
        Set(value As String)
            _MessageDetail = value
        End Set
    End Property
#End Region

#Region "エラー時のメッセージタイトル"
    Private _Error_MessageTitle As String
    Protected Friend Property Error_MessageTitle() As String
        Get
            Error_MessageTitle = _Error_MessageTitle
        End Get
        Set(value As String)
            _Error_MessageTitle = value
        End Set
    End Property
#End Region

#Region "エラー時のメッセージ本文"
    Private _Error_MessageDetail As String
    Protected Friend Property Error_MessageDetail() As String
        Get
            Error_MessageDetail = _Error_MessageDetail
        End Get
        Set(value As String)
            _Error_MessageDetail = value
        End Set
    End Property
#End Region

#Region "HasErrorとHasException"

    Private _HasError As Boolean = False
    Protected Friend Property HasError() As Boolean
        Get
            HasError = _HasError
        End Get
        Set(value As Boolean)
            _HasError = value
        End Set
    End Property

    Private _HasException As Boolean = False
    Protected Friend Property HasException() As Boolean
        Get
            HasException = _HasException
        End Get
        Set(value As Boolean)
            _HasException = value
        End Set
    End Property

#End Region

#End Region

    ''' <summary>
    ''' ログメッセージの出力
    ''' </summary>
    ''' <param name="intReturnValue">返却値</param>
    ''' <param name="msg">エラーメッセージオブジェクト</param>
    ''' <returns>boolean</returns>
    ''' <remarks>
    ''' 概要：　エラーメッセージオブジェクトを元にログメッセージを取得し、ファイルに出力する。
    ''' 【履歴】
    ''' 　日付	　　担当	　　Ver.	チケット#	変更理由
    ''' ----------------------------------------------------------------
    ''' </remarks>
    Public Overloads Function OutputLogMessage(ByRef intReturnValue As Integer, ByVal msg As ErrorMessage) As Integer
        With msg
            Dim rtnResult As Integer = OutputLogMessage(intReturnValue, .FormID, .MessageID, .Title, .RaiseError, .MessageParameter)
            If rtnResult = enmLogMessageReturnType.ExceptionError Then
                OutputLogMessage = enmLogMessageReturnType.ExceptionError
            ElseIf rtnResult = enmLogMessageReturnType.IgnoreError Then
                OutputLogMessage = enmLogMessageReturnType.IgnoreError
            Else
                OutputLogMessage = enmLogMessageReturnType.Successful
            End If
        End With
    End Function

    ''' <summary>
    ''' ログメッセージの出力
    ''' </summary>
    ''' <param name="intReturnValue">返却値</param>
    ''' <param name="strFormID">ログ出力用フォームID</param>
    ''' <param name="strMessageID">ログ出力用メッセージID</param>
    ''' <param name="strMessageTitle">ログ出力用タイトルメッセージ</param>
    ''' <param name="strErrorOccurrencePosition">エラー発生場所</param>
    ''' <param name="arrReplaceString">ログ出力用置き換え文字列</param>
    ''' <param name="strErrMessage">その他のエラーメッセージ(システムエラーメッセージを表示したい場合に指定)</param>
    ''' <returns>boolean</returns>
    ''' <remarks>
    ''' 概要：　メッセージIDをキーにログメッセージを取得し、ファイルに出力する。
    ''' 【履歴】
    ''' 　日付	　　担当	　　Ver.	チケット#	変更理由
    ''' ----------------------------------------------------------------
    ''' </remarks>
    Public Overloads Function OutputLogMessage(ByRef intReturnValue As Integer,
                                               ByVal strFormID As String,
                                               ByVal strMessageID As String,
                                               ByVal strMessageTitle As String,
                                               Optional ByVal strErrorOccurrencePosition As String = Nothing,
                                               Optional ByVal arrReplaceString As ArrayList = Nothing,
                                               Optional ByVal strErrMessage As String = Nothing) As Integer

        OutputLogMessage = enmLogMessageReturnType.ExceptionError

        Try
            'ログレベルが未設定の場合は通常モードで起動
            If IsNothing(g_LogLevel) = True OrElse String.IsNullOrEmpty(g_LogLevel) = True Then
                g_LogLevel = "1"
            End If

            'インスタンス処理
            If NewclsMessage(strFormID,
                             strMessageID,
                             strMessageTitle,
                             strErrorOccurrencePosition,
                             strErrMessage) = False Then
                Exit Function
            End If

            Dim retNum As Integer
            retNum = Me.GetMstMessage(strMessageID)
            If retNum = -1 Then 'データ取得失敗時
                Throw New Exception
            End If
            If retNum = 1 Then  'データ件数が0件時
                Error_MessageDetail = "メッセージマスタにメッセージが存在しません。" & vbCrLf & "メッセージID：" & strMessageID
                Throw New Exception
            End If

            'メッセージ本文設定（改行文字及び置換文字を置換）
            If ReplaceMessageDetail(arrReplaceString) = False Then
                Throw New Exception
            End If

            'メッセージダイアログを表示し、押下されたボタンの戻り値を設定
            If LogMessage.LogLevelForm > 0 Then
                'ADD 20151016 FSI山口 ログレベル設定対応 #2646
                If g_LogLevel = "2" Then
                    If LogMessage.LogLevelForm = 1 Or LogMessage.LogLevelForm = 2 Then
                    End If
                ElseIf g_LogLevel = "1" Then
                    If LogMessage.LogLevelForm = 1 Then
                    End If
                End If
            Else
                intReturnValue = 0
            End If

            'ログメッセージ出力
            If LogMessage.LogLevelFile > 0 Then
                'ADD 20151016 FSI山口 ログレベル設定対応 #2646
                If g_LogLevel = "2" Then
                    If LogMessage.LogLevelFile = 1 Or LogMessage.LogLevelFile = 2 Then
                        If LogMessageOutput() = False Then
                            Throw New Exception
                        End If
                    End If
                ElseIf g_LogLevel = "1" Then
                    If LogMessage.LogLevelFile = 1 Then
                        If LogMessageOutput() = False Then
                            Throw New Exception
                        End If
                    End If
                End If
            End If

            _HasError = False
            OutputLogMessage = enmLogMessageReturnType.Successful

        Catch ex As Exception

            'ログメッセージ出力
            Dim strOutSysDate As New Date
            Dim strMsgText As String = String.Empty
            Dim strMsgParameter As String = String.Empty
            Dim strMyHost As String = String.Empty
            '日付取得
            strOutSysDate = CDate(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"))

            'エラーメッセージ種別取得
            Dim strMessageType As String
            'エラー
            strMessageType = MESSAGE_TYPE_LOG_MESSAGE_INFO_ERROR_TEXT

            'ホスト名取得
            strMyHost = System.Net.Dns.GetHostName

            'メッセージ作成
            strMsgText = strOutSysDate.ToString("yyyy-MM-dd HH:mm:ss.fff") & ","
            strMsgText += strMessageType & ","
            strMsgText += Error_MessageTitle & ","
            strMsgText += Error_MessageDetail

            strMsgParameter += vbCrLf & "[渡された引数]  "
            strMsgParameter += " ・機能名【" & strFormID & "】,"
            strMsgParameter += " ・メッセージID【" & strMessageID & "】,"
            strMsgParameter += " ・メッセージタイトル【" & strMessageTitle & "】,"
            strMsgParameter += " ・エラー発生場所【" & strErrorOccurrencePosition & "】,"
            If Not IsNothing(arrReplaceString) AndAlso arrReplaceString.Count > 0 Then
                For i As Integer = 0 To arrReplaceString.Count - 1
                    If i = 0 Then strMsgParameter += " ・置き換え文字列【"
                    If Not i = 0 Then strMsgParameter += ","
                    strMsgParameter += arrReplaceString.Item(i).ToString
                    If i = arrReplaceString.Count - 1 Then strMsgParameter += "】"
                Next i
            End If
            strMsgParameter += " ・表示したいエラーメッセージ【" & strErrMessage & "】"
            strMsgText += strMsgParameter
            'フォルダの存在確認
            If String.IsNullOrWhiteSpace(g_LogFilePath) Then Exit Function
            If Directory.Exists(g_LogFilePath) = False Then
                Directory.CreateDirectory(g_LogFilePath)
            End If

            'ファイル名設定
            LogFileName = Path.Combine(g_LogFilePath, strMyHost & "_" & strOutSysDate.ToString("yyyyMMdd") & ".log")

            Using file As New FileStream(LogFileName,
                                         FileMode.Append, FileAccess.Write, FileShare.Write)
                Using filOpenWriter As New StreamWriter(file, System.Text.Encoding.GetEncoding("shift_jis"))
                    filOpenWriter.WriteLine(strMsgText)
                End Using
            End Using

            _HasError = True
            _HasException = True

        End Try

    End Function

    ''' <summary>
    ''' インスタンス作成と初期値設定 
    ''' </summary>
    ''' <param name="strFormID">ログ出力用フォームID</param>
    ''' <param name="strMessageID">ログ出力用メッセージID</param>
    ''' <param name="strMessageTitle">ログ出力用タイトルメッセージ</param>
    ''' <param name="strErrorOccurrencePosition">ログ出力用エラー発生場所</param>
    ''' <param name="strErrMessage">ログ出力用エラーメッセージ</param>
    ''' <remarks>
    ''' 概要：　クラス変数等のインスタンス処理を行う。
    ''' 【履歴】
    ''' 　日付	　　担当	　　Ver.	チケット#	変更理由
    ''' ----------------------------------------------------------------
    ''' </remarks>
    Private Function NewclsMessage(ByVal strFormID As String,
                                   ByVal strMessageID As String,
                                   ByVal strMessageTitle As String,
                                   Optional ByVal strErrorOccurrencePosition As String = Nothing,
                                   Optional ByVal strErrMessage As String = Nothing) As Boolean

        NewclsMessage = False

        Try
            FormID = strFormID
            MessageID = strMessageID
            MessageTitle = strMessageTitle
            If String.IsNullOrEmpty(strErrorOccurrencePosition) = False Then
                ErrorOccurrencePosition = strErrorOccurrencePosition.Replace(vbCrLf, " ")
            End If
            If String.IsNullOrEmpty(strErrMessage) = False Then
                ErrMessage = strErrMessage
            End If

            NewclsMessage = True

        Catch ex As Exception

            Error_MessageTitle = "インスタンス作成と初期値設定"
            Error_MessageDetail = String.Concat("インスタンス作成と初期値設定処理でエラーが発生しました。管理者へ問い合わせしてください。" & vbCrLf) &
                                                  String.Concat("--------------------▼以下、エラー内容▼----------------------" & vbCrLf) &
                                                  String.Concat(ex.ToString)
            _HasError = True
            _HasException = True
            Exit Function

        End Try

    End Function

    ''' <summary>
    ''' メッセージ取得処理 
    ''' </summary>
    ''' <returns>boolean</returns>
    ''' <remarks>
    ''' 概要：　メッセージIDをキーにメッセージマスタテーブルよりメッセージを取得する。
    ''' 【履歴】
    ''' 　日付	　　担当	　　Ver.	チケット#	変更理由
    ''' ----------------------------------------------------------------
    ''' </remarks>
    Private Function GetMstMessage(ByVal strMessageID As String) As Short

        GetMstMessage = 0

        Try
            Dim clsAsamaADBase As New AsamaEntities
            Dim clsLogData As New LogMessageTbl.LogMessageData(clsAsamaADBase, strMessageID)
            If clsLogData.HasData = True Then
                LogMessage = clsLogData
            Else
                GetMstMessage = 1
            End If

        Catch ex As Exception

            Error_MessageTitle = "メッセージ取得処理"
            Error_MessageDetail = String.Concat("メッセージ取得処理でエラーが発生しました。管理者へ問い合わせしてください。" & vbCrLf) &
                                                String.Concat("--------------------▼以下、エラー内容▼----------------------" & vbCrLf) &
                                                String.Concat(ex.ToString)
            GetMstMessage = -1
            Exit Function

        End Try

    End Function

    ''' <summary>
    ''' メッセージ本文置換処理 
    ''' </summary>
    ''' <param name="arrReplaceString">arrReplaceString</param>
    ''' <returns>boolean</returns>
    ''' <remarks>
    ''' 概要：　改行文字と置換文字を置換し、表示するメッセージ内容を作成する。
    ''' 【履歴】
    ''' 　日付	　　担当	　　Ver.	チケット#	変更理由
    ''' ----------------------------------------------------------------
    ''' </remarks>
    Private Function ReplaceMessageDetail(ByVal arrReplaceString As ArrayList) As Boolean

        ReplaceMessageDetail = False

        Try

            '改行マークを置換
            LogMessage.MessageDetail =
                LogMessage.MessageDetail.ToString.Replace("\n", vbCrLf)

            'メッセージテキスト
            Dim strMessageDetail As String = LogMessage.MessageDetail

            '置換文字列正規表現
            Dim pattern As String = "\[[0-9]+\]"
            '引数の置換文字列から置換するのではなく、メッセージ内容の置換文字列分全て処理するように修正。
            For Each match As Match In Regex.Matches(strMessageDetail, pattern)
                '文字列置換
                Dim arrayindex As Integer = CInt(Regex.Match(match.Value, "[0-9]+").Value)
                If arrReplaceString Is Nothing OrElse (arrReplaceString.Count - 1) < arrayindex OrElse arrReplaceString(arrayindex) Is Nothing Then
                    strMessageDetail = strMessageDetail.Replace(match.Value, String.Empty)
                Else
                    strMessageDetail = strMessageDetail.Replace(match.Value, arrReplaceString(arrayindex).ToString)
                End If
            Next
            LogMessage.MessageDetail = strMessageDetail

            ReplaceMessageDetail = True

        Catch ex As Exception

            Error_MessageTitle = "メッセージ本文置換処理"
            Error_MessageDetail = String.Concat("メッセージ本文置換処理でエラーが発生しました。管理者へ問い合わせしてください。" & vbCrLf) &
                                                String.Concat("--------------------▼以下、エラー内容▼----------------------" & vbCrLf) &
                                                String.Concat(ex.ToString)
            _HasError = True
            _HasException = True
            Exit Function

        End Try

    End Function

    ''' <summary>
    ''' ログメッセージ出力処理 
    ''' </summary>
    ''' <returns>boolean</returns>
    ''' <remarks>
    ''' 概要：　ログメッセージを出力する。
    ''' 【履歴】
    ''' 　日付	　　担当	　　Ver.	チケット#	変更理由
    ''' ----------------------------------------------------------------
    ''' </remarks>
    Public Function LogMessageOutput() As Boolean

        LogMessageOutput = False

        Dim strOutSysDate As Date
        Dim strMyHost As String
        Dim strMsgText As String

        Try

            '日付取得
            strOutSysDate = CDate(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"))

            'エラーメッセージ種別取得
            Dim strMessageType As String
            If LogMessage Is Nothing Then LogMessage = New LogMessageTbl.LogMessageData
            If LogMessage.MessageIcon = MESSAGE_TYPE_INFOMATION Then  '情報
                strMessageType = MESSAGE_TYPE_INFOMATION_TEXT
            ElseIf LogMessage.MessageIcon = MESSAGE_TYPE_CONFIRM Then '確認
                strMessageType = MESSAGE_TYPE_CONFIRM_TEXT
            ElseIf LogMessage.MessageIcon = MESSAGE_TYPE_WARNING Then '警告
                strMessageType = MESSAGE_TYPE_WARNING_TEXT
            Else                                                      'エラー
                strMessageType = MESSAGE_TYPE_ERROR_TEXT
            End If

            'ホスト名取得
            strMyHost = System.Net.Dns.GetHostName

            'メッセージ作成
            strMsgText = strOutSysDate.ToString("yyyy-MM-dd HH:mm:ss.fff") & ","
            strMsgText += strMessageType & ","
            strMsgText += FormID & ","
            strMsgText += MessageID & ","
            strMsgText += MessageTitle & ","
            strMsgText += ErrorOccurrencePosition & ","
            strMsgText += LogMessage.MessageDetail & ","
            strMsgText += ErrMessage

            'フォルダの存在確認
            If Directory.Exists(g_LogFilePath) = False Then
                Directory.CreateDirectory(g_LogFilePath)
            End If

            'ファイル名設定
            LogFileName = Path.Combine(g_LogFilePath, strMyHost & "_" & strOutSysDate.ToString("yyyyMMdd") & ".log")

            Try
IOError:
                System.Threading.Monitor.Enter(Me)

                Using file As New FileStream(LogFileName,
                                             FileMode.Append, FileAccess.Write, FileShare.Write)
                    Using filOpenWriter As New StreamWriter(file, System.Text.Encoding.GetEncoding("shift_jis"))
                        filOpenWriter.WriteLine(strMsgText)
                    End Using
                End Using
                'End Using
            Catch ex As IOException
                GoTo IOError
            End Try

            LogMessageOutput = True

        Catch ex As Exception

            Error_MessageTitle = "ログファイル出力処理"
            Error_MessageDetail = String.Concat("ログファイル出力処理でエラーが発生しました。管理者へ問い合わせしてください。" & vbCrLf) &
                                                String.Concat("--------------------▼以下、エラー内容▼----------------------" & vbCrLf) &
                                                String.Concat(ex.ToString)
            _HasError = True
            _HasException = True
            Exit Function

        End Try

    End Function

    ''' <summary>
    ''' NULLデータチェック
    ''' </summary>
    ''' <param name="objData">チェック対象データオブジェクト</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Friend Function CheckNull(ByVal objData As Object) As Boolean

        Try
            'String
            If TypeOf objData Is String Then
                If CType(objData, String) = NULL_String Then
                    Return True
                Else
                    Return False
                End If
            End If
            'Integer
            If TypeOf objData Is Integer Then
                If CType(objData, Integer) = NULL_Integer Then
                    Return True
                Else
                    Return False
                End If
            End If
            'DateTime
            If TypeOf objData Is DateTime Then
                If CType(objData, DateTime) = NULL_DateTime Then
                    Return True
                Else
                    Return False
                End If
            End If
            'Decimal
            If TypeOf objData Is Decimal Then
                If CType(objData, Decimal) = NULL_Decimal Then
                    Return True
                Else
                    Return False
                End If
            End If
            'Boolean
            If TypeOf objData Is Boolean Then
                If CType(objData, Boolean) = NULL_Boolean Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Error_MessageTitle = "NULLデータチェック"
            Error_MessageDetail = String.Concat("NULLデータチェックでエラーが発生しました。管理者へ問い合わせしてください。" & vbCrLf) &
                                                String.Concat("--------------------▼以下、エラー内容▼----------------------" & vbCrLf) &
                                                String.Concat(ex.ToString)
            _HasError = True
            _HasException = True
        End Try
        Return True
    End Function

End Class
