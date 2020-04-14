using SpeedPay.Domain.Entities;
using SpeedPay.Domain.Interfaces.Repositories;
using SpeedPay.Infra.Data.Contexts;
using SpeedPay.Infra.Data.Repositories.Base;

namespace SpeedPay.Infra.Data.Repositories
{
    public class ProviderRepository : RepositoryBase<Provider>, IProviderRepository
    {

        private DefaultContext context;

        public ProviderRepository(DefaultContext context) : base(context)
        {
            this.context = context;
        }
    }
}
