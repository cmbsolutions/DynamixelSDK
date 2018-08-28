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
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Servo3 = New Assemblies.servo_ui()
        Me.Servo2 = New Assemblies.servo_ui()
        Me.Servo1 = New Assemblies.servo_ui()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(288, 23)
        Me.Panel1.TabIndex = 13
        '
        'Servo3
        '
        Me.Servo3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Servo3.Location = New System.Drawing.Point(0, 143)
        Me.Servo3.MaximumSize = New System.Drawing.Size(290, 60)
        Me.Servo3.MinimumSize = New System.Drawing.Size(290, 60)
        Me.Servo3.Name = "Servo3"
        Me.Servo3.servoId = 12
        Me.Servo3.servoName = "RR Tibia"
        Me.Servo3.servoPosition = 512
        Me.Servo3.Size = New System.Drawing.Size(290, 60)
        Me.Servo3.TabIndex = 16
        '
        'Servo2
        '
        Me.Servo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Servo2.Location = New System.Drawing.Point(0, 83)
        Me.Servo2.MaximumSize = New System.Drawing.Size(290, 60)
        Me.Servo2.MinimumSize = New System.Drawing.Size(290, 60)
        Me.Servo2.Name = "Servo2"
        Me.Servo2.servoId = 10
        Me.Servo2.servoName = "RR Femur"
        Me.Servo2.servoPosition = 512
        Me.Servo2.Size = New System.Drawing.Size(290, 60)
        Me.Servo2.TabIndex = 15
        '
        'Servo1
        '
        Me.Servo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Servo1.Location = New System.Drawing.Point(0, 23)
        Me.Servo1.MaximumSize = New System.Drawing.Size(290, 60)
        Me.Servo1.MinimumSize = New System.Drawing.Size(290, 60)
        Me.Servo1.Name = "Servo1"
        Me.Servo1.servoId = 8
        Me.Servo1.servoName = "RR Coxa"
        Me.Servo1.servoPosition = 512
        Me.Servo1.Size = New System.Drawing.Size(290, 60)
        Me.Servo1.TabIndex = 14
        '
        'legassembly
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Servo3)
        Me.Controls.Add(Me.Servo2)
        Me.Controls.Add(Me.Servo1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.MaximumSize = New System.Drawing.Size(290, 203)
        Me.MinimumSize = New System.Drawing.Size(290, 203)
        Me.Name = "legassembly"
        Me.Size = New System.Drawing.Size(288, 201)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblCaption As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Servo1 As servo_ui
    Friend WithEvents Servo2 As servo_ui
    Friend WithEvents Servo3 As servo_ui
End Class
