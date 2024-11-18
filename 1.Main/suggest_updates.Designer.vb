<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class suggest_updates
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(suggest_updates))
        Me.txt_suggest = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_submit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.SuspendLayout()
        '
        'txt_suggest
        '
        Me.txt_suggest.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_suggest.DefaultText = ""
        Me.txt_suggest.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_suggest.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_suggest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_suggest.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_suggest.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_suggest.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_suggest.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_suggest.Location = New System.Drawing.Point(26, 71)
        Me.txt_suggest.MaxLength = 350
        Me.txt_suggest.Multiline = True
        Me.txt_suggest.Name = "txt_suggest"
        Me.txt_suggest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_suggest.PlaceholderText = "Share your thoughts or suggestions to help us make the system even better!"
        Me.txt_suggest.SelectedText = ""
        Me.txt_suggest.Size = New System.Drawing.Size(515, 150)
        Me.txt_suggest.TabIndex = 0
        '
        'btn_submit
        '
        Me.btn_submit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_submit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_submit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_submit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_submit.FillColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_submit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit.ForeColor = System.Drawing.Color.White
        Me.btn_submit.Image = CType(resources.GetObject("btn_submit.Image"), System.Drawing.Image)
        Me.btn_submit.Location = New System.Drawing.Point(371, 227)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(170, 41)
        Me.btn_submit.TabIndex = 5
        Me.btn_submit.Text = "Submit Feedback"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BorderRadius = 3
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(515, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 6
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'suggest_updates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(572, 298)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.txt_suggest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "suggest_updates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "suggest_updates"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_suggest As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_submit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
