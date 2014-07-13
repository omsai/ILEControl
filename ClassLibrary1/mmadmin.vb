' MetaMorph Administrator functions.
'
' Retrieve information maintained by the MetaMorph Administrator
' program.
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

Imports System.Xml ' To read hwprofile.xml

Module mmadmin
    ' Path to root folder, e.g.
    ' C:\MM
    Public Function pathMM() As String
        ' Find MetaMorph path from the currently executing
        ' process.
        Dim procMMapps() As System.Diagnostics.Process
        Dim pathMMapp As String
        procMMapps = System.Diagnostics.Process.GetProcessesByName("mmapp")
        pathMMapp = procMMapps(0).Modules(0).FileName
        Return System.IO.Path.GetDirectoryName(pathMMapp)
    End Function

    ' Path to hwprofile.xml, e.g.
    ' C:\MM\Hardware\Default\hwprofile.xml
    Public Function hwprofilePath() As String
        ' Create the hwprofile.xml path.  The mmadmin program stores the
        ' group's hardaware assignment in it's INI file.
        Dim groupName, pathToMM, pathMmadminIni, hardware As String
        groupName = "Default"
        UserMethods.mymm.GetMMVariable("GroupName", groupName)
        pathToMM = mmadmin.pathMM()
        pathMmadminIni = System.IO.Path.Combine({pathToMM, "MMADMIN.INI"})
        hardware = GetIniSetting(groupName, "Hardware", pathMmadminIni)
        Return System.IO.Path.Combine({pathToMM, "Hardware", hardware, "hwprofile.xml"})
    End Function
End Module

' Reads Spectral ILE device information.  XML logic from:
' http://stackoverflow.com/a/15170870
Class SpectralILE
    ' We need to read the MM administrator hwprofile.xml file to
    ' know the names of the ILE components, in case the user has
    ' changed the component names.
    Dim myXmlDoc As New XmlDocument

    ' Make the assumption that only a single device is claimed.
    Public Function getDeviceNodeByDescription(description As String) As XmlNode
        Dim pathXml As String = mmadmin.hwprofilePath()
        myXmlDoc.Load(pathXml)
        Dim items As XmlNodeList = _
            myXmlDoc.SelectNodes(
                "/HardwareProfileInstanceList" _
                & "/HardwareProfileDeviceInstances" _
                & "/Device/DeviceDescription")
        debugview.print("Found " & items.Count & " devices in " & pathXml & ":")
        Dim item As XmlNode
        Dim retItem As XmlNode = Nothing
        For Each item In items
            debugview.print("... " & item.InnerXml)
            If item.InnerXml.Equals(description) Then
                retItem = item.ParentNode
            End If
        Next
        Return retItem
    End Function

    Public Sub components()
        Dim parent As XmlNode = _
            getDeviceNodeByDescription("Spectral LMM/ILE description")
        Dim components As XmlNodeList = _
            parent.SelectNodes("DeviceParameters/Components/Component")
        debugview.print("Found " & components.Count & " ILE components:")
        Dim component As XmlNode
        For Each component In components
            debugview.print("... " & component.SelectSingleNode("ComponentName").InnerText)
        Next
    End Sub
End Class