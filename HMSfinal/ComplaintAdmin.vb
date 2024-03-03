Public Class ComplaintAdmin
    Private Sub ComplaintAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal

        ' Add staff members' names to the ComboBox
        staffComboxCA.Items.Add("Appoint a person...")
        staffComboxCA.Items.Add("John Smith")
        staffComboxCA.Items.Add("Emily Johnson")
        staffComboxCA.Items.Add("Michael Brown")
        staffComboxCA.Items.Add("Jessica Davis")
        staffComboxCA.Items.Add("David Wilson")
        staffComboxCA.SelectedIndex = 0

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Text = "Solved"
        Button1.BackColor = Color.Green
    End Sub
End Class