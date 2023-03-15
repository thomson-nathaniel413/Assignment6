<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpeedTest
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
        Me.lblSpeedTest = New System.Windows.Forms.Label()
        Me.btnEnterSpeed = New System.Windows.Forms.Button()
        Me.lstSpeeds = New System.Windows.Forms.ListBox()
        Me.lblAverageIndicator = New System.Windows.Forms.Label()
        Me.lblAverageSpeed = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSpeedTest
        '
        Me.lblSpeedTest.AutoSize = True
        Me.lblSpeedTest.Location = New System.Drawing.Point(336, 101)
        Me.lblSpeedTest.Name = "lblSpeedTest"
        Me.lblSpeedTest.Size = New System.Drawing.Size(203, 20)
        Me.lblSpeedTest.TabIndex = 0
        Me.lblSpeedTest.Text = "Internet Speed Test Survey"
        '
        'btnEnterSpeed
        '
        Me.btnEnterSpeed.Location = New System.Drawing.Point(283, 191)
        Me.btnEnterSpeed.Name = "btnEnterSpeed"
        Me.btnEnterSpeed.Size = New System.Drawing.Size(300, 50)
        Me.btnEnterSpeed.TabIndex = 1
        Me.btnEnterSpeed.Text = "Enter Internet Speed"
        Me.btnEnterSpeed.UseVisualStyleBackColor = True
        '
        'lstSpeeds
        '
        Me.lstSpeeds.FormattingEnabled = True
        Me.lstSpeeds.ItemHeight = 20
        Me.lstSpeeds.Location = New System.Drawing.Point(637, 78)
        Me.lstSpeeds.Name = "lstSpeeds"
        Me.lstSpeeds.Size = New System.Drawing.Size(120, 244)
        Me.lstSpeeds.TabIndex = 2
        '
        'lblAverageIndicator
        '
        Me.lblAverageIndicator.AutoSize = True
        Me.lblAverageIndicator.Location = New System.Drawing.Point(356, 364)
        Me.lblAverageIndicator.Name = "lblAverageIndicator"
        Me.lblAverageIndicator.Size = New System.Drawing.Size(183, 20)
        Me.lblAverageIndicator.TabIndex = 3
        Me.lblAverageIndicator.Text = "Average Internet Speed:"
        '
        'lblAverageSpeed
        '
        Me.lblAverageSpeed.AutoSize = True
        Me.lblAverageSpeed.Location = New System.Drawing.Point(604, 364)
        Me.lblAverageSpeed.Name = "lblAverageSpeed"
        Me.lblAverageSpeed.Size = New System.Drawing.Size(61, 20)
        Me.lblAverageSpeed.TabIndex = 4
        Me.lblAverageSpeed.Text = "0 Mbps"
        '
        'frmSpeedTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAverageSpeed)
        Me.Controls.Add(Me.lblAverageIndicator)
        Me.Controls.Add(Me.lstSpeeds)
        Me.Controls.Add(Me.btnEnterSpeed)
        Me.Controls.Add(Me.lblSpeedTest)
        Me.Name = "frmSpeedTest"
        Me.Text = "Internet Speed Test Survey for Home Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSpeedTest As Label
    Friend WithEvents btnEnterSpeed As Button
    Friend WithEvents lstSpeeds As ListBox
    Friend WithEvents lblAverageIndicator As Label
    Friend WithEvents lblAverageSpeed As Label
End Class
