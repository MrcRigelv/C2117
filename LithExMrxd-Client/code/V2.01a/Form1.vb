Imports System.Runtime.InteropServices
'Imports System.Threading
'鼠标连点class，钩子，模拟左键按下，右键按下
Public Class Form1
    'Dim start As Boolean
    Dim hooks As Boolean
    Dim state As String
    Dim i As Int32
    ' Dim flag As Boolean = False
    Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Long, ByVal dx As Long, ByVal dy As Long, ByVal cButtons As Long, ByVal dwExtraInfo As Long)
    Public Const MOUSEEVENTF_LEFTDOWN = &H2 '模拟鼠标左键按下
    Public Const MOUSEEVENTF_LEFTUP = &H4 '模拟鼠标左键释放
    Public Const MOUSEEVENTF_RIGHTDOWN = &H8 '模拟鼠标右键按下
    Public Const MOUSEEVENTF_RIGHTUP = &H10 '模拟鼠标右键释放
    Private Declare Function GetCursorPos Lib "user32" (ByRef lpPoint As POINTAPI) As Long '全屏坐标声明
    Private Declare Function ScreenToClient Lib "user32.dll" (ByVal hwnd As Int32, ByRef lpPoint As POINTAPI) As Int32 '窗口坐标声明
    Dim P As POINTAPI

    Private Structure POINTAPI '声明坐标变量
        Public x As Int32 '声明坐标变量为32位
        Public y As Int32 '声明坐标变量为32位
    End Structure
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If R1.Checked = True Then
            Timer1.Interval = TR.Text
            Timer1.Enabled = True
            R1.Enabled = False
            R2.Enabled = False
        End If
        If R2.Checked = True Then
            Timer2.Interval = TR.Text
            Timer2.Enabled = True
            R1.Enabled = False
            R2.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
        R1.Enabled = True
        R2.Enabled = True
    End Sub

    'Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
    '    Select Case keyData
    '        Case Keys.F6
    '            Button1_Click(Nothing, Nothing)
    '            flag = True
    '            Return True
    '        Case Keys.F7
    '            Timer1.Enabled = False
    '        Case Else
    '            Return MyBase.ProcessCmdKey(msg, keyData)   '其他键按默认处理
    '    End Select
    'End Function

    Public KeyHandle As Integer
    Public Function KeyCallback(ByVal Code As Integer, ByVal wParam As Integer, ByVal lParam As IntPtr) As Integer
        If Code >= HC_ACTION Then
            Dim keyStruct As KBDLLHOOKSTRUCT
            keyStruct = CType(Marshal.PtrToStructure(lParam, GetType(KBDLLHOOKSTRUCT)), KBDLLHOOKSTRUCT)
            state &= keyStruct.vkCode.ToString & ControlChars.CrLf
            '这里是检测并屏蔽F6按键
            If keyStruct.vkCode = Keys.F6 Then 'Or keyStruct.vkCode = Keys.R F6
                Button1_Click(Nothing, Nothing)
                Return 1
            End If
            If keyStruct.vkCode = Keys.F7 Then 'Or keyStruct.vkCode = Keys.R F7
                Button2_Click(Nothing, Nothing)
                Return 1
            End If
        End If
        Return CallNextHookEx(KeyHandle, Code, wParam, lParam)
    End Function

    Public Sub HookKeyboard()
        callback = New KeyHook(AddressOf KeyCallback)
        Dim hins As IntPtr = IntPtr.Zero
        hins = GetModuleHandle(Process.GetCurrentProcess.MainModule.ModuleName)
        KeyHandle = SetWindowsHookEx(WH_KEYBOARD_LL, callback, hins, 0)
        'If (KeyHandle > 0) Then
        '    state &= "启动钩子" & ControlChars.CrLf
        'Else
        '    state &= "启动钩子失败：" & Err.LastDllError & ControlChars.CrLf
        'End If
    End Sub

    Public Sub UnhookKeyboard()
        Call UnhookWindowsHookEx(KeyHandle) '停止钩子
        'state &= "停止钩子" & ControlChars.CrLf
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HookKeyboard()
        hooks = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TopMost = True Then
            TopMost = False
        ElseIf TopMost = False Then
            TopMost = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If hooks = True Then
            Call UnhookWindowsHookEx(KeyHandle)
        ElseIf hooks = False Then
            Call HookKeyboard()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        run1()
    End Sub
    Sub run1()
        GetCursorPos(P)
        mouse_event(MOUSEEVENTF_LEFTDOWN, P.x.ToString, P.y.ToString, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, P.x.ToString, P.y.ToString, 0, 0)
        i += 1
        Text = "鼠标连点--" & " 正在点击:" & i
    End Sub
    Sub run2()
        mouse_event(MOUSEEVENTF_RIGHTDOWN, P.x.ToString, P.y.ToString, 0, 0)
        mouse_event(MOUSEEVENTF_RIGHTUP, P.x.ToString, P.y.ToString, 0, 0)
        i += 1
        Text = "鼠标连点--" & " 正在点击:" & i
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        run2()
    End Sub
End Class
