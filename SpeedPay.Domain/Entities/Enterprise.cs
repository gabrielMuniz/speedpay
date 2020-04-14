using SpeedPay.Domain.Entities.Base;

namespace SpeedPay.Domain.Entities
{
    public class Enterprise : EntityBase
    {

        public string FantasyName { get; set; }
        public string FederalRegistration { get; set; }
        public string FederativeUnit { get; set; }

        public Enterprise()
        {
            
        }



    }
}
