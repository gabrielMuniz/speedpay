using SpeedPay.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SpeedPay.Domain.Interfaces.Services
{
    public interface IProviderService
    {

        public void Save(Provider provider);
        public Provider GetById(Guid id);
        public Provider Update(Provider provider);
        public Provider Remove(Provider provider);
        public IEnumerable<Provider> GetAll();
        public IEnumerable<Provider> GetByQuery(Expression<Func<Provider, bool>> lambdaExpression);

    }
}
