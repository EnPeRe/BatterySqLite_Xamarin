﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace BatterySqLite_Xamarin.Core
{
    public class BaseRepository<T> : IRepository<T> where T : new()
    {
        private readonly IConnectionWrapper _connectionWrapper = DependencyService.Get<IConnectionWrapper>();

        public BaseRepository()
        {
        }

        private SQLiteConnection GetConnection()
        {
            return _connectionWrapper.GetConnection() as SQLiteConnection;
        }

        public int Insert(T entity)
        {
            using (SQLiteConnection connection = GetConnection())
            {
                return connection.Insert(entity);
            }
        }

        public int InsertOrUpdate(T entity)
        {
            using (SQLiteConnection connection = GetConnection())
            {
                return connection.InsertOrReplace(entity);
            }
        }

        public int RemoveAll()
        {
            using (SQLiteConnection connection = GetConnection())
            {
                return connection.DeleteAll<T>();
            }
        }

        public int Remove(T entity)
        {
            using (SQLiteConnection connection = GetConnection())
            {
                return connection.Delete(entity);
            }
        }

        public T Find(object pk)
        {
            using (SQLiteConnection connection = GetConnection())
            {
                return connection.Find<T>(pk);
            }
        }

        public T Get(object pk)
        {
            using (SQLiteConnection connection = GetConnection())
            {
                return connection.Get<T>(pk);
            }
        }

        public T Get(Func<T, bool> predicate)
        {
            using (SQLiteConnection connection = GetConnection())
            {
                T data = connection.Table<T>().FirstOrDefault(predicate);
                return data;
            }
        }

        public List<T> GetAll()
        {
            using (SQLiteConnection connection = GetConnection())
            {
                List<T> lst = connection.Table<T>().ToList();
                return lst;
            }
        }

        protected List<T> Query(string sqlQuery, params object[] parameters)
        {
            using (SQLiteConnection connection = GetConnection())
            {
                return connection.Query<T>(sqlQuery, parameters);
            }
        }
    }
}
