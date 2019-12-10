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
        public CustomerManager(PathModel pathModel) : base(pathModel)
        {

        }
        public Customer GetById(int id)
        {
            Customer customer = Entities.FirstOrDefault(I => I.Id == id);
            return customer;
        }
        public Result CustomAdd(Customer customer)
        {
            return UseTryCatch.Use(() =>
            {
                customer.Id = Entities[Entities.Count - 1].Id + 1;
                Entities.Add(customer);
                Sync();
            });
        }
        public Result CustomDelete(Customer customer)
        {
            return UseTryCatch.Use(() =>
            {
                base.Delete(Entities.FindIndex(I => I.Id == customer.Id));
            });
        }
    }
}
