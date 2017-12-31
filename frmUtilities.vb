Option Explicit On
Option Infer Off
Option Strict On

Public Class frmUtilities

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
        Dim frmUtilities As New frmMain
        frmUtilities.Show()

        'Clicking the return button returns the user back to the main form

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim decTroyWeight As Decimal = CDec(0.0321507)
        Dim decGramsWeight As Decimal = CDec(31.1035)
        Dim decTroy As Decimal
        Dim decGrams As Decimal
        Dim decAns1 As Decimal
        Dim decAns2 As Decimal

        decTroy = CDec(Convert.ToDecimal(Val(txtTroy.Text)))
        decGrams = CDec(Convert.ToDecimal(Val(txtGrams.Text)))

        'Allows textGrams/Troy to be entered as a decimal value

        decAns1 = CDec(decTroy * decGramsWeight)
        decAns2 = CDec(decGrams * decTroyWeight)

        'decAns1 is the product of decTroy multiplied by decGramsWeight
        'decAns2 is the product of decGrams multiplied by decTroyWeight

        lblTc.Text = CType(FormatNumber(Val(decAns2), 2), String) & " Troy Ounces"
        lblGc.Text = CType(FormatNumber(Val(decAns1), 2), String) & " Grams"

        'lblTc text box displays decAns2 as Troy Ounces to two decimal places
        'lblGc text box displays decAns1 as Grams to two decimal places

    End Sub

    Private Sub btnCalcVal1_Click(sender As Object, e As EventArgs) Handles btnCalcVal1.Click
        MessageBox.Show("Value of Gold" &
                        vbCrLf + "" &
                        vbCrLf + "0.10 troy ounces of gold = $131.03" &
                        vbCrLf + "0.25 troy ounces of gold = $327.58" &
                        vbCrLf + "0.50 troy ounces of gold = $655.15" &
                        vbCrLf + "1 troy ounce of gold = $1,310.30" &
                        vbCrLf + "5 troy ounces of gold = $6,551.50" &
                        vbCrLf + "10 troy ounces of gold = $13,103.00")

        'When the btnClacVal1 button is clicked a message box shows the user the current value of gold at specific weights

    End Sub

    Private Sub btnClacVal2_Click(sender As Object, e As EventArgs) Handles btnClacVal2.Click
        MessageBox.Show("Value of Silver" &
                        vbCrLf + "" &
                        vbCrLf + "0.10 troy ounces of silver = $1.73" &
                        vbCrLf + "0.25 troy ounces of silver = $4.32" &
                        vbCrLf + "0.50 troy ounces of silver = $8.65" &
                        vbCrLf + "1 troy ounce of silver = $17.29" &
                        vbCrLf + "5 troy ounces of silver = $86.45" &
                        vbCrLf + "10 troy ounces of silver = $172.90")

        'When the btnClacVal1 button is clicked a message box shows the user the current value of silver at specific weights

    End Sub

    Private Sub btnClacVal3_Click(sender As Object, e As EventArgs) Handles btnClacVal3.Click
        MessageBox.Show("Value of Platinum" &
                        vbCrLf + "" &
                        vbCrLf + "0.10 troy ounces of platinum = $96.47" &
                        vbCrLf + "0.25 troy ounces of platinum = $241.18" &
                        vbCrLf + "0.50 troy ounces of platinum = $482.35" &
                        vbCrLf + "1 troy ounce of platinum = $964.70" &
                        vbCrLf + "5 troy ounces of platinum = $4823.50" &
                        vbCrLf + "10 troy ounces of platinum = $9647.00")

        'When the btnClacVal1 button is clicked a message box shows the user the current value of platinum at specific weights

    End Sub

    Private Sub txtGrams_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGrams.KeyPress, txtTroy.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True

        End If

        'Limts the user from entering anything other then digets 0-9, a period, and a comma in the txtGrams and txtTroy text boxs as their data input

    End Sub

End Class