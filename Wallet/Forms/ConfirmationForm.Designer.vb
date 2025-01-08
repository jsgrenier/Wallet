<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConfirmationForm
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.MainFlowPanel = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.tim = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelPublicAddress = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.CopyPublicAddress = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.IDLabel = New System.Windows.Forms.LinkLabel()
        Me.PanelPublicAddress.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.CopyPublicAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainFlowPanel
        '
        Me.MainFlowPanel.AlwaysScrollActiveControlIntoView = False
        Me.MainFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainFlowPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainFlowPanel.Name = "MainFlowPanel"
        Me.MainFlowPanel.Size = New System.Drawing.Size(725, 856)
        Me.MainFlowPanel.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(79, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Your address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 37)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Send Tokens"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(273, 390)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Transaction ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(141, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(377, 37)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Transaction successfully sent!"
        '
        'PanelPublicAddress
        '
        Me.PanelPublicAddress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelPublicAddress.BackColor = System.Drawing.Color.Transparent
        Me.PanelPublicAddress.BorderRadius = 6
        Me.PanelPublicAddress.Controls.Add(Me.CopyPublicAddress)
        Me.PanelPublicAddress.Controls.Add(Me.IDLabel)
        Me.PanelPublicAddress.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PanelPublicAddress.Location = New System.Drawing.Point(81, 419)
        Me.PanelPublicAddress.Name = "PanelPublicAddress"
        Me.PanelPublicAddress.ShadowDecoration.Depth = 20
        Me.PanelPublicAddress.ShadowDecoration.Enabled = True
        Me.PanelPublicAddress.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 2, 2)
        Me.PanelPublicAddress.Size = New System.Drawing.Size(496, 45)
        Me.PanelPublicAddress.TabIndex = 13
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.Label8)
        Me.Guna2Panel1.Controls.Add(Me.PanelPublicAddress)
        Me.Guna2Panel1.Controls.Add(Me.Label7)
        Me.Guna2Panel1.Location = New System.Drawing.Point(33, 15)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(659, 682)
        Me.Guna2Panel1.TabIndex = 14
        '
        'CopyPublicAddress
        '
        Me.CopyPublicAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CopyPublicAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.CopyPublicAddress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CopyPublicAddress.FillColor = System.Drawing.Color.Empty
        Me.CopyPublicAddress.Image = Global.Wallet.My.Resources.Resources.copy_24
        Me.CopyPublicAddress.ImageRotate = 0!
        Me.CopyPublicAddress.Location = New System.Drawing.Point(456, 10)
        Me.CopyPublicAddress.Name = "CopyPublicAddress"
        Me.CopyPublicAddress.Size = New System.Drawing.Size(24, 24)
        Me.CopyPublicAddress.TabIndex = 0
        Me.CopyPublicAddress.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Empty
        Me.Guna2PictureBox1.Image = Global.Wallet.My.Resources.Resources.successIcon
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(257, 177)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(144, 144)
        Me.Guna2PictureBox1.TabIndex = 14
        Me.Guna2PictureBox1.TabStop = False
        '
        'IDLabel
        '
        Me.IDLabel.ActiveLinkColor = System.Drawing.Color.White
        Me.IDLabel.AutoEllipsis = True
        Me.IDLabel.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.IDLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.IDLabel.Location = New System.Drawing.Point(10, 9)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(476, 25)
        Me.IDLabel.TabIndex = 15
        Me.IDLabel.TabStop = True
        Me.IDLabel.Text = "ad4bcf728b134652ac70419a6b4a13c6"
        Me.IDLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ConfirmationForm
        '
        Me.Appearance.ForeColor = System.Drawing.Color.White
        Me.Appearance.Options.UseFont = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(725, 856)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.MainFlowPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ConfirmationForm"
        Me.Text = "SendForm"
        Me.PanelPublicAddress.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.CopyPublicAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainFlowPanel As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents tim As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PanelPublicAddress As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CopyPublicAddress As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents IDLabel As LinkLabel
End Class
