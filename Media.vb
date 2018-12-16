Public Class Media
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        End If
    End Sub
End Class