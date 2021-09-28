using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    class AddressBook
    {
        public List<Contacts> GetContacts = new List<Contacts>();
        Dictionary<string, List<Contacts>> dict = new Dictionary<string, List<Contacts>>();
        public void CreateContacts()
        {
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter Firstname");
            contacts.Firstname = Console.ReadLine().ToLower();
            Console.WriteLine("Enter Lastname");
            contacts.LastName = Console.ReadLine().ToLower();
            Console.WriteLine("Enter Address");
            contacts.Address = Console.ReadLine().ToLower();
            Console.WriteLine("Enter City");
            contacts.City = Console.ReadLine().ToLower();
            Console.WriteLine("Enter State");
            contacts.State = Console.ReadLine().ToLower();
            Console.WriteLine("Enter Zipcode");
            contacts.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phonenumber");
            contacts.PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email");
            contacts.Email = Console.ReadLine().ToLower();
            GetContacts.Add(contacts);
            Console.WriteLine("contacts details added successfully");
        }
        public void DisplayContacts()
        {
            foreach (var data in GetContacts)
            {
                if (GetContacts.Contains(data))
                {
                    Console.WriteLine("The Contact Details are\n:" + data.Firstname + " " + data.LastName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
                }
                else
                {
                    Console.WriteLine("contact does not exists");
                }
            }
        }
        public void EditContacts()
        {
            Console.WriteLine("to edit contact list enter contact firstname");
            string name = Console.ReadLine().ToLower();
            foreach (var data in GetContacts)
            {
                if (GetContacts.Contains(data))
                {
                    if (data.Firstname == name)
                    {
                        Console.WriteLine("name exists");
                        Console.WriteLine("To edit contacts enter 1.LastName 2.Address 3.City 4.State 5.Zip 6.PhoneNumber 7.Email");
                        int options = Convert.ToInt32(Console.ReadLine());
                        switch (options)
                        {
                            case 1:
                                string lastname = Console.ReadLine();
                                break;
                            case 2:
                                string address = Console.ReadLine();
                                data.Address = address;
                                break;
                            case 3:
                                string city = Console.ReadLine();
                                data.City = city;
                                break;
                            case 4:
                                string state = Console.ReadLine();
                                data.State = state;
                                break;
                            case 5:
                                int zip = Convert.ToInt32(Console.ReadLine());
                                data.Zip = zip;
                                break;
                            case 6:
                                int phno = Convert.ToInt32(Console.ReadLine());
                                data.PhoneNumber = phno;
                                break;
                            case 7:
                                string email = Console.ReadLine();
                                data.Email = email;
                                break;
                            default:
                                Console.WriteLine("choose valid option");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("name does not exists");
                    }
                }
            }
        }
        public void DeleteContacts()
        {
            Console.WriteLine("to delete contact list enter contact firstname ");
            string name = Console.ReadLine().ToLower();
            foreach (var data in GetContacts.ToList())
            {
                if (GetContacts.Contains(data))
                {
                    if (data.Firstname == name)
                    {
                        try
                        {
                            Console.WriteLine("given name contact exists");
                            GetContacts.Remove(data);
                            Console.WriteLine("contact deleted successfully");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    else
                    {
                        Console.WriteLine("given name contact does not exists");
                    }
                }
            }
        }
        public void AddMultipleContacts(int n)
        {
            while (n > 0)
            {
                foreach (var data in GetContacts)
                {
                    Console.WriteLine("enter firstname of your contactdetails");
                    string name = Console.ReadLine().ToLower();
                    if (GetContacts.Contains(data))
                    {
                        if (data.Firstname == name)
                        {
                            Console.WriteLine("enter unique name to store the above contact details in a dictionary");
                            string uniqueName = Console.ReadLine().ToLower();
                            dict.Add(uniqueName, GetContacts);
                        }
                        else
                        {
                            Console.WriteLine("Oops!! Please enter correct firstname of your contactList");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Oops contactlist does not exist!! Please create a contactList");
                    }
                }
                n--;
            }
        }
        public void DisplayMultContacts()
        {
            //maintain dictionary of addressbook name to addressbook
            Console.WriteLine("enter name of dictionary to display that contact details");
            string name = Console.ReadLine().ToLower();
            foreach (var contacts in dict)
            {
                if (contacts.Key.Contains(name))
                {
                    foreach(var data in contacts.Value)
                    {
                        Console.WriteLine("The Contact Details are\n:" + data.Firstname + " " + data.LastName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
                    }
                }
            }
        }
    }
}
