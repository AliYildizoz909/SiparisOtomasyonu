using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisOtomasyonu.Entities.Entity.Abstract;

namespace SiparisOtomasyonu.Entities.Entity
{
    public class UserAdmin : IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
