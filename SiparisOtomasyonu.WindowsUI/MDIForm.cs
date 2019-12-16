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
    public partial class MDIForm : Form
    {
        private Form T;
        public MDIForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            if (Application.OpenForms["LoginForm"] != null)
            {
                T = Application.OpenForms["LoginForm"];
                T.Focus();

            }
            else
            {
                T = new LoginForm();
                T.MdiParent = this;
                T.Show();
            }
        }

        private void btnAdminForm_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AdminMainForm"] != null)
            {
                T = Application.OpenForms["AdminMainForm"];
                T.Focus();

            }
            else
            {
                T = new AdminMainForm();
                T.MdiParent = this;
                T.Show();
            }
        }

        private void btnCustomerManager_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CustomerForm"] != null)
            {
                T = Application.OpenForms["CustomerForm"];
                T.Focus();

            }
            else
            {
                T = new CustomerForm();
                T.MdiParent = this;
                T.Show();
            }
        }

        private void btnOrderManager_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["OrderDetailForm"] != null)
            {
                T = Application.OpenForms["OrderDetailForm"];
                T.Focus();

            }
            else
            {
                T = new OrderDetailForm();
                T.MdiParent = this;
                T.Show();
            }
        }

        private void btnItemManager_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ItemForm"] != null)
            {
                T = Application.OpenForms["ItemForm"];
                T.Focus();

            }
            else
            {
                T = new ItemForm();
                T.MdiParent = this;
                T.Show();
            }
        }

        private void btnUserManager_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["UserAdminForm"] != null)
            {
                T = Application.OpenForms["UserAdminForm"];
                T.Focus();

            }
            else
            {
                T = new UserAdminForm();
                T.MdiParent = this;
                T.Show();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<Form> forms = Application.OpenForms.Cast<Form>().ToList();
            for (int i = 0; i < forms.Count; i++)
            {
                Form form = forms[i];
                if (form != this)
                {
                    form.Close();
                }
            }



            foreach (Control item in ((Panel)Application.OpenForms["MDIForm"].Controls["pnlMenu"]).Controls)
            {
                if (item is Button)
                {
                    item.Enabled = false;
                }
            }

            T = new LoginForm();
            T.MdiParent = this;
            T.Show();


        }

        private void btnPaymentManager_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["PaymentForm"] != null)
            {
                T = Application.OpenForms["PaymentForm"];
                T.Focus();

            }
            else
            {
                T = new PaymentForm();
                T.MdiParent = this;
                T.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            List<Form> forms = Application.OpenForms.Cast<Form>().ToList();
            for (int i = 0; i < forms.Count; i++)
            {
                Form form = forms[i];
                if (form != this)
                {
                    form.Close();
                }
            }
        }
    }
}
