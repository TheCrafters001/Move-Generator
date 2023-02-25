Public Class codeList
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try

            ' Set dims for shortcuts
            Dim func As String = "..."
            Dim desc As String = "..."

            If ComboBox1.SelectedItem = "None" Then ' If it is set to 'None'
                func = "None"
                desc = "This does literally nothing. ^.^"

            ElseIf ComboBox1.SelectedItem = "Unimplemented" Then ' If it is set to 'Unimplemented'
                func = "Unimplemented"
                desc = "Superclass that handles moves using a non-existent function code." & vbCrLf &
                    "Damaging moves just do damage with no additional effect." & vbCrLf &
                    "Status moves always fail."

            Else ' If it isn't found in the list above.
                func = "Unknown"
                desc = "Sorry, I don't know that function code..."
            End If

            ' Use the dims set earlier to set the descriptions
            Label1.Text = func
            description_lbl.Text = desc

            ' Re-enable the Select button
            select_btn.Enabled = True

        Catch ex As Exception
            MessageBox.Show("crap." & vbCrLf & ex.Message, "Error")
        End Try
    End Sub

    Private Sub select_btn_Click(sender As Object, e As EventArgs) Handles select_btn.Click
        If Label1.Text = "Unimplemented" Then
            MessageBox.Show("You can't use an Unimplemented Function Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Form1.functionCode_txtBox.Text = ComboBox1.SelectedItem.Text
            Me.Close()
        End If
    End Sub
End Class