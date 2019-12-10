using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisOtomasyonu.Entities.Entity.Abstract;
using SiparisOtomasyonu.Entities.Entity.Enums;

namespace SiparisOtomasyonu.Entities.Entity
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Status Status { get; set; }
        public int CustomerId { get; set; }
        public List<int> OrderDetailIds { get; set; }   
        public List<int> PaymentIds { get; set; }
    }
}
