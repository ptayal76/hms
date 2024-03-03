<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowBill
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.patientNameLabel = New System.Windows.Forms.Label()
        Me.patientName = New System.Windows.Forms.Label()
        Me.doctorName = New System.Windows.Forms.Label()
        Me.doctorLabel = New System.Windows.Forms.Label()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rateLabel = New System.Windows.Forms.Label()
        Me.BillingLabel = New System.Windows.Forms.Label()
        Me.Time = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.medicineTableBil = New System.Windows.Forms.DataGridView()
        Me.medicineCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.typeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rateCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantityCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amountCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeleteRowToolStripMenuItem = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.stockLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.medicineTableBil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeleteRowToolStripMenuItem.SuspendLayout()
        Me.SuspendLayout()
        '
        'patientNameLabel
        '
        Me.patientNameLabel.AutoSize = True
        Me.patientNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.14286!)
        Me.patientNameLabel.ForeColor = System.Drawing.Color.White
        Me.patientNameLabel.Location = New System.Drawing.Point(9, 67)
        Me.patientNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.patientNameLabel.Name = "patientNameLabel"
        Me.patientNameLabel.Size = New System.Drawing.Size(147, 25)
        Me.patientNameLabel.TabIndex = 2
        Me.patientNameLabel.Text = "Patient Name:"
        '
        'patientName
        '
        Me.patientName.AutoSize = True
        Me.patientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.patientName.ForeColor = System.Drawing.Color.White
        Me.patientName.Location = New System.Drawing.Point(158, 67)
        Me.patientName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.patientName.Name = "patientName"
        Me.patientName.Size = New System.Drawing.Size(141, 25)
        Me.patientName.TabIndex = 3
        Me.patientName.Text = "Posa Mokshith"
        '
        'doctorName
        '
        Me.doctorName.AutoSize = True
        Me.doctorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.doctorName.ForeColor = System.Drawing.Color.White
        Me.doctorName.Location = New System.Drawing.Point(158, 97)
        Me.doctorName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.doctorName.Name = "doctorName"
        Me.doctorName.Size = New System.Drawing.Size(122, 25)
        Me.doctorName.TabIndex = 4
        Me.doctorName.Text = "Dr.Samaram"
        '
        'doctorLabel
        '
        Me.doctorLabel.AutoSize = True
        Me.doctorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.doctorLabel.ForeColor = System.Drawing.Color.White
        Me.doctorLabel.Location = New System.Drawing.Point(9, 97)
        Me.doctorLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.doctorLabel.Name = "doctorLabel"
        Me.doctorLabel.Size = New System.Drawing.Size(126, 25)
        Me.doctorLabel.TabIndex = 5
        Me.doctorLabel.Text = "Doctor Name"
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dateLabel.ForeColor = System.Drawing.Color.White
        Me.dateLabel.Location = New System.Drawing.Point(351, 67)
        Me.dateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(53, 25)
        Me.dateLabel.TabIndex = 9
        Me.dateLabel.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(454, 71)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "2/3/24"
        '
        'rateLabel
        '
        Me.rateLabel.AutoSize = True
        Me.rateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rateLabel.ForeColor = System.Drawing.Color.White
        Me.rateLabel.Location = New System.Drawing.Point(793, 227)
        Me.rateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.rateLabel.Name = "rateLabel"
        Me.rateLabel.Size = New System.Drawing.Size(52, 25)
        Me.rateLabel.TabIndex = 17
        Me.rateLabel.Text = "Rate"
        '
        'BillingLabel
        '
        Me.BillingLabel.AutoSize = True
        Me.BillingLabel.Font = New System.Drawing.Font("Lucida Sans Unicode", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillingLabel.ForeColor = System.Drawing.Color.Gold
        Me.BillingLabel.Location = New System.Drawing.Point(2, 6)
        Me.BillingLabel.Name = "BillingLabel"
        Me.BillingLabel.Size = New System.Drawing.Size(124, 40)
        Me.BillingLabel.TabIndex = 21
        Me.BillingLabel.Text = "Billing"
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Time.ForeColor = System.Drawing.Color.White
        Me.Time.Location = New System.Drawing.Point(351, 97)
        Me.Time.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(56, 25)
        Me.Time.TabIndex = 23
        Me.Time.Text = "Time"
        Me.Time.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(442, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 25)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "14:39 pm"
        '
        'medicineTableBil
        '
        Me.medicineTableBil.AllowUserToAddRows = False
        Me.medicineTableBil.AllowUserToDeleteRows = False
        Me.medicineTableBil.AllowUserToResizeColumns = False
        Me.medicineTableBil.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        Me.medicineTableBil.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.medicineTableBil.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.medicineTableBil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.medicineTableBil.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.medicineTableBil.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.medicineTableBil.ColumnHeadersHeight = 60
        Me.medicineTableBil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.medicineTableBil.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.medicineCol, Me.typeCol, Me.rateCol, Me.quantityCol, Me.amountCol})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.medicineTableBil.DefaultCellStyle = DataGridViewCellStyle3
        Me.medicineTableBil.EnableHeadersVisualStyles = False
        Me.medicineTableBil.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.medicineTableBil.Location = New System.Drawing.Point(13, 143)
        Me.medicineTableBil.Name = "medicineTableBil"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.medicineTableBil.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.medicineTableBil.RowHeadersVisible = False
        Me.medicineTableBil.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.medicineTableBil.RowTemplate.Height = 30
        Me.medicineTableBil.RowTemplate.ReadOnly = True
        Me.medicineTableBil.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.medicineTableBil.ShowCellToolTips = False
        Me.medicineTableBil.Size = New System.Drawing.Size(769, 269)
        Me.medicineTableBil.TabIndex = 25
        '
        'medicineCol
        '
        Me.medicineCol.HeaderText = "Medicine Name"
        Me.medicineCol.Name = "medicineCol"
        '
        'typeCol
        '
        Me.typeCol.HeaderText = "Type"
        Me.typeCol.Name = "typeCol"
        '
        'rateCol
        '
        Me.rateCol.HeaderText = "Rate"
        Me.rateCol.Name = "rateCol"
        '
        'quantityCol
        '
        Me.quantityCol.HeaderText = "Quanity"
        Me.quantityCol.Name = "quantityCol"
        '
        'amountCol
        '
        Me.amountCol.HeaderText = "Amount"
        Me.amountCol.Name = "amountCol"
        '
        'DeleteRowToolStripMenuItem
        '
        Me.DeleteRowToolStripMenuItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.DeleteRowToolStripMenuItem.Name = "ContextMenuStrip1"
        Me.DeleteRowToolStripMenuItem.Size = New System.Drawing.Size(121, 28)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(120, 24)
        Me.DeleteToolStripMenuItem.Text = "delete"
        '
        'stockLabel
        '
        Me.stockLabel.AutoSize = True
        Me.stockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.stockLabel.ForeColor = System.Drawing.Color.White
        Me.stockLabel.Location = New System.Drawing.Point(793, 259)
        Me.stockLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.stockLabel.Name = "stockLabel"
        Me.stockLabel.Size = New System.Drawing.Size(68, 25)
        Me.stockLabel.TabIndex = 28
        Me.stockLabel.Text = "Stock:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(793, 191)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 25)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Type"
        '
        'ShowBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1056, 475)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.stockLabel)
        Me.Controls.Add(Me.medicineTableBil)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BillingLabel)
        Me.Controls.Add(Me.rateLabel)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.doctorLabel)
        Me.Controls.Add(Me.doctorName)
        Me.Controls.Add(Me.patientName)
        Me.Controls.Add(Me.patientNameLabel)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ShowBill"
        Me.Text = "ShowBill"
        CType(Me.medicineTableBil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeleteRowToolStripMenuItem.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents patientNameLabel As System.Windows.Forms.Label
    Friend WithEvents patientName As System.Windows.Forms.Label
    Friend WithEvents doctorName As System.Windows.Forms.Label
    Friend WithEvents doctorLabel As System.Windows.Forms.Label
    Friend WithEvents dateLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rateLabel As System.Windows.Forms.Label
    Friend WithEvents BillingLabel As System.Windows.Forms.Label
    Friend WithEvents Time As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents medicineTableBil As System.Windows.Forms.DataGridView
    Friend WithEvents DeleteRowToolStripMenuItem As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents stockLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents medicineCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents typeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rateCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantityCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amountCol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
