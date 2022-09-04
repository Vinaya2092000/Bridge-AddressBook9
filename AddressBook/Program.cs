namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 9 Address Book");
            Console.WriteLine("1 to add contact \n 2 to edit contact");
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
                    Console.WriteLine("Enter the first name of the contact to edit the details");
                    string Firstname = Console.ReadLine();
                    Console.WriteLine("Enter the second name of the contact to edit the details");
                    string s_name = Console.ReadLine();
                    obj.edit(Firstname, s_name);
                    obj.display();
                    break;
            }
        }
    }
}