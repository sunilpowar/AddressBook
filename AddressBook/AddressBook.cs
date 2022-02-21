﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook
    {
        List<Contact> contactList;
        public AddressBook()
        {
            contactList = new List<Contact>();
        }

        // UC1 - Create Contacts in address book
        public void AddContactDetails(string firstName, string lastName, string address, string city, string state, int zipcode, long phoneNumber, string email)
        {
            Contact personDetails = new Contact(firstName, lastName, address, city, state, zipcode, phoneNumber, email);
            contactList.Add(personDetails);
        }

        //UC2 - Add New Contact Details
        public void AddNewContact()
        {
            Console.WriteLine("Enter your First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your City: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter your State: ");
            string state = Console.ReadLine();
            Console.WriteLine("Enter your Zipcode: ");
            int zipcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number: ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your EmailID: ");
            string email = Console.ReadLine();

            AddContactDetails(firstName, lastName, address, city, state, zipcode, phoneNumber, email);
            ViewContact();
        }

        // View Contact Details of a person
        public void ViewContact()
        {
            int count = 1;
            foreach (var contact in contactList)
            {
                Console.WriteLine("Person {0} Details: ", count);
                Console.WriteLine("First Name: " + contact.firstName);
                Console.WriteLine("Last Name: " + contact.lastName);
                Console.WriteLine("Address: " + contact.address);
                Console.WriteLine("City: " + contact.city);
                Console.WriteLine("State: " + contact.state);
                Console.WriteLine("ZipCode: " + contact.zipcode);
                Console.WriteLine("Phone Number: " + contact.phoneNumber);
                Console.WriteLine("Email ID: " + contact.email);
                count++;
            }
        }

        // UC3 - Edit Contact Details
        public void EditContact(string input)
        {
            for (int i = 0; i < contactList.Count; i++)
            {
                if (contactList[i].firstName == input)
                {
                    Console.WriteLine("\n Choose What you want to edit " +
                        "\n 1. First Name \n 2 Last Name \n 3. Address \n 4. City \n 5. State \n 6. ZipCode \n 7. Phone Number \n 8. Email-ID");
                    int edit = Convert.ToInt32(Console.ReadLine());
                    switch (edit)
                    {
                        case 1:
                            Console.WriteLine("Enter New First Name: ");
                            contactList[i].firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter New Last Name: ");
                            contactList[i].lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter New Address: ");
                            contactList[i].address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter New City: ");
                            contactList[i].city = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter New State: ");
                            contactList[i].state = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter New ZipCode: ");
                            contactList[i].zipcode = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Enter New Phone Number: ");
                            contactList[i].phoneNumber = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter New Email-ID: ");
                            contactList[i].email = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
            }
        }

        // UC4 - Delete Contact of a person
        public void DeleteContact(string fName, string lName)
        {
            for (int i = 0; i < contactList.Count; i++)
            {
                if (contactList[i].firstName == fName && contactList[i].lastName == lName)
                {
                    Console.WriteLine("Contact {0} {1} Deleted Successfully from Address Book.", contactList[i].firstName, contactList[i].lastName);
                    contactList.RemoveAt(i);
                }
            }
        }
        public void AddAddressBook(string newAddressBook)
        {
            if (addressBookDict.ContainsKey(newAddressBook))
            {
                Console.WriteLine("Address Book Name Already Exists");
            }
            else
            {
                AddressBook addressBook = new AddressBook();
                addressBookDict.Add(newAddressBook, addressBook);
                Console.WriteLine("AddressBook {0} Created Successfully.", newAddressBook);
            }
        }


        public void ViewAddressBooks()
        {
            foreach (var book in addressBookDict)
            {
                Console.WriteLine(book.Key);
            }

        }

        public string CheckAddressBook(string adBookName)
        {
            foreach (var book in addressBookDict)
            {
                if (book.Key == adBookName)
                {
                    return adBookName;
                }
            }
            return null;

        }
        public string CheckAddressBook(string adBookName)
        {
            foreach (var book in addressBookDict)
            {
                if (book.Key == adBookName)
                {
                    return adBookName;
                }
            }
            return null;

        }
        public string CheckAddressBook(string adBookName)
        {
            foreach (var book in addressBookDict)
            {
                if (book.Key == adBookName)
                {
                    return adBookName;
                }
            }
            return null;

        }
        public void SearchPersonByCityOrState(string userData)
        {
            foreach (var book in addressBookDict)
            {
                var searchResut = book.Value.contactList.FindAll(x => x.city == userData || x.state == userData);
                if (searchResut.Count != 0)
                {
                    foreach (var item in searchResut)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                else
                    Console.WriteLine("No person found for this city or state");
            }
        }
    }
}
    

