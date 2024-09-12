Imports MySql.Data.MySqlClient
Imports System.Reflection
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txt_password.PasswordChar = "*"c
            Dim version As String = Assembly.GetExecutingAssembly().GetName().Version.ToString()

            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("SELECT * FROM trc_device WHERE `PCname`='" & PCname & "' and `PCmac`='" & PCmac & "'", con)
            dr = cmdselect.ExecuteReader
            If dr.Read = True Then
                PClocation = dr.GetString("location")

            Else
                Dim result As DialogResult = MessageBox.Show("Please contact System Administrator!", "Machine not Verified", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)


                If result = DialogResult.OK Then
                    display_mainframe(Register_PC)

                ElseIf result = DialogResult.Cancel Then
                    con.Close()
                    Application.Exit()
                End If



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Close()


        End Try

    End Sub
    Private Sub login()
        Try
            Dim idwithA As String = "A" & txt_user.Text & "A"
            Dim idwithoutA As String = txt_user.Text.TrimStart("A"c).TrimEnd("A"c)
            Dim idwithoutasmall As String = txt_user.Text.TrimStart("a"c).TrimEnd("a"c)
            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM trc_user WHERE (IDno = @idwithoutA OR IDno = @idwithA OR IDno = @idwithoutasmall ) and password = @password ", con)
            With cmd.Parameters
                .AddWithValue("@idwithoutA", idwithoutA)
                .AddWithValue("@idwithA", idwithA)
                .AddWithValue("@idwithoutasmall", idwithoutasmall)
                .AddWithValue("@password", txt_password.Text)

            End With
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                idno = dr.GetString("IDno")
                fname = dr.GetString("firstname")
                display_mainframe(subframe)
                If dr.GetInt32("level") = 0 Then

                    subframe.add_user.Visible = True
                Else
                    subframe.add_user.Visible = False
                End If
                subframe.userstrip.Text = "Hello, " & fname
                    subframe.lbl_calendar.Text = longdate
                    error_panel.Visible = False
                    logdata("login")

                Else
                    'no fname
                    error_panel.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Close()


        End Try
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        login()
    End Sub
    Private Sub Guna2ImageButton1_MouseDown(sender As Object, e As MouseEventArgs) Handles Guna2ImageButton1.MouseDown
        ' Show password characters
        txt_password.PasswordChar = ""
    End Sub

    ' This event will trigger when the button is released
    Private Sub Guna2ImageButton1_MouseUp(sender As Object, e As MouseEventArgs) Handles Guna2ImageButton1.MouseUp
        ' Hide password characters
        txt_password.PasswordChar = "*"c
    End Sub

    Private Sub txt_user_TextChanged(sender As Object, e As EventArgs) Handles txt_user.TextChanged

    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click

    End Sub
End Class