using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AppCardapio1.Droid
{
    [Activity(Label = "Restaurante Lets Eat", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Activity
    {
        Button btncardapio, btncozinha, btncaixa;
        public string txtSyslog { get; private set; }
        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            //View
            btncardapio = FindViewById<Button>(Resource.Id.btcardapio);
            btncozinha = FindViewById<Button>(Resource.Id.btcozinha);
            btncaixa = FindViewById<Button>(Resource.Id.btcaixa);


            btncardapio.Click += (s, e) =>
            {

                Intent nextActivity = new Intent(this, typeof(SecondActivity));
                StartActivity(nextActivity);
            };

            btncozinha.Click += (s, e) =>
            {
                Intent nextActivity2 = new Intent(this, typeof(ThirdActivity));
                StartActivity(nextActivity2);
            };

        }
    }
}