using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisOtomasyonu.Entities.Entity.Abstract;

namespace SiparisOtomasyonu.Entities.Entity
{
    public class Check : Payment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int BankId { get; set; }

    }
}
