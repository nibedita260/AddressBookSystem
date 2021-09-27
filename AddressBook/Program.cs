using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            int options;
            while (!isExit)
            {
<<<<<<< HEAD
                AddressBook addressBook = new AddressBook();
                addressBook.CreateContacts();
=======
                Console.WriteLine("Choose 1.CreateContacts 2.DisplayContacts 3.EditContacts 4.DeleteContacts");
                options = Convert.ToInt32(Console.ReadLine());
                AddressBook addressBook1 = new AddressBook();
                switch (options)
                {
                    case 1:addressBook1.CreateContacts();
                        break;
                    case 2:addressBook1.DisplayContacts();
                        break;
                    case 3:addressBook1.EditContacts();
                        break;
                    case 4:addressBook1.DeleteContacts();
                        break;
                    default:
                        Console.WriteLine("Choose valid option");
                        break;
                }
>>>>>>> UC4-DeleteContacts
            }
        }
    }
}
