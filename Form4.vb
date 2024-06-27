Imports MySql.Data.MySqlClient

Public Class Form4
    Dim book_n As String
    Dim auth As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rent As New Form6
        rent.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        auth = auther.Text.Trim()
        book_n = book_name.Text.Trim()
        Dim connectionString As String = "Server=localhost;Database=bookliberary;User ID=yonatan;Password=123;Pooling=false"
        ' Create a connection object
        Dim connection As New MySqlConnection(connectionString)

        Try
            ' Open the connection
            connection.Open()

            ' Define the query to search for the book by name and author
            Dim query As String = "SELECT book_name FROM book_info WHERE book_name = @book_name AND Auther_name = @auther_name"

            ' Create a command object
            Dim command As New MySqlCommand(query, connection)
            ' Add parameters to the command to prevent SQL injection
            command.Parameters.AddWithValue("@book_name", book_n)
            command.Parameters.AddWithValue("@auther_name", auth)

            ' Execute the query and get the result
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                ' If there are matching rows, read the book name
                reader.Read()
                show_text.Text = reader("book_name").ToString()
            Else
                ' If no matching rows, display "No book found"
                show_text.Text = "No book found"
            End If

            ' Close the reader
            reader.Close()

        Catch ex As MySqlException
            ' Handle any errors that occur during the connection or query execution
            MessageBox.Show("An error occurred while connecting to the database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Close the connection
            connection.Close()
        End Try
    End Sub
End Class
