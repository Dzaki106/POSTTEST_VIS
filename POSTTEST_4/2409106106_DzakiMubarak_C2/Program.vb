Imports System
Imports System.Windows.Forms

Namespace KartuKomunitas
    Friend Module Program
        <STAThread>
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New FormMenuUtama())
        End Sub
    End Module
End Namespace