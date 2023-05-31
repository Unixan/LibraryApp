using System;

namespace LibraryApp.Model;

public class UserBookItem
{
    private Book _book;
    public DateOnly LoanedOn { get; private set; }
    public string Title { get; private set; }

    public UserBookItem(Book book)
    {
        _book = book;
        LoanedOn = new DateOnly(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
        Title = book.Title;
    }
}