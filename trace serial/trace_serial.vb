Public Class trace_serial
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
    End Sub

    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        If txt_search.Text = "" Then
        Else

            reload("SELECT `id`, `batch`, `drsi`, `qrcode`, `partcode`, `suppliercode`, `lotnumber`, `serial`, `remarks`, `qty`, `datein`, `timein`, `userin`, `batchout`, `userout`, `dateout`, `inspector`, `inspect_remarks`, `date_inspect` FROM `f2_parts_scan` WHERE serial REGEXP '" & txt_search.Text & "' OR lotnumber REGEXP '" & txt_search.Text & "'", datagrid1)
        End If
    End Sub

    Private Sub export_excel_Click(sender As Object, e As EventArgs) Handles export_excel.Click
        exportexcel(datagrid1)
    End Sub
End Class