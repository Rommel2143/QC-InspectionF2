<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subframe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(subframe))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AssetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InspectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncomingLogsheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.userstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageMyProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeviceInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuggestImprovementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_calendar = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_tittle = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssetsToolStripMenuItem, Me.userstrip})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1346, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AssetsToolStripMenuItem
        '
        Me.AssetsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InspectToolStripMenuItem, Me.IncomingLogsheetToolStripMenuItem})
        Me.AssetsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.AssetsToolStripMenuItem.Name = "AssetsToolStripMenuItem"
        Me.AssetsToolStripMenuItem.Size = New System.Drawing.Size(113, 36)
        Me.AssetsToolStripMenuItem.Text = "QC Inspection"
        '
        'InspectToolStripMenuItem
        '
        Me.InspectToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.InspectToolStripMenuItem.Image = CType(resources.GetObject("InspectToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InspectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InspectToolStripMenuItem.Name = "InspectToolStripMenuItem"
        Me.InspectToolStripMenuItem.Size = New System.Drawing.Size(260, 38)
        Me.InspectToolStripMenuItem.Text = "Inspect Incoming"
        '
        'IncomingLogsheetToolStripMenuItem
        '
        Me.IncomingLogsheetToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.IncomingLogsheetToolStripMenuItem.Image = CType(resources.GetObject("IncomingLogsheetToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IncomingLogsheetToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.IncomingLogsheetToolStripMenuItem.Name = "IncomingLogsheetToolStripMenuItem"
        Me.IncomingLogsheetToolStripMenuItem.Size = New System.Drawing.Size(260, 38)
        Me.IncomingLogsheetToolStripMenuItem.Text = "Print Inspection Logsheet"
        '
        'userstrip
        '
        Me.userstrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.userstrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageMyProfileToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem, Me.DeviceInfoToolStripMenuItem, Me.SuggestImprovementToolStripMenuItem, Me.logout})
        Me.userstrip.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.userstrip.Image = CType(resources.GetObject("userstrip.Image"), System.Drawing.Image)
        Me.userstrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.userstrip.Name = "userstrip"
        Me.userstrip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.userstrip.Size = New System.Drawing.Size(82, 36)
        Me.userstrip.Text = "User"
        '
        'ManageMyProfileToolStripMenuItem
        '
        Me.ManageMyProfileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageMyProfileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ManageMyProfileToolStripMenuItem.Image = CType(resources.GetObject("ManageMyProfileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ManageMyProfileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ManageMyProfileToolStripMenuItem.Name = "ManageMyProfileToolStripMenuItem"
        Me.ManageMyProfileToolStripMenuItem.Size = New System.Drawing.Size(188, 30)
        Me.ManageMyProfileToolStripMenuItem.Text = "Manage my profile"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckForUpdatesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CheckForUpdatesToolStripMenuItem.Image = CType(resources.GetObject("CheckForUpdatesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CheckForUpdatesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(188, 30)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for updates"
        '
        'DeviceInfoToolStripMenuItem
        '
        Me.DeviceInfoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeviceInfoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DeviceInfoToolStripMenuItem.Image = CType(resources.GetObject("DeviceInfoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeviceInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DeviceInfoToolStripMenuItem.Name = "DeviceInfoToolStripMenuItem"
        Me.DeviceInfoToolStripMenuItem.Size = New System.Drawing.Size(188, 30)
        Me.DeviceInfoToolStripMenuItem.Text = "Device Info."
        '
        'SuggestImprovementToolStripMenuItem
        '
        Me.SuggestImprovementToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuggestImprovementToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SuggestImprovementToolStripMenuItem.Image = CType(resources.GetObject("SuggestImprovementToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SuggestImprovementToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SuggestImprovementToolStripMenuItem.Name = "SuggestImprovementToolStripMenuItem"
        Me.SuggestImprovementToolStripMenuItem.Size = New System.Drawing.Size(188, 30)
        Me.SuggestImprovementToolStripMenuItem.Text = "Suggest Updates"
        '
        'logout
        '
        Me.logout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.logout.Image = CType(resources.GetObject("logout.Image"), System.Drawing.Image)
        Me.logout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(188, 30)
        Me.logout.Text = "Logout"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1346, 721)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Controls.Add(Me.Guna2PictureBox2)
        Me.Panel2.Controls.Add(Me.lbl_calendar)
        Me.Panel2.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel2.Controls.Add(Me.lbl_tittle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1346, 24)
        Me.Panel2.TabIndex = 2
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(19, 3)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(20, 18)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 4
        Me.Guna2PictureBox2.TabStop = False
        '
        'lbl_calendar
        '
        Me.lbl_calendar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_calendar.AutoSize = True
        Me.lbl_calendar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_calendar.ForeColor = System.Drawing.Color.White
        Me.lbl_calendar.Location = New System.Drawing.Point(1235, 6)
        Me.lbl_calendar.Name = "lbl_calendar"
        Me.lbl_calendar.Size = New System.Drawing.Size(99, 15)
        Me.lbl_calendar.TabIndex = 3
        Me.lbl_calendar.Text = "MMMM-dd-yyyy"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(1209, 3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(20, 18)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        '
        'lbl_tittle
        '
        Me.lbl_tittle.AutoSize = True
        Me.lbl_tittle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tittle.ForeColor = System.Drawing.Color.White
        Me.lbl_tittle.Location = New System.Drawing.Point(43, 2)
        Me.lbl_tittle.Name = "lbl_tittle"
        Me.lbl_tittle.Size = New System.Drawing.Size(0, 20)
        Me.lbl_tittle.TabIndex = 0
        '
        'subframe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1346, 785)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "subframe"
        Me.Text = "subframe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AssetsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents userstrip As ToolStripMenuItem
    Friend WithEvents logout As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeviceInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuggestImprovementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InspectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncomingLogsheetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_tittle As Label
    Friend WithEvents lbl_calendar As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ManageMyProfileToolStripMenuItem As ToolStripMenuItem
End Class
