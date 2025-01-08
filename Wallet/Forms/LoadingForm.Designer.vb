<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoadingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoadingForm))
        Me.PBValidating = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.ValidatingProcess = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GeneralPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnRetry = New DevExpress.XtraEditors.SimpleButton()
        Me.PBNetwork = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PBKey = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PBChain = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.WalletConnector = New System.Windows.Forms.Timer(Me.components)
        Me.LoadingControl1 = New Wallet.LoadingControl()
        Me.GeneralPanel.SuspendLayout()
        CType(Me.PBNetwork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBKey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBChain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBValidating
        '
        Me.PBValidating.BorderRadius = 6
        Me.PBValidating.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PBValidating.Location = New System.Drawing.Point(36, 102)
        Me.PBValidating.Name = "PBValidating"
        Me.PBValidating.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.PBValidating.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.PBValidating.Size = New System.Drawing.Size(606, 45)
        Me.PBValidating.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PBValidating.TabIndex = 0
        Me.PBValidating.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'ValidatingProcess
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Chain is valid"
        '
        'GeneralPanel
        '
        Me.GeneralPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GeneralPanel.BackColor = System.Drawing.Color.Transparent
        Me.GeneralPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GeneralPanel.BorderRadius = 10
        Me.GeneralPanel.Controls.Add(Me.BtnExit)
        Me.GeneralPanel.Controls.Add(Me.BtnRetry)
        Me.GeneralPanel.Controls.Add(Me.PBNetwork)
        Me.GeneralPanel.Controls.Add(Me.Label3)
        Me.GeneralPanel.Controls.Add(Me.PBKey)
        Me.GeneralPanel.Controls.Add(Me.Label2)
        Me.GeneralPanel.Controls.Add(Me.PBChain)
        Me.GeneralPanel.Controls.Add(Me.LabelTitle)
        Me.GeneralPanel.Controls.Add(Me.Label1)
        Me.GeneralPanel.Controls.Add(Me.PBValidating)
        Me.GeneralPanel.Controls.Add(Me.LoadingControl1)
        Me.GeneralPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GeneralPanel.Location = New System.Drawing.Point(38, 20)
        Me.GeneralPanel.Margin = New System.Windows.Forms.Padding(33, 15, 3, 3)
        Me.GeneralPanel.Name = "GeneralPanel"
        Me.GeneralPanel.ShadowDecoration.BorderRadius = 10
        Me.GeneralPanel.ShadowDecoration.Depth = 10
        Me.GeneralPanel.ShadowDecoration.Enabled = True
        Me.GeneralPanel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8, 4, 8, 10)
        Me.GeneralPanel.Size = New System.Drawing.Size(659, 276)
        Me.GeneralPanel.TabIndex = 4
        '
        'BtnExit
        '
        Me.BtnExit.AllowFocus = False
        Me.BtnExit.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BtnExit.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnExit.Appearance.Options.UseBackColor = True
        Me.BtnExit.Appearance.Options.UseFont = True
        Me.BtnExit.AppearanceHovered.Options.UseBackColor = True
        Me.BtnExit.AppearancePressed.Options.UseBackColor = True
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.Location = New System.Drawing.Point(558, 212)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.BtnExit.Size = New System.Drawing.Size(84, 45)
        Me.BtnExit.TabIndex = 20
        Me.BtnExit.Text = "Cancel"
        Me.BtnExit.Visible = False
        '
        'BtnRetry
        '
        Me.BtnRetry.AllowFocus = False
        Me.BtnRetry.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BtnRetry.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnRetry.Appearance.Options.UseBackColor = True
        Me.BtnRetry.Appearance.Options.UseFont = True
        Me.BtnRetry.AppearanceHovered.Options.UseBackColor = True
        Me.BtnRetry.AppearancePressed.Options.UseBackColor = True
        Me.BtnRetry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRetry.Location = New System.Drawing.Point(468, 212)
        Me.BtnRetry.Name = "BtnRetry"
        Me.BtnRetry.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.BtnRetry.Size = New System.Drawing.Size(84, 45)
        Me.BtnRetry.TabIndex = 19
        Me.BtnRetry.Text = "Retry"
        Me.BtnRetry.Visible = False
        '
        'PBNetwork
        '
        Me.PBNetwork.FillColor = System.Drawing.Color.Empty
        Me.PBNetwork.ImageRotate = 0!
        Me.PBNetwork.Location = New System.Drawing.Point(210, 170)
        Me.PBNetwork.Name = "PBNetwork"
        Me.PBNetwork.Size = New System.Drawing.Size(24, 24)
        Me.PBNetwork.TabIndex = 15
        Me.PBNetwork.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Blockchain is reachable"
        '
        'PBKey
        '
        Me.PBKey.FillColor = System.Drawing.Color.Empty
        Me.PBKey.ImageRotate = 0!
        Me.PBKey.Location = New System.Drawing.Point(385, 170)
        Me.PBKey.Name = "PBKey"
        Me.PBKey.Size = New System.Drawing.Size(24, 24)
        Me.PBKey.TabIndex = 8
        Me.PBKey.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Key is valid"
        '
        'PBChain
        '
        Me.PBChain.FillColor = System.Drawing.Color.Empty
        Me.PBChain.ImageRotate = 0!
        Me.PBChain.Location = New System.Drawing.Point(210, 210)
        Me.PBChain.Name = "PBChain"
        Me.PBChain.Size = New System.Drawing.Size(24, 24)
        Me.PBChain.TabIndex = 6
        Me.PBChain.TabStop = False
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LabelTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(11, 42)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(398, 37)
        Me.LabelTitle.TabIndex = 5
        Me.LabelTitle.Text = "Connecting to the blockchain..."
        '
        'WalletConnector
        '
        Me.WalletConnector.Interval = 3000
        '
        'LoadingControl1
        '
        Me.LoadingControl1.AnimationSpeed = 16
        Me.LoadingControl1.ArcColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.LoadingControl1.ArcLength = 120
        Me.LoadingControl1.ArcThickness = 5
        Me.LoadingControl1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LoadingControl1.Location = New System.Drawing.Point(600, 37)
        Me.LoadingControl1.Name = "LoadingControl1"
        Me.LoadingControl1.PaddingSize = 10
        Me.LoadingControl1.Size = New System.Drawing.Size(45, 45)
        Me.LoadingControl1.TabIndex = 13
        Me.LoadingControl1.Visible = False
        '
        'LoadingForm
        '
        Me.Appearance.ForeColor = System.Drawing.Color.White
        Me.Appearance.Options.UseFont = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(735, 348)
        Me.Controls.Add(Me.GeneralPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconOptions.Icon = CType(resources.GetObject("LoadingForm.IconOptions.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "LoadingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GeneralPanel.ResumeLayout(False)
        Me.GeneralPanel.PerformLayout()
        CType(Me.PBNetwork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBKey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBChain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PBValidating As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents ValidatingProcess As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents GeneralPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PBChain As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PBKey As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LoadingControl1 As LoadingControl
    Friend WithEvents WalletConnector As Timer
    Friend WithEvents PBNetwork As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnRetry As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnExit As DevExpress.XtraEditors.SimpleButton
End Class
