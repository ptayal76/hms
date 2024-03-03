<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffTableAdmin
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
        Me.StaffTableLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StaffAdminTable = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.StaffAdminTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StaffTableLabel
        '
        Me.StaffTableLabel.AutoSize = True
        Me.StaffTableLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffTableLabel.ForeColor = System.Drawing.Color.White
        Me.StaffTableLabel.Location = New System.Drawing.Point(78, 59)
        Me.StaffTableLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.StaffTableLabel.Name = "StaffTableLabel"
        Me.StaffTableLabel.Size = New System.Drawing.Size(90, 20)
        Me.StaffTableLabel.TabIndex = 1
        Me.StaffTableLabel.Text = "Staff Table"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(861, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add staff"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'StaffAdminTable
        '
        Me.StaffAdminTable.AllowUserToAddRows = False
        Me.StaffAdminTable.AllowUserToDeleteRows = False
        Me.StaffAdminTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffAdminTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.StaffName, Me.Sex, Me.DOB, Me.Position, Me.Email_id, Me.Salary, Me.Timing, Me.Contact})
        Me.StaffAdminTable.Location = New System.Drawing.Point(91, 139)
        Me.StaffAdminTable.Margin = New System.Windows.Forms.Padding(2)
        Me.StaffAdminTable.Name = "StaffAdminTable"
        Me.StaffAdminTable.ShowCellToolTips = False
        Me.StaffAdminTable.Size = New System.Drawing.Size(900, 374)
        Me.StaffAdminTable.TabIndex = 3
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'StaffName
        '
        Me.StaffName.HeaderText = "StaffName"
        Me.StaffName.Name = "StaffName"
        '
        'Sex
        '
        Me.Sex.HeaderText = "Sex"
        Me.Sex.Name = "Sex"
        '
        'DOB
        '
        Me.DOB.HeaderText = "DOB"
        Me.DOB.Name = "DOB"
        '
        'Position
        '
        Me.Position.HeaderText = "Position"
        Me.Position.Name = "Position"
        '
        'Email_id
        '
        Me.Email_id.HeaderText = "Email_id"
        Me.Email_id.Name = "Email_id"
        '
        'Salary
        '
        Me.Salary.HeaderText = "Salary"
        Me.Salary.Name = "Salary"
        '
        'Timing
        '
        Me.Timing.HeaderText = "Timing"
        Me.Timing.Name = "Timing"
        '
        'Contact
        '
        Me.Contact.HeaderText = "Contact"
        Me.Contact.Name = "Contact"
        '
        'StaffTableAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1082, 653)
        Me.ControlBox = False
        Me.Controls.Add(Me.StaffAdminTable)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StaffTableLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "StaffTableAdmin"
        CType(Me.StaffAdminTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StaffTableLabel As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents StaffAdminTable As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StaffName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Position As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Salary As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timing As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contact As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
