Public Class subframe

    Private Sub MasterlistToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles logout.Click
        display_mainframe(Login)
        Login.txt_password.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        con.Close()
        Application.Exit()

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
End Class