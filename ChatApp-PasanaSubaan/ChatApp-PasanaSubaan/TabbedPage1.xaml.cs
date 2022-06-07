using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ChatApp_PasanaSubaan.Models;

namespace ChatApp_PasanaSubaan
{
    public partial class TabbedPage1 : TabbedPage
    {
        DataClass dataClass = DataClass.GetInstance;
        public TabbedPage1()
        {
            InitializeComponent();
            //ProfilePage.name = dataClass.loggedInUser.name;
            //ProfilePage.email = dataClass.loggedInUser.email;
        }
    }
}