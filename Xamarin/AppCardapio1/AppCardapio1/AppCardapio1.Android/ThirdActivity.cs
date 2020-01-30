using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;

namespace AppCardapio1.Droid
{
    [Activity(Label = "Restaurante Lets Eat", Icon = "@drawable/icon", Theme = "@style/MainTheme")]
    public class ThirdActivity : FormsAppCompatActivity
    {
        public static ThirdActivity Instance;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Instance = this;


            // Create your application here

        }
    }
}