using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace LibraryApp.Model;

public class User
{
    public string FirstName { get;  set; }
    public string LastName { get;  set; }
    public string Address { get;  set; }
    public Guid Id { get; private set; }
    public string FullName => $"{LastName}, {FirstName}";
    public bool HasLoanCard => LoanCard != null;

    public string LoanCardStatus => HasLoanCard ? "Gyldig til: " + LoanCard.DateIssued : "Ingen";

    public LoanCard? LoanCard { get; private set; }
    public ObservableCollection<Book> LoanedBooks { get; private set; }

    public User(string firstName, string lastName, string address)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        LoanedBooks = new ObservableCollection<Book>();
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