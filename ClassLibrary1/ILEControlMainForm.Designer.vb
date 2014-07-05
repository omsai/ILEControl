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
        Me.chkLaser1Enable = New System.Windows.Forms.CheckBox()
        Me.lblEnable = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.txtLaser1Value = New System.Windows.Forms.TextBox()
        Me.lblRange = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblLaser = New System.Windows.Forms.Label()
        Me.lblLaser1Wavelength = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkLaser1Enable
        '
        Me.chkLaser1Enable.AutoSize = True
        Me.chkLaser1Enable.Location = New System.Drawing.Point(60, 31)
        Me.chkLaser1Enable.Name = "chkLaser1Enable"
        Me.chkLaser1Enable.Size = New System.Drawing.Size(15, 14)
        Me.chkLaser1Enable.TabIndex = 0
        Me.chkLaser1Enable.UseVisualStyleBackColor = True
        '
        'lblEnable
        '
        Me.lblEnable.AutoSize = True
        Me.lblEnable.Location = New System.Drawing.Point(56, 9)
        Me.lblEnable.Name = "lblEnable"
        Me.lblEnable.Size = New System.Drawing.Size(40, 13)
        Me.lblEnable.TabIndex = 1
        Me.lblEnable.Text = "Enable"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(102, 9)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(34, 13)
        Me.lblValue.TabIndex = 1
        Me.lblValue.Text = "Value"
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(225, 28)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(187, 21)
        Me.HScrollBar1.TabIndex = 2
        '
        'txtLaser1Value
        '
        Me.txtLaser1Value.Location = New System.Drawing.Point(105, 28)
        Me.txtLaser1Value.Name = "txtLaser1Value"
        Me.txtLaser1Value.Size = New System.Drawing.Size(42, 20)
        Me.txtLaser1Value.TabIndex = 3
        '
        'lblRange
        '
        Me.lblRange.AutoSize = True
        Me.lblRange.Location = New System.Drawing.Point(150, 9)
        Me.lblRange.Name = "lblRange"
        Me.lblRange.Size = New System.Drawing.Size(39, 13)
        Me.lblRange.TabIndex = 4
        Me.lblRange.Text = "Range"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"100", "10", "1", "0.1", "0.01", "0.001"})
        Me.ComboBox1.Location = New System.Drawing.Point(153, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(69, 21)
        Me.ComboBox1.TabIndex = 5
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
        Me.lblLaser1Wavelength.Text = "488 nm"
        '
        'ILEControlMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 180)
        Me.Controls.Add(Me.lblLaser1Wavelength)
        Me.Controls.Add(Me.lblLaser)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblRange)
        Me.Controls.Add(Me.txtLaser1Value)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.lblEnable)
        Me.Controls.Add(Me.chkLaser1Enable)
        Me.Name = "ILEControlMainForm"
        Me.Text = "Spectral ILE Control"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkLaser1Enable As System.Windows.Forms.CheckBox
    Friend WithEvents lblEnable As System.Windows.Forms.Label
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents txtLaser1Value As System.Windows.Forms.TextBox
    Friend WithEvents lblRange As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblLaser As System.Windows.Forms.Label
    Friend WithEvents lblLaser1Wavelength As System.Windows.Forms.Label
End Class
