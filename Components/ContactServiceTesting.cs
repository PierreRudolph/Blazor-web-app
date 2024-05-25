using Blazor_App.Models;

namespace Blazor_App.Components
{
    public class ContactServiceTesting : IContactService
    {
        public List<Contact> ContactList = [];
        public void AddContact(Contact contact)
        {

        }

        public List<Contact> GetContacts()
        {
            return new List<Contact>
           {
            new Contact
            {
                FirstName="Hans",
                LastName="Stockerson",
                Email="stockerson@mail.de"
            }
           };
        }
    }
}