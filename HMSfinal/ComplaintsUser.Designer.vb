<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComplaintsUser
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.complaintsTableCU = New System.Windows.Forms.DataGridView()
        Me.dateCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.complaintTypeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detailCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusCol = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.assignedToCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.positionCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.complaintsTableLabel = New System.Windows.Forms.Label()
        Me.complaintsTableAdminCTA = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.patientCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.complaintsTableCU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.complaintsTableAdminCTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'complaintsTableCU
        '
        Me.complaintsTableCU.AllowUserToAddRows = False
        Me.complaintsTableCU.AllowUserToDeleteRows = False
        Me.complaintsTableCU.AllowUserToOrderColumns = True
        Me.complaintsTableCU.AllowUserToResizeColumns = False
        Me.complaintsTableCU.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        Me.complaintsTableCU.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.complaintsTableCU.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.complaintsTableCU.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.complaintsTableCU.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.complaintsTableCU.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.complaintsTableCU.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.complaintsTableCU.ColumnHeadersHeight = 60
        Me.complaintsTableCU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.complaintsTableCU.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dateCol, Me.complaintTypeCol, Me.detailCol, Me.statusCol, Me.assignedToCol, Me.positionCol})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.complaintsTableCU.DefaultCellStyle = DataGridViewCellStyle4
        Me.complaintsTableCU.EnableHeadersVisualStyles = False
        Me.complaintsTableCU.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.complaintsTableCU.Location = New System.Drawing.Point(126, 171)
        Me.complaintsTableCU.Name = "complaintsTableCU"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.complaintsTableCU.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.complaintsTableCU.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.complaintsTableCU.RowTemplate.Height = 30
        Me.complaintsTableCU.RowTemplate.ReadOnly = True
        Me.complaintsTableCU.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.complaintsTableCU.Size = New System.Drawing.Size(1084, 608)
        Me.complaintsTableCU.TabIndex = 16
        '
        'dateCol
        '
        Me.dateCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dateCol.HeaderText = "Date"
        Me.dateCol.Name = "dateCol"
        Me.dateCol.ReadOnly = True
        Me.dateCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dateCol.Width = 150
        '
        'complaintTypeCol
        '
        Me.complaintTypeCol.FillWeight = 200.0!
        Me.complaintTypeCol.HeaderText = "Issue"
        Me.complaintTypeCol.Name = "complaintTypeCol"
        Me.complaintTypeCol.ReadOnly = True
        Me.complaintTypeCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'detailCol
        '
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.detailCol.DefaultCellStyle = DataGridViewCellStyle3
        Me.detailCol.HeaderText = "Detail More"
        Me.detailCol.Name = "detailCol"
        Me.detailCol.ReadOnly = True
        Me.detailCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.detailCol.Width = 173
        '
        'statusCol
        '
        Me.statusCol.HeaderText = "Status"
        Me.statusCol.Name = "statusCol"
        Me.statusCol.ReadOnly = True
        Me.statusCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.statusCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.statusCol.Width = 110
        '
        'assignedToCol
        '
        Me.assignedToCol.HeaderText = "Assigned To"
        Me.assignedToCol.Name = "assignedToCol"
        Me.assignedToCol.ReadOnly = True
        Me.assignedToCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.assignedToCol.Width = 200
        '
        'positionCol
        '
        Me.positionCol.HeaderText = "Position"
        Me.positionCol.Name = "positionCol"
        Me.positionCol.ReadOnly = True
        Me.positionCol.Width = 133
        '
        'complaintsTableLabel
        '
        Me.complaintsTableLabel.AutoSize = True
        Me.complaintsTableLabel.Font = New System.Drawing.Font("Lucida Sans Unicode", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.complaintsTableLabel.ForeColor = System.Drawing.Color.Gold
        Me.complaintsTableLabel.Location = New System.Drawing.Point(71, 25)
        Me.complaintsTableLabel.Name = "complaintsTableLabel"
        Me.complaintsTableLabel.Size = New System.Drawing.Size(209, 40)
        Me.complaintsTableLabel.TabIndex = 17
        Me.complaintsTableLabel.Text = "Complaints"
        '
        'complaintsTableAdminCTA
        '
        Me.complaintsTableAdminCTA.AllowUserToAddRows = False
        Me.complaintsTableAdminCTA.AllowUserToDeleteRows = False
        Me.complaintsTableAdminCTA.AllowUserToOrderColumns = True
        Me.complaintsTableAdminCTA.AllowUserToResizeColumns = False
        Me.complaintsTableAdminCTA.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(5)
        Me.complaintsTableAdminCTA.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.complaintsTableAdminCTA.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.complaintsTableAdminCTA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.complaintsTableAdminCTA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(77, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.complaintsTableAdminCTA.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.complaintsTableAdminCTA.ColumnHeadersHeight = 60
        Me.complaintsTableAdminCTA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.patientCol, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewButtonColumn1})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.complaintsTableAdminCTA.DefaultCellStyle = DataGridViewCellStyle8
        Me.complaintsTableAdminCTA.EnableHeadersVisualStyles = False
        Me.complaintsTableAdminCTA.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.complaintsTableAdminCTA.Location = New System.Drawing.Point(186, 334)
        Me.complaintsTableAdminCTA.Name = "complaintsTableAdminCTA"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.complaintsTableAdminCTA.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.complaintsTableAdminCTA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.complaintsTableAdminCTA.RowTemplate.Height = 30
        Me.complaintsTableAdminCTA.RowTemplate.ReadOnly = True
        Me.complaintsTableAdminCTA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.complaintsTableAdminCTA.Size = New System.Drawing.Size(400, 92)
        Me.complaintsTableAdminCTA.TabIndex = 18
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'patientCol
        '
        Me.patientCol.HeaderText = "Patient"
        Me.patientCol.Name = "patientCol"
        Me.patientCol.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Complaint Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Assigned To"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Position"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.HeaderText = "Status"
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.ReadOnly = True
        Me.DataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewButtonColumn1.Width = 150
        '
        'ComplaintsUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1282, 791)
        Me.ControlBox = False
        Me.Controls.Add(Me.complaintsTableLabel)
        Me.Controls.Add(Me.complaintsTableCU)
        Me.Controls.Add(Me.complaintsTableAdminCTA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ComplaintsUser"
        CType(Me.complaintsTableCU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.complaintsTableAdminCTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents complaintsTableCU As System.Windows.Forms.DataGridView
    Friend WithEvents complaintsTableLabel As System.Windows.Forms.Label
    Friend WithEvents dateCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents complaintTypeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detailCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents statusCol As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents assignedToCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents positionCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents complaintsTableAdminCTA As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents patientCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As System.Windows.Forms.DataGridViewButtonColumn
End Class
