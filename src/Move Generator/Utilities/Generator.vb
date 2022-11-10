Public Class Generator

    Public Shared Sub CreateMove()
        Form1.output_txtBox.Text = ""

        Dim internalName As String = ""
        Dim displayName As String = ""
        Dim moveType As String = ""
        Dim moveCategory As String = ""
        Dim movePower As String = ""
        Dim moveAccuracy As String = ""
        Dim totalPP As String = ""
        Dim moveTargets As String = ""
        Dim movePriority As String = ""
        Dim functionCode As String = ""
        Dim moveFlags As String = ""
        Dim effectChance As String = ""
        Dim description As String = ""
        Dim output As String = ""

        If Form1.internalName_txtBox.Text = "" Then
            MessageBox.Show("You need to enter a Internal Move Name.", "Cannot Create Move", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Form1.inGameName_txtBox.Text = "" Then
            MessageBox.Show("You need to enter a In-Game Move Name.", "Cannot Create Move", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Form1.type_cmbBox.Text = "" Then
            MessageBox.Show("You need to enter a Typing.", "Cannot Create Move", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Form1.power_txtBox.Text = "" Then
            MessageBox.Show("You need to enter a Power.", "Cannot Create Move", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Form1.acuracy_txtBox.Text = "" Then
            MessageBox.Show("You need to enter an Accuracy.", "Cannot Create Move", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Form1.totalPP_txtBox.Text = "" Then
            MessageBox.Show("You need to enter a Power.", "Cannot Create Move", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Form1.description_txtBox.Text = "" Then
            MessageBox.Show("You need to enter a Description.", "Cannot Create Move", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                internalName = "[" & Form1.internalName_txtBox.Text.ToUpper & "]" & vbCrLf
                displayName = "Name = " & Form1.inGameName_txtBox.Text & vbCrLf
                moveType = "Type = " & Form1.type_cmbBox.Text.ToUpper & vbCrLf
                moveCategory = "Category = " & Form1.category_cmbBox.Text & vbCrLf
                movePower = "Power = " & Form1.power_txtBox.Text & vbCrLf
                moveAccuracy = "Accuracy = " & Form1.acuracy_txtBox.Text & vbCrLf
                totalPP = "TotalPP = " & Form1.totalPP_txtBox.Text & vbCrLf
                moveTargets = "Target = " & Form1.targets_cmbBox.Text & vbCrLf
                movePriority = "Priority = " & Form1.priority_txtBox.Text & vbCrLf
                functionCode = "FunctionCode = " & Form1.functionCode_txtBox.Text & vbCrLf
                moveFlags = "Flags = "

                Try
                    ' Flag Handler
                    For Each move In Form1.flag_lstBox.Items
                        moveFlags &= move.ToString & ","
                    Next

                    moveFlags = moveFlags.Substring(0, moveFlags.Length - 1)
                Catch ex As Exception
                    Debug.WriteLine("Ignoring Flags")
                End Try

                effectChance = "EffectChance = " & Form1.effectChance_txtBox.Text & vbCrLf
                description = "Description = " & Form1.description_txtBox.Text

                output = internalName & displayName & moveType & moveCategory & movePower & moveAccuracy & totalPP & moveTargets &
                    movePriority & functionCode & moveFlags & vbCrLf & effectChance & description

                Form1.output_txtBox.Text = output

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

End Class
