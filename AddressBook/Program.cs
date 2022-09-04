namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 9 Address Book");
            Console.WriteLine(" 1 To add contact \n 2 To edit contact \n 3 To delete contact");
            Address obj = new Address();
            int sh = Convert.ToInt32(Console.ReadLine());
            switch (sh)
            {
                case 1:
                    Console.WriteLine("Enter the number of contacts to add");
                    int n = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Enter details to create a contact");
                        obj.create();
                    }
                    Console.WriteLine("These contacts are stored");
                    obj.display();
                    break;

                case 2:
                    Console.WriteLine("Enter the first name of the contact to edit the details ");
                    string Firstname = Console.ReadLine();
                    Console.WriteLine("Enter the second name of the contact to edit the details ");
                    string last_name = Console.ReadLine();
                    obj.edit(Firstname, last_name);
                    obj.display();
                    break;

                case 3:
                    Console.WriteLine("Enter the first name of the contact to delete the details ");
                    string Firstname1 = Console.ReadLine();
                    Console.WriteLine("Enter the second name of the contact to delete the details ");
                    string last_name1 = Console.ReadLine();
                    obj.delete(Firstname1,last_name1);
                    break;
            }
        }
    }
}