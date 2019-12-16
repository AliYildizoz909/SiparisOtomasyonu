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
    public partial class LoginForm : Form
    {
        private CustomerManager _customerManager;
        private UserAdminManager _userAdminManager;
        public LoginForm()
        {
            InitializeComponent();
            _customerManager = CustomerManager.CreateAsSingleton(PathHelper.CustomerPathModel);
            _userAdminManager = UserAdminManager.CreateAsSingleton(PathHelper.UserAdminPathModel);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            if (!rdAdmin.Checked)
            {
                Result result = _userAdminManager.Login(new UserAdmin
                {
                    UserName = userName,
                    Password = password
                });
                if (result.ResultState == ResultState.Success)
                {
                    foreach (Control item in ((Panel)Application.OpenForms["MDIForm"].Controls["pnlMenu"]).Controls)
                    {
                        if (item is Button)
                        {
                            item.Enabled = true;
                        }
                    }

                    Form form = Application.OpenForms["MDIForm"];
                    AdminMainForm adminMainForm = new AdminMainForm();
                    adminMainForm.MdiParent = form;
                    adminMainForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Message, "Hata işlem yapılamadı");
                }
            }
            else if (!rdCustomer.Checked)
            {
                Result result = _customerManager.Login(new Customer
                {
                    UserName = userName,
                    Password = password
                });
                if (result.ResultState == ResultState.Success)
                {

                }
                else
                {
                    MessageBox.Show(result.Message, "Hata işlem yapılamadı");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı tipini seçiniz", "Hata işlem yapılamadı");
            }

        }
    }
}
