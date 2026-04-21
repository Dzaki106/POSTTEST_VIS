<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPencarian
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        PanelCari = New Panel()
        GroupBoxCari = New GroupBox()
        ComboBoxCari = New ComboBox()
        LabelFilter = New Label()
        btnCari = New Button()
        txtKeyword = New TextBox()
        LabelKeyword = New Label()
        btnReset = New Button()
        PanelHasil = New Panel()
        GroupBoxHasil = New GroupBox()
        LabelJumlah = New Label()
        dgvHasil = New DataGridView()
        btnTutup = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        PictureBox4 = New PictureBox()
        PanelCari.SuspendLayout()
        GroupBoxCari.SuspendLayout()
        PanelHasil.SuspendLayout()
        GroupBoxHasil.SuspendLayout()
        CType(dgvHasil, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelCari
        ' 
        PanelCari.BackColor = Color.LightBlue
        PanelCari.BorderStyle = BorderStyle.FixedSingle
        PanelCari.Controls.Add(GroupBoxCari)
        PanelCari.Location = New Point(20, 23)
        PanelCari.Margin = New Padding(5, 6, 5, 6)
        PanelCari.Name = "PanelCari"
        PanelCari.Size = New Size(832, 229)
        PanelCari.TabIndex = 0
        ' 
        ' GroupBoxCari
        ' 
        GroupBoxCari.BackColor = Color.LightBlue
        GroupBoxCari.Controls.Add(ComboBoxCari)
        GroupBoxCari.Controls.Add(LabelFilter)
        GroupBoxCari.Controls.Add(btnCari)
        GroupBoxCari.Controls.Add(txtKeyword)
        GroupBoxCari.Controls.Add(LabelKeyword)
        GroupBoxCari.Controls.Add(btnReset)
        GroupBoxCari.Font = New Font("Arial", 9F, FontStyle.Bold)
        GroupBoxCari.Location = New Point(17, 19)
        GroupBoxCari.Margin = New Padding(5, 6, 5, 6)
        GroupBoxCari.Name = "GroupBoxCari"
        GroupBoxCari.Padding = New Padding(5, 6, 5, 6)
        GroupBoxCari.Size = New Size(792, 183)
        GroupBoxCari.TabIndex = 0
        GroupBoxCari.TabStop = False
        GroupBoxCari.Text = "PENCARIAN MODEL KIT"
        ' 
        ' ComboBoxCari
        ' 
        ComboBoxCari.BackColor = Color.White
        ComboBoxCari.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxCari.Font = New Font("Arial", 9F)
        ComboBoxCari.FormattingEnabled = True
        ComboBoxCari.Location = New Point(167, 110)
        ComboBoxCari.Margin = New Padding(5, 6, 5, 6)
        ComboBoxCari.Name = "ComboBoxCari"
        ComboBoxCari.Size = New Size(331, 29)
        ComboBoxCari.TabIndex = 3
        ' 
        ' LabelFilter
        ' 
        LabelFilter.AutoSize = True
        LabelFilter.BackColor = Color.LightBlue
        LabelFilter.Font = New Font("Arial", 9F)
        LabelFilter.Location = New Point(25, 115)
        LabelFilter.Margin = New Padding(5, 0, 5, 0)
        LabelFilter.Name = "LabelFilter"
        LabelFilter.Size = New Size(55, 21)
        LabelFilter.TabIndex = 2
        LabelFilter.Text = "Filter:"
        ' 
        ' btnCari
        ' 
        btnCari.BackColor = Color.Green
        btnCari.Font = New Font("Arial", 9F, FontStyle.Bold)
        btnCari.ForeColor = Color.White
        btnCari.Location = New Point(533, 48)
        btnCari.Margin = New Padding(5, 6, 5, 6)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(117, 106)
        btnCari.TabIndex = 4
        btnCari.Text = "CARI"
        btnCari.UseVisualStyleBackColor = False
        ' 
        ' txtKeyword
        ' 
        txtKeyword.BackColor = Color.White
        txtKeyword.Font = New Font("Arial", 9F)
        txtKeyword.Location = New Point(167, 52)
        txtKeyword.Margin = New Padding(5, 6, 5, 6)
        txtKeyword.Name = "txtKeyword"
        txtKeyword.Size = New Size(331, 28)
        txtKeyword.TabIndex = 1
        ' 
        ' LabelKeyword
        ' 
        LabelKeyword.AutoSize = True
        LabelKeyword.BackColor = Color.LightBlue
        LabelKeyword.Font = New Font("Arial", 9F)
        LabelKeyword.Location = New Point(25, 58)
        LabelKeyword.Margin = New Padding(5, 0, 5, 0)
        LabelKeyword.Name = "LabelKeyword"
        LabelKeyword.Size = New Size(102, 21)
        LabelKeyword.TabIndex = 0
        LabelKeyword.Text = "Kata Kunci:"
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.Gray
        btnReset.Font = New Font("Arial", 9F, FontStyle.Bold)
        btnReset.ForeColor = Color.White
        btnReset.Location = New Point(658, 48)
        btnReset.Margin = New Padding(5, 6, 5, 6)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(117, 106)
        btnReset.TabIndex = 5
        btnReset.Text = "RESET"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' PanelHasil
        ' 
        PanelHasil.BackColor = Color.White
        PanelHasil.BorderStyle = BorderStyle.FixedSingle
        PanelHasil.Controls.Add(GroupBoxHasil)
        PanelHasil.Location = New Point(20, 269)
        PanelHasil.Margin = New Padding(5, 6, 5, 6)
        PanelHasil.Name = "PanelHasil"
        PanelHasil.Size = New Size(832, 635)
        PanelHasil.TabIndex = 1
        ' 
        ' GroupBoxHasil
        ' 
        GroupBoxHasil.BackColor = Color.White
        GroupBoxHasil.Controls.Add(PictureBox4)
        GroupBoxHasil.Controls.Add(LabelJumlah)
        GroupBoxHasil.Controls.Add(dgvHasil)
        GroupBoxHasil.Font = New Font("Arial", 9F, FontStyle.Bold)
        GroupBoxHasil.Location = New Point(17, 19)
        GroupBoxHasil.Margin = New Padding(5, 6, 5, 6)
        GroupBoxHasil.Name = "GroupBoxHasil"
        GroupBoxHasil.Padding = New Padding(5, 6, 5, 6)
        GroupBoxHasil.Size = New Size(792, 600)
        GroupBoxHasil.TabIndex = 0
        GroupBoxHasil.TabStop = False
        GroupBoxHasil.Text = "HASIL PENCARIAN"
        ' 
        ' LabelJumlah
        ' 
        LabelJumlah.AutoSize = True
        LabelJumlah.Font = New Font("Arial", 9F, FontStyle.Bold)
        LabelJumlah.ForeColor = Color.DarkGreen
        LabelJumlah.Location = New Point(17, 355)
        LabelJumlah.Margin = New Padding(5, 0, 5, 0)
        LabelJumlah.Name = "LabelJumlah"
        LabelJumlah.Size = New Size(140, 21)
        LabelJumlah.TabIndex = 1
        LabelJumlah.Text = "Jumlah Data: 0"
        ' 
        ' dgvHasil
        ' 
        dgvHasil.AllowUserToAddRows = False
        dgvHasil.AllowUserToDeleteRows = False
        dgvHasil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvHasil.BackgroundColor = Color.White
        dgvHasil.ColumnHeadersHeight = 34
        dgvHasil.Location = New Point(17, 48)
        dgvHasil.Margin = New Padding(5, 6, 5, 6)
        dgvHasil.Name = "dgvHasil"
        dgvHasil.ReadOnly = True
        dgvHasil.RowHeadersWidth = 62
        dgvHasil.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvHasil.Size = New Size(758, 301)
        dgvHasil.TabIndex = 0
        ' 
        ' btnTutup
        ' 
        btnTutup.BackColor = Color.Red
        btnTutup.Font = New Font("Arial", 9F, FontStyle.Bold)
        btnTutup.ForeColor = Color.White
        btnTutup.Location = New Point(685, 916)
        btnTutup.Margin = New Padding(5, 6, 5, 6)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(167, 58)
        btnTutup.TabIndex = 2
        btnTutup.Text = "TUTUP"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.maxresdefault
        PictureBox4.Location = New Point(17, 379)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(758, 212)
        PictureBox4.TabIndex = 10
        PictureBox4.TabStop = False
        ' 
        ' FormPencarian
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(873, 989)
        Controls.Add(btnTutup)
        Controls.Add(PanelHasil)
        Controls.Add(PanelCari)
        Margin = New Padding(5, 6, 5, 6)
        Name = "FormPencarian"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pencarian Model Kit"
        PanelCari.ResumeLayout(False)
        GroupBoxCari.ResumeLayout(False)
        GroupBoxCari.PerformLayout()
        PanelHasil.ResumeLayout(False)
        GroupBoxHasil.ResumeLayout(False)
        GroupBoxHasil.PerformLayout()
        CType(dgvHasil, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelCari As Panel
    Friend WithEvents GroupBoxCari As GroupBox
    Friend WithEvents ComboBoxCari As ComboBox
    Friend WithEvents LabelFilter As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents txtKeyword As TextBox
    Friend WithEvents LabelKeyword As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents PanelHasil As Panel
    Friend WithEvents GroupBoxHasil As GroupBox
    Friend WithEvents dgvHasil As DataGridView
    Friend WithEvents LabelJumlah As Label
    Friend WithEvents btnTutup As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PictureBox4 As PictureBox
End Class