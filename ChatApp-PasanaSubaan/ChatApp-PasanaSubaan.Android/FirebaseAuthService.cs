using System;
using System.Threading.Tasks;
using Firebase.Auth;
using Plugin.CloudFirestore;
using ChatApp_PasanaSubaan.Droid;
using Xamarin.Forms;
using ChatApp_PasanaSubaan.Models;

[assembly: Dependency(typeof(FirebaseAuthService))]

namespace ChatApp_PasanaSubaan.Droid
{
    public class FirebaseAuthService : iFirebaseAuth
    {
        DataClass dataClass = DataClass.GetInstance;

        public FirebaseAuthResponseModel IsLoggedIn()
        {

        }
    }
}