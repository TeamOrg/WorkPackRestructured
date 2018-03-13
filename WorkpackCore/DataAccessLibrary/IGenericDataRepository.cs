using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DomainModelLibrary;

namespace DataAccessLibrary
{
    public interface IGenericDataRepository<T> where T : class, IEntity
    {
        IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
        T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
        void Add(params T[] items);
        void Update(params T[] items);
        void Remove(params T[] items);
        int getAdd(params T[] items);
        int getUpdate(params T[] items);
        int getRemove(params T[] items);
        string getXML(params T[] items);
        //DataTable LINQToDataTable(IEnumerable<T> linqList);
    }

}
