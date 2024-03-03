<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComplaintReg
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
        Me.complaintTypeLabelCR = New System.Windows.Forms.Label()
        Me.DetailText = New System.Windows.Forms.Label()
        Me.backButtonCR = New System.Windows.Forms.Button()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.dateLabelCR = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.submitButtonCR = New System.Windows.Forms.Button()
        Me.complaintsTableLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'complaintTypeLabelCR
        '
        Me.complaintTypeLabelCR.AutoSize = True
        Me.complaintTypeLabelCR.BackColor = System.Drawing.Color.Black
        Me.complaintTypeLabelCR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.complaintTypeLabelCR.ForeColor = System.Drawing.Color.White
        Me.complaintTypeLabelCR.Location = New System.Drawing.Point(501, 199)
        Me.complaintTypeLabelCR.Name = "complaintTypeLabelCR"
        Me.complaintTypeLabelCR.Size = New System.Drawing.Size(164, 26)
        Me.complaintTypeLabelCR.TabIndex = 3
        Me.complaintTypeLabelCR.Text = "Complaint Type"
        '
        'DetailText
        '
        Me.DetailText.AutoSize = True
        Me.DetailText.BackColor = System.Drawing.Color.Black
        Me.DetailText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DetailText.ForeColor = System.Drawing.Color.White
        Me.DetailText.Location = New System.Drawing.Point(503, 338)
        Me.DetailText.Name = "DetailText"
        Me.DetailText.Size = New System.Drawing.Size(191, 26)
        Me.DetailText.TabIndex = 4
        Me.DetailText.Text = "Describe the issue"
        '
        'backButtonCR
        '
        Me.backButtonCR.BackColor = System.Drawing.Color.Gold
        Me.backButtonCR.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.backButtonCR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.backButtonCR.ForeColor = System.Drawing.Color.Black
        Me.backButtonCR.Location = New System.Drawing.Point(874, 517)
        Me.backButtonCR.Name = "backButtonCR"
        Me.backButtonCR.Size = New System.Drawing.Size(200, 50)
        Me.backButtonCR.TabIndex = 5
        Me.backButtonCR.Text = "Back"
        Me.backButtonCR.UseVisualStyleBackColor = False
        '
        'DateTimePicker
        '
        Me.DateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DateTimePicker.Location = New System.Drawing.Point(771, 241)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(225, 32)
        Me.DateTimePicker.TabIndex = 6
        '
        'dateLabelCR
        '
        Me.dateLabelCR.AutoSize = True
        Me.dateLabelCR.BackColor = System.Drawing.Color.Black
        Me.dateLabelCR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dateLabelCR.ForeColor = System.Drawing.Color.White
        Me.dateLabelCR.Location = New System.Drawing.Point(766, 199)
        Me.dateLabelCR.Name = "dateLabelCR"
        Me.dateLabelCR.Size = New System.Drawing.Size(58, 26)
        Me.dateLabelCR.TabIndex = 7
        Me.dateLabelCR.Text = "Date"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(508, 243)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(113, 34)
        Me.ComboBox1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(501, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 26)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Patient ID"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(506, 100)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(372, 32)
        Me.TextBox1.TabIndex = 11
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RichTextBox2.Location = New System.Drawing.Point(506, 383)
        Me.RichTextBox2.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(403, 100)
        Me.RichTextBox2.TabIndex = 8
        Me.RichTextBox2.Text = ""
        '
        'submitButtonCR
        '
        Me.submitButtonCR.BackColor = System.Drawing.Color.Gold
        Me.submitButtonCR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.submitButtonCR.Location = New System.Drawing.Point(508, 517)
        Me.submitButtonCR.Name = "submitButtonCR"
        Me.submitButtonCR.Size = New System.Drawing.Size(177, 50)
        Me.submitButtonCR.TabIndex = 2
        Me.submitButtonCR.Text = "Submit"
        Me.submitButtonCR.UseVisualStyleBackColor = False
        '
        'complaintsTableLabel
        '
        Me.complaintsTableLabel.AutoSize = True
        Me.complaintsTableLabel.Font = New System.Drawing.Font("Lucida Sans Unicode", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.complaintsTableLabel.ForeColor = System.Drawing.Color.Gold
        Me.complaintsTableLabel.Location = New System.Drawing.Point(80, 305)
        Me.complaintsTableLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.complaintsTableLabel.Name = "complaintsTableLabel"
        Me.complaintsTableLabel.Size = New System.Drawing.Size(227, 44)
        Me.complaintsTableLabel.TabIndex = 17
        Me.complaintsTableLabel.Text = "Complaints"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(80, 216)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 44)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Add your "
        '
        'ComplaintReg
        '
        Me.AcceptButton = Me.backButtonCR
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.CancelButton = Me.backButtonCR
        Me.ClientSize = New System.Drawing.Size(1297, 792)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.complaintsTableLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.dateLabelCR)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.backButtonCR)
        Me.Controls.Add(Me.DetailText)
        Me.Controls.Add(Me.complaintTypeLabelCR)
        Me.Controls.Add(Me.submitButtonCR)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "ComplaintReg"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents complaintTypeLabelCR As System.Windows.Forms.Label
    Friend WithEvents DetailText As System.Windows.Forms.Label
    Friend WithEvents backButtonCR As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateLabelCR As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents submitButtonCR As System.Windows.Forms.Button
    Friend WithEvents complaintsTableLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
