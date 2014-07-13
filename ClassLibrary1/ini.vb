' INI file reader.
'
' Helper functions to read MetaMorph settings.  Write support is
' not implemented for safety.
'
' Copyright 2014 Pariksheet Nanda <omsai@member.fsf.org>
'
' License: LGPL-3+
'-----------------------------------------------------------------------
' This file is part of ILEControl.
'
' ILEControl is free software: you can redistribute it and/or modify
' it under the terms of the GNU Lesser General Public License as
' published by the Free Software Foundation, either version 3 of
' the License, or (at your option) any later version.
'
' ILEControl is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU Lesser General Public License for more details.
'
' You should have received a copy of the GNU Lesser General Public
' License along with this program.  If not, see
' <http://www.gnu.org/licenses/>.
'-----------------------------------------------------------------------

Module ini
    ' Read INI file.
    Public Declare Function GetPrivateProfileString Lib "kernel32" _
        Alias "GetPrivateProfileStringA" _
        (ByVal lpSectionName As String, _
         ByVal lpKeyName As String, _
         ByVal lpDefault As String, _
         ByVal lpReturnedString As String, _
         ByVal nSize As Integer, _
         ByVal lpFileName As String) As Integer

    ' GetIniString copied from:
    ' http://www.vbknowledgebase.com/?Id=47&Desc=Read-Write-INI-files-using-VB-.Net
    Public Function GetIniSetting(ByVal strSection As String, _
                                  ByVal strKey As String, _
                                  ByVal strIniPath As String) As String
        Dim strValue As String
        Dim intPos As Integer
        On Error GoTo ErrTrap
        strValue = Space(1024)
        GetPrivateProfileString(strSection, strKey, "NOT_FOUND", strValue, 1024, strIniPath)
        Do While InStrRev(strValue, " ") = Len(strValue)
            strValue = Mid(strValue, 1, Len(strValue) - 1)
        Loop
        ' To remove a special character in the last place.
        strValue = Mid(strValue, 1, Len(strValue) - 1)
        GetIniSetting = strValue
ErrTrap:
        If Err.Number <> 0 Then
            Err.Raise(Err.Number, , "Error form Fucntions.GetIniSettings " & Err.Description)
        End If
    End Function
End Module
