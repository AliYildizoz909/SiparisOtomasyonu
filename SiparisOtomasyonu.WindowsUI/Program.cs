using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiparisOtomasyonu.Core.Operations.Helpers;

namespace SiparisOtomasyonu.WindowsUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DirectoryHelper directoryHelper = new DirectoryHelper("C:\\", "SiparisOtomasyonuDb");
            if (!directoryHelper.DirectoryExists())
            {
                directoryHelper.Create();
            }
            Application.Run(new CustomerForm());
        }
    }
}
