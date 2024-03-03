<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComplaintAdmin
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
        Me.dateTextBoxCA = New System.Windows.Forms.TextBox()
        Me.complainTypeTextBoxCA = New System.Windows.Forms.TextBox()
        Me.problemTextBoxCA = New System.Windows.Forms.TextBox()
        Me.submitButtonCA = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.staffComboxCA = New System.Windows.Forms.ComboBox()
        Me.PatientID = New System.Windows.Forms.TextBox()
        Me.dateLabelCA = New System.Windows.Forms.Label()
        Me.problemLabelCA = New System.Windows.Forms.Label()
        Me.issuesLabelCA = New System.Windows.Forms.Label()
        Me.userNameLabelCA = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.selectOneLabelCA = New System.Windows.Forms.Label()
        Me.backButtonCA = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dateTextBoxCA
        '
        Me.dateTextBoxCA.Location = New System.Drawing.Point(361, 243)
        Me.dateTextBoxCA.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.dateTextBoxCA.Name = "dateTextBoxCA"
        Me.dateTextBoxCA.Size = New System.Drawing.Size(219, 38)
        Me.dateTextBoxCA.TabIndex = 2
        '
        'complainTypeTextBoxCA
        '
        Me.complainTypeTextBoxCA.Location = New System.Drawing.Point(65, 243)
        Me.complainTypeTextBoxCA.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.complainTypeTextBoxCA.Name = "complainTypeTextBoxCA"
        Me.complainTypeTextBoxCA.Size = New System.Drawing.Size(196, 38)
        Me.complainTypeTextBoxCA.TabIndex = 4
        '
        'problemTextBoxCA
        '
        Me.problemTextBoxCA.Location = New System.Drawing.Point(65, 379)
        Me.problemTextBoxCA.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.problemTextBoxCA.Multiline = True
        Me.problemTextBoxCA.Name = "problemTextBoxCA"
        Me.problemTextBoxCA.Size = New System.Drawing.Size(515, 213)
        Me.problemTextBoxCA.TabIndex = 5
        '
        'submitButtonCA
        '
        Me.submitButtonCA.BackColor = System.Drawing.Color.Gold
        Me.submitButtonCA.Font = New System.Drawing.Font("Comic Sans MS", 16.0!)
        Me.submitButtonCA.ForeColor = System.Drawing.Color.Black
        Me.submitButtonCA.Location = New System.Drawing.Point(842, 704)
        Me.submitButtonCA.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.submitButtonCA.Name = "submitButtonCA"
        Me.submitButtonCA.Size = New System.Drawing.Size(200, 51)
        Me.submitButtonCA.TabIndex = 7
        Me.submitButtonCA.Text = "Submit Now"
        Me.submitButtonCA.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.BackButton.Location = New System.Drawing.Point(2996, 1502)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(236, 80)
        Me.BackButton.TabIndex = 8
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'staffComboxCA
        '
        Me.staffComboxCA.FormattingEnabled = True
        Me.staffComboxCA.Location = New System.Drawing.Point(695, 243)
        Me.staffComboxCA.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.staffComboxCA.Name = "staffComboxCA"
        Me.staffComboxCA.Size = New System.Drawing.Size(238, 39)
        Me.staffComboxCA.TabIndex = 9
        '
        'PatientID
        '
        Me.PatientID.Location = New System.Drawing.Point(65, 113)
        Me.PatientID.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.PatientID.Multiline = True
        Me.PatientID.Name = "PatientID"
        Me.PatientID.Size = New System.Drawing.Size(196, 39)
        Me.PatientID.TabIndex = 4
        '
        'dateLabelCA
        '
        Me.dateLabelCA.AutoSize = True
        Me.dateLabelCA.Font = New System.Drawing.Font("Comic Sans MS", 16.0!)
        Me.dateLabelCA.ForeColor = System.Drawing.Color.White
        Me.dateLabelCA.Location = New System.Drawing.Point(354, 186)
        Me.dateLabelCA.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.dateLabelCA.Name = "dateLabelCA"
        Me.dateLabelCA.Size = New System.Drawing.Size(78, 38)
        Me.dateLabelCA.TabIndex = 10
        Me.dateLabelCA.Text = "Date"
        '
        'problemLabelCA
        '
        Me.problemLabelCA.AutoSize = True
        Me.problemLabelCA.Font = New System.Drawing.Font("Comic Sans MS", 16.0!)
        Me.problemLabelCA.ForeColor = System.Drawing.Color.White
        Me.problemLabelCA.Location = New System.Drawing.Point(58, 308)
        Me.problemLabelCA.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.problemLabelCA.Name = "problemLabelCA"
        Me.problemLabelCA.Size = New System.Drawing.Size(92, 38)
        Me.problemLabelCA.TabIndex = 12
        Me.problemLabelCA.Text = "Detail"
        '
        'issuesLabelCA
        '
        Me.issuesLabelCA.AutoSize = True
        Me.issuesLabelCA.Font = New System.Drawing.Font("Comic Sans MS", 16.0!)
        Me.issuesLabelCA.ForeColor = System.Drawing.Color.White
        Me.issuesLabelCA.Location = New System.Drawing.Point(55, 186)
        Me.issuesLabelCA.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.issuesLabelCA.Name = "issuesLabelCA"
        Me.issuesLabelCA.Size = New System.Drawing.Size(100, 38)
        Me.issuesLabelCA.TabIndex = 13
        Me.issuesLabelCA.Text = "Issues"
        '
        'userNameLabelCA
        '
        Me.userNameLabelCA.AutoSize = True
        Me.userNameLabelCA.Font = New System.Drawing.Font("Comic Sans MS", 16.0!)
        Me.userNameLabelCA.ForeColor = System.Drawing.Color.White
        Me.userNameLabelCA.Location = New System.Drawing.Point(58, 56)
        Me.userNameLabelCA.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.userNameLabelCA.Name = "userNameLabelCA"
        Me.userNameLabelCA.Size = New System.Drawing.Size(149, 38)
        Me.userNameLabelCA.TabIndex = 14
        Me.userNameLabelCA.Text = "Patient ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(99, 328)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 31)
        Me.Label2.TabIndex = 11
        '
        'selectOneLabelCA
        '
        Me.selectOneLabelCA.AutoSize = True
        Me.selectOneLabelCA.Font = New System.Drawing.Font("Comic Sans MS", 16.0!)
        Me.selectOneLabelCA.ForeColor = System.Drawing.Color.White
        Me.selectOneLabelCA.Location = New System.Drawing.Point(687, 186)
        Me.selectOneLabelCA.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.selectOneLabelCA.Name = "selectOneLabelCA"
        Me.selectOneLabelCA.Size = New System.Drawing.Size(113, 38)
        Me.selectOneLabelCA.TabIndex = 16
        Me.selectOneLabelCA.Text = "Allot to"
        '
        'backButtonCA
        '
        Me.backButtonCA.BackColor = System.Drawing.Color.Gold
        Me.backButtonCA.Font = New System.Drawing.Font("Comic Sans MS", 16.0!)
        Me.backButtonCA.ForeColor = System.Drawing.Color.Black
        Me.backButtonCA.Location = New System.Drawing.Point(1160, 704)
        Me.backButtonCA.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.backButtonCA.Name = "backButtonCA"
        Me.backButtonCA.Size = New System.Drawing.Size(200, 51)
        Me.backButtonCA.TabIndex = 17
        Me.backButtonCA.Text = "back"
        Me.backButtonCA.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Location = New System.Drawing.Point(783, 542)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 50)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Assign"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComplaintAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1076, 636)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.backButtonCA)
        Me.Controls.Add(Me.selectOneLabelCA)
        Me.Controls.Add(Me.userNameLabelCA)
        Me.Controls.Add(Me.issuesLabelCA)
        Me.Controls.Add(Me.problemLabelCA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dateLabelCA)
        Me.Controls.Add(Me.staffComboxCA)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.submitButtonCA)
        Me.Controls.Add(Me.problemTextBoxCA)
        Me.Controls.Add(Me.PatientID)
        Me.Controls.Add(Me.complainTypeTextBoxCA)
        Me.Controls.Add(Me.dateTextBoxCA)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "ComplaintAdmin"
        Me.Text = "AdminHandleComplaint"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dateTextBoxCA As System.Windows.Forms.TextBox
    Friend WithEvents complainTypeTextBoxCA As System.Windows.Forms.TextBox
    Friend WithEvents problemTextBoxCA As System.Windows.Forms.TextBox
    Friend WithEvents submitButtonCA As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents staffComboxCA As System.Windows.Forms.ComboBox
    Friend WithEvents PatientID As System.Windows.Forms.TextBox
    Friend WithEvents dateLabelCA As System.Windows.Forms.Label
    Friend WithEvents problemLabelCA As System.Windows.Forms.Label
    Friend WithEvents issuesLabelCA As System.Windows.Forms.Label
    Friend WithEvents userNameLabelCA As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents selectOneLabelCA As System.Windows.Forms.Label
    Friend WithEvents backButtonCA As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
