Imports MySql.Data.MySqlClient

Public Class ComplaintsTableAdmin

    ' Connection string to MySQL database
    Dim connectionString As String = "server=localhost;userid=root;password=piyush123;database=hms"

    ' DataTable to store retrieved data
    Dim dataTable As New DataTable()

    ' Event handler for the form load event
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Load data into the DataGridView when the form is loaded
        LoadDataIntoDataGridView()
    End Sub

    ' Function to load data into the DataGridView from the complaint table
    Private Sub LoadDataIntoDataGridView()

        ' Create a MySqlConnection object
        Dim conn As New MySqlConnection(connectionString)

        Try
            ' Open the database connection
            conn.Open()

            ' Fetch records from the complaint table
            Dim query As String = "SELECT Complaint_id, Complaint_type, Complaint, Status, Date_and_Time, Patient_id FROM complaint"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Load records into the DataGridView
            While reader.Read()
                complaintsTableAdminCTA.Rows.Add(reader("Complaint_id"), reader("Complaint_type"), reader("Complaint"), reader("Status"), reader("Date_and_Time"), reader("Patient_id"))
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

    ' Event handler for the child form closed event
    Private Sub ChildForm_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        Me.Show()
    End Sub

    ' Note: The following commented-out code represents a potential CellContentClick event handler.
    ' Uncomment and customize as needed.

    'Private Sub complaintsTableAdminCTA_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles complaintsTableAdminCTA.CellContentClick
    '    ' Check if the clicked cell is in the last column of the row
    '    If e.ColumnIndex = complaintsTableAdminCTA.Columns.Count - 1 AndAlso e.RowIndex >= 0 Then
    '        ' Perform your action here
    '        Dim form As New ComplaintAdmin()
    '        AddHandler form.FormClosed, AddressOf ChildForm_FormClosed
    '        form.Show()
    '        Me.Hide()
    '        ' Dim cell As DataGridViewCell = complaintsTableAdminCTA.Rows(e.RowIndex).Cells(e.ColumnIndex)
    '        ' You can access cell value, row index, etc.
    '        ' MessageBox.Show("Button clicked at row " & (e.RowIndex + 1).ToString())
    '    End If
    'End Sub

End Class
