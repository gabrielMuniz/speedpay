using SpeedPay.Domain.Entities;
using SpeedPay.Domain.Interfaces.Repositories;
using SpeedPay.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SpeedPay.Domain.Services
{
    public class ProviderService : IProviderService
    {

        private IProviderRepository _repository;

        public ProviderService(IProviderRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Provider> GetAll()
        {
            return _repository.GetAll();
        }

        public Provider GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Provider> GetByQuery(Expression<Func<Provider, bool>> lambdaExpression)
        {
            return _repository.GetByQuery(lambdaExpression);
        }

        public Provider Remove(Provider provider)
        {
            return _repository.Remove(provider);
        }

        public void Save(Provider provider)
        {
            _repository.Save(provider);
        }

        public Provider Update(Provider provider)
        {
            return _repository.Update(provider);
        }
    }
}
