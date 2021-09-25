using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    class AddressBook
    {
        readonly List<Contacts> GetContacts = new List<Contacts>();
        Dictionary<string, List<Contacts>> dict = new Dictionary<string, List<Contacts>>();
        public void CreateContacts()
        {
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter Firstname");
            contacts.Firstname = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter Lastname");
            contacts.LastName = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter Address");
            contacts.Address = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter City");
            contacts.City = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter State");
            contacts.State = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter Zipcode");
            contacts.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phonenumber");
            contacts.PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email");
            contacts.Email = Console.ReadLine().ToUpper();
            GetContacts.Add(contacts);
            Console.WriteLine("contacts details added successfully");
            //creating multiple contacts
            Contacts contacts2 = new Contacts();
            Console.WriteLine("Enter Firstname");
            contacts2.Firstname = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter Lastname");
            contacts2.LastName = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter Address");
            contacts2.Address = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter City");
            contacts2.City = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter State");
            contacts2.State = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter Zipcode");
            contacts2.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phonenumber");
            contacts2.PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email");
            contacts2.Email = Console.ReadLine().ToUpper();
            GetContacts.Add(contacts2);
            Console.WriteLine("contacts2 details added successfully");

            //maintain dictionary of addressbook name to addressbook
            dict.Add("Nibedita", GetContacts);
            dict.Add("Abhinav", GetContacts);
        }
    }
}
