using Blazor_App.Models;

namespace Blazor_App.Components
{
    public class ContactService : IContactService
    {
        public List<Contact> ContactList = [];

        public List<Contact> GetContacts()
        {
            return ContactList;
        }

        public void AddContact(Contact contact)
        {
            ContactList.Add(contact);
        }
    }
}