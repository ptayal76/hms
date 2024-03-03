Imports MySql.Data.MySqlClient

Public Class DoctorTable

    ' Connection string to MySQL database
    Dim connectionString As String = "server=localhost;userid=root;password=piyush123;database=hms"

    ' Event handler for the form load event
    Private Sub AppointmentTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Load data into the DataGridView when the form is loaded
        LoadDataIntoDataGridView()
    End Sub

    ' Function to load data into the DataGridView from the doctor table
    Private Sub LoadDataIntoDataGridView()

        ' Create a MySqlConnection object
        Dim conn As New MySqlConnection(connectionString)

        Try
            ' Open the database connection
            conn.Open()

            ' Fetch records from the doctor table
            Dim query As String = "SELECT Doctor_id, Name, Sex, DATE_FORMAT(DOB, '%Y-%m-%d') as DOB, Specialization, Email_id, Timing, Contact_no, Salary FROM doctor"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Load records into the DataGridView
            While reader.Read()
                DoctorTableAdmin.Rows.Add(reader("Doctor_id"), reader("Name"), reader("Sex"), reader("DOB"), reader("Specialization"), reader("Email_id"), reader("Timing"), reader("Contact_no"), reader("Salary"))
            End While

            ' Close the connection
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

    ' Event handler for the form load event
    Private Sub DoctorTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Hide row headers in the DataGridView
        DoctorTableAdmin.RowHeadersVisible = False
    End Sub

    ' Event handler for the button click event
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Open a new form for adding a new doctor
        Dim newStaffUpdateForm As New AdminAddDoctor()
        newStaffUpdateForm.Show()
    End Sub

End Class
