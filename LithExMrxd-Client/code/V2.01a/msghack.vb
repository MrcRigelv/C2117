Option Explicit On
Imports System.Buffers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class msghack
    Private Sub startmsgsend_Click(sender As Object, e As EventArgs) Handles startmsgsend.Click
        Dim m As Int16
        Dim a As Int16
        Select Case Mode.Text
            Case "钉钉群聊刷屏"
                m = 1
            Case "钉钉直播刷屏"
                m = 2
            Case "QQ刷屏"
                m = 3
            Case Else
                MsgBox("请选择模式")
        End Select
        If antimsgfolder1.Checked Then
            a = 1
        Else a = 0
        End If
        If m = 2 Then
            MsgBox("模式：钉钉直播刷屏器.在使用前，请确保你要刷屏的文字已被您复制")
            Shell("cmd.exe /c start .\mod\dinglivemsghack.vbs", 1)
        End If
        If m = 1 Then
            If a = 0 Then
                MsgBox("模式：钉钉聊天刷屏器.在使用前，请确保你要刷屏的文字已被您复制")
                Shell("cmd.exe /c start .\mod\dingmsghack1.vbs", 1)
            End If
            If a = 1 Then
                MsgBox("模式：钉钉聊天刷屏器-防折叠消息.在使用前，请确保你要刷屏的文字已被您复制")
                Shell("cmd.exe /c start .\mod\dingmsghack2.vbs", 1)
            End If
        End If
        If m = 3 Then
            MsgBox("模式：qq聊天刷屏器.在使用前，请确保你要刷屏的文字已被您复制")
            Shell("cmd.exe /c start .\mod\qqmsghack.vbs", 1)
        End If
    End Sub

    Private Sub exitmsghack_Click(sender As Object, e As EventArgs) Handles exitmsghack.Click
        Shell("cmd.exe /c taskkill /f /t /im wscript.exe", 1)
        Shell("cmd.exe /c taskkill /f /t /im wscript.exe", 1)
        Shell("cmd.exe /c taskkill /f /t /im wscript.exe", 1)
        Shell("cmd.exe /c taskkill /f /t /im wscript.exe", 1)
        Shell("cmd.exe /c taskkill /f /t /im wscript.exe", 1)
    End Sub
End Class