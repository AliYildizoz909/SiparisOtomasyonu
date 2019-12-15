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
using SiparisOtomasyonu.Entities.Entity.Enums;

namespace SiparisOtomasyonu.WindowsUI
{
    public partial class UserAdminForm : Form
    {
        private UserAdminManager _userAdminManager;
        public UserAdminForm()
        {
            InitializeComponent();
            _userAdminManager = UserAdminManager.CreateAsSingleton(PathHelper.UserAdminPathModel);
        }

        private void dtGridList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            DataGridViewCellCollection cellCollection = dataGridView.SelectedRows[0].Cells;
            TextboxFill(cellCollection);
            DataGridFill();
        }
        private void TextboxFill(DataGridViewCellCollection cellCollection)
        {
            txtId.Text = cellCollection[0].Value.ToString();
            txtPassword.Text = cellCollection[1].Value.ToString();
            txtUserName.Text = cellCollection[2].Value.ToString();
        }
        private void TextboxClear()
        {
            txtId.Text = "";
            txtPassword.Text = "";
            txtUserName.Text = "";
        }
        private void DataGridFill()
        {
            dtGridList.DataSource = null;
            dtGridList.DataSource =
                _userAdminManager.Entities.OrderBy(I => I.Id).ToList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Result result = _userAdminManager.Add(new UserAdmin
            {
                Password = txtPassword.Text,
                UserName = txtUserName.Text
            });
            if (result.ResultState == ResultState.Erorr)
            {
                MessageBox.Show(result.Message, "Hata işlem yapılamadı");
            }
            else
            {
                DataGridFill();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Result result = _userAdminManager.Delete(new UserAdmin
            {
                Id = int.Parse(txtId.Text)
            });
            if (result.ResultState == ResultState.Erorr)
            {
                MessageBox.Show(result.Message, "Hata işlem yapılamadı");
            }
            else
            {
                DataGridFill();
                TextboxClear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Result result = _userAdminManager.Update(new UserAdmin
            {
                Id = int.Parse(txtId.Text),
                Password = txtPassword.Text,
                UserName = txtUserName.Text
            });
            if (result.ResultState == ResultState.Erorr)
            {
                MessageBox.Show(result.Message, "Hata işlem yapılamadı");
            }
            else
            {

                DataGridFill();
                TextboxClear();
            }
        }

        private void btnCustomerClear_Click(object sender, EventArgs e)
        {
            TextboxClear();
        }

        private void UserAdminForm_Load(object sender, EventArgs e)
        {
            DataGridFill();
        }
    }
}
