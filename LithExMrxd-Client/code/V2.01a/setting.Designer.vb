<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class setting
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(setting))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.custitle = New System.Windows.Forms.TextBox()
        Me.enablecustomizetitle = New System.Windows.Forms.CheckBox()
        Me.enablecuspassword = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cuspassword = New System.Windows.Forms.TextBox()
        Me.applypassword = New System.Windows.Forms.Button()
        Me.titleac = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "功能选项"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "请输入标题"
        '
        'custitle
        '
        Me.custitle.Enabled = False
        Me.custitle.Location = New System.Drawing.Point(102, 151)
        Me.custitle.Name = "custitle"
        Me.custitle.Size = New System.Drawing.Size(228, 27)
        Me.custitle.TabIndex = 8
        '
        'enablecustomizetitle
        '
        Me.enablecustomizetitle.AutoSize = True
        Me.enablecustomizetitle.Location = New System.Drawing.Point(12, 127)
        Me.enablecustomizetitle.Name = "enablecustomizetitle"
        Me.enablecustomizetitle.Size = New System.Drawing.Size(136, 24)
        Me.enablecustomizetitle.TabIndex = 9
        Me.enablecustomizetitle.Text = "启动自定义标题"
        Me.enablecustomizetitle.UseVisualStyleBackColor = True
        '
        'enablecuspassword
        '
        Me.enablecuspassword.AutoSize = True
        Me.enablecuspassword.Location = New System.Drawing.Point(12, 32)
        Me.enablecuspassword.Name = "enablecuspassword"
        Me.enablecuspassword.Size = New System.Drawing.Size(319, 24)
        Me.enablecuspassword.TabIndex = 10
        Me.enablecuspassword.Text = "启用自定义密码(仅支持数字,字母,特殊符号)"
        Me.enablecuspassword.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "请输入密码"
        '
        'cuspassword
        '
        Me.cuspassword.Location = New System.Drawing.Point(102, 62)
        Me.cuspassword.Name = "cuspassword"
        Me.cuspassword.Size = New System.Drawing.Size(225, 27)
        Me.cuspassword.TabIndex = 12
        '
        'applypassword
        '
        Me.applypassword.Location = New System.Drawing.Point(12, 92)
        Me.applypassword.Name = "applypassword"
        Me.applypassword.Size = New System.Drawing.Size(94, 29)
        Me.applypassword.TabIndex = 13
        Me.applypassword.Text = "确认密码"
        Me.applypassword.UseVisualStyleBackColor = True
        '
        'titleac
        '
        Me.titleac.Location = New System.Drawing.Point(12, 184)
        Me.titleac.Name = "titleac"
        Me.titleac.Size = New System.Drawing.Size(94, 29)
        Me.titleac.TabIndex = 14
        Me.titleac.Text = "确认标题"
        Me.titleac.UseVisualStyleBackColor = True
        '
        'setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 231)
        Me.Controls.Add(Me.titleac)
        Me.Controls.Add(Me.applypassword)
        Me.Controls.Add(Me.cuspassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.enablecuspassword)
        Me.Controls.Add(Me.enablecustomizetitle)
        Me.Controls.Add(Me.custitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "setting"
        Me.Text = "设置界面"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents custitle As TextBox
    Friend WithEvents enablecustomizetitle As CheckBox
    Friend WithEvents enablecuspassword As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cuspassword As TextBox
    Friend WithEvents applypassword As Button
    Friend WithEvents titleac As Button
End Class
