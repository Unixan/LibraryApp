using System.Collections.Generic;

namespace LibraryApp.Model;

public class Library
{
    public List<Book> Books { get; set; }
    public Book Book { get; set; }

    public Library()
    {
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    
    public Book GetBook(int index)
    {
        return Books[index];
    }
}