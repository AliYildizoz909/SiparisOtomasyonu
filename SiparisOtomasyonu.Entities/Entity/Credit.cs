using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisOtomasyonu.Entities.Entity.Abstract;
using SiparisOtomasyonu.Entities.Entity.Enums;

namespace SiparisOtomasyonu.Entities.Entity
{
    public class Credit : Payment
    {
    
        public string CardNumber { get; set; }
        public short Cvc { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
