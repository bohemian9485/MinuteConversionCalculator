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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMinutes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtFractions = New System.Windows.Forms.TextBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.ChkTopMost = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Minutes"
        '
        'TxtMinutes
        '
        Me.TxtMinutes.Location = New System.Drawing.Point(147, 12)
        Me.TxtMinutes.Name = "TxtMinutes"
        Me.TxtMinutes.Size = New System.Drawing.Size(182, 24)
        Me.TxtMinutes.TabIndex = 1
        Me.TxtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.TxtMinutes, "Minutes to convert (maximum 3,840 minutes)")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Fractions of a Day"
        '
        'TxtFractions
        '
        Me.TxtFractions.Location = New System.Drawing.Point(147, 42)
        Me.TxtFractions.Name = "TxtFractions"
        Me.TxtFractions.ReadOnly = True
        Me.TxtFractions.Size = New System.Drawing.Size(182, 24)
        Me.TxtFractions.TabIndex = 3
        Me.TxtFractions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.TxtFractions, "Fractions of a day")
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(254, 72)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 27)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.BtnExit, "Exit application")
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'ChkTopMost
        '
        Me.ChkTopMost.AutoSize = True
        Me.ChkTopMost.Location = New System.Drawing.Point(12, 74)
        Me.ChkTopMost.Name = "ChkTopMost"
        Me.ChkTopMost.Size = New System.Drawing.Size(131, 22)
        Me.ChkTopMost.TabIndex = 4
        Me.ChkTopMost.Text = "&Top Most Form"
        Me.ToolTip1.SetToolTip(Me.ChkTopMost, "Set this window on top of other windows")
        Me.ChkTopMost.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Conversion Calculator"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 111)
        Me.Controls.Add(Me.ChkTopMost)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.TxtFractions)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMinutes)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversion Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtMinutes As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtFractions As TextBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents ChkTopMost As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
