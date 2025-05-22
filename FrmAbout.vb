Public Class FrmAbout
    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = $"{My.Application.Info.Version.Major}.{My.Application.Info.Version.Minor}.{My.Application.Info.Version.Build}"
        Left = FrmMain.Left + Int((FrmMain.Width - Width) / 2)
        Top = FrmMain.Top - Int((Height - FrmMain.Height) / 2)
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Close()
    End Sub

    Private Sub FrmAbout_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then
            Close()
            Return
        End If
    End Sub
End Class