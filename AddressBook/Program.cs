using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            while (!isExit)
            {
                AddressBook addressBook = new AddressBook();
                addressBook.CreateContacts();
                //addressBook.EditContacts("NIBI");
                addressBook.DeleteContacts("NIBI");
            }
        }
    }
}
