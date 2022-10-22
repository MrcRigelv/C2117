msgbox("在使用前，请确定你想刷屏的文字已经被你复制，如果没有请手动在聊天框输入一次并复制")
dim time,bet
time=Inputbox("输入轰炸次数",,25)
bet=Inputbox("请输入间隔时间ms",,2)
msgbox("按下开始")
wscript.sleep 2000
set wshshell=wscript.createobject("wscript.shell")
wshshell.AppActivate"要发送的人的名字"
for i=1 to time
wscript.sleep bet
wshshell.sendKeys "^v"
wshshell.sendKeys "^{ENTER}"
next
msgbox("sucessfully!")