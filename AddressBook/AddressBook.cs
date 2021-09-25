using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    class AddressBook
    {
        List<Contacts> GetContacts = new List<Contacts>();
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
        }
        public void EditContacts(string name)
        {
            Console.WriteLine("your entered name is:" + name);
            foreach (var data in GetContacts)
            {
                if (GetContacts.Contains(data) == true)
                {
                    Console.WriteLine("The Contact Details are\n:" + data.Firstname + " " + data.LastName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
                    if (data.Firstname == name)
                    {
                        Console.WriteLine("name exists");
                        Console.WriteLine("To edit choose 1.Address 2.City 3.PhoneNumber");
                        int options = Convert.ToInt32(Console.ReadLine());
                        switch (options)
                        {
                            case 1:Console.WriteLine("enter address");
                                string address = Console.ReadLine();
                                data.Address = address;
                                break;
                            case 2:
                                Console.WriteLine("enter city");
                                string city = Console.ReadLine();
                                data.City = city;
                                break;
                            case 3:
                                Console.WriteLine("enter phone number");
                                int phno =Convert.ToInt32(Console.ReadLine());
                                data.PhoneNumber = phno;
                                break;
                            default:
                                Console.WriteLine("choose valid option");
                                break;
                        }
                        Console.WriteLine("The Contact Details are\n:" + data.Firstname + " " + data.LastName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
                    }
                    else
                    {
                        Console.WriteLine("name does not exists");
                    }
                }
            }
        }
        public void DeleteContacts(string name)
        {
            foreach (var data in GetContacts.ToList())
            {
                if (GetContacts.Contains(data) == true)
                {
                    Console.WriteLine("The Contact Details are\n:" + data.Firstname + " " + data.LastName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
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
    }
}
