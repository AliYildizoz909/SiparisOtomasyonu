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

        private CreditManager _creditManager;
        private CashManager _cashManager;
        private CheckManager _checkManager;
        private OrderDetailManager _orderDetailManager;
        private CustomerManager _customerManager;
        private static OrderManager _orderManager;
        private OrderManager(PathModel pathModel = null) : base(pathModel)
        {
            _customerManager = CustomerManager.CreateAsSingleton(PathHelper.CustomerPathModel);
            _creditManager = CreditManager.CreateAsSingleton(PathHelper.CreditPathModel);
            _cashManager = CashManager.CreateAsSingleton(PathHelper.CashPathModel);
            _checkManager = CheckManager.CreateAsSingleton(PathHelper.CheckPathModel);
            _orderDetailManager = OrderDetailManager.CreateAsSingleton(PathHelper.OrderDetailPathModel);
        }

        public static OrderManager CreateAsSingleton(PathModel pathModel)
        {
            if (_orderManager == null)
            {

                if (_orderManager == null)
                {
                    _orderManager = new OrderManager(pathModel);
                }
            }

            return _orderManager;
        }
        public Order GetById(int id)
        {
            Order order = Entities.FirstOrDefault(I => I.Id == id);
            return order;
        }

        public override Result Add(Order entity)
        {
            entity.Id = Entities.Count != 0 ? Entities[Entities.Count - 1].Id + 1 : 1;
            Customer customer = _customerManager.Entities.Find(I => I.Id == entity.CustomerId);
            if (customer != null)
            {

                customer.OrderIds.Add(entity.Id);
                _customerManager.Update(customer);

            }
            return base.Add(entity);
        }
        public Result Delete(Order order)
        {
            bool res = Entities.Find(I => I.Id == order.Id && I.CustomerId == order.CustomerId) != null;
            if (res)
            {
                Cash cash = _cashManager.Entities.Find(I => I.OrderId == order.Id);
                Check check = _checkManager.Entities.Find(I => I.OrderId == order.Id);
                Credit credit = _creditManager.Entities.Find(I => I.OrderId == order.Id);
                OrderDetail orderDetail = _orderDetailManager.Entities.Find(I => I.OrderId == order.Id);
                Customer customer = _customerManager.Entities.Find(I => I.Id == order.CustomerId);
                if (cash != null)
                {
                    _cashManager.Delete(cash);
                }

                if (check != null)
                {
                    _checkManager.Delete(check);
                }

                if (credit != null)
                {
                    _creditManager.Delete(credit);
                }
                if (orderDetail != null)
                {
                    _orderDetailManager.Delete(orderDetail);
                }
                if (customer != null)
                {
                    int orderId = customer.OrderIds.Find(I => I == order.Id);
                    if (orderId != 0)
                    {
                        customer.OrderIds.Remove(orderId);
                        _customerManager.Update(customer);
                    }
                }

                return base.Delete(Entities.FindIndex(I => I.Id == order.Id));
            }
            return new Result { ResultState = ResultState.Erorr };
        }
        public Result Update(Order order)
        {

            return UseTryCatch.Use(() =>
            {
                base.Delete(Entities.FindIndex(I => I.Id == order.Id));
                Entities.Add(order);
                Sync();
            });
        }
    }
}
