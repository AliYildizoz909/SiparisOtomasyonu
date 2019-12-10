using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisOtomasyonu.Entities.Entity.Abstract;

namespace SiparisOtomasyonu.Entities.Entity
{
    public class PathModel
    {
        private const string defaultPath = @"C:\SiparisOtomasyonuDb";
        public string Path { get; set; } = defaultPath;
        public string FileName { get; set; }
        public string DirectoryName { get; set; }
    }
}
