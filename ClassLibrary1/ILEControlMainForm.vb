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
    ' Reference to the module UserMethods
    Dim um As UserMethods

    Declare Auto Function SetParent Lib "user32" _
        (ByVal hWndChild As IntPtr, _
         ByVal hWndNewParent As IntPtr) As Integer
    Declare Auto Function FindWindow Lib "user32" _
        (ByVal lpClassName As String, _
         ByVal lpWindowName As String) As IntPtr

    Public Sub New(ByRef UserMethods)
        um = UserMethods
        InitializeComponent()
    End Sub

    Property mm() As MMAppLib.UserCall
        Get
            Return um.mm
        End Get
        Set(ByVal Value As MMAppLib.UserCall)
            um.mm = Value
        End Set
    End Property

    Private Sub ILEControlMainForm_Load _
        (sender As Object, e As EventArgs) Handles MyBase.Load
        ' This form normally spawns as a separate window which then
        ' hides in the background when you do any work in MetaMorph.
        ' We can't use MdiParent and MdiChild here since MetaMorph is
        ' not written in Visual Basic, so FindWindow and SetParent
        ' allow us to make the form into a child window.
        SetParent(Me.Handle, FindWindow(vbNullString, "MetaMorph"))
        ' Temporarily hard coding these values for testing.
        Dim i405attenuation, i405power, i405shutter, iPort, strPort As Integer
        mm.GetMMVariable("Component.Spectral_LMM_Attenuation_405.Position", i405attenuation)
        mm.GetMMVariable("Component.Spectral_LMM_Power_405.Position", i405power)
        mm.GetMMVariable("Component.Spectral_LMM_Shutter_405.Position", i405shutter)
        mm.GetMMVariable("Component.Spectral_Port_Switch.Position", iPort)
        mm.GetMMVariable("Component.Spectral_Port_Switch.PositionLabel", strPort)
        Me.lblLaser1Wavelength.Text = "405 nm"
        Me.chkLaser1Shutter.Checked = i405shutter
        Me.txtLaser1Power.Text = i405power
        Me.hscLaser1Power.Value = i405power
    End Sub

    Private Sub txtLaser1Power_TextChanged _
        (sender As Object, e As EventArgs) _
        Handles txtLaser1Power.Leave
        Me.hscLaser1Power.Value = Me.txtLaser1Power.Text
        mm.PrintMsg(Me.txtLaser1Power.Text)
    End Sub
    Private Sub txtLaser1Power_KeyDown _
        (sender As Object, e As Windows.Forms.KeyEventArgs) _
        Handles txtLaser1Power.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            Me.hscLaser1Power.Value = Me.txtLaser1Power.Text
            mm.PrintMsg(Me.txtLaser1Power.Text)
        End If
    End Sub
    Private Sub hscLaser1Power_Scroll _
        (sender As Object, e As Windows.Forms.ScrollEventArgs) _
        Handles hscLaser1Power.Scroll
        Me.txtLaser1Power.Text = Me.hscLaser1Power.Value
        mm.PrintMsg(Me.hscLaser1Power.Value)
    End Sub
End Class
