
@echo off
mshta vbscript:msgbox("请关闭一切杀毒软件并授予Windows命令处理程序管理员权限，即允许Windows命令处理程序具对您的设备进行更改，否则操作可能会失败！",64+4096,"证书操作")(window.close)
%1 %2
mshta vbscript:createobject("shell.application").shellexecute("%~s0","goto runas","goto notadmin","runas",1)(window.close)&&exit
 
:runas
cd /d %~dp0
setlocal enabledelayedexpansion
certmgr.exe -add -c root.spc -s -r localMachine root>>%temp%\config.tmp
for /f "delims=" %%a in (%temp%\config.tmp) do (set var=%%a)
echo %var% | find "CertMgr Failed" > NUL && goto no
echo %var% | find "CertMgr Succeeded" > NUL && goto yes
del /f /q %temp%\config.tmp
 
:no
del /f /s %temp%\your.app.name.key
cls
mshta vbscript:msgbox("证书导入失败，请尝试重新关闭杀毒软件并以管理员权限运行此脚本！",64+4096,"证书操作")(window.close)
exit
 
:yes
echo CertMgr Succeeded>>%temp%\your.app.name.key
mshta vbscript:msgbox("证书导入成功！",64+4096,"证书操作")(window.close)
exit
————————————————
版权声明：本文为CSDN博主「dounick」的原创文章，遵循CC 4.0 BY-SA版权协议，转载请附上原文出处链接及本声明。
原文链接：https://blog.csdn.net/dounick/article/details/105643285