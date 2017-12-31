Public Class frmMain

    Private Sub btnNewCoin_Click(sender As Object, e As EventArgs) Handles btnNewCoin.Click
        Me.Hide()
        Dim frmMain As New frmNewCoin
        frmMain.Show()

        'When the New Coin button is clicked, the user is directed to the New Coin form

    End Sub

    Private Sub btnUtilities_Click(sender As Object, e As EventArgs) Handles btnUtilities.Click
        Me.Hide()
        Dim frmMain As New frmUtilities
        frmMain.Show()

        'When the Utilities button is clicked, the user is directed to the Utilities form

    End Sub

    Private Sub btnViewCollection_Click(sender As Object, e As EventArgs) Handles btnViewCollection.Click
        Me.Hide()
        Dim frmMain As New frmViewCol
        frmMain.Show()

        'When the View Collection button is clicked, the user is directed to the View Collection form

    End Sub

End Class