using System.Runtime.InteropServices;

string[][] phonebook = new string[3][];

phonebook[0] = new string[] { "1", "Bextiyar", "Semedli", "8788" };
phonebook[1] = new string[] { "2", "Murad", "Memmedli", "4647" };
phonebook[2] = new string[] { "3", "Aslan", "Akbey", "5556" };



Menu:
Console.Clear();
Console.WriteLine("1.Show all contact\n2.Add contact\n3.Edit contact\n4.Delete contact\n5.Search\n6.Quit ");
string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Console.Clear();
        for (int i = 0; i < phonebook.Length; i++)
        {
            Console.WriteLine($"ID: {phonebook[i][0]}");
            Console.WriteLine($"Name: {phonebook[i][1]}");
            Console.WriteLine($"Surname: {phonebook[i][2]}");
            Console.WriteLine($"Phone: {phonebook[i][3]}");
            Console.WriteLine("===============");
            Console.WriteLine();
        }
        Console.ReadKey();
        goto Menu;

        break;
    case "2":
        Console.Clear();
        Console.Write("Enter ID: ");
        string id = Console.ReadLine();

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Surname: ");
        string surname = Console.ReadLine();

        Console.Write("Enter Phone: ");
        string phone = Console.ReadLine();

        int newSize = phonebook.Length + 1;
        Array.Resize(ref phonebook, newSize);

        phonebook[newSize - 1] = new string[] { id, name, surname, phone };

        Console.WriteLine("Contact added successfully!");
        Console.WriteLine("Press any key to return to menu...");
        Console.ReadKey();
        goto Menu;
        break;
    case "3":
        Console.Clear();
        Console.Write("Select ID which you want edit: ");
        string editID = Console.ReadLine();
        int index = -1;

        for (int i = 0; i< phonebook.Length; i++)
        {
            if (phonebook[i][0] == editID)
            {
                index = i; break;
            }
        }
        if (index != -1)
        {
            Console.Clear();
            Console.WriteLine("What do you want to edit\n1.Name\n2.Surname\n3.Phone");
            string editChoice = Console.ReadLine();

            switch (editChoice)
            {
                case "1":
                    Console.Clear();
                    Console.Write("Enter new name: ");
                    phonebook[index][1] = Console.ReadLine();
                    Console.WriteLine("name updated");
                    Console.ReadKey();
                    goto Menu;
                    break;
                case "2":
                    Console.Clear();
                    Console.Write("Enter new Surname: ");
                    phonebook[index][2] = Console.ReadLine();
                    Console.WriteLine("surname updated");
                    Console.ReadKey();
                    goto Menu;
                    break; 
                case "3":
                    Console.Clear();
                    Console.Write("Enter new Phone number: ");
                    phonebook[index][3] = Console.ReadLine();
                    Console.WriteLine("Phone number updated");
                    Console.ReadKey();
                    goto Menu;
                    break; 
                default:
                    break;
            }
        }
        else
        {
            Console.WriteLine("It is not valid ID");
        }
        break;
    case "4":
        Console.Clear();
        Console.Write("select contact ID which you want delete: ");
        string deleteID = Console.ReadLine();
        int deleteIndex = -1;
        for (int i = 0; i < phonebook.Length; i++)

        {
            if (phonebook[i][0] == deleteID)
            {
                deleteIndex = i; break;
            }
        }
        if(deleteIndex != -1)
        {
            for (int i = deleteIndex; i < phonebook.Length-1; i++)
            {
                phonebook[i] = phonebook[i + 1];
            }
        Array.Resize(ref phonebook, phonebook.Length - 1);
        Console.WriteLine("Contact deleted successfully!");
        }
        else
        {
            Console.WriteLine("Not valid ID");
        }
        Console.ReadKey();
        goto Menu;
        break;
    case "5":
        Console.Clear();
        Console.WriteLine("Search by:\n1.name\n2.surname\n3.phone");
        string searchChoice = Console.ReadLine();
        bool phonefound = false;

        switch (searchChoice)
        {
            case "1":
                Console.Clear();
                Console.Write("enter the name: ");
                string nameChoice = Console.ReadLine();
                for (int i = 0; i < phonebook.Length; i++)
                {
                    if (phonebook[i][1].Equals(nameChoice , StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"ID: {phonebook[i][0]}");
                        Console.WriteLine($"Name: {phonebook[i][1]}");
                        Console.WriteLine($"Surname: {phonebook[i][2]}");
                        Console.WriteLine($"Phone: {phonebook[i][3]}");
                        Console.WriteLine();
                        phonefound = true;
                    }
                }
                if (!phonefound)
                {
                    Console.WriteLine("no contact found with that name");
                }
                Console.ReadKey ();
                goto Menu;
                break;


            case "2":
                Console.Clear();
                Console.Write("enter the name: ");
                string surnameChoice = Console.ReadLine();
                for (int i = 0; i < phonebook.Length; i++)
                {
                    if (phonebook[i][1].Equals(surnameChoice, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"ID: {phonebook[i][0]}");
                        Console.WriteLine($"Name: {phonebook[i][1]}");
                        Console.WriteLine($"Surname: {phonebook[i][2]}");
                        Console.WriteLine($"Phone: {phonebook[i][3]}");
                        Console.WriteLine();
                        phonefound = true;
                    }
                }
                if (!phonefound)
                {
                    Console.WriteLine("no contact found with that name");
                }
                Console.ReadKey();
                goto Menu;
                break;

            case "3":
                Console.Clear();
                Console.Write("enter the name: ");
                string phoneChoice = Console.ReadLine();
                for (int i = 0; i < phonebook.Length; i++)
                {
                    if (phonebook[i][1].Equals(phoneChoice, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"ID: {phonebook[i][0]}");
                        Console.WriteLine($"Name: {phonebook[i][1]}");
                        Console.WriteLine($"Surname: {phonebook[i][2]}");
                        Console.WriteLine($"Phone: {phonebook[i][3]}");
                        Console.WriteLine();
                        phonefound = true;
                    }
                }
                if (!phonefound)
                {
                    Console.WriteLine("no contact found with that name");
                }
                Console.ReadKey();
                goto Menu;
                break;
            default:
                break;
        }
        break;
    case "6":
        break; 
    default:
        break;
}
