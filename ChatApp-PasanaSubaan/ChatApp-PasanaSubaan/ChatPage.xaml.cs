using ChatApp_PasanaSubaan.Models;
using Newtonsoft.Json;
using Plugin.CloudFirestore;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatApp_PasanaSubaan
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatPage : ContentPage
    {
        DataClass dataClass = DataClass.GetInstance;
        List<ContactModel> contactList = new List<ContactModel>();
        List<UserModel> result = new List<UserModel>();
        public ChatPage()
        {
            InitializeComponent();
            GetList();
        }

        private async void Search(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Results(searchBar.Text));
        }

        private void GetList()
        {
            CrossCloudFirestore.Current
                .Instance
                .Collection("contacts")
                .WhereArrayContains("contactID", dataClass.loggedInUser.uid)
                .AddSnapshotListener((snapshot, error) =>
                {
                    loading.IsVisible = true;
                    if (snapshot != null)
                    {
                        foreach (var documentChange in snapshot.DocumentChanges)
                        {
                            var json = JsonConvert.SerializeObject(documentChange.Document.Data);
                            var obj = JsonConvert.DeserializeObject<ContactModel>(json);
                            switch (documentChange.Type)
                            {
                                case DocumentChangeType.Added:
                                    contactList.Add(obj);
                                    break;
                                case DocumentChangeType.Modified:
                                    if (contactList.Where(c => c.id == obj.id).Any())
                                    {
                                        var item = contactList.Where(c => c.id == obj.id).FirstOrDefault();
                                        item = obj;
                                    }
                                    break;
                                case DocumentChangeType.Removed:
                                    if (contactList.Where(c => c.id == obj.id).Any())
                                    {
                                        var item = contactList.Where(c => c.id == obj.id).FirstOrDefault();
                                        contactList.Remove(item);
                                    }
                                    break;
                            }
                        }
                    }
                    emptyListLabel.IsVisible = contactList.Count == 0;
                    contactsList.IsVisible = !(contactList.Count == 0);
                    loading.IsVisible = false;
                });
        }

        private async void ContactsList_ItemTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConversationPage());
        }
    }
}