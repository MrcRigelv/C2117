dim time,bet
time=Inputbox("�����ը����",,25)
bet=Inputbox("��������ʱ��ms",,2)
msgbox("���¿�ʼ")
wscript.sleep 2000
set wshshell=wscript.createobject("wscript.shell")
wshshell.AppActivate"Ҫ���͵��˵�����"
for i=1 to time
wscript.sleep bet
wshshell.sendKeys "^v"
wshshell.sendKeys "%s"
next
msgbox("Completed!")