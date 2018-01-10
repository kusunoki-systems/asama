@ModelType System.DateTime
<!--http://www.atmarkit.co.jp/fdotnet/aspnetmvc3/aspnetmvc3_07/aspnetmvc3_07_02.html-->
@code
    If (ViewData.ModelMetadata.IsReadOnly) Then
        @Html.TextBox("", String.Format("{0:yyyy-MM-dd}", If(Model <> Nothing, Model, DateTime.Today)), New With {.readonly = "true", .disabled = "disabled"})
    Else
        @Html.TextBox("", String.Format("{0:yyyy-MM-dd}", If(Model <> Nothing, Model, DateTime.Today)), New With {.class = "datepicker form-control text-box single-line"})
    End If
end code

