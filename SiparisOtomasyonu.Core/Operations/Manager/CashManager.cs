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
    public class CashManager : RepositoryBase<Cash>
    {
        private OrderManager _orderManager;
        private CashManager(PathModel pathModel) : base(pathModel)
        {
        }
        private static CashManager _cashManager;
        public static CashManager CreateAsSingleton(PathModel pathModel)
        {
            if (_cashManager == null)
            {
                _cashManager = new CashManager(pathModel);
            }

            return _cashManager;
        }
        public Cash GetById(int id)
        {
            Cash cash = Entities.FirstOrDefault(I => I.Id == id);
            return cash;
        }
        public override Result Add(Cash entity)
        {
            entity.Id = Entities.Count != 0 ? Entities[Entities.Count - 1].Id + 1 : 1;
            _orderManager = OrderManager.CreateAsSingleton(PathHelper.OrderPathModel);
            Order order = _orderManager.Entities.Find(I => I.Id == entity.OrderId);
            if (order != null)
            {
                order.PaymentIds.Add(entity.Id);
                _orderManager.Update(order);
            }
            return base.Add(entity);
        }
        public Result Delete(Cash cash)
        {
            bool res = Entities.Find(I => I.Id == cash.Id && I.OrderId == cash.OrderId) != null;
            if (res)
            {
                _orderManager = OrderManager.CreateAsSingleton(PathHelper.OrderPathModel);
                Order order = _orderManager.Entities.Find(I => I.Id == cash.OrderId);
                if (order != null)
                {
                    order.PaymentIds.Remove(cash.Id);
                    _orderManager.Update(order);
                }
                return base.Delete(Entities.FindIndex(I => I.Id == cash.Id));
            }
            return new Result { ResultState = ResultState.Erorr };
        }
        public Result Update(Cash cash)
        {
            return UseTryCatch.Use(() =>
            {
                base.Delete(Entities.FindIndex(I => I.Id == cash.Id));
                Entities.Add(cash);
                Sync();
            });
        }
    }
}
