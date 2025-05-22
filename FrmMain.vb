Public Class FrmMain

    Private leavesEarned As Integer
    Private wHours As Integer

    Private Sub ConvertDays()
        TxtEarned.Text = Math.Round((leavesEarned / 12) / 30 * NudDays.Value, 3).ToString("0.000")
    End Sub

    Private Sub ConvertedMinutes()
        Dim totalMinutes As Integer = wHours * 60
        If totalMinutes > 0 Then
            TxtFractions.Text = Math.Round(NudMinutes.Value / totalMinutes, 3).ToString("0.000")
        End If
    End Sub

    Private Sub ConvertMonths()
        TxtMonths.Text = Math.Round((leavesEarned / 12) * NudMonths.Value, 3).ToString("0.000")
    End Sub

    Friend Sub GetSettings()
        leavesEarned = My.Settings.LeavesEarnedInYear
        wHours = My.Settings.MaxHours
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Text += $" v{My.Application.Info.Version.Major}.{My.Application.Info.Version.Minor}.{My.Application.Info.Version.Build}"
        GetSettings()
        ' Set the default value for the NumericUpDown controls
        ConvertMonths()
        ConvertDays()
        ConvertHours()
        ConvertedMinutes()
        TopMost = ChkTopMost.Checked
    End Sub

    Private Sub ConvertHours()
        TxtHours.Text = Math.Round(60 / 480 * NudHours.Value, 3).ToString("0.000")
    End Sub

    Private Sub TxtMinutes_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Limit user input to numeric characters
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()
    End Sub

    Private Sub ChkTopMost_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTopMost.CheckedChanged
        TopMost = ChkTopMost.Checked
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        With FrmSettings
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub NudMonths_GotFocus(sender As Object, e As EventArgs) Handles NudMonths.GotFocus
        NudMonths.Select(0, NudMonths.Text.Length)
    End Sub

    Private Sub NudDays_GotFocus(sender As Object, e As EventArgs) Handles NudDays.GotFocus
        NudDays.Select(0, NudDays.Text.Length)
    End Sub

    Private Sub NudHours_GotFocus(sender As Object, e As EventArgs) Handles NudHours.GotFocus
        NudHours.Select(0, NudHours.Text.Length)
    End Sub

    Private Sub NudMinutes_GotFocus(sender As Object, e As EventArgs) Handles NudMinutes.GotFocus
        NudMinutes.Select(0, NudMinutes.Text.Length)
    End Sub

    Private Sub NudMinutes_TextChanged(sender As Object, e As EventArgs) Handles NudMinutes.TextChanged
        ConvertedMinutes()
    End Sub

    Private Sub NudHours_TextChanged(sender As Object, e As EventArgs) Handles NudHours.TextChanged
        ConvertHours()
    End Sub

    Private Sub NudMonths_TextChanged(sender As Object, e As EventArgs) Handles NudMonths.TextChanged
        ConvertMonths()
    End Sub

    Private Sub NudDays_TextChanged(sender As Object, e As EventArgs) Handles NudDays.TextChanged
        ConvertDays()
    End Sub

    Private Sub MnuAbout_Click(sender As Object, e As EventArgs) Handles MnuAbout.Click
        With FrmAbout
            .ShowDialog()
            .Dispose()
        End With
    End Sub
End Class
