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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void SignIn(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(pass.Text))
            {
                DisplayAlert("Error", "Missing fields", "Okay");

                if (string.IsNullOrEmpty(email.Text))
                {
                    emailbox.BorderColor = Color.Red;
                }
                if (string.IsNullOrEmpty(pass.Text))
                {
                    passbox.BorderColor = Color.Red;
                }
            }
            else
            {
                Application.Current.MainPage = new TabbedPage1();
            }
        }

        private void SignUp(object sender, EventArgs e)
        {
            Application.Current.MainPage = new RegisterPage();
        }

        private void ForgotPass(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgotPassPage());
        }

        private void ShowPass(object sender, EventArgs e)
        {
            pass.IsPassword = false;
            show.IsVisible = false;
            hide.IsVisible = true;
        }

        private void HidePass(object sender, EventArgs e)
        {
            pass.IsPassword = true;
            show.IsVisible = true;
            hide.IsVisible = false;
        }

        private void email_Focused(object sender, FocusEventArgs e)
        {
            emailbox.BorderColor = Color.Black;
        }

        private void pass_Focused(object sender, FocusEventArgs e)
        {
            passbox.BorderColor = Color.Black;
        }
    }
}
