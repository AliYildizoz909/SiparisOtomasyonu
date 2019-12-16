namespace SiparisOtomasyonu.WindowsUI
{
    partial class ItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtGridItem = new System.Windows.Forms.DataGridView();
            this.lblGetWeight = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPriceForQuantity = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnItemDelete = new System.Windows.Forms.Button();
            this.btnItemCreate = new System.Windows.Forms.Button();
            this.btnItemUpdate = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtGridList = new System.Windows.Forms.DataGridView();
            this.txtOrderDetailId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAllList = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtGridItem);
            this.groupBox4.Controls.Add(this.lblGetWeight);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.lblPriceForQuantity);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtItemId);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.btnItemDelete);
            this.groupBox4.Controls.Add(this.btnItemCreate);
            this.groupBox4.Controls.Add(this.btnItemUpdate);
            this.groupBox4.Controls.Add(this.txtDescription);
            this.groupBox4.Location = new System.Drawing.Point(25, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(895, 210);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Item info";
            // 
            // dtGridItem
            // 
            this.dtGridItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridItem.Location = new System.Drawing.Point(410, 30);
            this.dtGridItem.Name = "dtGridItem";
            this.dtGridItem.Size = new System.Drawing.Size(462, 174);
            this.dtGridItem.TabIndex = 62;
            this.dtGridItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridItem_CellDoubleClick);
            // 
            // lblGetWeight
            // 
            this.lblGetWeight.AutoSize = true;
            this.lblGetWeight.Location = new System.Drawing.Point(165, 120);
            this.lblGetWeight.Name = "lblGetWeight";
            this.lblGetWeight.Size = new System.Drawing.Size(19, 13);
            this.lblGetWeight.TabIndex = 60;
            this.lblGetWeight.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(99, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "weight";
            // 
            // lblPriceForQuantity
            // 
            this.lblPriceForQuantity.AutoSize = true;
            this.lblPriceForQuantity.Location = new System.Drawing.Point(165, 150);
            this.lblPriceForQuantity.Name = "lblPriceForQuantity";
            this.lblPriceForQuantity.Size = new System.Drawing.Size(19, 13);
            this.lblPriceForQuantity.TabIndex = 58;
            this.lblPriceForQuantity.Text = "00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(68, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "Price For Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Id";
            // 
            // txtItemId
            // 
            this.txtItemId.Enabled = false;
            this.txtItemId.Location = new System.Drawing.Point(87, 30);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(166, 20);
            this.txtItemId.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 55;
            this.label15.Text = "Description";
            // 
            // btnItemDelete
            // 
            this.btnItemDelete.Location = new System.Drawing.Point(278, 104);
            this.btnItemDelete.Name = "btnItemDelete";
            this.btnItemDelete.Size = new System.Drawing.Size(111, 31);
            this.btnItemDelete.TabIndex = 56;
            this.btnItemDelete.Text = "Delete";
            this.btnItemDelete.UseVisualStyleBackColor = true;
            this.btnItemDelete.Click += new System.EventHandler(this.btnItemDelete_Click);
            // 
            // btnItemCreate
            // 
            this.btnItemCreate.Location = new System.Drawing.Point(278, 30);
            this.btnItemCreate.Name = "btnItemCreate";
            this.btnItemCreate.Size = new System.Drawing.Size(111, 31);
            this.btnItemCreate.TabIndex = 56;
            this.btnItemCreate.Text = "Create";
            this.btnItemCreate.UseVisualStyleBackColor = true;
            this.btnItemCreate.Click += new System.EventHandler(this.btnItemCreate_Click);
            // 
            // btnItemUpdate
            // 
            this.btnItemUpdate.Location = new System.Drawing.Point(278, 67);
            this.btnItemUpdate.Name = "btnItemUpdate";
            this.btnItemUpdate.Size = new System.Drawing.Size(108, 31);
            this.btnItemUpdate.TabIndex = 57;
            this.btnItemUpdate.Text = "Update";
            this.btnItemUpdate.UseVisualStyleBackColor = true;
            this.btnItemUpdate.Click += new System.EventHandler(this.btnItemUpdate_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(87, 56);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(166, 52);
            this.txtDescription.TabIndex = 0;
            // 
            // dtGridList
            // 
            this.dtGridList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridList.Location = new System.Drawing.Point(12, 228);
            this.dtGridList.Name = "dtGridList";
            this.dtGridList.Size = new System.Drawing.Size(933, 349);
            this.dtGridList.TabIndex = 41;
            this.dtGridList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridList_CellDoubleClick);
            // 
            // txtOrderDetailId
            // 
            this.txtOrderDetailId.Enabled = false;
            this.txtOrderDetailId.Location = new System.Drawing.Point(96, 592);
            this.txtOrderDetailId.Name = "txtOrderDetailId";
            this.txtOrderDetailId.Size = new System.Drawing.Size(166, 20);
            this.txtOrderDetailId.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Id";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(300, 583);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 31);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "Add to item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(420, 583);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(111, 31);
            this.btnRemove.TabIndex = 56;
            this.btnRemove.Text = "Remove to item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAllList
            // 
            this.btnAllList.Location = new System.Drawing.Point(537, 583);
            this.btnAllList.Name = "btnAllList";
            this.btnAllList.Size = new System.Drawing.Size(111, 31);
            this.btnAllList.TabIndex = 56;
            this.btnAllList.Text = "No items all list";
            this.btnAllList.UseVisualStyleBackColor = true;
            this.btnAllList.Click += new System.EventHandler(this.btnAllList_Click);
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 624);
            this.Controls.Add(this.dtGridList);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtOrderDetailId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAllList);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblGetWeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPriceForQuantity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnItemDelete;
        private System.Windows.Forms.Button btnItemCreate;
        private System.Windows.Forms.Button btnItemUpdate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridView dtGridList;
        private System.Windows.Forms.TextBox txtOrderDetailId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dtGridItem;
        private System.Windows.Forms.Button btnAllList;
    }
}