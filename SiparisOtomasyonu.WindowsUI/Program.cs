using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiparisOtomasyonu.Core.Operations.Helpers;
using SiparisOtomasyonu.Core.Operations.Manager;
using SiparisOtomasyonu.Entities.Entity;

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
            UserAdminManager manager = UserAdminManager.CreateAsSingleton(PathHelper.UserAdminPathModel);
            UserAdmin admin = manager.Entities.Find(I => I.UserName == "admin" && I.Password == "12345");
            if (admin == null)
            {
                manager.Add(new UserAdmin { UserName = "admin", Password = "12345" });
            }
            Application.Run(new MDIForm());
        }
    }
}
