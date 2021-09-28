using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            int options;
            AddressBook addressBook1 = new AddressBook();
            while (!isExit)
            {
                Console.WriteLine("Choose 1.CreateContacts ");
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        addressBook1.CreateContacts();
                        break;
                    default:
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }
        }
    }
}