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
                Console.WriteLine("Choose 1.CreateContacts 2.DisplayContacts 3.EditContacts 4.DeleteContacts 5.AddMultipleContacts 6.AddUniqueContacts 7.DisplayUniqueContacts 8.SearchMultiplePersonNamesInCityOrState 9.DisplayContactsByCities 10.CountContactsByCities 11.SortContactsByName 12.SortContactsByCityStateZip 13.ReadOrWriteContactsIntoTxtFile 14.ReadOrWriteContactsIntoCSVFile");
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
                    case 4:
                        addressBook1.DeleteContacts();
                        break;
                    case 5:
                        addressBook1.AddMultipleContacts(2);
                        break;
                    case 6:
                        addressBook1.AddUniqueContacts();
                        break;
                    case 7:
                        addressBook1.DisplayUniqueContacts();
                        break;
                    case 8:
                        Console.WriteLine("enter city to search multiple persons");
                        string city = Console.ReadLine();
                        addressBook1.SearchMultiplePersonNamesInCityOrState(city);
                        break;
                    case 9:
                        addressBook1.UtilityToAddContactToCityState();
                        addressBook1.DisplayContactsByCities();
                        break;
                    case 10:
                        Console.WriteLine("enter city to search multiple persons");
                        string cities = Console.ReadLine(); 
                        addressBook1.CountContactsByCities(cities);
                        break;
                    case 11:
                        addressBook1.SortContactsByName();
                        break;
                    case 12:
                        addressBook1.SortContactsByCity();
                        addressBook1.SortContactsByState();
                        addressBook1.SortContactsByZip();
                        break;
                    case 13:
                        addressBook1.SaveContactsToTxt();
                        break;
                    case 14:
                        addressBook1.SaveContactsToCSV();
                        break;
                    default:
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }
        }
    }
}