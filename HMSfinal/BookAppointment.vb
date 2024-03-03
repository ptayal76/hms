Imports MySql.Data.MySqlClient

Public Class BookAppointment

    ' Event handler for the button click event
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Connection string to MySQL database
        Dim connectionString As String = "server=localhost;database=hms;uid=root;pwd=piyush123;"

        ' SQL query to insert data into the appointment table
        Dim SqlQuery As String = "INSERT INTO appointment (Patient_id, Date_and_time, Symptoms, Preferred_slot, Preferred_date, Status) VALUES (@Value2, NOW(), @Value4, @Value5, @Value6, @Value7)"

        Try
            ' Create a MySqlConnection object
            Using connection As New MySqlConnection(connectionString)
                ' Open the database connection
                connection.Open()

                ' Create a MySqlCommand object with the INSERT query and the MySqlConnection
                Using sqlcmd As New MySqlCommand(SqlQuery, connection)

                    ' Add parameters to the MySqlCommand to avoid SQL injection
                    sqlcmd.Parameters.AddWithValue("@Value2", 1)
                    sqlcmd.Parameters.AddWithValue("@Value4", TextBox4.Text)
                    sqlcmd.Parameters.AddWithValue("@Value5", ComboBox1.SelectedItem.ToString())
                    sqlcmd.Parameters.AddWithValue("@Value6", DateTimePicker1.Value.Date.ToString("yyyy-MM-dd"))
                    sqlcmd.Parameters.AddWithValue("@Value7", "Not Assigned")

                    ' Execute the INSERT query
                    Dim sqlRd As MySqlDataReader = sqlcmd.ExecuteReader()

                    ' Close the SqlDataReader
                    sqlRd.Close()
                End Using

                ' Close the connection
                connection.Close()

                ' Display a success message to the user
                MessageBox.Show("Your request was successfully received by the hospital. You will be allotted a slot in some time.")
            End Using

        Catch ex As Exception
            ' Display an error message if an exception occurs
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Any cleanup code can be added here
        End Try
    End Sub
End Class
