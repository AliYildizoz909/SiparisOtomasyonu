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
    public class OrderDetailManager : RepositoryBase<OrderDetail>
    {
        public OrderDetailManager(PathModel pathModel) : base(pathModel)
        {
        }
        public OrderDetail GetById(int id)
        {
            OrderDetail orderDetail = Entities.FirstOrDefault(I => I.Id == id);
            return orderDetail;
        }
        public override Result Add(OrderDetail entity)
        {
            entity.Id = Entities[Entities.Count - 1].Id + 1;
            return base.Add(entity);
        }
        public Result Delete(OrderDetail orderDetail)
        {
            return base.Delete(Entities.FindIndex(I => I.Id == orderDetail.Id));
        }
        public Result Update(OrderDetail orderDetail)
        {

            return UseTryCatch.Use(() =>
            {
                Delete(orderDetail);
                Entities.Add(orderDetail);
                Sync();
            });
        }
    }
}
