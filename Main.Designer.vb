<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnViewCollection = New System.Windows.Forms.Button()
        Me.btnNewCoin = New System.Windows.Forms.Button()
        Me.lblChoice1 = New System.Windows.Forms.Label()
        Me.lblChoice2 = New System.Windows.Forms.Label()
        Me.lblChoice3 = New System.Windows.Forms.Label()
        Me.btnUtilities = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnViewCollection
        '
        Me.btnViewCollection.ForeColor = System.Drawing.Color.Black
        Me.btnViewCollection.Location = New System.Drawing.Point(146, 83)
        Me.btnViewCollection.Name = "btnViewCollection"
        Me.btnViewCollection.Size = New System.Drawing.Size(104, 23)
        Me.btnViewCollection.TabIndex = 1
        Me.btnViewCollection.Text = "View Collection"
        Me.btnViewCollection.UseVisualStyleBackColor = True
        '
        'btnNewCoin
        '
        Me.btnNewCoin.ForeColor = System.Drawing.Color.Black
        Me.btnNewCoin.Location = New System.Drawing.Point(426, 367)
        Me.btnNewCoin.Name = "btnNewCoin"
        Me.btnNewCoin.Size = New System.Drawing.Size(104, 23)
        Me.btnNewCoin.TabIndex = 3
        Me.btnNewCoin.Text = "New Coin"
        Me.btnNewCoin.UseVisualStyleBackColor = True
        '
        'lblChoice1
        '
        Me.lblChoice1.AutoSize = True
        Me.lblChoice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoice1.Location = New System.Drawing.Point(12, 30)
        Me.lblChoice1.Name = "lblChoice1"
        Me.lblChoice1.Size = New System.Drawing.Size(381, 25)
        Me.lblChoice1.TabIndex = 2
        Me.lblChoice1.Text = "Would you like to view coin collection?"
        '
        'lblChoice2
        '
        Me.lblChoice2.AutoSize = True
        Me.lblChoice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoice2.Location = New System.Drawing.Point(326, 313)
        Me.lblChoice2.Name = "lblChoice2"
        Me.lblChoice2.Size = New System.Drawing.Size(295, 25)
        Me.lblChoice2.TabIndex = 3
        Me.lblChoice2.Text = "Would you like to add a coin?"
        '
        'lblChoice3
        '
        Me.lblChoice3.AutoSize = True
        Me.lblChoice3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoice3.Location = New System.Drawing.Point(172, 160)
        Me.lblChoice3.Name = "lblChoice3"
        Me.lblChoice3.Size = New System.Drawing.Size(331, 25)
        Me.lblChoice3.TabIndex = 4
        Me.lblChoice3.Text = "Find the weight of your coin here!"
        '
        'btnUtilities
        '
        Me.btnUtilities.ForeColor = System.Drawing.Color.Black
        Me.btnUtilities.Location = New System.Drawing.Point(289, 219)
        Me.btnUtilities.Name = "btnUtilities"
        Me.btnUtilities.Size = New System.Drawing.Size(104, 23)
        Me.btnUtilities.TabIndex = 2
        Me.btnUtilities.Text = "Utilities"
        Me.btnUtilities.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(643, 421)
        Me.Controls.Add(Me.btnUtilities)
        Me.Controls.Add(Me.lblChoice3)
        Me.Controls.Add(Me.lblChoice2)
        Me.Controls.Add(Me.lblChoice1)
        Me.Controls.Add(Me.btnNewCoin)
        Me.Controls.Add(Me.btnViewCollection)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dusenbery's Coins"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnViewCollection As Button
    Friend WithEvents btnNewCoin As Button
    Friend WithEvents lblChoice1 As Label
    Friend WithEvents lblChoice2 As Label
    Friend WithEvents lblChoice3 As Label
    Friend WithEvents btnUtilities As Button
End Class
