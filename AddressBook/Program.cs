using System;
using System.Collections.Generic;

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
<<<<<<< HEAD
                Console.WriteLine("Choose 1.CreateContacts 2.DisplayContacts 3.EditContacts 4.DeleteContacts 5.AddMultipleContacts");
                options = Convert.ToInt32(Console.ReadLine());

                List<Contacts> GetContacts = new List<Contacts>(); // creating list
=======
                Console.WriteLine("Choose 1.CreateContacts 2.DisplayContacts 3.EditContacts 4.DeleteContacts 5.AddMultipleContacts 6.UniqueContacts");
                options = Convert.ToInt32(Console.ReadLine());
<<<<<<< HEAD
>>>>>>> UC6-UniqueContacts
                AddressBook addressBook1 = new AddressBook();
=======
>>>>>>> UC6-UniqueContacts
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
                    case 4:
                        addressBook1.DeleteContacts();
                        break;
                    case 5:
<<<<<<< HEAD
                        addressBook1.AddMultipleContacts(3);
=======
                        addressBook1.AddMultipleContacts(2);
                        break;
                    case 6:
                        addressBook1.DisplayMultContacts();
>>>>>>> UC6-UniqueContacts
                        break;
                    default:
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }
        }
    }
}