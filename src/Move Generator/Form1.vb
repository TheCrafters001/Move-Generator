Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        category_cmbBox.SelectedIndex = 0
        targets_cmbBox.SelectedIndex = 0
    End Sub

    Private Sub generate_btn_Click(sender As Object, e As EventArgs) Handles generate_btn.Click
        Generator.CreateMove()
    End Sub


    Private Sub addFlag_btn_Click(sender As Object, e As EventArgs) Handles addFlag_btn.Click
        Dim flag As String = InputBox("Please enter a Flag", "Flags")
        flag_lstBox.Items.Add(flag)
    End Sub

    Private Sub flag_lstBox_DoubleClick(sender As Object, e As EventArgs) Handles flag_lstBox.DoubleClick
        flag_lstBox.SelectedItems.Remove(flag_lstBox.SelectedItems)
    End Sub
End Class
