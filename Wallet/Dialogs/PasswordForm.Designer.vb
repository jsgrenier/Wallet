<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasswordForm))
        Me.GeneralPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnUnlock = New Guna.UI2.WinForms.Guna2Button()
        Me.TBPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LabelTitleAllCoins = New System.Windows.Forms.Label()
        Me.GeneralPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GeneralPanel
        '
        Me.GeneralPanel.BackColor = System.Drawing.Color.Transparent
        Me.GeneralPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GeneralPanel.BorderRadius = 10
        Me.GeneralPanel.Controls.Add(Me.BtnUnlock)
        Me.GeneralPanel.Controls.Add(Me.TBPassword)
        Me.GeneralPanel.Controls.Add(Me.LabelTitleAllCoins)
        Me.GeneralPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GeneralPanel.Location = New System.Drawing.Point(38, 20)
        Me.GeneralPanel.Margin = New System.Windows.Forms.Padding(33, 15, 3, 3)
        Me.GeneralPanel.Name = "GeneralPanel"
        Me.GeneralPanel.ShadowDecoration.BorderRadius = 10
        Me.GeneralPanel.ShadowDecoration.Depth = 10
        Me.GeneralPanel.ShadowDecoration.Enabled = True
        Me.GeneralPanel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8, 4, 8, 10)
        Me.GeneralPanel.Size = New System.Drawing.Size(559, 270)
        Me.GeneralPanel.TabIndex = 4
        '
        'BtnUnlock
        '
        Me.BtnUnlock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnUnlock.BorderRadius = 6
        Me.BtnUnlock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUnlock.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnUnlock.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnUnlock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnUnlock.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUnlock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnUnlock.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BtnUnlock.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUnlock.ForeColor = System.Drawing.Color.White
        Me.BtnUnlock.Location = New System.Drawing.Point(418, 185)
        Me.BtnUnlock.Name = "BtnUnlock"
        Me.BtnUnlock.PressedDepth = 0
        Me.BtnUnlock.Size = New System.Drawing.Size(109, 45)
        Me.BtnUnlock.TabIndex = 17
        Me.BtnUnlock.Text = "Unlock"
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
        Me.TBPassword.Location = New System.Drawing.Point(31, 110)
        Me.TBPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TBPassword.PlaceholderText = ""
        Me.TBPassword.SelectedText = ""
        Me.TBPassword.Size = New System.Drawing.Size(496, 45)
        Me.TBPassword.TabIndex = 16
        Me.TBPassword.TextOffset = New System.Drawing.Point(10, 0)
        Me.TBPassword.UseSystemPasswordChar = True
        '
        'LabelTitleAllCoins
        '
        Me.LabelTitleAllCoins.AutoSize = True
        Me.LabelTitleAllCoins.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LabelTitleAllCoins.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitleAllCoins.Location = New System.Drawing.Point(11, 42)
        Me.LabelTitleAllCoins.Name = "LabelTitleAllCoins"
        Me.LabelTitleAllCoins.Size = New System.Drawing.Size(267, 37)
        Me.LabelTitleAllCoins.TabIndex = 5
        Me.LabelTitleAllCoins.Text = "Enter your password"
        '
        'PasswordForm
        '
        Me.AcceptButton = Me.BtnUnlock
        Me.Appearance.ForeColor = System.Drawing.Color.White
        Me.Appearance.Options.UseFont = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 313)
        Me.Controls.Add(Me.GeneralPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("PasswordForm.IconOptions.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "PasswordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter your password"
        Me.GeneralPanel.ResumeLayout(False)
        Me.GeneralPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GeneralPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LabelTitleAllCoins As Label
    Friend WithEvents TBPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnUnlock As Guna.UI2.WinForms.Guna2Button
End Class
