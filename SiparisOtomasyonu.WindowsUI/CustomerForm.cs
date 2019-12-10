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

namespace SiparisOtomasyonu.WindowsUI
{
    public partial class CustomerForm : Form
    {
        private CustomerManager _customerManager;
        private const string directoryName = "TbCustomer";
        private const string fileName = "Customer";
        public CustomerForm()
        {
            InitializeComponent();
            PathModel model = new PathModel { DirectoryName = directoryName, FileName = fileName };
            _customerManager = new CustomerManager(model);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _customerManager.CustomAdd(new Customer
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Address = txtAddress.Text,
                Password = txtPassword.Text,
                UserName = txtUserName.Text
            });
            DataFill();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            DataFill();
        }

        private void DataFill()
        {
            dtGridList.DataSource = null;
            dtGridUDList.DataSource = null;
            dtGridList.DataSource = _customerManager.Entities;
            dtGridUDList.DataSource = _customerManager.Entities;
        }

        private void dtGridUDList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            txtId.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
        
            txtUDName.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtUDSurname.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtUDAddress.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtUDPassword.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            txtUDUserName.Text = dataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _customerManager.CustomDelete(new Customer
            {
                Id = int.Parse(txtId.Text),
                Name =     txtUDName.Text,
                Surname =  txtUDSurname.Text,
                Address =  txtUDAddress.Text,
                Password = txtUDPassword.Text,
                UserName = txtUDUserName.Text
            });
            DataFill();
        }

    }
}
