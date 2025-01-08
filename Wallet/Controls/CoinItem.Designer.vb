<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CoinItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.RightLabel = New System.Windows.Forms.Label()
        Me.LeftLabel = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.HashLabel = New System.Windows.Forms.LinkLabel()
        Me.PBExternal = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.PBExternal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RightLabel
        '
        Me.RightLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RightLabel.AutoEllipsis = True
        Me.RightLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.RightLabel.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.RightLabel.Location = New System.Drawing.Point(437, 8)
        Me.RightLabel.Name = "RightLabel"
        Me.RightLabel.Size = New System.Drawing.Size(175, 25)
        Me.RightLabel.TabIndex = 7
        Me.RightLabel.Text = "0.000 SYMBOL"
        Me.RightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LeftLabel
        '
        Me.LeftLabel.AutoSize = True
        Me.LeftLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LeftLabel.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.LeftLabel.Location = New System.Drawing.Point(10, 8)
        Me.LeftLabel.Name = "LeftLabel"
        Me.LeftLabel.Size = New System.Drawing.Size(145, 25)
        Me.LeftLabel.TabIndex = 6
        Me.LeftLabel.Text = "Token (SYMBOL):"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Separator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Guna2Separator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2Separator1.Location = New System.Drawing.Point(7, 38)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(607, 10)
        Me.Guna2Separator1.TabIndex = 8
        '
        'HashLabel
        '
        Me.HashLabel.ActiveLinkColor = System.Drawing.Color.White
        Me.HashLabel.AutoEllipsis = True
        Me.HashLabel.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.HashLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.HashLabel.Location = New System.Drawing.Point(198, 8)
        Me.HashLabel.Name = "HashLabel"
        Me.HashLabel.Size = New System.Drawing.Size(225, 25)
        Me.HashLabel.TabIndex = 9
        Me.HashLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PBExternal
        '
        Me.PBExternal.FillColor = System.Drawing.Color.Empty
        Me.PBExternal.Image = My.Resources.Resources.ExternalLink
        Me.PBExternal.ImageRotate = 0!
        Me.PBExternal.Location = New System.Drawing.Point(418, 10)
        Me.PBExternal.Name = "PBExternal"
        Me.PBExternal.Size = New System.Drawing.Size(16, 16)
        Me.PBExternal.TabIndex = 10
        Me.PBExternal.TabStop = False
        Me.PBExternal.Visible = False
        '
        'CoinItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Controls.Add(Me.PBExternal)
        Me.Controls.Add(Me.HashLabel)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.RightLabel)
        Me.Controls.Add(Me.LeftLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "CoinItem"
        Me.Size = New System.Drawing.Size(621, 44)
        CType(Me.PBExternal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RightLabel As Label
    Friend WithEvents LeftLabel As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents HashLabel As LinkLabel
    Friend WithEvents PBExternal As Guna.UI2.WinForms.Guna2PictureBox
End Class
