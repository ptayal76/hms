Imports MySql.Data.MySqlClient

Public Class ComplaintReg

    ' Patient ID to be associated with the complaint
    Dim Patient_Id As Integer = 1

    ' Event handler for the form load event
    Private Sub ComplaintReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Populate the ComboBox with complaint types and set the default selection
        ComboBox1.Items.Add("Select an option...")
        ComboBox1.Items.Add("Cleaning")
        ComboBox1.Items.Add("Billing")
        ComboBox1.Items.Add("Service")
        ComboBox1.SelectedIndex = 0

        ' Set the DateTimePicker format
        DateTimePicker.Format = DateTimePickerFormat.Custom
        DateTimePicker.CustomFormat = "dd MMM yyyy"
    End Sub

    ' Event handler for the submit button click event
    Private Sub submitButtonCR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submitButtonCR.Click
        ' Connection string to MySQL database
        Dim connectionString As String = "server=localhost;database=hms;uid=root;pwd=piyush123;"

        ' SQL query to insert data into the complaint table
        Dim SqlQuery As String = "INSERT INTO complaint (Patient_id, Date_and_Time, Complaint, Complaint_type, Status) VALUES (@Value2, NOW(), @Value4, @Value5, @Value6)"

        Try
            ' Create a MySqlConnection object
            Using connection As New MySqlConnection(connectionString)
                ' Open the database connection
                connection.Open()

                ' Create a MySqlCommand object with the INSERT query and the MySqlConnection
                Using sqlcmd As New MySqlCommand(SqlQuery, connection)
                    ' Set parameter values
                    sqlcmd.Parameters.AddWithValue("@Value2", Patient_Id)
                    sqlcmd.Parameters.AddWithValue("@Value4", RichTextBox2.Text)
                    sqlcmd.Parameters.AddWithValue("@Value5", ComboBox1.SelectedItem.ToString())
                    sqlcmd.Parameters.AddWithValue("@Value6", "Not Assigned")

                    ' Execute the INSERT query
                    Dim sqlRd As MySqlDataReader = sqlcmd.ExecuteReader()
                    ' Close the SqlDataReader
                    sqlRd.Close()
                End Using

                ' Display a success message to the user
                MessageBox.Show("The complaint was lodged successfully")
            End Using

        Catch ex As Exception
            ' Display an error message if an exception occurs
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
