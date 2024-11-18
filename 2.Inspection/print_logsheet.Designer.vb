<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class print_logsheet
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_partcode = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_batch = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.dtpicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtpicker1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmb_partcode)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmb_batch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1259, 152)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(633, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Partcode"
        '
        'cmb_partcode
        '
        Me.cmb_partcode.BackColor = System.Drawing.Color.Transparent
        Me.cmb_partcode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_partcode.DropDownHeight = 360
        Me.cmb_partcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_partcode.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_partcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_partcode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_partcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_partcode.IntegralHeight = False
        Me.cmb_partcode.ItemHeight = 30
        Me.cmb_partcode.Location = New System.Drawing.Point(636, 53)
        Me.cmb_partcode.MaxDropDownItems = 10
        Me.cmb_partcode.Name = "cmb_partcode"
        Me.cmb_partcode.Size = New System.Drawing.Size(259, 36)
        Me.cmb_partcode.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(329, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Batch Code:"
        '
        'cmb_batch
        '
        Me.cmb_batch.BackColor = System.Drawing.Color.Transparent
        Me.cmb_batch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_batch.DropDownHeight = 360
        Me.cmb_batch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_batch.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_batch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_batch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_batch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_batch.IntegralHeight = False
        Me.cmb_batch.ItemHeight = 30
        Me.cmb_batch.Location = New System.Drawing.Point(332, 53)
        Me.cmb_batch.MaxDropDownItems = 10
        Me.cmb_batch.Name = "cmb_batch"
        Me.cmb_batch.Size = New System.Drawing.Size(259, 36)
        Me.cmb_batch.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(38, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Date Inspected :"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 152)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1259, 610)
        Me.CrystalReportViewer1.TabIndex = 1
        '
        'dtpicker1
        '
        Me.dtpicker1.Animated = True
        Me.dtpicker1.BorderColor = System.Drawing.Color.MidnightBlue
        Me.dtpicker1.BorderRadius = 5
        Me.dtpicker1.BorderThickness = 1
        Me.dtpicker1.Checked = True
        Me.dtpicker1.FillColor = System.Drawing.Color.White
        Me.dtpicker1.FocusedColor = System.Drawing.Color.Transparent
        Me.dtpicker1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpicker1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dtpicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpicker1.Location = New System.Drawing.Point(41, 54)
        Me.dtpicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpicker1.Name = "dtpicker1"
        Me.dtpicker1.Size = New System.Drawing.Size(250, 36)
        Me.dtpicker1.TabIndex = 12
        Me.dtpicker1.Value = New Date(2024, 9, 11, 10, 46, 26, 749)
        '
        'print_logsheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 762)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "print_logsheet"
        Me.Text = "print_logsheet"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_batch As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_partcode As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dtpicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
