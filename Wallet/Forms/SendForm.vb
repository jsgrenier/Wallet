Imports Newtonsoft.Json.Linq
Imports System.Net
Imports System.Security.Claims
Imports System.Security.Cryptography.X509Certificates
Imports System.Threading

Public Class SendForm
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

    Private Sub SendForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTokensOwned()
    End Sub

    Private Sub UpdateTokensOwned()
        Try
            ' Fetch tokens owned via the API
            Dim encodedAddress As String = WebUtility.UrlEncode(TBPublicAddress.Text)
            Console.WriteLine(encodedAddress)
            Dim jsonObject As JObject = _apiClient.Gett("/get_tokens_owned", New Dictionary(Of String, String) From {{"address", encodedAddress}})
            Dim tokensOwned As JObject = jsonObject("tokensOwned")

            CBTokens.Items.Clear()

            ' Sort tokens and populate the combobox
            Dim sortedTokens = tokensOwned.Properties().OrderBy(Function(p) p.Name)
            For Each token In sortedTokens
                Dim amount As Decimal = token.Value.ToObject(Of Decimal)()
                CBTokens.Items.Add($"{token.Name} ({amount})")
            Next
            GeneralPanel.Location = New Point(33, 15)
            If CBTokens.Items.Count > 0 Then CBTokens.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show($"Error loading tokens: {ex.Message}")
        End Try
    End Sub



    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        Try
            If _apiClient.IsConnectionFunctional() Then
                ' Get input values
                Dim fromPrivateKey As String = _privateAddress
                Dim fromPublicKey As String = TBPublicAddress.Text
                Dim toPublicKey As String = TBDestinationAddress.Text
                Dim amount As String = TBAmount.Text ' Keep amount as string for validation

                ' Extract token symbol from combobox selection
                Dim selectedItem = CBTokens.SelectedItem.ToString()
                Dim tokenSymbol As String = selectedItem.Substring(0, selectedItem.IndexOf(" "))

                ' Validate input fields
                If String.IsNullOrWhiteSpace(fromPublicKey) OrElse
               String.IsNullOrWhiteSpace(toPublicKey) OrElse
               String.IsNullOrWhiteSpace(amount) Then
                    MessageBox.Show("Please fill in all the required fields.")
                    Return
                End If

                ' Convert amount to decimal after validation
                Dim amountDecimal As Decimal
                If Not Decimal.TryParse(amount, amountDecimal) Then
                    MessageBox.Show("Please enter a valid amount.")
                    Return
                End If

                ' Construct the transaction data string (same format as server-side)
                Dim transactionData As String = $"{fromPublicKey}:{toPublicKey}:{amount}:{tokenSymbol}"

                ' Sign the transaction data using the user's private key
                Dim signature As String = WalletHandler.SignTransaction(_privateAddress, transactionData)

                BtnSend.Enabled = False
                LabelTransaction.ForeColor = Color.FromArgb(238, 164, 31)
                LabelTransaction.Text = "Validating..."

                LoadingControl1.Start()
                LoadingControl1.Visible = True

                ' Start a new thread for the API call
                Dim thread As New Thread(Sub()
                                             Try
                                                 ' Send transfer request to the API
                                                 Dim response As JObject = _apiClient.TransferTokens(fromPublicKey, toPublicKey, amount, tokenSymbol, signature)

                                                 ' Update UI on the main thread
                                                 Me.Invoke(Sub()
                                                               LoadingControl1.Visible = False
                                                               LabelTransaction.ForeColor = Color.FromArgb(167, 209, 74)
                                                               LabelTransaction.Text = response("message").ToString()
                                                               TextBox1.Text = response("txId").ToString()
                                                               BtnSend.Enabled = True ' Re-enable the button
                                                               UpdateTokensOwned()
                                                           End Sub)
                                             Catch ex As Exception
                                                 ' Update UI on the main thread
                                                 Me.Invoke(Sub()
                                                               LoadingControl1.Visible = False
                                                               LabelTransaction.ForeColor = Color.FromArgb(167, 209, 74)
                                                               LabelTransaction.Text = ex.Message
                                                               BtnSend.Enabled = True ' Re-enable the button
                                                           End Sub)
                                             End Try
                                         End Sub)
                thread.Start()
            Else
                MessageBox.Show("Blockchain is not reachable. Please check the connection")
            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Sub

End Class
