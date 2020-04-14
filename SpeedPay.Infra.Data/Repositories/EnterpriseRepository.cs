using SpeedPay.Domain.Entities;
using SpeedPay.Domain.Interfaces.Repositories;
using SpeedPay.Infra.Data.Contexts;
using SpeedPay.Infra.Data.Repositories.Base;

namespace SpeedPay.Infra.Data.Repositories
{
    public class EnterpriseRepository : RepositoryBase<Enterprise>, IEnterpriseRepository
    {

        private DefaultContext context;

        public EnterpriseRepository(DefaultContext context) : base(context)
        {
            this.context = context;
        }
    }
}
