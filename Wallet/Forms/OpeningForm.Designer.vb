<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OpeningForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpeningForm))
        Me.GeneralPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnCreate = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnImport = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelTitleAllCoins = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GeneralPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GeneralPanel
        '
        Me.GeneralPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GeneralPanel.BackColor = System.Drawing.Color.Transparent
        Me.GeneralPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GeneralPanel.BorderRadius = 10
        Me.GeneralPanel.Controls.Add(Me.BtnCreate)
        Me.GeneralPanel.Controls.Add(Me.BtnImport)
        Me.GeneralPanel.Controls.Add(Me.Label1)
        Me.GeneralPanel.Controls.Add(Me.LabelTitleAllCoins)
        Me.GeneralPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GeneralPanel.Location = New System.Drawing.Point(38, 24)
        Me.GeneralPanel.Margin = New System.Windows.Forms.Padding(33, 15, 3, 3)
        Me.GeneralPanel.Name = "GeneralPanel"
        Me.GeneralPanel.ShadowDecoration.BorderRadius = 10
        Me.GeneralPanel.ShadowDecoration.Depth = 10
        Me.GeneralPanel.ShadowDecoration.Enabled = True
        Me.GeneralPanel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8, 4, 8, 10)
        Me.GeneralPanel.Size = New System.Drawing.Size(659, 363)
        Me.GeneralPanel.TabIndex = 4
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
        Me.BtnCreate.Location = New System.Drawing.Point(81, 265)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.BtnCreate.Size = New System.Drawing.Size(496, 45)
        Me.BtnCreate.TabIndex = 13
        Me.BtnCreate.Text = "Create a new wallet"
        '
        'BtnImport
        '
        Me.BtnImport.AllowFocus = False
        Me.BtnImport.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BtnImport.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnImport.Appearance.Options.UseBackColor = True
        Me.BtnImport.Appearance.Options.UseFont = True
        Me.BtnImport.AppearanceHovered.Options.UseBackColor = True
        Me.BtnImport.AppearancePressed.Options.UseBackColor = True
        Me.BtnImport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnImport.Location = New System.Drawing.Point(81, 133)
        Me.BtnImport.Name = "BtnImport"
        Me.BtnImport.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.BtnImport.Size = New System.Drawing.Size(496, 45)
        Me.BtnImport.TabIndex = 12
        Me.BtnImport.Text = "Import a wallet"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(313, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "OR"
        '
        'LabelTitleAllCoins
        '
        Me.LabelTitleAllCoins.AutoSize = True
        Me.LabelTitleAllCoins.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LabelTitleAllCoins.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitleAllCoins.Location = New System.Drawing.Point(11, 42)
        Me.LabelTitleAllCoins.Name = "LabelTitleAllCoins"
        Me.LabelTitleAllCoins.Size = New System.Drawing.Size(233, 37)
        Me.LabelTitleAllCoins.TabIndex = 5
        Me.LabelTitleAllCoins.Text = "Choose an option"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(110, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpeningForm
        '
        Me.Appearance.ForeColor = System.Drawing.Color.White
        Me.Appearance.Options.UseFont = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(735, 416)
        Me.Controls.Add(Me.GeneralPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("OpeningForm.IconOptions.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "OpeningForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose an option"
        Me.GeneralPanel.ResumeLayout(False)
        Me.GeneralPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GeneralPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelTitleAllCoins As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCreate As DevExpress.XtraEditors.SimpleButton
End Class
