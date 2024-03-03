<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorTable
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
        Me.DoctorID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfJoiningCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contact_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DoctorTableAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(793, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 39)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Add doctor"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'StaffTableLabel
        '
        Me.StaffTableLabel.AutoSize = True
        Me.StaffTableLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffTableLabel.ForeColor = System.Drawing.Color.Gold
        Me.StaffTableLabel.Location = New System.Drawing.Point(92, 59)
        Me.StaffTableLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.StaffTableLabel.Name = "StaffTableLabel"
        Me.StaffTableLabel.Size = New System.Drawing.Size(189, 32)
        Me.StaffTableLabel.TabIndex = 4
        Me.StaffTableLabel.Text = "Doctor Table"
        '
        'DoctorTableAdmin
        '
        Me.DoctorTableAdmin.AllowUserToAddRows = False
        Me.DoctorTableAdmin.AllowUserToDeleteRows = False
        Me.DoctorTableAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoctorTableAdmin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DoctorID, Me.StaffCol, Me.Sex, Me.DateOfJoiningCol, Me.PositionCol, Me.Email, Me.Timing, Me.Contact_no, Me.Salary})
        Me.DoctorTableAdmin.Location = New System.Drawing.Point(91, 139)
        Me.DoctorTableAdmin.Margin = New System.Windows.Forms.Padding(2)
        Me.DoctorTableAdmin.Name = "DoctorTableAdmin"
        Me.DoctorTableAdmin.Size = New System.Drawing.Size(900, 374)
        Me.DoctorTableAdmin.TabIndex = 6
        '
        'DoctorID
        '
        Me.DoctorID.HeaderText = "DoctorID"
        Me.DoctorID.Name = "DoctorID"
        '
        'StaffCol
        '
        Me.StaffCol.HeaderText = "Name"
        Me.StaffCol.MinimumWidth = 150
        Me.StaffCol.Name = "StaffCol"
        Me.StaffCol.Width = 150
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
        'PositionCol
        '
        Me.PositionCol.HeaderText = "Specialization"
        Me.PositionCol.Name = "PositionCol"
        '
        'Email
        '
        Me.Email.HeaderText = "Email ID"
        Me.Email.MinimumWidth = 50
        Me.Email.Name = "Email"
        '
        'Timing
        '
        Me.Timing.HeaderText = "Timing"
        Me.Timing.Name = "Timing"
        '
        'Contact_no
        '
        Me.Contact_no.HeaderText = "Contact_no"
        Me.Contact_no.Name = "Contact_no"
        '
        'Salary
        '
        Me.Salary.HeaderText = "Salary"
        Me.Salary.Name = "Salary"
        '
        'DoctorTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1082, 653)
        Me.ControlBox = False
        Me.Controls.Add(Me.DoctorTableAdmin)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StaffTableLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "DoctorTable"
        CType(Me.DoctorTableAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents StaffTableLabel As System.Windows.Forms.Label
    Friend WithEvents DoctorTableAdmin As System.Windows.Forms.DataGridView
    Friend WithEvents DoctorID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StaffCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfJoiningCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PositionCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timing As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contact_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Salary As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
