<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class website
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.webwawa = New System.Windows.Forms.Button()
        Me.webcps = New System.Windows.Forms.Button()
        Me.webbili = New System.Windows.Forms.Button()
        Me.webgame3 = New System.Windows.Forms.Button()
        Me.webgame2 = New System.Windows.Forms.Button()
        Me.webgame1 = New System.Windows.Forms.Button()
        Me.web2 = New System.Windows.Forms.Button()
        Me.web1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'webwawa
        '
        Me.webwawa.Location = New System.Drawing.Point(10, 237)
        Me.webwawa.Name = "webwawa"
        Me.webwawa.Size = New System.Drawing.Size(178, 27)
        Me.webwawa.TabIndex = 15
        Me.webwawa.Text = "蛙蛙工具"
        Me.webwawa.UseVisualStyleBackColor = True
        '
        'webcps
        '
        Me.webcps.Location = New System.Drawing.Point(10, 205)
        Me.webcps.Name = "webcps"
        Me.webcps.Size = New System.Drawing.Size(178, 26)
        Me.webcps.TabIndex = 14
        Me.webcps.Text = "CPS测试网站"
        Me.webcps.UseVisualStyleBackColor = True
        '
        'webbili
        '
        Me.webbili.Location = New System.Drawing.Point(12, 173)
        Me.webbili.Name = "webbili"
        Me.webbili.Size = New System.Drawing.Size(176, 26)
        Me.webbili.TabIndex = 13
        Me.webbili.Text = "B站"
        Me.webbili.UseVisualStyleBackColor = True
        '
        'webgame3
        '
        Me.webgame3.Location = New System.Drawing.Point(12, 140)
        Me.webgame3.Name = "webgame3"
        Me.webgame3.Size = New System.Drawing.Size(176, 27)
        Me.webgame3.TabIndex = 12
        Me.webgame3.Text = "小游戏网站3"
        Me.webgame3.UseVisualStyleBackColor = True
        '
        'webgame2
        '
        Me.webgame2.Location = New System.Drawing.Point(12, 108)
        Me.webgame2.Name = "webgame2"
        Me.webgame2.Size = New System.Drawing.Size(176, 26)
        Me.webgame2.TabIndex = 11
        Me.webgame2.Text = "小游戏网站2"
        Me.webgame2.UseVisualStyleBackColor = True
        '
        'webgame1
        '
        Me.webgame1.Location = New System.Drawing.Point(12, 77)
        Me.webgame1.Name = "webgame1"
        Me.webgame1.Size = New System.Drawing.Size(176, 25)
        Me.webgame1.TabIndex = 10
        Me.webgame1.Text = "小游戏网站1"
        Me.webgame1.UseVisualStyleBackColor = True
        '
        'web2
        '
        Me.web2.Location = New System.Drawing.Point(12, 44)
        Me.web2.Name = "web2"
        Me.web2.Size = New System.Drawing.Size(176, 27)
        Me.web2.TabIndex = 9
        Me.web2.Text = "鸡乐盒"
        Me.web2.UseVisualStyleBackColor = True
        '
        'web1
        '
        Me.web1.Location = New System.Drawing.Point(12, 12)
        Me.web1.Name = "web1"
        Me.web1.Size = New System.Drawing.Size(176, 26)
        Me.web1.TabIndex = 8
        Me.web1.Text = "17班官网"
        Me.web1.UseVisualStyleBackColor = True
        '
        'website
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 277)
        Me.Controls.Add(Me.webwawa)
        Me.Controls.Add(Me.webcps)
        Me.Controls.Add(Me.webbili)
        Me.Controls.Add(Me.webgame3)
        Me.Controls.Add(Me.webgame2)
        Me.Controls.Add(Me.webgame1)
        Me.Controls.Add(Me.web2)
        Me.Controls.Add(Me.web1)
        Me.Name = "website"
        Me.Text = "网站列表"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents webwawa As Button
    Friend WithEvents webcps As Button
    Friend WithEvents webbili As Button
    Friend WithEvents webgame3 As Button
    Friend WithEvents webgame2 As Button
    Friend WithEvents webgame1 As Button
    Friend WithEvents web2 As Button
    Friend WithEvents web1 As Button
End Class
