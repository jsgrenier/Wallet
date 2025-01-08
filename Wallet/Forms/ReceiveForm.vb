Imports System.Net
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports QRCoder

Public Class ReceiveForm
    Private WithEvents tim As New Timer()
    Private _apiClient As New APIClient()

    Public Sub New(address As String)
        InitializeComponent()
        TBPublicAddress.Text = address
    End Sub

    Private Sub ReceiveForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayTokensOwned(TBPublicAddress.Text)
        DisplayTransactionHistory(TBPublicAddress.Text)

        tim.Interval = 100
        tim.Start()
    End Sub

    Private Sub tim_Tick(sender As Object, e As EventArgs) Handles tim.Tick
        tim.Stop()
        'MainFlowPanel.AutoScroll = True
        GeneralPanel.Visible = True
        AllCoinsPanel.Visible = True
        HistoryPanel.Visible = True
    End Sub

    Private Sub CopyPublicAddress_Click(sender As Object, e As EventArgs) Handles CopyPublicAddress.Click
        Try
            TBPublicAddress.Focus()
            Clipboard.SetData(DataFormats.Text, TBPublicAddress.Text)
            TBPublicAddress.Focus()
            TBPublicAddress.SelectAll()
        Catch ex As Exception
            'MsgBox(ex.ToString(), MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub TBPublicAddress_TextChanged(sender As Object, e As EventArgs) Handles TBPublicAddress.TextChanged
        Dim qrGenerator As New QRCodeGenerator()
        Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode(TBPublicAddress.Text, QRCodeGenerator.ECCLevel.Q)

        Dim qrCode As New QRCode(qrCodeData)

        Dim moduleSize As Integer = 250 \ qrCodeData.ModuleMatrix.Count

        ' Get the QR code as a Bitmap
        Dim qrCodeImage As Bitmap = qrCode.GetGraphic(moduleSize)

        PBWalletQR.Image = qrCodeImage
    End Sub

    Private Sub DisplayTransactionHistory(address As String)
        ' Clear the existing controls
        HistoryFlowPanel.Controls.Clear()

        Try
            ' Encode the address before making the API call
            Dim encodedAddress As String = WebUtility.UrlEncode(address)

            ' Use the APIClient to make the GET request
            Dim jsonObject As JObject = _apiClient.Gett("/get_transaction_history", New Dictionary(Of String, String) From {{"address", encodedAddress}})

            Dim transactions As JArray = jsonObject("transactions")

            ' Sort history items by timestamp in descending order (most recent first)
            Dim sortedTransactions = transactions.OrderByDescending(Function(t) t("Timestamp")).ToList()

            ' Add sorted history items to the HistoryFlowPanel as CoinItem controls
            Dim transactionCount As Integer = 0

            For Each transaction In sortedTransactions
                If transactionCount >= 10 Then
                    Exit For
                End If

                Dim timestampValue = transaction("Timestamp")?.ToString()
                Dim amountValue = transaction("Amount")?.ToString()
                Dim hashValue = transaction("Hash")?.ToString()

                If timestampValue IsNot Nothing AndAlso amountValue IsNot Nothing AndAlso hashValue IsNot Nothing Then
                    Dim coinItem As New CoinItem() With {
                    .Timestamp = DateTime.Parse(timestampValue)
                }

                    ' Format the timestamp as "dd/MM/yyyy HH:mm:ss"
                    coinItem.LeftLabel.Text = coinItem.Timestamp.ToString("dd/MM/yyyy HH:mm:ss")
                    coinItem.RightLabel.Text = amountValue
                    coinItem.HashLabel.Text = hashValue
                    coinItem.PBExternal.Visible = True

                    HistoryFlowPanel.Controls.Add(coinItem)
                    transactionCount += 1
                Else
                    Console.WriteLine("Transaction data is incomplete.")
                End If
            Next

            ' Add a "View More" item if there are more than 10 transactions
            If sortedTransactions.Count > 10 Then
                Dim viewMoreItem As New CoinItem()
                viewMoreItem.HashLabel.Text = "View More"
                viewMoreItem.LeftLabel.Text = ""
                viewMoreItem.RightLabel.Text = ""
                viewMoreItem.Guna2Separator1.Visible = False
                HistoryFlowPanel.Controls.Add(viewMoreItem)
            End If

            ' Adjust the panel heights dynamically
            HistoryFlowPanel.Height = HistoryFlowPanel.Controls.Count * 44
            HistoryPanel.Height = 159 + HistoryFlowPanel.Height

        Catch ex As Exception
            ' Handle API call errors
            Console.WriteLine($"Error getting transaction history: {ex.Message}")
            ' You might want to display an error message to the user
        End Try
    End Sub


    Private Sub DisplayTokensOwned(address As String)
        CoinsFlowPanel.Controls.Clear()

        Try
            ' Encode the address
            Dim encodedAddress As String = WebUtility.UrlEncode(address)

            ' Use the APIClient to make the GET request for tokens owned
            Dim jsonObject As JObject = _apiClient.Gett("/get_tokens_owned", New Dictionary(Of String, String) From {{"address", encodedAddress}})
            Dim tokensOwned As JObject = jsonObject("tokensOwned")

            ' Fetch token names from the API
            Dim tokenNamesToken As JToken = _apiClient.Gett("/get_token_names")

            ' Ensure tokenNamesToken is a JArray
            If tokenNamesToken.Type = JTokenType.Array Then
                ' Convert the JArray into a dictionary for easy lookup
                Dim tokenNameDict As Dictionary(Of String, String) = tokenNamesToken.ToObject(Of JArray)() _
                .ToDictionary(Function(t) t("symbol").ToString(), Function(t) t("name").ToString())

                ' Sort tokens by their symbol
                Dim sortedTokens = tokensOwned.Properties().OrderBy(Function(p) p.Name)

                ' Display each token in the CoinsFlowPanel
                For Each token In sortedTokens
                    Dim tokenAmount As String
                    Dim amount As Decimal = token.Value.ToObject(Of Decimal)()

                    ' Format the token amount
                    tokenAmount = If(amount = Math.Floor(amount), CInt(amount).ToString(), amount.ToString())

                    ' Get the token name from the dictionary, or fallback to the symbol
                    Dim tokenName As String = If(tokenNameDict.ContainsKey(token.Name), tokenNameDict(token.Name), token.Name)

                    ' Create and add the token display item
                    Dim coinItem As New CoinItem()
                    coinItem.LeftLabel.Text = $"{tokenName} ({token.Name})"
                    coinItem.RightLabel.Text = $"{tokenAmount} {token.Name}"

                    CoinsFlowPanel.Controls.Add(coinItem)
                Next
            Else
                Throw New Exception("API response for /get_token_names is not a valid array.")
            End If

            ' Adjust panel heights dynamically
            CoinsFlowPanel.Height = CoinsFlowPanel.Controls.Count * 44
            AllCoinsPanel.Height = 159 + CoinsFlowPanel.Height
            GeneralPanel.Location = New Point(33, GeneralPanel.Location.Y)
            AllCoinsPanel.Location = New Point(33, AllCoinsPanel.Location.Y)
            HistoryPanel.Location = New Point(33, (AllCoinsPanel.Location.Y + AllCoinsPanel.Height) + 33)
            MainFlowPanel.Padding = New Padding(0, 0, 0, 40)

        Catch ex As Exception
            ' Handle any API call errors
            Console.WriteLine($"Error getting tokens owned: {ex.Message}")
        End Try
    End Sub
End Class