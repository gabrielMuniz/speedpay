using SpeedPay.Domain.Entities.Base;
using SpeedPay.Domain.Enums;
using System;
using System.Collections.Generic;

namespace SpeedPay.Domain.Entities
{
    public class Provider : EntityBase
    {

        public Enterprise Enterprise { get; set; }
        public string FederalRegistration { get; set; }
        public string GeneralRegistration { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime BornDate { get; set; }
        public List<Phone> Phones { get; set; }
        public TypeProvider Type { get; set; }

        public Provider()
        {
            if (VerifyAgeProvider())
            {
                throw new ArgumentException("Empresas do Paraná não aceitam fornecedor menor de idade.");
            }
        }


        private bool VerifyAgeProvider()
        {
            return Enterprise != null && Enterprise.FederativeUnit == "PR" && GetAgeByBornDate() > 18;
        }

        private int GetAgeByBornDate()
        {
            int age = DateTime.Now.Year - BornDate.Year;
            if (DateTime.Now.DayOfYear < BornDate.DayOfYear)
            {
                age = age - 1;
            }
            return age;
        }

    }
}
