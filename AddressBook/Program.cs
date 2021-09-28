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
                Console.WriteLine("Choose 1.CreateContacts 2.DisplayContacts 3.EditContacts");
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        addressBook1.CreateContacts();
                        break;
                    case 2:
                        addressBook1.DisplayContacts();
                        break;
                    case 3:
                        addressBook1.EditContacts();
                        break;
                    default:
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }
        }
    }
}