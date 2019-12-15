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
    public class ItemManager : RepositoryBase<Item>
    {
        public ItemManager(PathModel pathModel) : base(pathModel)
        {
        }
        private static ItemManager _itemManager;
        public static ItemManager CreateAsSingleton(PathModel pathModel)
        {
            if (_itemManager == null)
            {
                _itemManager = new ItemManager(pathModel);

            }

            return _itemManager;
        }
        public Item GetById(int id)
        {
            Item item = Entities.FirstOrDefault(I => I.Id == id);
            return item;
        }
        public override Result Add(Item entity)
        {
            entity.Id = Entities.Count != 0 ? Entities[Entities.Count - 1].Id + 1 : 1;

            return base.Add(entity);
        }
        public Result Delete(Item item)
        {
            bool res = Entities.Find(I => I.Id == item.Id) != null;
            if (res)
            {

                return base.Delete(Entities.FindIndex(I => I.Id == item.Id));
            }
            return new Result { ResultState = ResultState.Erorr };
        }
        public Result Update(Item item)
        {

            return UseTryCatch.Use(() =>
            {
                base.Delete(Entities.FindIndex(I => I.Id == item.Id));
                Entities.Add(item);
                Sync();
            });
        }
    }
}
