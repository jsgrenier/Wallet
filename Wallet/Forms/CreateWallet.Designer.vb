<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateWallet
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateWallet))
        Me.GeneralPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnWallet = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnGenerate = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelPrivateAddress = New Guna.UI2.WinForms.Guna2Panel()
        Me.CopyPrivateAddress = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TBPrivateAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelPublicAddress = New Guna.UI2.WinForms.Guna2Panel()
        Me.CopyPublicAddress = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TBPublicAddress = New System.Windows.Forms.TextBox()
        Me.LabelTitleAllCoins = New System.Windows.Forms.Label()
        Me.GeneralPanel.SuspendLayout()
        Me.PanelPrivateAddress.SuspendLayout()
        CType(Me.CopyPrivateAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPublicAddress.SuspendLayout()
        CType(Me.CopyPublicAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GeneralPanel
        '
        Me.GeneralPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GeneralPanel.BackColor = System.Drawing.Color.Transparent
        Me.GeneralPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GeneralPanel.BorderRadius = 10
        Me.GeneralPanel.Controls.Add(Me.BtnWallet)
        Me.GeneralPanel.Controls.Add(Me.BtnSave)
        Me.GeneralPanel.Controls.Add(Me.BtnGenerate)
        Me.GeneralPanel.Controls.Add(Me.Label3)
        Me.GeneralPanel.Controls.Add(Me.TBPassword)
        Me.GeneralPanel.Controls.Add(Me.Label2)
        Me.GeneralPanel.Controls.Add(Me.PanelPrivateAddress)
        Me.GeneralPanel.Controls.Add(Me.Label1)
        Me.GeneralPanel.Controls.Add(Me.PanelPublicAddress)
        Me.GeneralPanel.Controls.Add(Me.LabelTitleAllCoins)
        Me.GeneralPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GeneralPanel.Location = New System.Drawing.Point(38, 20)
        Me.GeneralPanel.Margin = New System.Windows.Forms.Padding(33, 15, 3, 3)
        Me.GeneralPanel.Name = "GeneralPanel"
        Me.GeneralPanel.ShadowDecoration.BorderRadius = 10
        Me.GeneralPanel.ShadowDecoration.Depth = 10
        Me.GeneralPanel.ShadowDecoration.Enabled = True
        Me.GeneralPanel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8, 4, 8, 10)
        Me.GeneralPanel.Size = New System.Drawing.Size(659, 688)
        Me.GeneralPanel.TabIndex = 4
        '
        'BtnWallet
        '
        Me.BtnWallet.AllowFocus = False
        Me.BtnWallet.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BtnWallet.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnWallet.Appearance.Options.UseBackColor = True
        Me.BtnWallet.Appearance.Options.UseFont = True
        Me.BtnWallet.AppearanceHovered.Options.UseBackColor = True
        Me.BtnWallet.AppearancePressed.Options.UseBackColor = True
        Me.BtnWallet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnWallet.Location = New System.Drawing.Point(448, 592)
        Me.BtnWallet.Name = "BtnWallet"
        Me.BtnWallet.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.BtnWallet.Size = New System.Drawing.Size(129, 45)
        Me.BtnWallet.TabIndex = 19
        Me.BtnWallet.Text = "Go to wallet"
        '
        'BtnSave
        '
        Me.BtnSave.AllowFocus = False
        Me.BtnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BtnSave.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.Appearance.Options.UseBackColor = True
        Me.BtnSave.Appearance.Options.UseFont = True
        Me.BtnSave.AppearanceHovered.Options.UseBackColor = True
        Me.BtnSave.AppearancePressed.Options.UseBackColor = True
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(81, 592)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.BtnSave.Size = New System.Drawing.Size(117, 45)
        Me.BtnSave.TabIndex = 18
        Me.BtnSave.Text = "Save key"
        '
        'BtnGenerate
        '
        Me.BtnGenerate.AllowFocus = False
        Me.BtnGenerate.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BtnGenerate.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGenerate.Appearance.Options.UseBackColor = True
        Me.BtnGenerate.Appearance.Options.UseFont = True
        Me.BtnGenerate.AppearanceHovered.Options.UseBackColor = True
        Me.BtnGenerate.AppearancePressed.Options.UseBackColor = True
        Me.BtnGenerate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGenerate.Location = New System.Drawing.Point(81, 244)
        Me.BtnGenerate.Name = "BtnGenerate"
        Me.BtnGenerate.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.BtnGenerate.Size = New System.Drawing.Size(496, 45)
        Me.BtnGenerate.TabIndex = 17
        Me.BtnGenerate.Text = "Generate wallet"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 21)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Wallet password"
        '
        'TBPassword
        '
        Me.TBPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TBPassword.BorderRadius = 6
        Me.TBPassword.BorderThickness = 0
        Me.TBPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBPassword.DefaultText = ""
        Me.TBPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TBPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBPassword.ForeColor = System.Drawing.Color.White
        Me.TBPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBPassword.Location = New System.Drawing.Point(81, 148)
        Me.TBPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBPassword.PlaceholderText = ""
        Me.TBPassword.SelectedText = ""
        Me.TBPassword.Size = New System.Drawing.Size(496, 45)
        Me.TBPassword.TabIndex = 15
        Me.TBPassword.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 450)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Private key"
        '
        'PanelPrivateAddress
        '
        Me.PanelPrivateAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelPrivateAddress.BackColor = System.Drawing.Color.Transparent
        Me.PanelPrivateAddress.BorderRadius = 6
        Me.PanelPrivateAddress.Controls.Add(Me.CopyPrivateAddress)
        Me.PanelPrivateAddress.Controls.Add(Me.TBPrivateAddress)
        Me.PanelPrivateAddress.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PanelPrivateAddress.Location = New System.Drawing.Point(81, 484)
        Me.PanelPrivateAddress.Name = "PanelPrivateAddress"
        Me.PanelPrivateAddress.ShadowDecoration.Depth = 20
        Me.PanelPrivateAddress.ShadowDecoration.Enabled = True
        Me.PanelPrivateAddress.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 2, 2)
        Me.PanelPrivateAddress.Size = New System.Drawing.Size(496, 45)
        Me.PanelPrivateAddress.TabIndex = 11
        '
        'CopyPrivateAddress
        '
        Me.CopyPrivateAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CopyPrivateAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.CopyPrivateAddress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CopyPrivateAddress.FillColor = System.Drawing.Color.Empty
        Me.CopyPrivateAddress.Image = Global.Wallet.My.Resources.Resources.copy_24
        Me.CopyPrivateAddress.ImageRotate = 0!
        Me.CopyPrivateAddress.Location = New System.Drawing.Point(456, 10)
        Me.CopyPrivateAddress.Name = "CopyPrivateAddress"
        Me.CopyPrivateAddress.Size = New System.Drawing.Size(24, 24)
        Me.CopyPrivateAddress.TabIndex = 0
        Me.CopyPrivateAddress.TabStop = False
        '
        'TBPrivateAddress
        '
        Me.TBPrivateAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TBPrivateAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBPrivateAddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPrivateAddress.ForeColor = System.Drawing.Color.Gray
        Me.TBPrivateAddress.Location = New System.Drawing.Point(17, 11)
        Me.TBPrivateAddress.Name = "TBPrivateAddress"
        Me.TBPrivateAddress.Size = New System.Drawing.Size(433, 22)
        Me.TBPrivateAddress.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 21)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Public key"
        '
        'PanelPublicAddress
        '
        Me.PanelPublicAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelPublicAddress.BackColor = System.Drawing.Color.Transparent
        Me.PanelPublicAddress.BorderRadius = 6
        Me.PanelPublicAddress.Controls.Add(Me.CopyPublicAddress)
        Me.PanelPublicAddress.Controls.Add(Me.TBPublicAddress)
        Me.PanelPublicAddress.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PanelPublicAddress.Location = New System.Drawing.Point(81, 370)
        Me.PanelPublicAddress.Name = "PanelPublicAddress"
        Me.PanelPublicAddress.ShadowDecoration.Depth = 20
        Me.PanelPublicAddress.ShadowDecoration.Enabled = True
        Me.PanelPublicAddress.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 2, 2)
        Me.PanelPublicAddress.Size = New System.Drawing.Size(496, 45)
        Me.PanelPublicAddress.TabIndex = 9
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
        Me.TBPublicAddress.Size = New System.Drawing.Size(433, 22)
        Me.TBPublicAddress.TabIndex = 5
        '
        'LabelTitleAllCoins
        '
        Me.LabelTitleAllCoins.AutoSize = True
        Me.LabelTitleAllCoins.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LabelTitleAllCoins.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitleAllCoins.Location = New System.Drawing.Point(11, 42)
        Me.LabelTitleAllCoins.Name = "LabelTitleAllCoins"
        Me.LabelTitleAllCoins.Size = New System.Drawing.Size(253, 37)
        Me.LabelTitleAllCoins.TabIndex = 5
        Me.LabelTitleAllCoins.Text = "Create a new wallet"
        '
        'CreateWallet
        '
        Me.Appearance.ForeColor = System.Drawing.Color.White
        Me.Appearance.Options.UseFont = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(735, 775)
        Me.Controls.Add(Me.GeneralPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("CreateWallet.IconOptions.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "CreateWallet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create a new wallet"
        Me.GeneralPanel.ResumeLayout(False)
        Me.GeneralPanel.PerformLayout()
        Me.PanelPrivateAddress.ResumeLayout(False)
        Me.PanelPrivateAddress.PerformLayout()
        CType(Me.CopyPrivateAddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPublicAddress.ResumeLayout(False)
        Me.PanelPublicAddress.PerformLayout()
        CType(Me.CopyPublicAddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GeneralPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LabelTitleAllCoins As Label
    Friend WithEvents PanelPublicAddress As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CopyPublicAddress As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TBPublicAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelPrivateAddress As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CopyPrivateAddress As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TBPrivateAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnGenerate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnWallet As DevExpress.XtraEditors.SimpleButton
End Class
