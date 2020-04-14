using Microsoft.EntityFrameworkCore.ChangeTracking;
using SpeedPay.Domain.Interfaces.Repositories.Base;
using SpeedPay.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SpeedPay.Infra.Data.Repositories.Base
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {

        private DefaultContext context;

        public RepositoryBase(DefaultContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>();
        }

        public T GetById(Guid id)
        {
            return context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetByQuery(Expression<Func<T, bool>> filter)
        {
            return context.Set<T>().AsQueryable().Where(filter);
        }

        public T Remove(T entity)
        {
            var result = context.Set<T>().Remove(entity);
            SaveChanges();
            return result.Entity;
        }

        public void Save(T entity)
        {
            context.Set<T>().Add(entity);
            SaveChanges();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public T Update(T entity)
        {
            var result = context.Set<T>().Update(entity);
            SaveChanges();
            return result.Entity;
        }
    }
}
