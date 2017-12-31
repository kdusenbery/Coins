Public Class frmNewCoin

    Private Access As New DBcontrol

    Private Sub AddCoin()
        'Add parameters
        Access.AddParam("@name", txtCoinName.Text)
        Access.AddParam("@weight", txtCoinWeight.Text)
        Access.AddParam("@faceval", txtFaceValue.Text)
        Access.AddParam("@colvalue", txtColValue.Text)
        Access.AddParam("@currency", cboCurrency.Text)
        Access.AddParam("@year", txtYear.Text)
        Access.AddParam("@metal", conCoinMetal.Text)
        Access.AddParam("@preservation", chkEnc.Checked)

        'Execute insert command
        Access.ExecQuery("Insert into members (name, weight, face value, collector's value, currency, year, metal, preservation) " &
                         "Values (@name, @weight, @faceval, @colvalue, @currency, @year, @metal, @preservation); ")

        'Report and abort on errors
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        'Success
        MsgBox("Coin was added successfully!")

        frmViewCol.RefreshGrid()

        Me.Close()

    End Sub

    Private valArray(,) As String = {{"$0 - $10", " - Cheap"},
                                 {"$10.01 - $50", " - Average"},
                                 {"$50.01 - $100", " - Above Average"},
                                 {"$100.01 - $500", " - Valuable"},
                                 {"$500.01 - $5000", " - Very Valuable"},
                                 {"$5000.01 and up", " - Extremely Valuable"}}

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim Coin As Class1

        Dim dblName As Double
        Dim dblWeight As Double
        Dim dblFaceValue As Double
        Dim dblValue As Double
        Dim dblYear As Double

        Double.TryParse(txtCoinName.Text.ToString, dblName)
        Double.TryParse(txtCoinWeight.Text.ToString, dblWeight)
        Double.TryParse(txtFaceValue.Text.ToString, dblFaceValue)
        Double.TryParse(txtColValue.Text.ToString, dblValue)
        Double.TryParse(txtYear.Text.ToString, dblYear)

        Coin = New Class1

        MessageBox.Show("You entered a " & txtCoinName.Text & " weighing " & txtCoinWeight.Text & " troy ounces.")

        'When the submit button is clicked, a message box appears telling the user the information that was entered

        AddCoin()

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
        Dim frmNewCoin As New frmMain
        frmNewCoin.Show()

        'Clicking the return button returns the user back to the main form

    End Sub

    Private Sub txtColValue_TextChanged(sender As Object, e As EventArgs) Handles txtColValue.TextChanged
        Dim outFile As IO.StreamWriter

        outFile = IO.File.AppendText("collectorsValue.txt")

        outFile.WriteLine(txtColValue.Text)

        outFile.Close()

        If txtColValue.Text <= 10 Then
            lblValue.Text = valArray(0, 0) + valArray(0, 1)

        End If

        If txtColValue.Text >= 10.01 And txtColValue.Text <= 50 Then
            lblValue.Text = valArray(1, 0) + valArray(1, 1)

        End If

        If txtColValue.Text >= 50.01 And txtColValue.Text <= 100 Then
            lblValue.Text = valArray(2, 0) + valArray(2, 1)

        End If

        If txtColValue.Text >= 100.01 And txtColValue.Text <= 500 Then
            lblValue.Text = valArray(3, 0) + valArray(3, 1)

        End If

        If txtColValue.Text >= 500.01 And txtColValue.Text <= 5000 Then
            lblValue.Text = valArray(4, 0) + valArray(4, 1)

        End If

        If txtColValue.Text >= 5000.01 Then
            lblValue.Text = valArray(5, 0) + valArray(5, 1)

        End If

    End Sub

End Class