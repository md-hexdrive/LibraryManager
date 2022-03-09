''' <summary>
''' A basic library inventory manager
''' </summary>
Public Class LibraryManager

    'The library database
    Dim db As libraryDataContext

    Private Sub LibraryManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        db = New libraryDataContext()

        ReloadData()

    End Sub

#Region "Utility functions"
    ''' <summary>
    ''' Refresh the data held in the table from the database
    ''' </summary>
    Private Sub ReloadData()
        DataGridView1.DataSource = From book In db.Books
    End Sub

    ''' <summary>
    ''' Return the book currently selected in the table by the program's user
    ''' </summary>
    ''' <returns></returns>
    Private Function GetSelectedBook() As Book

        ' Get the selected row 
        Dim row = DataGridView1.CurrentRow

        ' prevent exceptions from bubbling out
        Try

            If row IsNot Nothing Then

                ' Get the book's id stored in the row 
                Dim id = CInt(row.Cells(0).Value)

                ' Get the book's complete details from the database
                Dim book = (From bk In db.Books
                            Where bk.BookID = id
                            Select bk).ToList()(0)
                Return book

            End If
        Catch ex As Exception
            'Handle exceptions
        End Try

        ' If anything above failed

        ' Get the list of books from the database
        Dim bookList = (From book In db.Books).ToList()

        ' return the first book in the database, if there are any books available
        If bookList.Count > 0 Then
            Return (From book In db.Books).ToList()(0)
        Else ' Otherwise, return nothing
            Return Nothing
        End If

    End Function




    ''' <summary>
    ''' Numerical fields can't be directly initialized from "" (an empty or null string), 
    ''' so this returns 0 instead to prevent an exception when: Value = "" 
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <returns></returns>
    Private Function SafeConvert(Value As String) As String
        If String.IsNullOrEmpty(Value) Then
            Return "0"
        Else
            Return Value
        End If
    End Function

#End Region

#Region "Event-Handlers"

    ''' <summary>
    ''' Change which book's data is focused on in the application controls
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DataGridView1_Select(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

        Dim book = GetSelectedBook()

        'Only change the fields contents when a book is available to select
        If book IsNot Nothing Then

            BookIDTextBox.Text = book.BookID
            NameTextBox.Text = If(book.Name, "")
            AuthorTextBox.Text = If(book.Author, "")
            PublisherTextBox.Text = If(book.Publisher, "")
            DatePublishedDateTimePicker.Value = If(book.DatePublished, Date.Now)
            PagesTextBox.Text = If(book.Pages, "")
            RatingTextBox.Text = If(book.Rating, "")

        End If

    End Sub

    ''' <summary>
    ''' Add a new book
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        'Create the new book from the data in the input fields
        Dim book As New Book With {
            .Name = NameTextBox.Text,
            .Author = AuthorTextBox.Text,
            .Rating = SafeConvert(RatingTextBox.Text),
            .DatePublished = DatePublishedDateTimePicker.Value,
            .Pages = SafeConvert(PagesTextBox.Text),
            .Publisher = PublisherTextBox.Text
        }

        'Add the book

        db.Books.InsertOnSubmit(book)

        Try
            db.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        'Reload the table with the new changes
        ReloadData()
    End Sub

    ''' <summary>
    ''' Update a book's details
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click


        'Get the book to update
        Dim book = GetSelectedBook()

        'Only run if book exists in table
        If book IsNot Nothing Then

            'Update the book's data with the new versions
            book.Name = NameTextBox.Text
            book.Author = AuthorTextBox.Text
            book.Rating = SafeConvert(RatingTextBox.Text)
            book.DatePublished = DatePublishedDateTimePicker.Value
            book.Pages = SafeConvert(PagesTextBox.Text)
            book.Publisher = PublisherTextBox.Text


        End If

        'Try to update the database 
        Try
            db.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        ' refresh the window
        ReloadData()
    End Sub

    ''' <summary>
    ''' Remove a book
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        Try
            'Get the book to delete
            Dim book = GetSelectedBook()

            'If there is a book to delete
            If book IsNot Nothing Then
                'delete the book

                db.Books.DeleteOnSubmit(book)

                db.SubmitChanges()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        ReloadData()
    End Sub

    ''' <summary>
    ''' Reset the data input fields, so that the user can input a new book's data 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        BookIDTextBox.Text = ""
        NameTextBox.Text = ""
        AuthorTextBox.Text = ""
        PublisherTextBox.Text = ""
        DatePublishedDateTimePicker.Value = Date.Now
        PagesTextBox.Text = ""
        RatingTextBox.Text = ""
    End Sub

#End Region

End Class
