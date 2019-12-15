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
    public class UserAdminManager : RepositoryBase<UserAdmin>
    {
        private UserAdminManager(PathModel pathModel) : base(pathModel)
        {
        }

        private static UserAdminManager _userAdminManager;
        public static UserAdminManager CreateAsSingleton(PathModel pathModel)
        {
            if (_userAdminManager == null)
            {
                if (_userAdminManager == null)
                {
                    _userAdminManager = new UserAdminManager(pathModel);
                }

            }

            return _userAdminManager;
        }
        public UserAdmin GetById(int id)
        {
            UserAdmin userAdmin = Entities.FirstOrDefault(I => I.Id == id);
            return userAdmin;
        }

        public Result Login(UserAdmin userAdmin)
        {
            Result result = new Result { ResultState = ResultState.Erorr, Message = "Giriş başarısız." };
            UserAdmin user = Entities.Find(I => I.UserName == userAdmin.UserName && I.Password == userAdmin.Password);
            if (user != null)
            {
                result.ResultState = ResultState.Success;
                result.Message = "Giriş başarılı";
            }

            return result;
        }

        public override Result Add(UserAdmin entity)
        {
            entity.Id = Entities.Count != 0 ? Entities[Entities.Count - 1].Id + 1 : 1;
            return base.Add(entity);
        }

        public Result Delete(UserAdmin userAdmin)
        {
            bool res = Entities.Find(I => I.Id == userAdmin.Id) != null;
            if (res)
            {
                return base.Delete(Entities.FindIndex(I => I.Id == userAdmin.Id));
            }
            return new Result { ResultState = ResultState.Erorr };
        }

        public Result Update(UserAdmin userAdmin)
        {
            return UseTryCatch.Use(() =>
            {
                Delete(userAdmin);
                Entities.Add(userAdmin);
                Sync();
            });
        }
    }
}
