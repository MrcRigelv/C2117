dim timea,timeb
timea=inputbox("请输入定时关机时间（秒）")
timeb=timea * 1000
if msgbox("是否确定")=vbyes then
wscript.sleep timeb
WSHshell.run"cmd /c""shutdown -s -t 05",4,true
else
end if