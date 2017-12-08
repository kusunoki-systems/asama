Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
''' <summary>
''' 医療材料用メタデータ
''' </summary>
Public Class M_DrugUnitEXMetaData

    <DisplayName("単位比率")>
    <DisplayFormat(ApplyFormatInEditMode:=True, DataFormatString:="{0:F5}")>
    <Required(ErrorMessage:="{0}を入力して下さい")>
    <RegularExpression("^[+-]?[0-9]*[\.]?[0-9]+$", ErrorMessage:="{0}は数字で入力して下さい")>
    <Range(-9999.99999, 9999.99999, ErrorMessage:="整数4桁、小数5桁以内で入力してください")>
    Public Property MDUT_UnitRatio As String

End Class
