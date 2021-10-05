<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEquality
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
        Me.txtEmployeeform = New System.Windows.Forms.TextBox()
        Me.btnFileSave = New System.Windows.Forms.Button()
        Me.btnEmployeeForm = New System.Windows.Forms.Button()
        Me.btnChosenCandidate = New System.Windows.Forms.Button()
        Me.txtjoboffering = New System.Windows.Forms.TextBox()
        Me.btnJobPosition = New System.Windows.Forms.Button()
        Me.btnemployeenumbers = New System.Windows.Forms.Button()
        Me.txtemployeenumbers = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtEmployeeform
        '
        Me.txtEmployeeform.Location = New System.Drawing.Point(145, 59)
        Me.txtEmployeeform.Multiline = True
        Me.txtEmployeeform.Name = "txtEmployeeform"
        Me.txtEmployeeform.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEmployeeform.Size = New System.Drawing.Size(368, 203)
        Me.txtEmployeeform.TabIndex = 11
        '
        'btnFileSave
        '
        Me.btnFileSave.Location = New System.Drawing.Point(12, 115)
        Me.btnFileSave.Name = "btnFileSave"
        Me.btnFileSave.Size = New System.Drawing.Size(115, 23)
        Me.btnFileSave.TabIndex = 10
        Me.btnFileSave.Text = "Save to files"
        Me.btnFileSave.UseVisualStyleBackColor = True
        '
        'btnEmployeeForm
        '
        Me.btnEmployeeForm.Location = New System.Drawing.Point(12, 86)
        Me.btnEmployeeForm.Name = "btnEmployeeForm"
        Me.btnEmployeeForm.Size = New System.Drawing.Size(115, 23)
        Me.btnEmployeeForm.TabIndex = 9
        Me.btnEmployeeForm.Text = "Employee form"
        Me.btnEmployeeForm.UseVisualStyleBackColor = True
        '
        'btnChosenCandidate
        '
        Me.btnChosenCandidate.Location = New System.Drawing.Point(12, 57)
        Me.btnChosenCandidate.Name = "btnChosenCandidate"
        Me.btnChosenCandidate.Size = New System.Drawing.Size(115, 23)
        Me.btnChosenCandidate.TabIndex = 8
        Me.btnChosenCandidate.Text = "Chosen Candidate"
        Me.btnChosenCandidate.UseVisualStyleBackColor = True
        '
        'txtjoboffering
        '
        Me.txtjoboffering.Location = New System.Drawing.Point(145, 12)
        Me.txtjoboffering.Name = "txtjoboffering"
        Me.txtjoboffering.Size = New System.Drawing.Size(368, 20)
        Me.txtjoboffering.TabIndex = 7
        '
        'btnJobPosition
        '
        Me.btnJobPosition.Location = New System.Drawing.Point(12, 12)
        Me.btnJobPosition.Name = "btnJobPosition"
        Me.btnJobPosition.Size = New System.Drawing.Size(115, 23)
        Me.btnJobPosition.TabIndex = 6
        Me.btnJobPosition.Text = "Job position"
        Me.btnJobPosition.UseVisualStyleBackColor = True
        '
        'btnemployeenumbers
        '
        Me.btnemployeenumbers.Location = New System.Drawing.Point(12, 277)
        Me.btnemployeenumbers.Name = "btnemployeenumbers"
        Me.btnemployeenumbers.Size = New System.Drawing.Size(115, 23)
        Me.btnemployeenumbers.TabIndex = 12
        Me.btnemployeenumbers.Text = "Employee numbers"
        Me.btnemployeenumbers.UseVisualStyleBackColor = True
        '
        'txtemployeenumbers
        '
        Me.txtemployeenumbers.Location = New System.Drawing.Point(145, 277)
        Me.txtemployeenumbers.Multiline = True
        Me.txtemployeenumbers.Name = "txtemployeenumbers"
        Me.txtemployeenumbers.Size = New System.Drawing.Size(368, 49)
        Me.txtemployeenumbers.TabIndex = 13
        '
        'frmEquality
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 338)
        Me.Controls.Add(Me.txtemployeenumbers)
        Me.Controls.Add(Me.btnemployeenumbers)
        Me.Controls.Add(Me.txtEmployeeform)
        Me.Controls.Add(Me.btnFileSave)
        Me.Controls.Add(Me.btnEmployeeForm)
        Me.Controls.Add(Me.btnChosenCandidate)
        Me.Controls.Add(Me.txtjoboffering)
        Me.Controls.Add(Me.btnJobPosition)
        Me.Name = "frmEquality"
        Me.Text = "promoting of gender equality and empowering women"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmployeeform As TextBox
    Friend WithEvents btnFileSave As Button
    Friend WithEvents btnEmployeeForm As Button
    Friend WithEvents btnChosenCandidate As Button
    Friend WithEvents txtjoboffering As TextBox
    Friend WithEvents btnJobPosition As Button
    Friend WithEvents btnemployeenumbers As Button
    Friend WithEvents txtemployeenumbers As TextBox
End Class
