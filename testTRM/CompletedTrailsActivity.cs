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
    [Activity(Label = "CompletedTrailsActivity")]
    public class CompletedTrailsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Button btnLevadaAlecrim = FindViewById<Button>(Resource.Id.levada25fontes);
            btnLevadaAlecrim.Click += LevadaAlecrim_click;


            // Create your application here
        }


        private void LevadaAlecrim_click(object sender, EventArgs e)
        {
            StartActivity(typeof(LevadaAlecrimActivity));
            // SetContentView(Resource.Layout.trails);
        }

    }
}