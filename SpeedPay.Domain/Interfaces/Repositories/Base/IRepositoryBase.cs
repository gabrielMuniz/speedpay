using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SpeedPay.Domain.Interfaces.Repositories.Base
{
    public interface IRepositoryBase<T> where T : class
    {

        public void Save(T entity);
        public T GetById(Guid id);
        public T Update(T entity);
        public T Remove(T entity);
        public IEnumerable<T> GetAll();
        public IEnumerable<T> GetByQuery(Expression<Func<T, bool>> lambdaExpression);
        public void SaveChanges();

    }
}
