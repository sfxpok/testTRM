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
    [Activity(Label = "TrailsActivity")]
    public class TrailsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.trails);

            // Create your application here

            Button btnCompletedTrails = FindViewById<Button>(Resource.Id.completed_trails);
            btnCompletedTrails.Click += CompletedTrails_click;
        }

        private void CompletedTrails_click(object sender, EventArgs e)
        {
            StartActivity(typeof(CompletedTrailsActivity));
        }

        //public override void OnBackPressed()
        //{
        //    StartActivity(typeof(MainActivity));
        //}


    }
}