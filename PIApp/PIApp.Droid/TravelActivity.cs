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

namespace PIApp.Droid
{
    [Activity]
    public class TravelActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            TextView textview = new TextView(this);
            textview.Text = "Az utaz�s funkci� jelenleg m�g nem el�rhet�. K�rlek gyere vissza k�s�bb!";
            SetContentView(textview);
            // Create your application here
        }
    }
}