<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inspect_judge
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
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btn_pass = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_failed = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_pending = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BorderRadius = 3
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(360, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'btn_pass
        '
        Me.btn_pass.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_pass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_pass.FillColor = System.Drawing.Color.ForestGreen
        Me.btn_pass.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pass.ForeColor = System.Drawing.Color.White
        Me.btn_pass.Location = New System.Drawing.Point(118, 94)
        Me.btn_pass.Name = "btn_pass"
        Me.btn_pass.Size = New System.Drawing.Size(180, 60)
        Me.btn_pass.TabIndex = 1
        Me.btn_pass.Text = "Passed"
        '
        'btn_failed
        '
        Me.btn_failed.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_failed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_failed.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_failed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_failed.FillColor = System.Drawing.Color.Tomato
        Me.btn_failed.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_failed.ForeColor = System.Drawing.Color.White
        Me.btn_failed.Location = New System.Drawing.Point(118, 173)
        Me.btn_failed.Name = "btn_failed"
        Me.btn_failed.Size = New System.Drawing.Size(180, 60)
        Me.btn_failed.TabIndex = 2
        Me.btn_failed.Text = "Failed"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER
        Me.Guna2BorderlessForm1.BorderRadius = 15
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(90, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "What is your overall Judgement?"
        '
        'txt_pending
        '
        Me.txt_pending.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_pending.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.txt_pending.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.txt_pending.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txt_pending.FillColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_pending.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pending.ForeColor = System.Drawing.Color.White
        Me.txt_pending.Location = New System.Drawing.Point(118, 257)
        Me.txt_pending.Name = "txt_pending"
        Me.txt_pending.Size = New System.Drawing.Size(180, 60)
        Me.txt_pending.TabIndex = 4
        Me.txt_pending.Text = "Pending"
        '
        'inspect_judge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 356)
        Me.Controls.Add(Me.txt_pending)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_failed)
        Me.Controls.Add(Me.btn_pass)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "inspect_judge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "inspect_judge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btn_pass As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_failed As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_pending As Guna.UI2.WinForms.Guna2Button
End Class
