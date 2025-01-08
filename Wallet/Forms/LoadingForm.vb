Public Class LoadingForm
    Private _privateKey As String
    Private _isChainValid As Boolean = False
    Private _isKeyValid As Boolean = False
    Private _apiClient As New APIClient()

    Public Sub New(privateKey As String)
        InitializeComponent()
        _privateKey = privateKey
    End Sub

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub LoadingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ValidatingProcess.Start()
    End Sub

    Private Sub ValidatingProcess_Tick(sender As Object, e As EventArgs) Handles ValidatingProcess.Tick
        PBValidating.Increment(2)
    End Sub



    Private Sub PBValidating_ValueChanged(sender As Object, e As EventArgs) Handles PBValidating.ValueChanged
        Select Case PBValidating.value
            Case 30
                ValidatingProcess.Stop()
                If _apiClient.IsConnectionFunctional = False Then
                    PBNetwork.Image = My.Resources.error_red
                    ShowError("network", "Blockchain is not accessible")
                    Exit Sub
                Else
                    PBNetwork.Image = My.Resources.checkmark_blue
                End If

                ValidatingProcess.Start()

            Case 60
                ValidatingProcess.Stop()
                'We need to fix this, it always return False (server sided)
                If _apiClient.CheckBlockchainValidity = False Then
                    PBChain.Image = My.Resources.error_red
                    'ShowError("chain", "Blockchain is not valid")
                    'Exit Sub
                Else
                    PBChain.Image = My.Resources.checkmark_blue
                End If

                ValidatingProcess.Start()

            Case 80
                ValidatingProcess.Stop()
                If WalletHandler.GetPublicKeyFromPrivateKey(_privateKey).Contains("Invalid format") Then
                    PBKey.Image = My.Resources.error_red
                    ShowError("key", "Private key has the wrong format")
                Else
                    PBKey.Image = My.Resources.checkmark_blue
                End If

                ValidatingProcess.Start()


            Case 100
                ValidatingProcess.Stop()
                LabelTitle.Text = "Loading your wallet..."
                LoadingControl1.Start()
                LoadingControl1.Visible = True

                WalletConnector.Start()

        End Select
    End Sub

    Private Sub ShowError(type As String, errorString As String)
        LabelTitle.ForeColor = Color.FromArgb(250, 82, 82)
        LabelTitle.Text = "Operation was cancelled"
        Select Case type
            Case "network"
                Console.WriteLine(errorString)

            Case "chain"
                Console.WriteLine(errorString)

            Case "key"
                Console.WriteLine(errorString)
        End Select

        BtnExit.Visible = True
        BtnRetry.Visible = True

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub LoadingForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If OpeningForm.isValid = False Then
            OpeningForm.Show()
        End If
        WalletConnector.Stop()
    End Sub

    Private Sub WalletConnector_Tick(sender As Object, e As EventArgs) Handles WalletConnector.Tick
        WalletConnector.Stop()
        OpeningForm.OpenWallet(_privateKey)
        Me.Close()
    End Sub

    Private Sub BtnRetry_Click(sender As Object, e As EventArgs) Handles BtnRetry.Click
        Me.Close()
        OpeningForm.LoadWallet(_privateKey)
    End Sub
End Class