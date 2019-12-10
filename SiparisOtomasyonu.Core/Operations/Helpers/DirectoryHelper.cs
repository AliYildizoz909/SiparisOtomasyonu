using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu.Core.Operations.Helpers
{
    public class DirectoryHelper
    {
        private string _directoryPath;
        private string _directoryName;

        private DirectoryInfo directoryInfo = null;
        public string FullPath { get; }

        public DirectoryHelper(string directoryPath, string directoryName)
        {
            _directoryPath = directoryPath;
            _directoryName = directoryName;
            FullPath = $@"{directoryPath}\{directoryName}";
        }

        public DirectoryInfo Create()
        {
            if (!DirectoryExists())
            {
                directoryInfo = Directory.CreateDirectory(FullPath);
            }

            return directoryInfo;
        }

        public bool Remove()
        {
            bool result = false;
            if (DirectoryExists())
            {
                Directory.Delete(FullPath);
                result = true;
            }
            return result;
        }

        public bool DirectoryExists()
        {
            return Directory.Exists(FullPath);
        }

        public DirectoryInfo GetDirectoryInfo()
        {
            if (Directory.Exists(FullPath))
            {
                directoryInfo = new DirectoryInfo(FullPath);

            }
            return directoryInfo;
        }
    }
}
