Imports MySql.Data.MySqlClient

Public Class rent
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' You can add any code you want to execute when Label1 is clicked
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Retrieve the input values
        Dim bookname As String = TextBox1.Text.Trim()
        Dim auther As String = TextBox2.Text.Trim()
        Dim bookid As String = TextBox3.Text.Trim()
        Dim datap As String = TextBox4.Text.Trim()

        ' Define the connection string
        Dim connectionString As String = "Server=localhost;Database=bookliberary;User ID=yonatan;Password=123;Pooling=false"
        ' Create a connection object
        Dim connection As New MySqlConnection(connectionString)

        Try
            ' Open the connection
            connection.Open()

            ' Define the query to delete the book data
            Dim query As String = "DELETE FROM book_info WHERE book_id = @bookid AND book_name = @bookname AND Auther_name = @auther_name AND year_of_publish = @datap"

            ' Create a command object
            Dim command As New MySqlCommand(query, connection)
            ' Add parameters to the command to prevent SQL injection
            command.Parameters.AddWithValue("@bookid", bookid)
            command.Parameters.AddWithValue("@bookname", bookname)
            command.Parameters.AddWithValue("@auther_name", auther)
            command.Parameters.AddWithValue("@datap", datap)

            ' Execute the query
            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            ' Check if any rows were affected (i.e., if the record was deleted)
            If rowsAffected > 0 Then
                ' Display a success message
                MessageBox.Show("Successfully removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Display a message if no records were deleted
                MessageBox.Show("No matching book found to delete.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As MySqlException
            ' Handle any errors that occur during the connection or query execution
            MessageBox.Show("An error occurred while connecting to the database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Close the connection
            connection.Close()
        End Try
    End Sub
End Class
