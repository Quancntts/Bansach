Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pic1.Click

    End Sub

    Private Sub pic1_MouseEnter(sender As Object, e As EventArgs) Handles pic1.MouseEnter
    End Sub

    Private Sub pic1_MouseLeave(sender As Object, e As EventArgs) Handles pic1.MouseLeave
    End Sub

    Private Sub pic1_MouseHover(sender As Object, e As EventArgs) Handles pic1.MouseHover
        pic1.Image = New Bitmap("C:\New folder\images (1).jpghh.jpg")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pic1_MouseLeave(sender, e)
    End Sub

    Private Sub Form1_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        pic1.Image = New Bitmap("C:\New folder\images.jpg")
    End Sub

    Private Sub ĐăngNhâpjToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngNhâpjToolStripMenuItem.Click
        Me.Hide()
        DangNhap.Show()
    End Sub
End Class
