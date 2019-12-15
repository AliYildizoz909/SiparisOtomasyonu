using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisOtomasyonu.Entities.Entity.Abstract;

namespace SiparisOtomasyonu.Entities.Entity
{
    public class Item : IEntity
    {
        public Item()
        {
            OrderDetails = new List<OrderDetail>();
        }
        public int Id { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public string Description { get; set; }

        public decimal GetWeight()
        {
            decimal shippingWeight = 0;
            foreach (var orderDetail in OrderDetails)
            {
                shippingWeight += orderDetail.SubWeight;
            }

            return shippingWeight;
        }

        public decimal GetPriceForQuantity()
        {
            decimal priceForQuantity = 0;
            foreach (var orderDetail in OrderDetails)
            {
                priceForQuantity += orderDetail.SubWeight;
            }

            return priceForQuantity;
        }
    }
}
