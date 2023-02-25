Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        category_cmbBox.SelectedIndex = 0
        targets_cmbBox.SelectedIndex = 0
    End Sub

    Private Sub generate_btn_Click(sender As Object, e As EventArgs) Handles generate_btn.Click
        If ess17Enable_chkBox.Checked = True Then
            Generator.CreateMove17()
        ElseIf ess17Enable_chkBox.Checked = False Then
            Generator.CreateMove18()
        End If
    End Sub


    Private Sub addFlag_btn_Click(sender As Object, e As EventArgs) Handles addFlag_btn.Click
        Dim flag As String = InputBox("Please enter a Flag", "Flags")
        flag_lstBox.Items.Add(flag)
    End Sub

    Private Sub flag_lstBox_DoubleClick(sender As Object, e As EventArgs) Handles flag_lstBox.DoubleClick
        flag_lstBox.SelectedItems.Remove(flag_lstBox.SelectedItems)
    End Sub

    Private Sub ess17Enable_chkBox_CheckedChanged(sender As Object, e As EventArgs) Handles ess17Enable_chkBox.CheckedChanged

        ' This just checks to see if the checkbox is checked.
        ' Once it is, disable the original Function Code Box, then
        ' enable the essentials 17 group.
        If ess17Enable_chkBox.Checked = True Then
            functionCode_lbl.Enabled = False
            functionCode_txtBox.Enabled = False

            ess17Specific_grp.Enabled = True

            ' This is just the same thing as above but backwards.
        ElseIf ess17Enable_chkBox.Checked = False Then
            functionCode_lbl.Enabled = True
            functionCode_txtBox.Enabled = True

            ess17Specific_grp.Enabled = False
        End If

    End Sub

    Private Sub codeList_btn_Click(sender As Object, e As EventArgs) Handles codeList_btn.Click
        codeList.Show()
    End Sub
End Class
