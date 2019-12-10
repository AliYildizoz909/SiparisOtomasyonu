using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu.Core.Operations.Helpers
{
    public class FileHelper
    {
        private string _filePath;
        private string _fileName;
        private string extension = "json";
        private FileStream fileStream = null;
        private bool result = false;
        public string FullPath { get; }



        public FileHelper(string filePath, string fileName)
        {
            _filePath = filePath;
            _fileName = fileName;
            FullPath = $@"{filePath}\{fileName}.{extension}";

        }

        public bool Create()
        {
            if (!FileExists())
            {
                fileStream = File.Create(FullPath);
                fileStream.Close();
                result = true;
            }

            return result;
        }

        public bool Remove()
        {

            if (FileExists())
            {
                File.Delete(FullPath);
                result = true;
            }
            return result;
        }
        public FileStream GetFileStream()
        {
            if (FileExists())
            {
                fileStream = new FileStream(FullPath, FileMode.Open);
            }
            return fileStream;
        }

        public void FileWrite(string writeText)
        {
            if (FileExists())
            {
                File.WriteAllText(FullPath, writeText);
            }
        }
        public string FileRead()
        {
            string readText = "";
            if (FileExists())
            {
                readText = File.ReadAllText(FullPath);
            }

            return readText;
        }
        public bool FileExists()
        {
            return File.Exists(FullPath);
        }
    }
}
