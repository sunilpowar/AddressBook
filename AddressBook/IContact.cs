namespace AddressBook
{
    internal interface IContact
    {
        void AddContactDetails(string firstName, string lastName, string address, string city, string state, int zipcode, long phoneNumber, string email, string bookName);
    }
}