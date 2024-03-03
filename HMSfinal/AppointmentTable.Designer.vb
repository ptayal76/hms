<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentTable
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.appointTable = New System.Windows.Forms.DataGridView()
        Me.Appointment_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Patient_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Doctor_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Allotted_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Allotted_slot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Symptoms = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bill_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Billing_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_and_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preferred_slot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preferred_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.appointTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(49, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(254, 40)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Appointments"
        '
        'appointTable
        '
        Me.appointTable.AllowUserToAddRows = False
        Me.appointTable.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        Me.appointTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.appointTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.appointTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.appointTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.appointTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.appointTable.ColumnHeadersHeight = 60
        Me.appointTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Appointment_id, Me.Patient_id, Me.Doctor_id, Me.Allotted_Date, Me.Allotted_slot, Me.Symptoms, Me.Bill_Status, Me.Billing_id, Me.Date_and_time, Me.Preferred_slot, Me.Preferred_Date})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.appointTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.appointTable.EnableHeadersVisualStyles = False
        Me.appointTable.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.appointTable.Location = New System.Drawing.Point(56, 144)
        Me.appointTable.Name = "appointTable"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.appointTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.appointTable.RowTemplate.Height = 30
        Me.appointTable.RowTemplate.ReadOnly = True
        Me.appointTable.Size = New System.Drawing.Size(1203, 305)
        Me.appointTable.TabIndex = 15
        '
        'Appointment_id
        '
        Me.Appointment_id.HeaderText = "Appointment_id"
        Me.Appointment_id.Name = "Appointment_id"
        '
        'Patient_id
        '
        Me.Patient_id.HeaderText = "Patient_id"
        Me.Patient_id.Name = "Patient_id"
        '
        'Doctor_id
        '
        Me.Doctor_id.HeaderText = "Doctor_id"
        Me.Doctor_id.Name = "Doctor_id"
        '
        'Allotted_Date
        '
        Me.Allotted_Date.HeaderText = "Allotted_Date"
        Me.Allotted_Date.Name = "Allotted_Date"
        '
        'Allotted_slot
        '
        Me.Allotted_slot.HeaderText = "Allotted_slot"
        Me.Allotted_slot.Name = "Allotted_slot"
        '
        'Symptoms
        '
        Me.Symptoms.HeaderText = "Symptoms"
        Me.Symptoms.Name = "Symptoms"
        '
        'Bill_Status
        '
        Me.Bill_Status.HeaderText = "Bill_Status"
        Me.Bill_Status.Name = "Bill_Status"
        '
        'Billing_id
        '
        Me.Billing_id.HeaderText = "Billing_id"
        Me.Billing_id.Name = "Billing_id"
        '
        'Date_and_time
        '
        Me.Date_and_time.HeaderText = "Date_and_time"
        Me.Date_and_time.Name = "Date_and_time"
        '
        'Preferred_slot
        '
        Me.Preferred_slot.HeaderText = "Preferred_slot"
        Me.Preferred_slot.Name = "Preferred_slot"
        '
        'Preferred_Date
        '
        Me.Preferred_Date.HeaderText = "Preferred_Date"
        Me.Preferred_Date.Name = "Preferred_Date"
        '
        'AppointmentTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1297, 809)
        Me.ControlBox = False
        Me.Controls.Add(Me.appointTable)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AppointmentTable"
        CType(Me.appointTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents appointTable As System.Windows.Forms.DataGridView
    Friend WithEvents Appointment_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Patient_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Doctor_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Allotted_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Allotted_slot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Symptoms As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bill_Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Billing_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Date_and_time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Preferred_slot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Preferred_Date As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
