using Blazor_App.Models;
using Microsoft.AspNetCore.Components;
namespace Blazor_App.Components.Pages.ContactsFolder
{
    public partial class Contacts
    {
        private List<Contact> contacts = [];

        [Inject]
        private IContactService ContactService { get; set; } = new ContactService();

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(2000);
            contacts = ContactService.GetContacts();
            //             contacts = new List<Contact>
            // {
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
            // };

            base.OnInitializedAsync();
        }
    }
}