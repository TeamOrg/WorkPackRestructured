using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DomainModelLibrary;
//using Utilities.ExceptionTypes;
using System.IO;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Xml.Serialization;
using System.Data;
//using System.Data.Entity.Infrastructure;

namespace DataAccessLibrary
{
    public class GenericDataRepository<T> : IGenericDataRepository<T> where T : class, IEntity
    {
        private readonly WorkpackDBContext _context;

        public GenericDataRepository(WorkpackDBContext context) {
            _context = context;
        }
        public virtual IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            
                IQueryable<T> dbQuery = _context.Set<T>();

                //Apply eager loading Abdul
                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                list = dbQuery
                    .AsNoTracking()
                    .ToList<T>();
            
            return list;
        }
        public virtual IList<T> GetList(Func<T, bool> where,
             params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            
                IQueryable<T> dbQuery = _context.Set<T>();

                //Apply eager loading
                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                list = dbQuery
                    .AsNoTracking()
                    .Where(where)
                    .ToList<T>();
            
            return list;
        }

        public virtual T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            T item = null;
            
                IQueryable<T> dbQuery = _context.Set<T>();

                //Apply eager loading
                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                item = dbQuery
                    .AsNoTracking() //Don't track any changes for the selected item
                    .FirstOrDefault(where); //Apply where clause
            
            return item;
        }

        public virtual void Add(params T[] items)
        {
            try
            {

                Update(items);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual void Update(params T[] items)
        {
            try
            {
               
                    DbSet<T> dbSet = _context.Set<T>();
                    foreach (T item in items)
                    {
                        dbSet.Add(item);
                        foreach (EntityEntry<IEntity> entry in _context.ChangeTracker.Entries<IEntity>())
                        {
                            IEntity entity = entry.Entity;
                            entry.State = GetEntityState(entity.EntityState);
                        }
                    }
                _context.SaveChanges();
                
            }


            //catch (DbEntityValidationException e)
            //{
            //    foreach (var eve in e.EntityValidationErrors)
            //    {
            //        String strErr = "Entity of type " + eve.Entry.Entity.GetType().Name + " in state " + eve.Entry.State + " has the following validation errors:";
            //        foreach (var ve in eve.ValidationErrors)
            //        {
            //            string str = "Property: " + ve.PropertyName + ", Error: " + ve.ErrorMessage + "";
            //        }
            //    }
            //    throw;
            //}


            catch (Exception ex)
            {








                // bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
                //if (ex is DbEntityValidationException)
                //{
                //    throw ValidationResults(ex as DbEntityValidationException);
                //}
                //else
                //{
                throw ex;
                //}
            }
        }
        public virtual void Remove(params T[] items)
        {
            try
            {
                Update(items);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual int getAdd(params T[] items)
        {
            int result = 0;
            try
            {

                result = getUpdate(items);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public virtual int getUpdate(params T[] items)
        {
            int result = 0;
            try
            {
                
                    DbSet<T> dbSet = _context.Set<T>();
                    foreach (T item in items)
                    {
                        dbSet.Add(item);
                        foreach (EntityEntry<IEntity> entry in _context.ChangeTracker.Entries<IEntity>())
                        {
                            IEntity entity = entry.Entity;
                            entry.State = GetEntityState(entity.EntityState);
                        }
                    }
                    result = _context.SaveChanges();
                
            }
            catch (Exception ex)
            {
               // bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
                //if (ex is DbEntityValidationException)
                //{
                //    throw ValidationResults(ex as DbEntityValidationException);
                //}
                //else
                //{
                    throw ex;
                //}
            }
            return result;
        }
        public virtual int getRemove(params T[] items)
        {
            int result = 0;
            try
            {
                result = getUpdate(items);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public virtual string getXML(params T[] item)
        {
            StringWriter sw = new StringWriter();
            //using (var context = new WorkpackDBContext())
            //{
            //    XmlSerializer serializer = new XmlSerializer(item.GetType());
            //    serializer.Serialize(sw, item);
            //}
            return sw.ToString();
        }
        //public DataTable LINQToDataTable(IEnumerable<T> linqList)
        //{
        //    var dtReturn = new DataTable();
        //    PropertyInfo[] columnNameList = null;
        //    if (linqList == null) return dtReturn;
        //    foreach (T t in linqList)
        //    {
        //        // Use reflection to get property names, to create table, Only first time, others will follow 
        //        //if (columnNameList == null)
        //        //{
        //        //    columnNameList = ((Type)t.GetType()).GetProperties();
        //        //    foreach (PropertyInfo columnName in columnNameList)
        //        //    {
        //        //        Type columnType = columnName.PropertyType;
        //        //        if ((columnType.IsGenericType) && (columnType.GetGenericTypeDefinition() == typeof(Nullable<>)))
        //        //        {
        //        //            columnType = columnType.GetGenericArguments()[0];
        //        //        }
        //        //        dtReturn.Columns.Add(new DataColumn(columnName.Name, columnType));
        //        //    }
        //        //}
        //        //DataRow dataRow = dtReturn.NewRow();
        //        //foreach (PropertyInfo columnName in columnNameList)
        //        //{
        //        //    dataRow[columnName.Name] =
        //        //        columnName.GetValue(t, null) == null ? DBNull.Value : columnName.GetValue(t, null);
        //        //}
        //        //dtReturn.Rows.Add(dataRow);
        //    }
        //    return dtReturn;
        //}
        //protected static DataValidationException ValidationResults(DbEntityValidationException ex)
        //{
        //    DataValidationException e;
        //    StringBuilder errorList = new StringBuilder();
        //    foreach (var dberror in ex.EntityValidationErrors)
        //    {
        //        var val = dberror.ValidationErrors.Select(v => v.ErrorMessage);
        //        foreach (var a in val)
        //            errorList.Append(a.ToString() + ", ");
        //    }
        //    e = new DataValidationException(errorList.ToString().Trim().TrimEnd(','));
        //    return e;
        //}

        protected static Microsoft.EntityFrameworkCore.EntityState GetEntityState(DomainModelLibrary.EntityState entityState)
        {
            switch (entityState)
            {
                case DomainModelLibrary.EntityState.Unchanged:
                    return Microsoft.EntityFrameworkCore.EntityState.Unchanged;
                case DomainModelLibrary.EntityState.Added:
                    return Microsoft.EntityFrameworkCore.EntityState.Added;
                case DomainModelLibrary.EntityState.Modified:
                    return Microsoft.EntityFrameworkCore.EntityState.Modified;
                case DomainModelLibrary.EntityState.Deleted:
                    return Microsoft.EntityFrameworkCore.EntityState.Deleted;
                default:
                    return Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
        }


    }
}
