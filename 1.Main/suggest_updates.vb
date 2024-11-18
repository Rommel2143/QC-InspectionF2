Imports MySql.Data.MySqlClient
Public Class suggest_updates
    Private Sub txt_pending_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        submit("QC-inspectionf2")
    End Sub


    Private Sub submit(systemapp As String)
        Try
            ' Ensure the connection is closed before opening it
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()

            ' Define and execute the SQL insert command with the correct column names
            Dim submitsuggest As New MySqlCommand("INSERT INTO `trc_improvements` ( `user`, `suggestion`, `system`) VALUES ( @user, @suggestion, @system)", con)

            submitsuggest.Parameters.AddWithValue("@user", idno) ' Adjust this line if 'user' refers to a different value
            submitsuggest.Parameters.AddWithValue("@suggestion", txt_suggest.Text)
            submitsuggest.Parameters.AddWithValue("@system", systemapp)

            submitsuggest.ExecuteNonQuery()

            MessageBox.Show("Thank you! Your suggestion has been sent – we're excited to make improvements together!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error submitting suggestion: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed in the end
            con.Close()
        End Try
    End Sub

End Class