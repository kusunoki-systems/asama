'Imports System
'Imports System.Web
'Imports System.Web.Mvc

'Namespace Helpers
'    ''' <summary>
'    ''' 編集用ヘルパー
'    ''' </summary>
'    Public Class HtmlHelperEditor
'        ''' <summary>
'        ''' 文字列をテキストで表示
'        ''' </summary>
'        ''' <param name="obj"></param>
'        ''' <param name="name"></param>
'        ''' <param name="format"></param>
'        ''' <returns></returns>
'        Public Shared Function ReadOnlyEditor(obj As Object, name As String, format As String) As IHtmlString

'            '日付型の場合
'            Dim datepicker As String = If(TypeOf obj Is DateTime, "datepicker", "")
'            obj = If(TypeOf obj Is Decimal, obj.ToString, obj)

'            Return MvcHtmlString.Create(
'            String.Format("<input type=""text"" value=""{0}"" class=""" & datepicker & " form-control text-box single-line"" id=""{1}"" name=""{1}"" disabled=""true""/>",
'                                  HttpUtility.HtmlAttributeEncode(String.Format("{0:" & format & "}", obj)),
'                                  HttpUtility.HtmlAttributeEncode(name)) &
'            String.Format("<input type=""hidden"" value=""{0}"" name=""{1}""/>",
'                                  HttpUtility.HtmlAttributeEncode(String.Format("{0:" & format & "}", obj)),
'                                  HttpUtility.HtmlAttributeEncode(name)))

'        End Function
'        ' ''' <summary>
'        ' ''' 編集可能になる
'        ' ''' </summary>
'        ' ''' <param name="obj"></param>
'        ' ''' <param name="name"></param>
'        ' ''' <param name="format"></param>
'        ' ''' <returns></returns>
'        'Public Shared Function ReadOnlyEditable(obj As Object, name As String, format As String) As IHtmlString

'        '    '日付型の場合
'        '    Dim datepicker As String = If(TypeOf obj Is DateTime, "datepicker", "")
'        '    obj = If(TypeOf obj Is Decimal, obj.ToString, obj)
'        '    Dim nameFlg As String() = name.Split("_")
'        '    Dim disabled As String = String.Empty
'        '    If nameFlg.Count > 0 AndAlso nameFlg(1) <> "ValidDateFrom" Then
'        '        disabled = "disabled=""disabled"""
'        '    End If

'        '    Return MvcHtmlString.Create(
'        '    String.Format("<input type=""text"" value=""{0}"" class=""" & datepicker & " form-control text-box single-line"" id=""{1}"" name=""{1}"" " & disabled & " />",
'        '                          HttpUtility.HtmlAttributeEncode(String.Format("{0:" & format & "}", obj)),
'        '                          HttpUtility.HtmlAttributeEncode(name)))

'        '    'Return MvcHtmlString.Create(
'        '    'String.Format("<input type=""text"" value=""{0}"" class=""" & datepicker & " form-control text-box single-line"" id=""{1}"" name=""{1}"" readonly=""readonly"" />",
'        '    '                      HttpUtility.HtmlAttributeEncode(String.Format("{0: " & format & "}", obj)),
'        '    '                      HttpUtility.HtmlAttributeEncode(name)) &
'        '    'String.Format("<input type=""hidden"" value=""{0}"" name=""{1}""/>",
'        '    '                      HttpUtility.HtmlAttributeEncode(String.Format("{0:" & format & "}", obj)),
'        '    '                      HttpUtility.HtmlAttributeEncode(name)))

'        'End Function
'        ''' <summary>
'        ''' 選択肢から表示
'        ''' </summary>
'        ''' <param name="obj"></param>
'        ''' <param name="name"></param>
'        ''' <param name="list"></param>
'        ''' <returns></returns>
'        Public Shared Function ReadOnlyEditor(obj As Object, name As String, list As Dictionary(Of String, String)) As IHtmlString

'            Dim l = (From e As KeyValuePair(Of String, String) In list
'                     Where e.Key = obj.ToString
'                     Select e).FirstOrDefault

'            Return MvcHtmlString.Create(
'            String.Format("<input type=""text"" value=""{0}"" class=""form-control text-box single-line"" id=""{1}"" name=""{1}"" readonly=""true"" disabled=""true""/>",
'                                  HttpUtility.HtmlAttributeEncode(String.Format("{0}", l.Value.ToString)),
'                                  HttpUtility.HtmlAttributeEncode(name)) &
'            String.Format("<input type=""hidden"" value=""{0}"" name=""{1}""/>",
'                                  HttpUtility.HtmlAttributeEncode(String.Format("{0}", l.Key.ToString)),
'                                  HttpUtility.HtmlAttributeEncode(name)))

'        End Function

'        ''' <summary>
'        ''' 選択肢から表示 List（単位等）
'        ''' </summary>
'        ''' <param name="obj"></param>
'        ''' <param name="name"></param>
'        ''' <param name="list"></param>
'        ''' <returns></returns>
'        Public Shared Function ReadOnlyEditor(obj As Object, name As String, list As List(Of VM_Name), FacilityID As String) As IHtmlString

'            Dim l = (From e As VM_Name In list
'                     Where e.VNAM_FacilityID = FacilityID And
'                         e.VNAM_NameClass = "CM04" And
'                         e.VNAM_NameCode = obj.ToString
'                     Select e).FirstOrDefault

'            Return MvcHtmlString.Create(
'            String.Format("<input type=""text"" value=""{0}"" class=""form-control text-box single-line"" id=""{1}"" name=""{1}"" readonly=""true""/>",
'                                  HttpUtility.HtmlAttributeEncode(String.Format("{0}", If(l Is Nothing, "", l.VNAM_Name))),
'                                  HttpUtility.HtmlAttributeEncode(name)) &
'            String.Format("<input type=""hidden"" value=""{0}"" name=""{1}""/>",
'                                  HttpUtility.HtmlAttributeEncode(String.Format("{0}", If(l Is Nothing, "", l.VNAM_Name))),
'                                  HttpUtility.HtmlAttributeEncode(name)))

'        End Function

'        ''' <summary>
'        ''' ラジオボタンエディター
'        ''' </summary>
'        ''' <param name="obj"></param>
'        ''' <param name="name"></param>
'        ''' <param name="valueList">valueList("key")=value</param>
'        ''' <returns></returns>
'        Public Shared Function FlagRadioButtonEditor(obj As Object, name As String, valueList As Dictionary(Of String, String)) As IHtmlString
'            If valueList Is Nothing Then
'                Return MvcHtmlString.Create("値リストが設定されていません。")
'            End If
'            If obj Is Nothing Then
'                Return MvcHtmlString.Create("オブジェクトが設定されていません。")
'            End If
'            Dim sb As New StringBuilder

'            '  SortedDictionary<string, int> sdata = new SortedDictionary<string, int>(data);
'            For Each Data As KeyValuePair(Of String, String) In valueList
'                sb.AppendFormat("<label class=""radio-inline"" for = ""{0}{1}"" >{2}", name, Data.Key, Data.Value)
'                sb.AppendFormat("<input type=""radio"" class="""" value=""{0}"" name=""{1}"" id=""{1}{0}"" {3} />",
'                                  HttpUtility.HtmlAttributeEncode(Data.Key),
'                                  HttpUtility.HtmlAttributeEncode(name),
'                                  HttpUtility.HtmlAttributeEncode(Data.Value),
'                                  HttpUtility.HtmlAttributeEncode(If(obj.ToString = Data.Key, "checked", "")))
'                sb.AppendFormat("</label>", name, Data.Key, Data.Value)
'            Next
'            Return MvcHtmlString.Create(sb.ToString)

'        End Function
'        ''' <summary>
'        ''' チェックボックスエディター
'        ''' </summary>
'        ''' <param name="obj"></param>
'        ''' <param name="name"></param>
'        ''' <param name="valueList"></param>
'        ''' <returns></returns>
'        Public Shared Function FlagCheckBoxEditor(ByVal obj As Object, ByVal name As String, ByVal valueList As Dictionary(Of String, String), Optional ByVal disabled As Boolean = False, Optional ByVal ItemKey As String = "1") As IHtmlString
'            If valueList Is Nothing Then
'                Return MvcHtmlString.Create("値リストが設定されていません。")
'            End If
'            Dim sb As New StringBuilder

'            'チェックボックスの出力を行う
'            For Each Data As KeyValuePair(Of String, String) In valueList
'                '値がキーと一致する場合名称を付ける
'                If Data.Key = ItemKey Then
'                    sb.AppendFormat("<label class=""checkbox-inline"" for = ""{0}"" >{1}", name, Data.Value)
'                    sb.AppendFormat("<input type=""checkbox"" value=""{0}"" name=""{1}"" id=""{1}"" {2} {3} />",
'                                  HttpUtility.HtmlAttributeEncode(Data.Key.ToString),
'                                  HttpUtility.HtmlAttributeEncode(name),
'                                  HttpUtility.HtmlAttributeEncode(If(obj.ToString = Data.Key, "checked", "")),
'                                  HttpUtility.HtmlAttributeEncode(If(disabled, "disabled = ""disabled""", "")))
'                    sb.AppendFormat("</label>", name, Data.Key, Data.Value)
'                    If disabled Then
'                        sb.AppendFormat("<input type=""hidden"" value=""{0}"" name=""{1}"" id=""{1}"" />",
'                                      HttpUtility.HtmlAttributeEncode(Data.Key.ToString),
'                                      HttpUtility.HtmlAttributeEncode(name))
'                    End If
'                End If
'            Next


'            Return MvcHtmlString.Create(sb.ToString)

'        End Function
'        ''' <summary>
'        ''' チェックボックスエディター
'        ''' </summary>
'        ''' <param name="check"></param>
'        ''' <param name="name"></param>
'        ''' <param name="valueList"></param>
'        ''' <param name="ItemKey"></param>
'        ''' <param name="disabled"></param>
'        ''' <returns></returns>
'        Public Shared Function CheckBoxEditor(ByVal check As Boolean, ByVal name As String, ByVal valueList As Dictionary(Of String, String), ByVal ItemKey As Integer, Optional ByVal disabled As Boolean = False) As IHtmlString
'            If valueList Is Nothing Then
'                Return MvcHtmlString.Create("値リストが設定されていません。")
'            End If
'            Dim sb As New StringBuilder
'            'チェックステータスの検証
'            Dim strChecked As String = String.Empty
'            Select Case check
'                Case True   '初期値としてチェック有り
'                    strChecked = "checked"
'                Case False  '初期値としてチェックなし
'                    strChecked = ""
'            End Select

'            'チェックボックスの出力を行う
'            For Each Data As KeyValuePair(Of String, String) In valueList
'                '値がキーと一致する場合名称を付ける
'                If Data.Key = ItemKey Then
'                    'Optionalの判定
'                    'ラベルの作成
'                    sb.AppendFormat("<label class=""checkbox-inline"" for = ""{0}"" >{1}", name, Data.Value)
'                    'チェックボックスの作成
'                    sb.AppendFormat("<input type=""checkbox"" value=""{0}"" name=""{1}"" id=""{1}"" {2} {3} />",
'                                  HttpUtility.HtmlAttributeEncode(Data.Key.ToString),
'                                  HttpUtility.HtmlAttributeEncode(name),
'                                  HttpUtility.HtmlAttributeEncode(strChecked),
'                                    If(disabled, "disabled = ""disabled""", "")
'                                    )
'                    sb.AppendFormat("</label>")
'                End If
'            Next

'            Return MvcHtmlString.Create(sb.ToString)

'        End Function
'        ''' <summary>
'        ''' 
'        ''' </summary>
'        ''' <param name="count"></param>
'        ''' <param name="name"></param>
'        ''' <param name="value1"></param>
'        ''' <param name="value2"></param>
'        ''' <param name="flg"></param>
'        ''' <returns></returns>
'        Public Shared Function CheckBoxEditorSingle(ByVal count As Integer, ByVal name As String, ByVal value1 As String, ByVal value2 As String, ByVal flg As Boolean) As IHtmlString
'            Dim sb As New StringBuilder

'            Dim strValue As String = If(flg, "", HttpUtility.HtmlAttributeEncode(value1 & "_" & value2))
'            Dim strName As String = HttpUtility.HtmlAttributeEncode(name & "_" & count)
'            Dim strClass As String = If(flg, "row_disable", "row_check")
'            Dim strDisabled As String = If(flg, "disabled = ""disabled"" checked", "")

'            'チェックボックスの出力を行う
'            sb.AppendFormat("<label class=""checkbox-inline"" for = ""{0}"" style=""padding: 15px 30px;"" >", strName)
'            sb.AppendFormat("<input type=""checkbox"" value=""{0}"" name=""{1}"" id=""{2}"" class = ""{3}"" style=""margin-left: -10px;"" {4} />",
'                          strValue, name, strName, strClass, strDisabled)
'            sb.AppendFormat("</label>")

'            Return MvcHtmlString.Create(sb.ToString)

'        End Function


'        ''' <summary>
'        ''' ドロップダウンエディター
'        ''' </summary>
'        ''' <param name="obj"></param>
'        ''' <param name="name"></param>
'        ''' <param name="valueList"></param>
'        ''' <returns></returns>
'        Public Shared Function DropDownEditor(obj As Object, name As String, valueList As Dictionary(Of String, String)) As IHtmlString
'            If valueList Is Nothing Then
'                Return MvcHtmlString.Create("値リストが設定されていません。")
'            End If
'            obj = Trim(obj)
'            Dim sb As New StringBuilder
'            'sb.AppendFormat("<label class=""control-label"" for = ""{0}"" >", name)
'            'sb.AppendFormat("</label>")
'            sb.AppendFormat("<Select class=""form-control"" name=""{0}"" id=""{0}"">", HttpUtility.HtmlAttributeEncode(name))

'            For Each Data As KeyValuePair(Of String, String) In valueList
'                sb.AppendFormat("<option value=""{0}"" {1}>", HttpUtility.HtmlAttributeEncode(Data.Key.ToString), HttpUtility.HtmlAttributeEncode(If(obj IsNot Nothing AndAlso obj.ToString = Data.Key, "selected", "")))
'                sb.AppendFormat("{0}</Option>", Data.Value.ToString)
'            Next
'            sb.AppendFormat("</Select>")
'            Return MvcHtmlString.Create(sb.ToString)

'        End Function

'        ''' <summary>
'        ''' 単位マスタ
'        ''' </summary>
'        ''' <param name="obj"></param>
'        ''' <param name="name"></param>
'        ''' <param name="mdlsUnit"></param>
'        ''' <param name="mdlsNames"></param>
'        ''' <returns></returns>
'        Public Shared Function DropDownEditor(obj As Object, name As String, mdlsUnit As IEnumerable(Of Object), mdlsNames As IEnumerable(Of Object)) As IHtmlString
'            If mdlsUnit Is Nothing Then
'                Return MvcHtmlString.Create("値リストが設定されていません。")
'            End If
'            Dim sb As New StringBuilder
'            sb.AppendFormat("<Select class=""form-control"" name=""{0}"" id=""{0}"">", HttpUtility.HtmlAttributeEncode(name))
'            '項目の生成
'            If TypeOf mdlsUnit Is List(Of M_DrugUnit) Then
'                For Each Data As M_DrugUnit In mdlsUnit
'                    Dim strSelected As String = If(obj = Data.MDUT_UnitNo, "selected", String.Empty)
'                    sb.AppendFormat("<option value=""{0}"" {1}>",
'                                    HttpUtility.HtmlAttributeEncode(Data.MDUT_UnitNo.ToString),
'                                    HttpUtility.HtmlAttributeEncode(strSelected))
'                    sb.AppendFormat("{0}</Option>", (From q As VM_Name In mdlsNames Where q.VNAM_NameCode = Data.MDUT_UnitCode Select q.VNAM_Name).FirstOrDefault)
'                Next
'            ElseIf TypeOf mdlsUnit Is List(Of GM_DrugUnit) Then
'                For Each Data As GM_DrugUnit In mdlsUnit
'                    Dim strSelected As String = If(obj = Data.GDUT_UnitNo, "selected", String.Empty)
'                    sb.AppendFormat("<option value=""{0}"" {1}>",
'                                    HttpUtility.HtmlAttributeEncode(Data.GDUT_UnitNo.ToString),
'                                    HttpUtility.HtmlAttributeEncode(strSelected))
'                    sb.AppendFormat("{0}</Option>", (From q In mdlsNames Where q.GNAM_NameCode = Data.GDUT_UnitCode Select q.GNAM_Name).FirstOrDefault)
'                Next
'            End If

'            sb.AppendFormat("</Select>")
'            Return MvcHtmlString.Create(sb.ToString)

'        End Function


'        ''' <summary>
'        ''' 単位マスタ
'        ''' </summary>
'        ''' <param name="obj"></param>
'        ''' <param name="name"></param>
'        ''' <param name="mdls"></param>
'        ''' <param name="read_only"></param>
'        ''' <returns></returns>
'        Public Shared Function DropDownEditorUnit(obj As Object, name As String, mdls As List(Of VM_Name), Optional read_only As Boolean = False) As IHtmlString
'            If mdls Is Nothing Then
'                Return MvcHtmlString.Create("値リストが設定されていません。")
'            End If
'            Dim sb As New StringBuilder
'            sb.AppendFormat("<Select class=""form-control"" name=""{0}"" id=""{0}"" {1}>", HttpUtility.HtmlAttributeEncode(name), If(read_only, "readonly = 'true' ", ""))
'            For Each Data As VM_Name In mdls
'                Dim strSelected As String = If(obj = Data.VNAM_NameCode, "selected", String.Empty)
'                sb.AppendFormat("<option value=""{0}"" {1}>", HttpUtility.HtmlAttributeEncode(Data.VNAM_NameCode.ToString), HttpUtility.HtmlAttributeEncode(strSelected))
'                sb.AppendFormat("{0}</Option>", Data.VNAM_Name)
'            Next
'            sb.AppendFormat("</Select>")
'            Return MvcHtmlString.Create(sb.ToString)

'        End Function



'    End Class
'End Namespace
