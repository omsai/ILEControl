' Print to DebugView.
'
' Molecular Devices' canonical way of debugging MetaMorph is using
' DebugView.  Therefore debug output from this module is generated
' for captured by DebugView.
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

Module debugview
    Private Declare Sub OutputDebugString Lib "kernel32" _
        Alias "OutputDebugStringA" _
        (ByVal lpOutputString As String)

    ' Coped from
    ' http://bytes.com/topic/visual-basic-net/answers/379064-possible-get-name-calling-class-function
    Public Sub print(message As String)
        Dim strace As New System.Diagnostics.StackTrace
        Dim frame As New System.Diagnostics.StackFrame
        Dim method As System.Reflection.MethodBase

        ' Gets the stack frame for the method that called
        ' this one
        frame = strace.GetFrame(1)
        method = frame.GetMethod()

        OutputDebugString(
            method.ReflectedType.Namespace _
            & "." & method.ReflectedType.Name _
            & "." & method.Name & ": " _
            & message)
    End Sub
End Module
