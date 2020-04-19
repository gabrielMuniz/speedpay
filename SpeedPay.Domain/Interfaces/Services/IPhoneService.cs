using SpeedPay.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SpeedPay.Domain.Interfaces.Services
{
    public interface IPhoneService
    {
        public void Save(Phone phone);
        public Phone GetById(Guid id);
        public Phone Update(Phone phone);
        public Phone Remove(Phone phone);
        public IEnumerable<Phone> GetAll();
        public IEnumerable<Phone> GetByQuery(Expression<Func<Phone, bool>> lambdaExpression);
    }
}
