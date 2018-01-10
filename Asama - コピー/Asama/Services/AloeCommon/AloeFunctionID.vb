''' <summary>
''' 機能ID
''' </summary>
Public Class AsamaFunctionID

    ''' <summary>
    ''' 施設用薬品マスタメンテナンス
    ''' </summary>
    Public Const MasterMainte_M_Drug As String = "M51"
    ''' <summary>
    ''' グループ用薬品マスタメンテナンス
    ''' </summary>
    Public Const MasterMainte_GM_Drug As String = "G51"
    ''' <summary>
    ''' 施設用血液製剤マスタメンテナンス
    ''' </summary>
    Public Const MasterMainte_M_Drug_Blood As String = "M52"
    ''' <summary>
    ''' グループ用血液製剤マスタメンテナンス
    ''' </summary>
    Public Const MasterMainte_GM_Drug_Blood As String = "G52"
    ''' <summary>
    ''' 施設用処方医療材料マスタメンテナンス
    ''' </summary>
    Public Const MasterMainte_M_Drug_Material As String = "M53"
    ''' <summary>
    ''' グループ用処方医療材料マスタメンテナンス
    ''' </summary>
    Public Const MasterMainte_GM_Drug_Material As String = "G53"


    '''' <summary>機能ID：共通</summary>
    'Public Const Common As String = "COM"

    '''' <summary>機能ID：ログイン</summary>
    'Public Const Login As String = "LOG"

    ''' <summary>機能ID：アクセス権限</summary>
    Public Const AccessAuthority As String = "ACC"

    ''ADD START 2016/05/31 FSI丸岡 #7035
    '''' <summary>機能ID：カルテベース</summary>
    'Public Const KarteBase As String = "KBA"
    ''ADD END 2016/05/31 FSI丸岡 #7035

    '''' <summary>機能ID：メニュー</summary>
    'Public Const Menu As String = "MNU"

    '''' <summary>機能ID：患者属性</summary>
    'Public Const PatientInformation As String = "PAI"

    '''' <summary>機能ID：病床マップ</summary>
    'Public Const BedMap As String = "BMP"

    '''' <summary>機能ID：定時オーダ切れ確認</summary>
    'Public Const RegularOrderConfirm As String = "ROC"

    '''' <summary>機能ID：病棟ワークシート</summary>
    'Public Const WardWorksheet As String = "WWS"

    '''' <summary>機能ID：看護計画</summary>
    'Public Const NursingCarePlan As String = "NCP"

    '''' <summary>機能ID：温度板（フローシート）</summary>
    'Public Const FlowSheet As String = "FLS"

    '''' <summary>機能ID：患者ノート</summary>
    'Public Const PatientNotes As String = "PAN"

    '''' <summary>機能ID：予定一覧</summary>
    'Public Const WardSchedule As String = "SCH"

    '''' <summary>機能ID：注射実施登録</summary>
    'Public Const InjectionImplementRecord As String = "IIR"

    '''' <summary>機能ID：処置実施登録</summary>
    'Public Const AidImplementRecord As String = "AIR"

    '''' <summary>機能ID：バイタル入力</summary>
    'Public Const VitalInput As String = "VII"

    '''' <summary>機能ID：看護必要度</summary>
    'Public Const NursingNeeds As String = "NND"

    '''' <summary>機能ID：患者選択</summary>
    'Public Const PatientSelect As String = "PAS"

    '''' <summary>機能ID：患者基本情報</summary>
    'Public Const PatientBasicInfo As String = "PBI"

    '''' <summary>機能ID：診療基本情報</summary>
    'Public Const PatientMedicalInfo As String = "PMI"

    '''' <summary>機能ID：傷病名管理（一覧）</summary>
    'Public Const DiseaseView As String = "DIV"

    '''' <summary>機能ID：傷病名管理（登録）</summary>
    'Public Const DiseaseEdit As String = "DIE"

    '''' <summary>機能ID：診療基礎情報</summary>
    'Public Const MedicalCareBasicInfo As String = "MBI"

    '''' <summary>機能ID：問題点管理（登録）</summary>
    'Public Const ProblemManagementEdit As String = "PBM"

    '''' <summary>機能ID：問題点管理（一覧）</summary>
    'Public Const ProblemManagementView As String = "PMV"

    '''' <summary>機能ID：経過記録・サマリ参照</summary>
    'Public Const ProgressNoteView As String = "PNV"

    '''' <summary>機能ID：経過記録登録</summary>
    'Public Const ProgressNoteEdit As String = "PNE"

    '''' <summary>機能ID：サマリ登録</summary>
    'Public Const SummaryEdit As String = "SME"

    '''' <summary>機能ID：所見入力</summary>
    'Public Const ObservationInput As String = "OBI"

    '''' <summary>機能ID：オーダ履歴</summary>
    'Public Const OrderHistory As String = "ORH"

    '''' <summary>機能ID：薬歴・検査歴・喫食率カレンダ</summary>
    'Public Const DrugExamMealHistory As String = "DEM"

    '''' <summary>機能ID：検査結果一覧</summary>
    'Public Const ExamResult As String = "EXR"

    '''' <summary>機能ID：患者状態表示</summary>
    'Public Const PatientStatusView As String = "PSV"

    '''' <summary>機能ID：複合セット</summary>
    'Public Const UnifiedOrderSet As String = "UOS"

    '''' <summary>機能ID：処方オーダ</summary>
    'Public Const PrescriptionOrder As String = "PRO"

    '''' <summary>機能ID：注射オーダ</summary>
    'Public Const InjectionOrder As String = "IJO"

    '''' <summary>機能ID：処置オーダ</summary>
    'Public Const AidOrder As String = "AIO"

    '''' <summary>機能ID：検体検査オーダ</summary>
    'Public Const LaboratoryExamOrder As String = "LEO"

    '''' <summary>機能ID：生理検査オーダ</summary>
    'Public Const PhysiologicalExamOrder As String = "PEO"

    '''' <summary>機能ID：画像オーダ</summary>
    'Public Const ImagingExamOrder As String = "IMO"

    '''' <summary>機能ID：リハビリオーダ</summary>
    'Public Const RehabOrder As String = "RHO"

    '''' <summary>機能ID：栄養オーダ登録</summary>
    'Public Const NutritionOrderEdit As String = "NTE"

    '''' <summary>機能ID：栄養オーダ一覧</summary>
    'Public Const NutritionOrderView As String = "NTV"

    '''' <summary>機能ID：看護オーダ</summary>
    'Public Const NursingOrder As String = "NUO"

    '''' <summary>機能ID：管理指導</summary>
    'Public Const TeachingOrder As String = "TCO"

    '''' <summary>機能ID：透析オーダ</summary>
    'Public Const DialysisOrder As String = "DLO"

    '''' <summary>機能ID：手術オーダ</summary>
    'Public Const OpeOrder As String = "OPO"

    '''' <summary>機能ID：輸血オーダ</summary>
    'Public Const TransfusionOrder As String = "TRO"

    '''' <summary>機能ID：麻酔オーダ</summary>
    'Public Const AnesthesiaOrder As String = "ANO"

    '''' <summary>機能ID：内視鏡検査オーダ</summary>
    'Public Const EndoscopeExamOrder As String = "EEO"

    '''' <summary>機能ID：精神オーダ</summary>
    'Public Const MentalOrder As String = "MTO"

    '''' <summary>機能ID：代行承認</summary>
    'Public Const ArticleAccept As String = "ARA"

    '''' <summary>機能ID：治療パス</summary>
    'Public Const HealingApploachEdit As String = "HEA"

    '''' <summary>機能ID：申し送り</summary>
    'Public Const HandOver As String = "HOV"

    '''' <summary>機能ID：総合評価版（アセスメント）登録</summary>
    'Public Const AssessmentEdit As String = "ASM"

    '''' <summary>機能ID：カンファレンス</summary>
    'Public Const Conference As String = "CON"

    '''' <summary>機能ID：ワークフロー（褥瘡など）</summary>
    'Public Const Workflow As String = "WFL"

    '''' <summary>機能ID：入院時診療計画</summary>
    'Public Const AdmissionCarePlan As String = "ACP"

    '''' <summary>機能ID：退院時療養計画</summary>
    'Public Const DischargeCarePlan As String = "DCP"

    '''' <summary>機能ID：入院時看護基礎データ</summary>
    'Public Const AdmissionNursingBase As String = "ANB"   

    '''' <summary>機能ID：褥瘡診療計画</summary>
    'Public Const BedsoreCarePlan As String = "BCP"

    '''' <summary>機能ID：サマリ（文書）</summary>
    'Public Const SummaryDocuments As String = "SMD"

    '''' <summary>機能ID：文書</summary>
    'Public Const MedicalDocuments As String = "DOC"

    '''' <summary>機能ID：患者台帳</summary>
    'Public Const PatientLedger As String = "PAL"

    '''' <summary>機能ID：統計</summary>
    'Public Const Statistics As String = "STA"

    '''' <summary>機能ID：医療区分</summary>
    'Public Const MedicalCarePartition As String = "MEP"

    '''' <summary>機能ID：栄養管理</summary>
    'Public Const NutritionalManagement As String = "NUM"

    '''' <summary>機能ID：診療予約</summary>
    'Public Const OPDReservation As String = "ORV"

    '''' <summary>機能ID：外来受付（総合受付）</summary>
    'Public Const GeneralReception As String = "GNR"

    '''' <summary>機能ID：外来受付（科受付）</summary>
    'Public Const DepartmentReception As String = "DPR"

    '''' <summary>機能ID：患者検索</summary>
    'Public Const PatientSearch As String = "PSC"

    '''' <summary>機能ID：薬剤部門システム</summary>
    'Public Const PharmacyDivisionSystem As String = "PDS"

    '''' <summary>機能ID：服薬指導システム</summary>
    'Public Const MedicationTeachingSystem As String = "MTS"

    '''' <summary>機能ID：検体検査システム</summary>
    'Public Const LaboratoryExamSystem As String = "LES"

    '''' <summary>機能ID：生理検査システム</summary>
    'Public Const PhysiologicalExamSystem As String = "PES"

    '''' <summary>機能ID：画像部門システム</summary>
    'Public Const ImagingDivisionSystem As String = "IDS"

    '''' <summary>機能ID：リハビリ部門システム</summary>
    'Public Const RehabDivisionSystem As String = "REH"

    '''' <summary>機能ID：精神部門システム</summary>
    'Public Const MentalDivisionSystem As String = "MEN"

    '''' <summary>機能ID：栄養部門システム</summary>
    'Public Const NutritionDivisionSystem As String = "NDS"

    '''' <summary>機能ID：栄養指導システム</summary>
    'Public Const NutritionGuidanceSystem As String = "NGS"

    '''' <summary>機能ID：マスタメンテナンス</summary>
    'Public Const MasterMaintenance As String = "MAM"

    '''' <summary>機能ID：代行入力</summary>
    'Public Const DeputyChangeAuthority As String = "DCA"

    '''' <summary>機能ID：掲示板登録</summary>
    'Public Const BulletinBoardRecord As String = "BBR"

    '''' <summary>機能ID：リストバンド印刷</summary>
    'Public Const PrintWristBand As String = "PWB"

    '''' <summary>機能ID：予約票</summary>
    'Public Const ReserveSheet As String = "RES"

    '''' <summary>機能ID：検体オーダ簡易受付</summary>
    'Public Const LaboratoryOrderSimpleReception As String = "LOR"

    '''' <summary>機能ID：食事箋印刷</summary>
    'Public Const PrintNutritionRecipe As String = "PNR"

    '''' <summary>機能ID：食事実施登録</summary>
    'Public Const NutritionImplementRecord As String = "NIR"

    '''' <summary>機能ID：機能設定</summary>
    'Public Const FunctionSettings As String = "FST"    

    '''' <summary>機能ID：評価印刷</summary>
    'Public Const PrintAssessment As String = "PRA"  

    '''' <summary>機能ID：食事ラベル印刷</summary>
    'Public Const PrintNutritionLabel As String = "PNL"

    '''' <summary>機能ID：退院療養計画書印刷</summary>
    '''' <remarks>※重複のため"PCP"から変更</remarks>
    'Public Const PrintDischargeCarePlan As String = "PDC"   

    '''' <summary>機能ID：注射ラベル印刷</summary>
    'Public Const PrintInjectionLabel As String = "PIL"

    '''' <summary>機能ID：院外処方箋</summary>
    'Public Const PrintOutOfHospitalRecipe As String = "POR"

    '''' <summary>機能ID：調剤連携</summary>
    'Public Const PharmLink As String = "PHL"

    '''' <summary>機能ID：定期処方取り込み</summary>
    'Public Const RegularPrescription As String = "RPR"

    '''' <summary>機能ID：薬情印刷データ取り込み</summary>
    'Public Const DrugInformationImport As String = "DII"

    '''' <summary>機能ID：褥瘡診療計画印刷</summary>
    'Public Const PrintBedsoreCarePlan As String = "PBC"

    '''' <summary>機能ID：フッター</summary>
    'Public Const Footer As String = "FOT"

    '''' <summary>機能ID：アクティブコントロール</summary>
    'Public Const ActiveControl As String = "ActiveControl"

    '''' <summary>アクティブコントロール</summary>
    'Public Const LeftControl As String = "LeftControl"

    '''' <summary>アクティブコントロール</summary>
    'Public Const RightControl As String = "RightControl"

    '''' <summary>アクティブコントロール</summary>
    'Public Const FullControl As String = "FullControl"

    '''' <summary>機能ID：院内処方箋</summary>
    'Public Const PrintInsideHospitalRecipe As String = "PHR"

    '''' <summary>機能ID：入院診療計画印刷</summary>
    'Public Const PrintAdmissionCarePlan As String = "PAC"

    '''' <summary>機能ID：検査結果一覧印刷(時系列)</summary>
    'Public Const PrintExamResultProgress As String = "PEP"

    '''' <summary>機能ID：検査結果一覧印刷(日毎)</summary>
    'Public Const PrintExamResultOneDay As String = "PED"

    '''' <summary>機能ID：入院注射箋</summary>
    'Public Const PrintInsideHospitalInjectionRecipe As String = "PHI"

    '''' <summary>機能ID：指示書印刷</summary>
    'Public Const PrintOrderSheet As String = "POS"

    '''' <summary>機能ID：パス</summary>
    'Public Const FilePath As String = "PATH"

    '''' <summary>機能ID：栄養管理システム</summary>
    'Public Const NutritionalManagementSystem As String = "NUM"  

    '''' <summary>機能ID：処方ラベル印刷</summary>
    'Public Const PrintPrescriptionLabel As String = "PPL"  

    '''' <summary>機能ID：病状評価計画</summary>
    'Public Const DiseaseAssesmentPlan As String = "DAP"  

    ''ADD START 2016/02/26 FSI 宮原
    '''' <summary>機能ID：栄養スクリーニング・アセスメント印刷</summary>
    'Public Const PrintScreeningAssessmennt As String = "PSA"

    '''' <summary>機能ID：低栄養マネジメント</summary>
    'Public Const PrintLowNutrientManagement As String = "PLN"

    '''' <summary>機能ID：栄養管理計画</summary>
    'Public Const PrintManagementPlan As String = "PMP"

    '''' <summary>機能ID：栄養治療実施計画</summary>
    'Public Const PrintCureImplementPlan As String = "PCI"

    '''' <summary>機能ID：IVH管理・離脱計画</summary>
    'Public Const PrintIVHPlan As String = "PIP"

    '''' <summary>機能ID：担当割当</summary>
    'Public Const ChargeAssignment As String = "CHA"

    '''' <summary>機能ID：文書管理（ファイル管理）</summary>
    'Public Const FileManagement As String = "FIM"

    '''' <summary>機能ID：看護計画印刷</summary>
    'Public Const PrintCarePlan As String = "PCP"

    '''' <summary>機能ID：病棟ワークシート印刷</summary>
    'Public Const PrintWardWorksheet As String = "PWS"

    '''' <summary>機能ID：処方実施登録</summary>
    'Public Const PrescriptionImplementRecord As String = "PRI"

    '''' <summary>機能ID：統計情報（患者台帳）</summary>
    'Public Const StatisticsSystem As String = "STS" 

    '''' <summary>機能ID：申し送り参照</summary>
    'Public Const HandOverView As String = "HVV" 

    '''' <summary>機能ID：申し送り印刷</summary>
    'Public Const PrintHandOver As String = "PHO"

    '''' <summary>機能ID：薬剤部門システム</summary>
    'Public Const PrintPharmacyDivision As String = "PPD"  

    '''' <summary>機能ID：オーダ一覧</summary>
    'Public Const OrderList As String = "ORL"    

    '''' <summary>外来基本伝票</summary>
    'Public Const OutPatientBasicSlipSheet As String = "POB"      

    '''' <summary>機能ID：オーダ一覧</summary>
    'Public Const PrintKarte As String = "PKT"   

    '''' <summary>機能ID：患者掲示板登録</summary>
    'Public Const PatientBulletinBoardRecord As String = "PBR" 

End Class
