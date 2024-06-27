Imports MySql.Data.MySqlClient
Imports Windows.Win32.System



Public Class Form2
    Private Sub create_Click(sender As Object, e As EventArgs) Handles create.Click
        ' Retrieve the input values
        Dim Tusername As String = username.Text.Trim()
        Dim Tpassword As String = password.Text.Trim()
        Dim role As String = ""

        ' Check if the username is empty
        If String.IsNullOrEmpty(Tusername) Then
            MessageBox.Show("Username cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            username.Focus()
            Exit Sub
        End If

        ' Check if the password is empty
        If String.IsNullOrEmpty(Tpassword) Then
            MessageBox.Show("Password cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            password.Focus()
            Exit Sub
        End If

        ' Check if any radio button is checked and assign the role value
        If Admin.Checked Then
            role = "Admin"
        ElseIf user.Checked Then
            role = "User"
        Else
            MessageBox.Show("Please select a role.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Admin.Focus() ' Set focus to one of the radio buttons
            Exit Sub
        End If

        ' Define the connection string
        Dim connectionString As String = "Server=localhost;Database=bookliberary;User ID=yonatan;Password=123;Pooling=false"
        ' Create a connection object
        Dim connection As New MySqlConnection(connectionString)

        Try
            ' Open the connection
            connection.Open()

            ' Define the query to insert the user data
            Dim query As String = "INSERT INTO users (username, password, role) VALUES (@username, @password, @role)"

            ' Create a command object
            Dim command As New MySqlCommand(query, connection)
            ' Add parameters to the command to prevent SQL injection
            command.Parameters.AddWithValue("@username", Tusername)
            command.Parameters.AddWithValue("@password", Tpassword)
            command.Parameters.AddWithValue("@role", role)

            ' Execute the query
            command.ExecuteNonQuery()

            ' Display a success message
            MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim goback As New signup
            signup.Show()
            Me.Hide()
        Catch ex As MySqlException
            ' Handle any errors that occur during the connection or query execution
            MessageBox.Show("An error occurred while connecting to the database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Close the connection
            connection.Close()
        End Try
    End Sub

    ' TextBox and RadioButton event handlers (if needed)
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged
    End Sub

    Private Sub Admin_CheckedChanged(sender As Object, e As EventArgs) Handles Admin.CheckedChanged
    End Sub

    Private Sub user_CheckedChanged(sender As Object, e As EventArgs) Handles user.CheckedChanged
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
