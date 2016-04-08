#cs ----------------------------------------------------------------------------

 AutoIt Version: 3.3.14.0
 Author:         myName

 Script Function:
	Template AutoIt script.
#region --- DownloadOpen generated code Start (v3.3.9.5 KeyboardLayout=00000409)  ---
_WinWaitActivate("Opening test.zip","")
MouseClick("left",46,165,1)
MouseClick("left",284,284,1)
#endregion --- DownloadOpen generated code End ---

#ce ----------------------------------------------------------------------------

; Script Start - Add your code below here
#region --- DownloadSave generated code Start (v3.3.9.5 KeyboardLayout=00000409)  ---

#region --- Internal functions Au3Recorder Start ---
Func Download()
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

Download()
#region --- DownloadSave generated code Start (v3.3.9.5 KeyboardLayout=00000409)  ---
_WinWaitActivate("Opening ContactUs.zip","")
MouseClick("left",45,190,1)
MouseClick("left",295,283,1)
#endregion --- DownloadSave generated code End ---















