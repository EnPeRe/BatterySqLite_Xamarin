using System;
using System.Collections.Generic;
using System.Text;


namespace BatterySqLite_Xamarin.Core
{
    public interface IDatabasePathProvider
    {
        string GetDatabasePath();
        bool DatabaseFileExists(string path);
    }
}
