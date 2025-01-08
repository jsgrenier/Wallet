Public Class CreateWallet
    Private _isGoingToWallet As Boolean = False

    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles BtnGenerate.Click
        Dim walletInfo As Tuple(Of String, String) = WalletHandler.GenerateWallet(TBPassword.Text)
        Dim publicKey As String = walletInfo.Item1
        Dim privateKey As String = walletInfo.Item2


        ' Generate key pair
        'Dim keyPair As Tuple(Of String, String) = WalletHandler.GenerateKeyPair()
        'Dim publicKey As String = keyPair.Item2
        'Dim privateKey As String = keyPair.Item1


        ' Display keys in the form (use a TextBox or Label)
        TBPublicAddress.Text = publicKey
        TBPrivateAddress.Text = privateKey

    End Sub

    Private Sub CreateWallet_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If _isGoingToWallet = False Then
            OpeningForm.Show()
        End If


    End Sub

    Private Sub BtnWallet_Click(sender As Object, e As EventArgs) Handles BtnWallet.Click
        _isGoingToWallet = True
        OpeningForm.LoadWallet(TBPrivateAddress.Text)
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ' Now, use SaveFileDialog to let the user choose where to save
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Wallet Files (*.dat)|*.dat"
        saveFileDialog.Title = "Save Wallet"
        saveFileDialog.FileName = "wallet.dat"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName

            ' Save the wallet to the chosen file path
            If WalletHandler.SaveWalletToFile(TBPrivateAddress.Text, filePath, TBPassword.Text) Then
                MessageBox.Show("Wallet created and saved successfully!")
            Else
                MessageBox.Show("Error saving wallet to file.")
            End If
        End If

    End Sub
End Class