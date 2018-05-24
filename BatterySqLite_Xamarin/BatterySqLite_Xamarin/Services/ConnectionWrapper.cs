using BatterySqLite_Xamarin.Models;
using BatterySqLite_Xamarin.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(ConnectionWrapper))]

namespace BatterySqLite_Xamarin.Services
{
    public class ConnectionWrapper : BaseConnectionWrapper
    {
        protected override SQLiteConnection CreateDataBase(string path)
        {
            SQLiteConnection connection = new SQLiteConnection(path);
            connection.CreateTable<Battery>();
            return connection;
        }
    }
}
