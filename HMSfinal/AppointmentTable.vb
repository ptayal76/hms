Imports MySql.Data.MySqlClient

Public Class AppointmentTable

    ' Connection string to MySQL database
    Dim connectionString As String = "server=localhost;userid=root;password=piyush123;database=hms"

    ' Event handler for the form load event
    Private Sub AppointmentTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Load data into the DataGridView when the form is loaded
        LoadDataIntoDataGridView()
    End Sub

    ' Function to load data into the DataGridView from the appointment table
    Private Sub LoadDataIntoDataGridView()
        Dim conn As New MySqlConnection(connectionString)

        Try
            ' Open the database connection
            conn.Open()

            ' Fetch records from the appointment table
            Dim query As String = "SELECT Appointment_id, Patient_id, Doctor_id, Billing_id, Date_and_Time, Symptoms, Allotted_date, Allotted_slot, Preferred_slot, DATE_FORMAT(Preferred_date, '%d-%m-%Y') as Preferred_date, Status FROM appointment"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Load records into the DataGridView
            While reader.Read()
                appointTable.Rows.Add(reader("Appointment_id"), reader("Patient_id"), reader("Doctor_id"), reader("Billing_id"), reader("Allotted_date"), reader("Allotted_slot"), reader("Symptoms"), reader("Status"), reader("Date_and_Time"), reader("Preferred_slot"), reader("Preferred_date"))
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

End Class
