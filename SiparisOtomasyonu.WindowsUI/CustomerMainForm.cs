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
    public partial class CustomerMainForm : Form
    {
        private readonly int _customerId;
        private ItemManager _itemManager;
        private OrderDetailManager _orderDetailManager;
        private CustomerManager _customerManager;
        private OrderManager _orderManager;
        public CustomerMainForm(int customerId)
        {
            _customerId = customerId;
            InitializeComponent();
            _itemManager = ItemManager.CreateAsSingleton(PathHelper.ItemPathModel);
            _orderDetailManager = OrderDetailManager.CreateAsSingleton(PathHelper.OrderDetailPathModel);
            _customerManager = CustomerManager.CreateAsSingleton(PathHelper.CustomerPathModel);
            _orderManager = OrderManager.CreateAsSingleton(PathHelper.OrderPathModel);
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

        private void dtGridOrderDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            DataGridViewCellCollection cellCollection = dataGridView.SelectedRows[0].Cells;
            OrderDetailLabelFill(cellCollection);
        }
        private void OrderDetailLabelFill(DataGridViewCellCollection cellCollection)
        {
            lblOrderDetailId.Text = cellCollection[0].Value.ToString();

            lblQuantity.Text = cellCollection[3].Value.ToString();
            lblPrice.Text = cellCollection[4].Value.ToString();
            lblTaxStatus.Text = cellCollection[5].Value.ToString();
            lblWeight.Text = cellCollection[6].Value.ToString();
            lblSubWeight.Text = cellCollection[7].Value.ToString();
            lblSubTotal.Text = cellCollection[8].Value.ToString();
        }

        private void DataGridFillForOrdetail(int itemId)
        {
            dtGridOrderDetail.DataSource = null;
            dtGridOrderDetail.DataSource = _orderDetailManager.Entities.Join(_orderManager.Entities.Join(
                    _customerManager.GetById(_customerId).OrderIds,
                    order => order.Id, i => i, (order, i) => order), detail => detail.OrderId, order => order.Id,
                (detail, order) => detail).Where(I => I.ItemId == itemId).ToList();
        }

        private void CustomerMainForm_Load(object sender, EventArgs e)
        {
            ItemDataGridFill();
        }

        private void ItemDataGridFill()
        {
            dtGridItem.DataSource = null;
            dtGridItem.DataSource = _itemManager.Entities.Join(_orderDetailManager.Entities.Join(_orderManager.Entities.Join(_customerManager.GetById(_customerId).OrderIds, order => order.Id, i => i, (order, i) => order), detail => detail.OrderId, order => order.Id, (detail, order) => detail.ItemId).Distinct(), item => item.Id, i => i, (item, i) => item).ToList();

        }
    }
}
