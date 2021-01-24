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
using testTRM.Entities;

namespace testTRM
{
    [Activity(Label = "SignupActivity")]
    public class SignupActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.signup);

            Button btnTestAddUser = FindViewById<Button>(Resource.Id.btnTestUser);
            btnTestAddUser.Click += btnTestAddUser_Click;

        }

        private void btnTestAddUser_Click(object sender, EventArgs e)
        {
            var username = FindViewById<EditText>(Resource.Id.inputUsername).Text;
            var password = FindViewById<EditText>(Resource.Id.inputPassword).Text;
            var email = FindViewById<EditText>(Resource.Id.inputEmail).Text;
            var birthday = FindViewById<EditText>(Resource.Id.inputBirthday).Text;

            var id = PeopleRepository.SavePerson(new User
            {
                username = username,
                password = password,
                email = email,
                birthday = birthday
            });

            var person = PeopleRepository.GetPerson(id);

            if (person == null)
                Toast.MakeText(this, $"Person: Username={username}, Email={email} wasn't properly saved!", ToastLength.Long).Show();
            else
                Toast.MakeText(this, $"Person saved, details: {person}", ToastLength.Long).Show();

        }

    }
}