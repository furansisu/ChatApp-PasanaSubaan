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
public partial class ConversationPage : ContentPage
    {
        public ConversationPage()
        {
            InitializeComponent();
        }

        private async void BackEvent(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}