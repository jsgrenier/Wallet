<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateTokenForm
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
        Me.GeneralPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.TBSymbol = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LoadingControl1 = New Wallet.LoadingControl()
        Me.BtnCreate = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelTitleAllCoins = New System.Windows.Forms.Label()
        Me.TBName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PanelPublicAddress = New Guna.UI2.WinForms.Guna2Panel()
        Me.CopyPublicAddress = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TBPublicAddress = New System.Windows.Forms.TextBox()
        Me.MainFlowPanel = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.tim = New System.Windows.Forms.Timer(Me.components)
        Me.TBSupply = New Wallet.NumericTextbox()
        Me.GeneralPanel.SuspendLayout()
        Me.PanelPublicAddress.SuspendLayout()
        CType(Me.CopyPublicAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GeneralPanel
        '
        Me.GeneralPanel.BackColor = System.Drawing.Color.Transparent
        Me.GeneralPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GeneralPanel.BorderRadius = 10
        Me.GeneralPanel.Controls.Add(Me.TBSupply)
        Me.GeneralPanel.Controls.Add(Me.TBSymbol)
        Me.GeneralPanel.Controls.Add(Me.LoadingControl1)
        Me.GeneralPanel.Controls.Add(Me.BtnCreate)
        Me.GeneralPanel.Controls.Add(Me.Label4)
        Me.GeneralPanel.Controls.Add(Me.Label3)
        Me.GeneralPanel.Controls.Add(Me.Label2)
        Me.GeneralPanel.Controls.Add(Me.Label1)
        Me.GeneralPanel.Controls.Add(Me.LabelTitleAllCoins)
        Me.GeneralPanel.Controls.Add(Me.TBName)
        Me.GeneralPanel.Controls.Add(Me.PanelPublicAddress)
        Me.GeneralPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GeneralPanel.Location = New System.Drawing.Point(33, 15)
        Me.GeneralPanel.Margin = New System.Windows.Forms.Padding(33, 15, 3, 3)
        Me.GeneralPanel.Name = "GeneralPanel"
        Me.GeneralPanel.ShadowDecoration.BorderRadius = 10
        Me.GeneralPanel.ShadowDecoration.Depth = 10
        Me.GeneralPanel.ShadowDecoration.Enabled = True
        Me.GeneralPanel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8, 4, 8, 10)
        Me.GeneralPanel.Size = New System.Drawing.Size(659, 650)
        Me.GeneralPanel.TabIndex = 2
        Me.GeneralPanel.Visible = False
        '
        'TBSymbol
        '
        Me.TBSymbol.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TBSymbol.BorderRadius = 6
        Me.TBSymbol.BorderThickness = 0
        Me.TBSymbol.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBSymbol.DefaultText = ""
        Me.TBSymbol.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBSymbol.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBSymbol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBSymbol.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBSymbol.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TBSymbol.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBSymbol.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBSymbol.ForeColor = System.Drawing.Color.White
        Me.TBSymbol.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBSymbol.Location = New System.Drawing.Point(83, 371)
        Me.TBSymbol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBSymbol.Name = "TBSymbol"
        Me.TBSymbol.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBSymbol.PlaceholderText = ""
        Me.TBSymbol.SelectedText = ""
        Me.TBSymbol.Size = New System.Drawing.Size(496, 45)
        Me.TBSymbol.TabIndex = 22
        Me.TBSymbol.TextOffset = New System.Drawing.Point(10, 0)
        '
        'LoadingControl1
        '
        Me.LoadingControl1.AnimationSpeed = 16
        Me.LoadingControl1.ArcColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.LoadingControl1.ArcLength = 120
        Me.LoadingControl1.ArcThickness = 5
        Me.LoadingControl1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LoadingControl1.Location = New System.Drawing.Point(421, 573)
        Me.LoadingControl1.Name = "LoadingControl1"
        Me.LoadingControl1.PaddingSize = 10
        Me.LoadingControl1.Size = New System.Drawing.Size(45, 45)
        Me.LoadingControl1.TabIndex = 21
        Me.LoadingControl1.Visible = False
        '
        'BtnCreate
        '
        Me.BtnCreate.AllowFocus = False
        Me.BtnCreate.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BtnCreate.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCreate.Appearance.Options.UseBackColor = True
        Me.BtnCreate.Appearance.Options.UseFont = True
        Me.BtnCreate.AppearanceHovered.Options.UseBackColor = True
        Me.BtnCreate.AppearancePressed.Options.UseBackColor = True
        Me.BtnCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCreate.Location = New System.Drawing.Point(241, 573)
        Me.BtnCreate.Name = "BtnSend"
        Me.BtnCreate.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.BtnCreate.Size = New System.Drawing.Size(177, 45)
        Me.BtnCreate.TabIndex = 20
        Me.BtnCreate.Text = "Create Token"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(79, 454)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 21)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Initial supply"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Token name (eg. Bitcoin)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Your address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 343)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Token symbol (eg. BTC)"
        '
        'LabelTitleAllCoins
        '
        Me.LabelTitleAllCoins.AutoSize = True
        Me.LabelTitleAllCoins.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitleAllCoins.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitleAllCoins.Location = New System.Drawing.Point(11, 42)
        Me.LabelTitleAllCoins.Name = "LabelTitleAllCoins"
        Me.LabelTitleAllCoins.Size = New System.Drawing.Size(196, 37)
        Me.LabelTitleAllCoins.TabIndex = 7
        Me.LabelTitleAllCoins.Text = "Create a Token"
        '
        'TBName
        '
        Me.TBName.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TBName.BorderRadius = 6
        Me.TBName.BorderThickness = 0
        Me.TBName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBName.DefaultText = ""
        Me.TBName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBName.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TBName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBName.ForeColor = System.Drawing.Color.White
        Me.TBName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBName.Location = New System.Drawing.Point(83, 258)
        Me.TBName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBName.Name = "TBName"
        Me.TBName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBName.PlaceholderText = ""
        Me.TBName.SelectedText = ""
        Me.TBName.Size = New System.Drawing.Size(496, 45)
        Me.TBName.TabIndex = 6
        Me.TBName.TextOffset = New System.Drawing.Point(10, 0)
        '
        'PanelPublicAddress
        '
        Me.PanelPublicAddress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelPublicAddress.BackColor = System.Drawing.Color.Transparent
        Me.PanelPublicAddress.BorderRadius = 6
        Me.PanelPublicAddress.Controls.Add(Me.CopyPublicAddress)
        Me.PanelPublicAddress.Controls.Add(Me.TBPublicAddress)
        Me.PanelPublicAddress.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PanelPublicAddress.Location = New System.Drawing.Point(83, 146)
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
        'MainFlowPanel
        '
        Me.MainFlowPanel.AlwaysScrollActiveControlIntoView = False
        Me.MainFlowPanel.Controls.Add(Me.GeneralPanel)
        Me.MainFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainFlowPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainFlowPanel.Name = "MainFlowPanel"
        Me.MainFlowPanel.Size = New System.Drawing.Size(725, 856)
        Me.MainFlowPanel.TabIndex = 5
        '
        'tim
        '
        '
        'TBSupply
        '
        Me.TBSupply.AllowDecimals = False
        Me.TBSupply.BorderRadius = 6
        Me.TBSupply.BorderThickness = 0
        Me.TBSupply.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBSupply.DefaultText = ""
        Me.TBSupply.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBSupply.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBSupply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBSupply.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBSupply.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TBSupply.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBSupply.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBSupply.ForeColor = System.Drawing.Color.White
        Me.TBSupply.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBSupply.Location = New System.Drawing.Point(83, 481)
        Me.TBSupply.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBSupply.Name = "TBSupply"
        Me.TBSupply.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBSupply.PlaceholderText = ""
        Me.TBSupply.SelectedText = ""
        Me.TBSupply.Size = New System.Drawing.Size(496, 45)
        Me.TBSupply.TabIndex = 23
        '
        'CreateTokenForm
        '
        Me.Appearance.ForeColor = System.Drawing.Color.White
        Me.Appearance.Options.UseFont = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(725, 856)
        Me.Controls.Add(Me.MainFlowPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CreateTokenForm"
        Me.Text = "SendForm"
        Me.GeneralPanel.ResumeLayout(False)
        Me.GeneralPanel.PerformLayout()
        Me.PanelPublicAddress.ResumeLayout(False)
        Me.PanelPublicAddress.PerformLayout()
        CType(Me.CopyPublicAddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GeneralPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PanelPublicAddress As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CopyPublicAddress As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TBPublicAddress As TextBox
    Friend WithEvents TBName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LabelTitleAllCoins As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCreate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MainFlowPanel As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents LoadingControl1 As LoadingControl
    Friend WithEvents tim As Timer
    Friend WithEvents TBSymbol As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBSupply As NumericTextbox
End Class
