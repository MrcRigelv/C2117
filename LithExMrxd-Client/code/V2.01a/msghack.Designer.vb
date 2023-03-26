<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class msghack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(msghack))
        Me.Mode = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.antimsgfolder1 = New System.Windows.Forms.CheckBox()
        Me.startmsgsend = New System.Windows.Forms.Button()
        Me.exitmsghack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Mode
        '
        Me.Mode.FormattingEnabled = True
        Me.Mode.Items.AddRange(New Object() {"钉钉群聊刷屏", "钉钉直播刷屏", "QQ刷屏"})
        Me.Mode.Location = New System.Drawing.Point(105, 4)
        Me.Mode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Mode.Name = "Mode"
        Me.Mode.Size = New System.Drawing.Size(151, 23)
        Me.Mode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "请选择模式"
        '
        'antimsgfolder1
        '
        Me.antimsgfolder1.AutoSize = True
        Me.antimsgfolder1.Location = New System.Drawing.Point(15, 82)
        Me.antimsgfolder1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.antimsgfolder1.Name = "antimsgfolder1"
        Me.antimsgfolder1.Size = New System.Drawing.Size(157, 19)
        Me.antimsgfolder1.TabIndex = 5
        Me.antimsgfolder1.Text = "防止钉钉折叠消息"
        Me.antimsgfolder1.UseVisualStyleBackColor = True
        '
        'startmsgsend
        '
        Me.startmsgsend.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.startmsgsend.Location = New System.Drawing.Point(15, 104)
        Me.startmsgsend.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.startmsgsend.Name = "startmsgsend"
        Me.startmsgsend.Size = New System.Drawing.Size(241, 38)
        Me.startmsgsend.TabIndex = 6
        Me.startmsgsend.Text = "开始刷屏"
        Me.startmsgsend.UseVisualStyleBackColor = False
        '
        'exitmsghack
        '
        Me.exitmsghack.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.exitmsghack.Location = New System.Drawing.Point(15, 147)
        Me.exitmsghack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.exitmsghack.Name = "exitmsghack"
        Me.exitmsghack.Size = New System.Drawing.Size(241, 41)
        Me.exitmsghack.TabIndex = 7
        Me.exitmsghack.Text = "紧急停止刷屏器"
        Me.exitmsghack.UseVisualStyleBackColor = False
        '
        'msghack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(268, 204)
        Me.Controls.Add(Me.exitmsghack)
        Me.Controls.Add(Me.startmsgsend)
        Me.Controls.Add(Me.antimsgfolder1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Mode)
        Me.Font = New System.Drawing.Font("Minecraft", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "msghack"
        Me.Text = "刷屏器-GUI"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Mode As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents antimsgfolder1 As CheckBox
    Friend WithEvents startmsgsend As Button
    Friend WithEvents exitmsghack As Button
End Class
