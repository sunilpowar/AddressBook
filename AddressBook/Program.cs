﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        public static string bookName = "Default";

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program\n");

            AddressBook addressBook = new AddressBook();
            addressBook.AddAddressBook("Default");
            addressBook.AddContactDetails("Sunil", "Powar", "Chikhali", "Kagal", "Maharashtra", 416235, 9970965164, "sunilpowarsp8468@gmail.com");


            while (true)
            {
                try
                {
                    Console.WriteLine("Please choose an option from the below list");
                    Console.WriteLine("\n1. Add New Address Book \n2. Add New Contact \n3. View Contacts \n4. View Contact by Person \n5. Edit Contact \n6. Delete Contact \n7. View all AddressBooks \n8. Switch AddressBook \n9. Search Person By City \n10.Exit\n");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter Unique Address Book Name to create: ");
                            string newBookName = Console.ReadLine();
                            addressBook.AddAddressBook(newBookName);
                            if (addressBook.CheckAddressBook(newBookName) == newBookName)
                            {
                                bookName = newBookName;
                                Console.WriteLine($"Switched to: {bookName}");
                            }
                            break;
                        case 2:
                            addressBook.AddNewContact(bookName);
                            break;
                        case 3:
                            addressBook.ViewContacts(bookName);
                            break;
                        case 4:
                            Console.WriteLine("Enter the First Name to View Contact Details: ");
                            string f_Name = Console.ReadLine();
                            addressBook.ViewContact(f_Name, bookName);
                            break;
                        case 5:
                            Console.WriteLine("Enter the First Name to Edit Contact Details: ");
                            string input = Console.ReadLine();
                            addressBook.EditContact(input, bookName);
                            addressBook.ViewContact(input, bookName);
                            break;
                        case 6:
                            Console.WriteLine("Enter the First Name of Contact: ");
                            string fName = Console.ReadLine();
                            Console.WriteLine("Enter the Last Name to Delete Contact: ");
                            string lName = Console.ReadLine();
                            addressBook.DeleteContact(fName, lName, bookName);
                            break;
                        case 7:
                            addressBook.ViewAddressBooks();
                            break;
                        case 8:
                            Console.WriteLine("Enter the AddressBook Name to Sitch into: ");
                            string adBookName = Console.ReadLine();
                            if (addressBook.CheckAddressBook(adBookName) == adBookName)
                            {
                                bookName = adBookName;
                                Console.WriteLine($"Switched to: {bookName}");
                            }
                            else
                                Console.WriteLine("AddressBook Not Found");
                            break;
                        case 9:
                            Console.WriteLine("Enter the city or state to Search person by city or state across addressbook: ");
                            string userData = Console.ReadLine();
                            addressBook.SearchPersonByCityOrState(userData);
                            break;
                        case 10:
                            Console.WriteLine("View person by city or state across addressbook: ");
                            addressBook.ViewPersonByCityOrState();
                            break;
                        case 11:
                            Console.WriteLine("person count by city or state: ");
                            addressBook.CountPersonByCityOrState();
                            break;
                        case 12:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Please choose the correct option");
                            break;
                    }
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

    }
}
