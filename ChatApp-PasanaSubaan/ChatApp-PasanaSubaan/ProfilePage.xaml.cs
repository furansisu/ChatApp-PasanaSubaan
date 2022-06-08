using ChatApp_PasanaSubaan.DependencyServices;
using ChatApp_PasanaSubaan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatApp_PasanaSubaan
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class ProfilePage : ContentPage
{
    public ProfilePage()
    {
        InitializeComponent();
    }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            FirebaseAuthResponseModel res = new FirebaseAuthResponseModel() { };
            res = DependencyService.Get<iFirebaseAuth>().SignOut();

            if (res.Status == true)
            {
                Application.Current.MainPage = new LoginPage();
            }
            else
            {
                await DisplayAlert("Error", res.Response, "Okay");
            }
        }
    }
}