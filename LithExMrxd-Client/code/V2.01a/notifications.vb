Public Class notifications
    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()


        Dim times As Int32 = 0
        times += 38
        If times < 100 Then

        End If
        If times = 100 Then
            Me.Hide()
        End If
        ProgressBar1.Value = times
    End Sub

    Private Sub notifications_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class