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
    public partial class ItemForm : Form
    {
        private ItemManager _itemManager;
        private OrderDetailManager _orderDetailManager;
        public ItemForm()
        {
            InitializeComponent();
            _itemManager = ItemManager.CreateAsSingleton(PathHelper.ItemPathModel);
            _orderDetailManager = OrderDetailManager.CreateAsSingleton(PathHelper.OrderDetailPathModel);
        }

        private void btnItemCreate_Click(object sender, EventArgs e)
        {
            Item item = new Item
            {
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
            Item item = _itemManager.GetById(Int32.Parse(txtItemId.Text));
            item.Description = txtDescription.Text;
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
            OrderDetail orderDetail = _orderDetailManager.Entities.Find(I => I.ItemId == int.Parse(txtItemId.Text));
            orderDetail.ItemId = 0;
            _orderDetailManager.Update(orderDetail);
            Item item = new Item
            {
                Id = int.Parse(txtItemId.Text),
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
                DataGridFillNoItems();
                txtItemId.Text = "";
                txtDescription.Text = "";
            }
        }


        private void DataGridFillForOrdetail(int itemId)
        {
            dtGridList.DataSource = null;
            dtGridList.DataSource = _itemManager.Entities.Find(I => I.Id == itemId).OrderDetails.OrderBy(I => I.Id).ToList();
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
        private void ItemDataGridFill()
        {
            dtGridItem.DataSource = null;
            dtGridItem.DataSource = _itemManager.Entities.OrderBy(I => I.Id).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtItemId.Text) && !string.IsNullOrEmpty(txtOrderDetailId.Text))
            {
                OrderDetail orderDetail = _orderDetailManager.GetById(int.Parse(txtOrderDetailId.Text));
                orderDetail.ItemId = int.Parse(txtItemId.Text);
                Result resultUpdate = _orderDetailManager.Update(orderDetail);
                Item item = _itemManager.GetById(int.Parse(txtItemId.Text));
                item.OrderDetails.Add(orderDetail);
                Result resultAdd = _itemManager.Update(item);
                if (resultUpdate.ResultState == ResultState.Erorr || resultAdd.ResultState == ResultState.Erorr)
                {
                    MessageBox.Show($"Result add:{resultAdd.Message}\nResult update:{resultUpdate.Message}", "Hata işlem yapılamadı");
                }
                else
                {
                    DataGridFillForOrdetail(item.Id);
                    GetCalc(item.Id);

                }
            }
            else
            {
                MessageBox.Show("Item id ve Order Detail id alanları boş geçilemez", "Hata işlem yapılamadı");
            }

        }

        private void dtGridList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrderDetailId.Text = ((DataGridView)sender).SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtItemId.Text) && !string.IsNullOrEmpty(txtOrderDetailId.Text))
            {
                OrderDetail orderDetail = _orderDetailManager.GetById(int.Parse(txtOrderDetailId.Text));
                orderDetail.ItemId = 0;
                Result resultUpdate = _orderDetailManager.Update(orderDetail);
                Item item = _itemManager.GetById(int.Parse(txtItemId.Text));
                item.OrderDetails.RemoveAll(I => I.Id == orderDetail.Id);
                Result resultRemove = _itemManager.Update(item);
                if (resultUpdate.ResultState == ResultState.Erorr || resultRemove.ResultState == ResultState.Erorr)
                {
                    MessageBox.Show($"Result add:{resultRemove.Message}\nResult update:{resultUpdate.Message}", "Hata işlem yapılamadı");
                }
                else
                {
                    DataGridFillForOrdetail(item.Id);
                    GetCalc(item.Id);
                }
            }
            else
            {
                MessageBox.Show("Item id ve Order Detail id alanları boş geçilemez", "Hata işlem yapılamadı");
            }
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            ItemDataGridFill();
            DataGridFillNoItems();
        }

        private void dtGridItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            DataGridViewCellCollection cellCollection = dataGridView.SelectedRows[0].Cells;
            ItemTextboxFill(cellCollection);
            DataGridFillForOrdetail(int.Parse(txtItemId.Text));
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            DataGridFillNoItems();
        }

        private void DataGridFillNoItems()
        {
            dtGridList.DataSource = null;
            dtGridList.DataSource = _orderDetailManager.GetByFilter(I => I.ItemId == 0).OrderBy(I => I.Id).ToList();
        }
    }
}
