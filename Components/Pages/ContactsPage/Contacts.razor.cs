using Blazor_App.Components.Pages.ContactComponents;
using Blazor_App.Models;
using Microsoft.AspNetCore.Components;
namespace Blazor_App.Components.Pages.ContactsPage
{
    public partial class Contacts
    {
        private List<Contact> contacts = [];
        private ContactList contactList;
        [Inject]
        private IContactService ContactService { get; set; } = new ContactService();

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(2000);
            contacts = ContactService.GetContacts();
            //             contacts =
            // [
            // new Contact
            // {
            // FirstName="Peter",
            // LastName="Wohlleben",
            // Email="wohlleben@mail.de"
            // },
            // new Contact
            // {
            // FirstName="Julia",
            // LastName="Stockerson",
            // Email="stockerson@mail.de"
            // },
            // new Contact
            // {
            // FirstName="Markus",
            // LastName="Kafka",
            // Email="kafka@mail.de"
            // }
            // ];

            base.OnInitializedAsync();
        }


    }
}