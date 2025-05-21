Public Class FrmSettings
    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NudLeaves.Value = My.Settings.LeavesEarnedInYear
        NudHours.Value = My.Settings.MaxHours
        Left = FrmMain.Left + (FrmMain.Width - Width) / 2
        Top = FrmMain.Top + (FrmMain.Height - Height) / 2
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim settingsSaved As Boolean = False
        With My.Settings
            If .LeavesEarnedInYear <> NudLeaves.Value Then
                .LeavesEarnedInYear = NudLeaves.Value
                settingsSaved = True
            End If
            If .MaxHours <> NudHours.Value Then
                .MaxHours = NudHours.Value
                settingsSaved = True
            End If
            If settingsSaved Then
                .Save()
                FrmMain.GetSettings()
                MessageBox.Show("Settings saved successfully.",
                                "Conversion Calculator",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Close()
            Else
                MessageBox.Show("No changes were made to the settings.",
                                "Conversion Calculator",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End If
        End With
    End Sub

    Private Sub NudLeaves_GotFocus(sender As Object, e As EventArgs) Handles NudLeaves.GotFocus
        NudLeaves.Select(0, NudLeaves.Text.Length)
    End Sub

    Private Sub NudHours_GotFocus(sender As Object, e As EventArgs) Handles NudHours.GotFocus
        NudHours.Select(0, NudHours.Text.Length)
    End Sub

    Private Sub FrmSettings_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then
            Close()
            Return
        End If
    End Sub
End Class