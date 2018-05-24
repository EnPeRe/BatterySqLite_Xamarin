using BatterySqLite_Xamarin.Core;
using BatterySqLite_Xamarin.UWP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System.Power;
using Xamarin.Forms;

[assembly: Dependency(typeof(BatteryChargeProvider))]

namespace BatterySqLite_Xamarin.UWP.Services
{
    public class BatteryChargeProvider : IBatteryChargeProvider
    {
        private BatteryStatus status;
        Windows.Devices.Power.Battery battery;

        public float GetbatteryCharge()
        {
            return 1;
        }
    }
}
