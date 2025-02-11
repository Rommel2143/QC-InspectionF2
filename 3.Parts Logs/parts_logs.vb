Public Class parts_logs
    Private Sub dtpicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpicker1.ValueChanged
        reload("SELECT lotnumber,COUNT(id) AS 'Box Count',SUM(QTY) as 'Total QTY' FROM f2_parts_scan WHERE datein='" & dtpicker1.Value.ToString("yyyy-MM-dd") & "' GROUP BY lotnumber", datagrid1)
    End Sub

    Private Sub export_excel_Click(sender As Object, e As EventArgs) Handles export_excel.Click
        exportexcel(datagrid1)
    End Sub
End Class