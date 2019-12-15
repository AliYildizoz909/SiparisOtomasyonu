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
        private ItemManager _itemManager;
        private OrderDetailManager(PathModel pathModel) : base(pathModel)
        {
        }
        private static OrderDetailManager _orderDetailManager;
        public static OrderDetailManager CreateAsSingleton(PathModel pathModel)
        {
            if (_orderDetailManager == null)
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
            _orderManager = OrderManager.CreateAsSingleton(PathHelper.OrderPathModel);
            _itemManager = ItemManager.CreateAsSingleton(PathHelper.ItemPathModel);
            Order order = _orderManager.Entities.Find(I => I.Id == entity.OrderId);
            Item item = _itemManager.Entities.Find(I => I.Id == entity.ItemId);
            if (order != null && item != null)
            {
                order.OrderDetailIds.Add(entity.Id);
                _orderManager.Update(order);
                item.OrderDetails.Add(entity);
                _itemManager.Update(item);
            }
            return base.Add(entity);
        }
        public Result Delete(OrderDetail orderDetail)
        {
            bool res = Entities.Find(I => I.Id == orderDetail.Id && I.OrderId == orderDetail.OrderId) != null;
            if (res)
            {
                _orderManager = OrderManager.CreateAsSingleton(PathHelper.OrderPathModel);
                _itemManager = ItemManager.CreateAsSingleton(PathHelper.ItemPathModel);
                Order order = _orderManager.Entities.Find(I => I.Id == orderDetail.OrderId);
                Item item = _itemManager.Entities.Find(I => I.Id == orderDetail.ItemId);
                if (order != null)
                {
                    order.OrderDetailIds.Remove(orderDetail.Id);
                    _orderManager.Update(order);
                    item.OrderDetails.Remove(orderDetail);
                    _itemManager.Update(item);
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
