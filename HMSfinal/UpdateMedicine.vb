'Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class UpdateMedicine



    ' Event handler for btnBack
    ' Remove or adjust the btnBack_Click method as necessary
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close() ' Just close UpdateMedicine; MedicineTable will show through the FormClosed event handling
    End Sub






    Private Sub UpdateMedicine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub





    Dim Mysqlconn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim Dta As New MySqlDataAdapter
    Dim SqlQuery As String

    'Private Sub insert_table()
    '    Mysqlconn.ConnectionString = "server=localhost;userid=root;password=Aasneh18;database=telephonedatabase;"
    '    Mysqlconn.Open()

    '    SqlQuery = "Insert into UserData(name,IITG_email,phonenumber,role,password,department,plan_id,expiry_date) values ('Aasneh','p.aasneh@iitg.ac.in','7021901677','Student','Aasneh','CSE',0,'03-03-2024');"


    '    sqlCmd.Connection = Mysqlconn
    '    sqlCmd.CommandText = SqlQuery

    '    sqlRd = sqlCmd.ExecuteReader
    '    'sqlDt.Load(sqlRd)

    '    sqlRd.Close()
    '    Mysqlconn.Close()
    '    MessageBox.Show("Successful Connection")
    '    'DataGridView1.DataSource = sqlDt
    'End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Not Validateprice(RichTextBox1.Text) Then
            MessageBox.Show("Invalid Price. Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not ValidateQuantity(txtStock.Text) Then
            MessageBox.Show("Invalid Quantity. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        '' Connection string to your SQL Server database
        Dim connectionString As String = "server=localhost;database=hms;uid=root;pwd=piyush123;"
        'Mysqlconn.ConnectionString = "server=localhost;database=hms;uid=root;pwd=1234;"
        'Mysqlconn.Open()

        '' SQL query to insert data into the doctor table
        'SqlQuery = "INSERT INTO medicine (Name, Medicine_Type, Quantity, Price, Arrival_Date, Expiry_Date) VALUES (@Name, @Type, @Quantity, @Price, @Arrival, @Expiry);"
        Dim insertQuery As String = "INSERT INTO medicine (Name, Medicine_Type, Quantity, Price, Arrival_Date, Expiry_Date) VALUES (@Name, @Type, @Quantity, @Price, @Arrival, @Expiry);"
        'sqlCmd.Connection = Mysqlconn
        'sqlCmd.CommandText = SqlQuery

        'sqlRd = sqlCmd.ExecuteReader
        ''sqlDt.Load(sqlRd)

        'sqlRd.Close()
        'Mysqlconn.Close()
        'MessageBox.Show("Successful Connection")

        Try
            ' Create a SqlConnection object
            Using connection As New MySqlConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Create a SqlCommand object with the INSERT query and the SqlConnection
                Using command As New MySqlCommand(insertQuery, connection)
                    ' Add parameters to the SqlCommand to avoid SQL injection
                    command.Parameters.AddWithValue("@Name", txtMedName.Text)
                    command.Parameters.AddWithValue("@Type", ComboBox1.SelectedItem.ToString())
                    command.Parameters.AddWithValue("@Quantity", txtStock.Text)
                    command.Parameters.AddWithValue("@Price", RichTextBox1.Text)
                    command.Parameters.AddWithValue("@Arrival", dtpDate.Value.ToString("yyyy-MM-dd"))
                    command.Parameters.AddWithValue("@Expiry", DateTimePicker1.Value.ToString("yyyy-MM-dd"))

                    ' Execute the INSERT query
                    'command.ExecuteNonQuery()
                    Dim sqlRd As MySqlDataReader = command.ExecuteReader()
                    sqlRd.Close()

                    ' Close the connection
                End Using
                connection.Close()

            End Using

            MessageBox.Show("Medicine added successfully!")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Validateprice(ByVal num As String) As Boolean
        Return IsNumeric(num) ' Checks if it's a numeric value
    End Function
    Private Function ValidateQuantity(ByVal num As String) As Boolean
        Return IsNumeric(num) ' Checks if it's a numeric value
    End Function

    ' Function to validate timing format
    'Private Function ValidateTiming(timing As String) As Boolean
    '    Return Regex.IsMatch(timing, "^\d{1,2}[ap]m-\d{1,2}[ap]m$", RegexOptions.IgnoreCase) ' Checks if it's in the format "8am-2pm"
    'End Function
    'Private Function ValidateContactNo(contactNo As String) As Boolean
    '    Return Regex.IsMatch(contactNo, "^\d{10}$") ' Checks if it's a 10-digit number
    'End Function
End Class
