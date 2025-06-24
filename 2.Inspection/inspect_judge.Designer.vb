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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inspect_judge))
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btn_pass = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_failed = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_pending = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_remarks = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.SuspendLayout()
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BorderRadius = 3
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(485, 12)
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
        Me.btn_pass.Image = CType(resources.GetObject("btn_pass.Image"), System.Drawing.Image)
        Me.btn_pass.Location = New System.Drawing.Point(77, 148)
        Me.btn_pass.Name = "btn_pass"
        Me.btn_pass.Size = New System.Drawing.Size(388, 41)
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
        Me.btn_failed.Image = CType(resources.GetObject("btn_failed.Image"), System.Drawing.Image)
        Me.btn_failed.Location = New System.Drawing.Point(77, 195)
        Me.btn_failed.Name = "btn_failed"
        Me.btn_failed.Size = New System.Drawing.Size(388, 41)
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
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(18, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "       What is your overall Judgement?"
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
        Me.txt_pending.Image = CType(resources.GetObject("txt_pending.Image"), System.Drawing.Image)
        Me.txt_pending.Location = New System.Drawing.Point(77, 242)
        Me.txt_pending.Name = "txt_pending"
        Me.txt_pending.Size = New System.Drawing.Size(388, 41)
        Me.txt_pending.TabIndex = 4
        Me.txt_pending.Text = "Pending"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(165, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Remarks"
        '
        'txt_remarks
        '
        Me.txt_remarks.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_remarks.DefaultText = ""
        Me.txt_remarks.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_remarks.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_remarks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_remarks.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_remarks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_remarks.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txt_remarks.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_remarks.Location = New System.Drawing.Point(168, 105)
        Me.txt_remarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_remarks.MaxLength = 32
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.PlaceholderText = "input remarks..."
        Me.txt_remarks.SelectedText = ""
        Me.txt_remarks.Size = New System.Drawing.Size(209, 36)
        Me.txt_remarks.TabIndex = 6
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(22, 55)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(499, 10)
        Me.Guna2Separator1.TabIndex = 7
        '
        'inspect_judge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(542, 349)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.txt_remarks)
        Me.Controls.Add(Me.Label2)
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
    Friend WithEvents txt_remarks As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
End Class
