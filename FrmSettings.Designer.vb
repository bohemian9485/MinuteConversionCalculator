<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NudLeaves = New System.Windows.Forms.NumericUpDown()
        Me.NudHours = New System.Windows.Forms.NumericUpDown()
        Me.BtnSave = New System.Windows.Forms.Button()
        CType(Me.NudLeaves, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Leaves can be earned in a year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Maximum working hours"
        '
        'NudLeaves
        '
        Me.NudLeaves.Location = New System.Drawing.Point(175, 12)
        Me.NudLeaves.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudLeaves.Name = "NudLeaves"
        Me.NudLeaves.Size = New System.Drawing.Size(53, 20)
        Me.NudLeaves.TabIndex = 3
        Me.NudLeaves.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NudHours
        '
        Me.NudHours.Location = New System.Drawing.Point(175, 38)
        Me.NudHours.Maximum = New Decimal(New Integer() {34, 0, 0, 0})
        Me.NudHours.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudHours.Name = "NudHours"
        Me.NudHours.Size = New System.Drawing.Size(53, 20)
        Me.NudHours.TabIndex = 4
        Me.NudHours.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(153, 64)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 5
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 99)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.NudHours)
        Me.Controls.Add(Me.NudLeaves)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSettings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Settings"
        CType(Me.NudLeaves, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NudLeaves As NumericUpDown
    Friend WithEvents NudHours As NumericUpDown
    Friend WithEvents BtnSave As Button
End Class
