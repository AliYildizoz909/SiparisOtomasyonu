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
        private OrderManager _orderManager;

        private OrderDetailManager(PathModel pathModel) : base(pathModel)
        {
        }
        private static OrderDetailManager _orderDetailManager;
        public static OrderDetailManager CreateAsSingleton(PathModel pathModel)
        {
            if(_orderDetailManager == null)
            {
                _orderDetailManager = new OrderDetailManager(pathModel);

            }

            return _orderDetailManager;
        }
        public OrderDetail GetById(int id)
        {
            OrderDetail orderDetail = Entities.FirstOrDefault(I => I.Id == id);
            return orderDetail;
        }
        public override Result Add(OrderDetail entity)
        {
            entity.Id = Entities.Count != 0 ? Entities[Entities.Count - 1].Id + 1 : 1;
            _orderManager = OrderManager.CreateAsSingleton(ConstHelper.OrderPathModel);
            Order order = _orderManager.Entities.Find(I => I.Id == entity.OrderId);
            if (order != null)
            {
                order.OrderDetailIds.Add(entity.Id);
                _orderManager.Update(order);
            }
            return base.Add(entity);
        }
        public Result Delete(OrderDetail orderDetail)
        {
            bool res = Entities.Find(I => I.Id == orderDetail.Id && I.OrderId == orderDetail.OrderId) != null;
            if (res)
            {
                _orderManager = OrderManager.CreateAsSingleton(ConstHelper.OrderPathModel);
                Order order = _orderManager.Entities.Find(I => I.Id == orderDetail.OrderId);
                if (order != null)
                {
                    order.OrderDetailIds.Remove(orderDetail.Id);
                    _orderManager.Update(order);
                }
                return base.Delete(Entities.FindIndex(I => I.Id == orderDetail.Id));
            }
            return new Result { ResultState = ResultState.Erorr };
        }
        public Result Update(OrderDetail orderDetail)
        {

            return UseTryCatch.Use(() =>
            {
                base.Delete(Entities.FindIndex(I => I.Id == orderDetail.Id));
                Entities.Add(orderDetail);
                Sync();
            });
        }
    }
}
