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
using SiparisOtomasyonu.Entities.Entity.Abstract;
using SiparisOtomasyonu.Entities.Entity.Enums;

namespace SiparisOtomasyonu.WindowsUI
{
    public partial class PaymentForm : Form
    {
        private CreditManager _creditManager;
        private CheckManager _checkManager;
        private CashManager _cashManager;
        private int _orderId;
        private decimal _amount;
        public PaymentForm(decimal amount = 0, int orderId = 0)
        {

            _amount = amount;
            _orderId = orderId;
            InitializeComponent();
            _creditManager = new CreditManager(new PathModel { DirectoryName = ConstHelper.paymentsDirectoryName, FileName = ConstHelper.creditFileName });
            _cashManager = new CashManager(new PathModel { DirectoryName = ConstHelper.paymentsDirectoryName, FileName = ConstHelper.cashFileName });
            _checkManager = new CheckManager(new PathModel { DirectoryName = ConstHelper.paymentsDirectoryName, FileName = ConstHelper.checkFileName });
        }

        void DataGridCashFill()
        {
            dtGridCash.DataSource = null;
            if (_orderId == 0)
            {
                dtGridCash.DataSource = _cashManager.Entities;
            }
            else
            {
                dtGridCash.DataSource = _cashManager.Entities.Where(I => I.OrderId == _orderId).OrderBy(I => I.Id).ToList();
            }



        }
        void DataGridCheckFill()
        {
            dtGridCheckList.DataSource = null;
            if (_orderId == 0)
            {
                dtGridCheckList.DataSource = _checkManager.Entities;
            }
            else
            {
                dtGridCheckList.DataSource = _checkManager.Entities.Where(I => I.OrderId == _orderId).OrderBy(I => I.Id).ToList();
            }
        }
        void DataGridCreditFill()
        {
            dtGridCreditList.DataSource = null;
            if (_orderId == 0)
            {
                dtGridCreditList.DataSource = _creditManager.Entities;
            }
            else
            {
                dtGridCreditList.DataSource = _creditManager.Entities.Where(I => I.OrderId == _orderId).OrderBy(I => I.Id).ToList();
            }
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = _orderId.ToString();
            txtCashAmount.Text = _amount.ToString();
            txtCreditAmount.Text = _amount.ToString();
            txtCheckAmount.Text = _amount.ToString();
            DataGridCashFill();
            DataGridCheckFill();
            DataGridCreditFill();
        }

        private void btnCashCreate_Click(object sender, EventArgs e)
        {
            if (_orderId != 0)
            {

                Result result = _cashManager.Add(new Cash
                {
                    Amount = decimal.Parse(txtCashAmount.Text),
                    OrderId = _orderId,
                });
                if (result.ResultState == ResultState.Erorr)
                {
                    MessageBox.Show(result.Message, "Hata işlem yapılamadı");
                }
                else
                {
                    DataGridCashFill();
                }
            }
            else
            {
                MessageBox.Show("Order Id boş geçilemez", "Hata işlem yapılamadı");
            }
        }

        private void btnCheckCreate_Click(object sender, EventArgs e)
        {
            if (_orderId != 0)
            {
                bool isAuth = _checkManager.Authorized(txtCheckName.Text, txtCheckSurname.Text, _orderId);
                if (isAuth)
                {
                    Result result = _checkManager.Add(new Check
                    {
                        Amount = decimal.Parse(txtCashAmount.Text),
                        OrderId = _orderId,
                        BankId = int.Parse(txtBankId.Text),
                        Name = txtCheckName.Text,
                        Surname = txtCheckSurname.Text
                    });
                    if (result.ResultState == ResultState.Erorr)
                    {
                        MessageBox.Show(result.Message, "Hata işlem yapılamadı");
                    }
                    else
                    {
                        DataGridCheckFill();
                    }
                }
                else
                {
                    MessageBox.Show("Kimlik doğrulama başarısız", "Hata işlem yapılamadı");
                }

            }
            else
            {
                MessageBox.Show("Order Id boş geçilemez", "Hata işlem yapılamadı");
            }

        }

        private void btnCreditCreate_Click(object sender, EventArgs e)
        {
            if (_orderId != 0)
            {
                bool isAuth = _creditManager.Authorized(txtCreditName.Text, txtCheckSurname.Text, _orderId);
                if (isAuth)
                {
                    Result result = _creditManager.Add(new Credit
                    {
                        Amount = decimal.Parse(txtCashAmount.Text),
                        OrderId = _orderId,
                        Cvc = short.Parse(txtCVC.Text),
                        CardNumber = txtCardNumber.Text,
                        Name = txtCheckName.Text,
                        Surname = txtCheckSurname.Text
                    });
                    if (result.ResultState == ResultState.Erorr)
                    {
                        MessageBox.Show(result.Message, "Hata işlem yapılamadı");
                    }
                    else
                    {
                        DataGridCreditFill();
                    }
                }
                else
                {
                    MessageBox.Show("Kimlik doğrulama başarısız", "Hata işlem yapılamadı");
                }
            }
            else
            {
                MessageBox.Show("Order Id boş geçilemez", "Hata işlem yapılamadı");
            }
        }

        private void dtGridCash_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            DataGridViewCellCollection cellCollection = dataGridView.SelectedRows[0].Cells;
            CashTextboxFill(cellCollection);
        }

        private void CashTextboxFill(DataGridViewCellCollection cellCollection)
        {
            txtCashId.Text = cellCollection[0].Value.ToString();

            txtCashAmount.Text = cellCollection[2].Value.ToString();
        }

        private void dtGridCheckList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            DataGridViewCellCollection cellCollection = dataGridView.SelectedRows[0].Cells;
            CheckTextboxFill(cellCollection);
        }

        private void CheckTextboxFill(DataGridViewCellCollection cellCollection)
        {
            txtCheckId.Text = cellCollection[0].Value.ToString();

            txtCheckAmount.Text = cellCollection[2].Value.ToString();
            txtCheckName.Text = cellCollection[3].Value.ToString();
            txtCheckSurname.Text = cellCollection[4].Value.ToString();
            txtBankId.Text = cellCollection[5].Value.ToString();
        }

        private void dtGridCreditList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            DataGridViewCellCollection cellCollection = dataGridView.SelectedRows[0].Cells;
            CreditTextboxFill(cellCollection);
        }

        private void CreditTextboxFill(DataGridViewCellCollection cellCollection)
        {
            txtCheckId.Text = cellCollection[0].Value.ToString();

            txtCheckAmount.Text = cellCollection[2].Value.ToString();
            txtCardNumber.Text = cellCollection[3].Value.ToString();
            txtCVC.Text = cellCollection[4].Value.ToString();
            txtCreditName.Text = cellCollection[5].Value.ToString();
            txtCreditSurname.Text = cellCollection[6].Value.ToString();
        }

        private void btnCheckClear_Click(object sender, EventArgs e)
        {

        }

        private void btnCreditClear_Click(object sender, EventArgs e)
        {

        }
    }
}

