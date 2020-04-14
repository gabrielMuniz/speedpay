using SpeedPay.Domain.Entities;
using SpeedPay.Domain.Interfaces.Repositories;
using SpeedPay.Infra.Data.Contexts;
using SpeedPay.Infra.Data.Repositories.Base;

namespace SpeedPay.Infra.Data.Repositories
{
    public class PhoneRepository : RepositoryBase<Phone>, IPhoneRepository
    {

        private DefaultContext context;

        public PhoneRepository(DefaultContext context) : base(context)
        {
            this.context = context;
        }
    }
}
