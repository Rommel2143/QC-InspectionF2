Imports MySql.Data.MySqlClient
Imports System.Text
Public Class inspect_incoming
    Public selectedrow As Integer
    Public reference_no As String
    Private Sub inspect_incoming_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker1.Value = Date.Now

    End Sub






    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpicker1.ValueChanged
        cmb_display("SELECT distinct(batch) FROM `f2_parts_scan` WHERE datein='" & dtpicker1.Value.ToString("yyyy-MM-dd") & "' ORDER BY batch ", "batch", cmb_batch)
        datagrid1.DataSource = Nothing
        cmb_partcode.Items.Clear()
        datagrid1.Columns.Clear()
    End Sub


    Public Sub AddCheckboxColumn()
        ' Check if the checkbox column already exists
        If Not datagrid1.Columns.Contains("SelectCheckBox") Then
            ' Create a new checkbox column
            Dim checkboxColumn As New DataGridViewCheckBoxColumn()
            checkboxColumn.Name = "SelectCheckBox"
            checkboxColumn.HeaderText = "Select Item"
            checkboxColumn.FalseValue = False
            checkboxColumn.TrueValue = True
            checkboxColumn.Width = 10
            datagrid1.Columns.Add(checkboxColumn)
        End If
    End Sub
    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick
        ' Check if the click is in the checkbox column
        If e.ColumnIndex = datagrid1.Columns("SelectCheckBox").Index AndAlso e.RowIndex >= 0 Then
            ' Toggle the checkbox value
            Dim isChecked As Boolean = Convert.ToBoolean(datagrid1.Rows(e.RowIndex).Cells("SelectCheckBox").Value)
            datagrid1.Rows(e.RowIndex).Cells("SelectCheckBox").Value = Not isChecked
        End If
    End Sub

    Public Sub refreshgrid()
        Try
            con.Close()
            con.Open()
            Dim query As String = "SELECT ps.id as Record_ID, `suppliercode`, `remarks`, `lotnumber`,`serial`, `qty`, datein,
                              CASE `status_inspect` 
                              WHEN 0 THEN 'Pending' 
                              WHEN 1 THEN 'Passed' 
                              WHEN 2 THEN 'Failed' 
                              END AS `status` , inspect_remarks AS Inspector_Remarks 
                              FROM f2_parts_scan ps
                            JOIN f2_parts_masterlist pm  ON pm.partcode = ps.partcode AND pm.supplier = ps.suppliercode
                                
                              WHERE datein = @datein AND batch = @batch and ps.partcode=@partcode"

            Dim cmdrefreshgrid As New MySqlCommand(query, con)
            cmdrefreshgrid.Parameters.AddWithValue("@datein", dtpicker1.Value.ToString("yyyy-MM-dd"))
            cmdrefreshgrid.Parameters.AddWithValue("@batch", cmb_batch.Text)
            cmdrefreshgrid.Parameters.AddWithValue("@partcode", cmb_partcode.Text)

            Dim da As New MySqlDataAdapter(cmdrefreshgrid)
            Dim dt As New DataTable
            da.Fill(dt)
            datagrid1.DataSource = dt


            datagrid1.Columns("Record_ID").Visible = False
            HighlightPreviousRecords()

        Catch ex As Exception
            display_error(ex.Message, 0)
        Finally
            con.Close()

        End Try
    End Sub
    Private Sub HighlightPreviousRecords()
        Try
            For Each row As DataGridViewRow In datagrid1.Rows

                If Not row.IsNewRow Then
                    Dim lotNumber As String = row.Cells("lotnumber").Value.ToString()
                    Dim query As String = "SELECT id FROM f2_parts_scan 
                          WHERE datein < '" & dtpicker1.Value.ToString("yyyy-MM-dd") & "'  AND lotnumber ='" & lotNumber & "' 
                         LIMIT 1"
                    con.Close()
                    con.Open()
                    Dim cmd As New MySqlCommand(query, con)
                    dr = cmd.ExecuteReader
                    If dr.Read = True Then
                        row.DefaultCellStyle.BackColor = Color.Tomato
                        row.DefaultCellStyle.ForeColor = Color.White
                    Else
                        row.DefaultCellStyle.BackColor = Color.White
                        row.DefaultCellStyle.ForeColor = Color.Black
                    End If

                End If
            Next


        Catch ex As Exception
            display_error(ex.Message, 0)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        If btn_select.Text = "Select all" Then

            ' Loop through all rows to check/uncheck the checkbox in each row
            For Each row As DataGridViewRow In datagrid1.Rows

                row.Cells("SelectCheckBox").Value = CheckState.Checked

            Next
            btn_select.Text = "Clear"
        Else

            ' Loop through all rows to check/uncheck the checkbox in each row
            For Each row As DataGridViewRow In datagrid1.Rows

                row.Cells("SelectCheckBox").Value = CheckState.Unchecked

            Next
            btn_select.Text = "Select all"
        End If

    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Dim inspect As New inspect_judge
            inspect.Show()
            inspect.BringToFront()

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_batch.SelectedIndexChanged
        cmb_display("SELECT DISTINCT(partcode)  FROM `f2_parts_scan`  WHERE datein = '" & dtpicker1.Value.ToString("yyyy-MM-dd") & "' AND batch = '" & cmb_batch.Text & "'", "partcode", cmb_partcode)



    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmb_partcode.SelectedIndexChanged
        refreshgrid()
        AddCheckboxColumn()
    End Sub

    Private Sub datagrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellDoubleClick
        ' Check if the click is on a valid row and column
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Initialize the lotnumber_select form and pass the lotnumber value
            Dim selectlot As New lotnumber_select
            Dim selectedLotNumber As String = datagrid1.Rows(e.RowIndex).Cells("lotnumber").Value.ToString()
            selectlot.lotnumber = selectedLotNumber

            ' Show the dialog and bring it to the front
            selectlot.ShowDialog()
            selectlot.BringToFront()
        End If
    End Sub

End Class