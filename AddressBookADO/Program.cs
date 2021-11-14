using System;

namespace AddressBookADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World in Address Book ADO!");
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            addressBookRepo.RetrieveData();
        }
    }
}
