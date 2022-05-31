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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Register(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(pass.Text) || string.IsNullOrEmpty(cpass.Text))
            {
                DisplayAlert("Error", "Missing fields", "Okay");

                if (string.IsNullOrEmpty(username.Text))
                {
                    userbox.BorderColor = Color.Red;
                }
                if (string.IsNullOrEmpty(email.Text))
                {
                    emailbox.BorderColor = Color.Red;
                }
                if (string.IsNullOrEmpty(pass.Text))
                {
                    passbox.BorderColor = Color.Red;
                }
                if (string.IsNullOrEmpty(cpass.Text))
                {
                    cpassbox.BorderColor = Color.Red;
                }
            }
            else if (pass.Text != cpass.Text)
            {
                DisplayAlert("Error", "Passwords don't match.", "Okay");
            }
            else
            {
                DisplayAlert("Success", "Sign up successful. Verification email sent.", "Okay");
                Application.Current.MainPage = new LoginPage();
            }
        }

        private void SignIn(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();
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

        private void ShowCPass(object sender, EventArgs e)
        {
            cpass.IsPassword = false;
            cshow.IsVisible = false;
            chide.IsVisible = true;
        }

        private void HideCPass(object sender, EventArgs e)
        {
            cpass.IsPassword = true;
            cshow.IsVisible = true;
            chide.IsVisible = false;
        }

        private void username_Focused(object sender, FocusEventArgs e)
        {
            userbox.BorderColor = Color.Black;
        }

        private void email_Focused(object sender, FocusEventArgs e)
        {
            emailbox.BorderColor = Color.Black;
        }

        private void pass_Focused(object sender, FocusEventArgs e)
        {
            passbox.BorderColor = Color.Black;
        }

        private void cpass_Focused(object sender, FocusEventArgs e)
        {
            cpassbox.BorderColor = Color.Black;
        }
    }
}
