Public Class Form2
    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles OOFver.Click

    End Sub

    Private Sub OOFBUTTON_Click(sender As Object, e As EventArgs) Handles OOFBUTTON.Click
        Diagnostics.Process.Start("winver.exe")
    End Sub
End Class