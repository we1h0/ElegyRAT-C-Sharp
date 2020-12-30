@echo off
echo ============================================
echo = 【名称：】工程清理.BAT                   =
echo = 【作者：】we1h0                          =
echo = 【日期：】2020-12-30                     =
echo = 【版本：】Ver1.0                         =
echo = 【网址：】http://github.com/zhaoweiho    =
echo ============================================
pause
echo 正在清理中，请稍等......
echo===========================================================================
 
FOR /R %dir% %%d IN (vc60.pdb vc90.pdb *.exp *.obj *.pch *.idb *.ncb *.opt *.plg *.sbr *.ilk *.aps *.sdf *.temp *.dcu *.bsc *.ipch) DO DEL /f /s /q "%%d" 2>nul
FOR /R . %%d IN (.) DO rd /s /q "%%d\Debug" 2>nul
FOR /R . %%d IN (.) DO rd /s /q "%%d\Release" 2>nul
FOR /R . %%d IN (.) DO rd /s /q "%%d\obj" 2>nul
rd /s /q packages 2>nul
rd /s /q Binaries 2>nul
echo===========================================================================
 
ECHO 文件清理完毕！本程序将在5秒后退出！现在进入倒计时......... 
@echo off 
echo WScript.Sleep 300 > %temp%.\tmp
$.vbsset/ai=5:Timeoutifsetlocalset/ai=echo倒计时……cscript//nologo
$.vbs 
goto Timeout 
goto End 
:Next 
cls & 
echo.