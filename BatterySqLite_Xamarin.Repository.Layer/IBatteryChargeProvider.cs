using System;
using System.Collections.Generic;
using System.Text;

namespace BatterySqLite_Xamarin.Core
{
    public interface IBatteryChargeProvider
    {
        float GetbatteryCharge();
    }
}
