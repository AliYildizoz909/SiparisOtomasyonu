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

        public CreditManager(PathModel pathModel) : base(pathModel)
        {

            _customerManager = new CustomerManager(new PathModel { DirectoryName = ConstHelper.customerDirectoryName, FileName = ConstHelper.customerFileName });
        }
        public Credit GetById(int id)
        {
            Credit credit = Entities.FirstOrDefault(I => I.Id == id);
            return credit;
        }
        public override Result Add(Credit entity)
        {
            entity.Id = Entities.Count != 0 ? Entities[Entities.Count - 1].Id + 1 : 1;
            return base.Add(entity);
        }
        public Result Delete(Credit credit)
        {
            if (Entities.Contains(credit))
            {
                return base.Delete(Entities.FindIndex(I => I.Id == credit.Id));
            }
            return new Result { ResultState = ResultState.Erorr };
        }
        public Result Update(Credit credit)
        {
            return UseTryCatch.Use(() =>
            {
                Delete(credit);
                Entities.Add(credit);
                Sync();
            });
        }

        public bool Authorized(string name, string surname, int orderId)
        {
            OrderManager _orderManager = new OrderManager(new PathModel { DirectoryName = ConstHelper.orderDirectoryName, FileName = ConstHelper.orderFileName });
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
