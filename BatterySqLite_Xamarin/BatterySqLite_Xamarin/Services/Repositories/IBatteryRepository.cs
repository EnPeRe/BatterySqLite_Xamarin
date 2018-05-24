using BatterySqLite_Xamarin.Models;
using BatterySqLite_Xamarin.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using BatterySqLite_Xamarin.Services.Repositories;


namespace BatterySqLite_Xamarin.Services.Repositories
{
    public interface IBatteryRepository : IRepository<Battery>
    {
    }
}
