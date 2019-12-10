using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisOtomasyonu.Entities.Entity.Abstract;
using SiparisOtomasyonu.Entities.Entity.Enums;

namespace SiparisOtomasyonu.Entities.Entity
{
    public class OrderDetail : IEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public TaxStatus TaxStatus { get; set; }
        public decimal Weight { get; set; }

        public decimal SubWeight
        {
            get { return CalcWeight(); }
        }

        public decimal SubTotal
        {
            get { return CalcSubTotal(); }
        }

        private decimal CalcSubTotal()
        {
            var subTotal = Price * Quantity;
            decimal taxSubTotal = 0;
            switch (TaxStatus)
            {
                case TaxStatus.Tax18:
                    taxSubTotal = (subTotal * 18 / 100) + subTotal;
                    break;
                case TaxStatus.Tax2:
                    taxSubTotal = (subTotal * 2 / 100) + subTotal;
                    break;
            }

            return taxSubTotal;
        }
        private decimal CalcWeight()
        {
            var calcWeight = Weight * Quantity;

            return calcWeight;
        }
    }
}
