using SpeedPay.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SpeedPay.Domain.Interfaces.Services
{
    public interface IEnterpriseService
    {

        public void Save(Enterprise enterprise);
        public Enterprise GetById(Guid id);
        public Enterprise Update(Enterprise enterprise);
        public Enterprise Remove(Enterprise enterprise);
        public IEnumerable<Enterprise> GetAll();
        public IEnumerable<Enterprise> GetByQuery(Expression<Func<Enterprise, bool>> lambdaExpression);

    }
}
