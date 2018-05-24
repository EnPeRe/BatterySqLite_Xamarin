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
using BatterySqLite_Xamarin.Core;
using BatterySqLite_Xamarin.Droid.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(BatteryChargeProvider))]

namespace BatterySqLite_Xamarin.Droid.Services
{
    public class BatteryChargeProvider : IBatteryChargeProvider
    {
        public float GetbatteryCharge()
        {
            //using (var filter = new IntentFilter(Intent.ActionBatteryChanged))
            //{
            //    using (var battery = Application.Context.RegisterReceiver(null, filter))
            //    {
            //        var level = battery.GetIntExtra(BatteryManager.ExtraLevel, -1);
            //        var scale = battery.GetIntExtra(BatteryManager.ExtraScale, -1);

            //        return (float)Math.Floor(level * 100D / scale);
            //    }
            //}
            return 3;
        }
    }
}