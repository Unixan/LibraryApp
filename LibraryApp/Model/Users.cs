using System.Collections.Generic;

namespace LibraryApp.Model;

public class Users
{
    public List<User> UsersList { get; set; }

    public Users()
    {
        UsersList = new List<User>();
    }
}