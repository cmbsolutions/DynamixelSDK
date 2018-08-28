<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class servo_ui
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
        Me.components = New System.ComponentModel.Container()
        Me.tbPositionSlider = New System.Windows.Forms.TrackBar()
        Me.chkServoOnOff = New System.Windows.Forms.CheckBox()
        Me.positionField = New System.Windows.Forms.NumericUpDown()
        Me.lblServoName = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.torque = New System.Windows.Forms.PictureBox()
        Me.errorIcon = New System.Windows.Forms.PictureBox()
        CType(Me.tbPositionSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.positionField, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.torque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbPositionSlider
        '
        Me.tbPositionSlider.AutoSize = False
        Me.tbPositionSlider.LargeChange = 4
        Me.tbPositionSlider.Location = New System.Drawing.Point(98, 3)
        Me.tbPositionSlider.Maximum = 1024
        Me.tbPositionSlider.Name = "tbPositionSlider"
        Me.tbPositionSlider.Size = New System.Drawing.Size(194, 30)
        Me.tbPositionSlider.TabIndex = 11
        Me.tbPositionSlider.TickFrequency = 32
        Me.tbPositionSlider.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.tbPositionSlider.Value = 512
        '
        'chkServoOnOff
        '
        Me.chkServoOnOff.AutoSize = True
        Me.chkServoOnOff.Checked = True
        Me.chkServoOnOff.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkServoOnOff.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkServoOnOff.Location = New System.Drawing.Point(115, 35)
        Me.chkServoOnOff.Name = "chkServoOnOff"
        Me.chkServoOnOff.Size = New System.Drawing.Size(68, 19)
        Me.chkServoOnOff.TabIndex = 13
        Me.chkServoOnOff.Text = "Enabled"
        Me.chkServoOnOff.UseVisualStyleBackColor = True
        '
        'positionField
        '
        Me.positionField.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.positionField.Location = New System.Drawing.Point(189, 34)
        Me.positionField.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.positionField.Name = "positionField"
        Me.positionField.Size = New System.Drawing.Size(94, 23)
        Me.positionField.TabIndex = 10
        Me.positionField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.positionField.Value = New Decimal(New Integer() {512, 0, 0, 0})
        '
        'lblServoName
        '
        Me.lblServoName.AutoSize = True
        Me.lblServoName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServoName.Location = New System.Drawing.Point(3, 23)
        Me.lblServoName.Name = "lblServoName"
        Me.lblServoName.Size = New System.Drawing.Size(68, 15)
        Me.lblServoName.TabIndex = 12
        Me.lblServoName.Text = "ServoName"
        '
        'torque
        '
        Me.torque.Image = Global.Assemblies.My.Resources.Resources.lightning
        Me.torque.Location = New System.Drawing.Point(19, 0)
        Me.torque.Name = "torque"
        Me.torque.Size = New System.Drawing.Size(16, 16)
        Me.torque.TabIndex = 15
        Me.torque.TabStop = False
        Me.ToolTip1.SetToolTip(Me.torque, "Torque enabled")
        Me.torque.Visible = False
        '
        'errorIcon
        '
        Me.errorIcon.Image = Global.Assemblies.My.Resources.Resources._error
        Me.errorIcon.Location = New System.Drawing.Point(0, 0)
        Me.errorIcon.Name = "errorIcon"
        Me.errorIcon.Size = New System.Drawing.Size(16, 16)
        Me.errorIcon.TabIndex = 14
        Me.errorIcon.TabStop = False
        Me.errorIcon.Visible = False
        '
        'servo_ui
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.torque)
        Me.Controls.Add(Me.errorIcon)
        Me.Controls.Add(Me.tbPositionSlider)
        Me.Controls.Add(Me.chkServoOnOff)
        Me.Controls.Add(Me.positionField)
        Me.Controls.Add(Me.lblServoName)
        Me.MaximumSize = New System.Drawing.Size(290, 60)
        Me.MinimumSize = New System.Drawing.Size(290, 60)
        Me.Name = "servo_ui"
        Me.Size = New System.Drawing.Size(290, 60)
        CType(Me.tbPositionSlider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.positionField, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.torque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbPositionSlider As TrackBar
    Friend WithEvents chkServoOnOff As CheckBox
    Friend WithEvents positionField As NumericUpDown
    Friend WithEvents lblServoName As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents errorIcon As PictureBox
    Friend WithEvents torque As PictureBox
End Class
