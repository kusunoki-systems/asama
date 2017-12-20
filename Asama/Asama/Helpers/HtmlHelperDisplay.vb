Imports System
Imports System.Web
Imports System.Web.Mvc

Namespace Helpers
    Public Class HtmlHelperDisplay
        Public Shared Function DateDisplay(obj As Object, UnDefDisp As Boolean) As IHtmlString
            Return DateDisplay(obj, "yyyy-MM-dd", UnDefDisp)
        End Function

        Public Shared Function DateDisplay(obj As Object, Optional format As String = "yyyy-MM-dd", Optional UnDefDisp As Boolean = True) As IHtmlString

            Dim sb As New StringBuilder
            Dim sDate As String = CDate(obj).ToString(format)
            '最小値、最大値も表示
            If UnDefDisp Then
                sb.Append(HttpUtility.HtmlAttributeEncode(sDate))
            Else
                If CDate(obj) = AsamaConst.UndefDateMin OrElse
                 CDate(obj) = AsamaConst.UndefDateMax Then
                    sb.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;")
                Else
                    sb.Append(HttpUtility.HtmlAttributeEncode(sDate))
                End If
            End If
            Return MvcHtmlString.Create(sb.ToString)

        End Function



    End Class
End Namespace
