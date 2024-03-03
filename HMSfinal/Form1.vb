Public Class Form1

    ' Event handler for the Complaint button click
    Private Sub btnComplaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComplaint.Click
        ' Remove the previous form from the panel and display the ComplaintReg form
        RemovePreviousForm()
        With ComplaintReg
            .TopLevel = False
            .Dock = DockStyle.Fill
            Panel5.Controls.Add(ComplaintReg)
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Event handler for the Appointment button click
    Private Sub btnAppointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppointment.Click
        ' Remove the previous form from the panel and display the BookAppointment form
        RemovePreviousForm()
        With BookAppointment
            .TopLevel = False
            .Dock = DockStyle.Fill
            Panel5.Controls.Add(BookAppointment)
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Function to remove the previous form from the panel
    Private Sub RemovePreviousForm()
        ' Check if any form is already in Panel5
        If Panel5.Controls.Count > 0 Then
            ' Remove the first control (form) from Panel5
            Panel5.Controls.RemoveAt(0)
        End If
    End Sub

    ' Event handler for the Complaint Table button click
    Private Sub btnCompTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompTable.Click
        ' Remove the previous form from the panel and display the ComplaintsUser form
        RemovePreviousForm()
        With ComplaintsUser
            .TopLevel = False
            .Dock = DockStyle.Fill
            Panel5.Controls.Add(ComplaintsUser)
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Event handler for the Appointment Table button click
    Private Sub btnAppointmentTbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppointmentTbl.Click
        ' Remove the previous form from the panel and display the AppointmentTable form
        RemovePreviousForm()
        With AppointmentTable
            .TopLevel = False
            .Dock = DockStyle.Fill
            Panel5.Controls.Add(AppointmentTable)
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Event handler for the Dashboard button click
    Private Sub btndash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndash.Click
        ' Remove the previous form from the panel and display the Dashboard form
        RemovePreviousForm()
        With Dashboard
            .TopLevel = False
            .Dock = DockStyle.Fill
            Panel5.Controls.Add(Dashboard)
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

    ' Event handler for the Form1 FormClosing event
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' Ensure that the application exits when the main form is closed
        Application.Exit()
    End Sub

End Class
