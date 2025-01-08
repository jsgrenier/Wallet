Public Class PasswordForm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnUnlock_Click(sender As Object, e As EventArgs) Handles BtnUnlock.Click
        DialogResult = DialogResult.OK
    End Sub
End Class