﻿using System.Windows;
using LibraryApp.Model;

namespace LibraryApp.View
{
    public partial class BookDetails : Window
    {
        public Book Book { get; private set; }
        public BookDetails (Window books, Book book)
        {
            Book = book;
            Owner = books;
            InitializeComponent();
            PopulateDetails(book);
        }

        private void PopulateDetails(Book book)
        {
            Title.Text = book.Title;
            Author.Text = book.Author;
            Description.Text = book.Description;
            Genre.Text = book.Genre;
            Status.Text = GetBookStatus(book);
        }

        private string GetBookStatus(Book book)
        {
            return book.IsAvailable ? "Ledig" : "Lånt ut til: " + book.LoanedTo;
        }

        private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
