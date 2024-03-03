Imports MySql.Data.MySqlClient

Public Class MedicineTableAdmin

    ' Connection string to MySQL database
    Dim connectionString As String = "server=localhost;userid=root;password=piyush123;database=hms"

    ' DataTable to store retrieved data
    Dim dataTable As New DataTable()

    ' Event handler for the form load event
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Load data into the DataGridView when the form is loaded
        LoadDataIntoDataGridView()
    End Sub

    ' Function to load data into the DataGridView from the medicine table
    Private Sub LoadDataIntoDataGridView()

        ' Create a MySqlConnection object
        Dim conn As New MySqlConnection(connectionString)

        Try
            ' Open the database connection
            conn.Open()

            ' Fetch records from the medicine table
            Dim query As String = "SELECT Medicine_id, Medicine_Type, Name, Quantity, Price, DATE_FORMAT(Arrival_Date, '%Y-%m-%d') as Arrival_Date, DATE_FORMAT(Expiry_Date, '%Y-%m-%d') as Expiry_Date FROM medicine"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Load records into the DataGridView
            While reader.Read()
                DataGridView1.Rows.Add(reader("Medicine_id"), reader("Medicine_Type"), reader("Name"), reader("Quantity"), reader("Price"), reader("Arrival_Date"), reader("Expiry_Date"))
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

    ' Event handler for the Update Medicine button click
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Open the UpdateMedicine form when the button is clicked
        Dim updateMedicineForm As New UpdateMedicine()
        AddHandler updateMedicineForm.FormClosed, AddressOf ChildForm_FormClosed
        updateMedicineForm.Show()
        Me.Hide()
    End Sub

    ' Event handler for the DataGridView cell content click (optional)
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' You can add custom logic for cell content click if needed
    End Sub
End Class
