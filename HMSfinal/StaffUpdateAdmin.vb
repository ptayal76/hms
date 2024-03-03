Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class StaffUpdateAdmin

    ' Event handler for the form load event
    Private Sub StaffUpdateAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Populate ComboBox with options when the form loads
        ComboBox1.Items.Add("Select among...")
        ComboBox1.Items.Add("Receptionist")
        ComboBox1.Items.Add("Security")
        ComboBox1.Items.Add("Cleaner")
        ComboBox1.Items.Add("Nurse")
        ComboBox1.Items.Add("Compounder")
        ComboBox1.SelectedIndex = 0 ' Select the first item by default
    End Sub

    ' Event handler for the "Submit" button click
    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        ' Validation of inputs

        ' Validate contact number
        If Not ValidateContactNo(RichTextBox1.Text) Then
            MessageBox.Show("Invalid contact number. Please enter a 10-digit number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate salary format
        If Not ValidateSalary(RichTextBox6.Text) Then
            MessageBox.Show("Invalid salary. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate timing format
        If Not ValidateTiming(RichTextBox5.Text) Then
            MessageBox.Show("Invalid timing format. Please enter a valid format like '8am-2pm'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Connection string to MySQL database
        Dim connectionString As String = "server=localhost;database=hms;uid=root;pwd=piyush123;"

        ' SQL query to insert data into the staff table
        Dim insertQuery As String = "INSERT INTO staff (Name, Sex, DOB, Position, Email_id, Timing, Contact_no, Salary) VALUES (@Name, @Sex, @DOB, @Position, @Email, @Timing, @ContactNo, @Salary)"

        Try
            ' Create a MySqlConnection object
            Using connection As New MySqlConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Create a MySqlCommand object with the INSERT query and the MySqlConnection
                Using command As New MySqlCommand(insertQuery, connection)
                    ' Add parameters to the MySqlCommand to avoid SQL injection
                    command.Parameters.AddWithValue("@Name", RichTextBox7.Text)
                    command.Parameters.AddWithValue("@Sex", ComboBox2.SelectedItem.ToString())
                    command.Parameters.AddWithValue("@DOB", DateTimePicker1.Value.Date.ToString("yyyy-MM-dd"))
                    command.Parameters.AddWithValue("@Position", ComboBox1.SelectedItem.ToString())
                    command.Parameters.AddWithValue("@Email", RichTextBox2.Text)
                    command.Parameters.AddWithValue("@Timing", RichTextBox5.Text)
                    command.Parameters.AddWithValue("@ContactNo", RichTextBox1.Text)
                    command.Parameters.AddWithValue("@Salary", RichTextBox6.Text)

                    ' Execute the INSERT query
                    'command.ExecuteNonQuery()
                    Dim sqlRd As MySqlDataReader = command.ExecuteReader()
                    sqlRd.Close()
                End Using
                ' Close the connection
                connection.Close()
            End Using

            MessageBox.Show("Staff added successfully!")
        Catch ex As Exception
            ' Display an error message if an exception occurs
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to validate salary format
    Private Function ValidateSalary(ByVal salary As String) As Boolean
        Return IsNumeric(salary) ' Checks if it's a numeric value
    End Function

    ' Function to validate timing format
    Private Function ValidateTiming(ByVal timing As String) As Boolean
        Return Regex.IsMatch(timing, "^\d{1,2}[ap]m-\d{1,2}[ap]m$", RegexOptions.IgnoreCase) ' Checks if it's in the format "8am-2pm"
    End Function

    ' Function to validate contact number
    Private Function ValidateContactNo(ByVal contactNo As String) As Boolean
        Return Regex.IsMatch(contactNo, "^\d{10}$") ' Checks if it's a 10-digit number
    End Function
End Class
