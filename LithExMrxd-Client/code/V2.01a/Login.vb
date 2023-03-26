Imports System.Windows

Public Class Login
    Private Sub logb1_Click(sender As Object, e As EventArgs) Handles logb1.Click

        If pwdbox.Text = "Debug2117" Then
            MainPage.Show()
            Me.Hide()
            MainPage.Text() = "LithExMrxdV-V2.01-主界面-调试模式"
            notifications.Show()
        End If
        If pwdbox.Text = "Mrxd211733" Then
            MainPage.Show()
            Me.Hide()
            MainPage.Text() = "LithExMrxdV-V2.01-主界面-欢迎您12岁零72月的天才少女"
        End If

        If pwdbox.Text = "MrxdWKSVC-1720" Then
            MainPage.Show()
            Me.Hide()
            MainPage.Text() = "LithExMrxdV-V2.01-主界面-正式版秘钥登录"
        End If
        If pwdbox.Text = My.Computer.FileSystem.ReadAllText("./data/p3w7d5a.mrxd") Then
            MainPage.Show()
            Me.Hide()
            MainPage.Text() = "LithExMrxdV-V2.01-主界面-自定义密码登录"
        End If
    End Sub
End Class