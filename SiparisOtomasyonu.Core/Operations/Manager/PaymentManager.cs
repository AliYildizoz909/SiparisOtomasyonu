using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisOtomasyonu.Core.Operations.Helpers;
using SiparisOtomasyonu.Entities.Entity;
using SiparisOtomasyonu.Entities.Entity.Abstract;
using SiparisOtomasyonu.Entities.Entity.Enums;

namespace SiparisOtomasyonu.Core.Operations.Manager
{
    public class PaymentManager : RepositoryBase<Payment>
    {
        public PaymentManager(PathModel pathModel) : base(pathModel)
        {
        }
        public Payment GetById(int id)
        {
            Payment order = Entities.FirstOrDefault(I => I.Id == id);
            return order;
        }
        public override Result Add(Payment entity)
        {
            entity.Id = Entities[Entities.Count - 1].Id + 1;
            return base.Add(entity);
        }
        public Result Delete(Payment payment)
        {
            return base.Delete(Entities.FindIndex(I => I.Id == payment.Id));
        }
        public Result Update(Payment payment)
        {

            return UseTryCatch.Use(() =>
            {
                Delete(payment);
                Entities.Add(payment);
                Sync();
            });
        }
    }
}
