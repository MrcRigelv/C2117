<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class smallcalc
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.clearb1 = New System.Windows.Forms.Button()
        Me.tanb1 = New System.Windows.Forms.Button()
        Me.cosb1 = New System.Windows.Forms.Button()
        Me.Sinb1 = New System.Windows.Forms.Button()
        Me.rootb1 = New System.Windows.Forms.Button()
        Me.mib1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chub1 = New System.Windows.Forms.Button()
        Me.chengb1 = New System.Windows.Forms.Button()
        Me.jianb1 = New System.Windows.Forms.Button()
        Me.plusb1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 80)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "使用方法：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "在第一个和第二个运算数框中填入数据" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "然后选择计算方法" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(在计算三角函数时无需填写第二个数)"
        '
        'clearb1
        '
        Me.clearb1.Location = New System.Drawing.Point(227, 221)
        Me.clearb1.Name = "clearb1"
        Me.clearb1.Size = New System.Drawing.Size(48, 46)
        Me.clearb1.TabIndex = 50
        Me.clearb1.Text = "清除"
        Me.clearb1.UseVisualStyleBackColor = True
        '
        'tanb1
        '
        Me.tanb1.Location = New System.Drawing.Point(173, 220)
        Me.tanb1.Name = "tanb1"
        Me.tanb1.Size = New System.Drawing.Size(47, 47)
        Me.tanb1.TabIndex = 49
        Me.tanb1.Text = "tan"
        Me.tanb1.UseVisualStyleBackColor = True
        '
        'cosb1
        '
        Me.cosb1.Location = New System.Drawing.Point(120, 221)
        Me.cosb1.Name = "cosb1"
        Me.cosb1.Size = New System.Drawing.Size(47, 46)
        Me.cosb1.TabIndex = 48
        Me.cosb1.Text = "cos"
        Me.cosb1.UseVisualStyleBackColor = True
        '
        'Sinb1
        '
        Me.Sinb1.Location = New System.Drawing.Point(68, 221)
        Me.Sinb1.Name = "Sinb1"
        Me.Sinb1.Size = New System.Drawing.Size(46, 46)
        Me.Sinb1.TabIndex = 47
        Me.Sinb1.Text = "sin"
        Me.Sinb1.UseVisualStyleBackColor = True
        '
        'rootb1
        '
        Me.rootb1.Location = New System.Drawing.Point(15, 220)
        Me.rootb1.Name = "rootb1"
        Me.rootb1.Size = New System.Drawing.Size(47, 47)
        Me.rootb1.TabIndex = 46
        Me.rootb1.Text = "开方"
        Me.rootb1.UseVisualStyleBackColor = True
        '
        'mib1
        '
        Me.mib1.Location = New System.Drawing.Point(226, 169)
        Me.mib1.Name = "mib1"
        Me.mib1.Size = New System.Drawing.Size(49, 45)
        Me.mib1.TabIndex = 45
        Me.mib1.Text = "幂"
        Me.mib1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "结果"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 40)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "第一个" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "运算数"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 40)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "第二个" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "运算数"
        '
        'chub1
        '
        Me.chub1.Location = New System.Drawing.Point(173, 168)
        Me.chub1.Name = "chub1"
        Me.chub1.Size = New System.Drawing.Size(47, 47)
        Me.chub1.TabIndex = 41
        Me.chub1.Text = "除"
        Me.chub1.UseVisualStyleBackColor = True
        '
        'chengb1
        '
        Me.chengb1.Location = New System.Drawing.Point(120, 169)
        Me.chengb1.Name = "chengb1"
        Me.chengb1.Size = New System.Drawing.Size(47, 46)
        Me.chengb1.TabIndex = 40
        Me.chengb1.Text = "乘"
        Me.chengb1.UseVisualStyleBackColor = True
        '
        'jianb1
        '
        Me.jianb1.Location = New System.Drawing.Point(68, 169)
        Me.jianb1.Name = "jianb1"
        Me.jianb1.Size = New System.Drawing.Size(46, 45)
        Me.jianb1.TabIndex = 39
        Me.jianb1.Text = "减"
        Me.jianb1.UseVisualStyleBackColor = True
        '
        'plusb1
        '
        Me.plusb1.Location = New System.Drawing.Point(16, 169)
        Me.plusb1.Name = "plusb1"
        Me.plusb1.Size = New System.Drawing.Size(46, 45)
        Me.plusb1.TabIndex = 38
        Me.plusb1.Text = "加"
        Me.plusb1.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(85, 97)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(201, 27)
        Me.TextBox3.TabIndex = 37
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(85, 57)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(201, 27)
        Me.TextBox2.TabIndex = 36
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(85, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(201, 27)
        Me.TextBox1.TabIndex = 35
        '
        'smallcalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 377)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.clearb1)
        Me.Controls.Add(Me.tanb1)
        Me.Controls.Add(Me.cosb1)
        Me.Controls.Add(Me.Sinb1)
        Me.Controls.Add(Me.rootb1)
        Me.Controls.Add(Me.mib1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chub1)
        Me.Controls.Add(Me.chengb1)
        Me.Controls.Add(Me.jianb1)
        Me.Controls.Add(Me.plusb1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "smallcalc"
        Me.Text = "小计算器悬浮窗"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents clearb1 As Button
    Friend WithEvents tanb1 As Button
    Friend WithEvents cosb1 As Button
    Friend WithEvents Sinb1 As Button
    Friend WithEvents rootb1 As Button
    Friend WithEvents mib1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chub1 As Button
    Friend WithEvents chengb1 As Button
    Friend WithEvents jianb1 As Button
    Friend WithEvents plusb1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
