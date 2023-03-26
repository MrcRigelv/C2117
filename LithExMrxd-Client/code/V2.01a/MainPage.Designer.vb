<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPage
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.选项ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.说明ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.网站ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.createdtex = New System.Windows.Forms.ToolStripStatusLabel()
        Me.timebox = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Mudules = New System.Windows.Forms.GroupBox()
        Me.opkeystroke = New System.Windows.Forms.Button()
        Me.closevbs = New System.Windows.Forms.Button()
        Me.startac2 = New System.Windows.Forms.Button()
        Me.startac = New System.Windows.Forms.Button()
        Me.startsystemt = New System.Windows.Forms.Button()
        Me.startbtc = New System.Windows.Forms.Button()
        Me.startmsghack = New System.Windows.Forms.Button()
        Me.startcalc = New System.Windows.Forms.Button()
        Me.mudulessld1 = New System.Windows.Forms.VScrollBar()
        Me.startcmd = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.systtools = New System.Windows.Forms.GroupBox()
        Me.backding = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.closesysttool = New System.Windows.Forms.Button()
        Me.autoshutdown = New System.Windows.Forms.Button()
        Me.renetip1 = New System.Windows.Forms.Button()
        Me.exitnetip1 = New System.Windows.Forms.Button()
        Me.kystbox = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.closeuikyst = New System.Windows.Forms.Button()
        Me.closekyst = New System.Windows.Forms.Button()
        Me.startkyst = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.processday = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.seco = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.minbar = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hourbar = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.daybar = New System.Windows.Forms.ProgressBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MudulesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Mudules.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.systtools.SuspendLayout()
        Me.kystbox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Minecraft", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.选项ToolStripMenuItem, Me.关于ToolStripMenuItem, Me.网站ToolStripMenuItem, Me.MudulesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1262, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '选项ToolStripMenuItem
        '
        Me.选项ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.设置ToolStripMenuItem, Me.说明ToolStripMenuItem})
        Me.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem"
        Me.选项ToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.选项ToolStripMenuItem.Text = "选项"
        '
        '设置ToolStripMenuItem
        '
        Me.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem"
        Me.设置ToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.设置ToolStripMenuItem.Text = "设置"
        '
        '说明ToolStripMenuItem
        '
        Me.说明ToolStripMenuItem.Name = "说明ToolStripMenuItem"
        Me.说明ToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.说明ToolStripMenuItem.Text = "说明"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        '网站ToolStripMenuItem
        '
        Me.网站ToolStripMenuItem.Name = "网站ToolStripMenuItem"
        Me.网站ToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.网站ToolStripMenuItem.Text = "网站"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusStrip1.Font = New System.Drawing.Font("Minecraft", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.createdtex, Me.timebox})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 651)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1262, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'createdtex
        '
        Me.createdtex.BackColor = System.Drawing.SystemColors.Control
        Me.createdtex.Font = New System.Drawing.Font("Minecraft", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.createdtex.ForeColor = System.Drawing.Color.Black
        Me.createdtex.Name = "createdtex"
        Me.createdtex.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.createdtex.Size = New System.Drawing.Size(259, 16)
        Me.createdtex.Text = "Created by C211733 , C211756"
        '
        'timebox
        '
        Me.timebox.Font = New System.Drawing.Font("Minecraft", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.timebox.ForeColor = System.Drawing.Color.Blue
        Me.timebox.Name = "timebox"
        Me.timebox.Size = New System.Drawing.Size(89, 16)
        Me.timebox.Text = "[当前时间]"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Mudules
        '
        Me.Mudules.Controls.Add(Me.opkeystroke)
        Me.Mudules.Controls.Add(Me.closevbs)
        Me.Mudules.Controls.Add(Me.startac2)
        Me.Mudules.Controls.Add(Me.startac)
        Me.Mudules.Controls.Add(Me.startsystemt)
        Me.Mudules.Controls.Add(Me.startbtc)
        Me.Mudules.Controls.Add(Me.startmsghack)
        Me.Mudules.Controls.Add(Me.startcalc)
        Me.Mudules.Controls.Add(Me.mudulessld1)
        Me.Mudules.Location = New System.Drawing.Point(0, 39)
        Me.Mudules.Name = "Mudules"
        Me.Mudules.Size = New System.Drawing.Size(246, 596)
        Me.Mudules.TabIndex = 2
        Me.Mudules.TabStop = False
        '
        'opkeystroke
        '
        Me.opkeystroke.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.opkeystroke.ForeColor = System.Drawing.Color.Lime
        Me.opkeystroke.Location = New System.Drawing.Point(6, 384)
        Me.opkeystroke.Name = "opkeystroke"
        Me.opkeystroke.Size = New System.Drawing.Size(212, 47)
        Me.opkeystroke.TabIndex = 10
        Me.opkeystroke.Text = "启动按键显示"
        Me.opkeystroke.UseVisualStyleBackColor = False
        '
        'closevbs
        '
        Me.closevbs.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.closevbs.ForeColor = System.Drawing.Color.Lime
        Me.closevbs.Location = New System.Drawing.Point(6, 331)
        Me.closevbs.Name = "closevbs"
        Me.closevbs.Size = New System.Drawing.Size(212, 47)
        Me.closevbs.TabIndex = 9
        Me.closevbs.Text = "一键关闭vbs程序"
        Me.closevbs.UseVisualStyleBackColor = False
        '
        'startac2
        '
        Me.startac2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.startac2.ForeColor = System.Drawing.Color.Yellow
        Me.startac2.Location = New System.Drawing.Point(6, 278)
        Me.startac2.Name = "startac2"
        Me.startac2.Size = New System.Drawing.Size(212, 47)
        Me.startac2.TabIndex = 8
        Me.startac2.Text = "连点器测试版"
        Me.startac2.UseVisualStyleBackColor = False
        '
        'startac
        '
        Me.startac.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.startac.ForeColor = System.Drawing.Color.Yellow
        Me.startac.Location = New System.Drawing.Point(6, 225)
        Me.startac.Name = "startac"
        Me.startac.Size = New System.Drawing.Size(212, 47)
        Me.startac.TabIndex = 7
        Me.startac.Text = "启用鼠大侠连点器"
        Me.startac.UseVisualStyleBackColor = False
        '
        'startsystemt
        '
        Me.startsystemt.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.startsystemt.ForeColor = System.Drawing.Color.Fuchsia
        Me.startsystemt.Location = New System.Drawing.Point(6, 172)
        Me.startsystemt.Name = "startsystemt"
        Me.startsystemt.Size = New System.Drawing.Size(212, 47)
        Me.startsystemt.TabIndex = 4
        Me.startsystemt.Text = "启动系统工具"
        Me.startsystemt.UseVisualStyleBackColor = False
        '
        'startbtc
        '
        Me.startbtc.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.startbtc.ForeColor = System.Drawing.Color.Lime
        Me.startbtc.Location = New System.Drawing.Point(6, 119)
        Me.startbtc.Name = "startbtc"
        Me.startbtc.Size = New System.Drawing.Size(212, 47)
        Me.startbtc.TabIndex = 3
        Me.startbtc.Text = "启动摸鱼器"
        Me.startbtc.UseVisualStyleBackColor = False
        '
        'startmsghack
        '
        Me.startmsghack.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.startmsghack.ForeColor = System.Drawing.Color.Red
        Me.startmsghack.Location = New System.Drawing.Point(6, 66)
        Me.startmsghack.Name = "startmsghack"
        Me.startmsghack.Size = New System.Drawing.Size(212, 47)
        Me.startmsghack.TabIndex = 2
        Me.startmsghack.Text = "启动刷屏器"
        Me.startmsghack.UseVisualStyleBackColor = False
        '
        'startcalc
        '
        Me.startcalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.startcalc.ForeColor = System.Drawing.Color.Cyan
        Me.startcalc.Location = New System.Drawing.Point(6, 13)
        Me.startcalc.Name = "startcalc"
        Me.startcalc.Size = New System.Drawing.Size(212, 47)
        Me.startcalc.TabIndex = 1
        Me.startcalc.Text = "启动计算器"
        Me.startcalc.UseVisualStyleBackColor = False
        '
        'mudulessld1
        '
        Me.mudulessld1.Location = New System.Drawing.Point(221, 13)
        Me.mudulessld1.Name = "mudulessld1"
        Me.mudulessld1.Size = New System.Drawing.Size(22, 580)
        Me.mudulessld1.TabIndex = 0
        '
        'startcmd
        '
        Me.startcmd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.startcmd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.startcmd.Location = New System.Drawing.Point(6, 183)
        Me.startcmd.Name = "startcmd"
        Me.startcmd.Size = New System.Drawing.Size(166, 59)
        Me.startcmd.TabIndex = 6
        Me.startcmd.Text = "启动CMD"
        Me.startcmd.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(178, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 60)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "启动任务管理器"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.systtools)
        Me.GroupBox1.Controls.Add(Me.kystbox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.processday)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.seco)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.minbar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.hourbar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.daybar)
        Me.GroupBox1.Location = New System.Drawing.Point(252, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(998, 596)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'systtools
        '
        Me.systtools.Controls.Add(Me.backding)
        Me.systtools.Controls.Add(Me.Label8)
        Me.systtools.Controls.Add(Me.closesysttool)
        Me.systtools.Controls.Add(Me.autoshutdown)
        Me.systtools.Controls.Add(Me.renetip1)
        Me.systtools.Controls.Add(Me.exitnetip1)
        Me.systtools.Controls.Add(Me.startcmd)
        Me.systtools.Controls.Add(Me.Button1)
        Me.systtools.Location = New System.Drawing.Point(6, 150)
        Me.systtools.Name = "systtools"
        Me.systtools.Size = New System.Drawing.Size(346, 317)
        Me.systtools.TabIndex = 13
        Me.systtools.TabStop = False
        Me.systtools.Visible = False
        '
        'backding
        '
        Me.backding.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.backding.Location = New System.Drawing.Point(178, 183)
        Me.backding.Name = "backding"
        Me.backding.Size = New System.Drawing.Size(162, 59)
        Me.backding.TabIndex = 14
        Me.backding.Text = "一键最小化窗口+返回(测试中)"
        Me.backding.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 18)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "系统工具"
        '
        'closesysttool
        '
        Me.closesysttool.ForeColor = System.Drawing.SystemColors.Window
        Me.closesysttool.Image = CType(resources.GetObject("closesysttool.Image"), System.Drawing.Image)
        Me.closesysttool.Location = New System.Drawing.Point(310, 11)
        Me.closesysttool.Name = "closesysttool"
        Me.closesysttool.Size = New System.Drawing.Size(32, 32)
        Me.closesysttool.TabIndex = 13
        Me.closesysttool.UseVisualStyleBackColor = True
        '
        'autoshutdown
        '
        Me.autoshutdown.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.autoshutdown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.autoshutdown.Location = New System.Drawing.Point(6, 117)
        Me.autoshutdown.Name = "autoshutdown"
        Me.autoshutdown.Size = New System.Drawing.Size(166, 60)
        Me.autoshutdown.TabIndex = 5
        Me.autoshutdown.Text = "自动关机"
        Me.autoshutdown.UseVisualStyleBackColor = False
        '
        'renetip1
        '
        Me.renetip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.renetip1.ForeColor = System.Drawing.Color.Lime
        Me.renetip1.Location = New System.Drawing.Point(178, 49)
        Me.renetip1.Name = "renetip1"
        Me.renetip1.Size = New System.Drawing.Size(164, 61)
        Me.renetip1.TabIndex = 2
        Me.renetip1.Text = "重新连接网络-ip模式"
        Me.renetip1.UseVisualStyleBackColor = False
        '
        'exitnetip1
        '
        Me.exitnetip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.exitnetip1.ForeColor = System.Drawing.Color.Red
        Me.exitnetip1.Location = New System.Drawing.Point(6, 49)
        Me.exitnetip1.Name = "exitnetip1"
        Me.exitnetip1.Size = New System.Drawing.Size(166, 62)
        Me.exitnetip1.TabIndex = 1
        Me.exitnetip1.Text = "断开网络连接-ip模式"
        Me.exitnetip1.UseVisualStyleBackColor = False
        '
        'kystbox
        '
        Me.kystbox.Controls.Add(Me.Label7)
        Me.kystbox.Controls.Add(Me.closeuikyst)
        Me.kystbox.Controls.Add(Me.closekyst)
        Me.kystbox.Controls.Add(Me.startkyst)
        Me.kystbox.Location = New System.Drawing.Point(6, 13)
        Me.kystbox.Name = "kystbox"
        Me.kystbox.Size = New System.Drawing.Size(172, 131)
        Me.kystbox.TabIndex = 12
        Me.kystbox.TabStop = False
        Me.kystbox.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "按键显示菜单"
        '
        'closeuikyst
        '
        Me.closeuikyst.ForeColor = System.Drawing.SystemColors.Window
        Me.closeuikyst.Image = CType(resources.GetObject("closeuikyst.Image"), System.Drawing.Image)
        Me.closeuikyst.Location = New System.Drawing.Point(128, 13)
        Me.closeuikyst.Name = "closeuikyst"
        Me.closeuikyst.Size = New System.Drawing.Size(32, 32)
        Me.closeuikyst.TabIndex = 12
        Me.closeuikyst.UseVisualStyleBackColor = True
        '
        'closekyst
        '
        Me.closekyst.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.closekyst.ForeColor = System.Drawing.Color.Red
        Me.closekyst.Location = New System.Drawing.Point(6, 92)
        Me.closekyst.Name = "closekyst"
        Me.closekyst.Size = New System.Drawing.Size(136, 33)
        Me.closekyst.TabIndex = 11
        Me.closekyst.Text = "关闭按键显示"
        Me.closekyst.UseVisualStyleBackColor = False
        '
        'startkyst
        '
        Me.startkyst.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.startkyst.ForeColor = System.Drawing.Color.Cyan
        Me.startkyst.Location = New System.Drawing.Point(6, 54)
        Me.startkyst.Name = "startkyst"
        Me.startkyst.Size = New System.Drawing.Size(136, 32)
        Me.startkyst.TabIndex = 11
        Me.startkyst.Text = "启动按键显示"
        Me.startkyst.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(312, 432)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(526, 478)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "%"
        '
        'processday
        '
        Me.processday.Location = New System.Drawing.Point(421, 473)
        Me.processday.Name = "processday"
        Me.processday.Size = New System.Drawing.Size(99, 27)
        Me.processday.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(241, 478)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "秒        一天进度"
        '
        'seco
        '
        Me.seco.Location = New System.Drawing.Point(163, 473)
        Me.seco.Name = "seco"
        Me.seco.Size = New System.Drawing.Size(72, 27)
        Me.seco.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 478)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "现在是一天中的第"
        '
        'minbar
        '
        Me.minbar.Location = New System.Drawing.Point(115, 565)
        Me.minbar.Maximum = 60
        Me.minbar.Name = "minbar"
        Me.minbar.Size = New System.Drawing.Size(877, 19)
        Me.minbar.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 566)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "分钟进度条"
        '
        'hourbar
        '
        Me.hourbar.Location = New System.Drawing.Point(115, 535)
        Me.hourbar.Maximum = 60
        Me.hourbar.Name = "hourbar"
        Me.hourbar.Size = New System.Drawing.Size(877, 19)
        Me.hourbar.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 536)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "小时进度条"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 507)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "一日进度条"
        '
        'daybar
        '
        Me.daybar.Location = New System.Drawing.Point(115, 506)
        Me.daybar.Maximum = 86400
        Me.daybar.Name = "daybar"
        Me.daybar.Size = New System.Drawing.Size(877, 19)
        Me.daybar.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(668, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(324, 454)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'MudulesToolStripMenuItem
        '
        Me.MudulesToolStripMenuItem.Name = "MudulesToolStripMenuItem"
        Me.MudulesToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.MudulesToolStripMenuItem.Text = "Mudules"
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Mudules)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Minecraft", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "MainPage"
        Me.Text = "LithExMrxdV-主界面"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Mudules.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.systtools.ResumeLayout(False)
        Me.systtools.PerformLayout()
        Me.kystbox.ResumeLayout(False)
        Me.kystbox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 选项ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 网站ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents createdtex As ToolStripStatusLabel
    Friend WithEvents timebox As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents 设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 说明ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Mudules As GroupBox
    Friend WithEvents startmsghack As Button
    Friend WithEvents startcalc As Button
    Friend WithEvents mudulessld1 As VScrollBar
    Friend WithEvents startbtc As Button
    Friend WithEvents startsystemt As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents minbar As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents hourbar As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents daybar As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents startcmd As Button
    Friend WithEvents processday As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents seco As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents startac As Button
    Friend WithEvents startac2 As Button
    Friend WithEvents closevbs As Button
    Friend WithEvents opkeystroke As Button
    Friend WithEvents kystbox As GroupBox
    Friend WithEvents closekyst As Button
    Friend WithEvents startkyst As Button
    Friend WithEvents closeuikyst As Button
    Friend WithEvents systtools As GroupBox
    Friend WithEvents exitnetip1 As Button
    Friend WithEvents renetip1 As Button
    Friend WithEvents autoshutdown As Button
    Friend WithEvents closesysttool As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents backding As Button
    Friend WithEvents MudulesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
End Class
