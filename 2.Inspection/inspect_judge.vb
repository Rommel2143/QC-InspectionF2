﻿Imports MySql.Data.MySqlClient
Public Class inspect_judge
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_pass.Click
        ChangeSelectedRowsStatus(1)
        Me.Close()
    End Sub

    Private Sub btn_failed_Click(sender As Object, e As EventArgs) Handles btn_failed.Click
        ChangeSelectedRowsStatus(2)
        Me.Close()
    End Sub
    Private Sub txt_pending_Click(sender As Object, e As EventArgs) Handles txt_pending.Click
        Try
            con.Close()
            con.Open()

            ' Loop through each row to find the selected ones
            For Each row As DataGridViewRow In inspect_incoming.datagrid1.Rows
                Dim isChecked As Boolean = Convert.ToBoolean(row.Cells("SelectCheckBox").Value)

                If isChecked Then
                    ' Get the row's ID
                    Dim rowId As Integer = Convert.ToInt32(row.Cells("Record_ID").Value)

                    ' Update the status_inspect for the selected row
                    Dim cmdUpdateStatus As New MySqlCommand("UPDATE `f2_parts_scan` SET `status_inspect` = @newStatus , inspector = '',date_inspect=NULL, inspect_remarks = ''  WHERE `id` = @id", con)
                    cmdUpdateStatus.Parameters.AddWithValue("@newStatus", 0)
                    cmdUpdateStatus.Parameters.AddWithValue("@id", rowId)

                    cmdUpdateStatus.ExecuteNonQuery()
                End If
            Next

            ' Refresh the grid to reflect the changes
            inspect_incoming.refreshgrid()
            inspect_incoming.btn_select.Text = "Select all"
            txt_remarks.Clear()
            Me.Close()
        Catch ex As Exception
            display_error(ex.Message, 0)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub ChangeSelectedRowsStatus(newStatus As Integer)
        Try
            con.Close()
            con.Open()

            ' Loop through each row to find the selected ones
            For Each row As DataGridViewRow In inspect_incoming.datagrid1.Rows
                Dim isChecked As Boolean = Convert.ToBoolean(row.Cells("SelectCheckBox").Value)

                If isChecked Then
                    ' Get the row's ID
                    Dim rowId As Integer = Convert.ToInt32(row.Cells("Record_ID").Value)

                    ' Update the status_inspect for the selected row
                    Dim cmdUpdateStatus As New MySqlCommand("UPDATE `f2_parts_scan` SET `status_inspect` = @newStatus , inspector = '" & idno & "',date_inspect = '" & datedb & "',inspect_remarks=@inspect_remarks  WHERE `id` = @id", con)
                    cmdUpdateStatus.Parameters.AddWithValue("@newStatus", newStatus)
                    cmdUpdateStatus.Parameters.AddWithValue("@id", rowId)
                    cmdUpdateStatus.Parameters.AddWithValue("@inspect_remarks", txt_remarks.Text)
                    cmdUpdateStatus.ExecuteNonQuery()
                End If
            Next

            ' Refresh the grid to reflect the changes
            inspect_incoming.refreshgrid()
            inspect_incoming.btn_select.Text = "Select all"
            txt_remarks.Clear()
        Catch ex As Exception
            display_error(ex.Message, 0)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub inspect_judge_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class