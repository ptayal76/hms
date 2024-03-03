<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComplaintsTableAdmin
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
        Me.complaintsTableLabel = New System.Windows.Forms.Label()
        Me.complaintsTableAdminCTA = New System.Windows.Forms.DataGridView()
        Me.Complaint_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Complaint_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_and_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Patient_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.complaintsTableAdminCTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'complaintsTableLabel
        '
        Me.complaintsTableLabel.AutoSize = True
        Me.complaintsTableLabel.Font = New System.Drawing.Font("Lucida Sans Unicode", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.complaintsTableLabel.ForeColor = System.Drawing.Color.Gold
        Me.complaintsTableLabel.Location = New System.Drawing.Point(20, 31)
        Me.complaintsTableLabel.Name = "complaintsTableLabel"
        Me.complaintsTableLabel.Size = New System.Drawing.Size(209, 40)
        Me.complaintsTableLabel.TabIndex = 16
        Me.complaintsTableLabel.Text = "Complaints"
        '
        'complaintsTableAdminCTA
        '
        Me.complaintsTableAdminCTA.AllowUserToAddRows = False
        Me.complaintsTableAdminCTA.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        Me.complaintsTableAdminCTA.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.complaintsTableAdminCTA.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.complaintsTableAdminCTA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.complaintsTableAdminCTA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.complaintsTableAdminCTA.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.complaintsTableAdminCTA.ColumnHeadersHeight = 60
        Me.complaintsTableAdminCTA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Complaint_ID, Me.Complaint_Type, Me.Detail, Me.Status, Me.Date_and_time, Me.Patient_id})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.complaintsTableAdminCTA.DefaultCellStyle = DataGridViewCellStyle3
        Me.complaintsTableAdminCTA.EnableHeadersVisualStyles = False
        Me.complaintsTableAdminCTA.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.complaintsTableAdminCTA.Location = New System.Drawing.Point(55, 93)
        Me.complaintsTableAdminCTA.Name = "complaintsTableAdminCTA"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.complaintsTableAdminCTA.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.complaintsTableAdminCTA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.complaintsTableAdminCTA.RowTemplate.Height = 30
        Me.complaintsTableAdminCTA.RowTemplate.ReadOnly = True
        Me.complaintsTableAdminCTA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.complaintsTableAdminCTA.Size = New System.Drawing.Size(972, 467)
        Me.complaintsTableAdminCTA.TabIndex = 17
        '
        'Complaint_ID
        '
        Me.Complaint_ID.HeaderText = "Complaint_ID"
        Me.Complaint_ID.Name = "Complaint_ID"
        '
        'Complaint_Type
        '
        Me.Complaint_Type.HeaderText = "Complaint_Type"
        Me.Complaint_Type.Name = "Complaint_Type"
        '
        'Detail
        '
        Me.Detail.HeaderText = "Detail"
        Me.Detail.Name = "Detail"
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        '
        'Date_and_time
        '
        Me.Date_and_time.HeaderText = "Date_and_time"
        Me.Date_and_time.Name = "Date_and_time"
        '
        'Patient_id
        '
        Me.Patient_id.HeaderText = "Patient_id"
        Me.Patient_id.Name = "Patient_id"
        '
        'ComplaintsTableAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1082, 653)
        Me.ControlBox = False
        Me.Controls.Add(Me.complaintsTableAdminCTA)
        Me.Controls.Add(Me.complaintsTableLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ComplaintsTableAdmin"
        CType(Me.complaintsTableAdminCTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents complaintsTableLabel As System.Windows.Forms.Label
    Friend WithEvents complaintsTableAdminCTA As System.Windows.Forms.DataGridView
    Friend WithEvents Complaint_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Complaint_Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Detail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Date_and_time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Patient_id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
