using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisOtomasyonu.Entities.Entity;
using SiparisOtomasyonu.Entities.Entity.Enums;

namespace SiparisOtomasyonu.Core.Operations.Helpers
{
    public class UseTryCatch
    {
        public static Result Use(Action action)
        {
            try
            {
                action.Invoke();
                return new Result { ResultState = ResultState.Success };

            }
            catch (Exception e)
            {
                return new Result { ResultState = ResultState.Erorr, Message = e.Message };
            }
        }
    }
}
