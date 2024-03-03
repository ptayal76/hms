<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnMedicineStock = New System.Windows.Forms.Button()
        Me.btnComplaints = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnDoctors = New System.Windows.Forms.Button()
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
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnMedicineStock)
        Me.Panel1.Controls.Add(Me.btnComplaints)
        Me.Panel1.Controls.Add(Me.btnStaff)
        Me.Panel1.Controls.Add(Me.btnDoctors)
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
        'btnMedicineStock
        '
        Me.btnMedicineStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnMedicineStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMedicineStock.FlatAppearance.BorderSize = 0
        Me.btnMedicineStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedicineStock.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedicineStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMedicineStock.Image = Global.HMSfinal.My.Resources.Resources.medicine
        Me.btnMedicineStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMedicineStock.Location = New System.Drawing.Point(0, 432)
        Me.btnMedicineStock.Margin = New System.Windows.Forms.Padding(5)
        Me.btnMedicineStock.Name = "btnMedicineStock"
        Me.btnMedicineStock.Padding = New System.Windows.Forms.Padding(15, 5, 0, 10)
        Me.btnMedicineStock.Size = New System.Drawing.Size(232, 76)
        Me.btnMedicineStock.TabIndex = 6
        Me.btnMedicineStock.Text = "Medicine Stock"
        Me.btnMedicineStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMedicineStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMedicineStock.UseVisualStyleBackColor = False
        '
        'btnComplaints
        '
        Me.btnComplaints.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnComplaints.FlatAppearance.BorderSize = 0
        Me.btnComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComplaints.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComplaints.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnComplaints.Image = Global.HMSfinal.My.Resources.Resources.file
        Me.btnComplaints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnComplaints.Location = New System.Drawing.Point(0, 364)
        Me.btnComplaints.Margin = New System.Windows.Forms.Padding(5)
        Me.btnComplaints.Name = "btnComplaints"
        Me.btnComplaints.Padding = New System.Windows.Forms.Padding(15, 5, 0, 10)
        Me.btnComplaints.Size = New System.Drawing.Size(232, 68)
        Me.btnComplaints.TabIndex = 5
        Me.btnComplaints.Text = "Complaints"
        Me.btnComplaints.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnComplaints.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnComplaints.UseVisualStyleBackColor = True
        '
        'btnStaff
        '
        Me.btnStaff.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStaff.FlatAppearance.BorderSize = 0
        Me.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaff.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnStaff.Image = Global.HMSfinal.My.Resources.Resources.grouping
        Me.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaff.Location = New System.Drawing.Point(0, 289)
        Me.btnStaff.Margin = New System.Windows.Forms.Padding(5)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Padding = New System.Windows.Forms.Padding(15, 5, 0, 10)
        Me.btnStaff.Size = New System.Drawing.Size(232, 75)
        Me.btnStaff.TabIndex = 4
        Me.btnStaff.Text = "Staff"
        Me.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'btnDoctors
        '
        Me.btnDoctors.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDoctors.FlatAppearance.BorderSize = 0
        Me.btnDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDoctors.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoctors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDoctors.Image = Global.HMSfinal.My.Resources.Resources.doctor
        Me.btnDoctors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDoctors.Location = New System.Drawing.Point(0, 212)
        Me.btnDoctors.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDoctors.Name = "btnDoctors"
        Me.btnDoctors.Padding = New System.Windows.Forms.Padding(15, 5, 0, 10)
        Me.btnDoctors.Size = New System.Drawing.Size(232, 77)
        Me.btnDoctors.TabIndex = 3
        Me.btnDoctors.Text = "Doctors"
        Me.btnDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDoctors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDoctors.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel4.Controls.Add(Me.pbLogo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 42)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(232, 170)
        Me.Panel4.TabIndex = 1
        '
        'pbLogo
        '
        Me.pbLogo.Image = Global.HMSfinal.My.Resources.Resources.admin1
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
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(232, 42)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1362, 823)
        Me.Panel5.TabIndex = 2
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1594, 865)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form2"
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnMedicineStock As System.Windows.Forms.Button
    Friend WithEvents btnComplaints As System.Windows.Forms.Button
    Friend WithEvents btnStaff As System.Windows.Forms.Button
    Friend WithEvents btnDoctors As System.Windows.Forms.Button
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
End Class
