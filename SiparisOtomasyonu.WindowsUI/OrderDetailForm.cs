using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
    public partial class OrderDetailForm : Form
    {
        private OrderDetailManager _orderDetailManager;
        private ItemManager _itemManager;
        private int _orderId;
        public OrderDetailForm(int orderId = 0)
        {
            _orderId = orderId;
            InitializeComponent();
            _orderDetailManager = OrderDetailManager.CreateAsSingleton(PathHelper.OrderDetailPathModel);
            _itemManager = ItemManager.CreateAsSingleton(PathHelper.ItemPathModel);
        }

        private void dtGridList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            DataGridViewCellCollection cellCollection = dataGridView.SelectedRows[0].Cells;
            OrderDetailTextboxFill(cellCollection);
        }

        private void OrderDetailTextboxFill(DataGridViewCellCollection cellCollection)
        {
            cmbTax.Text = "";
            txtId.Text = cellCollection[0].Value.ToString();

            txtOrderDetailtemId.Text = cellCollection[1].Value.ToString();
            txtOrderId.Text = cellCollection[2].Value.ToString();
            nudQuantity.Text = cellCollection[3].Value.ToString();
            nudPrice.Text = cellCollection[4].Value.ToString();
            cmbTax.Text = cellCollection[5].Value.ToString();
            nudWeight.Text = cellCollection[6].Value.ToString();
            lblSubWeight.Text = cellCollection[7].Value.ToString();
            lblSubTotal.Text = cellCollection[8].Value.ToString();
        }

        private void OrderDetailForm_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = _orderId.ToString();
            DataGridFill();

        }

        private void DataGridFill()
        {
            dtGridList.DataSource = null;
            if (_orderId == 0)
            {
                dtGridList.DataSource = _orderDetailManager.Entities.OrderBy(I => I.Id).ToList();
            }
            else
            {
                dtGridList.DataSource = _orderDetailManager.Entities.Where(I => I.OrderId == _orderId).ToList().OrderBy(I => I.Id).ToList();
            }


        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (_orderId != 0)
            {
                OrderDetail orderDetail = new OrderDetail
                {
                    OrderId = int.Parse(txtOrderId.Text),
                    ItemId = 0,
                    Price = nudPrice.Value,
                    Quantity = int.Parse(nudQuantity.Text),
                    Weight = nudWeight.Value,
                    TaxStatus = SelectedTaxStatus()
                };
                lblSubTotal.Text = orderDetail.SubTotal.ToString();
                lblSubWeight.Text = orderDetail.SubWeight.ToString();
                Result result = _orderDetailManager.Add(orderDetail);
                if (result.ResultState == ResultState.Erorr)
                {
                    MessageBox.Show(result.Message, "Hata işlem yapılamadı");
                }
                else
                {
                    DataGridFill();
                }
            }
            else
            {
                MessageBox.Show("Order id ve Item id boş geçilemez", "Hata işlem yapılamadı");
            }

        }

        private TaxStatus SelectedTaxStatus()
        {
            TaxStatus taxStatus = TaxStatus.Tax18;
            switch (cmbTax.Text)
            {
                case "Tax18":
                    taxStatus = TaxStatus.Tax18;
                    break;
                case "Tax2":
                    taxStatus = TaxStatus.Tax2;
                    break;
            }

            return taxStatus;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OrderDetail orderDetail = new OrderDetail
            {
                Id = int.Parse(txtId.Text),
                OrderId = int.Parse(txtOrderId.Text),
                ItemId = int.Parse(txtOrderDetailtemId.Text),
                Price = nudPrice.Value,
                Quantity = int.Parse(nudQuantity.Text),
                Weight = nudWeight.Value,
                TaxStatus = SelectedTaxStatus()
            };
            lblSubTotal.Text = orderDetail.SubTotal.ToString();
            lblSubWeight.Text = orderDetail.SubWeight.ToString();
            Result result = _orderDetailManager.Update(orderDetail);
            if (result.ResultState == ResultState.Erorr)
            {
                MessageBox.Show(result.Message, "Hata işlem yapılamadı");
            }
            else
            {
                DataGridFill();
                TextBoxClear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OrderDetail orderDetail = new OrderDetail
            {
                Id = int.Parse(txtId.Text),
                OrderId = int.Parse(txtOrderId.Text),
                ItemId = int.Parse(txtOrderDetailtemId.Text),
            };
            Result result = _orderDetailManager.Delete(orderDetail);
            if (result.ResultState == ResultState.Erorr)
            {
                MessageBox.Show(result.Message, "Hata işlem yapılamadı");
            }
            else
            {
                DataGridFill();
                TextBoxClear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TextBoxClear();
        }

        private void TextBoxClear()
        {
            txtOrderId.Text = "";
            txtOrderDetailtemId.Text = "";
            txtId.Text = "";
            nudPrice.Text = "";
            nudQuantity.Text = "";
            nudWeight.Text = "";
            cmbTax.Text = "";
            lblSubTotal.Text = "00";
            lblSubWeight.Text = "00";
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["MDIForm"];
            PaymentForm paymentForm = new PaymentForm(decimal.Parse(lblSubTotal.Text), int.Parse(txtOrderId.Text)); paymentForm.MdiParent = form;
            paymentForm.Show();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["MDIForm"];
            ItemForm itemForm = new ItemForm();
            itemForm.MdiParent = form;
            itemForm.Show();
        }
    }
}
