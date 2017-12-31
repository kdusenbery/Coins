<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilities
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCalculator = New System.Windows.Forms.Label()
        Me.lblGrams = New System.Windows.Forms.Label()
        Me.lblTroy = New System.Windows.Forms.Label()
        Me.txtGrams = New System.Windows.Forms.TextBox()
        Me.txtTroy = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblTc = New System.Windows.Forms.Label()
        Me.lblGc = New System.Windows.Forms.Label()
        Me.lblGold = New System.Windows.Forms.Label()
        Me.lblSilver = New System.Windows.Forms.Label()
        Me.lblPlatinum = New System.Windows.Forms.Label()
        Me.btnCalcVal1 = New System.Windows.Forms.Button()
        Me.btnClacVal2 = New System.Windows.Forms.Button()
        Me.btnClacVal3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCalculator
        '
        Me.lblCalculator.AutoSize = True
        Me.lblCalculator.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculator.ForeColor = System.Drawing.Color.Red
        Me.lblCalculator.Location = New System.Drawing.Point(207, 44)
        Me.lblCalculator.Name = "lblCalculator"
        Me.lblCalculator.Size = New System.Drawing.Size(228, 31)
        Me.lblCalculator.TabIndex = 0
        Me.lblCalculator.Text = "Weight Calculator"
        '
        'lblGrams
        '
        Me.lblGrams.AutoSize = True
        Me.lblGrams.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrams.ForeColor = System.Drawing.Color.Red
        Me.lblGrams.Location = New System.Drawing.Point(127, 207)
        Me.lblGrams.Name = "lblGrams"
        Me.lblGrams.Size = New System.Drawing.Size(75, 25)
        Me.lblGrams.TabIndex = 1
        Me.lblGrams.Text = "Grams"
        '
        'lblTroy
        '
        Me.lblTroy.AutoSize = True
        Me.lblTroy.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTroy.ForeColor = System.Drawing.Color.Red
        Me.lblTroy.Location = New System.Drawing.Point(407, 207)
        Me.lblTroy.Name = "lblTroy"
        Me.lblTroy.Size = New System.Drawing.Size(135, 25)
        Me.lblTroy.TabIndex = 2
        Me.lblTroy.Text = "Troy Ounces"
        '
        'txtGrams
        '
        Me.txtGrams.Location = New System.Drawing.Point(78, 254)
        Me.txtGrams.Name = "txtGrams"
        Me.txtGrams.Size = New System.Drawing.Size(172, 20)
        Me.txtGrams.TabIndex = 4
        '
        'txtTroy
        '
        Me.txtTroy.Location = New System.Drawing.Point(389, 254)
        Me.txtTroy.Name = "txtTroy"
        Me.txtTroy.Size = New System.Drawing.Size(172, 20)
        Me.txtTroy.TabIndex = 5
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(219, 364)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 6
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(348, 364)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 7
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'lblTc
        '
        Me.lblTc.AutoSize = True
        Me.lblTc.BackColor = System.Drawing.Color.Black
        Me.lblTc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTc.ForeColor = System.Drawing.Color.Red
        Me.lblTc.Location = New System.Drawing.Point(82, 307)
        Me.lblTc.Name = "lblTc"
        Me.lblTc.Size = New System.Drawing.Size(168, 18)
        Me.lblTc.TabIndex = 10
        Me.lblTc.Text = "                                        "
        Me.lblTc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGc
        '
        Me.lblGc.AutoSize = True
        Me.lblGc.BackColor = System.Drawing.Color.Black
        Me.lblGc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGc.ForeColor = System.Drawing.Color.Red
        Me.lblGc.Location = New System.Drawing.Point(386, 307)
        Me.lblGc.Name = "lblGc"
        Me.lblGc.Size = New System.Drawing.Size(168, 18)
        Me.lblGc.TabIndex = 11
        Me.lblGc.Text = "                                        "
        Me.lblGc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGold
        '
        Me.lblGold.AutoSize = True
        Me.lblGold.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGold.ForeColor = System.Drawing.Color.Red
        Me.lblGold.Location = New System.Drawing.Point(127, 114)
        Me.lblGold.Name = "lblGold"
        Me.lblGold.Size = New System.Drawing.Size(57, 25)
        Me.lblGold.TabIndex = 13
        Me.lblGold.Text = "Gold"
        '
        'lblSilver
        '
        Me.lblSilver.AutoSize = True
        Me.lblSilver.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilver.ForeColor = System.Drawing.Color.Red
        Me.lblSilver.Location = New System.Drawing.Point(288, 114)
        Me.lblSilver.Name = "lblSilver"
        Me.lblSilver.Size = New System.Drawing.Size(66, 25)
        Me.lblSilver.TabIndex = 14
        Me.lblSilver.Text = "Silver"
        '
        'lblPlatinum
        '
        Me.lblPlatinum.AutoSize = True
        Me.lblPlatinum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatinum.ForeColor = System.Drawing.Color.Red
        Me.lblPlatinum.Location = New System.Drawing.Point(452, 114)
        Me.lblPlatinum.Name = "lblPlatinum"
        Me.lblPlatinum.Size = New System.Drawing.Size(95, 25)
        Me.lblPlatinum.TabIndex = 15
        Me.lblPlatinum.Text = "Platinum"
        '
        'btnCalcVal1
        '
        Me.btnCalcVal1.Location = New System.Drawing.Point(95, 152)
        Me.btnCalcVal1.Name = "btnCalcVal1"
        Me.btnCalcVal1.Size = New System.Drawing.Size(125, 23)
        Me.btnCalcVal1.TabIndex = 1
        Me.btnCalcVal1.Text = "Calculate Value"
        Me.btnCalcVal1.UseVisualStyleBackColor = True
        '
        'btnClacVal2
        '
        Me.btnClacVal2.Location = New System.Drawing.Point(260, 152)
        Me.btnClacVal2.Name = "btnClacVal2"
        Me.btnClacVal2.Size = New System.Drawing.Size(125, 23)
        Me.btnClacVal2.TabIndex = 2
        Me.btnClacVal2.Text = "Calculate Value"
        Me.btnClacVal2.UseVisualStyleBackColor = True
        '
        'btnClacVal3
        '
        Me.btnClacVal3.Location = New System.Drawing.Point(436, 152)
        Me.btnClacVal3.Name = "btnClacVal3"
        Me.btnClacVal3.Size = New System.Drawing.Size(125, 23)
        Me.btnClacVal3.TabIndex = 3
        Me.btnClacVal3.Text = "Calculate Value"
        Me.btnClacVal3.UseVisualStyleBackColor = True
        '
        'frmUtilities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(643, 421)
        Me.Controls.Add(Me.btnClacVal3)
        Me.Controls.Add(Me.btnClacVal2)
        Me.Controls.Add(Me.btnCalcVal1)
        Me.Controls.Add(Me.lblPlatinum)
        Me.Controls.Add(Me.lblSilver)
        Me.Controls.Add(Me.lblGold)
        Me.Controls.Add(Me.lblGc)
        Me.Controls.Add(Me.lblTc)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtTroy)
        Me.Controls.Add(Me.txtGrams)
        Me.Controls.Add(Me.lblTroy)
        Me.Controls.Add(Me.lblGrams)
        Me.Controls.Add(Me.lblCalculator)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmUtilities"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Utilities"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCalculator As Label
    Friend WithEvents lblGrams As Label
    Friend WithEvents lblTroy As Label
    Friend WithEvents txtGrams As TextBox
    Friend WithEvents txtTroy As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblTc As Label
    Friend WithEvents lblGc As Label
    Friend WithEvents lblGold As Label
    Friend WithEvents lblSilver As Label
    Friend WithEvents lblPlatinum As Label
    Friend WithEvents btnCalcVal1 As Button
    Friend WithEvents btnClacVal2 As Button
    Friend WithEvents btnClacVal3 As Button
End Class
