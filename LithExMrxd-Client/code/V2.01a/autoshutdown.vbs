dim timea,timeb
timea=inputbox("�����붨ʱ�ػ�ʱ�䣨�룩")
timeb=timea * 1000
if msgbox("�Ƿ�ȷ��")=vbyes then
wscript.sleep timeb
WSHshell.run"cmd /c""shutdown -s -t 05",4,true
else
end if