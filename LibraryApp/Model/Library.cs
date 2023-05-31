using System.Collections.ObjectModel;

namespace LibraryApp.Model;

public class Library
{
    public ObservableCollection<Book> Books { get; set; }

    public Library()
    {
        Books = new ObservableCollection<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }
}