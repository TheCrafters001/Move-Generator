<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pg_MoveInfo = New System.Windows.Forms.TabPage()
        Me.description_txtBox = New System.Windows.Forms.RichTextBox()
        Me.description_lbl = New System.Windows.Forms.Label()
        Me.effectChance_txtBox = New System.Windows.Forms.TextBox()
        Me.effectChance_lbl = New System.Windows.Forms.Label()
        Me.flags_grpBox = New System.Windows.Forms.GroupBox()
        Me.addFlag_btn = New System.Windows.Forms.Button()
        Me.flag_lstBox = New System.Windows.Forms.ListBox()
        Me.functionCode_txtBox = New System.Windows.Forms.TextBox()
        Me.functionCode_lbl = New System.Windows.Forms.Label()
        Me.priority_txtBox = New System.Windows.Forms.TextBox()
        Me.priority_lbl = New System.Windows.Forms.Label()
        Me.targets_cmbBox = New System.Windows.Forms.ComboBox()
        Me.targets_lbl = New System.Windows.Forms.Label()
        Me.totalPP_txtBox = New System.Windows.Forms.TextBox()
        Me.totalPP_lbl = New System.Windows.Forms.Label()
        Me.acuracy_txtBox = New System.Windows.Forms.TextBox()
        Me.accuracy_lbl = New System.Windows.Forms.Label()
        Me.power_txtBox = New System.Windows.Forms.TextBox()
        Me.power_lbl = New System.Windows.Forms.Label()
        Me.category_cmbBox = New System.Windows.Forms.ComboBox()
        Me.category_lbl = New System.Windows.Forms.Label()
        Me.type_cmbBox = New System.Windows.Forms.ComboBox()
        Me.type_lbl = New System.Windows.Forms.Label()
        Me.inGameName_txtBox = New System.Windows.Forms.TextBox()
        Me.inGameName_lbl = New System.Windows.Forms.Label()
        Me.internalName_txtBox = New System.Windows.Forms.TextBox()
        Me.internalName_lbl = New System.Windows.Forms.Label()
        Me.pg_Output = New System.Windows.Forms.TabPage()
        Me.output_txtBox = New System.Windows.Forms.RichTextBox()
        Me.generate_btn = New System.Windows.Forms.Button()
        Me.pg_About = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.pg_MoveInfo.SuspendLayout()
        Me.flags_grpBox.SuspendLayout()
        Me.pg_Output.SuspendLayout()
        Me.pg_About.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.pg_MoveInfo)
        Me.TabControl1.Controls.Add(Me.pg_Output)
        Me.TabControl1.Controls.Add(Me.pg_About)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(611, 450)
        Me.TabControl1.TabIndex = 0
        '
        'pg_MoveInfo
        '
        Me.pg_MoveInfo.Controls.Add(Me.description_txtBox)
        Me.pg_MoveInfo.Controls.Add(Me.description_lbl)
        Me.pg_MoveInfo.Controls.Add(Me.effectChance_txtBox)
        Me.pg_MoveInfo.Controls.Add(Me.effectChance_lbl)
        Me.pg_MoveInfo.Controls.Add(Me.flags_grpBox)
        Me.pg_MoveInfo.Controls.Add(Me.functionCode_txtBox)
        Me.pg_MoveInfo.Controls.Add(Me.functionCode_lbl)
        Me.pg_MoveInfo.Controls.Add(Me.priority_txtBox)
        Me.pg_MoveInfo.Controls.Add(Me.priority_lbl)
        Me.pg_MoveInfo.Controls.Add(Me.targets_cmbBox)
        Me.pg_MoveInfo.Controls.Add(Me.targets_lbl)
        Me.pg_MoveInfo.Controls.Add(Me.totalPP_txtBox)
        Me.pg_MoveInfo.Controls.Add(Me.totalPP_lbl)
        Me.pg_MoveInfo.Controls.Add(Me.acuracy_txtBox)
        Me.pg_MoveInfo.Controls.Add(Me.accuracy_lbl)
        Me.pg_MoveInfo.Controls.Add(Me.power_txtBox)
        Me.pg_MoveInfo.Controls.Add(Me.power_lbl)
        Me.pg_MoveInfo.Controls.Add(Me.category_cmbBox)
        Me.pg_MoveInfo.Controls.Add(Me.category_lbl)
        Me.pg_MoveInfo.Controls.Add(Me.type_cmbBox)
        Me.pg_MoveInfo.Controls.Add(Me.type_lbl)
        Me.pg_MoveInfo.Controls.Add(Me.inGameName_txtBox)
        Me.pg_MoveInfo.Controls.Add(Me.inGameName_lbl)
        Me.pg_MoveInfo.Controls.Add(Me.internalName_txtBox)
        Me.pg_MoveInfo.Controls.Add(Me.internalName_lbl)
        Me.pg_MoveInfo.Location = New System.Drawing.Point(4, 24)
        Me.pg_MoveInfo.Name = "pg_MoveInfo"
        Me.pg_MoveInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.pg_MoveInfo.Size = New System.Drawing.Size(603, 422)
        Me.pg_MoveInfo.TabIndex = 0
        Me.pg_MoveInfo.Text = "Move Information"
        Me.pg_MoveInfo.UseVisualStyleBackColor = True
        '
        'description_txtBox
        '
        Me.description_txtBox.Location = New System.Drawing.Point(209, 274)
        Me.description_txtBox.Name = "description_txtBox"
        Me.description_txtBox.Size = New System.Drawing.Size(255, 128)
        Me.description_txtBox.TabIndex = 24
        Me.description_txtBox.Text = ""
        '
        'description_lbl
        '
        Me.description_lbl.AutoSize = True
        Me.description_lbl.Location = New System.Drawing.Point(209, 256)
        Me.description_lbl.Name = "description_lbl"
        Me.description_lbl.Size = New System.Drawing.Size(67, 15)
        Me.description_lbl.TabIndex = 23
        Me.description_lbl.Text = "Description"
        '
        'effectChance_txtBox
        '
        Me.effectChance_txtBox.Location = New System.Drawing.Point(209, 230)
        Me.effectChance_txtBox.Name = "effectChance_txtBox"
        Me.effectChance_txtBox.PlaceholderText = "10"
        Me.effectChance_txtBox.Size = New System.Drawing.Size(195, 23)
        Me.effectChance_txtBox.TabIndex = 22
        '
        'effectChance_lbl
        '
        Me.effectChance_lbl.AutoSize = True
        Me.effectChance_lbl.Location = New System.Drawing.Point(209, 212)
        Me.effectChance_lbl.Name = "effectChance_lbl"
        Me.effectChance_lbl.Size = New System.Drawing.Size(80, 15)
        Me.effectChance_lbl.TabIndex = 21
        Me.effectChance_lbl.Text = "Effect Chance"
        '
        'flags_grpBox
        '
        Me.flags_grpBox.Controls.Add(Me.addFlag_btn)
        Me.flags_grpBox.Controls.Add(Me.flag_lstBox)
        Me.flags_grpBox.Location = New System.Drawing.Point(209, 56)
        Me.flags_grpBox.Name = "flags_grpBox"
        Me.flags_grpBox.Size = New System.Drawing.Size(255, 153)
        Me.flags_grpBox.TabIndex = 20
        Me.flags_grpBox.TabStop = False
        Me.flags_grpBox.Text = "Flags (Double Click a flag to remove it)"
        '
        'addFlag_btn
        '
        Me.addFlag_btn.Location = New System.Drawing.Point(6, 122)
        Me.addFlag_btn.Name = "addFlag_btn"
        Me.addFlag_btn.Size = New System.Drawing.Size(243, 23)
        Me.addFlag_btn.TabIndex = 21
        Me.addFlag_btn.Text = "Add Flag"
        Me.addFlag_btn.UseVisualStyleBackColor = True
        '
        'flag_lstBox
        '
        Me.flag_lstBox.FormattingEnabled = True
        Me.flag_lstBox.ItemHeight = 15
        Me.flag_lstBox.Location = New System.Drawing.Point(6, 22)
        Me.flag_lstBox.Name = "flag_lstBox"
        Me.flag_lstBox.Size = New System.Drawing.Size(243, 94)
        Me.flag_lstBox.TabIndex = 0
        '
        'functionCode_txtBox
        '
        Me.functionCode_txtBox.Location = New System.Drawing.Point(209, 27)
        Me.functionCode_txtBox.Name = "functionCode_txtBox"
        Me.functionCode_txtBox.PlaceholderText = "LowerTargetSpDef1"
        Me.functionCode_txtBox.Size = New System.Drawing.Size(195, 23)
        Me.functionCode_txtBox.TabIndex = 19
        '
        'functionCode_lbl
        '
        Me.functionCode_lbl.AutoSize = True
        Me.functionCode_lbl.Location = New System.Drawing.Point(209, 9)
        Me.functionCode_lbl.Name = "functionCode_lbl"
        Me.functionCode_lbl.Size = New System.Drawing.Size(85, 15)
        Me.functionCode_lbl.TabIndex = 18
        Me.functionCode_lbl.Text = "Function Code"
        '
        'priority_txtBox
        '
        Me.priority_txtBox.Location = New System.Drawing.Point(8, 379)
        Me.priority_txtBox.Name = "priority_txtBox"
        Me.priority_txtBox.PlaceholderText = "0"
        Me.priority_txtBox.Size = New System.Drawing.Size(195, 23)
        Me.priority_txtBox.TabIndex = 17
        '
        'priority_lbl
        '
        Me.priority_lbl.AutoSize = True
        Me.priority_lbl.Location = New System.Drawing.Point(8, 361)
        Me.priority_lbl.Name = "priority_lbl"
        Me.priority_lbl.Size = New System.Drawing.Size(45, 15)
        Me.priority_lbl.TabIndex = 16
        Me.priority_lbl.Text = "Priority"
        '
        'targets_cmbBox
        '
        Me.targets_cmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.targets_cmbBox.FormattingEnabled = True
        Me.targets_cmbBox.Items.AddRange(New Object() {"None", "User", "BearAlly", "UserOrNearAlly", "AllAllies", "UserAndAllies", "NearFpe", "RandomNearFoe", "AllNearFoes", "Foe", "AllFoes", "NearOthers", "AllNearOthers", "Other", "AllBattlers", "UserSide", "FoeSide", "BothSides"})
        Me.targets_cmbBox.Location = New System.Drawing.Point(8, 335)
        Me.targets_cmbBox.Name = "targets_cmbBox"
        Me.targets_cmbBox.Size = New System.Drawing.Size(195, 23)
        Me.targets_cmbBox.TabIndex = 15
        '
        'targets_lbl
        '
        Me.targets_lbl.AutoSize = True
        Me.targets_lbl.Location = New System.Drawing.Point(8, 317)
        Me.targets_lbl.Name = "targets_lbl"
        Me.targets_lbl.Size = New System.Drawing.Size(44, 15)
        Me.targets_lbl.TabIndex = 14
        Me.targets_lbl.Text = "Targets"
        '
        'totalPP_txtBox
        '
        Me.totalPP_txtBox.Location = New System.Drawing.Point(8, 291)
        Me.totalPP_txtBox.Name = "totalPP_txtBox"
        Me.totalPP_txtBox.PlaceholderText = "10"
        Me.totalPP_txtBox.Size = New System.Drawing.Size(195, 23)
        Me.totalPP_txtBox.TabIndex = 13
        '
        'totalPP_lbl
        '
        Me.totalPP_lbl.AutoSize = True
        Me.totalPP_lbl.Location = New System.Drawing.Point(8, 273)
        Me.totalPP_lbl.Name = "totalPP_lbl"
        Me.totalPP_lbl.Size = New System.Drawing.Size(49, 15)
        Me.totalPP_lbl.TabIndex = 12
        Me.totalPP_lbl.Text = "Total PP"
        '
        'acuracy_txtBox
        '
        Me.acuracy_txtBox.Location = New System.Drawing.Point(8, 247)
        Me.acuracy_txtBox.Name = "acuracy_txtBox"
        Me.acuracy_txtBox.PlaceholderText = "100"
        Me.acuracy_txtBox.Size = New System.Drawing.Size(195, 23)
        Me.acuracy_txtBox.TabIndex = 11
        '
        'accuracy_lbl
        '
        Me.accuracy_lbl.AutoSize = True
        Me.accuracy_lbl.Location = New System.Drawing.Point(8, 229)
        Me.accuracy_lbl.Name = "accuracy_lbl"
        Me.accuracy_lbl.Size = New System.Drawing.Size(56, 15)
        Me.accuracy_lbl.TabIndex = 10
        Me.accuracy_lbl.Text = "Accuracy"
        '
        'power_txtBox
        '
        Me.power_txtBox.Location = New System.Drawing.Point(8, 203)
        Me.power_txtBox.Name = "power_txtBox"
        Me.power_txtBox.PlaceholderText = "90"
        Me.power_txtBox.Size = New System.Drawing.Size(195, 23)
        Me.power_txtBox.TabIndex = 9
        '
        'power_lbl
        '
        Me.power_lbl.AutoSize = True
        Me.power_lbl.Location = New System.Drawing.Point(8, 185)
        Me.power_lbl.Name = "power_lbl"
        Me.power_lbl.Size = New System.Drawing.Size(40, 15)
        Me.power_lbl.TabIndex = 8
        Me.power_lbl.Text = "Power"
        '
        'category_cmbBox
        '
        Me.category_cmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.category_cmbBox.FormattingEnabled = True
        Me.category_cmbBox.Items.AddRange(New Object() {"Physical", "Special", "Status"})
        Me.category_cmbBox.Location = New System.Drawing.Point(8, 159)
        Me.category_cmbBox.Name = "category_cmbBox"
        Me.category_cmbBox.Size = New System.Drawing.Size(195, 23)
        Me.category_cmbBox.TabIndex = 7
        '
        'category_lbl
        '
        Me.category_lbl.AutoSize = True
        Me.category_lbl.Location = New System.Drawing.Point(8, 141)
        Me.category_lbl.Name = "category_lbl"
        Me.category_lbl.Size = New System.Drawing.Size(55, 15)
        Me.category_lbl.TabIndex = 6
        Me.category_lbl.Text = "Category"
        '
        'type_cmbBox
        '
        Me.type_cmbBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.type_cmbBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.type_cmbBox.FormattingEnabled = True
        Me.type_cmbBox.Items.AddRange(New Object() {"NORMAL", "FIGHTING", "FLYING", "POISON", "GROUND", "ROCK", "BUG", "GHOST", "STEEL", "QMARKS", "FIRE", "WATER", "ELECTRIC", "PSYCHIC", "ICE", "DRAGON", "DARK", "FAIRY"})
        Me.type_cmbBox.Location = New System.Drawing.Point(8, 115)
        Me.type_cmbBox.Name = "type_cmbBox"
        Me.type_cmbBox.Size = New System.Drawing.Size(195, 23)
        Me.type_cmbBox.TabIndex = 5
        '
        'type_lbl
        '
        Me.type_lbl.AutoSize = True
        Me.type_lbl.Location = New System.Drawing.Point(8, 97)
        Me.type_lbl.Name = "type_lbl"
        Me.type_lbl.Size = New System.Drawing.Size(31, 15)
        Me.type_lbl.TabIndex = 4
        Me.type_lbl.Text = "Type"
        '
        'inGameName_txtBox
        '
        Me.inGameName_txtBox.Location = New System.Drawing.Point(8, 71)
        Me.inGameName_txtBox.Name = "inGameName_txtBox"
        Me.inGameName_txtBox.PlaceholderText = "Bug Buzz"
        Me.inGameName_txtBox.Size = New System.Drawing.Size(195, 23)
        Me.inGameName_txtBox.TabIndex = 3
        '
        'inGameName_lbl
        '
        Me.inGameName_lbl.AutoSize = True
        Me.inGameName_lbl.Location = New System.Drawing.Point(8, 53)
        Me.inGameName_lbl.Name = "inGameName_lbl"
        Me.inGameName_lbl.Size = New System.Drawing.Size(88, 15)
        Me.inGameName_lbl.TabIndex = 2
        Me.inGameName_lbl.Text = "In-Game Name"
        '
        'internalName_txtBox
        '
        Me.internalName_txtBox.Location = New System.Drawing.Point(8, 27)
        Me.internalName_txtBox.Name = "internalName_txtBox"
        Me.internalName_txtBox.PlaceholderText = "BUGBUZZ"
        Me.internalName_txtBox.Size = New System.Drawing.Size(195, 23)
        Me.internalName_txtBox.TabIndex = 1
        '
        'internalName_lbl
        '
        Me.internalName_lbl.AutoSize = True
        Me.internalName_lbl.Location = New System.Drawing.Point(8, 9)
        Me.internalName_lbl.Name = "internalName_lbl"
        Me.internalName_lbl.Size = New System.Drawing.Size(82, 15)
        Me.internalName_lbl.TabIndex = 0
        Me.internalName_lbl.Text = "Internal Name"
        '
        'pg_Output
        '
        Me.pg_Output.Controls.Add(Me.output_txtBox)
        Me.pg_Output.Controls.Add(Me.generate_btn)
        Me.pg_Output.Location = New System.Drawing.Point(4, 24)
        Me.pg_Output.Name = "pg_Output"
        Me.pg_Output.Padding = New System.Windows.Forms.Padding(3)
        Me.pg_Output.Size = New System.Drawing.Size(603, 422)
        Me.pg_Output.TabIndex = 1
        Me.pg_Output.Text = "Output"
        Me.pg_Output.UseVisualStyleBackColor = True
        '
        'output_txtBox
        '
        Me.output_txtBox.Location = New System.Drawing.Point(6, 6)
        Me.output_txtBox.Name = "output_txtBox"
        Me.output_txtBox.ReadOnly = True
        Me.output_txtBox.Size = New System.Drawing.Size(591, 384)
        Me.output_txtBox.TabIndex = 1
        Me.output_txtBox.Text = ""
        '
        'generate_btn
        '
        Me.generate_btn.Location = New System.Drawing.Point(522, 396)
        Me.generate_btn.Name = "generate_btn"
        Me.generate_btn.Size = New System.Drawing.Size(75, 23)
        Me.generate_btn.TabIndex = 0
        Me.generate_btn.Text = "Generate"
        Me.generate_btn.UseVisualStyleBackColor = True
        '
        'pg_About
        '
        Me.pg_About.Controls.Add(Me.PictureBox1)
        Me.pg_About.Controls.Add(Me.RichTextBox1)
        Me.pg_About.Location = New System.Drawing.Point(4, 24)
        Me.pg_About.Name = "pg_About"
        Me.pg_About.Size = New System.Drawing.Size(603, 422)
        Me.pg_About.TabIndex = 2
        Me.pg_About.Text = "About"
        Me.pg_About.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(603, 422)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Move_Generator.My.Resources.Resources.installBanner
        Me.PictureBox1.Location = New System.Drawing.Point(525, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Move Generator"
        Me.TabControl1.ResumeLayout(False)
        Me.pg_MoveInfo.ResumeLayout(False)
        Me.pg_MoveInfo.PerformLayout()
        Me.flags_grpBox.ResumeLayout(False)
        Me.pg_Output.ResumeLayout(False)
        Me.pg_About.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents pg_MoveInfo As TabPage
    Friend WithEvents pg_Output As TabPage
    Friend WithEvents internalName_txtBox As TextBox
    Friend WithEvents internalName_lbl As Label
    Friend WithEvents type_cmbBox As ComboBox
    Friend WithEvents type_lbl As Label
    Friend WithEvents inGameName_txtBox As TextBox
    Friend WithEvents inGameName_lbl As Label
    Friend WithEvents category_cmbBox As ComboBox
    Friend WithEvents category_lbl As Label
    Friend WithEvents acuracy_txtBox As TextBox
    Friend WithEvents accuracy_lbl As Label
    Friend WithEvents power_txtBox As TextBox
    Friend WithEvents power_lbl As Label
    Friend WithEvents targets_cmbBox As ComboBox
    Friend WithEvents targets_lbl As Label
    Friend WithEvents totalPP_txtBox As TextBox
    Friend WithEvents totalPP_lbl As Label
    Friend WithEvents priority_txtBox As TextBox
    Friend WithEvents priority_lbl As Label
    Friend WithEvents functionCode_txtBox As TextBox
    Friend WithEvents functionCode_lbl As Label
    Friend WithEvents description_txtBox As RichTextBox
    Friend WithEvents description_lbl As Label
    Friend WithEvents effectChance_txtBox As TextBox
    Friend WithEvents effectChance_lbl As Label
    Friend WithEvents flags_grpBox As GroupBox
    Friend WithEvents addFlag_btn As Button
    Friend WithEvents flag_lstBox As ListBox
    Friend WithEvents output_txtBox As RichTextBox
    Friend WithEvents generate_btn As Button
    Friend WithEvents pg_About As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
