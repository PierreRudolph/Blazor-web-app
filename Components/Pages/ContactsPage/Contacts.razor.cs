using Blazor_App.Components.Pages.ContactComponents;
using Blazor_App.Models;
using Microsoft.AspNetCore.Components;
namespace Blazor_App.Components.Pages.ContactsPage
{
    public partial class Contacts
    {
        private List<Contact> contacts = [];
        private bool IsContactDisplayed = true;
        private ContactList contactList;//das ist eine refernz auf die datei/klasse ContactList
        [Inject]
        private IContactService ContactService { get; set; } = new ContactService();

        [Inject]
        NavigationManager navigationManager { get; set; }
        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(1000);
            //contacts = ContactService.GetContacts();
            contacts =
[
new Contact
            {
            FirstName="Peter",
            LastName="Wohlleben",
            Email="wohlleben@mail.de"
            },
            new Contact
            {
            FirstName="Julia",
            LastName="Stockerson",
            Email="stockerson@mail.de"
            },
            new Contact
            {
            FirstName="Markus",
            LastName="Kafka",
            Email="kafka@mail.de"
            }
];

            base.OnInitializedAsync();
        }

        private void HideContacts()
        {
            IsContactDisplayed = !IsContactDisplayed;
            if (!IsContactDisplayed)
            {
                contactList.HideContacts();
            }
            else
            {
                contactList.ShowContacts();
            }
        }

        private void NavigateToTest()
        {
            navigationManager.NavigateTo("./testPage");
        }
    }
}