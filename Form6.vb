Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bookname As String = TextBox1.Text.Trim()
        Dim auther As String = TextBox2.Text.Trim()
        Dim publishedd As String = TextBox3.Text.Trim()
        Dim name As String = TextBox4.Text.Trim() ' Corrected TextBox index
        Dim rentedd As String = TextBox5.Text.Trim() ' Corrected TextBox index
        Dim expd As String = TextBox6.Text.Trim() ' Corrected TextBox index

        ' Define the connection string
        Dim connectionString As String = "Server=localhost;Database=bookliberary;User ID=yonatan;Password=123;Pooling=false"
        ' Create a connection object
        Dim connection As New MySqlConnection(connectionString)

        Try
            ' Open the connection
            connection.Open()

            ' Define the query to insert the rent data
            Dim query As String = "INSERT INTO rent (`renter name`, `rented date`, `expire date`, `book name`, `auther`, `published date`) " &
                                  "VALUES (@renter_name, @rented_date, @expire_date, @book_name, @auther, @published_date)"

            ' Create a command object
            Dim command As New MySqlCommand(query, connection)
            ' Add parameters to the command to prevent SQL injection
            command.Parameters.AddWithValue("@renter_name", name)
            command.Parameters.AddWithValue("@rented_date", rentedd)
            command.Parameters.AddWithValue("@expire_date", expd)
            command.Parameters.AddWithValue("@book_name", bookname)
            command.Parameters.AddWithValue("@auther", auther)
            command.Parameters.AddWithValue("@published_date", publishedd)

            ' Execute the query
            command.ExecuteNonQuery()

            ' Display a success message
            MessageBox.Show("Successfully added to rent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As MySqlException
            ' Handle any errors that occur during the connection or query execution
            MessageBox.Show("An error occurred while connecting to the database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Close the connection
            connection.Close()
        End Try
    End Sub
End Class
