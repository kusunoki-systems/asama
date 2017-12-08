'******************************************************************
'*	システム名	：	Aloe
'*	ファイル名	：	modAloeConst
'*	概要		：	Aloeで使用する定数値を定義します。
'*
'*	Copyright  (c) 2014-2015 Medis Co., Ltd.
'*
'******************************************************************


''' <summary>
''' Aloe 共通定数
''' </summary>
''' <remarks>
''' <para>【履歴】</para>
''' <para>2017年08月時点のConstを移植</para>
''' </remarks>
Public Module AloeConst

#Region "DB接続"
    ''' <summary>DB接続文字列</summary>
    Public Const ConnectionString As String = "AloeConnectionString"
#End Region

#Region "DB無効値"
    ''' <summary>DB無効値・文字列</summary>
    Public Const UndefString As String = ""
    ''' <summary>DB無効値・Integer最小値</summary>
    Public Const UndefIntegerMin As Integer = -99999999
    ''' <summary>DB無効値・Integer最大値</summary>
    Public Const UndefIntegerMax As Integer = 99999999
    ''' <summary>DB無効値・Decimal</summary>
    Public Const UndefDecimal As Decimal = -1
    ''' <summary>DB無効値・min日付</summary>
    Public Const UndefDateMin As DateTime = #1/1/1900#
    ''' <summary>DB無効値・MAX日付</summary>
    Public Const UndefDateMax As DateTime = #12/31/2900#
#End Region

#Region "固定値"
    ''' <summary>開始時刻（00:00:00）</summary>
    Public Const DateTimeStart As String = "00:00:00"
    ''' <summary>最終時刻（23:59:59）</summary>
    Public Const DateTimeLast As String = "23:59:59"
    ''' <summary>最終時刻（23:59:59）</summary>
    Public Const OIDTitle As String = "【OID】"
    ''' <summary>開始時刻2（00:00）</summary>
    Public Const DateTimeStart2 As String = "00:00"
    ''' <summary>最終時刻2（23:59）</summary>
    Public Const DateTimeLast2 As String = "23:59"
    ''' <summary>最大時刻（99:99）</summary>
    Public Const DateTimeMax As String = "99:99"
    ''' <summary>フリー文字</summary>
    Public Const DateTimeFree As String = "ﾌﾘｰ"
#End Region

#Region "フォーマット"
    ''' <summary>フォーマット・日付</summary>
    Public Const FormatDateString As String = "yyyy/MM/dd"
    ''' <summary>フォーマット・日付（西暦下2桁表示）</summary>
    Public Const FormatDateShortString As String = "yy/MM/dd"
    ''' <summary>フォーマット・日付（スラッシュなし）</summary>
    Public Const FormatDateTimeNoMarkString As String = "yyyyMMdd"
    ''' <summary>フォーマット・日付　年月日＆時分</summary>
    Public Const FormatDateTimeString As String = "yyyy/MM/dd HH:mm"
    ''' <summary>フォーマット・日付　年月日＆時分秒</summary>
    Public Const FormatDateTimeSecondString As String = "yyyy/MM/dd HH:mm:ss"
    ''' <summary>フォーマット・年月（漢字）</summary>
    Public Const FormatYearMonthString_JP As String = "yyyy年M月"
    ''' <summary>フォーマット・年（西暦年）</summary>
    Public Const FormatYearString As String = "yyyy年"
    ''' <summary>フォーマット・曜日（曜）</summary>
    Public Const FormatDayofWeek As String = "（ddd）"
    ''' <summary>フォーマット・時刻</summary>
    Public Const FormatTimeString As String = "HH:mm"
    ''' <summary>フォーマット・日付日時</summary>
    Public Const FormatCreateDateTimeString As String = "作成日時 yyyy/MM/dd HH:mm"
#End Region

#Region "AloeGeneraDataキー"
    ''' <summary>AloeGeneraDataキー・クライアントマシン名</summary>
    Public Const ClientID As String = "ClientID"
    '''' <summary>AloeGeneraDataキー・施設ID</summary>
    'Public Const FacilityID As String = "FacilityID"
    ''' <summary>AloeGeneraDataキー・ログイン者職員情報</summary>
    Public Const LoginStaffInfo As String = "LoginStaffInfo"
    ''' <summary>AloeGeneraDataキー・代行職員情報</summary>
    Public Const DeputyStaffInfo As String = "DeputyStaffInfo"
    ''' <summary>AloeGeneraDataキー・患者表示情報</summary>
    Public Const PatientDispInfo As String = "PatientDispInfo"
    ''' <summary>AloeGeneraDataキー・患者モード情報</summary>
    Public Const PatientModeInfo As String = "PatientModeInfo"
    ''' <summary>AloeGeneraDataキー・機能情報</summary>
    Public Const FunctionInfo As String = "FunctionInfo"
#End Region

#Region "Const文字"
    ''' <summary>再表示呼び出し文字列</summary>
    Public Const RedrawCall As String = "RedrawCall"
    ''' <summary>オーダデータ受け取り確認</summary>
    Public Const ReceiveConfirmOrderData As String = "ReceiveConfirmOrderData"

    Public Const StaffID As String = "StaffID"
    Public Const LastName As String = "LastName"
    Public Const MiddleName As String = "MiddleName"
    Public Const FirstName As String = "FirstName"
    Public Const KanaLastName As String = "KanaLastName"
    Public Const KanaMiddleName As String = "KanaMiddleName"
    Public Const KanaFirstName As String = "KanaFirstName"
    Public Const JobCode As String = "JobCode"
    Public Const LicenseClass As String = "LicenseClass"
    Public Const LicenseNo As String = "LicenseNo"
    Public Const SexType As String = "SexType"
    Public Const RetireDate As String = "RitireDate"
    Public Const EnterDate As String = "EnterDate"
    Public Const DepartmentCode As String = "DepartmentCode"
    Public Const BirthDate As String = "BirthDate"
    Public Const DeputyStaffID As String = "LoginID"
    Public Const DeputyJobCode As String = "WorkCode"
    Public Const Authority As String = "Authority"
    Public Const PatientBase As String = "PatientBase"
    Public Const GroupCode As String = "GroupCode"

    ''' <summary>表示用患者IDの名称</summary>
    Public Const DisplayPatientID As String = "患者ID"
    ''' <summary>状態表示値：中止（旧：削除）</summary>
    Public Const OrderStatusCancel As String = "中止"
    ''' <summary>状態表示値：途中中止</summary>
    Public Const OrderStatusStop As String = "途中中止"
    ''' <summary>状態表示値：新規</summary>
    Public Const OrderStatusNew As String = "新規"
    ''' <summary>状態表示値：修正</summary>
    Public Const OrderStatusEdit As String = "修正"
    ''' <summary>状態表示値：修正</summary>
    Public Const OrderStatusEditStop As String = "修正(途中中止)"
    ''' <summary>ダミーオーダID</summary>
    Public Const DummyOrderId As String = "------------"

    ''' <summary>予約時刻未確定</summary>
    Public Const ReserveTimeUnspecified As String = "未指定"
    ''' <summary>レポートの改ページ時の出力文字</summary>
    Public Const STRING_PAGE_BREAK As String = "－－－次ページあり－－－"
    ''' <summary>レポートの最終行の出力文字</summary>
    Public Const STRING_PAGE_END As String = "－－－　以下余白　－－－"
    ''' <summary>修正前オーダID</summary>
    Public Const BeforeOrderIdTitle As String = "【修正前OID】"
#End Region

#Region "登録用オーダ詳細辞書のキー"
    '必須
    Public Const RP As String = "RP"
    Public Const RPRecNo As String = "RPRecNo"
    Public Const RecNo As String = "RecNo"
    Public Const Class1 As String = "Class1"
    Public Const Class2 As String = "Class2"
    Public Const Class3 As String = "Class3"
    Public Const Record As String = "Record"
    Public Const Dosage As String = "Dosage"
    Public Const Unit As String = "Unit"
    Public Const OrderID As String = "OrderID"
    Public Const OrderType As String = "OrderType"
    Public Const DelFlag As String = "DelFlag"
    Public Const InvalidFlag As String = "InvalidFlag"
    Public Const PatientID As String = "PatientID"
    Public Const TargetDate As String = "TargetDate"

#End Region

#Region "オーダ一覧表示取得用のキー"

#Region "オーダ基本情報のキー"
    Public Const OrderBase_FacilityID As String = "FacilityID"
    Public Const OrderBase_OrderID As String = "OrderID"
    Public Const OrderBase_UpdateDate As String = "UpdateDate"
    Public Const OrderBase_UpdateStaffID As String = "UpdateStaffID"
    Public Const OrderBase_UpdateJobCode As String = "UpdateJobCode"
    Public Const OrderBase_DeputyStaffID As String = "DeputyStaffID"
    Public Const OrderBase_DeputyJobCode As String = "DeputyJobCode"
    Public Const OrderBase_AdmitDate As String = "AdmitDate"
    Public Const OrderBase_AdmitStaffID As String = "AdmitStaffID"
    Public Const OrderBase_AdmitJobCode As String = "AdmitJobCode"
    Public Const OrderBase_DelFlag As String = "DelFlag"
    Public Const OrderBase_PatientID As String = "PatientID"
    Public Const OrderBase_HistoryRecNo As String = "HistoryRecNo"
    Public Const OrderBase_DepartmentCode As String = "DepartmentCode"
    Public Const OrderBase_InsuranceType As String = "InsuranceType"
    Public Const OrderBase_OrderStatusClass As String = "OrderStatusClass"
    Public Const OrderBase_OrderType As String = "OrderType"
    Public Const OrderBase_OrderDate As String = "OrderDate"
    Public Const OrderBase_ValidDateFrom As String = "ValidDateFrom"
    Public Const OrderBase_ValidDateTo As String = "ValidDateTo"
    Public Const OrderBase_InitDateFrom As String = "InitDateFrom"
    Public Const OrderBase_InitDateTo As String = "InitDateTo"
    Public Const OrderBase_ScheduleDateFrom As String = "ScheduleDateFrom"
    Public Const OrderBase_ScheduleDateTo As String = "ScheduleDateTo"
    Public Const OrderBase_InvalidFlag As String = "InvalidFlag"
    Public Const OrderBase_TemporaryClass As String = "TemporaryClass"
    Public Const OrderBase_EmergencyClass As String = "EmergencyClass"
    Public Const OrderBase_ExecutionFlag As String = "ExecutionFlag"
    Public Const OrderBase_QualificationFlag As String = "QualificationFlag"
    Public Const OrderBase_Qualification As String = "Qualification"
    Public Const OrderBase_AtHomeFlag As String = "AtHomeFlag"
    Public Const OrderBase_OrderFamily As String = "OrderFamily"
    Public Const OrderBase_OrderSummary As String = "OrderSummary"
    Public Const OrderBase_OrderComment As String = "OrderComment"
    Public Const OrderBase_ProblemNo As String = "ProblemNo"
    Public Const OrderBase_CancelReason As String = "CancelReason"
#End Region

#Region "オーダ詳細情報のキー"
    Public Const OrderDetail_FacilityID As String = "FacilityID"
    Public Const OrderDetail_OrderID As String = "OrderID"
    Public Const OrderDetail_RecNo As String = "RecNo"
    Public Const OrderDetail_UpdateDate As String = "UpdateDate"
    Public Const OrderDetail_UpdateStaffID As String = "UpdateStaffID"
    Public Const OrderDetail_UpdateJobCode As String = "UpdateJobCode"
    Public Const OrderDetail_DelFlag As String = "DelFlag"
    Public Const OrderDetail_ValidDateFrom As String = "ValidDateFrom"
    Public Const OrderDetail_ValidDateTo As String = "ValidDateTo"
    Public Const OrderDetail_InvalidFlag As String = "InvalidFlag"
    Public Const OrderDetail_PatientID As String = "PatientID"
    Public Const OrderDetail_RP As String = "RP"
    Public Const OrderDetail_RPRecNo As String = "RPRecNo"
    Public Const OrderDetail_OrderType As String = "OrderType"
    Public Const OrderDetail_Class1 As String = "Class1"
    Public Const OrderDetail_Class2 As String = "Class2"
    Public Const OrderDetail_Class3 As String = "Class3"
    Public Const OrderDetail_Record As String = "Record"
    Public Const OrderDetail_Dosage As String = "Dosage"
    Public Const OrderDetail_UnitCode As String = "UnitCode"
#End Region

#Region "オーダ受け情報のキー"
    Public Const OrderAccept_FacilityID As String = "FacilityID"
    Public Const OrderAccept_OrderID As String = "OrderID"
    Public Const OrderAccept_JobCode As String = "JobCode"
    Public Const OrderAccept_RecNo As String = "RecNo"
    Public Const OrderAccept_UpdateDate As String = "UpdateDate"
    Public Const OrderAccept_UpdateStaffID As String = "UpdateStaffID"
    Public Const OrderAccept_UpdateJobCode As String = "UpdateJobCode"
    Public Const OrderAccept_DeputyStaffID As String = "DeputyStaffID"
    Public Const OrderAccept_DeputyJobCode As String = "DeputyJobCode"
    Public Const OrderAccept_AdmitDate As String = "AdmitDate"
    Public Const OrderAccept_AdmitStaffID As String = "AdmitStaffID"
    Public Const OrderAccept_AdmitJobCode As String = "AdmitJobCode"
    Public Const OrderAccept_DelFlag As String = "DelFlag"
    Public Const OrderAccept_OrderType As String = "OrderType"
    Public Const OrderAccept_ScheduleDateFrom As String = "ScheduleDateFrom"
    Public Const OrderAccept_ScheduleDateTo As String = "ScheduleDateTo"
    Public Const OrderAccept_AcceptClass As String = "AcceptClass"
    Public Const OrderAccept_AcceptDate As String = "AcceptDate"
    Public Const OrderAccept_AcceptComment As String = "AcceptComment"
#End Region

#Region "オーダ予定実績情報のキー"
    Public Const OrderSchedule_FacilityID As String = "FacilityID"
    Public Const OrderSchedule_OrderID As String = "OrderID"
    Public Const OrderSchedule_JobCode As String = "JobCode"
    Public Const OrderSchedule_DetailNo As String = "DetailNo"
    Public Const OrderSchedule_RecNo As String = "RecNo"
    Public Const OrderSchedule_UpdateDate As String = "UpdateDate"
    Public Const OrderSchedule_UpdateStaffID As String = "UpdateStaffID"
    Public Const OrderSchedule_UpdateJobCode As String = "UpdateJobCode"
    Public Const OrderSchedule_DeputyStaffID As String = "DeputyStaffID"
    Public Const OrderSchedule_DeputyJobCode As String = "DeputyJobCode"
    Public Const OrderSchedule_AdmitDate As String = "AdmitDate"
    Public Const OrderSchedule_AdmitStaffID As String = "AdmitStaffID"
    Public Const OrderSchedule_AdmitJobCode As String = "AdmitJobCode"
    Public Const OrderSchedule_DelFlag As String = "DelFlag"
    Public Const OrderSchedule_PatientID As String = "PatientID"
    Public Const OrderSchedule_HistoryRecNo As String = "HistoryRecNo"
    Public Const OrderSchedule_OrderType As String = "OrderType"
    Public Const OrderSchedule_RunConfirmClass As String = "RunConfirmClass"
    Public Const OrderSchedule_RecordStateClass As String = "RecordStateClass"
    Public Const OrderSchedule_ScheduleDateFrom As String = "ScheduleDateFrom"
    Public Const OrderSchedule_ScheduleDateTo As String = "ScheduleDateTo"
    Public Const OrderSchedule_ScheduleInterval As String = "ScheduleInterval"
    Public Const OrderSchedule_ScheduleTime As String = "ScheduleTime"
    Public Const OrderSchedule_DisplayTime As String = "DisplayTime"
    Public Const OrderSchedule_ReserveDateFrom As String = "ReserveDateFrom"
    Public Const OrderSchedule_ReserveDateTo As String = "ReserveDateTo"
    Public Const OrderSchedule_ChargeStaffID As String = "ChargeStaffID"
    Public Const OrderSchedule_RunClass As String = "RunClass"
    Public Const OrderSchedule_RunDate As String = "RunDate"
    Public Const OrderSchedule_RunComment As String = "RunComment"
#End Region

#Region "オーダ発行情報のキー"
    Public Const OrderPublish_FacilityID As String = "FacilityID"
    Public Const OrderPublish_OrderID As String = "OrderID"
    Public Const OrderPublish_RecNo As String = "RecNo"
    Public Const OrderPublish_UpdateDate As String = "UpdateDate"
    Public Const OrderPublish_UpdateStaffID As String = "UpdateStaffID"
    Public Const OrderPublish_UpdateJobCode As String = "UpdateJobCode"
    Public Const OrderPublish_DelFlag As String = "DelFlag"
    Public Const OrderPublish_OrderType As String = "OrderType"
    Public Const OrderPublish_OrderActionClass As String = "OrderActionClass"
    Public Const OrderPublish_OrderStatusClass As String = "OrderStatusClass"
    Public Const OrderPublish_PublishStaffID As String = "PublishStaffID"
    Public Const OrderPublish_PublishDate As String = "PublishDate"
    Public Const OrderPublish_TargetOrderID As String = "TargetOrderID"
#End Region

#End Region

#Region "オーダ詳細情報の区分"
#Region "オーダ基本情報"
    Public Const OrderExecDate As String = "000018000"               '実施日数
#End Region
#Region "RP基本情報"
    Public Const RPStartDate As String = "100100000"                 'RP開始日
    Public Const RPStartTime As String = "100200000"                 'RP開始時刻
    Public Const RPStartTiming As String = "100300000"               'RP開始タイミング
    Public Const RPEndTiming As String = "100300001"                 'RP終了タイミング
    Public Const RPExecDate As String = "100400000"                  'RP実施日数
    Public Const RPEndDate As String = "100401000"                   'RP終了日
    Public Const DoseDateTimes As String = "100420000"               '服用日数
    Public Const ExecSpan As String = "100500000"                    'RP実施間隔
    Public Const ExecSpanString As String = "100501000"              '実施間隔文字列
    Public Const UsageCode As String = "100600000"                   'RP用法
    Public Const OneDayTimes As String = "100600001"                 '1日回数
    Public Const UsageClass As String = "100600002"                  '用法種別
    Public Const UsageBeforeAfterMealClass As String = "100600003"   '食事前後区分
    Public Const UsageTimeClass As String = "100600004"              '用法時間区分
    Public Const UsageSelectTime As String = "100600005"             '用法時間指定
    Public Const UsageInsulinUnitNum As String = "100600006"         'インスリン指定単位数
    Public Const UsageSingleDose As String = "100600020"             '頓用指示指定
    Public Const UsageSingleDoseValue As String = "100600021"        '頓用指示設定値
    Public Const UsageExternalRegion As String = "100600022"         '外用部位
    Public Const UsageExternalRegionValue As String = "100600023"    '外用部位設定値
    Public Const UsageExternalUsage As String = "100600024"          '外用使用法
    Public Const UsageExternalUsageValue As String = "100600025"     '外用使用法設定値
    Public Const UsageInsulinRegion As String = "100600026"          'インスリン部位
    Public Const UsageInsulinRegionValue As String = "100600027"     'インスリン部位設定値
    Public Const UsageInsulinScale As String = "100600028"           'インスリンスケール
    Public Const UsageString As String = "100600029"                 '用法文字列
    Public Const UsageTermString As String = "100600030"             '期間文字列
    Public Const ExecScheduleTime As String = "100601000"            '実施予定時間
    Public Const DisplayExecScheduleTime As String = "100601001"     '表示実施予定時間
    Public Const JointDoseTimeCount As String = "100602000"          'つなぎ処方回数
    Public Const UsageComment As String = "100800000"                'RPコメント
#End Region
#End Region

#Region "オーダセット詳細のキー"
    Public Const OrderSet_SetID As String = "SetID"
    Public Const OrderSet_RecNo As String = "RecNo"
    Public Const OrderSet_UpdateDate As String = "UpdateDate"
    Public Const OrderSet_DelFlag As String = "DelFlag"
    Public Const OrderSet_InvalidFlag As String = "InvalidFlag"
    Public Const OrderSet_RP As String = "RP"
    Public Const OrderSet_RPRecNo As String = "RPRecNo"
    Public Const OrderSet_OrderType As String = "OrderType"
    Public Const OrderSet_Class1 As String = "Class1"
    Public Const OrderSet_Class2 As String = "Class2"
    Public Const OrderSet_Class3 As String = "Class3"
    Public Const OrderSet_Record As String = "Record"
    Public Const OrderSet_Dosage As String = "Dosage"
    Public Const OrderSet_UnitCode As String = "UnitCode"

#End Region

#Region "オーダ伝票関連のキー"

#Region "オーダ伝票カテゴリのキー"
    Public Const OrderSlipCategory_OrderType As String = "OrderType"
    Public Const OrderSlipCategory_CategoryCode As String = "CategoryCode"
    Public Const OrderSlipCategory_CategoryName As String = "CategoryName"
    Public Const OrderSlipCategory_Comment As String = "Comment"
#End Region

#Region "オーダ伝票基本のキー"
    Public Const OrderSlipBase_OrderType As String = "OrderType"
    Public Const OrderSlipBase_SlipCode As String = "SlipCode"
    Public Const OrderSlipBase_CategoryCode As String = "CategoryCode"
    Public Const OrderSlipBase_SlipName As String = "SlipName"
    Public Const OrderSlipBase_Comment As String = "Comment"
#End Region

#Region "オーダ伝票詳細のキー"
    Public Const OrderSlipDetail_OrderType As String = "OrderType"
    Public Const OrderSlipDetail_SlipCode As String = "SlipCode"
    Public Const OrderSlipDetail_RecNo As String = "RecNo"
    Public Const OrderSlipDetail_Class1 As String = "Class1"
    Public Const OrderSlipDetail_Class2 As String = "Class2"
    Public Const OrderSlipDetail_Class3 As String = "Class3"
    Public Const OrderSlipDetail_Record As String = "Record"
    Public Const OrderSlipDetail_Dosage As String = "Dosage"
    Public Const OrderSlipDetail_UnitCode As String = "UnitCode"
#End Region

#End Region

#Region "画像実施記録関連のキー"

#Region "画像実施記録基本情報のキー"
    Public Const RadiationRecordBase_FacilityID As String = "FacilityID"
    Public Const RadiationRecordBase_RadiationNo As String = "RadiationNo"
    Public Const RadiationRecordBase_UpdateDate As String = "UpdateDate"
    Public Const RadiationRecordBase_UpdateStaffID As String = "UpdateStaffID"
    Public Const RadiationRecordBase_UpdateJobCode As String = "UpdateJobCode"
    Public Const RadiationRecordBase_DeputyStaffID As String = "DeputyStaffID"
    Public Const RadiationRecordBase_DeputyJobCode As String = "DeputyJobCode"
    Public Const RadiationRecordBase_AdmitDate As String = "AdmitDate"
    Public Const RadiationRecordBase_AdmitStaffID As String = "AdmitStaffID"
    Public Const RadiationRecordBase_AdmitJobCode As String = "AdmitJobCode"
    Public Const RadiationRecordBase_DelFlag As String = "DelFlag"
    Public Const RadiationRecordBase_RecordDate As String = "RecordDate"
    Public Const RadiationRecordBase_KeyType As String = "KeyType"
    Public Const RadiationRecordBase_KeyCode1 As String = "KeyCode1"
    Public Const RadiationRecordBase_KeyCode2 As String = "KeyCode2"
    Public Const RadiationRecordBase_KeyCode3 As String = "KeyCode3"
    Public Const RadiationRecordBase_ClassCode As String = "ClassCode"
    Public Const RadiationRecordBase_TechniqueCode1 As String = "TechniqueCode1"
    Public Const RadiationRecordBase_TechniqueCode2 As String = "TechniqueCode2"
    Public Const RadiationRecordBase_TechniqueCode3 As String = "TechniqueCode3"
    Public Const RadiationRecordBase_ModalityCode As String = "ModalityCode"
    Public Const RadiationRecordBase_Comment As String = "Comment"
#End Region

#Region "画像実施記録明細情報のキー"
    Public Const RadiationRecordDetail_FacilityID As String = "FacilityID"
    Public Const RadiationRecordDetail_RadiationNo As String = "RadiationNo"
    Public Const RadiationRecordDetail_RecNo As String = "RecNo"
    Public Const RadiationRecordDetail_UpdateDate As String = "UpdateDate"
    Public Const RadiationRecordDetail_UpdateStaffID As String = "UpdateStaffID"
    Public Const RadiationRecordDetail_UpdateJobCode As String = "UpdateJobCode"
    Public Const RadiationRecordDetail_DelFlag As String = "DelFlag"
    Public Const RadiationRecordDetail_CategoryPartsCode As String = "CategoryPartsCode"
    Public Const RadiationRecordDetail_DetailPartsCode As String = "DetailPartsCode"
    Public Const RadiationRecordDetail_LeftRightCode As String = "LeftRightCode"
    Public Const RadiationRecordDetail_PositionCode As String = "PositionCode"
    Public Const RadiationRecordDetail_ShotAngleCode As String = "ShotAngleCode"
    Public Const RadiationRecordDetail_ExpandCode As String = "ExpandCode"
    Public Const RadiationRecordDetail_DetailPositionCode As String = "DetailPositionCode"
    Public Const RadiationRecordDetail_SpecialOrderCode As String = "SpecialOrderCode"
    Public Const RadiationRecordDetail_IsotopeCode As String = "IsotopeCode"
    Public Const RadiationRecordDetail_ImageModeCode As String = "ImageModeCode"
    Public Const RadiationRecordDetail_ReserveCode As String = "ReserveCode"
    Public Const RadiationRecordDetail_FilmConditionKV As String = "FilmConditionKV"
    Public Const RadiationRecordDetail_FilmConditionMA As String = "FilmConditionMA"
    Public Const RadiationRecordDetail_FilmConditionSEC As String = "FilmConditionSEC"
    Public Const RadiationRecordDetail_FilmConditionCM As String = "FilmConditionCM"
    Public Const RadiationRecordDetail_ThicknessCode As String = "ThicknessCode"
    Public Const RadiationRecordDetail_TakeTimes As String = "TakeTimes"
    Public Const RadiationRecordDetail_CopyFilmCount As String = "CopyFilmCount"
    Public Const RadiationRecordDetail_FilmCode As String = "FilmCode"
    Public Const RadiationRecordDetail_FilmCount As String = "FilmCount"
#End Region

#Region "画像実施記録使用道具情報のキー"
    Public Const RadiationRecordTool_FacilityID As String = "FacilityID"
    Public Const RadiationRecordTool_RadiationNo As String = "RadiationNo"
    Public Const RadiationRecordTool_RpNo As String = "RpNo"
    Public Const RadiationRecordTool_RecNo As String = "RecNo"
    Public Const RadiationRecordTool_UpdateDate As String = "UpdateDate"
    Public Const RadiationRecordTool_UpdateStaffID As String = "UpdateStaffID"
    Public Const RadiationRecordTool_UpdateJobCode As String = "UpdateJobCode"
    Public Const RadiationRecordTool_DelFlag As String = "DelFlag"
    Public Const RadiationRecordTool_ToolClass As String = "ToolClass"
    Public Const RadiationRecordTool_ToolCode As String = "ToolCode"
    Public Const RadiationRecordTool_ToolQuantity As String = "ToolQuantity"
    Public Const RadiationRecordTool_ToolUnitCode As String = "ToolUnitCode"
#End Region

#End Region

#Region "処置マスタ関連のキー"

#Region "処置マスタのキー"
    Public Const MedicalCareAct_FacilityID As String = "FacilityID"
    Public Const MedicalCareAct_MedicalCareActCode As String = "MedicalCareActCode"
    Public Const MedicalCareAct_ValidDateFrom As String = "ValidDateFrom"
    Public Const MedicalCareAct_ValidDateTo As String = "ValidDateTo"
    Public Const MedicalCareAct_HospitalClass As String = "HospitalClass"
    Public Const MedicalCareAct_StayOutClass As String = "StayOutClass"
    Public Const MedicalCareAct_MedicalCareActName As String = "MedicalCareActName"
    Public Const MedicalCareAct_MedicalCareActNameKana As String = "MedicalCareActNameKana"
    Public Const MedicalCareAct_PartsFlag As String = "PartsFlag"
    Public Const MedicalCareAct_TimesFlag As String = "TimesFlag"
    Public Const MedicalCareAct_KCode As String = "KCode"
#End Region

#Region "処置薬品マスタのキー"
    Public Const MedicalCareDrug_FacilityID As String = "FacilityID"
    Public Const MedicalCareDrug_MedicalCareActCode As String = "MedicalCareActCode"
    Public Const MedicalCareDrug_HotCode As String = "HotCode"
    Public Const MedicalCareDrug_LogNo As String = "LogNo"
    Public Const MedicalCareDrug_StatusClass As String = "StatusClass"
    Public Const MedicalCareDrug_UpdateDate As String = "UpdateDate"
    Public Const MedicalCareDrug_UpdateStaffID As String = "UpdateStaffID"
    Public Const MedicalCareDrug_DelFlag As String = "DelFlag"
    Public Const MedicalCareDrug_ValidDateFrom As String = "ValidDateFrom"
    Public Const MedicalCareDrug_ValidDateTo As String = "ValidDateTo"
#End Region

#End Region

#Region "診療行為マスタ関連のキー"

#Region "処置薬品マスタのキー"
    Public Const Practice_FacilityID As String = "FacilityID"
    Public Const Practice_StatusClass As String = "StatusClass"
    Public Const Practice_PracticeCode As String = "PracticeCode"
    Public Const Practice_LogNo As String = "LogNo"
    Public Const Practice_UpdateDate As String = "UpdateDate"
    Public Const Practice_UpdateStaffID As String = "UpdateStaffID"
    Public Const Practice_DelFlag As String = "DelFlag"
    Public Const Practice_ValidDateFrom As String = "ValidDateFrom"
    Public Const Practice_ValidDateTo As String = "ValidDateTo"
    Public Const Practice_PracticeName As String = "PracticeName"
    Public Const Practice_PracticeKana As String = "PracticeKana"
    Public Const Practice_CodeListNo As String = "CodeListNo"
    Public Const Practice_CodeListChapterNo As String = "CodeListChapterNo"
    Public Const Practice_CodeListClassNo As String = "CodeListClassNo"
    Public Const Practice_CodeListSectionNo As String = "CodeListSectionNo"
    Public Const Practice_CodeListBlanchNo As String = "CodeListBlanchNo"
    Public Const Practice_CodeListItemNo As String = "CodeListItemNo"
    Public Const Practice_NoticeIndexType1 As String = "NoticeIndexType1"
    Public Const Practice_NoticeIndexType2 As String = "NoticeIndexType2"
    Public Const Practice_CarveCalcType As String = "CarveCalcType"
    Public Const Practice_CarveUnit As String = "CarveUnit"
#End Region

#End Region

    'ABC順＆数字順で追記してください。ローカル定数やベタ書き禁止
#Region "名称マスタ．名称区分"
    ''' <summary>名称区分：受診状況種別</summary>
    Public Const NAME_CLASS_BM02_PROCESS_TYPE As String = "BM02"
    ''' <summary>名称区分：診療種別</summary>
    Public Const NAME_CLASS_BM08_MEDICAL_CARE_TYPE As String = "BM08"   
    ''' <summary>名称区分：性別</summary>
    Public Const NAME_CLASS_CM02_SEX_TYPE As String = "CM02"
    ''' <summary>名称区分：都道府県</summary>
    Public Const NAME_CLASS_CM03_STATE As String = "CM03"
    ''' <summary>名称区分：単位</summary>
    Public Const NAME_CLASS_CM04_UNIT As String = "CM04"
    ''' <summary>名称区分：現任区分</summary>
    Public Const NAME_CLASS_CM07_VALID_TYPE As String = "CM07"
    ''' <summary>名称区分：予約枠区分</summary>
    Public Const NAME_CLASS_FA06_RESERVE_CLASS As String = "FA06"
    ''' <summary>名称区分：入外区分</summary>
    Public Const NAME_CLASS_FA10_IN_OUT_CLASS As String = "FA10"
    ''' <summary>名称区分：オーダ種別</summary>
    Public Const NAME_CLASS_OD01_ORDER_TYPE As String = "OD01"
    ''' <summary>名称区分：処方箋種別_外来（院内／院外）</summary>
    Public Const NAME_CLASS_OD03_TEMPORARY_CLASS As String = "OD03"
    ''' <summary>名称区分：処方箋種別_入院(定期/臨時)</summary>
    Public Const NAME_CLASS_OD04_TEMPORARY_CLASS As String = "OD04"
    ''' <summary>名称区分：処方用法種別</summary>
    Public Const NAME_CLASS_OD05_DOSAGE_CLASS As String = "OD05"
    ''' <summary>名称区分：時間区分</summary>
    Public Const NAME_CLASS_OD06_DOSE_TIMING As String = "OD06"
    ''' <summary>名称区分：処方頓用指示コメント</summary>
    Public Const NAME_CLASS_OD10_DOSE_SCENE As String = "OD10"
    ''' <summary>名称区分：処方外用指示コメント１（部位）</summary>
    Public Const NAME_CLASS_OD11_EXTERNAL_PART As String = "OD11"
    ''' <summary>名称区分：処方外用指示コメント２（使用法）</summary>
    Public Const NAME_CLASS_OD12_EXTERNAL_METHOD As String = "OD12"
    ''' <summary>名称区分：処方その他指示コメント（インスリン対象部位）</summary>
    Public Const NAME_CLASS_OD13_INSULIN_PART As String = "OD13"
    ''' <summary>名称区分：外用部位区分）</summary>
    Public Const NAME_CLASS_OD14_EXTERNAL_PART_CODE As String = "OD14"
    ''' <summary>名称区分：特殊薬品識別区分</summary>
    Public Const NAME_CLASS_OD16_SPECIAL_DRUG As String = "OD16"
    ''' <summary>名称区分：薬品麻毒区分</summary>
    Public Const NAME_CLASS_OD17_NARCOTIC_POISON_DRUG As String = "OD17"
    ''' <summary>名称区分：剤形区分</summary>
    Public Const NAME_CLASS_OD18_DOSAGE_FORM_CLASS As String = "OD18"
    ''' <summary>名称区分：生理機能検査（種別）</summary>
    Public Const NAME_CLASS_OD28_PHYSIOLOGICAL_EXAM_TYPE As String = "OD28"
    ''' <summary>名称区分：注射投与手技</summary>
    Public Const NAME_CLASS_OD31_INJECTION_TECHNIQUE As String = "OD31"
    ''' <summary>名称区分：注射投与方法</summary>
    Public Const NAME_CLASS_OD32_INJECTION_METHOD As String = "OD32"
    ''' <summary>名称区分：（注射）点滴速度区分</summary>
    Public Const NAME_CLASS_OD33_INJECTION_SPEED As String = "OD33"
    ''' <summary>名称区分：日付区分（指示日/実施日）</summary>
    Public Const NAME_CLASS_OD35_DATE_TYPE As String = "OD35"
    ''' <summary>名称区分：オーダ状態</summary>
    Public Const NAME_CLASS_OD36_ORDER_STATUS As String = "OD36"
    ''' <summary>名称区分：オーダ受け種別</summary>
    Public Const NAME_CLASS_OD37_ORCER_ACCEPT As String = "OD37"
    ''' <summary>名称区分：主副病名区分</summary>
    Public Const NAME_CLASS_RE01_DISEASE_TYPE As String = "RE01"
    ''' <summary>名称区分：傷病名転帰</summary>
    Public Const NAME_CLASS_RE02_OUTCOME_TYPE As String = "RE02"
    ''' <summary>名称区分：保険病名区分</summary>
    Public Const NAME_CLASS_RE03_RECIEPT_FLAG As String = "RE03"
    ''' <summary>名称区分：安全管理区分</summary>
    Public Const NAME_CLASS_RE18_SAFETY_CODE As String = "RE18"
    ''' <summary>名称区分：免許区分</summary>
    Public Const NAME_CLASS_ST01_LICENSE As String = "ST01"

#End Region

    '※気づいたら順次追加していって下さい！ABC順＆数字順で追記してください。ローカル定数やベタ書き禁止
#Region "汎用マスタ・汎用区分"
    'ACU01
    'ACU02
    'ACU03
    'BMS01
    'COM01
    'CON01
    'CON02
    'FLS01
    'FMT01
    'IMO01
    'IMO02
    'MEP01
    'MNU01
    ''' <summary>汎用区分：指示コメント</summary>
    Public Const UNIV_CLASS_ODCMT_COMMENT As String = "ODCMT"
    ''' <summary>汎用区分：検査目的・臨床診断コメント</summary>
    Public Const UNIV_CLASS_ODEPC_EXAM_PURPOSE As String = "ODEPC"
    'OPI01
    'PAI11
    'PNTMP
    'PRS01
    ''' <summary>汎用区分：予約票説明欄テンプレート</summary>
    Public Const UNIV_CLASS_RES01_DESCRIPTION As String = "RES01"
    'RES01
    'RHO01
    'RHO02
    'RPR01
    'REP01
    ''' <summary>汎用区分：診療内容区分</summary>
    Public Const UNIV_CLASS_REP01_MEDICAL_CONTENTS As String = "REP01"
    'WWS01
#End Region

#Region "名称マスタのキー"
    Public Const Name_FacilityID As String = "FacilityID"
    Public Const Name_StatusClass As String = "StatusClass"
    Public Const Name_NameClass As String = "NameClass"
    Public Const Name_NameCode As String = "NameCode"
    Public Const Name_LogNo As String = "LogNo"
    Public Const Name_UpdateDate As String = "UpdateDate"
    Public Const Name_UpdateStaffID As String = "UpdateStaffID"
    Public Const Name_DelFlag As String = "DelFlag"
    Public Const Name_SortNo As String = "SortNo"
    Public Const Name_ValidDateFrom As String = "ValidDateFrom"
    Public Const Name_ValidDateTo As String = "ValidDateTo"
    Public Const Name_FacilitySelectFlag As String = "FacilitySelectFlag"
    Public Const Name_Name As String = "Name"
    Public Const Name_ShortName As String = "ShortName"
    Public Const Name_Kana As String = "Kana"
    Public Const Name_Explanation As String = "Explanation"
    Public Const Name_Value01 As String = "Value01"
    Public Const Name_Value02 As String = "Value02"
    Public Const Name_Value03 As String = "Value03"
    Public Const Name_Value04 As String = "Value04"
    Public Const Name_Value05 As String = "Value05"
    Public Const Name_Value06 As String = "Value06"
    Public Const Name_Value07 As String = "Value07"
    Public Const Name_Value08 As String = "Value08"
    Public Const Name_Value09 As String = "Value09"
    Public Const Name_Value10 As String = "Value10"
    Public Const Name_Value As String = "Value"
    Public Const Name_Flag01 As String = "Flag01"
    Public Const Name_Flag02 As String = "Flag02"
    Public Const Name_Flag03 As String = "Flag03"
    Public Const Name_Flag04 As String = "Flag04"
    Public Const Name_Flag05 As String = "Flag05"
    Public Const Name_Flag06 As String = "Flag06"
    Public Const Name_Flag07 As String = "Flag07"
    Public Const Name_Flag08 As String = "Flag08"
    Public Const Name_Flag09 As String = "Flag09"
    Public Const Name_Flag10 As String = "Flag10"
    Public Const Name_Flag As String = "Flag"
#End Region


#Region "DB名称"  '※気づいたら順次追加　DBの通し番号順に記載。ローカル定数やベタ書き禁止
#Region "DB名称：0100（システム情報）"
    ''' <summary>DB名称</summary>
    ''' <remarks>0103 機能一覧</remarks>
    Public Const DB_FUNCTION As String = "機能一覧"
#End Region
#Region "DB名称：0200（施設情報）"
    ''' <summary>DB名称</summary>
    ''' <remarks>0222 診療科マスタ</remarks>
    Public Const DB_DEPARTMENT As String = "診療科マスタ"
    ''' <summary>DB名称</summary>
    ''' <remarks>0223 予約項目マスタ</remarks>
    Public Const DB_RESERVE_ITEM As String = "予約項目マスタ"
    ''' <summary>DB名称</summary>
    ''' <remarks>0224 予約枠マスタ</remarks>
    Public Const DB_RESERVE_UNIT As String = "予約枠マスタ"
    ''' <summary>DB名称</summary>
    ''' <remarks>0231 病棟マスタ</remarks>
    Public Const DB_HOSPITAL_WARD As String = "病棟マスタ"
    ''' <summary>DB名称</summary>
    ''' <remarks>0232 病室マスタ</remarks>
    Public Const DB_HOSPITAL_ROOM As String = "病室マスタ"
    ''' <summary>DB名称</summary>
    ''' <remarks>0233 病床マスタ</remarks>
    Public Const DB_HOSPITAL_BED As String = "病床マスタ"
    ''' <summary>アクセスクラス名称名称</summary>
    ''' <remarks>病棟/病室/病床マスタ</remarks>
    Public Const DB_HOSPITAL As String = "病棟/病室/病床マスタ"
#End Region
#Region "DB名称：0300（職員）"
    ''' <summary>DB名称</summary>
    ''' <remarks>0301 職員基本情報</remarks>
    Public Const DB_STAFF_BASE As String = "職員基本情報"
    'ADD START	2017/02/16 HMW加藤 #9966　
    ''' <summary>DB名称</summary>
    ''' <remarks>0302 職員担当職種</remarks>
    Public Const DB_STAFF_JOB_TYPE As String = "職員担当職種"
    ''' <summary>DB名称</summary>
    ''' <remarks>0303 職員担当診療科</remarks>
    Public Const DB_STAFF_DEPARTMENT As String = "職員担当診療科"
    ''' <summary>DB名称</summary>
    ''' <remarks>0305 職員パスワード情報</remarks>
    Public Const DB_STAFF_PASSWORD As String = "職員パスワード情報"
    ''' <summary>DB名称</summary>
    ''' <remarks>0306 職員免許情報</remarks>
    Public Const DB_STAFF_LICENSE As String = "職員免許情報"
#End Region
#Region "DB名称：0400（患者）"
    ''' <summary>DB名称</summary>
    ''' <remarks>0401 患者基本情報</remarks>
    Public Const DB_PATIENT_BASE As String = "患者基本情報"
#End Region
#Region "DB名称：0500（業務支援）"

#End Region
#Region "DB名称：0600（外来入院管理）"
    ''' <summary>DB名称</summary>
    ''' <remarks>0601 予約枠情報</remarks>
    Public Const DB_CONTROL_RESERVE As String = "予約枠情報"
    ''' <summary>DB名称</summary>
    ''' <remarks>0602 科予約受付管理</remarks>
    Public Const DB_CONTROL_OUTPATIENT As String = "科予約受付管理"
    ''' <summary>DB名称</summary>
    ''' <remarks>0623 転床転科履歴</remarks>
    Public Const DB_HISTORY_BED As String = "転床転科履歴"
#End Region
#Region "DB名称：0700（診療情報）～0760"
    ''' <summary>DB名称</summary>
    ''' <remarks>0710 傷病名情報</remarks>
    Public Const DB_DISEASE As String = "傷病名情報"
    ''' <summary>DB名称</summary>
    ''' <remarks>0714 経過記録</remarks>
    Public Const DB_PROGRESS_HEADER As String = "経過記録"
    ''' <summary>DB名称</summary>
    ''' <remarks>0715 経過明細</remarks>
    Public Const DB_PROGRESS_DETAIL As String = "経過明細"
    ''' <summary>アクセスクラス名称</summary>
    ''' <remarks>経過記録/明細情報</remarks>
    Public Const DB_PROGRESS_DATA As String = "経過記録/明細情報"
    'ADD END	2017/03/22 HMW加藤 #10816
    ''' <summary>DB名称</summary>
    ''' <remarks>0781 文書データ</remarks>
    Public Const DB_DOCUMENT As String = "文書データ"
#End Region
#Region "DB名称：0780（ドキュメント）"

#End Region
#Region "DB名称：0800（オーダ・ケア管理）"
    ''' <summary>DB名称</summary>
    ''' <remarks>0801 オーダ基本情報</remarks>
    Public Const DB_ORDER_BASE As String = "オーダ基本情報"
    ''' <summary>DB名称</summary>
    ''' <remarks>0802 オーダ予定実績</remarks>
    Public Const DB_ORDER_SCHEDULE As String = "オーダ予定実績"
    ''' <summary>DB名称</summary>
    ''' <remarks>0803 オーダ受け情報</remarks>
    Public Const DB_ORDER_ACCEPT As String = "オーダ受け情報"
    ''' <summary>DB名称</summary>
    ''' <remarks>0804 オーダ発行情報</remarks>
    Public Const DB_ORDER_PUBLISH As String = "オーダ発行情報"
    ''' <summary>DB名称</summary>
    ''' <remarks>08XX オーダ詳細情報</remarks>
    Public Const DB_ORDER_DETAIL As String = "オーダ詳細情報"
    ''' <summary>アクセスクラス名称</summary>
    ''' <remarks>オーダ基本情報/オーダ受け情報/オーダ予定実績</remarks>
    Public Const DB_ORDER_INFO As String = "オーダ情報"
#End Region
#Region "DB名称：0900（オーダ実施記録）"

#End Region
#Region "DB名称：1000（マスタ）"
    ''' <summary>DB名称</summary>
    ''' <remarks>1001 職種マスタ</remarks>
    Public Const DB_JOB As String = "職種マスタ"
    ''' <summary>DB名称</summary>
    ''' <remarks>1002M 制御マスタ</remarks>
    Public Const DB_CONTROL As String = "制御マスタ"
    ''' <summary>DB名称</summary>
    ''' <remarks>1004 名称マスタ</remarks>
    Public Const DB_NAME As String = "名称マスタ"
    ''' <summary>DB名称</summary>
    ''' <remarks>1008 汎用マスタ</remarks>
    Public Const DB_UNIVERSAL As String = "汎用マスタ"
    ''' <summary>DB名称</summary>
    ''' <remarks>1165 検査マスタ</remarks>
    Public Const DB_EXAMINATION As String = "検査マスタ"
#End Region
#Region "DB名称：2000（オーダセット）"
    ''' <summary>DB名称</summary>
    ''' <remarks>2101 伝票カテゴリマスタ</remarks>
    Public Const DB_SLIP_CATEGORY As String = "伝票カテゴリマスタ"
    ''' <summary>DB名称</summary>
    ''' <remarks>2102 伝票基本マスタ</remarks>
    Public Const DB_SLIP_BASE As String = "伝票基本マスタ"
    ''' <summary>DB名称</summary>
    ''' <remarks>2103 伝票詳細マスタ</remarks>
    Public Const DB_SLIP_DETAIL As String = "伝票詳細マスタ"
#End Region
#Region "DB名称：9000（インターフェイス）"
    ''' <summary>DB名称</summary>
    ''' <remarks>9001 連携用コード変換マスタ</remarks>
    Public Const DB_LINK_MASTER As String = "連携用コード変換マスタ"
#End Region
#End Region

#Region "実行ファイルNo."     '名称マスタ［SY03］に定義される［名称コード］

    ''' <summary>実行ファイル名[SY03]：外来受付</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_OutpatientReception As String = "001"

    ''' <summary>実行ファイル名[SY03]：画像部門システム</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_ImagingDivisionSystem As String = "002"

    ''' <summary>実行ファイル名[SY03]：リハビリ部門システム</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_RehabDivisionSystem As String = "003"

    ''' <summary>実行ファイル名[SY03]：検体検査部門システム</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_LaboratoryExamSystem As String = "004"

    ''' <summary>実行ファイル名[SY03]：栄養部門システム</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_NutritionDivisionSystem As String = "005"

    ''' <summary>実行ファイル名[SY03]：薬剤部門システム</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PharmacyDivisionSystem As String = "006"

    ''' <summary>実行ファイル名[SY03]：生理検査部門システム</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PhysiologicalExamSystem As String = "007"

    ''' <summary>実行ファイル名[SY03]：リストバンド印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintWristBand As String = "008"

    ''' <summary>実行ファイル名[SY03]：予約票印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_ReserveSheet As String = "009"

    ''' <summary>実行ファイル名[SY03]：食事箋印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintNutritionRecipe As String = "010"

    ''' <summary>実行ファイル名[SY03]：経管栄養ラベル印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintNutritionLabel As String = "011"

    ''' <summary>実行ファイル名[SY03]：退院療養計画書印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintDischargeCarePlan As String = "012"

    ''' <summary>実行ファイル名[SY03]：入院診療計画書印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintAdmissionCarePlan As String = "013"

    ''' <summary>実行ファイル名[SY03]：総合評価版印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintAssessment As String = "014"

    ''' <summary>実行ファイル名[SY03]：褥瘡診療計画印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintBedsoreCarePlan As String = "015"

    ''' <summary>実行ファイル名[SY03]：検査結果（時系列）印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintExamResultProgress As String = "016"

    ''' <summary>実行ファイル名[SY03]：検査結果（日毎）印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintExamResultOneDay As String = "017"

    ''' <summary>実行ファイル名[SY03]：院外処方箋印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintOutOfHospitalRecipe As String = "018"

    ''' <summary>実行ファイル名[SY03]：院内処方箋印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintInsideHospitalRecipe As String = "019"

    ''' <summary>実行ファイル名[SY03]：院内注射箋印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintInsideHospitalInjectionRecipe As String = "020"

    ''' <summary>実行ファイル名[SY03]：注射ラベル印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintInjectionLabel As String = "021"

    ''' <summary>実行ファイル名[SY03]：施用箋印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintNarcoticRecipe As String = "022"

    ''' <summary>実行ファイル名[SY03]：指示書印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintOrderSheet As String = "023"

    ''' <summary>実行ファイル名[SY03]：食札印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintFoodTag As String = "024"

    ''' <summary>実行ファイル名[SY03]：処方ラベル</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintPrescriptionLabel As String = "025"

    ''' <summary>実行ファイル名[SY03]：栄養スクリーニング・アセスメント印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintScreeningAssessment As String = "026"

    ''' <summary>実行ファイル名[SY03]：低栄養マネジメント印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintLowNutrientManagement As String = "027"

    ''' <summary>実行ファイル名[SY03]：栄養管理計画印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintNutrientManagementPlan As String = "028"

    ''' <summary>実行ファイル名[SY03]：栄養治療実施計画印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintNutrientCureImplementPlan As String = "029"

    ''' <summary>実行ファイル名[SY03]：IVH管理・離脱計画印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintIVHPlan As String = "030"

    ''' <summary>実行ファイル名[SY03]：看護計画印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintCarePlan As String = "031"

    ''' <summary>実行ファイル名[SY03]：病棟ワークシート印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintWardWorksheet As String = "032"

    ''' <summary>実行ファイル名[SY03]：入院時看護基礎データ</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintAdmissionNursingBase As String = "033"

    ''' <summary>実行ファイル名[SY03]：栄養管理システム（※コード未設定）</summary>
    ''' <remarks>
    ''' <para>名称マスタ［SY03］に定義される［名称コード］</para>
    ''' <para>※名称マスタ［SY03］に「検体オーダ簡易受付」で上書きされており、今は使用されていない。</para>
    ''' </remarks>
    Public Const ExeFileNo_NutritionalManagementSystem As String = "" '"034"　
    ''' <summary>実行ファイル名[SY03]：検体オーダ簡易受付</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_LaboratoryExamOrderSimpleReception As String = "034"

    ''' <summary>実行ファイル名[SY03]：統計情報（患者台帳）</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_StatisticsSystem As String = "035"

    ''' <summary>実行ファイル名[SY03]：申し送り印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintHandOver As String = "036"

    ''' <summary>実行ファイル名[SY03]：薬剤部門システム</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintPharmacyDivision As String = "038"

    ''' <summary>実行ファイル名[SY03]：基本票印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintOutpatientBaseSlip As String = "040"
    ''' <summary>実行ファイル名[SY03]：カルテ印刷</summary>
    ''' <remarks>名称マスタ［SY03］に定義される［名称コード］</remarks>
    Public Const ExeFileNo_PrintKarte As String = "039"
#End Region

#Region "文書種別　名称マスタ:RE13"
    ''' <summary>文書種別［RE13］：退院時ドクターサマリ</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_DischargeDoctorSummary As String = "113"
    ''' <summary>文書種別［RE13］：経過看護サマリ</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_NursingSummary_Progress As String = "122"
    ''' <summary>文書種別［RE13］：転棟時看護サマリ</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_NursingSummary_ChangeWard As String = "123"
    ''' <summary>文書種別［RE13］：転院時看護サマリ</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_NursingSummary_ChangeFacility As String = "124"
    ''' <summary>文書種別［RE13］：退院時看護サマリ</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_NursingSummary_DischargeTime As String = "125"
    ''' <summary>文書種別［RE13］：退院看護サマリ</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_NursingSummary_Discharge As String = "126"
    ''' <summary>文書種別［RE13］：看護計画</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_CarePlan As String = "132"
    ''' <summary>文書種別［RE13］：問題点管理</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_ProblemManagement As String = "133"
    ''' <summary>文書種別［RE13］：診療情報提供書（紹介状）</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_HealthInformation As String = "211"
    ''' <summary>文書種別［RE13］：返信箋</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_ReplyRecipe As String = "212"
    ''' <summary>文書種別［RE13］：病状説明同意書</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_DiseaseStateConsentForm As String = "213"
    ''' <summary>文書種別［RE13］：退院証明書</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_DischargeCertificationForm As String = "214"
    ''' <summary>文書種別［RE13］：病状評価計画表</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_DiseaseAssessmentPlan As String = "221"
    ''' <summary>文書種別［RE13］：入院時看護基礎データ</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_AdmissionNursingBase As String = "222"
    ''' <summary>文書種別［RE13］：褥瘡診療計画書</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_BedsoreCarePlan As String = "223"
    ''' <summary>文書種別［RE13］：栄養スクリーニング</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_Nutrition_Screening As String = "241"
    ''' <summary>文書種別［RE13］：低栄養マネジメント</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_LowNutrientManagement As String = "242"
    ''' <summary>文書種別［RE13］：栄養管理計画</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_Nutrition_ManagementPlan As String = "243"
    ''' <summary>文書種別［RE13］：栄養ケア計画</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_Nutrition_CarePlan As String = "244"
    ''' <summary>文書種別［RE13］：栄養IVH計画</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_Nutrition_IVHPlan As String = "245"
    ''' <summary>文書種別［RE13］：栄養治療実施計画</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_Nutrition_CureImplementPlan As String = "246"
    ''' <summary>文書種別［RE13］：退院療養計画書</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_DischargeCarePlan As String = "253"
    ''' <summary>文書種別［RE13］：入院時診療計画書</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_AdmissionCarePlan As String = "254"
    ''' <summary>文書種別［RE13］：カンファレンス</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_Conference As String = "900"
    ''' <summary>文書種別［RE13］：病棟ワークシート</summary>
    ''' <remarks>名称マスタ［RE13］に定義される［名称コード］</remarks>
    Public Const DocType_WardWorksheet As String = "991"

#End Region '"文書種別　名称マスタ:RE13"

#Region "実行ファイルパラメータ（院内処方箋）"
    ''' <summary>実行ファイルパラメータ 薬剤部用</summary>
    Public Const PrintInsideHospitalRecipeMode_Medical As String = "1"
    ''' <summary>実行ファイルパラメータ 病棟用</summary>
    Public Const PrintInsideHospitalRecipeMode_Ward As String = "2"
    ''' <summary>実行ファイルパラメータ 薬剤部用/病棟用</summary>
    Public Const PrintInsideHospitalRecipeMode_MedicalWard As String = "3"
#End Region

#Region "実行ファイルパラメータ（院内注射箋）"
    ''' <summary>実行ファイルパラメータ 両方（薬剤部用/病棟用を同一プリンタ出力）</summary>
    Public ReadOnly PrintInsideHospitalInjectionRecipeMode_Both As String = "0"
    ''' <summary>実行ファイルパラメータ 薬剤部用</summary>
    Public ReadOnly PrintInsideHospitalInjectionRecipeMode_Medical As String = "1"
    ''' <summary>実行ファイルパラメータ 病棟用</summary>
    Public ReadOnly PrintInsideHospitalInjectionRecipeMode_Ward As String = "2"
    ''' <summary>実行ファイルパラメータ 薬剤部用/病棟用</summary>
    Public ReadOnly PrintInsideHospitalInjectionRecipeMode_MedicalWard As String = "3"
#End Region

#Region "データID"
    ''' <summary>データ情報：保険情報の権限制御設定を持つ［S_Data.SDAT_DataID］</summary>
    ''' <remarks>データ一覧情報で持つ、システム固定とするコード定義：</remarks>
    Public Const Insurance As String = "INSURANCE"
#End Region

#Region "栄養オーダ関連"
    ''' <summary>栄養オーダ・単位</summary>
    Public Enum enmNutritionUnit
        Day = 1
        Individual = 2
        Milliliter = 3
        Gram = 4
    End Enum

    Public Const Nutrition_Unit_Day As String = ""
    Public Const Nutrition_Unit_Individual As String = "個"
    Public Const Nutrition_Unit_Milliliter As String = "ml"
    Public Const Nutrition_Unit_Gram As String = "g"

#End Region

#Region "職種コード"
    Public Const JobTypeDoctor As String = "0000001"    '医師
    Public Const JobTypeNurse As String = "0000003"     '看護師
    Public Const JobTypePharmacist As String = "0000009"    '薬剤師
    Public Const JobTypeNutrient As String = "0000038"   '栄養士
#End Region

#Region "検査日未定"
    ''' <summary>検査日未定</summary>
    Public Const NoPlanExecExamination As String = "9999/12/30"
#End Region

#Region "機能連携用パラメータ"
    ''' <summary>機能連携用パラメータ</summary>
    Public Const Parameter As String = "Parameter"
#End Region

#Region "メッセージID"
#Region "100番台"
    ''' <summary></summary>
    Public Const MSGID_10000001 As String = "10000001"
    ''' <summary></summary>
    Public Const MSGID_10000002 As String = "10000002"
    ''' <summary></summary>
    Public Const MSGID_10000003 As String = "10000003"
    ''' <summary></summary>
    Public Const MSGID_10000004 As String = "10000004"
    ''' <summary></summary>
    Public Const MSGID_10000005 As String = "10000005"
    ''' <summary></summary>
    Public Const MSGID_10000006 As String = "10000006"
    ''' <summary></summary>
    Public Const MSGID_10000007 As String = "10000007"
    ''' <summary></summary>
    Public Const MSGID_10000008 As String = "10000008"
    ''' <summary></summary>
    Public Const MSGID_10000009 As String = "10000009"
    ''' <summary></summary>
    Public Const MSGID_10000010 As String = "10000010"
    ''' <summary></summary>
    Public Const MSGID_10000011 As String = "10000011"
    ''' <summary></summary>
    Public Const MSGID_10000012 As String = "10000012"
    ''' <summary>
    ''' <para>マスタ取得エラー時</para>
    ''' <para>[0]項目名/データ名</para>
    ''' </summary>
    Public Const MSGID_10000013 As String = "10000013"
    ''' <summary>
    ''' <para>DB取得成功時</para>
    ''' <para>[0]</para>
    ''' <para>[1]</para>
    ''' </summary>
    Public Const MSGID_10000014 As String = "10000014"
    ''' <summary>
    ''' <para>DB取得失敗時</para>
    ''' <para>[0]</para>
    ''' <para>[1]</para>
    ''' </summary>
    Public Const MSGID_10000015 As String = "10000015"
    ''' <summary>
    ''' <para>DB登録成功時（画面用）</para>
    ''' <para>[0]項目名/データ名</para>
    ''' </summary>
    Public Const MSGID_10000016 As String = "10000016"
    ''' <summary>
    ''' <para>DB登録失敗時（画面用）</para>
    ''' <para>[0]項目名/データ名</para>
    ''' </summary>
    Public Const MSGID_10000017 As String = "10000017"
    ''' <summary>
    ''' <para>DB更新成功時（画面用）</para>
    ''' <para>[0]項目名/データ名</para>
    ''' </summary>
    Public Const MSGID_10000018 As String = "10000018"
    ''' <summary>
    ''' <para>DB更新失敗時（画面用）</para>
    ''' <para>[0]項目名/データ名</para>
    ''' </summary>
    Public Const MSGID_10000019 As String = "10000019"
    ''' <summary>
    ''' <para>DB削除成功時（画面用）</para>
    ''' <para>[0]項目名/データ名</para>
    ''' </summary>
    Public Const MSGID_10000020 As String = "10000020"
    ''' <summary>
    ''' <para>DB削除失敗時（画面用）</para>
    ''' <para>[0]項目名/データ名</para>
    ''' </summary>
    Public Const MSGID_10000021 As String = "10000021"
    ''' <summary>
    ''' <para>DB取得成功時（画面用）</para>
    ''' <para>[0]項目名/データ名</para>
    ''' </summary>
    Public Const MSGID_10000022 As String = "10000022"
    ''' <summary>
    ''' <para>DB取得失敗時（画面用）</para>
    ''' <para>[0]項目名/データ名</para>
    ''' </summary>
    Public Const MSGID_10000023 As String = "10000023"
#End Region

#Region "200番台"
    ''' <summary></summary>
    Public Const MSGID_20000001 As String = "20000001"
    ''' <summary></summary>
    Public Const MSGID_20000002 As String = "20000002"
    ''' <summary>
    ''' <para>必須項目エラー：“［0］は、必須項目です。”</para>
    ''' <para>[0]項目名</para>
    ''' </summary>
    Public Const MSGID_20000003 As String = "20000003"
    ''' <summary>※重複のため使用不可</summary>
    Public Const MSGID_20000004 As String = "20000004"
    ''' <summary>
    ''' <para>必須項目未選択エラー：“［0］を選択してください。”</para>
    ''' <para>[0]項目名</para>
    ''' </summary>
    Public Const MSGID_20000005 As String = "20000005"
    ''' <summary>
    ''' <para>必須項目未指定エラー：“［0］を指定してください。”</para>
    ''' <para>[0]項目名</para>
    ''' </summary>
    Public Const MSGID_20000006 As String = "20000006"
    ''' <summary></summary>
    Public Const MSGID_20000007 As String = "20000007"
    ''' <summary></summary>
    Public Const MSGID_20000008 As String = "20000008"
    ''' <summary></summary>
    Public Const MSGID_20000009 As String = "20000009"
    ''' <summary></summary>
    Public Const MSGID_20000010 As String = "20000010"
    ''' <summary></summary>
    Public Const MSGID_20000011 As String = "20000011"
    ''' <summary></summary>
    Public Const MSGID_20000012 As String = "20000012"
    ''' <summary></summary>
    Public Const MSGID_20000013 As String = "20000013"
    ''' <summary></summary>
    Public Const MSGID_20000014 As String = "20000014"
    ''' <summary></summary>
    Public Const MSGID_20000015 As String = "20000015"
    ''' <summary></summary>
    Public Const MSGID_20000016 As String = "20000016"
    ''' <summary></summary>
    Public Const MSGID_20000017 As String = "20000017"
    ''' <summary></summary>
    Public Const MSGID_20000018 As String = "20000018"
    ''' <summary></summary>
    Public Const MSGID_20000019 As String = "20000019"
    ''' <summary></summary>
    Public Const MSGID_20000020 As String = "20000020"
    ''' <summary></summary>
    Public Const MSGID_20000021 As String = "20000021"
    ''' <summary></summary>
    Public Const MSGID_20000022 As String = "20000022"
    ''' <summary></summary>
    Public Const MSGID_20000023 As String = "20000023"
    ''' <summary></summary>
    Public Const MSGID_20000024 As String = "20000024"
    ''' <summary></summary>
    Public Const MSGID_20000025 As String = "20000025"
    ''' <summary>
    ''' <para>MAX桁数オーバ</para>
    ''' <para>[0]項目名</para>
    ''' <para>[1]文字数</para>
    ''' </summary>
    Public Const MSGID_20000026 As String = "20000026"
    ''' <summary></summary>
    Public Const MSGID_20000027 As String = "20000027"
    ''' <summary></summary>
    Public Const MSGID_20000028 As String = "20000028"
    ''' <summary></summary>
    Public Const MSGID_20000029 As String = "20000029"
    ''' <summary></summary>
    Public Const MSGID_20000030 As String = "20000030"
    ''' <summary></summary>
    Public Const MSGID_20000031 As String = "20000031"
    ''' <summary></summary>
    Public Const MSGID_20000032 As String = "20000032"
    ''' <summary></summary>
    Public Const MSGID_20000033 As String = "20000033"
    ''' <summary></summary>
    Public Const MSGID_20000034 As String = "20000034"
    ''' <summary></summary>
    Public Const MSGID_20000035 As String = "20000035"
    ''' <summary></summary>
    Public Const MSGID_20000036 As String = "20000036"
    ''' <summary></summary>
    Public Const MSGID_20000037 As String = "20000037"
    ''' <summary></summary>
    Public Const MSGID_20000038 As String = "20000038"
    ''' <summary></summary>
    Public Const MSGID_20000039 As String = "20000039"
    ''' <summary></summary>
    Public Const MSGID_20000040 As String = "20000040"
    ''' <summary></summary>
    Public Const MSGID_20000041 As String = "20000041"
    ''' <summary></summary>
    Public Const MSGID_20000042 As String = "20000042"
    ''' <summary>編集中確認メッセージ（部門ログアウト時）</summary>
    ''' <remarks>※20000044と重複のような気もする</remarks>
    Public Const MSGID_20000043 As String = "20000043"
    ''' <summary>編集中確認メッセージ（閉じる場合）</summary>
    Public Const MSGID_20000044 As String = "20000044"
    ''' <summary></summary>
    Public Const MSGID_20000045 As String = "20000045"
    ''' <summary></summary>
    Public Const MSGID_20000046 As String = "20000046"
    ''' <summary></summary>
    Public Const MSGID_20000047 As String = "20000047"
    ''' <summary></summary>
    Public Const MSGID_20000048 As String = "20000048"
    ''' <summary></summary>
    Public Const MSGID_20000049 As String = "20000049"
    ''' <summary></summary>
    Public Const MSGID_20000050 As String = "20000050"
    ''' <summary></summary>
    Public Const MSGID_20000051 As String = "20000051"
    ''' <summary></summary>
    Public Const MSGID_20000052 As String = "20000052"
    ''' <summary></summary>
    Public Const MSGID_20000053 As String = "20000053"
    ''' <summary></summary>
    Public Const MSGID_20000054 As String = "20000054"
    ''' <summary></summary>
    Public Const MSGID_20000055 As String = "20000055"
    ''' <summary></summary>
    Public Const MSGID_20000056 As String = "20000056"
    ''' <summary></summary>
    Public Const MSGID_20000057 As String = "20000057"
    ''' <summary>編集中確認メッセージ（新規、修正時）</summary>
    Public Const MSGID_20000058 As String = "20000058"
    ''' <summary></summary>
    Public Const MSGID_20000059 As String = "20000059"
    ''' <summary></summary>
    Public Const MSGID_20000060 As String = "20000060"
    ''' <summary></summary>
    Public Const MSGID_20000061 As String = "20000061"
    ''' <summary></summary>
    Public Const MSGID_20000062 As String = "20000062"
    ''' <summary></summary>
    Public Const MSGID_20000063 As String = "20000063"
    ''' <summary>編集中確認メッセージ（重複⇒20000058を使用してください）</summary>
    Public Const MSGID_20000064 As String = "20000064"
    ''' <summary></summary>
    Public Const MSGID_20000065 As String = "20000065"
    ''' <summary></summary>
    Public Const MSGID_20000066 As String = "20000066"
    ''' <summary></summary>
    Public Const MSGID_20000067 As String = "20000067"
    ''' <summary></summary>
    Public Const MSGID_20000068 As String = "20000068"
    ''' <summary></summary>
    Public Const MSGID_20000069 As String = "20000069"
    ''' <summary></summary>
    Public Const MSGID_20000070 As String = "20000070"
    ''' <summary></summary>
    Public Const MSGID_20000071 As String = "20000071"
    ''' <summary></summary>
    Public Const MSGID_20000072 As String = "20000072"
    ''' <summary></summary>
    Public Const MSGID_20000073 As String = "20000073"
    ''' <summary></summary>
    Public Const MSGID_20000074 As String = "20000074"
    ''' <summary></summary>
    Public Const MSGID_20000075 As String = "20000075"
    ''' <summary></summary>
    Public Const MSGID_20000076 As String = "20000076"
    ''' <summary></summary>
    Public Const MSGID_20000077 As String = "20000077"
    ''' <summary></summary>
    Public Const MSGID_20000078 As String = "20000078"
    ''' <summary></summary>
    Public Const MSGID_20000079 As String = "20000079"
    ''' <summary></summary>
    Public Const MSGID_20000080 As String = "20000080"
    ''' <summary></summary>
    Public Const MSGID_20000081 As String = "20000081"
    ''' <summary></summary>
    Public Const MSGID_20000082 As String = "20000082"
    ''' <summary></summary>
    Public Const MSGID_20000083 As String = "20000083"
    ''' <summary></summary>
    Public Const MSGID_20000084 As String = "20000084"
    ''' <summary></summary>
    Public Const MSGID_20000085 As String = "20000085"
    ''' <summary></summary>
    Public Const MSGID_20000086 As String = "20000086"
    ''' <summary></summary>
    Public Const MSGID_20000087 As String = "20000087"
    ''' <summary></summary>
    Public Const MSGID_20000088 As String = "20000088"
    ''' <summary></summary>
    Public Const MSGID_20000089 As String = "20000089"
    ''' <summary></summary>
    Public Const MSGID_20000090 As String = "20000090"
    ''' <summary></summary>
    Public Const MSGID_20000091 As String = "20000091"
    ''' <summary></summary>
    Public Const MSGID_20000092 As String = "20000092"
    ''' <summary></summary>
    Public Const MSGID_20000093 As String = "20000093"
    ''' <summary></summary>
    Public Const MSGID_20000094 As String = "20000094"
    ''' <summary></summary>
    Public Const MSGID_20000095 As String = "20000095"
    ''' <summary></summary>
    Public Const MSGID_20000096 As String = "20000096"
    ''' <summary></summary>
    Public Const MSGID_20000097 As String = "20000097"
    ''' <summary></summary>
    Public Const MSGID_20000098 As String = "20000098"
    ''' <summary></summary>
    Public Const MSGID_20000099 As String = "20000099"
    ''' <summary></summary>
    Public Const MSGID_20000100 As String = "20000100"
    ''' <summary></summary>
    Public Const MSGID_20000101 As String = "20000101"
    ''' <summary></summary>
    Public Const MSGID_20000102 As String = "20000102"
    ''' <summary></summary>
    Public Const MSGID_20000103 As String = "20000103"
    ''' <summary></summary>
    Public Const MSGID_20000104 As String = "20000104"
    ''' <summary></summary>
    Public Const MSGID_20000105 As String = "20000105"
    ''' <summary></summary>
    Public Const MSGID_20000106 As String = "20000106"
    ''' <summary></summary>
    Public Const MSGID_20000107 As String = "20000107"
    ''' <summary></summary>
    Public Const MSGID_20000108 As String = "20000108"
    ''' <summary></summary>
    Public Const MSGID_20000109 As String = "20000109"
    ''' <summary></summary>
    Public Const MSGID_20000110 As String = "20000110"
    ''' <summary></summary>
    Public Const MSGID_20000111 As String = "20000111"
    ''' <summary></summary>
    Public Const MSGID_20000112 As String = "20000112"
    ''' <summary></summary>
    Public Const MSGID_20000113 As String = "20000113"
    ''' <summary></summary>
    Public Const MSGID_20000114 As String = "20000114"
    ''' <summary></summary>
    Public Const MSGID_20000115 As String = "20000115"
    ''' <summary></summary>
    Public Const MSGID_20000116 As String = "20000116"
    ''' <summary></summary>
    Public Const MSGID_20000117 As String = "20000117"
    ''' <summary></summary>
    Public Const MSGID_20000118 As String = "20000118"
    ''' <summary></summary>
    Public Const MSGID_20000119 As String = "20000119"
    ''' <summary></summary>
    Public Const MSGID_20000120 As String = "20000120"
    ''' <summary></summary>
    Public Const MSGID_20000121 As String = "20000121"
    ''' <summary></summary>
    Public Const MSGID_20000122 As String = "20000122"
    ''' <summary></summary>
    Public Const MSGID_20000123 As String = "20000123"
    ''' <summary></summary>
    Public Const MSGID_20000124 As String = "20000124"
    ''' <summary></summary>
    Public Const MSGID_20000125 As String = "20000125"
    ''' <summary></summary>
    Public Const MSGID_20000126 As String = "20000126"
    ''' <summary></summary>
    Public Const MSGID_20000127 As String = "20000127"
    ''' <summary></summary>
    Public Const MSGID_20000128 As String = "20000128"
    ''' <summary></summary>
    Public Const MSGID_20000129 As String = "20000129"
    ''' <summary></summary>
    Public Const MSGID_20000130 As String = "20000130"
    ''' <summary></summary>
    Public Const MSGID_20000131 As String = "20000131"
    ''' <summary></summary>
    Public Const MSGID_20000132 As String = "20000132"
    ''' <summary></summary>
    Public Const MSGID_20000133 As String = "20000133"
    ''' <summary></summary>
    Public Const MSGID_20000134 As String = "20000134"
    ''' <summary></summary>
    Public Const MSGID_20000135 As String = "20000135"
    ''' <summary></summary>
    Public Const MSGID_20000136 As String = "20000136"
    ''' <summary></summary>
    Public Const MSGID_20000137 As String = "20000137"
    ''' <summary></summary>
    Public Const MSGID_20000138 As String = "20000138"
    ''' <summary></summary>
    Public Const MSGID_20000139 As String = "20000139"
    ''' <summary></summary>
    Public Const MSGID_20000140 As String = "20000140"
    ''' <summary></summary>
    Public Const MSGID_20000141 As String = "20000141"
    ''' <summary></summary>
    Public Const MSGID_20000142 As String = "20000142"
    ''' <summary></summary>
    Public Const MSGID_20000143 As String = "20000143"
    ''' <summary></summary>
    Public Const MSGID_20000144 As String = "20000144"
    ''' <summary></summary>
    Public Const MSGID_20000145 As String = "20000145"
    ''' <summary></summary>
    Public Const MSGID_20000146 As String = "20000146"
    ''' <summary></summary>
    Public Const MSGID_20000147 As String = "20000147"
    ''' <summary></summary>
    Public Const MSGID_20000148 As String = "20000148"
    ''' <summary></summary>
    Public Const MSGID_20000149 As String = "20000149"
    ''' <summary></summary>
    Public Const MSGID_20000150 As String = "20000150"
    ''' <summary></summary>
    Public Const MSGID_20000151 As String = "20000151"
    ''' <summary></summary>
    Public Const MSGID_20000152 As String = "20000152"
    ''' <summary></summary>
    Public Const MSGID_20000153 As String = "20000153"
    ''' <summary></summary>
    Public Const MSGID_20000154 As String = "20000154"
    ''' <summary></summary>
    Public Const MSGID_20000155 As String = "20000155"
    ''' <summary></summary>
    Public Const MSGID_20000156 As String = "20000156"
    ''' <summary></summary>
    Public Const MSGID_20000157 As String = "20000157"
    ''' <summary></summary>
    Public Const MSGID_20000158 As String = "20000158"
    ''' <summary></summary>
    Public Const MSGID_20000159 As String = "20000159"
    ''' <summary></summary>
    Public Const MSGID_20000160 As String = "20000160"
    ''' <summary></summary>
    Public Const MSGID_20000161 As String = "20000161"
    ''' <summary></summary>
    Public Const MSGID_20000162 As String = "20000162"
    ''' <summary></summary>
    Public Const MSGID_20000163 As String = "20000163"
    ''' <summary></summary>
    Public Const MSGID_20000164 As String = "20000164"
    ''' <summary></summary>
    Public Const MSGID_20000165 As String = "20000165"
    ''' <summary></summary>
    Public Const MSGID_20000166 As String = "20000166"
    ''' <summary></summary>
    Public Const MSGID_20000167 As String = "20000167"
    ''' <summary></summary>
    Public Const MSGID_20000168 As String = "20000168"
    ''' <summary></summary>
    Public Const MSGID_20000169 As String = "20000169"
    ''' <summary></summary>
    Public Const MSGID_20000170 As String = "20000170"
    ''' <summary></summary>
    Public Const MSGID_20000171 As String = "20000171"
    ''' <summary></summary>
    Public Const MSGID_20000172 As String = "20000172"
    ''' <summary></summary>
    Public Const MSGID_20000173 As String = "20000173"
    ''' <summary></summary>
    Public Const MSGID_20000174 As String = "20000174"
#End Region

#Region "300番台"
    ''' <summary></summary>
    Public Const MSGID_30000001 As String = "30000001"
    ''' <summary></summary>
    Public Const MSGID_30000002 As String = "30000002"
    ''' <summary></summary>
    Public Const MSGID_30000003 As String = "30000003"
    ''' <summary></summary>
    Public Const MSGID_30000004 As String = "30000004"
    ''' <summary></summary>
    Public Const MSGID_30000005 As String = "30000005"
    ''' <summary></summary>
    Public Const MSGID_30000006 As String = "30000006"
    ''' <summary></summary>
    Public Const MSGID_30000007 As String = "30000007"
    ''' <summary></summary>
    Public Const MSGID_30000008 As String = "30000008"
    ''' <summary></summary>
    Public Const MSGID_30000009 As String = "30000009"
    ''' <summary></summary>
    Public Const MSGID_30000010 As String = "30000010"
    ''' <summary></summary>
    Public Const MSGID_30000011 As String = "30000011"
    ''' <summary></summary>
    Public Const MSGID_30000012 As String = "30000012"
    ''' <summary></summary>
    Public Const MSGID_30000013 As String = "30000013"
#End Region

#Region "400番台"
    ''' <summary></summary>
    Public Const MSGID_40000001 As String = "40000001"
    ''' <summary></summary>
    Public Const MSGID_40000002 As String = "40000002"
    ''' <summary></summary>
    Public Const MSGID_40000003 As String = "40000003"
    ''' <summary></summary>
    Public Const MSGID_40000004 As String = "40000004"
#End Region

#Region "900番台"
    ''' <summary>
    ''' <para>システムエラー時（画面用）</para>
    ''' <para>[0]プログラム名</para>
    ''' <para>[1]エラーコード</para>
    ''' </summary>
    Public Const MSGID_90000001 As String = "90000001"
    ''' <summary>
    ''' <para>システムエラー時（ログ用）</para>
    ''' <para>[0]ex.Message</para>
    ''' </summary>
    Public Const MSGID_90000002 As String = "90000002"
    ''' <summary></summary>
    Public Const MSGID_90000003 As String = "90000003"
    ''' <summary></summary>
    Public Const MSGID_90000006 As String = "90000006"
    ''' <summary>
    ''' <para>印刷エラー時（POPUPなし）</para>
    ''' <para>[0]患者ID</para>
    ''' <para>[1]職員ID</para>
    ''' <para>[2]実行マシン</para>
    ''' </summary>
    Public Const MSGID_90000010 As String = "90000010"
#End Region

#End Region

#Region "受付関連"
    ''' <summary>受診状況種別（受付関連）</summary>
    Public Enum enmReceptionType
        ''' <summary>受診状況種別：予約</summary>
        Reservation = 1             '予約
        ''' <summary>受診状況種別：受付済</summary>
        ReceptionCompleted = 2      '受付済
        ''' <summary>受診状況種別：診察待</summary>
        MedicalCareWait = 3         '診察待
        ''' <summary>受診状況種別：診察中</summary>
        MedicalCareIn = 4           '診察中
        ''' <summary>受診状況種別：検査待</summary>
        ExamWait = 5                '検査待
        ''' <summary>受診状況種別：検査中</summary>
        ExamIn = 6                  '検査中
        ''' <summary>受診状況種別：診察済</summary>
        MedicalCareCompleted = 9    '診察済
    End Enum

#End Region
   
#Region "診療種別"
    ''' <summary>診療種別</summary>
    Public Enum enmMedicalCareType
        ''' <summary>診療種別：初診</summary>
        FirstVisit = 1
        ''' <summary>診療種別：再診</summary>
        RepeatedVisit = 2
    End Enum
#End Region

#Region "問題点管理"
    ''' <summary>問題点番号　接頭文字：一時的</summary>
    Public Const PRIFIX_TEMP As String = "T"
    ''' <summary>問題点番号　接頭文字：一般</summary>
    Public Const PRIFIX_GENERAL As String = "#"
#End Region

    ''' <summary>フラグ値</summary>
    Public Enum enmFlag
        ''' <summary>OFF(False)</summary>
        FlagOff = 0
        ''' <summary>ON(True)</summary>
        FlagOn = 1
    End Enum

#Region "患者情報"
    ''' <summary>年齢表示 歳の文字列</summary>
    Public Const AGE_STRING As String = "歳"
    '後期高齢区分
    Public Const Kouki_Kourei_Kubun As String = "039"
    '後期高齢(７割給付)負担割合
    Public Const Kouki_Kourei_Futan As Decimal = 0.3
#End Region

#Region "ID表示桁数"
    ''' <summary>表示用職員ID　桁数</summary>
    Public Const LEN_STAFF_ID As Integer = 12
#End Region

#Region "身体計測データ"
    Public Const BODY_DATA_ALB As String = "ALB"
    Public Const BODY_DATA_BMI As String = "BMI"
    Public Const BODY_DATA_TSF As String = "TSF"
    Public Const BODY_DATA_MAC As String = "MAC"
    Public Const BODY_DATA_AMC As String = "AMC"
    Public Const BODY_DATA_AMA As String = "AMA"
#End Region

#Region "オーダ種別"
    'オーダ名称等が変更される可能性があるため、番号で宣言する
    '⇒enmOrderTypeに列挙値で定義されているので、そちらを使用してください。
    ''' <summary>enmOrderType.TeachingOrderを使用してください</summary>
    Public Const ORDERTYPE_13 As String = "13"
    ''' <summary>enmOrderType.Prescriptionを使用してください</summary>
    Public Const ORDERTYPE_20 As String = "20"
    ''' <summary>enmOrderType.Injectionを使用してください</summary>
    Public Const ORDERTYPE_30 As String = "30"
    ''' <summary>enmOrderType.Aidを使用してください</summary>
    Public Const ORDERTYPE_40 As String = "40"
    ''' <summary>enmOrderType.LaboratoryExamを使用してください</summary>
    Public Const ORDERTYPE_61 As String = "61"
    ''' <summary>enmOrderType.PhysiologicalExamを使用してください</summary>
    Public Const ORDERTYPE_62 As String = "62"
    ''' <summary>enmOrderType.Endscopeを使用してください</summary>
    Public Const ORDERTYPE_63 As String = "63"
    ''' <summary>enmOrderType.Bacteriaを使用してください</summary>
    Public Const ORDERTYPE_64 As String = "64"
    ''' <summary>enmOrderType.ImagingExamを使用してください</summary>
    Public Const ORDERTYPE_70 As String = "70"
    ''' <summary>enmOrderType.Rehabを使用してください</summary>
    Public Const ORDERTYPE_81 As String = "81"
    Public Const ORDERTYPE_98 As String = "98"  '看護
#End Region

#Region "代行承認状態"
    ''' <summary>代行承認状態・未承認「未」</summary>
    Public ReadOnly NonAdmitState As String = "未"
    ''' <summary>代行承認状態・承認済み「済」</summary>
    Public ReadOnly AdmitState As String = "済"
#End Region

#Region "薬品メンテ確認用"



    Public Const SAFETYTYPE_21 As String = "21"  '看護

    Public Const ORDER_DETAIL_CLASS1 As String = "200"
    Public Const ORDER_DETAIL_CLASS2 As String = "900"
    Public Const ORDER_DETAIL_CLASS3 As String = "003"



#End Region

End Module
