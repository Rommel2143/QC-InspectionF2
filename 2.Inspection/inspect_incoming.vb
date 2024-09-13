Imports MySql.Data.MySqlClient
Public Class inspect_incoming
    Public selectedrow As Integer
    Private headerCheckBox As CheckBox
    Private Sub inspect_incoming_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub



    Public Sub display_error(text As String)
        sounderror()
        error_panel.Visible = True
        lbl_error.Text = text
    End Sub



    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpicker1.ValueChanged
        cmb_display("SELECT distinct(batch) FROM `f2_parts_scan` WHERE datein='" & dtpicker1.Value.ToString("yyyy-MM-dd") & "' ORDER BY batch ", "batch", cmb_batch)
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
            Dim query As String = "SELECT id as Record_ID, `partcode`, `suppliercode`, `remarks`, `lotnumber`, `serial`, `qty`, 
                              CASE `status_inspect` 
                              WHEN 0 THEN 'Pending' 
                              WHEN 1 THEN 'Passed' 
                              WHEN 2 THEN 'Failed' 
                              END AS `status` 
                              FROM `f2_parts_scan` 
                              WHERE datein = @datein AND batch = @batch"

            Dim cmdrefreshgrid As New MySqlCommand(query, con)
            cmdrefreshgrid.Parameters.AddWithValue("@datein", dtpicker1.Value.ToString("yyyy-MM-dd"))
            cmdrefreshgrid.Parameters.AddWithValue("@batch", cmb_batch.Text)

            Dim da As New MySqlDataAdapter(cmdrefreshgrid)
            Dim dt As New DataTable
            da.Fill(dt)
            datagrid1.DataSource = dt


            datagrid1.Columns("Record_ID").Visible = False


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub


    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        error_panel.Visible = False
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        If btn_select.Text = "Select all" Then

            ' Loop through all rows to check/uncheck the checkbox in each row
            For Each row As DataGridViewRow In datagrid1.Rows

                row.Cells("SelectCheckBox").Value = CheckState.Checked

            Next
            btn_select.Text = "Unselect all"
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
        'inspect_judge.Show()
        'inspect_judge.BringToFront()
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_batch.SelectedIndexChanged

        refreshgrid()
        AddCheckboxColumn()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class