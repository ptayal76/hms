<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAppointmentTbl = New System.Windows.Forms.Button()
        Me.btnCompTable = New System.Windows.Forms.Button()
        Me.btnAppointment = New System.Windows.Forms.Button()
        Me.btnComplaint = New System.Windows.Forms.Button()
        Me.btndash = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnAppointmentTbl)
        Me.Panel1.Controls.Add(Me.btnCompTable)
        Me.Panel1.Controls.Add(Me.btnAppointment)
        Me.Panel1.Controls.Add(Me.btnComplaint)
        Me.Panel1.Controls.Add(Me.btndash)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 865)
        Me.Panel1.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogout.Image = Global.HMSfinal.My.Resources.Resources.logout
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 796)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(15, 5, 0, 10)
        Me.btnLogout.Size = New System.Drawing.Size(232, 69)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnAppointmentTbl
        '
        Me.btnAppointmentTbl.BackColor = System.Drawing.Color.DimGray
        Me.btnAppointmentTbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAppointmentTbl.FlatAppearance.BorderSize = 0
        Me.btnAppointmentTbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppointmentTbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppointmentTbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAppointmentTbl.Image = Global.HMSfinal.My.Resources.Resources.appointment
        Me.btnAppointmentTbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAppointmentTbl.Location = New System.Drawing.Point(0, 506)
        Me.btnAppointmentTbl.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAppointmentTbl.Name = "btnAppointmentTbl"
        Me.btnAppointmentTbl.Padding = New System.Windows.Forms.Padding(15, 5, 0, 10)
        Me.btnAppointmentTbl.Size = New System.Drawing.Size(232, 76)
        Me.btnAppointmentTbl.TabIndex = 6
        Me.btnAppointmentTbl.Text = "Appointments"
        Me.btnAppointmentTbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAppointmentTbl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAppointmentTbl.UseVisualStyleBackColor = False
        '
        'btnCompTable
        '
        Me.btnCompTable.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCompTable.FlatAppearance.BorderSize = 0
        Me.btnCompTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompTable.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCompTable.Image = Global.HMSfinal.My.Resources.Resources.file
        Me.btnCompTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompTable.Location = New System.Drawing.Point(0, 438)
        Me.btnCompTable.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCompTable.Name = "btnCompTable"
        Me.btnCompTable.Padding = New System.Windows.Forms.Padding(15, 5, 0, 10)
        Me.btnCompTable.Size = New System.Drawing.Size(232, 68)
        Me.btnCompTable.TabIndex = 5
        Me.btnCompTable.Text = "Complaints"
        Me.btnCompTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCompTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCompTable.UseVisualStyleBackColor = True
        '
        'btnAppointment
        '
        Me.btnAppointment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAppointment.FlatAppearance.BorderSize = 0
        Me.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppointment.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppointment.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAppointment.Image = Global.HMSfinal.My.Resources.Resources.online
        Me.btnAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAppointment.Location = New System.Drawing.Point(0, 363)
        Me.btnAppointment.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAppointment.Name = "btnAppointment"
        Me.btnAppointment.Padding = New System.Windows.Forms.Padding(15, 5, 0, 10)
        Me.btnAppointment.Size = New System.Drawing.Size(232, 75)
        Me.btnAppointment.TabIndex = 4
        Me.btnAppointment.Text = "Book Appointment"
        Me.btnAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAppointment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAppointment.UseVisualStyleBackColor = True
        '
        'btnComplaint
        '
        Me.btnComplaint.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnComplaint.FlatAppearance.BorderSize = 0
        Me.btnComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComplaint.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComplaint.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnComplaint.Image = Global.HMSfinal.My.Resources.Resources.register
        Me.btnComplaint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnComplaint.Location = New System.Drawing.Point(0, 286)
        Me.btnComplaint.Margin = New System.Windows.Forms.Padding(5)
        Me.btnComplaint.Name = "btnComplaint"
        Me.btnComplaint.Padding = New System.Windows.Forms.Padding(15, 5, 0, 10)
        Me.btnComplaint.Size = New System.Drawing.Size(232, 77)
        Me.btnComplaint.TabIndex = 3
        Me.btnComplaint.Text = "Register Complaint"
        Me.btnComplaint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnComplaint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnComplaint.UseVisualStyleBackColor = True
        '
        'btndash
        '
        Me.btndash.Dock = System.Windows.Forms.DockStyle.Top
        Me.btndash.FlatAppearance.BorderSize = 0
        Me.btndash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndash.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndash.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndash.Image = Global.HMSfinal.My.Resources.Resources.db2
        Me.btndash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndash.Location = New System.Drawing.Point(0, 212)
        Me.btndash.Margin = New System.Windows.Forms.Padding(5)
        Me.btndash.Name = "btndash"
        Me.btndash.Padding = New System.Windows.Forms.Padding(15, 5, 0, 10)
        Me.btndash.Size = New System.Drawing.Size(232, 74)
        Me.btndash.TabIndex = 2
        Me.btndash.Text = "Dashboard"
        Me.btndash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btndash.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DimGray
        Me.Panel4.Controls.Add(Me.pbLogo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 42)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(232, 170)
        Me.Panel4.TabIndex = 1
        '
        'pbLogo
        '
        Me.pbLogo.Image = Global.HMSfinal.My.Resources.Resources.diagnosis
        Me.pbLogo.Location = New System.Drawing.Point(33, 21)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(153, 121)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(232, 42)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(232, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1362, 42)
        Me.Panel3.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Panel5.Location = New System.Drawing.Point(232, 42)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1362, 823)
        Me.Panel5.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1594, 865)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btndash As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnAppointmentTbl As System.Windows.Forms.Button
    Friend WithEvents btnCompTable As System.Windows.Forms.Button
    Friend WithEvents btnAppointment As System.Windows.Forms.Button
    Friend WithEvents btnComplaint As System.Windows.Forms.Button
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel

End Class
