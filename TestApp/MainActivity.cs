using Android.App;
using Android.Widget;
using Android.OS;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace TestApp
{
    [Activity(Label = "TestApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            AppCenter.Start("2c1e7712-b7b0-40ee-96d7-ecca1f4b2503",
                   typeof(Analytics), typeof(Crashes));
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var btnDisplay = FindViewById<Button>(Resource.Id.SayHi);
            btnDisplay.Click += BtnDisplay_Click;
            
        }

        private void BtnDisplay_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(FindViewById<EditText>(Resource.Id.editText1).Text))
                Toast.MakeText(this, "Hello " + FindViewById<EditText>(Resource.Id.editText1).Text, ToastLength.Long).Show();
            else
                Toast.MakeText(this, "I dont know your name, please enter your name !!", ToastLength.Long).Show(); ;
        }
    }
}

