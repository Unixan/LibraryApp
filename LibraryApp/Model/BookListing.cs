using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace LibraryApp.Model;

public class BookListing : StackPanel
{
    public TextBlock Title { get; set; } = new TextBlock();
    public TextBlock Author { get; set; } = new TextBlock();
    public TextBlock Genre { get; set; } = new TextBlock();

    public BookListing(Book book)
    {
        Title.Text = book.Title;
        Title.FontSize = 15;
        Title.FontWeight = FontWeights.Bold;
        Author.Text = "Forfatter: " + book.Author;
        Author.FontWeight = FontWeights.Bold;
        Genre.Text = "Kategori: " + book.Genre;
        Genre.FontWeight = FontWeights.Bold;
        Children.Add(Title);
        Children.Add(Author);
        Children.Add(Genre);
    }
}