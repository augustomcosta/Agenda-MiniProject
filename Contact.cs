using System.Text.RegularExpressions;

namespace Agenda_Contatos;

public class Contact
{   
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }

    public Contact(){}

    public Contact(string name, string email, string phoneNumber)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }

}