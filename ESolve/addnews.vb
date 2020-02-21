Public Class addnews

    Private Sub addnews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label9.Text = Date.Now.ToString(" dd-MMM-yyyy ")
        Label8.Text = Date.Now.ToString("hh:mm:ss")
    End Sub
End Class