<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ILEControlMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.chkLaser1Shutter = New System.Windows.Forms.CheckBox()
        Me.lblShutter = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.hscLaser1Power = New System.Windows.Forms.HScrollBar()
        Me.txtLaser1Power = New System.Windows.Forms.TextBox()
        Me.lblRange = New System.Windows.Forms.Label()
        Me.cmbLaser1Range = New System.Windows.Forms.ComboBox()
        Me.lblLaser = New System.Windows.Forms.Label()
        Me.lblLaser1Wavelength = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkLaser1Shutter
        '
        Me.chkLaser1Shutter.AutoSize = True
        Me.chkLaser1Shutter.Location = New System.Drawing.Point(60, 31)
        Me.chkLaser1Shutter.Name = "chkLaser1Shutter"
        Me.chkLaser1Shutter.Size = New System.Drawing.Size(15, 14)
        Me.chkLaser1Shutter.TabIndex = 0
        Me.chkLaser1Shutter.UseVisualStyleBackColor = True
        '
        'lblShutter
        '
        Me.lblShutter.AutoSize = True
        Me.lblShutter.Location = New System.Drawing.Point(56, 9)
        Me.lblShutter.Name = "lblShutter"
        Me.lblShutter.Size = New System.Drawing.Size(41, 13)
        Me.lblShutter.TabIndex = 1
        Me.lblShutter.Text = "Shutter"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(177, 9)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(34, 13)
        Me.lblValue.TabIndex = 1
        Me.lblValue.Text = "Value"
        '
        'hscLaser1Power
        '
        Me.hscLaser1Power.Location = New System.Drawing.Point(225, 28)
        Me.hscLaser1Power.Name = "hscLaser1Power"
        Me.hscLaser1Power.Size = New System.Drawing.Size(187, 21)
        Me.hscLaser1Power.TabIndex = 3
        Me.hscLaser1Power.TabStop = True
        '
        'txtLaser1Power
        '
        Me.txtLaser1Power.Location = New System.Drawing.Point(180, 29)
        Me.txtLaser1Power.MaxLength = 3
        Me.txtLaser1Power.Name = "txtLaser1Power"
        Me.txtLaser1Power.Size = New System.Drawing.Size(42, 20)
        Me.txtLaser1Power.TabIndex = 2
        Me.txtLaser1Power.Text = "0"
        Me.txtLaser1Power.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRange
        '
        Me.lblRange.AutoSize = True
        Me.lblRange.Location = New System.Drawing.Point(103, 9)
        Me.lblRange.Name = "lblRange"
        Me.lblRange.Size = New System.Drawing.Size(39, 13)
        Me.lblRange.TabIndex = 4
        Me.lblRange.Text = "Range"
        '
        'cmbLaser1Range
        '
        Me.cmbLaser1Range.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLaser1Range.FormattingEnabled = True
        Me.cmbLaser1Range.Items.AddRange(New Object() {"100", "10", "1", "0.1", "0.01", "0.001"})
        Me.cmbLaser1Range.Location = New System.Drawing.Point(105, 29)
        Me.cmbLaser1Range.Name = "cmbLaser1Range"
        Me.cmbLaser1Range.Size = New System.Drawing.Size(69, 21)
        Me.cmbLaser1Range.TabIndex = 1
        '
        'lblLaser
        '
        Me.lblLaser.AutoSize = True
        Me.lblLaser.Location = New System.Drawing.Point(10, 9)
        Me.lblLaser.Name = "lblLaser"
        Me.lblLaser.Size = New System.Drawing.Size(33, 13)
        Me.lblLaser.TabIndex = 6
        Me.lblLaser.Text = "Laser"
        '
        'lblLaser1Wavelength
        '
        Me.lblLaser1Wavelength.AutoSize = True
        Me.lblLaser1Wavelength.Location = New System.Drawing.Point(12, 32)
        Me.lblLaser1Wavelength.Name = "lblLaser1Wavelength"
        Me.lblLaser1Wavelength.Size = New System.Drawing.Size(42, 13)
        Me.lblLaser1Wavelength.TabIndex = 7
        Me.lblLaser1Wavelength.Text = "000 nm"
        '
        'ILEControlMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 180)
        Me.Controls.Add(Me.lblLaser1Wavelength)
        Me.Controls.Add(Me.lblLaser)
        Me.Controls.Add(Me.cmbLaser1Range)
        Me.Controls.Add(Me.lblRange)
        Me.Controls.Add(Me.txtLaser1Power)
        Me.Controls.Add(Me.hscLaser1Power)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.lblShutter)
        Me.Controls.Add(Me.chkLaser1Shutter)
        Me.Name = "ILEControlMainForm"
        Me.Text = "Spectral ILE Control"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkLaser1Shutter As System.Windows.Forms.CheckBox
    Friend WithEvents lblShutter As System.Windows.Forms.Label
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents hscLaser1Power As System.Windows.Forms.HScrollBar
    Friend WithEvents txtLaser1Power As System.Windows.Forms.TextBox
    Friend WithEvents lblRange As System.Windows.Forms.Label
    Friend WithEvents cmbLaser1Range As System.Windows.Forms.ComboBox
    Friend WithEvents lblLaser As System.Windows.Forms.Label
    Friend WithEvents lblLaser1Wavelength As System.Windows.Forms.Label
End Class
