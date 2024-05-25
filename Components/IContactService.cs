using Blazor_App.Models;

namespace Blazor_App.Components
{
    public interface IContactService
    {
        List<Contact> GetContacts();
        void AddContact(Contact contact);
    }
}