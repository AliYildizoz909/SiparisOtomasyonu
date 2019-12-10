using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu.Entities.Entity
{
    public class Item
    {
        public List<OrderDetail> OrderDetails { get; set; }
        public string Description { get; set; }

        public decimal ShippingWeight
        {
            get { return GetWeight(); }
        }
        public decimal PriceForQuantity
        {
            get { return GetPriceForQuantity(); }
        }

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
