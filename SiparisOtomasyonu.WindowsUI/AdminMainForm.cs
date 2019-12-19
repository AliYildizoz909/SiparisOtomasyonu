using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiparisOtomasyonu.Core.Operations.Helpers;
using SiparisOtomasyonu.Core.Operations.Manager;
using SiparisOtomasyonu.Entities.Entity;

namespace SiparisOtomasyonu.WindowsUI
{
    public partial class AdminMainForm : Form
    {
        private ItemManager _itemManager;
        private CustomerManager _customerManager;
        public AdminMainForm()
        {
            InitializeComponent();
            _itemManager = ItemManager.CreateAsSingleton(PathHelper.ItemPathModel);
            _customerManager = CustomerManager.CreateAsSingleton(PathHelper.CustomerPathModel);
        }

        private void dtGridItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            DataGridViewCellCollection cellCollection = dataGridView.SelectedRows[0].Cells;
            ItemLabelFill(cellCollection);
            DataGridFillForOrdetail(int.Parse(lblItemId.Text));
        }

        private void ItemLabelFill(DataGridViewCellCollection cellCollection)
        {
            lblItemId.Text = cellCollection[0].Value.ToString();
            lblDescription.Text = cellCollection[1].Value.ToString();
            GetCalc(int.Parse(lblItemId.Text));
        }

        private void GetCalc(int itemId)
        {
            Item item = _itemManager.GetById(itemId);
            lblItemSubWeight.Text = item.GetWeight().ToString();
            lblPriceForQuantity.Text = item.GetPriceForQuantity().ToString();
        }

        private void DataGridFillForOrdetail(int itemId)
        {
            dtGridOrderDetail.DataSource = null;
            dtGridOrderDetail.DataSource = _itemManager.Entities.Find(I => I.Id == itemId).OrderDetails.OrderBy(I => I.Id).ToList();
        }

        private void dtGridOrderDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            DataGridViewCellCollection cellCollection = dataGridView.SelectedRows[0].Cells;
            OrderDetailLabelFill(cellCollection);
            CustomerLabelFill(int.Parse(lblOrderId.Text));
        }

        private void CustomerLabelFill(int orderId)
        {
            Customer customer = _customerManager.Entities.Find(I => I.OrderIds.Contains(orderId));
            lblCustomerId.Text = customer.Id.ToString();
            lblCustomerName.Text = customer.Name;
            lblCustomerSurname.Text = customer.Surname;
            lblCustomerAddress.Text = customer.Address;
            lblCustomerPassword.Text = customer.Password;
            lblCustomerUserName.Text = customer.UserName;
        }

        private void OrderDetailLabelFill(DataGridViewCellCollection cellCollection)
        {
            lblOrderDetailId.Text = cellCollection[0].Value.ToString();

            lblOrderId.Text = cellCollection[2].Value.ToString();
            lblQuantity.Text = cellCollection[3].Value.ToString();
            lblPrice.Text = cellCollection[4].Value.ToString();
            lblTaxStatus.Text = cellCollection[5].Value.ToString();
            lblWeight.Text = cellCollection[6].Value.ToString();
            lblSubWeight.Text = cellCollection[7].Value.ToString();
            lblSubTotal.Text = cellCollection[8].Value.ToString();
        }

        private void ItemDataGridFill()
        {
            dtGridItem.DataSource = null;
            dtGridItem.DataSource = _itemManager.Entities.OrderBy(I => I.Id).ToList();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            ItemDataGridFill();
        }

        private void btnCustomerManager_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["MDIForm"];
            CustomerForm customerForm = new CustomerForm();
            customerForm.MdiParent = form;
            customerForm.Show();
        }

        private void btnOrderManager_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["MDIForm"];
            OrderDetailForm detailForm = new OrderDetailForm();
            detailForm.MdiParent = form;
            detailForm.Show();
        }

        private void btnItemManager_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["MDIForm"];
            ItemForm itemForm = new ItemForm();
            itemForm.MdiParent = form;
            itemForm.Show();
        }
    }
}
