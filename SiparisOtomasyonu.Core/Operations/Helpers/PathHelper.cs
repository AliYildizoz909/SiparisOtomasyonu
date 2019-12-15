using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisOtomasyonu.Entities.Entity;

namespace SiparisOtomasyonu.Core.Operations.Helpers
{
    public static class PathHelper
    {
        //Customer
        private const string customerDirectoryName = "TbCustomer";
        private const string customerFileName = "Customer";
        public static PathModel CustomerPathModel { get; } = new PathModel { FileName = customerFileName, DirectoryName = customerDirectoryName };

        //Payments
        private const string paymentsDirectoryName = "TbPayments";

        private const string creditFileName = "Credit";
        public static PathModel CreditPathModel { get; } = new PathModel { FileName = creditFileName, DirectoryName = paymentsDirectoryName };

        private const string checkFileName = "Check";
        public static PathModel CheckPathModel { get; } = new PathModel { FileName = checkFileName, DirectoryName = paymentsDirectoryName };

        private const string cashFileName = "Cash";
        public static PathModel CashPathModel { get; } = new PathModel { FileName = cashFileName, DirectoryName = paymentsDirectoryName };


        //OrderDetail
        private const string orderDetailDirectoryName = "TbOrderDetail";
        private const string orderDetailFileName = "OrderDetail";
        public static PathModel OrderDetailPathModel { get; } = new PathModel { FileName = orderDetailFileName, DirectoryName = orderDetailDirectoryName };


        //Order
        private const string orderDirectoryName = "TbOrder";
        private const string orderFileName = "Order";
        public static PathModel OrderPathModel { get; } = new PathModel { FileName = orderFileName, DirectoryName = orderDirectoryName };

        //UserAdmin
        private const string userAdminDirectoryName = "TbUserAdmin";
        private const string userAdminFileName = "UserAdmin";
        public static PathModel UserAdminPathModel { get; } = new PathModel { FileName = userAdminFileName, DirectoryName = userAdminDirectoryName };

        //Item
        private const string itemDirectoryName = "TbItem";
        private const string itemrFileName = "Item";
        public static PathModel ItemPathModel { get; } = new PathModel { FileName = itemrFileName, DirectoryName = itemDirectoryName };

    }
}
