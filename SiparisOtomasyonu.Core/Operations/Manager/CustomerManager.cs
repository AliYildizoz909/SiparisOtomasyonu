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
    public class CustomerManager : RepositoryBase<Customer>
    {
        private CustomerManager(PathModel pathModel) : base(pathModel)
        {

        }
        private static CustomerManager _customerManager;

        public static CustomerManager CreateAsSingleton(PathModel pathModel)
        {
            if (_customerManager == null)
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager(pathModel);
                }

            }

            return _customerManager;
        }
        public Customer GetById(int id)
        {
            Customer customer = Entities.FirstOrDefault(I => I.Id == id);
            return customer;
        }
        public Result Login(Customer customer)
        {
            Result result = new Result { ResultState = ResultState.Erorr, Message = "Giriş başarısız." };
            Customer user = Entities.Find(I => I.UserName == customer.UserName && I.Password == customer.Password);
            if (user != null)
            {
                result.ResultState = ResultState.Success;
                result.Message = "Giriş başarılı";
            }

            return result;
        }
        public override Result Add(Customer entity)
        {
            entity.Id = Entities.Count != 0 ? Entities[Entities.Count - 1].Id + 1 : 1;
            return base.Add(entity);
        }

        public Result Delete(Customer customer)
        {
            bool res = Entities.Find(I => I.Id == customer.Id && I.Name == customer.Name && I.Surname == customer.Surname) != null;
            if (res)
            {
                return base.Delete(Entities.FindIndex(I => I.Id == customer.Id));
            }
            return new Result { ResultState = ResultState.Erorr };
        }

        public Result Update(Customer customer)
        {
            return UseTryCatch.Use(() =>
            {
                Delete(customer);
                Entities.Add(customer);
                Sync();
            });
        }

    }
}
