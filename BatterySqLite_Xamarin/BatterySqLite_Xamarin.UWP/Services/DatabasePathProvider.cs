using BatterySqLite_Xamarin.Constants;
using BatterySqLite_Xamarin.Core;
using BatterySqLite_Xamarin.UWP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(DatabasePathProvider))]

namespace BatterySqLite_Xamarin.UWP.Services
{
    public class DatabasePathProvider : IDatabasePathProvider
    {
        public bool DatabaseFileExists(string path)
        {
            try
            {
                ApplicationData.Current.LocalFolder.GetFileAsync(path).GetResults();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string GetDatabasePath()
        {
            string path = System.IO.Path.Combine(ApplicationData.Current.LocalFolder.Path, CommonConstants.DatabaseName);
            return path;
        }
    }
}
