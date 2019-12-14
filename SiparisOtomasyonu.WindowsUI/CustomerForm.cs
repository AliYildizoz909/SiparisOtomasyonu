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
using SiparisOtomasyonu.Core.Operations;
using SiparisOtomasyonu.Core.Operations.Helpers;
using SiparisOtomasyonu.Entities.Entity.Abstract;
using SiparisOtomasyonu.Entities.Entity.Enums;

namespace SiparisOtomasyonu.WindowsUI
{
    public partial class CustomerForm : Form
    {
        private CustomerManager _customerManager;
        private OrderManager _orderManager;

        public CustomerForm()
        {
            InitializeComponent();

            _customerManager = CustomerManager.CreateAsSingleton(ConstHelper.CustomerPathModel);
            _orderManager = OrderManager.CreateAsSingleton(ConstHelper.OrderPathModel);
        }



        private void CustomerForm_Load(object sender, EventArgs e)
        {
            DataGridCustomerFill();
        }

        private void DataGridCustomerFill()
        {

            dtGridList.DataSource = null;
            dtGridList.DataSource = _customerManager.Entities.OrderBy(I => I.Id).ToList();
        }
        private void DataGridCustomerFill(List<Customer> customers)
        {

            dtGridList.DataSource = null;
            dtGridList.DataSource = customers.OrderBy(I => I.Id).ToList();
        }
        private void DataGridOrderFill()
        {

            dtGridOrders.DataSource = null;
            dtGridOrders.DataSource =
                _orderManager.Entities.Where(I => I.CustomerId == int.Parse(txtId.Text)).OrderBy(I => I.Id).ToList();
        }
        private void CustomerTextboxFill(DataGridViewCellCollection cellCollection)
        {
            cmbStatus.Text = "";
            txtId.Text = cellCollection[0].Value.ToString();

            txtName.Text = cellCollection[1].Value.ToString();
            txtSurname.Text = cellCollection[2].Value.ToString();
            txtAddress.Text = cellCollection[3].Value.ToString();
            txtPassword.Text = cellCollection[4].Value.ToString();
            txtUserName.Text = cellCollection[5].Value.ToString();
            txtCustomerId.Text = cellCollection[0].Value.ToString();
        }
        private void TextboxCustomerClear()
        {
            dtGridOrders.DataSource = null;
            txtFind.Text = "";
            txtId.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
            txtUserName.Text = "";
            txtOrderId.Text = "";
            cmbStatus.Text = "";
            txtCustomerId.Text = "";
        }

        private void dtGridList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            DataGridViewCellCollection cellCollection = dataGridView.SelectedRows[0].Cells;
            CustomerTextboxFill(cellCollection);
            DataGridOrderFill();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Result result = _customerManager.Delete(new Customer
            {
                Id = int.Parse(txtId.Text)
            });
            if (result.ResultState == ResultState.Erorr)
            {
                MessageBox.Show(result.Message, "Hata işlem yapılamadı");
            }
            else
            {
                DataGridCustomerFill();
                TextboxCustomerClear();
            }

        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            List<Customer> customers = _customerManager.Entities.Where(I => I.Name.Contains(txtFind.Text)).ToList();
            DataGridCustomerFill(customers);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Result result = _customerManager.Update(new Customer
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Address = txtAddress.Text,
                Password = txtPassword.Text,
                UserName = txtUserName.Text
            });
            if (result.ResultState == ResultState.Erorr)
            {
                MessageBox.Show(result.Message, "Hata işlem yapılamadı");
            }
            else
            {
                DataGridCustomerFill();
                TextboxCustomerClear();
            }

        }
        private void btnOrderCreate_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtId.Text))
            {
                Status status = SelectedStatus();

                Result result = _orderManager.Add(new Order
                {
                    CustomerId = int.Parse(txtCustomerId.Text),
                    Status = status,
                    Date = Convert.ToDateTime(dtPickerOrder.Value.ToShortDateString())
                });
                if (result.ResultState == ResultState.Erorr)
                {
                    MessageBox.Show(result.Message, "Hata işlem yapılamadı");
                }
                else
                {
                    DataGridOrderFill();
                }
            }
            else
            {
                MessageBox.Show("Customer Id boş geçilemez", "Hata işlem yapılamadı");
            }

        }

        private Status SelectedStatus()
        {
            Status status = Status.NewOrder;
            switch (cmbStatus.Text)
            {
                case "New Order":
                    status = Status.NewOrder;
                    break;
                case "Wait":
                    status = Status.Wait;
                    break;
                case "Road":
                    status = Status.Road;
                    break;
                case "Reached":
                    status = Status.Reached;
                    break;
                case "Cancelled":
                    status = Status.Cancelled;
                    break;
            }

            return status;
        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {

            Result result = _orderManager.Delete(new Order()
            {
                Id = int.Parse(txtOrderId.Text),
                CustomerId = int.Parse(txtCustomerId.Text),
                Date = dtPickerOrder.Value,
                Status = SelectedStatus()
            });
            if (result.ResultState == ResultState.Erorr)
            {
                MessageBox.Show(result.Message, "Hata işlem yapılamadı");
            }
            else
            {
                TextboxOrderClear();
                DataGridOrderFill();
            }
        }

        private void btnOrderUpdate_Click(object sender, EventArgs e)
        {
            Result result = _orderManager.Update(new Order
            {
                Id = int.Parse(txtOrderId.Text),
                CustomerId = int.Parse(txtCustomerId.Text),
                Status = SelectedStatus(),
                Date = Convert.ToDateTime(dtPickerOrder.Value.ToShortDateString())
            });
            if (result.ResultState == ResultState.Erorr)
            {
                MessageBox.Show(result.Message, "Hata işlem yapılamadı");
            }
            else
            {
                DataGridOrderFill();
            }
        }

        private void dtGridOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            DataGridViewCellCollection cellCollection = dataGridView.SelectedRows[0].Cells;
            OrderTextboxFill(cellCollection);
            DataGridOrderFill();
        }

        private void OrderTextboxFill(DataGridViewCellCollection cellCollection)
        {
            txtOrderId.Text = cellCollection[0].Value.ToString();
            dtPickerOrder.Value = (DateTime)cellCollection[1].Value;
            cmbStatus.SelectedText = cellCollection[2].Value.ToString();
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            OrderDetailForm detailForm = new OrderDetailForm(int.Parse(txtOrderId.Text));
            detailForm.Show();
        }

        private void btnOrderClear_Click(object sender, EventArgs e)
        {
            TextboxOrderClear();
        }

        private void TextboxOrderClear()
        {
            dtGridOrders.DataSource = null;
            txtOrderId.Text = "";
            txtCustomerId.Text = "";
            cmbStatus.Text = "";

        }

        private void btnCustomerClear_Click(object sender, EventArgs e)
        {
            TextboxCustomerClear();
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            Result result = _customerManager.Add(new Customer
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Address = txtAddress.Text,
                Password = txtPassword.Text,
                UserName = txtUserName.Text
            });
            if (result.ResultState == ResultState.Erorr)
            {
                MessageBox.Show(result.Message, "Hata işlem yapılamadı");
            }
            else
            {
                DataGridCustomerFill();
            }
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm(0, int.Parse(txtOrderId.Text));
            paymentForm.Show();
        }
    }
}
