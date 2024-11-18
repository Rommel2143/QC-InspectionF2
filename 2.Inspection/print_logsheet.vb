Imports MySql.Data.MySqlClient
Public Class print_logsheet

    Private Sub printlogsheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker1.Value = Date.Now
    End Sub
    Private Sub dtpicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Sub viewdata()
        con.Close()
        con.Open()
        Dim showreport As New MySqlCommand("SELECT 
                                                ps.id,
                                                ps.batch,
                                                ps.partcode,
                                                ps.suppliercode,
                                                ps.lotnumber,
                                                ps.serial,
                                                ps.remarks,
                                                ps.qty,
                                                ps.datein,
                                           CASE ps.status_inspect 
                                                  WHEN 0 THEN 'Pending' 
                                                  WHEN 1 THEN 'Passed' 
                                                  WHEN 2 THEN 'Failed' 
                                                  END AS status_inspect,
                                                ps.inspector,
                                                ps.date_inspect,
                                                ps.reference,
                                                ps.inspect_remarks,
                                                pm.partname,
                                                CONCAT(pm.partname, ' (', ps.partcode, ')') AS part_details
                                            FROM 
                                                f2_parts_scan ps
                                            JOIN f2_parts_masterlist pm ON ps.partcode=pm.partcode
                                                
                                            WHERE
                                                    ps.date_inspect='" & dtpicker1.Value.ToString("yyyy-MM-dd") & "' and ps.batch = '" & cmb_batch.Text & "' and ps.partcode= '" & cmb_partcode.Text & "'
                                           
                                            ORDER BY
                                                   ps.lotnumber ASC", con)
        Dim da As New MySqlDataAdapter(showreport)
        da.Fill(dt)
        con.Close()

    End Sub

    Private Sub cmb_reference_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_batch.SelectedIndexChanged

        cmb_display("SELECT DISTINCT(partcode)  FROM `f2_parts_scan`  WHERE date_inspect = '" & dtpicker1.Value.ToString("yyyy-MM-dd") & "' AND batch = '" & cmb_batch.Text & "'", "partcode", cmb_partcode)


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub cmb_partcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_partcode.SelectedIndexChanged
        Dim myrpt As New inspection_logsheet
        dt.Clear()
        viewdata()
        myrpt.Database.Tables("F2_parts_scan").SetDataSource(dt)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt
    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpicker1.ValueChanged
        cmb_display("SELECT DISTINCT(batch) FROM f2_parts_scan WHERE date_inspect='" & dtpicker1.Value.ToString("yyyy-MM-dd") & "'", "batch", cmb_batch)
    End Sub
End Class