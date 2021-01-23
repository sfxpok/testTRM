using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testTRM
{
    [Activity(Label = "SignupActivity")]
    public class SignupActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.signup);
            Button btnSignIn = FindViewById<Button>(Resource.Id.signintesting);
            btnSignIn.Click += SignIn_click;

            // Create your application here
        }

        //public override void OnBackPressed()
        //{
        //    var intent = new Intent(this, typeof(MainActivity));
        //    StartActivity(intent);

        //    base.OnBackPressed();
        //}

        private void SignIn_click(object sender, EventArgs e)
        {

            //Intent intent = new Intent(this, typeof(MainActivity));
            //StartActivity(intent);

            SetContentView(Resource.Layout.home);
        }
    }
}