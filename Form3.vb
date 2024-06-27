Imports MySql.Data.MySqlClient

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim view As New Form4
        view.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Rent As New Form6
        Rent.Show()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
    Private Sub LoadBookData()
        ' Define the connection string
        Dim connectionString As String = "Server=localhost;Database=bookliberary;User ID=yonatan;Password=123;Pooling=false"
        ' Create a connection object
        Dim connection As New MySqlConnection(connectionString)

        Try
            ' Open the connection
            connection.Open()

            ' Define the query to retrieve data from the book_info table
            Dim query As String = "SELECT * FROM book_info"

            ' Create a command object
            Dim command As New MySqlCommand(query, connection)

            ' Execute the query and retrieve the data
            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' Clear the ListView before adding new items
            ListView1.Items.Clear()

            ' Ensure the ListView is set to details view and columns are added
            ListView1.View = View.Details
            ListView1.Columns.Clear()
            ListView1.Columns.Add("Book ID", 100, HorizontalAlignment.Left)
            ListView1.Columns.Add("Book Name", 150, HorizontalAlignment.Left)
            ListView1.Columns.Add("Author Name", 150, HorizontalAlignment.Left)
            ListView1.Columns.Add("Year of Publish", 100, HorizontalAlignment.Left)

            ' Loop through the data and add items to the ListView
            While reader.Read()
                ' Create a new ListViewItem with the data from the current row
                Dim item As New ListViewItem(reader("book_id").ToString())
                item.SubItems.Add(reader("book_name").ToString())
                item.SubItems.Add(reader("Auther_name").ToString())
                item.SubItems.Add(reader("year_of_publish").ToString())

                ' Add the ListViewItem to the ListView
                ListView1.Items.Add(item)
            End While

            ' Close the reader
            reader.Close()

        Catch ex As MySqlException
            ' Display the error message
            MessageBox.Show("An error occurred while connecting to the database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Close the connection
            connection.Close()
        End Try
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBookData()
    End Sub
End Class