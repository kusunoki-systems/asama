Public Class Options

    Public Property db As AsamaEntities

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(_db As AsamaEntities)
        MyBase.New()
        Me.db = _db
    End Sub
    '''' <summary>
    '''' 麻毒区分
    '''' </summary>
    '''' <returns></returns>
    'Public Function GetOption_NarcoticClass(FacilityID As String) As Dictionary(Of String, String)

    '    Return GetOption_VMName(NAME_CLASS_OD17_NARCOTIC_POISON_DRUG, FacilityID)

    'End Function
    '''' <summary>
    '''' 剤形区分
    '''' </summary>
    '''' <returns></returns>
    'Public Function GetOption_DosageFormClass(FacilityID As String) As Dictionary(Of String, String)

    '    Return GetOption_VMName(NAME_CLASS_OD18_DOSAGE_FORM_CLASS, FacilityID)

    'End Function


    '''' <summary>
    '''' 外用部位コード
    '''' </summary>
    '''' <returns></returns>
    'Public Function GetOption_ExternalPartCode(FacilityID As String) As Dictionary(Of String, String)

    '    Return GetOption_VMName(NAME_CLASS_OD14_EXTERNAL_PART_CODE, FacilityID, True)

    'End Function

    '''' <summary>
    '''' 単位マスタ
    '''' </summary>
    '''' <returns></returns>
    'Public Function GetOption_UnitCode(FacilityID As String) As Dictionary(Of String, String)

    '    Return GetOption_VMName(NAME_CLASS_CM04_UNIT, FacilityID, True)

    'End Function

    '''' <summary>
    '''' VMName取得
    '''' </summary>
    '''' <param name="strClass"></param>
    '''' <returns></returns>
    'Public Function GetOption_VMName(strClass As String, FacilityID As String, Optional extra As Boolean = False) As Dictionary(Of String, String)

    '    Dim list As New Dictionary(Of String, String)
    '    Dim mdls = From n As VM_Name In db.VM_Name
    '               Where n.VNAM_DelFlag = 0 And n.VNAM_NameClass = strClass And n.VNAM_FacilityID = FacilityID And n.VNAM_ValidDateFrom < DateTime.Now
    '               Select n.VNAM_NameCode, n.VNAM_Name

    '    'Dim list As New Dictionary(Of String, String)
    '    'Dim mdls = From m As M_Name In db.M_Name
    '    '           Join gm As GM_Name In db.GM_Name On gm.GNAM_NameClass.Trim Equals m.MNAM_NameClass.Trim And gm.GNAM_NameCode.Trim Equals m.MNAM_NameCode.Trim
    '    '           Where m.MNAM_NameClass = strClass
    '    '           Select gm

    '    If extra Then
    '        list(" ") = " "
    '    End If

    '    For Each n In mdls.ToList()
    '        list(n.VNAM_NameCode.Trim) = n.VNAM_Name.Trim
    '    Next

    '    Return list

    'End Function

    ''' <summary>
    ''' 0:対象外/1:対象のリストを取得
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function GetOption_Flag1() As Dictionary(Of String, String)

        Dim list As New Dictionary(Of String, String)
        list("0") = "対象外"
        list("1") = "対象"
        Return list

    End Function

    ''' <summary>
    ''' 採用区分のリストを取得
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function GetOption_AdoptClass() As Dictionary(Of String, String)
        Dim list As New Dictionary(Of String, String)
        list("0") = "共通"
        list("1") = "院内"
        list("2") = "院外"
        Return list
    End Function
    '0=非神経破壊剤、1=神経破壊剤
    Public Shared Function GetOption_NerveDestroyFlag() As Dictionary(Of String, String)
        Dim list As New Dictionary(Of String, String)
        list("0") = ""
        list("1") = "対象"
        Return list
    End Function
    '0=非生物学的製剤、1=生物学的製剤
    Public Shared Function GetOption_BiologyFlag() As Dictionary(Of String, String)
        Dim list As New Dictionary(Of String, String)
        list("0") = ""
        list("1") = "対象"
        Return list
    End Function
    '0=非後発品、1=後発品
    Public Shared Function GetOption_GenericFlag() As Dictionary(Of String, String)
        Dim list As New Dictionary(Of String, String)
        list("0") = ""
        list("1") = "対象"
        Return list
    End Function
    '0=非歯科特定医薬品、1=歯科特定医薬品
    Public Shared Function GetOption_DentistrySpecialtyFlag() As Dictionary(Of String, String)
        Dim list As New Dictionary(Of String, String)
        list("0") = "非歯科特定医薬品"
        list("1") = "歯科特定医薬品"
        Return list
    End Function
    '0=非造影剤・非造影補助剤、1=造影剤、2=造影補助剤
    Public Shared Function GetOption_ContrastMediumFlag() As Dictionary(Of String, String)
        Dim list As New Dictionary(Of String, String)
        list("1") = "造影剤"
        list("2") = "造影補助剤"
        list("0") = "造影剤以外"
        Return list
    End Function
    '0=調剤指示不可、1=調剤指示可
    Public Shared Function GetOption_GrindFlag() As Dictionary(Of String, String)
        Dim list As New Dictionary(Of String, String)
        list("0") = "非調剤指示可"
        list("1") = "調剤指示可"
        Return list
    End Function
    '0=調剤指示不可、1=調剤指示可
    Public Shared Function GetOption_MixFlag() As Dictionary(Of String, String)
        Return GetOption_GrindFlag()
    End Function
    '0=調剤指示不可、1=調剤指示可
    Public Shared Function GetOption_DissolveFlag() As Dictionary(Of String, String)
        Return GetOption_GrindFlag()
    End Function
    '0=調剤指示不可、1=調剤指示可
    Public Shared Function GetOption_PTPFlag() As Dictionary(Of String, String)
        Return GetOption_GrindFlag()
    End Function
    '0=調剤指示不可、1=調剤指示可
    Public Shared Function GetOption_OneDosePackagFlag() As Dictionary(Of String, String)
        Return GetOption_GrindFlag()
    End Function
    '0=非院内製剤、1=院内製剤
    Public Shared Function GetOption_HospitalPreparationFlag() As Dictionary(Of String, String)
        Dim list As New Dictionary(Of String, String)
        list("0") = "非調剤指示可"
        list("1") = "調剤指示可"
        Return list
    End Function
    '0=非治験薬、1=治験薬
    Public Shared Function GetOption_INDFlag() As Dictionary(Of String, String)
        Dim list As New Dictionary(Of String, String)
        list("0") = "非"
        list("1") = "治験薬"
        Return list
    End Function
    '0=非臨時薬、1=臨時薬
    Public Shared Function GetOption_ExtraDrugFlag() As Dictionary(Of String, String)
        Dim list As New Dictionary(Of String, String)
        list("0") = "非臨時薬"
        list("1") = "臨時薬"
        Return list
    End Function
    '0=非糖尿病薬、1=糖尿病薬
    Public Shared Function GetOption_DiabetesFlag() As Dictionary(Of String, String)
        Dim list As New Dictionary(Of String, String)
        list("0") = "非糖尿病薬"
        list("1") = "糖尿病薬"
        Return list
    End Function
    '0=非抗癌薬、1=抗癌薬
    Public Shared Function GetOption_AnticancerDrugFlag() As Dictionary(Of String, String)
        Dim list As New Dictionary(Of String, String)
        list("0") = "非抗癌薬"
        list("1") = "抗癌薬"
        Return list
    End Function

    '患者限定採用フラグ 1=患者限定採用
    Public Shared Function GetOption_PatientLimitedFlag() As Dictionary(Of String, String)
        Dim list As New Dictionary(Of String, String)
        list("0") = ""
        list("1") = "対象"
        Return list
    End Function

    ''' <summary>
    ''' 無期限
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function GetOption_ValidCheckbox() As Dictionary(Of String, String)

        Dim list As New Dictionary(Of String, String)
        list("0") = ""
        list("1") = "無期限"
        Return list

    End Function

    ''' <summary>
    ''' チェックボックス用フラグ
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetOption_CheckFlag() As Dictionary(Of String, String)
        Dim list As New Dictionary(Of String, String)
        list("0") = ""
        list("1") = "対象"
        Return list
    End Function

    ''' <summary>
    ''' 医療材料糖尿病薬
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetOption_DiabetesFlag_Material() As Dictionary(Of String, String)

        Dim list As New Dictionary(Of String, String)
        list("0") = "外用"
        list("1") = "インスリン"
        Return list

    End Function


End Class
