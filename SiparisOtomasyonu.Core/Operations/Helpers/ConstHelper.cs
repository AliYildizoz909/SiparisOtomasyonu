using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisOtomasyonu.Entities.Entity;

namespace SiparisOtomasyonu.Core.Operations.Helpers
{
    public static class ConstHelper
    {
        //Customer
        public const string customerDirectoryName = "TbCustomer";
        public const string customerFileName = "Customer";
        public static PathModel CustomerPathModel { get; set; } = new PathModel { FileName = customerFileName, DirectoryName = customerDirectoryName };

        //Payments
        public const string paymentsDirectoryName = "TbPayments";

        public const string creditFileName = "Credit";
        public static PathModel CreditPathModel { get; set; } = new PathModel { FileName = creditFileName, DirectoryName = paymentsDirectoryName };

        public const string checkFileName = "Check";
        public static PathModel CheckPathModel { get; set; } = new PathModel { FileName = checkFileName, DirectoryName = paymentsDirectoryName };

        public const string cashFileName = "Cash";
        public static PathModel CashPathModel { get; set; } = new PathModel { FileName = cashFileName, DirectoryName = paymentsDirectoryName };


        //OrderDetail
        public const string orderDetailDirectoryName = "TbOrderDetail";
        public const string orderDetailFileName = "OrderDetail";
        public static PathModel OrderDetailPathModel { get; set; } = new PathModel { FileName = orderDetailFileName, DirectoryName = orderDetailDirectoryName };


        //Order
        public const string orderDirectoryName = "TbOrder";
        public const string orderFileName = "Order";
        public static PathModel OrderPathModel { get; set; } = new PathModel { FileName = orderFileName, DirectoryName = orderDirectoryName };

    }
}
