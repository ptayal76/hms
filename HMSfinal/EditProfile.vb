' Import necessary libraries for MySQL and SQL Server.
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

' EditProfile class for handling profile editing.
Public Class EditProfile

    ' MySQL connection and command objects for database interaction.
    Dim Mysqlconn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim SqlQuery As String
    Dim sqlDt As MySqlDataReader

    ' Variables to store user profile information.
    Dim email As String
    Dim password As String
    Dim userName As String
    Dim sex As String
    Dim dob As String
    Dim bloodGroup As String
    Dim contactNumber As String
    Dim address As String

    ' Property to set the email value from the calling form.
    Public WriteOnly Property takeEmail As String
        Set(value As String)
            email = value
        End Set
    End Property

    ' Property to set the password value from the calling form.
    Public WriteOnly Property takePassword As String
        Set(value As String)
            password = value
        End Set
    End Property

    ' EditProfile_Load event handler executes when the form is loaded.
    Private Sub EditProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the email value in TextBox2 when the form loads.
        TextBox2.Text = email
    End Sub

    ' Button1_Click event handler executes when Button1 is clicked.
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Retrieve user-entered information for profile update.
        userName = TextBox1.Text
        contactNumber = TextBox3.Text
        address = RichTextBox1.Text

        ' Determine the value of the sex based on the selected index of ComboBox1.
        If ComboBox1.SelectedIndex = 1 Then
            sex = "M"
        Else
            sex = "F"
        End If

        bloodGroup = TextBox4.Text
        ' Format the date of birth in the required format.
        dob = DateTimePicker1.Value.Date.ToString("yyyy-MM-dd")

        ' Validation checks for user-entered information.
        If userName = "" Then
            MsgBox("Please enter Name!")
            Exit Sub
        End If

        If contactNumber = "" Then
            MsgBox("Please enter Contact Number!")
            Exit Sub
        End If

        If contactNumber.Length <> 10 Then
            MsgBox("Please enter a valid 10-digit Contact Number!")
            Exit Sub
        End If

        If address = "" Then
            MsgBox("Please enter Address!")
            Exit Sub
        End If

        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Please select gender!")
            Exit Sub
        End If

        If bloodGroup = "" Then
            MsgBox("Please enter Blood Group!")
            Exit Sub
        End If

        ' MySQL database connection setup.
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=piyush123;database=hms;"
        Mysqlconn.Open()

        ' Query to count the number of entries in the 'patient' table.
        SqlQuery = "SELECT COUNT(*) FROM patient"

        ' Execute the query and read the result.
        sqlCmd.Connection = Mysqlconn
        sqlCmd.CommandText = SqlQuery
        sqlRd = sqlCmd.ExecuteReader

        Dim numOfEntries As Integer

        ' Retrieve the count and increment by 1 to determine the new entry's ID.
        While sqlRd.Read()
            numOfEntries = sqlRd.GetInt32(0) + 1
        End While

        sqlRd.Close()

        ' Query to insert the new patient information into the 'patient' table.
        SqlQuery = "INSERT INTO patient VALUES(" & numOfEntries & ",'" & userName & "', '" & password & "', '" & email & "','" & sex & "', '" & dob & "', '" & address & "','" & bloodGroup & "', '" & contactNumber & "');"

        ' Execute the query to insert the new record.
        sqlCmd.Connection = Mysqlconn
        sqlCmd.CommandText = SqlQuery
        sqlRd = sqlCmd.ExecuteReader

        ' Close the database connection.
        sqlRd.Close()
        Mysqlconn.Close()

        ' Display the main Form1 after updating the profile.
        Dim form As New Form1()
        form.Show()
        Me.Hide()
    End Sub
End Class