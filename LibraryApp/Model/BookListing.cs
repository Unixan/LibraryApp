using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LibraryApp.Model;

public class BookListing : StackPanel
{
    public Book Book { get; private set; }
    public BookListing(Book book)
    {
        Book = book;
        Width = 413;
        Children.Add(new Textitem(book.Title, 16, true));
        Children.Add(new Textitem("Forfatter: " + book.Author));
        Children.Add(new Textitem("Sjanger: " + book.Genre));
        HorizontalAlignment = HorizontalAlignment.Stretch;
        Background = book.IsAvailable ? new SolidColorBrush(Colors.LightGreen) : new SolidColorBrush(Colors.LightCoral);
    }
    
    public Book GetBook()
    {
        return Book;
    }
}