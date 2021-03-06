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

namespace testTRM
{
    [Activity(Label = "LevadaAlecrimActivity")]
    public class LevadaAlecrimActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.levada_alecrim);

            Button btnOverview = FindViewById<Button>(Resource.Id.btnOverview);
            btnOverview.Click += Overview_click;
        }
        private void Overview_click(object sender, EventArgs e)
        {
            StartActivity(typeof(OverviewActivity));
            // SetContentView(Resource.Layout.trails);
        }
    }
}