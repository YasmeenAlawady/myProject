Public Class HomePage

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles MemberPanel.Paint
        ' MemberPanel.BackColor = Color.FromArgb(175, 90, 0, 30)
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        'If LogRB.Checked = True Then
        '    SettingPanel.Visible = False
        '    MemberPanel.Visible = True
        'ElseIf LogRB.Checked = False Then
        '    SettingPanel.Location = MemberPanel.Location
        '    SettingPanel.Visible = True
        'End If

    End Sub

    Private Sub SettingRB_CheckedChanged(sender As Object, e As EventArgs)
        'If SettingRB.Checked = True Then
        '    SettingPanel.Location = MemberPanel.Location
        '    MemberPanel.Visible = False
        '    SettingPanel.Visible = True

        'ElseIf SettingRB.Checked = False Then
        '    MemberPanel.Location = SettingPanel.Location
        '    MemberPanel.Visible = True
        'End If

    End Sub

    Private Sub SettingPanel_Paint(sender As Object, e As PaintEventArgs) Handles SettingPanel.Paint
        '  SettingPanel.BackColor = Color.FromArgb(175, 90, 0, 30)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        login.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        login.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        addnews.Show()

    End Sub
End Class
