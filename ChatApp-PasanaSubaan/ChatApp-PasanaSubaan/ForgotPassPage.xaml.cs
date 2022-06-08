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
    public partial class ForgotPassPage : ContentPage
    {
        public ForgotPassPage()
        {
            InitializeComponent();
        }

        private async void Send(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email.Text))
            {
                await DisplayAlert("Error", "Missing field", "Okay");
                emailbox.BorderColor = Color.Red;
            }
            else
            {
                FirebaseAuthResponseModel res = new FirebaseAuthResponseModel() { };
                res = await DependencyService.Get<iFirebaseAuth>().ResetPassword(email.Text);

                if (res.Status == true)
                {
                    await DisplayAlert("Success", "Email has been sent to your email address.", "Okay");
                    Application.Current.MainPage = new LoginPage();
                }
                else
                {
                    await DisplayAlert("Error", res.Response, "Okay");
                }
            }
        }

        private void email_Focused(object sender, FocusEventArgs e)
        {
            emailbox.BorderColor = Color.Black;
        }
    }
}
