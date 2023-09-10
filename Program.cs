using Agenda_Contatos;


Console.WriteLine("## Contact Agenda ##\n");

int menuSelection;
Agenda agenda = new();
ContactManager contactManager = new();

// default contacts
Contact contact1 = new("Augusto Medeiros","augusto@email.com", "(48) 9911-80283");
Contact contact2 = new("Lucas Tinoco","lucas@email.com", "(48) 8440-35981");
Contact contact3 = new("Marco Mama","marcomama@email.com", "(48) 6969-42024");

agenda.AddContact(contact1);
agenda.AddContact(contact2);
agenda.AddContact(contact3);

do
{
    Console.WriteLine("1- Add Contact\n2- Show Agenda\n3- Edit Contact\n4- Delete Contact\n5- Exit Agenda");

    menuSelection = Convert.ToInt32(Console.ReadLine());

    if (menuSelection == 5)
    {
        break;
    }

    switch (menuSelection)
    {
        case 1:
            var newContact = contactManager.CreateContact();
            agenda.AddContact(newContact);
            Console.WriteLine($"Contact {newContact.Name} added to the agenda");
            break;
        
        case 2:
            agenda.ShowContacts();
            break;
        
        case 3:
            agenda.EditContact();
            break;
        
        case 4:
            agenda.DeleteContact();
            break;

        default:
            Console.WriteLine("Invalid option. Please choose a valid one.");
            break;
    }
} while (true);



