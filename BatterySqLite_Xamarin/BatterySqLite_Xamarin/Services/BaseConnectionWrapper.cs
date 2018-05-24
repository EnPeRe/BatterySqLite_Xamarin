using BatterySqLite_Xamarin.Core;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BatterySqLite_Xamarin.Services
{
    public abstract class BaseConnectionWrapper : IConnectionWrapper
    {
        private readonly IDatabasePathProvider _databasePathProvider = DependencyService.Get<IDatabasePathProvider>();

        public BaseConnectionWrapper()
        {

        }

        public object GetConnection()
        {
            string path = _databasePathProvider.GetDatabasePath();
            SQLiteConnection connection = (!_databasePathProvider.DatabaseFileExists(path)) ? CreateDataBase(path) : new SQLiteConnection(path);
            return connection;
        }

        protected abstract SQLiteConnection CreateDataBase(string path);

    }
}
