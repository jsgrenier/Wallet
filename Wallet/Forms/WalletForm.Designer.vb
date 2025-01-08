<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WalletForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WalletForm))
        Me.MainPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.ContentPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.NavPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnLock = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnReceive = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnSend = New Guna.UI2.WinForms.Guna2Button()
        Me.MainPanel.SuspendLayout()
        Me.NavPanel.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MainPanel.Controls.Add(Me.ContentPanel)
        Me.MainPanel.Controls.Add(Me.NavPanel)
        Me.MainPanel.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(735, 793)
        Me.MainPanel.TabIndex = 0
        '
        'ContentPanel
        '
        Me.ContentPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPanel.Location = New System.Drawing.Point(0, 67)
        Me.ContentPanel.MinimumSize = New System.Drawing.Size(725, 300)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.Size = New System.Drawing.Size(735, 726)
        Me.ContentPanel.TabIndex = 1
        '
        'NavPanel
        '
        Me.NavPanel.Controls.Add(Me.Guna2Panel1)
        Me.NavPanel.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.NavPanel.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.NavPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.NavPanel.Location = New System.Drawing.Point(0, 0)
        Me.NavPanel.MinimumSize = New System.Drawing.Size(715, 67)
        Me.NavPanel.Name = "NavPanel"
        Me.NavPanel.ShadowDecoration.BorderRadius = 0
        Me.NavPanel.ShadowDecoration.Depth = 8
        Me.NavPanel.ShadowDecoration.Enabled = True
        Me.NavPanel.Size = New System.Drawing.Size(735, 67)
        Me.NavPanel.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel1.Controls.Add(Me.BtnCreate)
        Me.Guna2Panel1.Controls.Add(Me.BtnLock)
        Me.Guna2Panel1.Controls.Add(Me.BtnReceive)
        Me.Guna2Panel1.Controls.Add(Me.BtnSend)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(46, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(643, 66)
        Me.Guna2Panel1.TabIndex = 2
        '
        'BtnCreate
        '
        Me.BtnCreate.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnCreate.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.BtnCreate.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCreate.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnCreate.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.BtnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCreate.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnCreate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreate.ForeColor = System.Drawing.Color.White
        Me.BtnCreate.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.BtnCreate.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnCreate.Location = New System.Drawing.Point(437, 0)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.PressedDepth = 0
        Me.BtnCreate.Size = New System.Drawing.Size(103, 66)
        Me.BtnCreate.TabIndex = 3
        Me.BtnCreate.Text = "Create a token"
        '
        'BtnLock
        '
        Me.BtnLock.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.BtnLock.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnLock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLock.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnLock.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.BtnLock.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnLock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnLock.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnLock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnLock.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnLock.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLock.ForeColor = System.Drawing.Color.White
        Me.BtnLock.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.BtnLock.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnLock.Location = New System.Drawing.Point(540, 0)
        Me.BtnLock.Name = "BtnLock"
        Me.BtnLock.PressedDepth = 0
        Me.BtnLock.Size = New System.Drawing.Size(103, 66)
        Me.BtnLock.TabIndex = 2
        Me.BtnLock.Text = "Lock Wallet"
        '
        'BtnReceive
        '
        Me.BtnReceive.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnReceive.Checked = True
        Me.BtnReceive.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.BtnReceive.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnReceive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReceive.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnReceive.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.BtnReceive.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnReceive.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnReceive.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnReceive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnReceive.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnReceive.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReceive.ForeColor = System.Drawing.Color.White
        Me.BtnReceive.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.BtnReceive.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnReceive.Location = New System.Drawing.Point(0, 0)
        Me.BtnReceive.Name = "BtnReceive"
        Me.BtnReceive.PressedDepth = 0
        Me.BtnReceive.Size = New System.Drawing.Size(103, 66)
        Me.BtnReceive.TabIndex = 0
        Me.BtnReceive.Text = "Receive"
        '
        'BtnSend
        '
        Me.BtnSend.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnSend.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.BtnSend.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSend.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnSend.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.BtnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnSend.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnSend.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSend.ForeColor = System.Drawing.Color.White
        Me.BtnSend.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.BtnSend.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnSend.Location = New System.Drawing.Point(103, 0)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.PressedDepth = 0
        Me.BtnSend.Size = New System.Drawing.Size(103, 66)
        Me.BtnSend.TabIndex = 1
        Me.BtnSend.Text = "Send"
        '
        'WalletForm
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 793)
        Me.Controls.Add(Me.MainPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconOptions.Icon = CType(resources.GetObject("WalletForm.IconOptions.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(737, 450)
        Me.Name = "WalletForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wallet"
        Me.MainPanel.ResumeLayout(False)
        Me.NavPanel.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents NavPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnReceive As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnSend As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ContentPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnLock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnCreate As Guna.UI2.WinForms.Guna2Button
End Class
