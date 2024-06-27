Imports MySql.Data.MySqlClient

Public Class signup
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        ' You can add any code you want to execute when Label5 is clicked
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim login As New Form2
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Retrieve the input values
        Dim tusername As String = username.Text.Trim()
        Dim tpassword As String = passowrd.Text.Trim()

        ' Check if the username is empty
        If String.IsNullOrEmpty(tusername) Then
            MessageBox.Show("Username cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            username.Focus()
            Exit Sub
        End If

        ' Check if the password is empty
        If String.IsNullOrEmpty(tpassword) Then
            MessageBox.Show("Password cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            passowrd.Focus()
            Exit Sub
        End If

        ' Define the connection string
        Dim connectionString As String = "Server=localhost;Database=bookliberary;User ID=yonatan;Password=123;Pooling=false"
        ' Create a connection object
        Dim connection As New MySqlConnection(connectionString)

        Try
            ' Open the connection
            connection.Open()

            ' Define the query to check if the username and password exist
            Dim query As String = "SELECT role FROM users WHERE username = @username AND password = @password"

            ' Create a command object
            Dim command As New MySqlCommand(query, connection)
            ' Add parameters to the command to prevent SQL injection
            command.Parameters.AddWithValue("@username", tusername)
            command.Parameters.AddWithValue("@password", tpassword)

            ' Execute the query and get the result
            Dim role As String = Convert.ToString(command.ExecuteScalar())

            ' Check if the username and password match and determine the role
            If Not String.IsNullOrEmpty(role) Then
                If role = "Admin" Then
                    Dim admin_home As New Form1
                    admin_home.Show()
                    Me.Hide()
                ElseIf role = "User" Then
                    Dim user_home As New Form3
                    user_home.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As MySqlException
            ' Handle any errors that occur during the connection or query execution
            MessageBox.Show("An error occurred while connecting to the database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            connection.Close()
        End Try
    End Sub

    ' TextBox event handlers (if needed)
    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged
    End Sub

    Private Sub passowrd_TextChanged(sender As Object, e As EventArgs) Handles passowrd.TextChanged
    End Sub
End Class
