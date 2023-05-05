using System.Collections.Generic;

namespace LibraryApp.Model;

public class Person
{
    public string Name { get; set; }
    public List<Book> LoanedBooks { get; set; }

    public Person(string name)
    {
        Name = name;
        LoanedBooks = new List<Book>();
    }
}