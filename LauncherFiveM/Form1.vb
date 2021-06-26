Public Class Launcher
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Shell("Explorer.exe fivem://connect/127.0.0.1:30120")
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("Explorer.exe ts3server://ts.XXXXXXXXX.com")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("Explorer.exe https://github.com/Shazuub/LauncherFiveM")
    End Sub
End Class
