Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class AuthenticationPage

    ' MySqlConnection is used to establish a connection to the MySQL database.
    Dim Mysqlconn As New MySqlConnection

    ' MySqlCommand is used to execute SQL queries.
    Dim sqlCmd As New MySqlCommand

    ' MySqlDataReader is used to read the results of a SQL query.
    Dim sqlRd As MySqlDataReader

    ' String to store SQL queries.
    Dim SqlQuery As String

    ' MySqlDataReader used for data reading operations.
    Dim sqlDt As MySqlDataReader

    ' HashPassword function takes a plaintext password and returns its hashed version.
    Private Function HashPassword(password As String) As String
        ' Using SHA256 algorithm for password hashing.
        Using sha256 As SHA256 = SHA256.Create()
            ' Compute hash for the UTF-8 encoded password.
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()

            ' Convert each byte of the hashed result to hexadecimal and append to the string builder.
            For Each b As Byte In hashedBytes
                builder.Append(b.ToString("x2"))
            Next

            ' Return the final hashed password as a string.
            Return builder.ToString()
        End Using
    End Function

    ' LinkLabel1_LinkClicked event handler executes when LinkLabel1 is clicked.
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' Hide unnecessary UI elements and show the registration UI.
        Label3.Visible = False
        LinkLabel1.Visible = False
        Label4.Visible = True
        TextBox3.Visible = True
        Button1.Visible = False
        Button2.Visible = True
        Label5.Visible = True
        LinkLabel2.Visible = True
    End Sub

    ' Form1_Load event handler executes when the form is loaded.
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set initial visibility settings for UI elements.
        Label4.Visible = False
        TextBox3.Visible = False
        Button2.Visible = False
        Label5.Visible = False
        LinkLabel2.Visible = False

        ' Set password characters for TextBox2 and TextBox3 to asterisk.
        TextBox2.PasswordChar = "*"
        TextBox3.PasswordChar = "*"

        ' Populate ComboBox1 with user type options and set the default selection.
        ComboBox1.Items.Add("Login as")
        ComboBox1.Items.Add("Patient")
        ComboBox1.Items.Add("Admin")
        ComboBox1.SelectedIndex = 0
    End Sub

    ' LinkLabel2_LinkClicked event handler executes when LinkLabel2 is clicked.
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        ' Reset UI elements to show the login UI.
        Label3.Visible = True
        LinkLabel1.Visible = True
        Label4.Visible = False
        TextBox3.Visible = False
        Button1.Visible = True
        Button2.Visible = False
        Label5.Visible = False
        LinkLabel2.Visible = False
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Check if the selected user type is Patient
        If ComboBox1.SelectedIndex = 1 Then
            ' Establish a connection to the MySQL database
            Mysqlconn.ConnectionString = "server=localhost;userid=root;password=piyush123;database=hms;"
            Mysqlconn.Open()

            ' Retrieve email and password input from the user
            Dim emailToCheck As String = TextBox1.Text
            Dim pass As String = TextBox2.Text

            ' Validate if the email is provided
            If emailToCheck = "" Then
                MsgBox("Please enter valid email")
                Mysqlconn.Close()
                Exit Sub
            End If

            ' Validate if the password is provided
            If pass = "" Then
                MsgBox("Please enter valid password")
                Mysqlconn.Close()
                Exit Sub
            End If

            ' Formulate the SQL query to check if the patient with the provided email exists
            SqlQuery = "SELECT * FROM patient WHERE Email_id = '" & emailToCheck & "';"

            ' Set up the MySQL command
            sqlCmd.Connection = Mysqlconn
            sqlCmd.CommandText = SqlQuery

            ' Execute the query and obtain the results
            sqlRd = sqlCmd.ExecuteReader

            ' Check if the patient with the provided email exists
            If sqlRd.HasRows Then
                ' Iterate through the results
                While sqlRd.Read()
                    ' Retrieve relevant data from the database
                    Dim tem1 As Integer = sqlRd.GetInt32(0)
                    Dim temp2 As String = sqlRd.GetString(1)
                    Dim newPass As String = sqlRd.GetString(2)

                    ' Check if the hashed password matches the stored password
                    If HashPassword(pass) = newPass Then
                        ' If successful, navigate to Form1 (patient profile)
                        Dim profile As New Form1()
                        profile.Show()
                        Me.Hide()
                    Else
                        ' If passwords do not match, display an error message
                        MsgBox("Incorrect email or password")
                    End If
                End While
            Else
                ' If the patient with the provided email does not exist, display an error message
                MsgBox("Incorrect email or password")
            End If

            ' Close the data reader and database connection
            sqlRd.Close()
            Mysqlconn.Close()

            ' Check if the selected user type is Admin
        ElseIf ComboBox1.SelectedIndex = 2 Then
            ' Establish a connection to the MySQL database
            Mysqlconn.ConnectionString = "server=localhost;userid=root;password=piyush123;database=hms;"
            Mysqlconn.Open()

            ' Retrieve email and password input from the user
            Dim emailToCheck As String = TextBox1.Text
            Dim pass As String = TextBox2.Text

            ' Validate if the email is provided
            If emailToCheck = "" Then
                MsgBox("Please enter valid email")
                Mysqlconn.Close()
                Exit Sub
            End If

            ' Validate if the password is provided
            If pass = "" Then
                MsgBox("Please enter valid password")
                Mysqlconn.Close()
                Exit Sub
            End If

            ' Formulate the SQL query to check if the admin with the provided email exists
            SqlQuery = "SELECT * FROM admin WHERE Email_id = '" & emailToCheck & "';"

            ' Set up the MySQL command
            sqlCmd.Connection = Mysqlconn
            sqlCmd.CommandText = SqlQuery

            ' Execute the query and obtain the results
            sqlRd = sqlCmd.ExecuteReader

            ' Check if the admin with the provided email exists
            If sqlRd.HasRows Then
                ' Iterate through the results
                While sqlRd.Read()
                    ' Retrieve relevant data from the database
                    Dim email As String = sqlRd.GetString(0)
                    Dim userPass As String = sqlRd.GetString(1)

                    ' Check if the hashed password matches the stored password
                    If HashPassword(pass) = userPass Then
                        ' If successful, navigate to Form2 (admin profile)
                        Dim profile As New Form2()
                        profile.Show()
                        Me.Hide()
                    Else
                        ' If passwords do not match, display an error message
                        MsgBox("Incorrect email or password")
                    End If
                End While
            Else
                ' If the admin with the provided email does not exist, display an error message
                MsgBox("Incorrect email or password")
            End If

            ' Close the data reader and database connection
            sqlRd.Close()
            Mysqlconn.Close()

        Else
            ' If no user type is selected, display an error message
            MsgBox("Please select one field for user type")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Check if the selected user type is Patient
        If ComboBox1.SelectedIndex = 1 Then
            ' Establish a connection to the MySQL database
            Mysqlconn.ConnectionString = "server=localhost;userid=root;password=piyush123;database=hms;"
            Mysqlconn.Open()

            ' Retrieve user input for registration
            Dim emailToRegister As String = TextBox1.Text
            Dim pass As String = TextBox2.Text
            Dim confirmPass As String = TextBox3.Text

            ' Validate if the email is provided
            If emailToRegister = "" Then
                MsgBox("Please enter valid email")
                Mysqlconn.Close()
                Exit Sub
            End If

            ' Validate if the password is provided
            If pass = "" Then
                MsgBox("Please enter valid password")
                Mysqlconn.Close()
                Exit Sub
            End If

            ' Validate if the confirm password is provided
            If confirmPass = "" Then
                MsgBox("Please confirm password")
                Mysqlconn.Close()
                Exit Sub
            End If

            ' Validate if password and confirm password match
            If pass <> confirmPass Then
                MsgBox("Password and confirm password are not the same")
                Mysqlconn.Close()
                Exit Sub
            End If

            ' Formulate the SQL query to check if the patient with the provided email already exists
            SqlQuery = "SELECT * FROM patient WHERE Email_id = '" & emailToRegister & "';"

            ' Set up the MySQL command
            sqlCmd.Connection = Mysqlconn
            sqlCmd.CommandText = SqlQuery

            ' Execute the query and obtain the results
            sqlRd = sqlCmd.ExecuteReader

            ' Check if an account already exists with the provided email
            If sqlRd.HasRows Then
                MsgBox("Account already exists with this email")
                Mysqlconn.Close()
                Exit Sub
            End If

            ' Close the data reader
            sqlRd.Close()

            ' Open the EditProfile form for further registration
            Dim editProfileForm As New EditProfile()
            editProfileForm.takeEmail = emailToRegister
            editProfileForm.takePassword = HashPassword(pass)
            editProfileForm.Show()

            ' Hide the current form
            Me.Hide()

            ' Check if the selected user type is Admin
        ElseIf ComboBox1.SelectedIndex = 2 Then
            ' Establish a connection to the MySQL database
            Mysqlconn.ConnectionString = "server=localhost;userid=root;password=piyush123;database=hms;"
            Mysqlconn.Open()

            ' Retrieve user input for registration
            Dim emailToRegister As String = TextBox1.Text
            Dim pass As String = TextBox2.Text
            Dim confirmPass As String = TextBox3.Text

            ' Validate if the email is provided
            If emailToRegister = "" Then
                MsgBox("Please enter valid email")
                Mysqlconn.Close()
                Exit Sub
            End If

            ' Validate if the password is provided
            If pass = "" Then
                MsgBox("Please enter valid password")
                Mysqlconn.Close()
                Exit Sub
            End If

            ' Validate if the confirm password is provided
            If confirmPass = "" Then
                MsgBox("Please confirm password")
                Mysqlconn.Close()
                Exit Sub
            End If

            ' Validate if password and confirm password match
            If pass <> confirmPass Then
                MsgBox("Password and confirm password are not the same")
                Mysqlconn.Close()
                Exit Sub
            End If

            ' Formulate the SQL query to check if the admin with the provided email already exists
            SqlQuery = "SELECT * FROM admin WHERE email_id = '" & emailToRegister & "';"

            ' Set up the MySQL command
            sqlCmd.Connection = Mysqlconn
            sqlCmd.CommandText = SqlQuery

            ' Execute the query and obtain the results
            sqlRd = sqlCmd.ExecuteReader

            ' Check if an account already exists with the provided email
            If sqlRd.HasRows Then
                MsgBox("Account already exists with this email")
                Mysqlconn.Close()
                Exit Sub
            End If

            ' Close the data reader
            sqlRd.Close()

            ' Formulate the SQL query to insert a new admin account
            SqlQuery = "INSERT INTO admin(email_id , password) VALUES( '" & emailToRegister & "', '" & HashPassword(pass) & "');"

            ' Set up the MySQL command
            sqlCmd.Connection = Mysqlconn
            sqlCmd.CommandText = SqlQuery

            ' Execute the query and obtain the results
            sqlRd = sqlCmd.ExecuteReader

            ' Close the data reader
            sqlRd.Close()

            ' Close the database connection
            Mysqlconn.Close()

            ' Open the Form2 (admin profile) for the newly registered admin
            Dim profile As New Form2()
            profile.Show()

            ' Hide the current form
            Me.Hide()

        Else
            ' If no user type is selected, display an error message
            MsgBox("Please select one field for user type")
        End If
    End Sub


End Class