<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class codeList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.description_lbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.functon_lbl = New System.Windows.Forms.Label()
        Me.select_btn = New System.Windows.Forms.Button()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 53)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Function Code Select"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"None", "DoesNothingCongratulations", "DoesNothingFailsIfNoAlly", "DoesNothingUnusableInGravity", "AddMoneyGainedFromBattle", "DoubleMoneyGainedFromBattle", "FailsIfNotUserFirstTurn", "FailsIfUserHasUnusedMove", "FailsIfUserNotConsumedBerry", "FailsIfTargetHasNoItem", "FailsUnlessTargetSharesTypeWithUser", "FailsIfUserDamagedThisTurn", "FailsIfTargetActed", "CrashDamageIfFailsUnusableInGravity", "StartSunWeather", "StartRainWeather", "StartSandstormWeather", "StartHailWeather", "StartElectricTerrain", "StartGrassyTerrain", "StartMistyTerrain", "StartPsychicTerrain", "RemoveTerrain", "AddSpikesToFoeSide", "AddToxicSpikesToFoeSide", "AddStealthRocksToFoeSide", "AddStickyWebToFoeSide", "SwapSideEffects", "UserMakeSubstitute", "RemoveUserBindingAndEntryHazards", "AttackTwoTurnsLater", "UserSwapsPositionsWithAlly", "BurnAttackerBeforeUserActs", "RaiseUserAttack1", "RaiseUserAttack2", "RaiseUserAttack2IfTargetFaints", "RaiseUserAttack3", "RaiseUserAttack3IfTargetFaints", "MaxUserAttackLoseHalfOfTotalHP", "RaiseUserDefense1", "RaiseUserDefense1CurlUpUser", "RaiseUserDefense2", "RaiseUserDefense3", "RaiseUserSpAtk1", "RaiseUserSpAtk2", "RaiseUserSpAtk3", "RaiseUserSpDef1"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(398, 23)
        Me.ComboBox1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.description_lbl)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.functon_lbl)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(410, 176)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Function Code Description"
        '
        'description_lbl
        '
        Me.description_lbl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.description_lbl.Location = New System.Drawing.Point(6, 34)
        Me.description_lbl.Name = "description_lbl"
        Me.description_lbl.Size = New System.Drawing.Size(398, 139)
        Me.description_lbl.TabIndex = 2
        Me.description_lbl.Text = "Please select a function code above."
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(70, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Unknown"
        '
        'functon_lbl
        '
        Me.functon_lbl.AutoSize = True
        Me.functon_lbl.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.functon_lbl.Location = New System.Drawing.Point(6, 19)
        Me.functon_lbl.Name = "functon_lbl"
        Me.functon_lbl.Size = New System.Drawing.Size(58, 15)
        Me.functon_lbl.TabIndex = 0
        Me.functon_lbl.Text = "Function:"
        '
        'select_btn
        '
        Me.select_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.select_btn.Enabled = False
        Me.select_btn.Location = New System.Drawing.Point(347, 253)
        Me.select_btn.Name = "select_btn"
        Me.select_btn.Size = New System.Drawing.Size(75, 23)
        Me.select_btn.TabIndex = 2
        Me.select_btn.Text = "Select"
        Me.select_btn.UseVisualStyleBackColor = True
        '
        'cancel_btn
        '
        Me.cancel_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancel_btn.Location = New System.Drawing.Point(12, 253)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(75, 23)
        Me.cancel_btn.TabIndex = 3
        Me.cancel_btn.Text = "&Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = True
        '
        'codeList
        '
        Me.AcceptButton = Me.select_btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cancel_btn
        Me.ClientSize = New System.Drawing.Size(434, 288)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.select_btn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "codeList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Function Codes Selector"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents description_lbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents functon_lbl As Label
    Friend WithEvents select_btn As Button
    Friend WithEvents cancel_btn As Button
End Class
