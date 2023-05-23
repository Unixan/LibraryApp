using System.Collections.Generic;
using System.Windows.Documents;

namespace LibraryApp.Model;

public class User
{
    private string _firstName;
    private string _lastName;
    private string _address;
    private List<Book> _loanedBooks;

    public User(string firstName, string lastName, string address)
    {
        _firstName = firstName;
        _lastName = lastName;
        _address = address;
        _loanedBooks = new List<Book>();
    }
}