' Spectral ILE control window.
'
' Similar to MetaMorph's Integrated Confocal System (ICS) window, but
' uses range limiters like those in the Spectral LMM GUI software.
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

Public Class ILEControlMainForm
    Declare Auto Function SetParent Lib "user32" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    Declare Auto Function FindWindow Lib "user32" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr

    Private Sub ILEControlMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetParent(Me.Handle, FindWindow(vbNullString, "MetaMorph"))
    End Sub
End Class