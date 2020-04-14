using Microsoft.EntityFrameworkCore;
using SpeedPay.Domain.Entities;

namespace SpeedPay.Infra.Data.Contexts
{
    public class DefaultContext : DbContext
    {

        public DbSet<Provider> Providers { get; set; }
        public DbSet<Enterprise> Enterprises { get; set; }
        public DbSet<Phone> Phones { get; set; }

        public DefaultContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }
}
