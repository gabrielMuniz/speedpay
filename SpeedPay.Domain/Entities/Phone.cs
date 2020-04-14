using SpeedPay.Domain.Entities.Base;

namespace SpeedPay.Domain.Entities
{
    public class Phone : EntityBase
    {

        public string PhoneNumber { get; set; }
        public Provider Provider { get; set; }

    }
}
