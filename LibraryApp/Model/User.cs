using System.Collections.Generic;
using System.Windows.Documents;

namespace LibraryApp.Model;

public class User
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Address { get; private set; }
    public int Id { get; private set; }

    public bool HasLoanCard => LoanCard != null;

    public LoanCard? LoanCard { get; private set; }
    public List<Book> LoanedBooks { get; private set; }

    public User(int id, string firstName, string lastName, string address)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        LoanedBooks = new List<Book>();
    }

    public string GetFullName()
    {
        return $"{LastName}, {FirstName}";
    }

    public void IssueLoanCard()
    {
        LoanCard = new LoanCard();
    }

    public void RevokeLoanCard()
    {
        LoanCard = null;
    }

    public string GetLoanCardStatus()
    {
        return HasLoanCard ? "Gyldig til: " + LoanCard.DateIssued : "Ingen";
    }
}