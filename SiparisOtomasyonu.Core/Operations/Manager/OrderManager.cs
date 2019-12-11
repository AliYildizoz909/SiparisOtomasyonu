using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisOtomasyonu.Core.Operations.Helpers;
using SiparisOtomasyonu.Entities.Entity;
using SiparisOtomasyonu.Entities.Entity.Enums;

namespace SiparisOtomasyonu.Core.Operations.Manager
{
    public class OrderManager : RepositoryBase<Order>
    {
        public OrderManager(PathModel pathModel) : base(pathModel)
        {
        }
        public Order GetById(int id)
        {
            Order order = Entities.FirstOrDefault(I => I.Id == id);
            return order;
        }
        public override Result Add(Order entity)
        {
            entity.Id = Entities.Count != 0 ? Entities[Entities.Count - 1].Id + 1 : 1;


            return base.Add(entity);
        }
        public Result Delete(Order order)
        {
            return base.Delete(Entities.FindIndex(I => I.Id == order.Id));
        }
        public Result Update(Order order)
        {

            return UseTryCatch.Use(() =>
            {
                Delete(order);
                Entities.Add(order);
                Sync();
            });
        }
    }
}
