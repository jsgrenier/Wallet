<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReceiveForm
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
        Me.GeneralPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.PBWalletQR = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PanelPublicAddress = New Guna.UI2.WinForms.Guna2Panel()
        Me.CopyPublicAddress = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TBPublicAddress = New System.Windows.Forms.TextBox()
        Me.AllCoinsPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.CoinsFlowPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabelTitleAllCoins = New System.Windows.Forms.Label()
        Me.HistoryPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.HistoryFlowPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabelTitleHistory = New System.Windows.Forms.Label()
        Me.MainFlowPanel = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.GeneralPanel.SuspendLayout()
        CType(Me.PBWalletQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPublicAddress.SuspendLayout()
        CType(Me.CopyPublicAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AllCoinsPanel.SuspendLayout()
        Me.HistoryPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GeneralPanel
        '
        Me.GeneralPanel.BackColor = System.Drawing.Color.Transparent
        Me.GeneralPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GeneralPanel.BorderRadius = 10
        Me.GeneralPanel.Controls.Add(Me.PBWalletQR)
        Me.GeneralPanel.Controls.Add(Me.PanelPublicAddress)
        Me.GeneralPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GeneralPanel.Location = New System.Drawing.Point(33, 15)
        Me.GeneralPanel.Margin = New System.Windows.Forms.Padding(33, 15, 3, 3)
        Me.GeneralPanel.Name = "GeneralPanel"
        Me.GeneralPanel.ShadowDecoration.BorderRadius = 10
        Me.GeneralPanel.ShadowDecoration.Depth = 10
        Me.GeneralPanel.ShadowDecoration.Enabled = True
        Me.GeneralPanel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8, 4, 8, 10)
        Me.GeneralPanel.Size = New System.Drawing.Size(659, 422)
        Me.GeneralPanel.TabIndex = 2
        Me.GeneralPanel.Visible = False
        '
        'PBWalletQR
        '
        Me.PBWalletQR.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PBWalletQR.BorderRadius = 20
        Me.PBWalletQR.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.PBWalletQR.ImageRotate = 0!
        Me.PBWalletQR.Location = New System.Drawing.Point(204, 42)
        Me.PBWalletQR.Name = "PBWalletQR"
        Me.PBWalletQR.Size = New System.Drawing.Size(250, 250)
        Me.PBWalletQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBWalletQR.TabIndex = 5
        Me.PBWalletQR.TabStop = False
        '
        'PanelPublicAddress
        '
        Me.PanelPublicAddress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelPublicAddress.BackColor = System.Drawing.Color.Transparent
        Me.PanelPublicAddress.BorderRadius = 6
        Me.PanelPublicAddress.Controls.Add(Me.CopyPublicAddress)
        Me.PanelPublicAddress.Controls.Add(Me.TBPublicAddress)
        Me.PanelPublicAddress.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PanelPublicAddress.Location = New System.Drawing.Point(81, 327)
        Me.PanelPublicAddress.Name = "PanelPublicAddress"
        Me.PanelPublicAddress.ShadowDecoration.Depth = 20
        Me.PanelPublicAddress.ShadowDecoration.Enabled = True
        Me.PanelPublicAddress.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 2, 2)
        Me.PanelPublicAddress.Size = New System.Drawing.Size(496, 45)
        Me.PanelPublicAddress.TabIndex = 4
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
        'TBPublicAddress
        '
        Me.TBPublicAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TBPublicAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBPublicAddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPublicAddress.ForeColor = System.Drawing.Color.Gray
        Me.TBPublicAddress.Location = New System.Drawing.Point(17, 11)
        Me.TBPublicAddress.Name = "TBPublicAddress"
        Me.TBPublicAddress.ReadOnly = True
        Me.TBPublicAddress.Size = New System.Drawing.Size(433, 22)
        Me.TBPublicAddress.TabIndex = 5
        '
        'AllCoinsPanel
        '
        Me.AllCoinsPanel.BackColor = System.Drawing.Color.Transparent
        Me.AllCoinsPanel.BorderRadius = 10
        Me.AllCoinsPanel.Controls.Add(Me.CoinsFlowPanel)
        Me.AllCoinsPanel.Controls.Add(Me.LabelTitleAllCoins)
        Me.AllCoinsPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.AllCoinsPanel.Location = New System.Drawing.Point(33, 473)
        Me.AllCoinsPanel.Margin = New System.Windows.Forms.Padding(33, 15, 3, 3)
        Me.AllCoinsPanel.Name = "AllCoinsPanel"
        Me.AllCoinsPanel.ShadowDecoration.BorderRadius = 10
        Me.AllCoinsPanel.ShadowDecoration.Depth = 10
        Me.AllCoinsPanel.ShadowDecoration.Enabled = True
        Me.AllCoinsPanel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8, 4, 8, 10)
        Me.AllCoinsPanel.Size = New System.Drawing.Size(659, 159)
        Me.AllCoinsPanel.TabIndex = 3
        Me.AllCoinsPanel.Visible = False
        '
        'CoinsFlowPanel
        '
        Me.CoinsFlowPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CoinsFlowPanel.Location = New System.Drawing.Point(19, 109)
        Me.CoinsFlowPanel.Name = "CoinsFlowPanel"
        Me.CoinsFlowPanel.Size = New System.Drawing.Size(621, 44)
        Me.CoinsFlowPanel.TabIndex = 5
        '
        'LabelTitleAllCoins
        '
        Me.LabelTitleAllCoins.AutoSize = True
        Me.LabelTitleAllCoins.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LabelTitleAllCoins.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitleAllCoins.Location = New System.Drawing.Point(11, 42)
        Me.LabelTitleAllCoins.Name = "LabelTitleAllCoins"
        Me.LabelTitleAllCoins.Size = New System.Drawing.Size(124, 37)
        Me.LabelTitleAllCoins.TabIndex = 2
        Me.LabelTitleAllCoins.Text = "All Coins"
        '
        'HistoryPanel
        '
        Me.HistoryPanel.BackColor = System.Drawing.Color.Transparent
        Me.HistoryPanel.BorderRadius = 10
        Me.HistoryPanel.Controls.Add(Me.HistoryFlowPanel)
        Me.HistoryPanel.Controls.Add(Me.LabelTitleHistory)
        Me.HistoryPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.HistoryPanel.Location = New System.Drawing.Point(33, 668)
        Me.HistoryPanel.Margin = New System.Windows.Forms.Padding(33, 15, 3, 3)
        Me.HistoryPanel.Name = "HistoryPanel"
        Me.HistoryPanel.ShadowDecoration.BorderRadius = 10
        Me.HistoryPanel.ShadowDecoration.Depth = 10
        Me.HistoryPanel.ShadowDecoration.Enabled = True
        Me.HistoryPanel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8, 4, 8, 10)
        Me.HistoryPanel.Size = New System.Drawing.Size(659, 159)
        Me.HistoryPanel.TabIndex = 4
        Me.HistoryPanel.Visible = False
        '
        'HistoryFlowPanel
        '
        Me.HistoryFlowPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.HistoryFlowPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.HistoryFlowPanel.Location = New System.Drawing.Point(19, 109)
        Me.HistoryFlowPanel.Name = "HistoryFlowPanel"
        Me.HistoryFlowPanel.Size = New System.Drawing.Size(621, 44)
        Me.HistoryFlowPanel.TabIndex = 6
        '
        'LabelTitleHistory
        '
        Me.LabelTitleHistory.AutoSize = True
        Me.LabelTitleHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LabelTitleHistory.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitleHistory.Location = New System.Drawing.Point(11, 42)
        Me.LabelTitleHistory.Name = "LabelTitleHistory"
        Me.LabelTitleHistory.Size = New System.Drawing.Size(255, 37)
        Me.LabelTitleHistory.TabIndex = 2
        Me.LabelTitleHistory.Text = "Transaction History"
        '
        'MainFlowPanel
        '
        Me.MainFlowPanel.AlwaysScrollActiveControlIntoView = False
        Me.MainFlowPanel.Controls.Add(Me.HistoryPanel)
        Me.MainFlowPanel.Controls.Add(Me.AllCoinsPanel)
        Me.MainFlowPanel.Controls.Add(Me.GeneralPanel)
        Me.MainFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainFlowPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainFlowPanel.Name = "MainFlowPanel"
        Me.MainFlowPanel.Size = New System.Drawing.Size(725, 950)
        Me.MainFlowPanel.TabIndex = 4
        '
        'ReceiveForm
        '
        Me.Appearance.ForeColor = System.Drawing.Color.White
        Me.Appearance.Options.UseFont = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(725, 950)
        Me.Controls.Add(Me.MainFlowPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ReceiveForm"
        Me.Text = "ReceiveForm"
        Me.GeneralPanel.ResumeLayout(False)
        CType(Me.PBWalletQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPublicAddress.ResumeLayout(False)
        Me.PanelPublicAddress.PerformLayout()
        CType(Me.CopyPublicAddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AllCoinsPanel.ResumeLayout(False)
        Me.AllCoinsPanel.PerformLayout()
        Me.HistoryPanel.ResumeLayout(False)
        Me.HistoryPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GeneralPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PanelPublicAddress As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CopyPublicAddress As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TBPublicAddress As TextBox
    Friend WithEvents AllCoinsPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LabelTitleAllCoins As Label
    Friend WithEvents HistoryPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LabelTitleHistory As Label
    Friend WithEvents PBWalletQR As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents CoinsFlowPanel As FlowLayoutPanel
    Friend WithEvents HistoryFlowPanel As FlowLayoutPanel
    Friend WithEvents MainFlowPanel As DevExpress.XtraEditors.XtraScrollableControl
End Class
