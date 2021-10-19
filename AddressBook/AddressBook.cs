using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace AddressBook
{
    class AddressBook
    {
        static string Path = @"D:\git\AddressBookSystem\AddressBook\Contacts.txt";
        static string CsvFilePath = @"D:\git\AddressBookSystem\AddressBook\Contacts.csv";
        public List<Contacts> GetContacts = new List<Contacts>();
        public Dictionary<string, List<Contacts>> dict = new Dictionary<string, List<Contacts>>();
        public Dictionary<string, List<Contacts>> dtCities = new Dictionary<string, List<Contacts>>();
        public Dictionary<string, List<Contacts>> dtStates = new Dictionary<string, List<Contacts>>();
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
                    Console.WriteLine("The Contact Details of " + data.Firstname + " are\n:" + data.Firstname + " " + data.LastName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
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
                        return;
                    }
                }
            }
            Console.WriteLine("name does not exists");
        }
        public void DeleteContacts()
        {
            Console.WriteLine("to delete contact list enter contact firstname ");
            string name = Console.ReadLine().ToLower();
            try
            {
                foreach (var data in GetContacts)
                {
                    if (GetContacts.Contains(data))
                    {
                        if (data.Firstname == name)
                        {
                            Console.WriteLine("given name contact exists");
                            GetContacts.Remove(data);
                            Console.WriteLine("contact deleted successfully");
                            return;
                        }
                    }
                }
                Console.WriteLine("given name contact does not exists");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void AddMultipleContacts(int n)
        {
            while (n > 0)
            {
                CreateContacts();
                n--;
            }
        }
        public void AddUniqueContacts()
        {
            Console.WriteLine("enter firstname of your contactdetails");
            string name = Console.ReadLine().ToLower();
            foreach (var data in GetContacts)
            {
                if (GetContacts.Contains(data))
                {
                    if (data.Firstname == name)
                    {
                        Console.WriteLine("enter unique name to store the above contact details in a dictionary");
                        string uniqueName = Console.ReadLine().ToLower();
                        if (dict.ContainsKey(uniqueName))
                        {
                            Console.WriteLine("Oops!! Person name already Exists");
                            return;
                        }
                        dict.Add(uniqueName, GetContacts);
                        return;
                    }
                }
            }
            Console.WriteLine("Oops contactlist does not exist!! Please create a contactList");
            return;
        }
        public void DisplayUniqueContacts()
        {
            //maintain dictionary of addressbook name to addressbook
            if (dict.Count >= 1)
            {
                Console.WriteLine("enter name of dictionary to display that contact details");
                string name = Console.ReadLine().ToLower();
                foreach (var item in dict.Keys)
                {
                    Console.WriteLine($"Enter name to Select AddressBook : {item}");
                }
                foreach (var contacts in dict)
                {
                    if (contacts.Key.Contains(name))
                    {
                        foreach (var data in contacts.Value)
                        {
                            Console.WriteLine("The Contact of " + data.Firstname + " Details are\n:" + data.Firstname + " " + data.LastName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
                        }
                    }
                    return;
                }
                Console.WriteLine("Oops UniqueContacts does not exist!! Please create a UniquecontactList");
                return;
            }
        }
        //search Result can show multiple person name in the city or state
        public void SearchMultiplePersonNamesInCityOrState(string city)
        {
            foreach (KeyValuePair<string, List<Contacts>> item in dict)
            {
                Console.WriteLine("Name of AddressBook: " + item.Key);
                foreach (Contacts items in item.Value)
                {
                    if (items.City.Contains(city))
                    {
                        Console.WriteLine($"Name: {items.Firstname + " " + items.LastName}, Phone Number: {items.PhoneNumber}, City: {items.City}");
                        Console.WriteLine();
                    }
                }
            }
        }
        //an utility to add contacts to city and state dictionary
        public void UtilityToAddContactToCityState()
        {
            List<Contacts> stateList = new List<Contacts>();
            // adding list to cities dictionary
            try
            {
                var data = GetContacts.GroupBy(x => x.City);
                foreach (var cities in data)
                {
                    List<Contacts> cityList = new List<Contacts>();
                    foreach(var city in cities)
                    {
                        cityList.Add(city);
                    }
                    dtCities.Add(cities.Key, cityList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// view Contacts by Cities
        /// </summary>
        public void DisplayContactsByCities()
        {
            if (dtCities.Count == 0)
                Console.WriteLine("No AddressBook(s) to Show.");
            if (dtCities.Count >= 1)
            {
                foreach (KeyValuePair<string, List<Contacts>> addressBooks in dtCities)
                {
                    Console.WriteLine("Contacts From City: " + addressBooks.Key);
                    foreach (Contacts items in addressBooks.Value)
                    {
                        Console.WriteLine($"Name: {items.Firstname + " " + items.LastName}, Phone Number: {items.PhoneNumber}, City: {items.City}, State: {items.State}" +
                            $"\n Address: {items.Address}, Zipcode: {items.Zip}, Email: {items.Email}");
                        Console.WriteLine();
                    }
                }
            }
        }
        public void CountContactsByCities(string city)
        {
            int count = 0;
            foreach (KeyValuePair<string, List<Contacts>> item in dict)
            {
                Console.WriteLine("Name of AddressBook: " + item.Key);
                foreach (Contacts items in item.Value)
                {
                    if (items.City.Contains(city))
                    {
                        count++;
                        Console.WriteLine($"Name: {items.Firstname + " " + items.LastName}, Phone Number: {items.PhoneNumber}, City: {items.City}");
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("count of Contacts using City-"+ city +" is: " + count);
        }
        public void SortContactsByName()
        {
            foreach (var data in GetContacts.OrderBy(x => x.Firstname).ToList())
            {
                if (GetContacts.Contains(data))
                {
                    Console.WriteLine("The Contact Details of " + data.Firstname + " are\n:" + data.Firstname + " " + data.LastName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
                }
                else
                {
                    Console.WriteLine("contact does not exists");
                }
            }
        }
        public void SortContactsByCity()
        {
            foreach (var data in GetContacts.OrderBy(x => x.City).ToList())
            {
                if (GetContacts.Contains(data))
                {
                    Console.WriteLine("The Contact Details of " + data.Firstname + " are\n:" + data.Firstname + " " + data.LastName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
                }
                else
                {
                    Console.WriteLine("contact does not exists");
                }
            }
        }
        public void SortContactsByState()
        {
            foreach (var data in GetContacts.OrderBy(x => x.State).ToList())
            {
                if (GetContacts.Contains(data))
                {
                    Console.WriteLine("The Contact Details of " + data.Firstname + " are\n:" + data.Firstname + " " + data.LastName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
                }
                else
                {
                    Console.WriteLine("contact does not exists");
                }
            }
        }
        public void SortContactsByZip()
        {
            foreach (var data in GetContacts.OrderBy(x => x.Zip).ToList())
            {
                if (GetContacts.Contains(data))
                {
                    Console.WriteLine("The Contact Details of " + data.Firstname + " are\n:" + data.Firstname + " " + data.LastName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
                }
                else
                {
                    Console.WriteLine("contact does not exists");
                }
            }
        }
        public void SaveContactsToTxt()
        {
            using TextWriter tw = new StreamWriter(Path);
            foreach (var contacts in GetContacts)
            {
                tw.WriteLine(contacts.Firstname.ToString() + " " + contacts.LastName.ToString() + " " + contacts.Address.ToString() + " " + contacts.City.ToString() + " " + contacts.State.ToString() + " " + contacts.PhoneNumber.ToString() + " " + contacts.Zip.ToString() + " " + contacts.Email.ToString());
            }
        }
        public void SaveContactsToCSV()
        {
            using TextWriter tw = new StreamWriter(CsvFilePath);
            using (var csvExport = new CsvWriter(tw, CultureInfo.InvariantCulture))
            {
                csvExport.WriteRecords(GetContacts);
            }
        }
    }
}