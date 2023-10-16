Public Class DangNhap
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
        MessageBox.Show("Đăng Nhập Thành Công", "Thông Tin")
    End Sub
End Class