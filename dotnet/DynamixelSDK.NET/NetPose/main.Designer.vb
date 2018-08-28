<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits DevComponents.DotNetBar.OfficeForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Legassembly6 = New Assemblies.legassembly()
        Me.Legassembly5 = New Assemblies.legassembly()
        Me.Legassembly4 = New Assemblies.legassembly()
        Me.Legassembly3 = New Assemblies.legassembly()
        Me.Legassembly2 = New Assemblies.legassembly()
        Me.Legassembly1 = New Assemblies.legassembly()
        Me.cmdReadPosAll = New System.Windows.Forms.Button()
        Me.cmdTorqueOn = New System.Windows.Forms.Button()
        Me.cmdTorqueOff = New System.Windows.Forms.Button()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.StyleManagerAmbient1 = New DevComponents.DotNetBar.StyleManagerAmbient(Me.components)
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.cboPort = New DevComponents.DotNetBar.ComboBoxItem()
        Me.btnReloadPorts = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem()
        Me.cboBaud = New DevComponents.DotNetBar.ComboBoxItem()
        Me.btnConnect = New DevComponents.DotNetBar.ButtonItem()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(498, 489)
        Me.Panel1.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.NetPose.My.Resources.Resources.servonum
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(498, 489)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TabControl1.Location = New System.Drawing.Point(900, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(512, 524)
        Me.TabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.RichTextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(504, 495)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Console"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.DetectUrls = False
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Lime
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(498, 489)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(504, 495)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PhantomX ID''s"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Legassembly6
        '
        Me.Legassembly6.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.Legassembly6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Legassembly6.LegId = 1
        Me.Legassembly6.LegLocation = Assemblies.eLegLocation.LeftFront
        Me.Legassembly6.Location = New System.Drawing.Point(604, 37)
        Me.Legassembly6.MaximumSize = New System.Drawing.Size(290, 203)
        Me.Legassembly6.MinimumSize = New System.Drawing.Size(290, 203)
        Me.Legassembly6.Name = "Legassembly6"
        Me.Legassembly6.Size = New System.Drawing.Size(290, 203)
        Me.Legassembly6.TabIndex = 13
        '
        'Legassembly5
        '
        Me.Legassembly5.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.Legassembly5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Legassembly5.LegId = 2
        Me.Legassembly5.LegLocation = Assemblies.eLegLocation.RightFront
        Me.Legassembly5.Location = New System.Drawing.Point(604, 246)
        Me.Legassembly5.MaximumSize = New System.Drawing.Size(290, 203)
        Me.Legassembly5.MinimumSize = New System.Drawing.Size(290, 203)
        Me.Legassembly5.Name = "Legassembly5"
        Me.Legassembly5.Size = New System.Drawing.Size(290, 203)
        Me.Legassembly5.TabIndex = 12
        '
        'Legassembly4
        '
        Me.Legassembly4.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.Legassembly4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Legassembly4.LegId = 3
        Me.Legassembly4.LegLocation = Assemblies.eLegLocation.LeftMiddle
        Me.Legassembly4.Location = New System.Drawing.Point(308, 37)
        Me.Legassembly4.MaximumSize = New System.Drawing.Size(290, 203)
        Me.Legassembly4.MinimumSize = New System.Drawing.Size(290, 203)
        Me.Legassembly4.Name = "Legassembly4"
        Me.Legassembly4.Size = New System.Drawing.Size(290, 203)
        Me.Legassembly4.TabIndex = 11
        '
        'Legassembly3
        '
        Me.Legassembly3.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.Legassembly3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Legassembly3.LegId = 4
        Me.Legassembly3.LegLocation = Assemblies.eLegLocation.RightMiddle
        Me.Legassembly3.Location = New System.Drawing.Point(308, 246)
        Me.Legassembly3.MaximumSize = New System.Drawing.Size(290, 203)
        Me.Legassembly3.MinimumSize = New System.Drawing.Size(290, 203)
        Me.Legassembly3.Name = "Legassembly3"
        Me.Legassembly3.Size = New System.Drawing.Size(290, 203)
        Me.Legassembly3.TabIndex = 10
        '
        'Legassembly2
        '
        Me.Legassembly2.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.Legassembly2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Legassembly2.LegId = 5
        Me.Legassembly2.LegLocation = Assemblies.eLegLocation.LeftRear
        Me.Legassembly2.Location = New System.Drawing.Point(12, 37)
        Me.Legassembly2.MaximumSize = New System.Drawing.Size(290, 203)
        Me.Legassembly2.MinimumSize = New System.Drawing.Size(290, 203)
        Me.Legassembly2.Name = "Legassembly2"
        Me.Legassembly2.Size = New System.Drawing.Size(290, 203)
        Me.Legassembly2.TabIndex = 9
        '
        'Legassembly1
        '
        Me.Legassembly1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.Legassembly1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Legassembly1.LegId = 6
        Me.Legassembly1.LegLocation = Assemblies.eLegLocation.RightRear
        Me.Legassembly1.Location = New System.Drawing.Point(12, 246)
        Me.Legassembly1.MaximumSize = New System.Drawing.Size(290, 203)
        Me.Legassembly1.MinimumSize = New System.Drawing.Size(290, 203)
        Me.Legassembly1.Name = "Legassembly1"
        Me.Legassembly1.Size = New System.Drawing.Size(290, 203)
        Me.Legassembly1.TabIndex = 8
        '
        'cmdReadPosAll
        '
        Me.cmdReadPosAll.Location = New System.Drawing.Point(12, 455)
        Me.cmdReadPosAll.Name = "cmdReadPosAll"
        Me.cmdReadPosAll.Size = New System.Drawing.Size(104, 23)
        Me.cmdReadPosAll.TabIndex = 17
        Me.cmdReadPosAll.Text = "Read positions"
        Me.cmdReadPosAll.UseVisualStyleBackColor = True
        '
        'cmdTorqueOn
        '
        Me.cmdTorqueOn.Location = New System.Drawing.Point(122, 455)
        Me.cmdTorqueOn.Name = "cmdTorqueOn"
        Me.cmdTorqueOn.Size = New System.Drawing.Size(75, 23)
        Me.cmdTorqueOn.TabIndex = 18
        Me.cmdTorqueOn.Text = "Torque ON"
        Me.cmdTorqueOn.UseVisualStyleBackColor = True
        '
        'cmdTorqueOff
        '
        Me.cmdTorqueOff.Location = New System.Drawing.Point(203, 455)
        Me.cmdTorqueOff.Name = "cmdTorqueOff"
        Me.cmdTorqueOff.Size = New System.Drawing.Size(75, 23)
        Me.cmdTorqueOff.TabIndex = 19
        Me.cmdTorqueOff.Text = "Torque OFF"
        Me.cmdTorqueOff.UseVisualStyleBackColor = True
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer)))
        '
        'Bar1
        '
        Me.Bar1.AccessibleDescription = "DotNetBar Bar (Bar1)"
        Me.Bar1.AccessibleName = "DotNetBar Bar"
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar1.AntiAlias = True
        Me.Bar1.CanCustomize = False
        Me.Bar1.DoubleClickBehavior = DevComponents.DotNetBar.eDoubleClickBarBehavior.None
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem1, Me.cboPort, Me.btnReloadPorts, Me.LabelItem2, Me.cboBaud, Me.btnConnect})
        Me.Bar1.Location = New System.Drawing.Point(308, 2)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(302, 29)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 20
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "Port"
        '
        'cboPort
        '
        Me.cboPort.DropDownHeight = 106
        Me.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cboPort.ItemHeight = 18
        Me.cboPort.Name = "cboPort"
        '
        'btnReloadPorts
        '
        Me.btnReloadPorts.Image = Global.NetPose.My.Resources.Resources.arrow_refresh
        Me.btnReloadPorts.Name = "btnReloadPorts"
        Me.btnReloadPorts.Text = "ButtonItem1"
        '
        'LabelItem2
        '
        Me.LabelItem2.Name = "LabelItem2"
        Me.LabelItem2.Text = "Baudrate"
        '
        'cboBaud
        '
        Me.cboBaud.DropDownHeight = 106
        Me.cboBaud.ItemHeight = 18
        Me.cboBaud.Name = "cboBaud"
        '
        'btnConnect
        '
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Text = "Connect"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1412, 524)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.cmdTorqueOff)
        Me.Controls.Add(Me.cmdTorqueOn)
        Me.Controls.Add(Me.cmdReadPosAll)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Legassembly6)
        Me.Controls.Add(Me.Legassembly5)
        Me.Controls.Add(Me.Legassembly4)
        Me.Controls.Add(Me.Legassembly3)
        Me.Controls.Add(Me.Legassembly2)
        Me.Controls.Add(Me.Legassembly1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NetPose"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Legassembly1 As Assemblies.legassembly
    Friend WithEvents Legassembly2 As Assemblies.legassembly
    Friend WithEvents Legassembly4 As Assemblies.legassembly
    Friend WithEvents Legassembly3 As Assemblies.legassembly
    Friend WithEvents Legassembly5 As Assemblies.legassembly
    Friend WithEvents Legassembly6 As Assemblies.legassembly
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmdReadPosAll As Button
    Friend WithEvents cmdTorqueOn As Button
    Friend WithEvents cmdTorqueOff As Button
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents StyleManagerAmbient1 As DevComponents.DotNetBar.StyleManagerAmbient
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents cboPort As DevComponents.DotNetBar.ComboBoxItem
    Friend WithEvents LabelItem2 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents cboBaud As DevComponents.DotNetBar.ComboBoxItem
    Friend WithEvents btnReloadPorts As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnConnect As DevComponents.DotNetBar.ButtonItem
End Class
