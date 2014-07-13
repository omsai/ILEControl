' Spectral ILE control module.
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

Option Strict Off
Option Explicit On

Public Interface IUserMethods
    Property mm() As MMAppLib.UserCall
    Property gParentWnd() As Integer
    Property gUserID() As Integer

    Function Startup(ByRef cmdLine As String) As Integer
    Function Docommand(ByRef cmdLin As String) As Integer
    Function Shutdown() As Integer
End Interface



<ComClass(UserMethods.ClassId, UserMethods.InterfaceId)> _
Public Class UserMethods
    Implements IUserMethods

    ' Main window handle, but value is incorrect value on 64-bit Windows.
    Private mygParentWnd As Integer

    ' Required variable, but currently unused.
    Private mygUserID As Integer

    ' MetaMorph software handle.
    Public Shared mymm As MMAppLib.UserCall

    Public Const ClassId As String = "832F34A5-5CF5-403f-B4A8-428C8351FD02"
    Public Const InterfaceId As String = "3D8B5BA4-FB8C-5ff8-8468-11BF6BD5CF91"

    Property mm() As MMAppLib.UserCall Implements IUserMethods.mm
        Get
            Return mymm
        End Get
        Set(ByVal Value As MMAppLib.UserCall)
            mymm = Value
        End Set
    End Property
    Property gParentWnd() As Integer Implements IUserMethods.gParentWnd
        Get
            Return mygParentWnd
        End Get
        Set(ByVal Value As Integer)
            mygParentWnd = Value
        End Set
    End Property
    Property gUserID() As Integer Implements IUserMethods.gUserID
        Get
            Return mygUserID
        End Get
        Set(ByVal Value As Integer)
            mygUserID = Value
        End Set
    End Property

    Public Function Startup(ByRef cmdLine As String) As Integer _
        Implements IUserMethods.Startup
        Docommand(cmdLine)
        Return 0
    End Function

    Public Function Docommand(ByRef cmdLine As String) As Integer _
        Implements IUserMethods.Docommand

        Dim ile As SpectralILE
        ile = New SpectralILE()
        ile.components()

        'Dim myNewForm As New ILEControlMainForm()
        'myNewForm.Show()
        Return 0
    End Function

    Public Function Shutdown() As Integer Implements IUserMethods.Shutdown
        Return 0
    End Function
End Class
