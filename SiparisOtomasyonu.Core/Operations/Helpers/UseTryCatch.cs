using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                return Result.Success;

            }
            catch (Exception e)
            {
                return Result.Erorr;
            }
        }
    }
}
