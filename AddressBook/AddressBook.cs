using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    class AddressBook
    {
        readonly List<Contacts> GetContacts = new List<Contacts>();
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
        }
<<<<<<< HEAD
        public void DisplayContacts()
        {
            CreateContacts();
            foreach (var data in GetContacts)
            {
                Console.WriteLine("The Contact Details are\n:" + data.Firstname + " " + data.LastName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
=======
        public void Print(Contacts contacts)
        {
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
        }
        public void DisplayContacts()
        {
            foreach (var data in GetContacts)
            {
                if (GetContacts.Contains(data))
                {
                    Print(data);
                    Console.WriteLine("The Contact Details are\n:" + data.Firstname + " " + data.LastName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
                }
                else
                {
                    Console.WriteLine("contact does not exists");
                }
>>>>>>> UC6-UniqueContacts
            }
        }
        public void EditContacts()
        {
            CreateContacts();
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
            DisplayContacts();
        }
        public void DeleteContacts()
        {
            CreateContacts();
            Console.WriteLine("to delete contact list enter contact firstname ");
            string name = Console.ReadLine().ToLower();
            foreach (var data in GetContacts)
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
            DisplayContacts();
        }
        public void AddMultipleContacts(int n)
        {
            while (n > 0)
            {
<<<<<<< HEAD
                CreateContacts();
                n--;
            }
=======
                Console.WriteLine("enter name to store the above contact details in a dictionary");
                string name = Console.ReadLine().ToLower();
                CreateContacts();
                dict.Add(name, GetContacts);
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
                if (dict.ContainsKey(name))
                {
                    Console.WriteLine("contact details of " +contacts);
                }
                else
                {
                    Console.WriteLine("contact details of " + dict.Keys + "are found");
                }
            }
>>>>>>> UC6-UniqueContacts
        }
    }
}