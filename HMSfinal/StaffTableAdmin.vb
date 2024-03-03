Imports MySql.Data.MySqlClient

Public Class StaffTableAdmin

    ' Connection string to MySQL database
    Dim connectionString As String = "server=localhost;userid=root;password=piyush123;database=hms"

    ' DataTable to store retrieved data
    Dim dataTable As New DataTable()

    ' Event handler for loading data into the DataGridView
    Private Sub LoadDataIntoDataGridView()

        ' Create a MySqlConnection object
        Dim conn As New MySqlConnection(connectionString)

        Try
            ' Open the database connection
            conn.Open()

            ' Fetch records from the staff table
            Dim query As String = "SELECT Staff_id, Name, Sex, DATE_FORMAT(DOB, '%Y-%m-%d') as DOB, Position, Email_id, Salary, Timing, Contact_no FROM staff"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Load records into DataGridView
            While reader.Read()
                StaffAdminTable.Rows.Add(reader("Staff_id"), reader("Name"), reader("Sex"), reader("DOB"), reader("Position"), reader("Email_id"), reader("Salary"), reader("Timing"), reader("Contact_no"))
            End While

            ' Close connection
            reader.Close()
            conn.Close()

        Catch ex As Exception
            ' Display an error message if an exception occurs
            MessageBox.Show(ex.Message)
        Finally
            ' Close the connection if it's still open
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Function to update data in the database
    Private Sub UpdateData()
        Try
            ' Create a MySqlConnection object
            Using connection As New MySqlConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Create a MySqlCommandBuilder object to automatically generate update commands
                Using cmdBuilder As New MySqlCommandBuilder()
                    cmdBuilder.DataAdapter = New MySqlDataAdapter("SELECT * FROM staff", connection)

                    ' Update the database with changes made in the DataTable
                    cmdBuilder.GetUpdateCommand()
                    Dim rowsAffected As Integer = cmdBuilder.DataAdapter.Update(dataTable)
                    MessageBox.Show(rowsAffected & " rows updated successfully.")
                End Using
            End Using
        Catch ex As Exception
            ' Display an error message if an exception occurs
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Event handler for the form load event
    Private Sub StaffTableAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Load data into the DataGridView when the form is loaded
        LoadDataIntoDataGridView()
    End Sub

    ' Event handler for the "Update" button click
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Open the StaffUpdateAdmin form when the button is clicked
        Dim newStaffUpdateForm As New StaffUpdateAdmin()
        newStaffUpdateForm.Show()
    End Sub

    ' Event handler for the label click (optional)
    Private Sub StaffTableLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffTableLabel.Click
        ' You can add custom logic for label click if needed
    End Sub

    ' Event handler for the DataGridView cell content click (optional)
    Private Sub StaffAdminTable_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StaffAdminTable.CellContentClick
        ' You can add custom logic for DataGridView cell content click if needed
    End Sub
End Class
