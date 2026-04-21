<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        PanelInput = New Panel()
        GroupBoxInput = New GroupBox()
        ComboBoxMerek = New ComboBox()
        LabelMerek = New Label()
        ComboBoxSkala = New ComboBox()
        LabelSkala = New Label()
        txtNamaModel = New TextBox()
        LabelNamaModel = New Label()
        PanelButton = New Panel()
        GroupBoxButton = New GroupBox()
        btnTutup = New Button()
        btnBatal = New Button()
        btnHapus = New Button()
        btnSimpan = New Button()
        PanelData = New Panel()
        GroupBoxData = New GroupBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        dgvModelKit = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        btnPencarian = New Button()
        PanelInput.SuspendLayout()
        GroupBoxInput.SuspendLayout()
        PanelButton.SuspendLayout()
        GroupBoxButton.SuspendLayout()
        PanelData.SuspendLayout()
        GroupBoxData.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvModelKit, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelInput
        ' 
        PanelInput.BackColor = Color.LightBlue
        PanelInput.BorderStyle = BorderStyle.FixedSingle
        PanelInput.Controls.Add(GroupBoxInput)
        PanelInput.Location = New Point(20, 23)
        PanelInput.Margin = New Padding(5, 6, 5, 6)
        PanelInput.Name = "PanelInput"
        PanelInput.Size = New Size(615, 364)
        PanelInput.TabIndex = 0
        ' 
        ' GroupBoxInput
        ' 
        GroupBoxInput.BackColor = Color.LightBlue
        GroupBoxInput.Controls.Add(ComboBoxMerek)
        GroupBoxInput.Controls.Add(LabelMerek)
        GroupBoxInput.Controls.Add(ComboBoxSkala)
        GroupBoxInput.Controls.Add(LabelSkala)
        GroupBoxInput.Controls.Add(txtNamaModel)
        GroupBoxInput.Controls.Add(LabelNamaModel)
        GroupBoxInput.Font = New Font("Arial", 9F, FontStyle.Bold)
        GroupBoxInput.Location = New Point(17, 19)
        GroupBoxInput.Margin = New Padding(5, 6, 5, 6)
        GroupBoxInput.Name = "GroupBoxInput"
        GroupBoxInput.Padding = New Padding(5, 6, 5, 6)
        GroupBoxInput.Size = New Size(575, 317)
        GroupBoxInput.TabIndex = 0
        GroupBoxInput.TabStop = False
        GroupBoxInput.Text = "MODEL KIT"
        ' 
        ' ComboBoxMerek
        ' 
        ComboBoxMerek.BackColor = Color.White
        ComboBoxMerek.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxMerek.FormattingEnabled = True
        ComboBoxMerek.Location = New Point(200, 196)
        ComboBoxMerek.Margin = New Padding(5, 6, 5, 6)
        ComboBoxMerek.Name = "ComboBoxMerek"
        ComboBoxMerek.Size = New Size(331, 29)
        ComboBoxMerek.TabIndex = 5
        ' 
        ' LabelMerek
        ' 
        LabelMerek.AutoSize = True
        LabelMerek.BackColor = Color.LightBlue
        LabelMerek.Font = New Font("Arial", 9F)
        LabelMerek.Location = New Point(33, 202)
        LabelMerek.Margin = New Padding(5, 0, 5, 0)
        LabelMerek.Name = "LabelMerek"
        LabelMerek.Size = New Size(65, 21)
        LabelMerek.TabIndex = 4
        LabelMerek.Text = "Merek:"
        ' 
        ' ComboBoxSkala
        ' 
        ComboBoxSkala.BackColor = Color.White
        ComboBoxSkala.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxSkala.FormattingEnabled = True
        ComboBoxSkala.Location = New Point(200, 129)
        ComboBoxSkala.Margin = New Padding(5, 6, 5, 6)
        ComboBoxSkala.Name = "ComboBoxSkala"
        ComboBoxSkala.Size = New Size(331, 29)
        ComboBoxSkala.TabIndex = 3
        ' 
        ' LabelSkala
        ' 
        LabelSkala.AutoSize = True
        LabelSkala.BackColor = Color.LightBlue
        LabelSkala.Font = New Font("Arial", 9F)
        LabelSkala.Location = New Point(33, 135)
        LabelSkala.Margin = New Padding(5, 0, 5, 0)
        LabelSkala.Name = "LabelSkala"
        LabelSkala.Size = New Size(60, 21)
        LabelSkala.TabIndex = 2
        LabelSkala.Text = "Skala:"
        ' 
        ' txtNamaModel
        ' 
        txtNamaModel.BackColor = Color.White
        txtNamaModel.Location = New Point(200, 62)
        txtNamaModel.Margin = New Padding(5, 6, 5, 6)
        txtNamaModel.Name = "txtNamaModel"
        txtNamaModel.Size = New Size(331, 28)
        txtNamaModel.TabIndex = 1
        ' 
        ' LabelNamaModel
        ' 
        LabelNamaModel.AutoSize = True
        LabelNamaModel.BackColor = Color.LightBlue
        LabelNamaModel.Font = New Font("Arial", 9F)
        LabelNamaModel.Location = New Point(33, 67)
        LabelNamaModel.Margin = New Padding(5, 0, 5, 0)
        LabelNamaModel.Name = "LabelNamaModel"
        LabelNamaModel.Size = New Size(116, 21)
        LabelNamaModel.TabIndex = 0
        LabelNamaModel.Text = "Nama Model:"
        ' 
        ' PanelButton
        ' 
        PanelButton.BackColor = Color.LightGray
        PanelButton.BorderStyle = BorderStyle.FixedSingle
        PanelButton.Controls.Add(GroupBoxButton)
        PanelButton.Location = New Point(20, 404)
        PanelButton.Margin = New Padding(5, 6, 5, 6)
        PanelButton.Name = "PanelButton"
        PanelButton.Size = New Size(615, 248)
        PanelButton.TabIndex = 1
        ' 
        ' GroupBoxButton
        ' 
        GroupBoxButton.BackColor = Color.LightGray
        GroupBoxButton.Controls.Add(btnPencarian)
        GroupBoxButton.Controls.Add(btnTutup)
        GroupBoxButton.Controls.Add(btnBatal)
        GroupBoxButton.Controls.Add(btnHapus)
        GroupBoxButton.Controls.Add(btnSimpan)
        GroupBoxButton.Font = New Font("Arial", 9F, FontStyle.Bold)
        GroupBoxButton.Location = New Point(17, 19)
        GroupBoxButton.Margin = New Padding(5, 6, 5, 6)
        GroupBoxButton.Name = "GroupBoxButton"
        GroupBoxButton.Padding = New Padding(5, 6, 5, 6)
        GroupBoxButton.Size = New Size(575, 202)
        GroupBoxButton.TabIndex = 0
        GroupBoxButton.TabStop = False
        GroupBoxButton.Text = "Button"
        ' 
        ' btnTutup
        ' 
        btnTutup.BackColor = Color.Salmon
        btnTutup.ForeColor = Color.White
        btnTutup.Location = New Point(398, 127)
        btnTutup.Margin = New Padding(5, 6, 5, 6)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(167, 67)
        btnTutup.TabIndex = 3
        btnTutup.Text = "TUTUP"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Teal
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(33, 135)
        btnBatal.Margin = New Padding(5, 6, 5, 6)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(167, 67)
        btnBatal.TabIndex = 2
        btnBatal.Text = "BATAL"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Brown
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(398, 48)
        btnHapus.Margin = New Padding(5, 6, 5, 6)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(167, 67)
        btnHapus.TabIndex = 1
        btnHapus.Text = "HAPUS"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.LightGreen
        btnSimpan.ForeColor = Color.Black
        btnSimpan.Location = New Point(33, 48)
        btnSimpan.Margin = New Padding(5, 6, 5, 6)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(167, 67)
        btnSimpan.TabIndex = 0
        btnSimpan.Text = "SIMPAN"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' PanelData
        ' 
        PanelData.BackColor = Color.White
        PanelData.BorderStyle = BorderStyle.FixedSingle
        PanelData.Controls.Add(GroupBoxData)
        PanelData.Location = New Point(650, 23)
        PanelData.Margin = New Padding(5, 6, 5, 6)
        PanelData.Name = "PanelData"
        PanelData.Size = New Size(965, 629)
        PanelData.TabIndex = 2
        ' 
        ' GroupBoxData
        ' 
        GroupBoxData.BackColor = Color.White
        GroupBoxData.Controls.Add(PictureBox2)
        GroupBoxData.Controls.Add(PictureBox1)
        GroupBoxData.Controls.Add(dgvModelKit)
        GroupBoxData.Font = New Font("Arial", 9F, FontStyle.Bold)
        GroupBoxData.Location = New Point(17, 19)
        GroupBoxData.Margin = New Padding(5, 6, 5, 6)
        GroupBoxData.Name = "GroupBoxData"
        GroupBoxData.Padding = New Padding(5, 6, 5, 6)
        GroupBoxData.Size = New Size(925, 583)
        GroupBoxData.TabIndex = 0
        GroupBoxData.TabStop = False
        GroupBoxData.Text = "DAFTAR MODEL KIT"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.download32321
        PictureBox2.Location = New Point(688, 16)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(212, 177)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.download131321
        PictureBox1.Location = New Point(17, 39)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(325, 154)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' dgvModelKit
        ' 
        dgvModelKit.AllowUserToAddRows = False
        dgvModelKit.AllowUserToDeleteRows = False
        dgvModelKit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvModelKit.BackgroundColor = Color.White
        dgvModelKit.ColumnHeadersHeight = 34
        dgvModelKit.Location = New Point(17, 202)
        dgvModelKit.Margin = New Padding(5, 6, 5, 6)
        dgvModelKit.Name = "dgvModelKit"
        dgvModelKit.ReadOnly = True
        dgvModelKit.RowHeadersWidth = 62
        dgvModelKit.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvModelKit.Size = New Size(883, 346)
        dgvModelKit.TabIndex = 0
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnPencarian
        ' 
        btnPencarian.BackColor = Color.Khaki
        btnPencarian.Location = New Point(210, 48)
        btnPencarian.Margin = New Padding(5, 6, 5, 6)
        btnPencarian.Name = "btnPencarian"
        btnPencarian.Size = New Size(155, 67)
        btnPencarian.TabIndex = 4
        btnPencarian.Text = "PENCARIAN"
        btnPencarian.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1640, 685)
        Controls.Add(PanelData)
        Controls.Add(PanelButton)
        Controls.Add(PanelInput)
        Margin = New Padding(5, 6, 5, 6)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Model Kit Shop "
        PanelInput.ResumeLayout(False)
        GroupBoxInput.ResumeLayout(False)
        GroupBoxInput.PerformLayout()
        PanelButton.ResumeLayout(False)
        GroupBoxButton.ResumeLayout(False)
        PanelData.ResumeLayout(False)
        GroupBoxData.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvModelKit, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelInput As Panel
    Friend WithEvents GroupBoxInput As GroupBox
    Friend WithEvents ComboBoxMerek As ComboBox
    Friend WithEvents LabelMerek As Label
    Friend WithEvents ComboBoxSkala As ComboBox
    Friend WithEvents LabelSkala As Label
    Friend WithEvents txtNamaModel As TextBox
    Friend WithEvents LabelNamaModel As Label
    Friend WithEvents PanelButton As Panel
    Friend WithEvents GroupBoxButton As GroupBox
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents PanelData As Panel
    Friend WithEvents GroupBoxData As GroupBox
    Friend WithEvents dgvModelKit As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPencarian As Button
End Class