using SiparisOtomasyonu.Core.Operations.Manager;
using SiparisOtomasyonu.Entities.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiparisOtomasyonu.Entities.Entity.Abstract;
using SiparisOtomasyonu.Entities.Entity.Enums;

namespace SiparisOtomasyonu.WindowsUI
{
    public partial class CustomerForm : Form
    {
        private CustomerManager _customerManager;
        private OrderManager _orderManager;
        private OrderDetailManager _orderDetailManager;
        private PaymentManager _paymentManager;
        private const string customerDirectoryName = "TbCustomer";
        private const string customerFileName = "Customer";
        private const string orderDirectoryName = "TbOrder";
        private const string orderFileName = "Order";
        private const string paymentDirectoryName = "TbPayment";
        private const string paymentFileName = "Payment";
        private const string orderDetailDirectoryName = "TbOrderDetail";
        private const string orderDetailFileName = "OrderDetail";
        public CustomerForm()
        {
            InitializeComponent();

            _customerManager = new CustomerManager(new PathModel { DirectoryName = customerDirectoryName, FileName = customerFileName });
            _orderManager = new OrderManager(new PathModel { DirectoryName = orderDirectoryName, FileName = orderFileName });
            _orderDetailManager = new OrderDetailManager(new PathModel { DirectoryName = orderDetailDirectoryName, FileName = orderDetailFileName });
            _paymentManager = new PaymentManager(new PathModel { DirectoryName = paymentDirectoryName, FileName = paymentFileName });

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _customerManager.Add(new Customer
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Address = txtAddress.Text,
                Password = txtPassword.Text,
                UserName = txtUserName.Text
            });
            DataGridCustomerFill();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            DataGridCustomerFill();
        }

        private void DataGridCustomerFill()
        {
            dtGridList.DataSource = null;
            dtGridList.DataSource = _customerManager.Entities;
        }
        private void DataGridCustomerFill(List<Customer> customer)
        {
            dtGridList.DataSource = null;
            dtGridList.DataSource = customer;
        }
        private void DataGridOrderFill()
        {
            dtGridOrders.DataSource = null;
            dtGridOrders.DataSource =
                _orderManager.Entities.Where(I => I.CustomerId == int.Parse(txtId.Text)).ToList();
        }
        private void TextboxFill(DataGridViewCellCollection cellCollection)
        {
            txtId.Text = cellCollection[0].Value.ToString();

            txtName.Text = cellCollection[1].Value.ToString();
            txtSurname.Text = cellCollection[2].Value.ToString();
            txtAddress.Text = cellCollection[3].Value.ToString();
            txtPassword.Text = cellCollection[4].Value.ToString();
            txtUserName.Text = cellCollection[5].Value.ToString();
            txtCustomerId.Text = cellCollection[0].Value.ToString();
        }
        private void TextboxClear()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
            txtUserName.Text = "";
        }
        private void dtGridList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            DataGridViewCellCollection cellCollection = dataGridView.SelectedRows[0].Cells;
            TextboxFill(cellCollection);
            DataGridOrderFill();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _customerManager.Delete(new Customer
            {
                Id = int.Parse(txtId.Text)
            });

            DataGridCustomerFill();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _customerManager.Update(new Customer
            {
                Id = int.Parse(txtId.Text)
            });
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            List<Customer> customers = _customerManager.Entities.Where(I => I.Name.Contains(txtFind.Text)).ToList();
            DataGridCustomerFill(customers);
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            _customerManager.Update(new Customer
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Address = txtAddress.Text,
                Password = txtPassword.Text,
                UserName = txtUserName.Text
            });
            DataGridCustomerFill();
        }
        private void btnOrderCreate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                Status status = Status.NewOrder;
                switch (cmbStatus.SelectedText)
                {
                    case "New Order":
                        status = Status.NewOrder;
                        break; ;
                    case "Wait":
                        status = Status.Wait;
                        break; ;
                    case "Road":
                        status = Status.Road;
                        break; ;
                    case "Reached":
                        status = Status.Reached;
                        break; ;
                    case "Cancelled":
                        status = Status.Cancelled;
                        break; ;
                }

                _orderManager.Add(new Order
                {
                    CustomerId = int.Parse(txtCustomerId.Text),
                    Status = status,
                    Date = dtPickerOrder.Value
                });
                DataGridOrderFill();
            }
        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            _orderDetailManager.Entities.RemoveAll((I => I.OrderId == int.Parse(txtOrderId.Text)));
            _paymentManager.Entities.RemoveAll(I => I.OrderId == int.Parse(txtOrderId.Text));
        }
    }
}
