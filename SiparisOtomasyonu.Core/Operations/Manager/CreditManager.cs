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
    public class CreditManager : RepositoryBase<Credit>
    {
        private CustomerManager _customerManager;
        private OrderManager _orderManager;
        public CreditManager(PathModel pathModel) : base(pathModel)
        {
            _customerManager = CustomerManager.CreateAsSingleton(PathHelper.CustomerPathModel);
        }
        private static CreditManager _creditManager;
        public static CreditManager CreateAsSingleton(PathModel pathModel)
        {
            if (_creditManager == null)
            {
                _creditManager = new CreditManager(pathModel);

            }

            return _creditManager;
        }
        public Credit GetById(int id)
        {
            Credit credit = Entities.FirstOrDefault(I => I.Id == id);
            return credit;
        }
        public override Result Add(Credit entity)
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
        public Result Delete(Credit credit)
        {
            bool res = Entities.Find(I => I.Id == credit.Id && I.OrderId == credit.OrderId) != null;
            if (res)
            {
                _orderManager = OrderManager.CreateAsSingleton(PathHelper.OrderPathModel);
                Order order = _orderManager.Entities.Find(I => I.Id == credit.OrderId);
                if (order != null)
                {
                    order.PaymentIds.Remove(credit.Id);
                    _orderManager.Update(order);
                }
                return base.Delete(Entities.FindIndex(I => I.Id == credit.Id));
            }
            return new Result { ResultState = ResultState.Erorr };
        }
        public Result Update(Credit credit)
        {
            return UseTryCatch.Use(() =>
            {
                base.Delete(Entities.FindIndex(I => I.Id == credit.Id));
                Entities.Add(credit);
                Sync();
            });
        }

        public bool Authorized(string name, string surname, int orderId)
        {
            _orderManager = OrderManager.CreateAsSingleton(PathHelper.OrderPathModel);
            bool result = false;
          
            
            Order order = _orderManager.GetById(orderId);
            if (order != null)
            {
                Customer customer = _customerManager.GetById(order.CustomerId);
                if (customer != null)
                {
                    if (customer.Name == name && customer.Surname == surname)
                    {
                        result = true;
                    }
                }
            }

            return result;
        }

    }
}
