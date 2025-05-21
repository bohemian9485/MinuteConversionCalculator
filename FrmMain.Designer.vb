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
        Me.TxtMinutes = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtEarned = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NudDays = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NudDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(191, 160)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 27)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.BtnExit, "Exit application")
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'ChkTopMost
        '
        Me.ChkTopMost.AutoSize = True
        Me.ChkTopMost.Location = New System.Drawing.Point(12, 162)
        Me.ChkTopMost.Name = "ChkTopMost"
        Me.ChkTopMost.Size = New System.Drawing.Size(131, 22)
        Me.ChkTopMost.TabIndex = 2
        Me.ChkTopMost.Text = "&Top Most Form"
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
        Me.TxtFractions.Location = New System.Drawing.Point(157, 53)
        Me.TxtFractions.Name = "TxtFractions"
        Me.TxtFractions.ReadOnly = True
        Me.TxtFractions.Size = New System.Drawing.Size(97, 24)
        Me.TxtFractions.TabIndex = 3
        Me.TxtFractions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.TxtFractions, "Fractions of a day")
        '
        'TxtMinutes
        '
        Me.TxtMinutes.Location = New System.Drawing.Point(157, 23)
        Me.TxtMinutes.Name = "TxtMinutes"
        Me.TxtMinutes.Size = New System.Drawing.Size(97, 24)
        Me.TxtMinutes.TabIndex = 1
        Me.TxtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.TxtMinutes, "Minutes to convert (maximum 3,840 minutes)")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtFractions)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtMinutes)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 83)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Minutes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Fractions of a Day"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Minutes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtEarned)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.NudDays)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 53)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Days"
        '
        'TxtEarned
        '
        Me.TxtEarned.Location = New System.Drawing.Point(174, 23)
        Me.TxtEarned.Name = "TxtEarned"
        Me.TxtEarned.ReadOnly = True
        Me.TxtEarned.Size = New System.Drawing.Size(80, 24)
        Me.TxtEarned.TabIndex = 2
        Me.TxtEarned.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Credits Earned"
        '
        'NudDays
        '
        Me.NudDays.Location = New System.Drawing.Point(6, 23)
        Me.NudDays.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NudDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudDays.Name = "NudDays"
        Me.NudDays.Size = New System.Drawing.Size(50, 24)
        Me.NudDays.TabIndex = 0
        Me.NudDays.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 199)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ChkTopMost)
        Me.Controls.Add(Me.BtnExit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NudDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnExit As Button
    Friend WithEvents ChkTopMost As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtFractions As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtMinutes As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtEarned As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NudDays As NumericUpDown
End Class
