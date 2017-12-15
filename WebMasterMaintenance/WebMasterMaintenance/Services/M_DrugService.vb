Imports System.Data.Entity

Public Class M_DrugService

    'Public Function M_ToSearch(db As AsamaEntities, conditionModel As M_DrugCondition, MasterType As String, FacilityID As String) As List(Of M_DrugEX)

    '    Dim dtNow As DateTime = DateTime.Now
    '    'LogNo最大値取得
    '    Dim maxgroup = From m In db.M_Drug
    '                   Where m.MDRG_DelFlag = 0 And m.MDRG_FacilityID = FacilityID
    '                   Group m By m.MDRG_FacilityID, m.MDRG_HotCode Into maxlog = Group
    '                   Select MDRG_FacilityID, MDRG_HotCode, MaxLogNo = maxlog.Max(Function(x) x.MDRG_LogNo)

    '    Dim query = From e In db.M_Drug
    '                Group Join m In maxgroup On e.MDRG_FacilityID Equals m.MDRG_FacilityID And
    '                    e.MDRG_HotCode Equals m.MDRG_HotCode
    '                    Into maxgrp = Group
    '                From m In maxgrp.DefaultIfEmpty
    '                Where e.MDRG_DelFlag = 0 And e.MDRG_FacilityID = FacilityID
    '                Order By e.MDRG_HotCode, e.MDRG_ValidDateFrom
    '                Select e, m
    '    '↑Max Log は複写不可のため取得                    

    '    'タイプによって絞込みを変更
    '    Select Case MasterType
    '        Case 1
    '            query = From q In query Where (q.e.MDRG_DosageFormClass.Contains("1") _
    '                                    OrElse q.e.MDRG_DosageFormClass.Contains("4") _
    '                                    OrElse q.e.MDRG_DosageFormClass.Contains("6")) _
    '                                    And q.e.MDRG_OrderTransfusionFlag <> "1"
    '        Case 2
    '            query = From q In query Where q.e.MDRG_DosageFormClass.Contains("3")
    '        Case 3
    '            query = From q In query Where q.e.MDRG_OrderTransfusionFlag = "1"
    '    End Select

    '    'MDRG_HotCode
    '    If Not String.IsNullOrEmpty(conditionModel.Model.MDRG_HotCode) Then
    '        query = From q In query Where q.e.MDRG_HotCode.Contains(conditionModel.Model.MDRG_HotCode)
    '    End If

    '    'MDRG_DrugName 部分一致
    '    If Not String.IsNullOrEmpty(conditionModel.Model.MDRG_DrugName) Then
    '        Dim strDrugName As String = conditionModel.Model.MDRG_DrugName
    '        query = From q In query Where (q.e.MDRG_DrugName.Contains(strDrugName) _
    '                                OrElse q.e.MDRG_DrugKana.Contains(strDrugName) _
    '                                OrElse q.e.MDRG_SalesName.Contains(strDrugName) _
    '                                OrElse q.e.MDRG_PublicName.Contains(strDrugName) _
    '                                OrElse q.e.MDRG_ComponentName.Contains(strDrugName) _
    '                                OrElse q.e.MDRG_OriginalName.Contains(strDrugName))
    '    End If

    '    'MDRG_DosageFormClass
    '    If Not String.IsNullOrEmpty(conditionModel.Model.MDRG_DosageFormClass) Then
    '        Dim s As String() = conditionModel.Model.MDRG_DosageFormClass.Split(",")
    '        query = From q In query Where s.Contains(q.e.MDRG_DosageFormClass)
    '    End If

    '    Dim lst As New List(Of M_DrugEX)
    '    For Each e In query.ToList()
    '        Dim mdl As New M_DrugEX
    '        mdl.SetFromOriginalModel(e.e)
    '        mdl.MaxLog = e.m.MaxLogNo
    '        lst.Add(mdl)
    '    Next
    '    Return lst

    'End Function

    '''' <summary>
    '''' UPDATE
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="m_drug"></param>
    '''' <param name="SaveChange"></param>
    'Public Function Update(db As AsamaEntities, m_drug As M_DrugEX, staffId As String, HostName As String, Optional SaveChange As Boolean = False) As M_DrugEX

    '    '*** 履歴保存する

    '    '変更前を削除
    '    Dim rtnex As M_Drug = db.M_Drug.Find(m_drug.MDRG_FacilityID, m_drug.MDRG_HotCode, m_drug.MDRG_LogNo)
    '    rtnex.MDRG_DelFlag = 1
    '    db.Entry(rtnex).State = EntityState.Modified

    '    '削除時は抜ける
    '    If m_drug.MDRG_DelFlag = "1" Then
    '        If SaveChange Then
    '            db.SaveChanges()
    '        End If
    '        Return m_drug
    '    End If

    '    '変更後を新規
    '    Dim newmdl As New M_DrugEX()
    '    newmdl.SetFromOriginalModel(m_drug.GetOriginalModel())
    '    'LogNo取得
    '    Dim brothers = From e In db.M_Drug
    '                   Where e.MDRG_FacilityID = m_drug.MDRG_FacilityID And
    '                             e.MDRG_HotCode = m_drug.MDRG_HotCode
    '    newmdl.MDRG_LogNo = brothers.Max(Function(x) x.MDRG_LogNo) + 1
    '    Me.Insert(db, newmdl, staffId, HostName)

    '    If SaveChange Then
    '        db.SaveChanges()
    '    End If
    '    Return newmdl

    'End Function

    '''' <summary>
    '''' INSERT M_DrugExMaterial
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="m_drug"></param>
    '''' <param name="staffId"></param>
    '''' <param name="HostName"></param>
    '''' <param name="SaveChange"></param>
    'Public Sub Insert(db As AsamaEntities, m_drug As M_DrugEX, staffId As String, HostName As String, Optional SaveChange As Boolean = False)

    '    m_drug.MDRG_UpdateStaffID = staffId
    '    m_drug.MDRG_UpdateClientName = HostName
    '    m_drug.MDRG_UpdateDate = Now()
    '    If m_drug.MDRG_StatusClass = "1" Then
    '        m_drug.MDRG_StatusClass = "2"
    '    End If

    '    '必須項目の置き換え
    '    m_drug.MDRG_ReceiptCode = If(m_drug.MDRG_ReceiptCode Is Nothing, Common.DefaultOfType(m_drug.MDRG_ReceiptCode), m_drug.MDRG_ReceiptCode)
    '    m_drug.MDRG_StandardCode = If(m_drug.MDRG_StandardCode Is Nothing, Common.DefaultOfType(m_drug.MDRG_StandardCode), m_drug.MDRG_StandardCode)
    '    m_drug.MDRG_MHLWCode = If(m_drug.MDRG_MHLWCode Is Nothing, Common.DefaultOfType(m_drug.MDRG_MHLWCode), m_drug.MDRG_MHLWCode)
    '    m_drug.MDRG_DrugName = If(m_drug.MDRG_DrugName Is Nothing, Common.DefaultOfType(m_drug.MDRG_DrugName), m_drug.MDRG_DrugName)
    '    m_drug.MDRG_DrugKana = If(m_drug.MDRG_DrugKana Is Nothing, Common.DefaultOfType(m_drug.MDRG_DrugKana), m_drug.MDRG_DrugKana)
    '    m_drug.MDRG_SalesName = If(m_drug.MDRG_SalesName Is Nothing, Common.DefaultOfType(m_drug.MDRG_SalesName), m_drug.MDRG_SalesName)
    '    m_drug.MDRG_NarcoticClass = If(m_drug.MDRG_NarcoticClass Is Nothing, Common.DefaultOfType(m_drug.MDRG_NarcoticClass), m_drug.MDRG_NarcoticClass)
    '    m_drug.MDRG_DosageFormClass = If(m_drug.MDRG_DosageFormClass Is Nothing, Common.DefaultOfType(m_drug.MDRG_DosageFormClass), m_drug.MDRG_DosageFormClass)
    '    m_drug.MDRG_AdoptClass = If(m_drug.MDRG_AdoptClass Is Nothing, Common.DefaultOfType(m_drug.MDRG_AdoptClass), m_drug.MDRG_AdoptClass)

    '    db.M_Drug.Add(m_drug.GetOriginalModel)

    '    If SaveChange Then
    '        db.SaveChanges()
    '    End If

    'End Sub

    '''' <summary>
    '''' 複写登録
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="m_Drug"></param>
    '''' <param name="staffid"></param>
    '''' <param name="host"></param>
    'Public Sub CopyRegist(db As AsamaEntities, m_Drug As M_DrugEX, staffid As String, host As String)

    '    Using tran = db.Database.BeginTransaction
    '        Try
    '            ''旧モデルの取得
    '            'Dim old As M_Drug = db.M_Drug.Find(m_Drug.MDRG_FacilityID, m_Drug.MDRG_HotCode, m_Drug.MDRG_LogNo)
    '            'If old.MDRG_ValidDateFrom < m_Drug.MDRG_ValidDateFrom Then
    '            '    old.MDRG_ValidDateTo = m_Drug.MDRG_ValidDateFrom.AddDays(-1)
    '            'End If
    '            'old.MDRG_UpdateDate = Now()
    '            'old.MDRG_UpdateStaffID = staffid
    '            'old.MDRG_UpdateClientName = host
    '            'db.Entry(old).State = EntityState.Modified
    '            ''db.SaveChanges()

    '            '新モデル
    '            'LogNo取得
    '            Dim brothers = From e In db.M_Drug
    '                           Where e.MDRG_FacilityID = m_Drug.MDRG_FacilityID And
    '                                 e.MDRG_HotCode = m_Drug.MDRG_HotCode
    '            m_Drug.MDRG_LogNo = brothers.Max(Function(x) x.MDRG_LogNo) + 1
    '            Me.Insert(db, m_Drug, staffid, host)

    '            db.SaveChanges()

    '            tran.Commit()

    '        Catch ex As Exception
    '            tran.Rollback()
    '            Throw
    '        End Try

    '    End Using

    'End Sub

    '''' <summary>
    '''' 削除時チェック
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="mdl"></param>
    '''' <param name="msg"></param>
    '''' <returns></returns>
    'Public Function CheckDeleteMDrug(db As AsamaEntities, mdl As M_Drug, ByRef msg As String) As Boolean


    '    ''（途中履歴）は、削除できません。
    '    'If Not CheckLog(db, mdl) Then
    '    '    '途中履歴エラー
    '    '    msg = Message.MSG_NODELETE_LOG
    '    '    Return False
    '    'End If

    '    'カルテで使用されているため、削除できません。
    '    If Not Me.CheckKarte20(db, mdl) Then
    '        '使用済みエラー
    '        msg = Message.MSG_KARTE_USED
    '        Return False
    '    End If
    '    '注射 200	900	003
    '    If Not Me.CheckKarte30(db, mdl) Then
    '        '使用済みエラー
    '        msg = Message.MSG_KARTE_USED
    '        Return False
    '    End If
    '    '処置
    '    If Not Me.CheckKarte40(db, mdl) Then
    '        '使用済みエラー
    '        msg = Message.MSG_KARTE_USED
    '        Return False
    '    End If
    '    '輸血
    '    If Not Me.CheckKarte55(db, mdl) Then
    '        '使用済みエラー
    '        msg = Message.MSG_KARTE_USED
    '        Return False
    '    End If
    '    '放射線
    '    If Not Me.CheckKarte70(db, mdl) Then
    '        '使用済みエラー
    '        msg = Message.MSG_KARTE_USED
    '        Return False
    '    End If
    '    '放射線部門
    '    If Not Me.CheckOrderRecordTools70(db, mdl) Then
    '        '使用済みエラー
    '        msg = Message.MSG_KARTE_USED
    '        Return False
    '    End If
    '    '診療基本
    '    If Not Me.CheckSafetyInfo(db, mdl) Then
    '        '使用済みエラー
    '        msg = Message.MSG_KARTE_USED
    '        Return False
    '    End If
    '    'エラーがないとき
    '    Return True

    'End Function
    '''' <summary>
    '''' LOG番号チェック
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="mdl"></param>
    '''' <returns></returns>
    'Public Function CheckLog(db As AsamaEntities, mdl As M_Drug) As Boolean
    '    Try
    '        Dim max = (From e In db.M_Drug
    '                   Where e.MDRG_FacilityID = mdl.MDRG_FacilityID And
    '                     e.MDRG_HotCode = mdl.MDRG_HotCode And
    '                     e.MDRG_DelFlag = 0
    '                   Select e.MDRG_LogNo).Max

    '        If mdl.MDRG_LogNo < max Then
    '            'エラー
    '            Return False
    '        End If

    '    Catch ex As Exception
    '    Finally
    '        mdl = New M_Drug
    '    End Try

    '    Return True

    'End Function

    '''' <summary>
    '''' 
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="mdl"></param>
    '''' <param name="msg"></param>
    '''' <returns></returns>
    'Public Function CheckUpdateDrug(db As AsamaEntities, mdl As M_Drug, ByRef msg As String, Optional CopyFlg As Boolean = False) As Boolean

    '    '関連チェック
    '    If mdl.MDRG_ValidDateFrom > mdl.MDRG_ValidDateTo Then
    '        '日付矛盾エラー
    '        msg = Message.MSG_20000035
    '        Return False
    '    End If

    '    'コピー時には開始日チェックを行わない
    '    If Not CopyFlg Then
    '        'REP START 2017/09/15 FSI星野 #12083 複写時に初回登録した有効開始日より未来日に変更できない
    '        '開始日変更チェック
    '        Dim Val As Date = AsamaConst.UndefDateMin
    '        Dim Err As String = String.Empty
    '        'カルテ使用があるかを確認
    '        If Not CheckDeleteMDrug(db, mdl, Err) Then
    '            'カルテ使用がある場合は開始日チェックを行う
    '            If Not CheckValidateFromDate(db, mdl, Val) Then
    '                msg = String.Format(Message.MSG_BEFORE_VALIDDATE_FROM, Val.ToShortDateString)
    '                Return False
    '            End If
    '        End If
    '        'REP END   2017/09/15 FSI星野 #12083 複写時に初回登録した有効開始日より未来日に変更できない
    '        'DEL START 2017/09/15 FSI星野 #12083 複写時に初回登録した有効開始日より未来日に変更できない
    '        'If Val <> mdl.MDRG_ValidDateFrom Then
    '        '    Dim Err As String = String.Empty
    '        '    If Not CheckDeleteMDrug(db, mdl, Err) Then
    '        '        msg = Err.Replace("削除", "開始日の変更は")
    '        '        Return False
    '        '    End If
    '        'End If
    '        'DEL EMD   2017/09/15 FSI星野 #12083 複写時に初回登録した有効開始日より未来日に変更できない
    '    End If

    '    '終了日付は本日以降とする
    '    Dim NowDate As Date = DateTime.Now
    '    NowDate = CType(NowDate.ToShortDateString, DateTime).AddDays(1).AddSeconds(-1)
    '    If mdl.MDRG_ValidDateTo < NowDate Then
    '        '日付エラー
    '        msg = String.Format(Message.MSG_BEFORE_VALIDDATE_TO, NowDate.ToShortDateString)
    '        Return False
    '    End If

    '    '有効期限が重複しています。
    '    If Not CheckValidateDate(db, mdl, CopyFlg) Then
    '        msg = Message.MSG_DUPLICATE_VALIDDATE
    '        Return False
    '    End If

    '    Return True

    'End Function

    '''' <summary>
    '''' 有効期限チェック
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="mdl"></param>
    '''' <returns></returns>
    'Public Function CheckValidateDate(db As AsamaEntities, mdl As M_Drug, CopyFlg As Boolean) As Boolean

    '    Dim bro = From e In db.M_Drug
    '              Where e.MDRG_FacilityID = mdl.MDRG_FacilityID And
    '                     e.MDRG_HotCode = mdl.MDRG_HotCode And
    '                     e.MDRG_DelFlag = 0 And
    '                     e.MDRG_ValidDateTo >= mdl.MDRG_ValidDateFrom And
    '                     e.MDRG_ValidDateFrom <= mdl.MDRG_ValidDateTo
    '              Select e

    '    If Not CopyFlg Then
    '        bro = From e In bro Where e.MDRG_LogNo <> mdl.MDRG_LogNo
    '    End If

    '    If bro.Count > 0 Then
    '        'エラー
    '        Return False
    '    End If

    '    Return True

    'End Function

    '''' <summary>
    '''' 開始日変更の確認
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="mdl"></param>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Function CheckValidateFromDate(db As AsamaEntities, mdl As M_Drug, ByRef Val As Date) As Boolean
    '    'Public Function CheckValidateFromDate(db As AsamaEntities, mdl As M_Drug, ByRef Val As Date) As Boolean
    '    'Public Function CheckValidateFromDate(db As AsamaEntities, mdl As M_Drug, CopyFlg As Boolean, ByRef Val As Date) As Boolean

    '    'REP START 2017/09/15 FSI星野 #12083 複写時に初回登録した有効開始日より未来日に変更できない
    '    'DEL START 2017-09-05 FSI星野 #12019 複写時にカルテで使用がある場合に有効開始日を変更できない
    '    'コピーの場合は対象としない
    '    'If Not CopyFlg Then
    '    'If (old.MDRG_ValidDateFrom <> AsamaConst.UndefDateMin AndAlso old.MDRG_ValidDateFrom < mdl.MDRG_ValidDateFrom) Then
    '    '旧モデルの取得
    '    Dim old As M_Drug = db.M_Drug.Find(mdl.MDRG_FacilityID, mdl.MDRG_HotCode, mdl.MDRG_LogNo)
    '    Dim DateNow As DateTime = CType(DateTime.Now.ToShortDateString, Date)
    '    If (old.MDRG_ValidDateFrom <= DateNow AndAlso old.MDRG_ValidDateFrom < mdl.MDRG_ValidDateFrom) Then
    '        'エラー
    '        Val = old.MDRG_ValidDateFrom
    '        Return False
    '    End If
    '    Val = old.MDRG_ValidDateFrom
    '    'End If
    '    'DEL END   2017-09-05 FSI星野 #12019 複写時にカルテで使用がある場合に有効開始日を変更できない
    '    'REP END   2017/09/15 FSI星野 #12083 複写時に初回登録した有効開始日より未来日に変更できない

    '    Return True

    'End Function

    '''' <summary>
    '''' 処方オーダ使用有無
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="mdl"></param>
    '''' <returns></returns>
    'Private Function CheckKarte20(db As AsamaEntities, mdl As M_Drug) As Boolean

    '    '処方 200	900	003
    '    Dim karte20 = From e In db.T_OrderDetail_20
    '                  Where e.TORD_FacilityID = mdl.MDRG_FacilityID And
    '                    e.TORD_Class1 = ORDER_DETAIL_CLASS1 And
    '                    e.TORD_Class2 = ORDER_DETAIL_CLASS2 And
    '                    e.TORD_Class3 = ORDER_DETAIL_CLASS3 And
    '                    mdl.MDRG_HotCode.Trim = e.TORD_Record.Trim
    '                  Select e

    '    Return (karte20.ToList.Count = 0)

    'End Function

    '''' <summary>
    '''' 注射チェック
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="mdl"></param>
    '''' <returns></returns>
    'Private Function CheckKarte30(db As AsamaEntities, mdl As M_Drug) As Boolean

    '    '注射 200	900	003
    '    Dim karte30 = From e In db.T_OrderDetail_30
    '                  Where e.TORD_FacilityID = mdl.MDRG_FacilityID And
    '                    e.TORD_Class1 = ORDER_DETAIL_CLASS1 And
    '                    e.TORD_Class2 = ORDER_DETAIL_CLASS2 And
    '                    e.TORD_Class3 = ORDER_DETAIL_CLASS3 And
    '                    mdl.MDRG_HotCode.Trim = e.TORD_Record.Trim
    '                  Select e

    '    Return (karte30.ToList.Count = 0)

    'End Function

    '''' <summary>
    '''' 処置チェック
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="mdl"></param>
    '''' <returns></returns>
    'Private Function CheckKarte40(db As AsamaEntities, mdl As M_Drug) As Boolean

    '    '処置 200	900	003
    '    Dim karte40 = From e In db.T_OrderDetail_40
    '                  Where e.TORD_FacilityID = mdl.MDRG_FacilityID And
    '                    e.TORD_Class1 = ORDER_DETAIL_CLASS1 And
    '                    e.TORD_Class2 = ORDER_DETAIL_CLASS2 And
    '                    e.TORD_Class3 = ORDER_DETAIL_CLASS3 And
    '                   mdl.MDRG_HotCode.Trim = e.TORD_Record.Trim
    '                  Select e

    '    Return (karte40.ToList.Count = 0)

    'End Function

    '''' <summary>
    '''' 輸血チェック
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="mdl"></param>
    '''' <returns></returns>
    'Private Function CheckKarte55(db As AsamaEntities, mdl As M_Drug) As Boolean

    '    '輸血 100 605	002
    '    'Dim karte55 = From e In db.T_OrderDetail_55
    '    '              Where e.TORD_FacilityID = mdl.MDRG_FacilityID And
    '    '                e.TORD_Class1 = "100" And
    '    '                e.TORD_Class2 = "605" And
    '    '                e.TORD_Class3 = "002" And
    '    '        mdl.MDRG_HotCode.Trim = e.TORD_Record.Trim
    '    '              Select e
    '    'Return (karte55.ToList.Count = 0)
    '    Return True

    'End Function
    '''' <summary>
    '''' 放射線チェック
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="mdl"></param>
    '''' <returns></returns>
    'Private Function CheckKarte70(db As AsamaEntities, mdl As M_Drug) As Boolean

    '    '放射線 
    '    Dim karte70 = From e In db.T_OrderDetail_70
    '                  Where e.TORD_FacilityID = mdl.MDRG_FacilityID And
    '                    e.TORD_Class1 = ORDER_DETAIL_CLASS1 And
    '                    e.TORD_Class2 = ORDER_DETAIL_CLASS2 And
    '                    e.TORD_Class3 = ORDER_DETAIL_CLASS3 And
    '                    mdl.MDRG_HotCode.Trim = e.TORD_Record.Trim
    '                  Select e

    '    Return (karte70.ToList.Count = 0)

    'End Function

    '''' <summary>
    '''' 放射線詳細チェック
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="mdl"></param>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Private Function CheckOrderRecordTools70(db As AsamaEntities, mdl As M_Drug) As Boolean

    '    '放射線 
    '    Dim OrderRecordTools70 = From e In db.T_OrderRecordTools_70
    '                             Where e.TORT_FacilityID = mdl.MDRG_FacilityID And
    '                    mdl.MDRG_HotCode.Trim = e.TORT_ToolCode.Trim
    '                             Select e

    '    Return (OrderRecordTools70.ToList.Count = 0)

    'End Function

    '''' <summary>
    '''' 診療基本情報チェック
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="mdl"></param>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Private Function CheckSafetyInfo(db As AsamaEntities, mdl As M_Drug) As Boolean

    '    '放射線 
    '    Dim SafetyInfo = From e In db.T_SafetyInfo
    '                     Where e.TSAF_FacilityID = mdl.MDRG_FacilityID And
    '                    e.TSAF_SafetyType = SAFETYTYPE_21 And
    '                    mdl.MDRG_HotCode.Trim = e.TSAF_SafetyCode.Trim
    '                     Select e

    '    Return (SafetyInfo.ToList.Count = 0)

    'End Function



End Class

Public Class M_DrugCondition

    'Public Property Model As New M_Drug

End Class
