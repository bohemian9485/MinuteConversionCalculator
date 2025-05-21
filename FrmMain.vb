Public Class FrmMain
    Private conversionWrapper As New FractionsOfADay.ClsConversion

    Private Const MAX_MINUTES As Integer = 3840
    Private Const WORK_MINUTES As Integer = 480
    Private Const MINUTES_IN_HOUR As Integer = 60

    Private Sub CalculateCreditsEarned()
        Dim creditsEarned As Decimal = 0
        Dim daysCredited As Integer = NudDays.Value
        Dim daysInMonth As Integer = 30
        TxtEarned.Text = Math.Round(1.25 / daysInMonth * daysCredited, 3).ToString("0.000")
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Text += $" v{My.Application.Info.Version.Major}.{My.Application.Info.Version.Minor}.{My.Application.Info.Version.Build}"
        conversionWrapper.GetClassSettings()
        CalculateCreditsEarned()
        TopMost = ChkTopMost.Checked
    End Sub

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        conversionWrapper = Nothing
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

    Private Sub TxtMinutes_TextChanged(sender As Object, e As EventArgs) Handles TxtMinutes.TextChanged
        Dim fractionsOfADay As Decimal
        If TxtMinutes.Text <> vbNullString Then
            Dim minutesEntered As Integer = CInt(TxtMinutes.Text)
            If minutesEntered <= MAX_MINUTES Then
                ' Checks if minutes entered is greater than one hour
                Dim convertedToHours As Integer = Int(minutesEntered / WORK_MINUTES)
                If convertedToHours > 1 Then
                    Dim sixtyMinuteFraction As Decimal = conversionWrapper.FractionsOfADay(MINUTES_IN_HOUR)
                    fractionsOfADay = sixtyMinuteFraction * convertedToHours
                    Dim remainder As Integer = minutesEntered Mod WORK_MINUTES
                    fractionsOfADay += conversionWrapper.FractionsOfADay(remainder)
                Else
                    fractionsOfADay = conversionWrapper.FractionsOfADay(minutesEntered)
                End If
                TxtFractions.Text = Format(fractionsOfADay, "0.000")
            Else
                TxtFractions.Text = vbNullString
                TxtMinutes.Focus()
                Dim unUsed = MessageBox.Show("Minutes entered is greater than eight (8) hours (3,840 minutes).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            TxtFractions.Text = vbNullString
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()
    End Sub

    Private Sub ChkTopMost_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTopMost.CheckedChanged
        TopMost = ChkTopMost.Checked
    End Sub

    Private Sub NudDays_ValueChanged(sender As Object, e As EventArgs) Handles NudDays.ValueChanged
        CalculateCreditsEarned()
    End Sub
End Class
