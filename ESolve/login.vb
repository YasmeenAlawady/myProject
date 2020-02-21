Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Panel1.BackColor = Color.FromArgb(175, 0, 0, 0)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class