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
using BatterySqLite_Xamarin.Constants;
using BatterySqLite_Xamarin.Core;
using BatterySqLite_Xamarin.Droid.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(DatabasePathProvider))]

namespace BatterySqLite_Xamarin.Droid.Services
{
    public class DatabasePathProvider : IDatabasePathProvider
    {
        public bool DatabaseFileExists(string path)
        {
            return System.IO.File.Exists(path);
        }

        public string GetDatabasePath()
        {
            string path = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), CommonConstants.DatabaseName);
            return path;
        }
    }
}