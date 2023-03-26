Public Class MainPage
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timebox.Text = "[当前时间:" + Now + "]"
        Dim sec As Int64, perc As Double
        sec = (Hour(Now) * 3600 + Minute(Now) * 60 + Second(Now))
        perc = (sec / 86400 * 100)

        daybar.Value = sec
        minbar.Value = Second(Now)
        hourbar.Value = Minute(Now)
        seco.Text = sec
        processday.Text = Format(perc, "0.00001")
    End Sub

    Private Sub 网站ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 网站ToolStripMenuItem.Click
        website.Show()
    End Sub

    Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        about.Show()
    End Sub

    Private Sub 设置ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 设置ToolStripMenuItem.Click
        setting.Show()
    End Sub

    Private Sub 说明ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 说明ToolStripMenuItem.Click
        shuoming.Show()
    End Sub

    Private Sub startcalc_Click(sender As Object, e As EventArgs) Handles startcalc.Click
        calc.Show()
    End Sub

    Private Sub startmsghack_Click(sender As Object, e As EventArgs) Handles startmsghack.Click
        msghack.Show()
    End Sub

    Private Sub startbtc_Click(sender As Object, e As EventArgs) Handles startbtc.Click
        backtoclass.Show()
    End Sub

    Private Sub startsystemt_Click(sender As Object, e As EventArgs) Handles startsystemt.Click
        systtools.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("cmd.exe /c start taskmgr.exe", 1)
    End Sub

    Private Sub startcmd_Click(sender As Object, e As EventArgs) Handles startcmd.Click
        Shell("cmd.exe /c start cmd.exe", 1)
    End Sub

    Private Sub startac_Click(sender As Object, e As EventArgs) Handles startac.Click
        Shell("cmd.exe /c start ./mod/ac.exe", 1)
    End Sub

    Private Sub startac2_Click(sender As Object, e As EventArgs) Handles startac2.Click
        Form1.Show()
    End Sub

    Private Sub closevbs_Click(sender As Object, e As EventArgs) Handles closevbs.Click
        For i = 0 To 5
            Shell("cmd.exe /c taskkill /f /t /im wscript.exe", 1)
        Next
    End Sub

    Private Sub startkyst_Click(sender As Object, e As EventArgs) Handles startkyst.Click
        Shell("./mod/kyst.exe", 1)
    End Sub

    Private Sub closekyst_Click(sender As Object, e As EventArgs) Handles closekyst.Click
        Shell("cmd.exe /c taskkill /f /t /im kyst.exe", 1)
    End Sub

    Private Sub opkeystroke_Click(sender As Object, e As EventArgs) Handles opkeystroke.Click
        kystbox.Show()
    End Sub

    Private Sub closeuikyst_Click(sender As Object, e As EventArgs) Handles closeuikyst.Click
        kystbox.Hide()
    End Sub
    Private Sub exitnetip1_Click(sender As Object, e As EventArgs) Handles exitnetip1.Click
        Shell("cmd.exe /c ipconfig/release", 1)
    End Sub

    Private Sub renetip1_Click(sender As Object, e As EventArgs) Handles renetip1.Click

        Shell("cmd.exe /c ipconfig/renew", 1)
    End Sub

    Private Sub autoshutdown_Click(sender As Object, e As EventArgs) Handles autoshutdown.Click
        Shell("cmd.exe /c start ./mod/autoshutdown.vbs", 1)
    End Sub

    Private Sub closesysttool_Click(sender As Object, e As EventArgs) Handles closesysttool.Click
        systtools.Hide()
    End Sub
    Private Sub backding_Click(sender As Object, e As EventArgs) Handles backding.Click
        Shell("cmd.exe /c start .\mod\zxh.vbs", 1)
    End Sub

    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class