Imports System.Buffers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class setting
    Private Sub applypassword_Click(sender As Object, e As EventArgs) Handles applypassword.Click
        My.Computer.FileSystem.WriteAllText("./data/p3w7d5a.mrxd", cuspassword.Text, False)
    End Sub

    Private Sub secbpic_Click(sender As Object, e As EventArgs)
        'OpenFileDialog1.Filter = "*.png|*.jpg"
        'OpenFileDialog1.ShowDialog()
        'Dim FilePath1
        'If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
        'FilePath1 = OpenFileDialog1.FileName
        'End If
        'MainPage.BackgroundImage = FilePath1
    End Sub

    Private Sub titleac_Click(sender As Object, e As EventArgs) Handles titleac.Click
        My.Computer.FileSystem.WriteAllText("./data/custit1.mrxd", custitle.Text, False)
        MainPage.Text = My.Computer.FileSystem.ReadAllText("./data/custit1.mrxd")
    End Sub
End Class