using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using bcamachoS5.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
[assembly:Xamarin.Forms.Dependency(typeof(mensajeAndroid))]
namespace bcamachoS5.Droid
{
    public class mensajeAndroid : Mensaje
    {
        public void LongAlert(string mensaje)
        {
            Toast.MakeText(Application.Context, mensaje, ToastLength.Long).Show();
        }

        public void ShortAlert(string mensaje)
        {
            Toast.MakeText(Application.Context, mensaje, ToastLength.Short).Show();
        }
    }
}