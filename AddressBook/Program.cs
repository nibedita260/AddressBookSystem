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
            while (!isExit)
            {
<<<<<<< HEAD
<<<<<<< HEAD
                AddressBook addressBook = new AddressBook();
                addressBook.CreateContacts();
                Console.WriteLine("Choose 1.CreateContacts 2.DisplayContacts 3.EditContacts 4.DeleteContacts");
=======
                Console.WriteLine("Choose 1.CreateContacts 2.DisplayContacts 3.EditContacts");
>>>>>>> UC3-EditContacts
                options = Convert.ToInt32(Console.ReadLine());
                AddressBook addressBook1 = new AddressBook();
                switch (options)
                {
<<<<<<< HEAD
                    case 1:addressBook1.CreateContacts();
                        break;
                    case 2:addressBook1.DisplayContacts();
                        break;
                    case 3:addressBook1.EditContacts();
                        break;
                    case 4:addressBook1.DeleteContacts();
=======
=======
                Console.WriteLine("Choose 1.CreateContacts 2.DisplayContacts 3.EditContacts 4.DeleteContacts 5.AddMultipleContacts");
                options = Convert.ToInt32(Console.ReadLine());
               
                List<Contacts> GetContacts = new List<Contacts>(); // creating list
                AddressBook addressBook1 = new AddressBook();
                switch (options)
                {
>>>>>>> UC5-AddMultContacts
                    case 1:
                        addressBook1.CreateContacts();
                        break;
                    case 2:
                        addressBook1.DisplayContacts();
                        break;
                    case 3:
                        addressBook1.EditContacts();
<<<<<<< HEAD
>>>>>>> UC3-EditContacts
=======
                        break;
                    case 4:
                        addressBook1.DeleteContacts();
                        break;
                    case 5:
                        addressBook1.AddMultipleContacts(3);
>>>>>>> UC5-AddMultContacts
                        break;
                    default:
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }
        }
    }
}