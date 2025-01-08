<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SendForm
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
        Me.LabelTransaction = New System.Windows.Forms.Label()
        Me.TBAmount = New Wallet.NumericTextbox()
        Me.LoadingControl1 = New Wallet.LoadingControl()
        Me.BtnSend = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBTokens = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LabelTitleAllCoins = New System.Windows.Forms.Label()
        Me.TBDestinationAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PanelPublicAddress = New Guna.UI2.WinForms.Guna2Panel()
        Me.CopyPublicAddress = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TBPublicAddress = New System.Windows.Forms.TextBox()
        Me.MainFlowPanel = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.tim = New System.Windows.Forms.Timer(Me.components)
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
        Me.GeneralPanel.Controls.Add(Me.LabelTransaction)
        Me.GeneralPanel.Controls.Add(Me.TBAmount)
        Me.GeneralPanel.Controls.Add(Me.LoadingControl1)
        Me.GeneralPanel.Controls.Add(Me.BtnSend)
        Me.GeneralPanel.Controls.Add(Me.Label4)
        Me.GeneralPanel.Controls.Add(Me.Label3)
        Me.GeneralPanel.Controls.Add(Me.Label2)
        Me.GeneralPanel.Controls.Add(Me.Label1)
        Me.GeneralPanel.Controls.Add(Me.CBTokens)
        Me.GeneralPanel.Controls.Add(Me.LabelTitleAllCoins)
        Me.GeneralPanel.Controls.Add(Me.TBDestinationAddress)
        Me.GeneralPanel.Controls.Add(Me.PanelPublicAddress)
        Me.GeneralPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GeneralPanel.Location = New System.Drawing.Point(33, 15)
        Me.GeneralPanel.Margin = New System.Windows.Forms.Padding(33, 15, 3, 3)
        Me.GeneralPanel.Name = "GeneralPanel"
        Me.GeneralPanel.ShadowDecoration.BorderRadius = 10
        Me.GeneralPanel.ShadowDecoration.Depth = 10
        Me.GeneralPanel.ShadowDecoration.Enabled = True
        Me.GeneralPanel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8, 4, 8, 10)
        Me.GeneralPanel.Size = New System.Drawing.Size(659, 682)
        Me.GeneralPanel.TabIndex = 2
        Me.GeneralPanel.Visible = False
        '
        'LabelTransaction
        '
        Me.LabelTransaction.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTransaction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LabelTransaction.Location = New System.Drawing.Point(3, 636)
        Me.LabelTransaction.Name = "LabelTransaction"
        Me.LabelTransaction.Size = New System.Drawing.Size(653, 20)
        Me.LabelTransaction.TabIndex = 23
        Me.LabelTransaction.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TBAmount
        '
        Me.TBAmount.AllowDecimals = True
        Me.TBAmount.BorderRadius = 6
        Me.TBAmount.BorderThickness = 0
        Me.TBAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBAmount.DefaultText = ""
        Me.TBAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBAmount.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TBAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBAmount.ForeColor = System.Drawing.Color.White
        Me.TBAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBAmount.Location = New System.Drawing.Point(83, 481)
        Me.TBAmount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBAmount.Name = "TBAmount"
        Me.TBAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBAmount.PlaceholderText = ""
        Me.TBAmount.SelectedText = ""
        Me.TBAmount.Size = New System.Drawing.Size(496, 45)
        Me.TBAmount.TabIndex = 22
        '
        'LoadingControl1
        '
        Me.LoadingControl1.AnimationSpeed = 16
        Me.LoadingControl1.ArcColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.LoadingControl1.ArcLength = 120
        Me.LoadingControl1.ArcThickness = 5
        Me.LoadingControl1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LoadingControl1.Location = New System.Drawing.Point(430, 573)
        Me.LoadingControl1.Name = "LoadingControl1"
        Me.LoadingControl1.PaddingSize = 10
        Me.LoadingControl1.Size = New System.Drawing.Size(45, 45)
        Me.LoadingControl1.TabIndex = 21
        Me.LoadingControl1.Visible = False
        '
        'BtnSend
        '
        Me.BtnSend.AllowFocus = False
        Me.BtnSend.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BtnSend.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSend.Appearance.Options.UseBackColor = True
        Me.BtnSend.Appearance.Options.UseFont = True
        Me.BtnSend.AppearanceHovered.Options.UseBackColor = True
        Me.BtnSend.AppearancePressed.Options.UseBackColor = True
        Me.BtnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSend.Location = New System.Drawing.Point(241, 573)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.BtnSend.Size = New System.Drawing.Size(177, 45)
        Me.BtnSend.TabIndex = 20
        Me.BtnSend.Text = "Send"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(79, 454)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 21)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Amount of tokens to send"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Destination address"
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
        Me.Label1.Size = New System.Drawing.Size(206, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Select which token to send"
        '
        'CBTokens
        '
        Me.CBTokens.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.CBTokens.BorderRadius = 6
        Me.CBTokens.BorderThickness = 0
        Me.CBTokens.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBTokens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTokens.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.CBTokens.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBTokens.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBTokens.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.CBTokens.ForeColor = System.Drawing.Color.White
        Me.CBTokens.ItemHeight = 39
        Me.CBTokens.Location = New System.Drawing.Point(83, 371)
        Me.CBTokens.Name = "CBTokens"
        Me.CBTokens.Size = New System.Drawing.Size(201, 45)
        Me.CBTokens.TabIndex = 8
        '
        'LabelTitleAllCoins
        '
        Me.LabelTitleAllCoins.AutoSize = True
        Me.LabelTitleAllCoins.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitleAllCoins.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitleAllCoins.Location = New System.Drawing.Point(11, 42)
        Me.LabelTitleAllCoins.Name = "LabelTitleAllCoins"
        Me.LabelTitleAllCoins.Size = New System.Drawing.Size(169, 37)
        Me.LabelTitleAllCoins.TabIndex = 7
        Me.LabelTitleAllCoins.Text = "Send Tokens"
        '
        'TBDestinationAddress
        '
        Me.TBDestinationAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TBDestinationAddress.BorderRadius = 6
        Me.TBDestinationAddress.BorderThickness = 0
        Me.TBDestinationAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBDestinationAddress.DefaultText = ""
        Me.TBDestinationAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBDestinationAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBDestinationAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBDestinationAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBDestinationAddress.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TBDestinationAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBDestinationAddress.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBDestinationAddress.ForeColor = System.Drawing.Color.White
        Me.TBDestinationAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBDestinationAddress.Location = New System.Drawing.Point(83, 258)
        Me.TBDestinationAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBDestinationAddress.Name = "TBDestinationAddress"
        Me.TBDestinationAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBDestinationAddress.PlaceholderText = ""
        Me.TBDestinationAddress.SelectedText = ""
        Me.TBDestinationAddress.Size = New System.Drawing.Size(496, 45)
        Me.TBDestinationAddress.TabIndex = 6
        Me.TBDestinationAddress.TextOffset = New System.Drawing.Point(10, 0)
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
        'SendForm
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
        Me.Name = "SendForm"
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
    Friend WithEvents TBDestinationAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LabelTitleAllCoins As Label
    Friend WithEvents CBTokens As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSend As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MainFlowPanel As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents LoadingControl1 As LoadingControl
    Friend WithEvents tim As Timer
    Friend WithEvents TBAmount As NumericTextbox
    Friend WithEvents LabelTransaction As Label
End Class
