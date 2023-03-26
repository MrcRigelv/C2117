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
wshshell.sendKeys "%s"
next
msgbox("Completed!")