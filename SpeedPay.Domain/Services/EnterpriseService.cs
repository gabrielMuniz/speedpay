using SpeedPay.Domain.Entities;
using SpeedPay.Domain.Interfaces.Repositories;
using SpeedPay.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SpeedPay.Domain.Services
{
    public class EnterpriseService : IEnterpriseService
    {

        private IEnterpriseRepository _repository;

        public EnterpriseService(IEnterpriseRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Enterprise> GetAll()
        {
            return _repository.GetAll();
        }

        public Enterprise GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Enterprise> GetByQuery(Expression<Func<Enterprise, bool>> lambdaExpression)
        {
            return _repository.GetByQuery(lambdaExpression);
        }

        public Enterprise Remove(Enterprise enterprise)
        {
            return _repository.Remove(enterprise);
        }

        public void Save(Enterprise enterprise)
        {
            _repository.Save(enterprise);
        }

        public Enterprise Update(Enterprise enterprise)
        {
            return _repository.Update(enterprise);
        }
    }
}
