Public Class LibraryManager

    'The library database
    Dim db As libraryDataContext

    'Don't register table cell selections until this is true
    Dim registerSelections = False

    Private Sub LibraryManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        db = New libraryDataContext()

        ReloadData()

        registerSelections = True

    End Sub

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
        Dim row = DataGridView1.CurrentRow

        Try
            If registerSelections AndAlso row IsNot Nothing Then

                Dim id = CInt(row.Cells(0).Value)

                Dim rowData = (From book In db.Books
                               Where book.BookID = id
                               Select book).ToList()(0)
                Return rowData

            End If
        Catch ex As Exception

        End Try

        Dim bookList = (From book In db.Books).ToList()

        If bookList.Count > 0 Then
            Return (From book In db.Books).ToList()(0)
        Else
            Return Nothing
        End If

    End Function

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

        'Dim row = DataGridView1.CurrentRow

        'If registerSelections AndAlso row IsNot Nothing Then

        '    Dim id = CInt(row.Cells(0)?.Value)

        '    Dim rowData = (From book In db.Books Where book.BookID = id).ToList()(0)

        Dim book = GetSelectedBook()

        If book IsNot Nothing Then

            BookIDTextBox.Text = book.BookID
            NameTextBox.Text = If(book.Name, "")
            AuthorTextBox.Text = If(book.Author, "")
            PublisherTextBox.Text = If(book.Publisher, "")
            DatePublishedDateTimePicker.Value = If(book.DatePublished, Date.Now)
            PagesTextBox.Text = If(book.Pages, "")
            RatingTextBox.Text = If(book.Rating, "")

            'Dim index = DataGridView1.CurrentRow.Index
            'MessageBox.Show(id)
            'MessageBox.Show(DataGridView1.CurrentRow.ToString())
            'DataGridView1.row
            'End If
        End If


    End Sub


    ''' <summary>
    ''' Numerical fields can't be cast from "" (an empty or null string), so this returns 0 instead when "" is the input
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

    ''' <summary>
    ''' Add a new book
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim book As New Book With {
            .Name = NameTextBox.Text,
            .Author = AuthorTextBox.Text,
            .Rating = SafeConvert(RatingTextBox.Text),
            .DatePublished = DatePublishedDateTimePicker.Value,
            .Pages = SafeConvert(PagesTextBox.Text),
            .Publisher = PublisherTextBox.Text
        }

        db.Books.InsertOnSubmit(book)

        Try
            db.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        ReloadData()
    End Sub

    ''' <summary>
    ''' Update a book's details
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click

        'Get the row to update
        'DataGridView1.
        'Get the corrosponding database item to update

        'Carry out the update

        'Execute the results on the table

        Dim book = GetSelectedBook()

        If book IsNot Nothing Then


            book.Name = NameTextBox.Text
            book.Author = AuthorTextBox.Text
            book.Rating = SafeConvert(RatingTextBox.Text)
            book.DatePublished = DatePublishedDateTimePicker.Value
            book.Pages = SafeConvert(PagesTextBox.Text)
            book.Publisher = PublisherTextBox.Text


        End If

        Try
            db.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        ReloadData()
    End Sub

    ''' <summary>
    ''' Remove a book
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        Try
            Dim book = GetSelectedBook()

            db.Books.DeleteOnSubmit(book)

            db.SubmitChanges()
        Catch ex As Exception
            'handle exceptions
        End Try

        ReloadData()
    End Sub

    ''' <summary>
    ''' Clear the input fields as a starting point to create a new empty book
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


End Class
