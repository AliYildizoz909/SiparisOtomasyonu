using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisOtomasyonu.Entities.Entity.Abstract;
using SiparisOtomasyonu.Entities.Entity.Enums;

namespace SiparisOtomasyonu.Entities.Entity
{
    public class Check : Payment
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public int BankId { get; set; }
    }
}
