namespace Agenda_Contatos;

public class Agenda
{
    public List<Contact> Contacts = new();

    public void AddContact(Contact contato)
    {
        Contacts.Add(contato);
    }

    public void ShowContacts()
    {
        int index = 1;
        foreach (var item in Contacts)
        {
            Console.WriteLine($"{index}- Name: {item.Name} - Phone: {item.PhoneNumber} - Email: {item.Email}\n");
            index++;
        }
    }

    public void EditContact()
    {
        Console.WriteLine("\nType the name, phone number, or email of the contact that you want to edit:");
        string? searchInput = Console.ReadLine();

        List<Contact> matchingContacts = Contacts.FindAll(contact =>
            contact.Name.Contains(searchInput, StringComparison.OrdinalIgnoreCase) ||
            contact.PhoneNumber.Contains(searchInput, StringComparison.OrdinalIgnoreCase) ||
            contact.Email.Contains(searchInput, StringComparison.OrdinalIgnoreCase));

        if (matchingContacts.Count == 0)
        {
            Console.WriteLine($"\nNo contacts found for '{searchInput}'.");
            return;
        }

        foreach (var contactToEdit in matchingContacts)
        {
            Console.WriteLine($"\nEditing contact: {contactToEdit.Name}");
            Console.WriteLine("\nType the information that you wish to Edit:\n1- Name \n2- Phone Number \n3- Email");
            int info = Convert.ToInt32(Console.ReadLine());

            switch (info)
            {
                case 1:
                    Console.WriteLine("\nType the new Name:");
                    string? newName = Console.ReadLine();
                    contactToEdit.Name = newName;
                    Console.WriteLine($"\nName altered to {newName}");
                    break;

                case 2:
                    Console.WriteLine("\nType the new Phone Number");
                    string? newPhone = Console.ReadLine();
                    contactToEdit.PhoneNumber = newPhone;
                    Console.WriteLine($"\nPhone altered to {newPhone}");
                    break;

                case 3:
                    Console.WriteLine("\nType the new Email:");
                    string? newEmail = Console.ReadLine();
                    contactToEdit.Email = newEmail;
                    Console.WriteLine($"\nEmail altered to {newEmail}");
                    break;

                default:
                    Console.WriteLine("\nInvalid option, please choose a valid one.");
                    return;
            }
        }
    }

    public void DeleteContact()
    { 
        Console.WriteLine("\nSelect the index of the contact you wish to delete:");
        ShowContacts();
        int index = Convert.ToInt32(Console.ReadLine());
            if (index >= 1 && index <= Contacts.Count)
            {
                Contacts.RemoveAt(index - 1);
                Console.WriteLine($"\nContact at index {index} deleted successfully.\n");
            }
            else
            {
                Console.WriteLine("\nInvalid index. Please choose a valid one.\n");
        }
    }
}
