<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class legassembly
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.tibiaEnabled = New System.Windows.Forms.CheckBox()
        Me.femurEnabled = New System.Windows.Forms.CheckBox()
        Me.coxaEnabled = New System.Windows.Forms.CheckBox()
        Me.tbTibia = New System.Windows.Forms.TrackBar()
        Me.nudTibia = New System.Windows.Forms.NumericUpDown()
        Me.tbFemur = New System.Windows.Forms.TrackBar()
        Me.nudFemur = New System.Windows.Forms.NumericUpDown()
        Me.lblTibia = New System.Windows.Forms.Label()
        Me.lblFemur = New System.Windows.Forms.Label()
        Me.lblCoxa = New System.Windows.Forms.Label()
        Me.tbCoxa = New System.Windows.Forms.TrackBar()
        Me.nudCoxa = New System.Windows.Forms.NumericUpDown()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.tbTibia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTibia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFemur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFemur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCoxa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCoxa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tibiaEnabled
        '
        Me.tibiaEnabled.AutoSize = True
        Me.tibiaEnabled.Checked = True
        Me.tibiaEnabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tibiaEnabled.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tibiaEnabled.Location = New System.Drawing.Point(89, 196)
        Me.tibiaEnabled.Name = "tibiaEnabled"
        Me.tibiaEnabled.Size = New System.Drawing.Size(68, 19)
        Me.tibiaEnabled.TabIndex = 11
        Me.tibiaEnabled.Text = "Enabled"
        Me.tibiaEnabled.UseVisualStyleBackColor = True
        '
        'femurEnabled
        '
        Me.femurEnabled.AutoSize = True
        Me.femurEnabled.Checked = True
        Me.femurEnabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.femurEnabled.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.femurEnabled.Location = New System.Drawing.Point(89, 131)
        Me.femurEnabled.Name = "femurEnabled"
        Me.femurEnabled.Size = New System.Drawing.Size(68, 19)
        Me.femurEnabled.TabIndex = 10
        Me.femurEnabled.Text = "Enabled"
        Me.femurEnabled.UseVisualStyleBackColor = True
        '
        'coxaEnabled
        '
        Me.coxaEnabled.AutoSize = True
        Me.coxaEnabled.Checked = True
        Me.coxaEnabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.coxaEnabled.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coxaEnabled.Location = New System.Drawing.Point(89, 66)
        Me.coxaEnabled.Name = "coxaEnabled"
        Me.coxaEnabled.Size = New System.Drawing.Size(68, 19)
        Me.coxaEnabled.TabIndex = 9
        Me.coxaEnabled.Text = "Enabled"
        Me.coxaEnabled.UseVisualStyleBackColor = True
        '
        'tbTibia
        '
        Me.tbTibia.AutoSize = False
        Me.tbTibia.LargeChange = 4
        Me.tbTibia.Location = New System.Drawing.Point(89, 158)
        Me.tbTibia.Maximum = 1024
        Me.tbTibia.Name = "tbTibia"
        Me.tbTibia.Size = New System.Drawing.Size(194, 30)
        Me.tbTibia.TabIndex = 8
        Me.tbTibia.TickFrequency = 32
        Me.tbTibia.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.tbTibia.Value = 512
        '
        'nudTibia
        '
        Me.nudTibia.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTibia.Location = New System.Drawing.Point(163, 193)
        Me.nudTibia.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.nudTibia.Name = "nudTibia"
        Me.nudTibia.Size = New System.Drawing.Size(120, 23)
        Me.nudTibia.TabIndex = 7
        Me.nudTibia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudTibia.Value = New Decimal(New Integer() {512, 0, 0, 0})
        '
        'tbFemur
        '
        Me.tbFemur.AutoSize = False
        Me.tbFemur.LargeChange = 4
        Me.tbFemur.Location = New System.Drawing.Point(89, 94)
        Me.tbFemur.Maximum = 1024
        Me.tbFemur.Name = "tbFemur"
        Me.tbFemur.Size = New System.Drawing.Size(194, 30)
        Me.tbFemur.TabIndex = 6
        Me.tbFemur.TickFrequency = 32
        Me.tbFemur.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.tbFemur.Value = 512
        '
        'nudFemur
        '
        Me.nudFemur.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudFemur.Location = New System.Drawing.Point(163, 129)
        Me.nudFemur.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.nudFemur.Name = "nudFemur"
        Me.nudFemur.Size = New System.Drawing.Size(120, 23)
        Me.nudFemur.TabIndex = 5
        Me.nudFemur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudFemur.Value = New Decimal(New Integer() {512, 0, 0, 0})
        '
        'lblTibia
        '
        Me.lblTibia.AutoSize = True
        Me.lblTibia.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTibia.Location = New System.Drawing.Point(3, 173)
        Me.lblTibia.Name = "lblTibia"
        Me.lblTibia.Size = New System.Drawing.Size(33, 15)
        Me.lblTibia.TabIndex = 4
        Me.lblTibia.Text = "Tibia"
        '
        'lblFemur
        '
        Me.lblFemur.AutoSize = True
        Me.lblFemur.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFemur.Location = New System.Drawing.Point(3, 109)
        Me.lblFemur.Name = "lblFemur"
        Me.lblFemur.Size = New System.Drawing.Size(41, 15)
        Me.lblFemur.TabIndex = 3
        Me.lblFemur.Text = "Femur"
        '
        'lblCoxa
        '
        Me.lblCoxa.AutoSize = True
        Me.lblCoxa.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoxa.Location = New System.Drawing.Point(3, 44)
        Me.lblCoxa.Name = "lblCoxa"
        Me.lblCoxa.Size = New System.Drawing.Size(33, 15)
        Me.lblCoxa.TabIndex = 2
        Me.lblCoxa.Text = "Coxa"
        '
        'tbCoxa
        '
        Me.tbCoxa.AutoSize = False
        Me.tbCoxa.LargeChange = 4
        Me.tbCoxa.Location = New System.Drawing.Point(89, 29)
        Me.tbCoxa.Maximum = 1024
        Me.tbCoxa.Name = "tbCoxa"
        Me.tbCoxa.Size = New System.Drawing.Size(194, 30)
        Me.tbCoxa.TabIndex = 1
        Me.tbCoxa.TickFrequency = 32
        Me.tbCoxa.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.tbCoxa.Value = 512
        '
        'nudCoxa
        '
        Me.nudCoxa.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCoxa.Location = New System.Drawing.Point(163, 64)
        Me.nudCoxa.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.nudCoxa.Name = "nudCoxa"
        Me.nudCoxa.Size = New System.Drawing.Size(120, 23)
        Me.nudCoxa.TabIndex = 0
        Me.nudCoxa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudCoxa.Value = New Decimal(New Integer() {512, 0, 0, 0})
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCaption.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption.Location = New System.Drawing.Point(0, 0)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(85, 17)
        Me.lblCaption.TabIndex = 12
        Me.lblCaption.Text = "Leg position"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.lblCaption)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 23)
        Me.Panel1.TabIndex = 13
        '
        'legassembly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.tibiaEnabled)
        Me.Controls.Add(Me.femurEnabled)
        Me.Controls.Add(Me.tbCoxa)
        Me.Controls.Add(Me.coxaEnabled)
        Me.Controls.Add(Me.nudCoxa)
        Me.Controls.Add(Me.tbTibia)
        Me.Controls.Add(Me.lblCoxa)
        Me.Controls.Add(Me.nudTibia)
        Me.Controls.Add(Me.lblFemur)
        Me.Controls.Add(Me.tbFemur)
        Me.Controls.Add(Me.lblTibia)
        Me.Controls.Add(Me.nudFemur)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "legassembly"
        Me.Size = New System.Drawing.Size(290, 223)
        CType(Me.tbTibia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTibia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFemur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFemur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCoxa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCoxa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tibiaEnabled As CheckBox
    Friend WithEvents femurEnabled As CheckBox
    Friend WithEvents coxaEnabled As CheckBox
    Friend WithEvents tbTibia As TrackBar
    Friend WithEvents nudTibia As NumericUpDown
    Friend WithEvents tbFemur As TrackBar
    Friend WithEvents nudFemur As NumericUpDown
    Friend WithEvents lblTibia As Label
    Friend WithEvents lblFemur As Label
    Friend WithEvents lblCoxa As Label
    Friend WithEvents tbCoxa As TrackBar
    Friend WithEvents nudCoxa As NumericUpDown
    Friend WithEvents lblCaption As Label
    Friend WithEvents Panel1 As Panel
End Class
