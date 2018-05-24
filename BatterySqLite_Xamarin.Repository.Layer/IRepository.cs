using System;
using System.Collections.Generic;
using System.Text;

namespace BatterySqLite_Xamarin.Core
{
    public interface IRepository<T>
    {
        int RemoveAll();
        int Insert(T entity);
        int InsertOrUpdate(T entity);
        int Remove(T entity);
        T Find(object pk);
        T Get(object pk);
        T Get(Func<T, bool> predicate);
        List<T> GetAll();
    }
}
