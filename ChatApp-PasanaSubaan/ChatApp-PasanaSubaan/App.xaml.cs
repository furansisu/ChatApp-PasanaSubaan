using ChatApp_PasanaSubaan.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatApp_PasanaSubaan
{
    public partial class App : Application
    {
        DataClass dataClass = DataClass.GetInstance;
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new TabbedPage1());
            if (dataClass.isSignedIn)
            {
                Application.Current.MainPage = new TabbedPage1();
            }
            else
            {
                MainPage = new NavigationPage(new LoginPage());
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
