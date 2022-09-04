namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 9 Address Book");
            Console.WriteLine("Enter the number of contacts to add");
            int n = Convert.ToInt32(Console.ReadLine());
            Address obj = new Address();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter details to create a contact");
                obj.create();
            }
            Console.WriteLine("These contacts are stored");
            obj.display();
        }
    }
}