<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewCoin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtCoinWeight = New System.Windows.Forms.TextBox()
        Me.txtCoinName = New System.Windows.Forms.TextBox()
        Me.lblCoinName = New System.Windows.Forms.Label()
        Me.lblCoinWeight = New System.Windows.Forms.Label()
        Me.lblNewCoin = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.conCoinMetal = New System.Windows.Forms.GroupBox()
        Me.radOther = New System.Windows.Forms.RadioButton()
        Me.radSilver = New System.Windows.Forms.RadioButton()
        Me.radPalladium = New System.Windows.Forms.RadioButton()
        Me.radZinc = New System.Windows.Forms.RadioButton()
        Me.radPlatinum = New System.Windows.Forms.RadioButton()
        Me.radGold = New System.Windows.Forms.RadioButton()
        Me.radCopper = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.conCoinEnc = New System.Windows.Forms.GroupBox()
        Me.chkNotEnc = New System.Windows.Forms.CheckBox()
        Me.chkEnc = New System.Windows.Forms.CheckBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblFaceValue = New System.Windows.Forms.Label()
        Me.txtFaceValue = New System.Windows.Forms.TextBox()
        Me.lblColValue = New System.Windows.Forms.Label()
        Me.txtColValue = New System.Windows.Forms.TextBox()
        Me.lblCoinCurrency = New System.Windows.Forms.Label()
        Me.cboCurrency = New System.Windows.Forms.ComboBox()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.conCoinMetal.SuspendLayout()
        Me.conCoinEnc.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(224, 533)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 18
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtCoinWeight
        '
        Me.txtCoinWeight.Location = New System.Drawing.Point(344, 133)
        Me.txtCoinWeight.Name = "txtCoinWeight"
        Me.txtCoinWeight.Size = New System.Drawing.Size(234, 20)
        Me.txtCoinWeight.TabIndex = 2
        '
        'txtCoinName
        '
        Me.txtCoinName.Location = New System.Drawing.Point(344, 85)
        Me.txtCoinName.Name = "txtCoinName"
        Me.txtCoinName.Size = New System.Drawing.Size(234, 20)
        Me.txtCoinName.TabIndex = 1
        '
        'lblCoinName
        '
        Me.lblCoinName.AutoSize = True
        Me.lblCoinName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoinName.ForeColor = System.Drawing.Color.Red
        Me.lblCoinName.Location = New System.Drawing.Point(56, 79)
        Me.lblCoinName.Name = "lblCoinName"
        Me.lblCoinName.Size = New System.Drawing.Size(139, 25)
        Me.lblCoinName.TabIndex = 5
        Me.lblCoinName.Text = "Coin's &Name:"
        '
        'lblCoinWeight
        '
        Me.lblCoinWeight.AutoSize = True
        Me.lblCoinWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoinWeight.ForeColor = System.Drawing.Color.Red
        Me.lblCoinWeight.Location = New System.Drawing.Point(56, 127)
        Me.lblCoinWeight.Name = "lblCoinWeight"
        Me.lblCoinWeight.Size = New System.Drawing.Size(242, 25)
        Me.lblCoinWeight.TabIndex = 6
        Me.lblCoinWeight.Text = "Coin's &Weight (Troy oz):"
        '
        'lblNewCoin
        '
        Me.lblNewCoin.AutoSize = True
        Me.lblNewCoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewCoin.ForeColor = System.Drawing.Color.Red
        Me.lblNewCoin.Location = New System.Drawing.Point(255, 21)
        Me.lblNewCoin.Name = "lblNewCoin"
        Me.lblNewCoin.Size = New System.Drawing.Size(132, 31)
        Me.lblNewCoin.TabIndex = 7
        Me.lblNewCoin.Text = "New Coin"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(344, 533)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 19
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'conCoinMetal
        '
        Me.conCoinMetal.Controls.Add(Me.radOther)
        Me.conCoinMetal.Controls.Add(Me.radSilver)
        Me.conCoinMetal.Controls.Add(Me.radPalladium)
        Me.conCoinMetal.Controls.Add(Me.radZinc)
        Me.conCoinMetal.Controls.Add(Me.radPlatinum)
        Me.conCoinMetal.Controls.Add(Me.radGold)
        Me.conCoinMetal.Controls.Add(Me.radCopper)
        Me.conCoinMetal.Controls.Add(Me.GroupBox1)
        Me.conCoinMetal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conCoinMetal.ForeColor = System.Drawing.Color.Red
        Me.conCoinMetal.Location = New System.Drawing.Point(61, 403)
        Me.conCoinMetal.Name = "conCoinMetal"
        Me.conCoinMetal.Size = New System.Drawing.Size(253, 100)
        Me.conCoinMetal.TabIndex = 7
        Me.conCoinMetal.TabStop = False
        Me.conCoinMetal.Text = "Coin's &Metal"
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.Location = New System.Drawing.Point(180, 20)
        Me.radOther.Name = "radOther"
        Me.radOther.Size = New System.Drawing.Size(63, 22)
        Me.radOther.TabIndex = 14
        Me.radOther.TabStop = True
        Me.radOther.Text = "Other"
        Me.radOther.UseVisualStyleBackColor = True
        '
        'radSilver
        '
        Me.radSilver.AutoSize = True
        Me.radSilver.Location = New System.Drawing.Point(92, 20)
        Me.radSilver.Name = "radSilver"
        Me.radSilver.Size = New System.Drawing.Size(62, 22)
        Me.radSilver.TabIndex = 11
        Me.radSilver.TabStop = True
        Me.radSilver.Text = "Silver"
        Me.radSilver.UseVisualStyleBackColor = True
        '
        'radPalladium
        '
        Me.radPalladium.AutoSize = True
        Me.radPalladium.Location = New System.Drawing.Point(92, 66)
        Me.radPalladium.Name = "radPalladium"
        Me.radPalladium.Size = New System.Drawing.Size(90, 22)
        Me.radPalladium.TabIndex = 13
        Me.radPalladium.TabStop = True
        Me.radPalladium.Text = "Palladium"
        Me.radPalladium.UseVisualStyleBackColor = True
        '
        'radZinc
        '
        Me.radZinc.AutoSize = True
        Me.radZinc.Location = New System.Drawing.Point(17, 43)
        Me.radZinc.Name = "radZinc"
        Me.radZinc.Size = New System.Drawing.Size(54, 22)
        Me.radZinc.TabIndex = 9
        Me.radZinc.TabStop = True
        Me.radZinc.Text = "Zinc"
        Me.radZinc.UseVisualStyleBackColor = True
        '
        'radPlatinum
        '
        Me.radPlatinum.AutoSize = True
        Me.radPlatinum.Location = New System.Drawing.Point(92, 43)
        Me.radPlatinum.Name = "radPlatinum"
        Me.radPlatinum.Size = New System.Drawing.Size(83, 22)
        Me.radPlatinum.TabIndex = 12
        Me.radPlatinum.TabStop = True
        Me.radPlatinum.Text = "Platinum"
        Me.radPlatinum.UseVisualStyleBackColor = True
        '
        'radGold
        '
        Me.radGold.AutoSize = True
        Me.radGold.Location = New System.Drawing.Point(17, 66)
        Me.radGold.Name = "radGold"
        Me.radGold.Size = New System.Drawing.Size(58, 22)
        Me.radGold.TabIndex = 10
        Me.radGold.TabStop = True
        Me.radGold.Text = "Gold"
        Me.radGold.UseVisualStyleBackColor = True
        '
        'radCopper
        '
        Me.radCopper.AutoSize = True
        Me.radCopper.Location = New System.Drawing.Point(17, 20)
        Me.radCopper.Name = "radCopper"
        Me.radCopper.Size = New System.Drawing.Size(75, 22)
        Me.radCopper.TabIndex = 8
        Me.radCopper.Text = "Copper"
        Me.radCopper.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(251, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 100)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Coin's Metal"
        '
        'conCoinEnc
        '
        Me.conCoinEnc.Controls.Add(Me.chkNotEnc)
        Me.conCoinEnc.Controls.Add(Me.chkEnc)
        Me.conCoinEnc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conCoinEnc.ForeColor = System.Drawing.Color.Red
        Me.conCoinEnc.Location = New System.Drawing.Point(378, 403)
        Me.conCoinEnc.Name = "conCoinEnc"
        Me.conCoinEnc.Size = New System.Drawing.Size(200, 100)
        Me.conCoinEnc.TabIndex = 15
        Me.conCoinEnc.TabStop = False
        Me.conCoinEnc.Text = "Coin &Preservation"
        '
        'chkNotEnc
        '
        Me.chkNotEnc.AutoSize = True
        Me.chkNotEnc.Location = New System.Drawing.Point(14, 67)
        Me.chkNotEnc.Name = "chkNotEnc"
        Me.chkNotEnc.Size = New System.Drawing.Size(147, 22)
        Me.chkNotEnc.TabIndex = 17
        Me.chkNotEnc.Text = "Not Encapslulated"
        Me.chkNotEnc.UseVisualStyleBackColor = True
        '
        'chkEnc
        '
        Me.chkEnc.AutoSize = True
        Me.chkEnc.Location = New System.Drawing.Point(14, 21)
        Me.chkEnc.Name = "chkEnc"
        Me.chkEnc.Size = New System.Drawing.Size(116, 22)
        Me.chkEnc.TabIndex = 16
        Me.chkEnc.Text = "Encapsulated"
        Me.chkEnc.UseVisualStyleBackColor = True
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.ForeColor = System.Drawing.Color.Red
        Me.lblYear.Location = New System.Drawing.Point(56, 363)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(129, 25)
        Me.lblYear.TabIndex = 11
        Me.lblYear.Text = "Coin's &Year:"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(344, 369)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(234, 20)
        Me.txtYear.TabIndex = 6
        '
        'lblFaceValue
        '
        Me.lblFaceValue.AutoSize = True
        Me.lblFaceValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaceValue.ForeColor = System.Drawing.Color.Red
        Me.lblFaceValue.Location = New System.Drawing.Point(56, 177)
        Me.lblFaceValue.Name = "lblFaceValue"
        Me.lblFaceValue.Size = New System.Drawing.Size(192, 25)
        Me.lblFaceValue.TabIndex = 13
        Me.lblFaceValue.Text = "Coin's &Face Value:"
        '
        'txtFaceValue
        '
        Me.txtFaceValue.Location = New System.Drawing.Point(344, 183)
        Me.txtFaceValue.Name = "txtFaceValue"
        Me.txtFaceValue.Size = New System.Drawing.Size(234, 20)
        Me.txtFaceValue.TabIndex = 3
        '
        'lblColValue
        '
        Me.lblColValue.AutoSize = True
        Me.lblColValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColValue.ForeColor = System.Drawing.Color.Red
        Me.lblColValue.Location = New System.Drawing.Point(56, 225)
        Me.lblColValue.Name = "lblColValue"
        Me.lblColValue.Size = New System.Drawing.Size(243, 25)
        Me.lblColValue.TabIndex = 15
        Me.lblColValue.Text = "Collector's &Value (USD):"
        '
        'txtColValue
        '
        Me.txtColValue.Location = New System.Drawing.Point(344, 231)
        Me.txtColValue.Name = "txtColValue"
        Me.txtColValue.Size = New System.Drawing.Size(234, 20)
        Me.txtColValue.TabIndex = 4
        '
        'lblCoinCurrency
        '
        Me.lblCoinCurrency.AutoSize = True
        Me.lblCoinCurrency.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoinCurrency.ForeColor = System.Drawing.Color.Red
        Me.lblCoinCurrency.Location = New System.Drawing.Point(56, 313)
        Me.lblCoinCurrency.Name = "lblCoinCurrency"
        Me.lblCoinCurrency.Size = New System.Drawing.Size(170, 25)
        Me.lblCoinCurrency.TabIndex = 17
        Me.lblCoinCurrency.Text = "Coin's &Currency:"
        '
        'cboCurrency
        '
        Me.cboCurrency.FormattingEnabled = True
        Me.cboCurrency.Items.AddRange(New Object() {"USD", "GBP", "EUR"})
        Me.cboCurrency.Location = New System.Drawing.Point(344, 319)
        Me.cboCurrency.Name = "cboCurrency"
        Me.cboCurrency.Size = New System.Drawing.Size(234, 21)
        Me.cboCurrency.TabIndex = 5
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.ForeColor = System.Drawing.Color.Red
        Me.lblValue.Location = New System.Drawing.Point(341, 271)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(0, 18)
        Me.lblValue.TabIndex = 20
        '
        'frmNewCoin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(643, 579)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.cboCurrency)
        Me.Controls.Add(Me.lblCoinCurrency)
        Me.Controls.Add(Me.txtColValue)
        Me.Controls.Add(Me.lblColValue)
        Me.Controls.Add(Me.txtFaceValue)
        Me.Controls.Add(Me.lblFaceValue)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.conCoinEnc)
        Me.Controls.Add(Me.conCoinMetal)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lblNewCoin)
        Me.Controls.Add(Me.lblCoinWeight)
        Me.Controls.Add(Me.lblCoinName)
        Me.Controls.Add(Me.txtCoinName)
        Me.Controls.Add(Me.txtCoinWeight)
        Me.Controls.Add(Me.btnSubmit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmNewCoin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Coin"
        Me.conCoinMetal.ResumeLayout(False)
        Me.conCoinMetal.PerformLayout()
        Me.conCoinEnc.ResumeLayout(False)
        Me.conCoinEnc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtCoinWeight As TextBox
    Friend WithEvents txtCoinName As TextBox
    Friend WithEvents lblCoinName As Label
    Friend WithEvents lblCoinWeight As Label
    Friend WithEvents lblNewCoin As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents conCoinMetal As GroupBox
    Friend WithEvents radOther As RadioButton
    Friend WithEvents radSilver As RadioButton
    Friend WithEvents radPalladium As RadioButton
    Friend WithEvents radZinc As RadioButton
    Friend WithEvents radPlatinum As RadioButton
    Friend WithEvents radGold As RadioButton
    Friend WithEvents radCopper As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents conCoinEnc As GroupBox
    Friend WithEvents chkNotEnc As CheckBox
    Friend WithEvents chkEnc As CheckBox
    Friend WithEvents lblYear As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents lblFaceValue As Label
    Friend WithEvents txtFaceValue As TextBox
    Friend WithEvents lblColValue As Label
    Friend WithEvents txtColValue As TextBox
    Friend WithEvents lblCoinCurrency As Label
    Friend WithEvents cboCurrency As ComboBox
    Friend WithEvents lblValue As Label
End Class
