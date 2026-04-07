<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenuUtama
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
        MenuStrip1 = New MenuStrip()
        MenuData = New ToolStripMenuItem()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        LabelJudul = New Label()
        PictureBoxLogo = New PictureBox()
        LabelInfo = New Label()
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        MenuStrip1.SuspendLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuData})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(10, 4, 0, 4)
        MenuStrip1.Size = New Size(1000, 37)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuData
        ' 
        MenuData.DropDownItems.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, ToolStripSeparator1, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, ToolStripSeparator2, KeluarToolStripMenuItem})
        MenuData.Name = "MenuData"
        MenuData.Size = New Size(69, 29)
        MenuData.Text = "&Kartu"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.I
        InputDataToolStripMenuItem.Size = New Size(277, 34)
        InputDataToolStripMenuItem.Text = "&Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.L
        LihatKartuToolStripMenuItem.Size = New Size(277, 34)
        LihatKartuToolStripMenuItem.Text = "&Lihat Kartu"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(274, 6)
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        SimpanDataToolStripMenuItem.Size = New Size(277, 34)
        SimpanDataToolStripMenuItem.Text = "&Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        BukaDataToolStripMenuItem.Size = New Size(277, 34)
        BukaDataToolStripMenuItem.Text = "&Buka Data"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(274, 6)
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Q
        KeluarToolStripMenuItem.Size = New Size(277, 34)
        KeluarToolStripMenuItem.Text = "&Keluar"
        ' 
        ' LabelJudul
        ' 
        LabelJudul.AutoSize = True
        LabelJudul.Font = New Font("Arial", 24.0F, FontStyle.Bold)
        LabelJudul.ForeColor = Color.DarkBlue
        LabelJudul.Location = New Point(200, 96)
        LabelJudul.Margin = New Padding(5, 0, 5, 0)
        LabelJudul.Name = "LabelJudul"
        LabelJudul.Size = New Size(725, 56)
        LabelJudul.TabIndex = 1
        LabelJudul.Text = "APLIKASI KARTU KOMUNITAS"
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.BorderStyle = BorderStyle.FixedSingle
        PictureBoxLogo.Image = My.Resources.Resources.Komunitas21
        PictureBoxLogo.Location = New Point(190, 208)
        PictureBoxLogo.Margin = New Padding(5, 6, 5, 6)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(653, 287)
        PictureBoxLogo.TabIndex = 2
        PictureBoxLogo.TabStop = False
        ' 
        ' LabelInfo
        ' 
        LabelInfo.AutoSize = True
        LabelInfo.Font = New Font("Arial", 12.0F, FontStyle.Italic)
        LabelInfo.ForeColor = Color.Gray
        LabelInfo.Location = New Point(250, 558)
        LabelInfo.Margin = New Padding(5, 0, 5, 0)
        LabelInfo.Name = "LabelInfo"
        LabelInfo.Size = New Size(449, 28)
        LabelInfo.TabIndex = 3
        LabelInfo.Text = "Silakan pilih menu di atas untuk memulai"
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv"
        ' 
        ' FormMenuUtama
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 673)
        Controls.Add(LabelInfo)
        Controls.Add(PictureBoxLogo)
        Controls.Add(LabelJudul)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(5, 6, 5, 6)
        Name = "FormMenuUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kartu Komunitas"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuData As ToolStripMenuItem
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelJudul As Label
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents LabelInfo As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class