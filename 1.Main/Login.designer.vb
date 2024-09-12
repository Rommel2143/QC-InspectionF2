<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.txt_user = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_login = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.error_panel = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_error = New System.Windows.Forms.Label()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel1.SuspendLayout()
        Me.error_panel.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_user
        '
        Me.txt_user.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_user.DefaultText = ""
        Me.txt_user.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_user.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_user.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_user.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txt_user.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_user.IconLeft = CType(resources.GetObject("txt_user.IconLeft"), System.Drawing.Image)
        Me.txt_user.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.txt_user.Location = New System.Drawing.Point(140, 36)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_user.PlaceholderText = "Username..."
        Me.txt_user.SelectedText = ""
        Me.txt_user.Size = New System.Drawing.Size(229, 44)
        Me.txt_user.TabIndex = 14
        '
        'txt_password
        '
        Me.txt_password.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.DefaultText = ""
        Me.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.IconLeft = CType(resources.GetObject("txt_password.IconLeft"), System.Drawing.Image)
        Me.txt_password.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.txt_password.Location = New System.Drawing.Point(140, 88)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_password.PlaceholderText = "Password..."
        Me.txt_password.SelectedText = ""
        Me.txt_password.Size = New System.Drawing.Size(229, 44)
        Me.txt_password.TabIndex = 15
        '
        'btn_login
        '
        Me.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_login.FillColor = System.Drawing.SystemColors.HotTrack
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(198, 163)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(112, 42)
        Me.btn_login.TabIndex = 16
        Me.btn_login.Text = "Login"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.error_panel)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ImageButton1)
        Me.Guna2Panel1.Controls.Add(Me.btn_login)
        Me.Guna2Panel1.Controls.Add(Me.txt_password)
        Me.Guna2Panel1.Controls.Add(Me.txt_user)
        Me.Guna2Panel1.Location = New System.Drawing.Point(392, 244)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(509, 254)
        Me.Guna2Panel1.TabIndex = 17
        Me.Guna2Panel1.UseTransparentBackground = True
        '
        'error_panel
        '
        Me.error_panel.Controls.Add(Me.Guna2PictureBox1)
        Me.error_panel.Controls.Add(Me.lbl_error)
        Me.error_panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.error_panel.FillColor = System.Drawing.Color.Red
        Me.error_panel.FillColor2 = System.Drawing.Color.Tomato
        Me.error_panel.Location = New System.Drawing.Point(0, 220)
        Me.error_panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.error_panel.Name = "error_panel"
        Me.error_panel.Size = New System.Drawing.Size(509, 34)
        Me.error_panel.TabIndex = 29
        Me.error_panel.Visible = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(15, 1)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(27, 29)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'lbl_error
        '
        Me.lbl_error.AutoSize = True
        Me.lbl_error.BackColor = System.Drawing.Color.Transparent
        Me.lbl_error.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error.ForeColor = System.Drawing.Color.White
        Me.lbl_error.Location = New System.Drawing.Point(50, 7)
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(135, 20)
        Me.lbl_error.TabIndex = 0
        Me.lbl_error.Text = "Invalid Credentials"
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.BackColor = System.Drawing.Color.White
        Me.Guna2ImageButton1.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton1.ImageRotate = 0!
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(337, 100)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(29, 23)
        Me.Guna2ImageButton1.TabIndex = 28
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 727)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        Me.error_panel.ResumeLayout(False)
        Me.error_panel.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_user As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents error_panel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lbl_error As Label
End Class
