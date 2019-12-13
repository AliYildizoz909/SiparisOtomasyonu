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
        public CashManager(PathModel pathModel) : base(pathModel)
        {
        }
        public Cash GetById(int id)
        {
            Cash cash = Entities.FirstOrDefault(I => I.Id == id);
            return cash;
        }
        public override Result Add(Cash entity)
        {
            entity.Id = Entities.Count != 0 ? Entities[Entities.Count - 1].Id + 1 : 1;
            return base.Add(entity);
        }
        public Result Delete(Cash cash)
        {
            if (Entities.Contains(cash))
            {
                return base.Delete(Entities.FindIndex(I => I.Id == cash.Id));
            }
            return new Result { ResultState = ResultState.Erorr };
        }
        public Result Update(Cash cash)
        {
            return UseTryCatch.Use(() =>
            {
                Delete(cash);
                Entities.Add(cash);
                Sync();
            });
        }
    }
}
