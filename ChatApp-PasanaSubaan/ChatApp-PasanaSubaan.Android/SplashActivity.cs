﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatApp_PasanaSubaan.Droid
{
    [Activity(Label = "SplashActivity", Icon = "@mipmap/icon", Theme = "@style/splashscreen", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        //protected override void OnCreate(Bundle savedInstanceState)
        //{
        //   base.OnCreate(savedInstanceState);

            // Create your application here
        //}
        protected override void OnResume()
        {
            base.OnResume();
            StartActivity(typeof(MainActivity));
        }
    }
}