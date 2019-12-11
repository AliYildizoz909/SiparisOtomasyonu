using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisOtomasyonu.Entities.Entity.Enums;

namespace SiparisOtomasyonu.Entities.Entity
{
    public class Result
    {
        public ResultState ResultState { get; set; }
        public string Message { get; set; }
    }
}
