Imports Guna.UI2.WinForms

Public Class WalletForm
    Public currentChildformContentPanel As Form
    Private _privateAddress As String


    Public Sub New(privateAddress As String)
        InitializeComponent()
        _privateAddress = privateAddress
    End Sub
    Public Sub OpenChildFormContentPanel(childForm As Form)
        If currentChildformContentPanel IsNot Nothing Then
            currentChildformContentPanel.Close()
        End If
        currentChildformContentPanel = childForm
        'end
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        'childForm.Left = ContentPanel.Width / 2 - childForm.Width / 2 + 8
        'childForm.Top = 50
        'childForm.Anchor = AnchorStyles.Top
        'childForm.Location = New Point(Guna2Panel1.Location.X, childForm.Location.Y)
        ContentPanel.Controls.Add(childForm)
        ContentPanel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub WalletForm_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Guna2Panel1.Margin = New Padding(Me.Width - 659 / 2, 3, 3, 3)
        Console.WriteLine(Guna2Panel1.Location)
    End Sub
    Private _isUnlocked As Boolean = True
    Private Sub WalletForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If currentChildformContentPanel IsNot Nothing Then
            currentChildformContentPanel.Close()
        End If
        If _isUnlocked = False Then
            OpeningForm.Show()

        Else
            OpeningForm.Close()
        End If


    End Sub

    Private Sub BtnReceive_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnReceive.MouseDown
        If BtnReceive.Checked = False Then
            Dim publickey As String = WalletHandler.GetPublicKeyFromPrivateKey(_privateAddress)
            OpenChildFormContentPanel(New ReceiveForm(publickey))
        End If

    End Sub

    Private Sub BtnSend_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnSend.MouseDown
        If BtnSend.Checked = False Then
            OpenChildFormContentPanel(New SendForm(_privateAddress))
        End If
    End Sub

    Private Sub WalletForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim publickey As String = WalletHandler.GetPublicKeyFromPrivateKey(_privateAddress)
        OpenChildFormContentPanel(New ReceiveForm(publickey))
    End Sub

    Private Sub BtnLock_Click(sender As Object, e As EventArgs) Handles BtnLock.Click
        _privateAddress = String.Empty
        _isUnlocked = False
        Me.Close()
    End Sub

    Private Sub BtnCreate_mousedown(sender As Object, e As MouseEventArgs) Handles BtnCreate.MouseDown
        If BtnCreate.Checked = False Then
            OpenChildFormContentPanel(New CreateTokenForm(_privateAddress))
        End If
    End Sub

    Public Sub ConfirmTx(txID As String)
        OpenChildFormContentPanel(New ConfirmationForm(txID))

    End Sub
End Class