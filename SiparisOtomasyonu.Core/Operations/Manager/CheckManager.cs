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
    public class CheckManager : RepositoryBase<Check>
    {
        private CustomerManager _customerManager;
        private OrderManager _orderManager;
        private CheckManager(PathModel pathModel) : base(pathModel)
        {
            _customerManager = CustomerManager.CreateAsSingleton(new PathModel { DirectoryName = ConstHelper.customerDirectoryName, FileName = ConstHelper.customerFileName });
        }
        private static CheckManager _checkManager;
        public static CheckManager CreateAsSingleton(PathModel pathModel)
        {
            if (_checkManager == null)
            {
                _checkManager = new CheckManager(pathModel);

            }

            return _checkManager;
        }
        public Check GetById(int id)
        {
            Check check = Entities.FirstOrDefault(I => I.Id == id);
            return check;
        }
        public override Result Add(Check entity)
        {
            entity.Id = Entities.Count != 0 ? Entities[Entities.Count - 1].Id + 1 : 1;
            _orderManager = OrderManager.CreateAsSingleton(ConstHelper.OrderPathModel);
            Order order = _orderManager.Entities.Find(I => I.Id == entity.OrderId);
            if (order != null)
            {
                order.PaymentIds.Add(entity.Id);
                _orderManager.Update(order);
            }
            return base.Add(entity);
        }
        public Result Delete(Check check)
        {
            bool res = Entities.Find(I => I.Id == check.Id && I.OrderId == check.OrderId) != null;
            if (res)
            {
                _orderManager = OrderManager.CreateAsSingleton(ConstHelper.OrderPathModel);
                Order order = _orderManager.Entities.Find(I => I.Id == check.OrderId);
                if (order != null)
                {
                    order.PaymentIds.Remove(check.Id);
                    _orderManager.Update(order);
                }
                return base.Delete(Entities.FindIndex(I => I.Id == check.Id));
            }
            return new Result { ResultState = ResultState.Erorr };
        }
        public Result Update(Check check)
        {
            return UseTryCatch.Use(() =>
            {
                base.Delete(Entities.FindIndex(I => I.Id == check.Id));
                Entities.Add(check);
                Sync();
            });
        }
        public bool Authorized(string name, string surname, int orderId)
        {
            _orderManager = OrderManager.CreateAsSingleton(ConstHelper.OrderPathModel);
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
