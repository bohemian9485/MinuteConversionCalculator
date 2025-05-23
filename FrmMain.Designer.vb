<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.ChkTopMost = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TxtFractions = New System.Windows.Forms.TextBox()
        Me.NudMinutes = New System.Windows.Forms.NumericUpDown()
        Me.NudDays = New System.Windows.Forms.NumericUpDown()
        Me.TxtHours = New System.Windows.Forms.TextBox()
        Me.NudHours = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtEarned = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtMonths = New System.Windows.Forms.TextBox()
        Me.NudMonths = New System.Windows.Forms.NumericUpDown()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.NudMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.NudMonths, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(228, 145)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(80, 27)
        Me.BtnExit.TabIndex = 6
        Me.BtnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.BtnExit, "Exit application")
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'ChkTopMost
        '
        Me.ChkTopMost.AutoSize = True
        Me.ChkTopMost.Location = New System.Drawing.Point(18, 147)
        Me.ChkTopMost.Name = "ChkTopMost"
        Me.ChkTopMost.Size = New System.Drawing.Size(77, 22)
        Me.ChkTopMost.TabIndex = 5
        Me.ChkTopMost.Text = "On Top"
        Me.ToolTip1.SetToolTip(Me.ChkTopMost, "Set this window on top of other windows")
        Me.ChkTopMost.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Conversion Calculator"
        '
        'TxtFractions
        '
        Me.TxtFractions.Location = New System.Drawing.Point(62, 23)
        Me.TxtFractions.Name = "TxtFractions"
        Me.TxtFractions.ReadOnly = True
        Me.TxtFractions.Size = New System.Drawing.Size(80, 24)
        Me.TxtFractions.TabIndex = 1
        Me.TxtFractions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.TxtFractions, "Fractions of a day")
        '
        'NudMinutes
        '
        Me.NudMinutes.Location = New System.Drawing.Point(6, 23)
        Me.NudMinutes.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NudMinutes.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudMinutes.Name = "NudMinutes"
        Me.NudMinutes.Size = New System.Drawing.Size(50, 24)
        Me.NudMinutes.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.NudMinutes, "Conversion of working minutes into fractions of a day")
        Me.NudMinutes.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NudDays
        '
        Me.NudDays.Location = New System.Drawing.Point(6, 23)
        Me.NudDays.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NudDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudDays.Name = "NudDays"
        Me.NudDays.Size = New System.Drawing.Size(50, 24)
        Me.NudDays.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.NudDays, "Vacation and sick leave credits earned on a daily basis")
        Me.NudDays.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TxtHours
        '
        Me.TxtHours.Location = New System.Drawing.Point(62, 23)
        Me.TxtHours.Name = "TxtHours"
        Me.TxtHours.ReadOnly = True
        Me.TxtHours.Size = New System.Drawing.Size(80, 24)
        Me.TxtHours.TabIndex = 1
        Me.TxtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.TxtHours, "Hours to be converted, maximum is 8")
        '
        'NudHours
        '
        Me.NudHours.Location = New System.Drawing.Point(6, 23)
        Me.NudHours.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NudHours.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudHours.Name = "NudHours"
        Me.NudHours.Size = New System.Drawing.Size(50, 24)
        Me.NudHours.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.NudHours, "Conversion of working hours into fractions of a day")
        Me.NudHours.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NudMinutes)
        Me.GroupBox1.Controls.Add(Me.TxtFractions)
        Me.GroupBox1.Location = New System.Drawing.Point(166, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 53)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Minute/s"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtEarned)
        Me.GroupBox2.Controls.Add(Me.NudDays)
        Me.GroupBox2.Location = New System.Drawing.Point(166, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(148, 53)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Day/s"
        '
        'TxtEarned
        '
        Me.TxtEarned.Location = New System.Drawing.Point(62, 23)
        Me.TxtEarned.Name = "TxtEarned"
        Me.TxtEarned.ReadOnly = True
        Me.TxtEarned.Size = New System.Drawing.Size(80, 24)
        Me.TxtEarned.TabIndex = 1
        Me.TxtEarned.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtHours)
        Me.GroupBox3.Controls.Add(Me.NudHours)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(148, 53)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hour/s"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtMonths)
        Me.GroupBox4.Controls.Add(Me.NudMonths)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(148, 53)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Month/s"
        '
        'TxtMonths
        '
        Me.TxtMonths.Location = New System.Drawing.Point(62, 23)
        Me.TxtMonths.Name = "TxtMonths"
        Me.TxtMonths.ReadOnly = True
        Me.TxtMonths.Size = New System.Drawing.Size(80, 24)
        Me.TxtMonths.TabIndex = 1
        Me.TxtMonths.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NudMonths
        '
        Me.NudMonths.Location = New System.Drawing.Point(6, 23)
        Me.NudMonths.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.NudMonths.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudMonths.Name = "NudMonths"
        Me.NudMonths.Size = New System.Drawing.Size(50, 24)
        Me.NudMonths.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.NudMonths, "Vacation and sick leave credits earned on a monthly basis")
        Me.NudMonths.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MnuAbout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(326, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(113, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MnuAbout
        '
        Me.MnuAbout.Name = "MnuAbout"
        Me.MnuAbout.Size = New System.Drawing.Size(52, 20)
        Me.MnuAbout.Text = "About"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 184)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ChkTopMost)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversion Calculator"
        CType(Me.NudMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.NudMonths, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnExit As Button
    Friend WithEvents ChkTopMost As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtFractions As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtEarned As TextBox
    Friend WithEvents NudDays As NumericUpDown
    Friend WithEvents NudMinutes As NumericUpDown
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtHours As TextBox
    Friend WithEvents NudHours As NumericUpDown
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtMonths As TextBox
    Friend WithEvents NudMonths As NumericUpDown
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuAbout As ToolStripMenuItem
End Class
