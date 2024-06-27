Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form5
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bookname As String = TextBox1.Text.Trim()
        Dim auther As String = TextBox2.Text.Trim()
        Dim publishedd As String = TextBox3.Text.Trim()


        ' Define the connection string
        Dim connectionString As String = "Server=localhost;Database=bookliberary;User ID=yonatan;Password=123;Pooling=false"
        ' Create a connection object
        Dim connection As New MySqlConnection(connectionString)

        Try
            ' Open the connection
            connection.Open()

            ' Define the query to insert the rent data
            Dim query As String = "INSERT INTO book_info (`book_name`, `Auther_name`, `year_of_publish`) " & "VALUES (@book_name, @Auther_date, @year_of_publish)"

            ' Create a command object
            Dim command As New MySqlCommand(query, connection)
            ' Add parameters to the command to prevent SQL injection
            command.Parameters.AddWithValue("@book_name", bookname)
            command.Parameters.AddWithValue("@Auther_date", auther)
            command.Parameters.AddWithValue("@year_of_publish", publishedd)

            ' Execute the query
            command.ExecuteNonQuery()

            ' Display a success message
            MessageBox.Show("Successfully added ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As MySqlException
            ' Handle any errors that occur during the connection or query execution
            MessageBox.Show("An error occurred while connecting to the database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Close the connection
            connection.Close()
        End Try
    End Sub
End Class