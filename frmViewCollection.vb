Public Class frmViewCol

    Private Access As New DBcontrol

    Private Sub frmViewCol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()

    End Sub

    Public Sub RefreshGrid()
        'Run query
        Access.ExecQuery("Select "" From Coins")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        'Fill datagrid
        dgvData.DataSource = Access.DBDT

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
        Dim frmViewCollection As New frmMain
        frmNewCoin.Show()

        'Clicking the return button returns the user back to the main form

    End Sub

    Private Sub FilterCoins(CollectorsValue As Integer)
        'Add parameters and run query
        Access.AddParam("@ColValue", "%" & CollectorsValue & "%")
        Access.ExecQuery("Select name, weight, face value, collector's value, currency, year, metal, preservation " &
                         "From Dusenbery's Coins " &
                         "Where Collector's Value LIKE @ColValue")

    End Sub

    Private Sub cmdFilter_Click(sender As Object, e As EventArgs) Handles cmdFilter.Click
        FilterCoins(txtFind.Text)

    End Sub

End Class