Public Class Message

    ''' <summary>
    ''' 必須入力エラー
    ''' </summary>
    Public Shared ReadOnly MSG_REQUIRED As String = "{0}を入力して下さい。"

    ''' <summary>
    '''削除しました。
    ''' </summary>
    Public Shared ReadOnly MSG_DELETED As String = "削除しました。"

    ''' <summary>
    '''検索結果が０件です。"
    ''' </summary>
    Public Shared ReadOnly MSG_SELECTED As String = "検索結果が{0}件です。"

    ''' <summary>
    ''' ホットコード重複エラー
    ''' </summary>
    Public Shared ReadOnly MSG_HOTCORD As String = "選択したHOTコード{0}が重複しています。同一HOTコードは複数登録できません。"

    ''' <summary>
    ''' 終了日には、開始日以降の日付を指定してください。
    ''' </summary>
    Public Shared ReadOnly MSG_20000035 As String = "終了日には、開始日以降の日付を指定してください。"

    ''' <summary>
    ''' 有効期限が重複しています。
    ''' </summary>
    Public Shared ReadOnly MSG_DUPLICATE_VALIDDATE As String = "有効期限が重複しています。先に有効期限終了日を確認してください。"

    ''' <summary>
    ''' カルテで使用されているため、開始日は登録開始日以降への変更はできません。
    ''' </summary>
    Public Shared ReadOnly MSG_BEFORE_VALIDDATE_FROM As String = "カルテで使用されているため、開始日は登録開始日 {0} 以降への変更はできません。"

    ''' <summary>
    ''' 開始日は登録開始日以降への変更はできません。
    ''' </summary>
    Public Shared ReadOnly MSG_BEFORE_VALIDDATE_TO As String = "終了日は本日 {0} 以前への変更はできません。"

    ''' <summary>
    ''' カルテで使用されているため、削除できません。
    ''' </summary>
    Public Shared ReadOnly MSG_KARTE_USED As String = "カルテで使用されているため、削除できません。"

    ''' <summary>
    ''' （途中履歴）は、削除できません。
    ''' </summary>
    Public Shared ReadOnly MSG_NODELETE_LOG As String = "（途中履歴）は、削除できません。"

    ''' <summary>
    ''' 単位が重複しています。
    ''' </summary>
    Public Shared ReadOnly MSG_DUPLICATE_UNIT As String = "単位が重複しています。"

End Class
