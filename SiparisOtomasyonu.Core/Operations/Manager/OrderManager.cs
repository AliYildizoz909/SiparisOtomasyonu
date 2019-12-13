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
        public OrderManager(PathModel pathModel) : base(pathModel)
        {
            _creditManager = new CreditManager(new PathModel { DirectoryName = ConstHelper.paymentsDirectoryName, FileName = ConstHelper.creditFileName });
            _cashManager = new CashManager(new PathModel { DirectoryName = ConstHelper.paymentsDirectoryName, FileName = ConstHelper.cashFileName });
            _checkManager = new CheckManager(new PathModel { DirectoryName = ConstHelper.paymentsDirectoryName, FileName = ConstHelper.checkFileName });
            _orderDetailManager = new OrderDetailManager(new PathModel { DirectoryName = ConstHelper.orderDetailDirectoryName, FileName = ConstHelper.orderDetailFileName });
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
            Cash cash = _cashManager.Entities.Find(I => I.OrderId == order.Id);
            Check check = _checkManager.Entities.Find(I => I.OrderId == order.Id);
            Credit credit = _creditManager.Entities.Find(I => I.OrderId == order.Id);
            OrderDetail orderDetail = _orderDetailManager.Entities.Find(I => I.OrderId == order.Id);
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

            if (Entities.Contains(order))
            {
                return base.Delete(Entities.FindIndex(I => I.Id == order.Id));
            }
            return new Result { ResultState = ResultState.Erorr };
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
