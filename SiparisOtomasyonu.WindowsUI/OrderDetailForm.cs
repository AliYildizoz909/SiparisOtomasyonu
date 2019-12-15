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

            txtOrderId.Text = cellCollection[1].Value.ToString();
            nudQuantity.Text = cellCollection[2].Value.ToString();
            nudPrice.Text = cellCollection[3].Value.ToString();
            cmbTax.Text = cellCollection[4].Value.ToString();
            nudWeight.Text = cellCollection[5].Value.ToString();
            lblSubWeight.Text = cellCollection[6].Value.ToString();
            lblSubTotal.Text = cellCollection[7].Value.ToString();
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
            if (_orderId != 0 && !string.IsNullOrEmpty(txtOrderDetailtemId.Text))
            {
                OrderDetail orderDetail = new OrderDetail
                {
                    OrderId = int.Parse(txtOrderId.Text),
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
                OrderId = int.Parse(txtOrderId.Text)
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
            PaymentForm paymentForm = new PaymentForm(decimal.Parse(lblSubTotal.Text), int.Parse(txtOrderId.Text));
            paymentForm.Show();
        }

        private void dtGridItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            DataGridViewCellCollection cellCollection = dataGridView.SelectedRows[0].Cells;
            ItemTextboxFill(cellCollection);
            DataGridFillForOrdetail(int.Parse(txtItemId.Text));
        }

        private void DataGridFillForOrdetail(int itemId)
        {
            dtGridList.DataSource = null;
            dtGridList.DataSource = _itemManager.Entities.Find(I => I.Id == itemId).OrderDetails.OrderBy(I => I.Id);

        }

        private void ItemTextboxFill(DataGridViewCellCollection cellCollection)
        {
            txtItemId.Text = cellCollection[0].Value.ToString();
            txtDescription.Text = cellCollection[1].Value.ToString();
            GetCalc(int.Parse(txtItemId.Text));
        }

        private void GetCalc(int itemId)
        {
            Item item = _itemManager.GetById(itemId);
            lblGetWeight.Text = item.GetWeight().ToString();
            lblPriceForQuantity.Text = item.GetPriceForQuantity().ToString();
        }

        private void btnItemCreate_Click(object sender, EventArgs e)
        {
            Item item = new Item
            {
                Id = int.Parse(txtId.Text),
                Description = txtDescription.Text
            };
            Result result = _itemManager.Add(item);
            if (result.ResultState == ResultState.Erorr)
            {
                MessageBox.Show(result.Message, "Hata işlem yapılamadı");
            }
            else
            {
                ItemDataGridFill();
                txtItemId.Text = "";
                txtDescription.Text = "";
            }
        }

        private void btnItemUpdate_Click(object sender, EventArgs e)
        {
            Item item = new Item
            {
                Id = int.Parse(txtId.Text),
                Description = txtDescription.Text
            };
            Result result = _itemManager.Update(item);
            if (result.ResultState == ResultState.Erorr)
            {
                MessageBox.Show(result.Message, "Hata işlem yapılamadı");
            }
            else
            {
                ItemDataGridFill();
                txtItemId.Text = "";
                txtDescription.Text = "";
            }
        }

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            Item item = new Item
            {
                Id = int.Parse(txtId.Text),
                Description = txtDescription.Text
            };
            Result result = _itemManager.Delete(item);
            if (result.ResultState == ResultState.Erorr)
            {
                MessageBox.Show(result.Message, "Hata işlem yapılamadı");
            }
            else
            {
                ItemDataGridFill();
                txtItemId.Text = "";
                txtDescription.Text = "";
            }
        }

        private void ItemDataGridFill()
        {
            dtGridItem.DataSource = null;
            dtGridItem.DataSource = _itemManager.Entities.OrderBy(I => I.Id);
        }
    }
}
