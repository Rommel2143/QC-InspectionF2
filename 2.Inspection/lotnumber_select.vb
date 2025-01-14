Public Class lotnumber_select
    Public Property lotnumber As String
    Private Sub lotnumber_select_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_lot.Text = lotnumber
        reload("SELECT batch,partcode,serial,remarks, datein FROM `f2_parts_scan` WHERE lotnumber='" & lotnumber & "' GROUP BY datein ORDER BY datein DESC", datagrid1)
    End Sub

End Class