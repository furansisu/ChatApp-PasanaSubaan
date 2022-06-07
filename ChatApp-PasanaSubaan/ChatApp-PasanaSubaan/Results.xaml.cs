using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatApp_PasanaSubaan.Models;
using Newtonsoft.Json;
using Plugin.CloudFirestore;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatApp_PasanaSubaan
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Results : ContentPage
    {
        List<UserModel> result = new List<UserModel>();
        public Results(string param)
        {
            InitializeComponent();
            LoadResults(param);
        }

        private async void BackEvent(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void ItemTapped(object sender, EventArgs e)
        {

        }

        private async void LoadResults(string param)
        {
            var documents = await CrossCloudFirestore.Current
                .Instance
                .Collection("users")
                .WhereEqualsTo("email", param)
                .GetAsync();
            foreach (var documentChange in documents.DocumentChanges)
            {
                var json = JsonConvert.SerializeObject(documentChange.Document.Data);
                var obj = JsonConvert.DeserializeObject<UserModel>(json);

                result.Add(obj);
            }
            resultList.ItemsSource = result;

            if (result.Count == 0)
            {
                await DisplayAlert("", "User not found.", "Okay");
                await Navigation.PopModalAsync(true);
            }
        }
    }
}