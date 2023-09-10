using System.Text.RegularExpressions;

namespace Agenda_Contatos;

public class ContactManager 
{
    public Contact CreateContact()
    {
        Contact contact = new();
        Console.WriteLine("Type the name of your Contact:");
        contact.Name = Console.ReadLine();
        
        Console.WriteLine("Type the phone number of your Contact:");
        contact.PhoneNumber = Console.ReadLine();
        
        Console.WriteLine("Type the email of your Contact:");
        contact.Email = Console.ReadLine();
        
        string pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
        Regex regex = new(pattern);
        bool validateEmail = regex.IsMatch(contact.Email);
        
        while (validateEmail == false)
        {
            Console.WriteLine("Invalid Email, try again.");
            contact.Email = Console.ReadLine();
            validateEmail = regex.IsMatch(contact.Email);
        }
        return contact;
        
    }
    

}