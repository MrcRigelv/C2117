<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class calc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calc))
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
        Me.dvalue1 = New System.Windows.Forms.Label()
        Me.delta1 = New System.Windows.Forms.TextBox()
        Me.resx2 = New System.Windows.Forms.TextBox()
        Me.resx1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.recalc2 = New System.Windows.Forms.Button()
        Me.ssjs = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pangen1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ctext1 = New System.Windows.Forms.TextBox()
        Me.btext1 = New System.Windows.Forms.TextBox()
        Me.atext1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.func1c = New System.Windows.Forms.GroupBox()
        Me.recalc3 = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.b = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.k = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.f1y2 = New System.Windows.Forms.TextBox()
        Me.f1x2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.f1y1 = New System.Windows.Forms.TextBox()
        Me.f1x1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.startscalc = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.func1c.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(281, 60)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "使用方法：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "在第一个和第二个运算数框中填入数据" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "然后选择计算方法" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(在计算三角函数时无需填写第二个数)"
        '
        'clearb1
        '
        Me.clearb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.clearb1.ForeColor = System.Drawing.Color.Cyan
        Me.clearb1.Location = New System.Drawing.Point(223, 176)
        Me.clearb1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.clearb1.Name = "clearb1"
        Me.clearb1.Size = New System.Drawing.Size(48, 34)
        Me.clearb1.TabIndex = 33
        Me.clearb1.Text = "清除"
        Me.clearb1.UseVisualStyleBackColor = False
        '
        'tanb1
        '
        Me.tanb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tanb1.ForeColor = System.Drawing.Color.Cyan
        Me.tanb1.Location = New System.Drawing.Point(169, 176)
        Me.tanb1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tanb1.Name = "tanb1"
        Me.tanb1.Size = New System.Drawing.Size(47, 35)
        Me.tanb1.TabIndex = 32
        Me.tanb1.Text = "tan"
        Me.tanb1.UseVisualStyleBackColor = False
        '
        'cosb1
        '
        Me.cosb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cosb1.ForeColor = System.Drawing.Color.Cyan
        Me.cosb1.Location = New System.Drawing.Point(116, 176)
        Me.cosb1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cosb1.Name = "cosb1"
        Me.cosb1.Size = New System.Drawing.Size(47, 34)
        Me.cosb1.TabIndex = 31
        Me.cosb1.Text = "cos"
        Me.cosb1.UseVisualStyleBackColor = False
        '
        'Sinb1
        '
        Me.Sinb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Sinb1.ForeColor = System.Drawing.Color.Cyan
        Me.Sinb1.Location = New System.Drawing.Point(64, 176)
        Me.Sinb1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Sinb1.Name = "Sinb1"
        Me.Sinb1.Size = New System.Drawing.Size(46, 34)
        Me.Sinb1.TabIndex = 30
        Me.Sinb1.Text = "sin"
        Me.Sinb1.UseVisualStyleBackColor = False
        '
        'rootb1
        '
        Me.rootb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rootb1.ForeColor = System.Drawing.Color.Cyan
        Me.rootb1.Location = New System.Drawing.Point(11, 176)
        Me.rootb1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rootb1.Name = "rootb1"
        Me.rootb1.Size = New System.Drawing.Size(47, 35)
        Me.rootb1.TabIndex = 29
        Me.rootb1.Text = "开方"
        Me.rootb1.UseVisualStyleBackColor = False
        '
        'mib1
        '
        Me.mib1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mib1.ForeColor = System.Drawing.Color.Cyan
        Me.mib1.Location = New System.Drawing.Point(222, 137)
        Me.mib1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mib1.Name = "mib1"
        Me.mib1.Size = New System.Drawing.Size(49, 34)
        Me.mib1.TabIndex = 28
        Me.mib1.Text = "幂"
        Me.mib1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "结果"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 30)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "第一个" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "运算数"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 30)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "第二个" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "运算数"
        '
        'chub1
        '
        Me.chub1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chub1.ForeColor = System.Drawing.Color.Cyan
        Me.chub1.Location = New System.Drawing.Point(169, 136)
        Me.chub1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chub1.Name = "chub1"
        Me.chub1.Size = New System.Drawing.Size(47, 35)
        Me.chub1.TabIndex = 24
        Me.chub1.Text = "除"
        Me.chub1.UseVisualStyleBackColor = False
        '
        'chengb1
        '
        Me.chengb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chengb1.ForeColor = System.Drawing.Color.Cyan
        Me.chengb1.Location = New System.Drawing.Point(116, 137)
        Me.chengb1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chengb1.Name = "chengb1"
        Me.chengb1.Size = New System.Drawing.Size(47, 34)
        Me.chengb1.TabIndex = 23
        Me.chengb1.Text = "乘"
        Me.chengb1.UseVisualStyleBackColor = False
        '
        'jianb1
        '
        Me.jianb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.jianb1.ForeColor = System.Drawing.Color.Cyan
        Me.jianb1.Location = New System.Drawing.Point(64, 137)
        Me.jianb1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.jianb1.Name = "jianb1"
        Me.jianb1.Size = New System.Drawing.Size(46, 34)
        Me.jianb1.TabIndex = 22
        Me.jianb1.Text = "减"
        Me.jianb1.UseVisualStyleBackColor = False
        '
        'plusb1
        '
        Me.plusb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.plusb1.ForeColor = System.Drawing.Color.Cyan
        Me.plusb1.Location = New System.Drawing.Point(12, 137)
        Me.plusb1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.plusb1.Name = "plusb1"
        Me.plusb1.Size = New System.Drawing.Size(46, 34)
        Me.plusb1.TabIndex = 21
        Me.plusb1.Text = "加"
        Me.plusb1.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(81, 83)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(201, 24)
        Me.TextBox3.TabIndex = 20
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(81, 53)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(201, 24)
        Me.TextBox2.TabIndex = 19
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(81, 23)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(201, 24)
        Me.TextBox1.TabIndex = 18
        '
        'dvalue1
        '
        Me.dvalue1.AutoSize = True
        Me.dvalue1.Location = New System.Drawing.Point(15, 156)
        Me.dvalue1.Name = "dvalue1"
        Me.dvalue1.Size = New System.Drawing.Size(61, 15)
        Me.dvalue1.TabIndex = 50
        Me.dvalue1.Text = "Delta="
        '
        'delta1
        '
        Me.delta1.Location = New System.Drawing.Point(91, 153)
        Me.delta1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.delta1.Name = "delta1"
        Me.delta1.Size = New System.Drawing.Size(197, 24)
        Me.delta1.TabIndex = 49
        '
        'resx2
        '
        Me.resx2.Location = New System.Drawing.Point(18, 250)
        Me.resx2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.resx2.Name = "resx2"
        Me.resx2.Size = New System.Drawing.Size(270, 24)
        Me.resx2.TabIndex = 48
        '
        'resx1
        '
        Me.resx1.Location = New System.Drawing.Point(18, 222)
        Me.resx1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.resx1.Name = "resx1"
        Me.resx1.Size = New System.Drawing.Size(270, 24)
        Me.resx1.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 199)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 15)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "解"
        '
        'recalc2
        '
        Me.recalc2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.recalc2.ForeColor = System.Drawing.Color.Cyan
        Me.recalc2.Location = New System.Drawing.Point(158, 76)
        Me.recalc2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.recalc2.Name = "recalc2"
        Me.recalc2.Size = New System.Drawing.Size(130, 34)
        Me.recalc2.TabIndex = 45
        Me.recalc2.Text = "求解"
        Me.recalc2.UseVisualStyleBackColor = False
        '
        'ssjs
        '
        Me.ssjs.Location = New System.Drawing.Point(175, 125)
        Me.ssjs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ssjs.Name = "ssjs"
        Me.ssjs.Size = New System.Drawing.Size(113, 24)
        Me.ssjs.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 15)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "该方程的实数解数："
        '
        'pangen1
        '
        Me.pangen1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pangen1.ForeColor = System.Drawing.Color.Cyan
        Me.pangen1.Location = New System.Drawing.Point(18, 78)
        Me.pangen1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pangen1.Name = "pangen1"
        Me.pangen1.Size = New System.Drawing.Size(134, 34)
        Me.pangen1.TabIndex = 42
        Me.pangen1.Text = "判别实数根数"
        Me.pangen1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(198, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 15)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "c="
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(118, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 15)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "b="
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 15)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "a="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(266, 15)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "一元二次方程标准格式ax^2+bx+c=0"
        '
        'ctext1
        '
        Me.ctext1.Location = New System.Drawing.Point(241, 49)
        Me.ctext1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ctext1.Name = "ctext1"
        Me.ctext1.Size = New System.Drawing.Size(47, 24)
        Me.ctext1.TabIndex = 37
        '
        'btext1
        '
        Me.btext1.Location = New System.Drawing.Point(149, 48)
        Me.btext1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btext1.Name = "btext1"
        Me.btext1.Size = New System.Drawing.Size(43, 24)
        Me.btext1.TabIndex = 36
        '
        'atext1
        '
        Me.atext1.Location = New System.Drawing.Point(59, 48)
        Me.atext1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.atext1.Name = "atext1"
        Me.atext1.Size = New System.Drawing.Size(41, 24)
        Me.atext1.TabIndex = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.clearb1)
        Me.GroupBox1.Controls.Add(Me.tanb1)
        Me.GroupBox1.Controls.Add(Me.cosb1)
        Me.GroupBox1.Controls.Add(Me.Sinb1)
        Me.GroupBox1.Controls.Add(Me.rootb1)
        Me.GroupBox1.Controls.Add(Me.mib1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chub1)
        Me.GroupBox1.Controls.Add(Me.chengb1)
        Me.GroupBox1.Controls.Add(Me.jianb1)
        Me.GroupBox1.Controls.Add(Me.plusb1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 5)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(288, 295)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dvalue1)
        Me.GroupBox2.Controls.Add(Me.delta1)
        Me.GroupBox2.Controls.Add(Me.resx2)
        Me.GroupBox2.Controls.Add(Me.resx1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.recalc2)
        Me.GroupBox2.Controls.Add(Me.ssjs)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.pangen1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ctext1)
        Me.GroupBox2.Controls.Add(Me.btext1)
        Me.GroupBox2.Controls.Add(Me.atext1)
        Me.GroupBox2.Location = New System.Drawing.Point(303, 5)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(307, 295)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        '
        'func1c
        '
        Me.func1c.Controls.Add(Me.recalc3)
        Me.func1c.Controls.Add(Me.Label20)
        Me.func1c.Controls.Add(Me.b)
        Me.func1c.Controls.Add(Me.Label19)
        Me.func1c.Controls.Add(Me.k)
        Me.func1c.Controls.Add(Me.Label18)
        Me.func1c.Controls.Add(Me.Label17)
        Me.func1c.Controls.Add(Me.Label16)
        Me.func1c.Controls.Add(Me.f1y2)
        Me.func1c.Controls.Add(Me.f1x2)
        Me.func1c.Controls.Add(Me.Label15)
        Me.func1c.Controls.Add(Me.Label14)
        Me.func1c.Controls.Add(Me.Label13)
        Me.func1c.Controls.Add(Me.f1y1)
        Me.func1c.Controls.Add(Me.f1x1)
        Me.func1c.Controls.Add(Me.Label12)
        Me.func1c.Controls.Add(Me.Label11)
        Me.func1c.Location = New System.Drawing.Point(616, 5)
        Me.func1c.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.func1c.Name = "func1c"
        Me.func1c.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.func1c.Size = New System.Drawing.Size(262, 246)
        Me.func1c.TabIndex = 53
        Me.func1c.TabStop = False
        '
        'recalc3
        '
        Me.recalc3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.recalc3.ForeColor = System.Drawing.Color.Cyan
        Me.recalc3.Location = New System.Drawing.Point(6, 106)
        Me.recalc3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.recalc3.Name = "recalc3"
        Me.recalc3.Size = New System.Drawing.Size(104, 27)
        Me.recalc3.TabIndex = 51
        Me.recalc3.Text = "求解"
        Me.recalc3.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(89, 134)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(25, 15)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "y="
        '
        'b
        '
        Me.b.Location = New System.Drawing.Point(211, 132)
        Me.b.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(45, 24)
        Me.b.TabIndex = 14
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(177, 134)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(25, 15)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "x+"
        '
        'k
        '
        Me.k.Location = New System.Drawing.Point(123, 132)
        Me.k.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.k.Name = "k"
        Me.k.Size = New System.Drawing.Size(48, 24)
        Me.k.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 137)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 15)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "解析式为:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(116, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 15)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "y2="
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 15)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "x2="
        '
        'f1y2
        '
        Me.f1y2.Location = New System.Drawing.Point(159, 86)
        Me.f1y2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.f1y2.Name = "f1y2"
        Me.f1y2.Size = New System.Drawing.Size(61, 24)
        Me.f1y2.TabIndex = 8
        '
        'f1x2
        '
        Me.f1x2.Location = New System.Drawing.Point(49, 86)
        Me.f1x2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.f1x2.Name = "f1x2"
        Me.f1x2.Size = New System.Drawing.Size(61, 24)
        Me.f1x2.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 71)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 15)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "点B(x2,y2)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(116, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 15)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "y1="
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 15)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "x1="
        '
        'f1y1
        '
        Me.f1y1.Location = New System.Drawing.Point(159, 49)
        Me.f1y1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.f1y1.Name = "f1y1"
        Me.f1y1.Size = New System.Drawing.Size(61, 24)
        Me.f1y1.TabIndex = 3
        '
        'f1x1
        '
        Me.f1x1.Location = New System.Drawing.Point(49, 49)
        Me.f1x1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.f1x1.Name = "f1x1"
        Me.f1x1.Size = New System.Drawing.Size(61, 24)
        Me.f1x1.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 15)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "点A(x1,y1)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(247, 15)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "请输入该一次函数中两个点的坐标"
        '
        'startscalc
        '
        Me.startscalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.startscalc.ForeColor = System.Drawing.Color.Cyan
        Me.startscalc.Location = New System.Drawing.Point(620, 255)
        Me.startscalc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.startscalc.Name = "startscalc"
        Me.startscalc.Size = New System.Drawing.Size(258, 45)
        Me.startscalc.TabIndex = 54
        Me.startscalc.Text = "启用精简版计算器悬浮窗口"
        Me.startscalc.UseVisualStyleBackColor = False
        '
        'calc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(881, 311)
        Me.Controls.Add(Me.startscalc)
        Me.Controls.Add(Me.func1c)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Minecraft", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "calc"
        Me.Text = "计算器-界面"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.func1c.ResumeLayout(False)
        Me.func1c.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents dvalue1 As Label
    Friend WithEvents delta1 As TextBox
    Friend WithEvents resx2 As TextBox
    Friend WithEvents resx1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents recalc2 As Button
    Friend WithEvents ssjs As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents pangen1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ctext1 As TextBox
    Friend WithEvents btext1 As TextBox
    Friend WithEvents atext1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents func1c As GroupBox
    Friend WithEvents f1x1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents b As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents k As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents f1y2 As TextBox
    Friend WithEvents f1x2 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents f1y1 As TextBox
    Friend WithEvents recalc3 As Button
    Friend WithEvents startscalc As Button
End Class
