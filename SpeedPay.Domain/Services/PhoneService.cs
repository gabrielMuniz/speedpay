using SpeedPay.Domain.Entities;
using SpeedPay.Domain.Interfaces.Repositories;
using SpeedPay.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SpeedPay.Domain.Services
{
    public class PhoneService : IPhoneService
    {

        private IPhoneRepository _repository;

        public PhoneService(IPhoneRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Phone> GetAll()
        {
            return _repository.GetAll();
        }

        public Phone GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Phone> GetByQuery(Expression<Func<Phone, bool>> lambdaExpression)
        {
            return _repository.GetByQuery(lambdaExpression);
        }

        public Phone Remove(Phone phone)
        {
            return _repository.Remove(phone);
        }

        public void Save(Phone phone)
        {
            _repository.Save(phone);
        }

        public Phone Update(Phone phone)
        {
            return _repository.Update(phone);
        }
    }
}
