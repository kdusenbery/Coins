Public Class frmSplash


    Private Sub tmrExit_Tick(sender As Object, e As EventArgs) Handles tmrExit.Tick
        Me.Hide()
        Dim frmSplash As New frmMain
        frmSplash.Show()
        tmrExit.Stop()

        'Timer for the splash screen to disappear and display the main form

    End Sub

End Class
