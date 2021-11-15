using System;

namespace AddressBookADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World in Address Book ADO!");
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            AddressBookModel addrBook = new AddressBookModel();
            Console.WriteLine("1.Connect to Databse And Retrieve the data from sql server");
            Console.WriteLine("2. Insert new Contacts to Address Book");
            Console.WriteLine("3. Edit Existing Contact");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Retrieve Person Based on City or State");
            Console.WriteLine("6. Retrieve Count of address book by City and State");
            Console.WriteLine("7. Retrieve Person by Sorting Alphabetically for a given city. ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    addressBookRepo.RetrieveData();
                    break;
                case 2:
                    Console.WriteLine("Enter First Name: ");
                    addrBook.firstName = Console.ReadLine();
                    Console.WriteLine("Enter Last Name: ");
                    addrBook.lastName = Console.ReadLine();
                    Console.WriteLine("Enter Address : ");
                    addrBook.address = Console.ReadLine();
                    Console.WriteLine("Enter City : ");
                    addrBook.city = Console.ReadLine();
                    Console.WriteLine("Enter State Name: ");
                    addrBook.stateName = Console.ReadLine();
                    Console.WriteLine("Enter ZIP Code : ");
                    addrBook.zipCode =Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Phone number : ");
                    addrBook.phonenum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter EMail ID : ");
                    addrBook.emailId = Console.ReadLine();
                    Console.WriteLine("Enter Address Book Name : ");
                    addrBook.addrBookName = Console.ReadLine();
                    Console.WriteLine("Enter Relation Type : ");
                    addrBook.relationType = Console.ReadLine();
                    addressBookRepo.InsertIntoTable(addrBook);
                    break;
                case 3:
                    addressBookRepo.EditExistingContact(addrBook);
                    break;
                case 4:
                    addressBookRepo.DeleteContact(addrBook);
                    break;
                case 5:
                    addressBookRepo.RetrievePersonBasedOnStateAndCity(addrBook);
                    break;
                case 6:
                    addressBookRepo.RetrieveCountByStateAndCity(addrBook);
                    break;
                case 7:
                    addressBookRepo.RetrievePersonbyOrder(addrBook);
                    break;
            }
        }
    }
}
