Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        category_cmbBox.SelectedIndex = 0
        targets_cmbBox.SelectedIndex = 0
    End Sub

    Private Sub generate_btn_Click(sender As Object, e As EventArgs) Handles generate_btn.Click
        Generator.CreateMove()
    End Sub
End Class
