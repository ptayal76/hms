Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class AdminAddDoctor

    ' Event handler for the form load event
    Private Sub AdminAddDoctor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Form load event
    End Sub

    ' Event handler for the submit button click event
    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        Try
            ' Validating user inputs before adding a new doctor record

            ' Check if the contact number is provided
            If String.IsNullOrWhiteSpace(RichTextBox1.Text) Then
                MessageBox.Show("Please enter a contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validate the contact number format
            If Not ValidateContactNo(RichTextBox1.Text) Then
                MessageBox.Show("Invalid contact number. Please enter a 10-digit number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check if a specialization is selected
            If ComboBox1.SelectedItem Is Nothing Then
                MessageBox.Show("Please select a specialization.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check if a gender is selected
            If ComboBox2.SelectedItem Is Nothing Then
                MessageBox.Show("Please select a gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check if an email is provided
            If String.IsNullOrWhiteSpace(RichTextBox2.Text) Then
                MessageBox.Show("Please enter an email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check if timing information is provided
            If String.IsNullOrWhiteSpace(RichTextBox5.Text) Then
                MessageBox.Show("Please enter timing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validate the timing format
            If Not ValidateTiming(RichTextBox5.Text) Then
                MessageBox.Show("Invalid timing format. Please enter a valid format like '8am-2pm'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check if a salary is provided
            If String.IsNullOrWhiteSpace(RichTextBox6.Text) Then
                MessageBox.Show("Please enter a salary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validate the salary format
            If Not ValidateSalary(RichTextBox6.Text) Then
                MessageBox.Show("Invalid salary. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Connection string to the MySQL database
            Dim connectionString As String = "server=localhost;database=hms;uid=root;pwd=piyush123;"

            ' SQL query to insert data into the doctor table
            Dim insertQuery As String = "INSERT INTO hms.doctor (Name, Sex, DOB, Specialization, Email_id, Timing, Contact_no, Salary) VALUES (@Name, @Sex, @DOB, @Specialization, @Email, @Timing, @ContactNo, @Salary);"

            ' Create a MySqlConnection object
            Using connection As New MySqlConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Create a MySqlCommand object with the INSERT query and the MySqlConnection
                Using command As New MySqlCommand(insertQuery, connection)
                    ' Add parameters to the MySqlCommand to avoid SQL injection
                    command.Parameters.AddWithValue("@Name", RichTextBox7.Text)
                    command.Parameters.AddWithValue("@Sex", ComboBox2.SelectedItem.ToString())
                    command.Parameters.AddWithValue("@DOB", DateTimePicker1.Value)
                    command.Parameters.AddWithValue("@Specialization", ComboBox1.SelectedItem.ToString())
                    command.Parameters.AddWithValue("@Email", RichTextBox2.Text)
                    command.Parameters.AddWithValue("@Timing", RichTextBox5.Text)
                    command.Parameters.AddWithValue("@ContactNo", RichTextBox1.Text)
                    command.Parameters.AddWithValue("@Salary", RichTextBox6.Text)

                    ' Execute the INSERT query
                    command.ExecuteNonQuery()

                    ' Close the connection
                    connection.Close()
                End Using
            End Using

            ' Display a success message to the user
            MessageBox.Show("Doctor added successfully!")
        Catch ex As Exception
            ' Display an error message if an exception occurs
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to validate contact number format
    Private Function ValidateContactNo(ByVal contactNo As String) As Boolean
        Return Regex.IsMatch(contactNo, "^\d{10}$") ' Checks if it's a 10-digit number
    End Function

    ' Function to validate salary format
    Private Function ValidateSalary(ByVal salary As String) As Boolean
        Return IsNumeric(salary) ' Checks if it's a numeric value
    End Function

    ' Function to validate timing format
    Private Function ValidateTiming(ByVal timing As String) As Boolean
        Return Regex.IsMatch(timing, "^\d{1,2}[ap]m-\d{1,2}[ap]m$", RegexOptions.IgnoreCase) ' Checks if it's in the format "8am-2pm"
    End Function
End Class
