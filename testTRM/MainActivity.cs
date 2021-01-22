using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace testTRM
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            // New code will go here

            Button btnLogin = FindViewById<Button>(Resource.Id.login);
            btnLogin.Click += Login_click;
            Button btnSignup = FindViewById<Button>(Resource.Id.signup);
            btnSignup.Click += Signup_click;

        }

        private void Login_click(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.trails);
        }
        private void Signup_click(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.signup);
        }

    }
}