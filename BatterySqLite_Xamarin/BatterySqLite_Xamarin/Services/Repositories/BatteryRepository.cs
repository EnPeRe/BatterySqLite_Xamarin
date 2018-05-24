using BatterySqLite_Xamarin.Core;
using BatterySqLite_Xamarin.Models;
using BatterySqLite_Xamarin.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(BatteryRepository))]

namespace BatterySqLite_Xamarin.Services.Repositories
{
    public class BatteryRepository : BaseRepository<Battery>, IBatteryRepository
    {
        public BatteryRepository() : base()
        {
        }
    }
}
