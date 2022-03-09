<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LibraryManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label2 As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim PublisherLabel As System.Windows.Forms.Label
        Dim DatePublishedLabel As System.Windows.Forms.Label
        Dim PagesLabel As System.Windows.Forms.Label
        Dim RatingLabel As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.BookIDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.PublisherTextBox = New System.Windows.Forms.TextBox()
        Me.DatePublishedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PagesTextBox = New System.Windows.Forms.TextBox()
        Me.RatingTextBox = New System.Windows.Forms.TextBox()
        Label2 = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        PublisherLabel = New System.Windows.Forms.Label()
        DatePublishedLabel = New System.Windows.Forms.Label()
        PagesLabel = New System.Windows.Forms.Label()
        RatingLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 194)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(776, 283)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Books"
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "Books"
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(13, 92)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 37
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(13, 66)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton.TabIndex = 36
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'NewButton
        '
        Me.NewButton.Location = New System.Drawing.Point(13, 12)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(75, 23)
        Me.NewButton.TabIndex = 34
        Me.NewButton.Text = "New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(13, 41)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 35
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(126, 15)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(46, 13)
        Label2.TabIndex = 20
        Label2.Text = "BookID:"
        '
        'BookIDTextBox
        '
        Me.BookIDTextBox.Location = New System.Drawing.Point(214, 12)
        Me.BookIDTextBox.Name = "BookIDTextBox"
        Me.BookIDTextBox.ReadOnly = True
        Me.BookIDTextBox.Size = New System.Drawing.Size(75, 20)
        Me.BookIDTextBox.TabIndex = 22
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(126, 44)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 21
        NameLabel.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(214, 41)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameTextBox.TabIndex = 23
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Location = New System.Drawing.Point(126, 70)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(41, 13)
        AuthorLabel.TabIndex = 24
        AuthorLabel.Text = "Author:"
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Location = New System.Drawing.Point(214, 67)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AuthorTextBox.TabIndex = 25
        '
        'PublisherLabel
        '
        PublisherLabel.AutoSize = True
        PublisherLabel.Location = New System.Drawing.Point(126, 96)
        PublisherLabel.Name = "PublisherLabel"
        PublisherLabel.Size = New System.Drawing.Size(53, 13)
        PublisherLabel.TabIndex = 26
        PublisherLabel.Text = "Publisher:"
        '
        'PublisherTextBox
        '
        Me.PublisherTextBox.Location = New System.Drawing.Point(214, 93)
        Me.PublisherTextBox.Name = "PublisherTextBox"
        Me.PublisherTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PublisherTextBox.TabIndex = 27
        '
        'DatePublishedLabel
        '
        DatePublishedLabel.AutoSize = True
        DatePublishedLabel.Location = New System.Drawing.Point(126, 123)
        DatePublishedLabel.Name = "DatePublishedLabel"
        DatePublishedLabel.Size = New System.Drawing.Size(82, 13)
        DatePublishedLabel.TabIndex = 28
        DatePublishedLabel.Text = "Date Published:"
        '
        'DatePublishedDateTimePicker
        '
        Me.DatePublishedDateTimePicker.Location = New System.Drawing.Point(214, 119)
        Me.DatePublishedDateTimePicker.Name = "DatePublishedDateTimePicker"
        Me.DatePublishedDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DatePublishedDateTimePicker.TabIndex = 29
        '
        'PagesLabel
        '
        PagesLabel.AutoSize = True
        PagesLabel.Location = New System.Drawing.Point(126, 148)
        PagesLabel.Name = "PagesLabel"
        PagesLabel.Size = New System.Drawing.Size(40, 13)
        PagesLabel.TabIndex = 30
        PagesLabel.Text = "Pages:"
        '
        'PagesTextBox
        '
        Me.PagesTextBox.Location = New System.Drawing.Point(172, 145)
        Me.PagesTextBox.Name = "PagesTextBox"
        Me.PagesTextBox.Size = New System.Drawing.Size(62, 20)
        Me.PagesTextBox.TabIndex = 31
        '
        'RatingLabel
        '
        RatingLabel.AutoSize = True
        RatingLabel.Location = New System.Drawing.Point(261, 148)
        RatingLabel.Name = "RatingLabel"
        RatingLabel.Size = New System.Drawing.Size(41, 13)
        RatingLabel.TabIndex = 32
        RatingLabel.Text = "Rating:"
        '
        'RatingTextBox
        '
        Me.RatingTextBox.Location = New System.Drawing.Point(308, 145)
        Me.RatingTextBox.Name = "RatingTextBox"
        Me.RatingTextBox.Size = New System.Drawing.Size(62, 20)
        Me.RatingTextBox.TabIndex = 33
        '
        'LibraryManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 489)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.NewButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.BookIDTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(AuthorLabel)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(PublisherLabel)
        Me.Controls.Add(Me.PublisherTextBox)
        Me.Controls.Add(DatePublishedLabel)
        Me.Controls.Add(Me.DatePublishedDateTimePicker)
        Me.Controls.Add(PagesLabel)
        Me.Controls.Add(Me.PagesTextBox)
        Me.Controls.Add(RatingLabel)
        Me.Controls.Add(Me.RatingTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "LibraryManager"
        Me.Text = "Library Manager"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BooksBindingSource As BindingSource
    Friend WithEvents DeleteButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents NewButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents BookIDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AuthorTextBox As TextBox
    Friend WithEvents PublisherTextBox As TextBox
    Friend WithEvents DatePublishedDateTimePicker As DateTimePicker
    Friend WithEvents PagesTextBox As TextBox
    Friend WithEvents RatingTextBox As TextBox
End Class
