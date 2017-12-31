<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSplash
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrExit = New System.Windows.Forms.Timer(Me.components)
        Me.picPenny = New System.Windows.Forms.PictureBox()
        Me.picQuarter = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picPenny, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQuarter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrExit
        '
        Me.tmrExit.Enabled = True
        Me.tmrExit.Interval = 3000
        '
        'picPenny
        '
        Me.picPenny.Image = Global.Kohl_Dusenbery_s_Coins.My.Resources.Resources.penny
        Me.picPenny.Location = New System.Drawing.Point(13, 333)
        Me.picPenny.Name = "picPenny"
        Me.picPenny.Size = New System.Drawing.Size(90, 76)
        Me.picPenny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPenny.TabIndex = 3
        Me.picPenny.TabStop = False
        '
        'picQuarter
        '
        Me.picQuarter.Image = Global.Kohl_Dusenbery_s_Coins.My.Resources.Resources.quarter1
        Me.picQuarter.Location = New System.Drawing.Point(497, 305)
        Me.picQuarter.Name = "picQuarter"
        Me.picQuarter.Size = New System.Drawing.Size(134, 104)
        Me.picQuarter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQuarter.TabIndex = 2
        Me.picQuarter.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.Image = Global.Kohl_Dusenbery_s_Coins.My.Resources.Resources.logo2
        Me.picLogo.Location = New System.Drawing.Point(134, 57)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(357, 268)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(643, 421)
        Me.ControlBox = False
        Me.Controls.Add(Me.picPenny)
        Me.Controls.Add(Me.picQuarter)
        Me.Controls.Add(Me.picLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplash"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dusenbery's Coins"
        CType(Me.picPenny, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQuarter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tmrExit As Timer
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents picQuarter As PictureBox
    Friend WithEvents picPenny As PictureBox
End Class
