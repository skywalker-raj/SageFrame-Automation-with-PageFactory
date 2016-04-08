#cs ----------------------------------------------------------------------------

 AutoIt Version: 3.3.14.0
 Author:         Raj Kumar Thapa

 Script Function:
	Template AutoIt script.
#region --- DeleteCancel generated code Start (v3.3.9.5 KeyboardLayout=00000409)  ---
_WinWaitActivate("The page at http://172.18.12.225:1111 says:","")
Send("{Tab}")
Sleep (100)
Send("{Enter}")
#endregion --- DeleteCancel generated code End ---
#ce ----------------------------------------------------------------------------

; Script Start - Add your code below here

#region --- Delete generated code Start (v3.3.9.5 KeyboardLayout=00000409)  ---

#region --- Internal functions Delete Start ---
Func _Delete()
Opt('WinWaitDelay',100)
Opt('WinDetectHiddenText',1)
Opt('MouseCoordMode',0)
Local $aResult = DllCall('User32.dll', 'int', 'GetKeyboardLayoutNameW', 'wstr', '')
If $aResult[1] <> '00000409' Then
  MsgBox(64, 'Warning', 'Recording has been done under a different Keyboard layout' & @CRLF & '(00000409->' & $aResult[1] & ')')
EndIf

EndFunc

Func _WinWaitActivate($title,$text,$timeout=5)
	WinWait($title,$text,$timeout)
	If Not WinActive($title,$text) Then WinActivate($title,$text)
	WinWaitActive($title,$text,$timeout)
EndFunc

_Delete()

#region --- Au3Recorder generated code Start (v3.3.9.5 KeyboardLayout=00000409)  ---
_WinWaitActivate("The page at http://172.18.12.225:1111 says:","")
MouseClick("left",206,88,1)
#endregion --- Au3Recorder generated code End ---




