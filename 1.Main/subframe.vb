Public Class subframe

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles logout.Click
        display_mainframe(Login)
        Login.txt_password.Clear()
    End Sub

    Private Sub DeviceInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeviceInfoToolStripMenuItem.Click
        MessageBox.Show("Device loc:" & PClocation & "   /  Mac:" & PCmac & "   /  Device:" & PCname & "", "This Device is Registered", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub InspectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InspectToolStripMenuItem.Click
        display_formsub(inspect_incoming, InspectToolStripMenuItem.Text)
    End Sub

    Private Sub ManageMyProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageMyProfileToolStripMenuItem.Click
        display_formsub(manage_profiles, "Manage my profile")
    End Sub

    Private Sub IncomingLogsheetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncomingLogsheetToolStripMenuItem.Click
        display_formsub(print_logsheet, "Print Incoming Inspection History Logsheet")
    End Sub

    Private Sub SuggestImprovementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuggestImprovementToolStripMenuItem.Click
        Dim suggest As New suggest_updates
        suggest.ShowDialog()

    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        Try
            Dim setupPath As String = "\\ptif1-ds\SystemServer\QC-Inspection(F2)\setup.exe"
            If System.IO.File.Exists(setupPath) Then
                Process.Start(setupPath)
                Application.Exit()
            Else
                MessageBox.Show("Update file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while trying to update: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchLotNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchLotNumberToolStripMenuItem.Click
        display_formsub(parts_logs, "Parts Logs")
    End Sub
End Class