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

        private void Send(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email.Text))
            {
                DisplayAlert("Error", "Missing field", "Okay");
                emailbox.BorderColor = Color.Red;
            }
            else
            {
                DisplayAlert("Success", "Email has been sent to your email address.", "Okay");
                Application.Current.MainPage = new LoginPage();
            }
        }

        private void email_Focused(object sender, FocusEventArgs e)
        {
            emailbox.BorderColor = Color.Black;
        }
    }
}
