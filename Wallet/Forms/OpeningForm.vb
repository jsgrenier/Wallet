Imports System.IO
Imports DevExpress.XtraEditors

Public Class OpeningForm
    Public isValid As Boolean = False

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub BtnImport_Click(sender As Object, e As EventArgs) Handles BtnImport.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Wallet Files (*.dat)|*.dat|All files (*.*)|*.*"
        openFileDialog.Title = "Select Wallet File"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName

            ' Prompt the user for the password
            Dim inputForm As New PasswordForm() ' Assuming you have an InputForm
            If inputForm.ShowDialog() = DialogResult.OK Then
                Dim password As String = inputForm.TBPassword.Text
                Try
                    ' Load and decrypt the private key using the provided password
                    Dim privateKey As String = WalletHandler.LoadWalletFromFile(filePath, password)

                    ' If decryption is successful, proceed
                    If privateKey IsNot Nothing Then
                        ' ... (rest of your import logic, e.g., display the key or use it in your application)
                        Dim _loadingForm As New LoadingForm(privateKey) ' Assuming LoadingForm takes the private key
                        Me.Hide()
                        _loadingForm.Show()
                    Else
                        MessageBox.Show("Incorrect password or invalid wallet file.")
                    End If

                Catch ex As Exception
                    MessageBox.Show($"Error importing wallet: {ex.Message}")
                End Try
            End If

        End If
    End Sub

    Public Sub OpenWallet(privateKey As String)
        Dim _walletForm As New WalletForm(privateKey)
        isValid = True
        Me.Hide()
        _walletForm.Show()
    End Sub

    Public Sub LoadWallet(privateKey As String)
        Dim _loadingForm As New LoadingForm(privateKey)

        Me.Hide()
        _loadingForm.Show()
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim _createWallet As New CreateWallet()

        Me.Hide()
        _createWallet.Show()
    End Sub

End Class