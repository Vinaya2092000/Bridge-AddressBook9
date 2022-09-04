namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 9 Address Book");
            Console.WriteLine("Enter to create a contact");
            Address obj = new Address();
            obj.create();
            obj.display();
        }
    }
}