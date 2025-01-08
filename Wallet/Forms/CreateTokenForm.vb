Imports System.Threading
Imports Newtonsoft.Json.Linq

Public Class CreateTokenForm
    Private _apiClient As New APIClient()
    Private _privateAddress As String


    Public Sub New(address As String)
        InitializeComponent()
        Dim publicKey As String = WalletHandler.GetPublicKeyFromPrivateKey(address)
        _privateAddress = address
        TBPublicAddress.Text = publicKey

        tim.Start()
    End Sub

    Private Sub tim_Tick(sender As Object, e As EventArgs) Handles tim.Tick
        tim.Stop()
        'MainFlowPanel.AutoScroll = True
        GeneralPanel.Visible = True
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Try
            ' Check if the API is reachable
            If _apiClient.IsConnectionFunctional() Then
                ' Get input values

                ' Construct the data to be signed (consistent with server-side)
                Dim dataToSign As String = $"{TBName.Text}:{TBSymbol.Text}:{TBSupply.Text}:{TBPublicAddress.Text}"
                ' Sign the data using the private key
                Dim signature As String = WalletHandler.SignTransaction(_privateAddress, dataToSign)

                ' Disable the button and start the loading animation
                BtnCreate.Enabled = False
                LoadingControl1.Start()
                LoadingControl1.Visible = True

                ' Start a new thread for the API call
                Dim thread As New Thread(Sub()
                                             Try
                                                 ' Create the token using the APIClient.CreateToken method
                                                 Dim response As JObject = _apiClient.CreateToken(TBName.Text, TBSymbol.Text, TBSupply.Text, TBPublicAddress.Text, signature)

                                                 ' Update UI on the main thread
                                                 Me.Invoke(Sub()
                                                               LoadingControl1.Visible = False
                                                               MessageBox.Show(response("message").ToString())
                                                               BtnCreate.Enabled = True ' Re-enable the button
                                                           End Sub)
                                             Catch ex As Exception
                                                 ' Update UI on the main thread
                                                 Me.Invoke(Sub()
                                                               LoadingControl1.Visible = False
                                                               MessageBox.Show($"Error creating token: {ex.Message}")
                                                               BtnCreate.Enabled = True ' Re-enable the button
                                                           End Sub)
                                             End Try
                                         End Sub)
                thread.Start()

            Else
                MessageBox.Show("Blockchain is not reachable. Please check the connection.")
            End If

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub
End Class