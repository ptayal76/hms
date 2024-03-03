<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientTable
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StaffTableLabel = New System.Windows.Forms.Label()
        Me.DoctorTableAdmin = New System.Windows.Forms.DataGridView()
        Me.PatientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfJoiningCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Blood_Group = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contact_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DoctorTableAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(878, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 32)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Add patient"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'StaffTableLabel
        '
        Me.StaffTableLabel.AutoSize = True
        Me.StaffTableLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffTableLabel.ForeColor = System.Drawing.Color.White
        Me.StaffTableLabel.Location = New System.Drawing.Point(95, 68)
        Me.StaffTableLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.StaffTableLabel.Name = "StaffTableLabel"
        Me.StaffTableLabel.Size = New System.Drawing.Size(107, 20)
        Me.StaffTableLabel.TabIndex = 7
        Me.StaffTableLabel.Text = "Patient Table"
        '
        'DoctorTableAdmin
        '
        Me.DoctorTableAdmin.AllowUserToAddRows = False
        Me.DoctorTableAdmin.AllowUserToDeleteRows = False
        Me.DoctorTableAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoctorTableAdmin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientID, Me.StaffCol, Me.Email, Me.Sex, Me.DateOfJoiningCol, Me.Address, Me.Blood_Group, Me.Contact_no})
        Me.DoctorTableAdmin.Location = New System.Drawing.Point(98, 115)
        Me.DoctorTableAdmin.Margin = New System.Windows.Forms.Padding(2)
        Me.DoctorTableAdmin.Name = "DoctorTableAdmin"
        Me.DoctorTableAdmin.Size = New System.Drawing.Size(900, 374)
        Me.DoctorTableAdmin.TabIndex = 6
        '
        'PatientID
        '
        Me.PatientID.HeaderText = "PatientID"
        Me.PatientID.Name = "PatientID"
        '
        'StaffCol
        '
        Me.StaffCol.HeaderText = "Name"
        Me.StaffCol.MinimumWidth = 150
        Me.StaffCol.Name = "StaffCol"
        Me.StaffCol.Width = 150
        '
        'Email
        '
        Me.Email.HeaderText = "Email ID"
        Me.Email.MinimumWidth = 50
        Me.Email.Name = "Email"
        '
        'Sex
        '
        Me.Sex.HeaderText = "Sex"
        Me.Sex.Name = "Sex"
        '
        'DateOfJoiningCol
        '
        Me.DateOfJoiningCol.HeaderText = "DOB"
        Me.DateOfJoiningCol.Name = "DateOfJoiningCol"
        Me.DateOfJoiningCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        '
        'Blood_Group
        '
        Me.Blood_Group.HeaderText = "Blood_Group"
        Me.Blood_Group.Name = "Blood_Group"
        '
        'Contact_no
        '
        Me.Contact_no.HeaderText = "Contact_no"
        Me.Contact_no.Name = "Contact_no"
        '
        'PatientTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1092, 544)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StaffTableLabel)
        Me.Controls.Add(Me.DoctorTableAdmin)
        Me.Name = "PatientTable"
        Me.Text = "Form1"
        CType(Me.DoctorTableAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents StaffTableLabel As System.Windows.Forms.Label
    Friend WithEvents DoctorTableAdmin As System.Windows.Forms.DataGridView
    Friend WithEvents PatientID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StaffCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfJoiningCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Blood_Group As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contact_no As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
