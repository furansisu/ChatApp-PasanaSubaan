using ChatApp_PasanaSubaan.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_PasanaSubaan.DependencyServices
{
    interface iFirebaseAuth
{
        Task<FirebaseAuthResponseModel> LoginWithEmailPassword(string email, string password);
        Task<FirebaseAuthResponseModel> SignUpWithEmailPassword(string name, string email, string password);
        FirebaseAuthResponseModel SignOut();
        FirebaseAuthResponseModel IsLoggedIn();
        Task<FirebaseAuthResponseModel> ResetPassword(string email);
    }
}
