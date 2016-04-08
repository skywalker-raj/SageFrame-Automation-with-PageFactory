#cs ----------------------------------------------------------------------------

 AutoIt Version: 3.3.14.0
 Author:         myName

 Script Function:
	Template AutoIt script.

#ce ----------------------------------------------------------------------------

; Script Start - Add your code below here
#region --- Au3Recorder generated code Start (v3.3.9.5 KeyboardLayout=00000409)  ---

#region --- Internal functions Au3Recorder Start ---
Func ExportExcel()
Opt('WinWaitDelay',100)
Opt('WinDetectHiddenText',1)
Opt('MouseCoordMode',0)
Local $aResult = DllCall('User32.dll', 'int', 'GetKeyboardLayoutNameW', 'wstr', '')
If $aResult[1] <> '00000409' Then
  MsgBox(64, 'Warning', 'Recording has been done under a different Keyboard layout' & @CRLF & '(00000409->' & $aResult[1] & ')')
EndIf

EndFunc

Func _WinWaitActivate($title,$text,$timeout=0)
	WinWait($title,$text,$timeout)
	If Not WinActive($title,$text) Then WinActivate($title,$text)
	WinWaitActive($title,$text,$timeout)
EndFunc

ExportExcel()
#endregion --- Internal functions ExportExcel End ---

_WinWaitActivate("Opening Analytic-Report_8_04_2015_11_8_8.xls","")
MouseClick("left",47,188,1)
MouseClick("left",286,286,1)
#endregion --- ExportExcel generated code End ---

