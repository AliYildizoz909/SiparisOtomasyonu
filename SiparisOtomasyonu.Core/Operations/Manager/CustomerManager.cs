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

        public override Result Add(Customer entity)
        {
            entity.Id = Entities.Count != 0 ? Entities[Entities.Count - 1].Id + 1 : 1;
            return base.Add(entity);
        }

        public Result Delete(Customer customer)
        {
            return base.Delete(Entities.FindIndex(I => I.Id == customer.Id));
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
