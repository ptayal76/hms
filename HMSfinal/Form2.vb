Public Class Form2

    ' Event handler for the Doctors button click
    Private Sub btnDoctors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoctors.Click
        ' Remove the previous form from the panel and display the DoctorTable form
        RemovePreviousForm()
        With DoctorTable
            .TopLevel = False
            .Dock = DockStyle.Fill
            Panel5.Controls.Add(DoctorTable)
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Event handler for the Staff button click
    Private Sub btnStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStaff.Click
        ' Remove the previous form from the panel and display the StaffTableAdmin form
        RemovePreviousForm()
        With StaffTableAdmin
            .TopLevel = False
            .Dock = DockStyle.Fill
            Panel5.Controls.Add(StaffTableAdmin)
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Event handler for the Complaints button click
    Private Sub btnComplaints_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComplaints.Click
        ' Remove the previous form from the panel and display the ComplaintsTableAdmin form
        RemovePreviousForm()
        With ComplaintsTableAdmin
            .TopLevel = False
            .Dock = DockStyle.Fill
            Panel5.Controls.Add(ComplaintsTableAdmin)
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Event handler for the Medicine Stock button click
    Private Sub btnMedicineStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedicineStock.Click
        ' Remove the previous form from the panel and display the MedicineTableAdmin form
        RemovePreviousForm()
        With MedicineTableAdmin
            .TopLevel = False
            .Dock = DockStyle.Fill
            Panel5.Controls.Add(MedicineTableAdmin)
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Event handler for the Logout button click
    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        ' Hide the current form and display the AuthenticationPage form
        Me.Hide()
        Dim form As New AuthenticationPage()
        form.Show()
    End Sub

    ' Event handler for the Form2 FormClosing event
    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' Ensure that the application exits when the main form is closed
        Application.Exit()
    End Sub

    ' Function to remove the previous form from the panel
    Private Sub RemovePreviousForm()
        ' Check if any form is already in Panel5
        If Panel5.Controls.Count > 0 Then
            ' Remove the first control (form) from Panel5
            Panel5.Controls.Clear()
        End If
    End Sub

    ' Event handler for the Form2 Load event
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Any initialization code can be added here
    End Sub
End Class
