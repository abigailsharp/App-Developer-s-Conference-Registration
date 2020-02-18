<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblRegistrationNumber = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFirstAttend = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.grbAttendance = New System.Windows.Forms.GroupBox()
        Me.lblPrevAttend = New System.Windows.Forms.Label()
        Me.grbAttendance.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(110, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(86, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Calculation Total"
        '
        'lblRegistrationNumber
        '
        Me.lblRegistrationNumber.AutoSize = True
        Me.lblRegistrationNumber.Location = New System.Drawing.Point(12, 65)
        Me.lblRegistrationNumber.Name = "lblRegistrationNumber"
        Me.lblRegistrationNumber.Size = New System.Drawing.Size(243, 13)
        Me.lblRegistrationNumber.TabIndex = 1
        Me.lblRegistrationNumber.Text = "Number of Conference Registrations per Company"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Attended Previous Conferences"
        '
        'lblFirstAttend
        '
        Me.lblFirstAttend.AutoSize = True
        Me.lblFirstAttend.Location = New System.Drawing.Point(6, 28)
        Me.lblFirstAttend.Name = "lblFirstAttend"
        Me.lblFirstAttend.Size = New System.Drawing.Size(130, 13)
        Me.lblFirstAttend.TabIndex = 3
        Me.lblFirstAttend.Text = "First Conference Attended"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(84, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(279, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(176, 28)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(189, 74)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(279, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "88"
        '
        'grbAttendance
        '
        Me.grbAttendance.Controls.Add(Me.lblPrevAttend)
        Me.grbAttendance.Controls.Add(Me.RadioButton2)
        Me.grbAttendance.Controls.Add(Me.RadioButton1)
        Me.grbAttendance.Controls.Add(Me.lblFirstAttend)
        Me.grbAttendance.Location = New System.Drawing.Point(33, 126)
        Me.grbAttendance.Name = "grbAttendance"
        Me.grbAttendance.Size = New System.Drawing.Size(290, 115)
        Me.grbAttendance.TabIndex = 9
        Me.grbAttendance.TabStop = False
        '
        'lblPrevAttend
        '
        Me.lblPrevAttend.AutoSize = True
        Me.lblPrevAttend.Location = New System.Drawing.Point(6, 74)
        Me.lblPrevAttend.Name = "lblPrevAttend"
        Me.lblPrevAttend.Size = New System.Drawing.Size(152, 13)
        Me.lblPrevAttend.TabIndex = 8
        Me.lblPrevAttend.Text = "Attended Previous Conference"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 311)
        Me.Controls.Add(Me.grbAttendance)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblRegistrationNumber)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Conference Registration"
        Me.grbAttendance.ResumeLayout(False)
        Me.grbAttendance.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblRegistrationNumber As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblFirstAttend As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents grbAttendance As GroupBox
    Friend WithEvents lblPrevAttend As Label
End Class
