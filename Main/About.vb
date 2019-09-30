Public Class About
    'opens a link to the source of the icon image
    Private Sub lnklblIcon_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblIcon.LinkClicked
        System.Diagnostics.Process.Start("http://www.flaticon.com")
    End Sub
    'hides this window
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub
End Class
