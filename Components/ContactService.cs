using Blazor_App.Models;

namespace Blazor_App.Components
{
    public class ContactService
    {
        public List<Contact> ContactList = new List<Contact>();

        public void AddContact(Contact contact)
        {
            ContactList.Add(contact);
        }
    }
}