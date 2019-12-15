namespace SiparisOtomasyonu.WindowsUI
{
    partial class OrderDetailForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbTax = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSubWeight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtGridList = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnItemDelete = new System.Windows.Forms.Button();
            this.btnItemCreate = new System.Windows.Forms.Button();
            this.btnItemUpdate = new System.Windows.Forms.Button();
            this.dtGridItem = new System.Windows.Forms.DataGridView();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtOrderDetailtemId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGetWeight = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPriceForQuantity = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridList)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridItem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnPayments);
            this.groupBox1.Controls.Add(this.txtOrderDetailtemId);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.cmbTax);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudWeight);
            this.groupBox1.Controls.Add(this.nudPrice);
            this.groupBox1.Controls.Add(this.nudQuantity);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblSubWeight);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblSubTotal);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtOrderId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 349);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Detail info";
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(142, 273);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(111, 31);
            this.btnPayments.TabIndex = 64;
            this.btnPayments.Text = "Go to payments";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(210, 320);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 23);
            this.btnClear.TabIndex = 63;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbTax
            // 
            this.cmbTax.FormattingEnabled = true;
            this.cmbTax.Items.AddRange(new object[] {
            "Tax2",
            "Tax18"});
            this.cmbTax.Location = new System.Drawing.Point(87, 150);
            this.cmbTax.Name = "cmbTax";
            this.cmbTax.Size = new System.Drawing.Size(169, 21);
            this.cmbTax.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Price";
            // 
            // nudWeight
            // 
            this.nudWeight.Location = new System.Drawing.Point(87, 177);
            this.nudWeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(169, 20);
            this.nudWeight.TabIndex = 33;
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(87, 124);
            this.nudPrice.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(169, 20);
            this.nudPrice.TabIndex = 33;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(87, 98);
            this.nudQuantity.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(169, 20);
            this.nudQuantity.TabIndex = 33;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(15, 251);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 29);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(16, 214);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(111, 31);
            this.btnCreate.TabIndex = 30;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 28);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Order id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Quantity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Id";
            // 
            // lblSubWeight
            // 
            this.lblSubWeight.AutoSize = true;
            this.lblSubWeight.Location = new System.Drawing.Point(207, 214);
            this.lblSubWeight.Name = "lblSubWeight";
            this.lblSubWeight.Size = new System.Drawing.Size(19, 13);
            this.lblSubWeight.TabIndex = 23;
            this.lblSubWeight.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Sub weight";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tax status";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(207, 244);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(19, 13);
            this.lblSubTotal.TabIndex = 22;
            this.lblSubTotal.Text = "00";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(87, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(169, 20);
            this.txtId.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Sub total";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Enabled = false;
            this.txtOrderId.Location = new System.Drawing.Point(87, 72);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(169, 20);
            this.txtOrderId.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Weight";
            // 
            // dtGridList
            // 
            this.dtGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridList.Location = new System.Drawing.Point(290, 228);
            this.dtGridList.Name = "dtGridList";
            this.dtGridList.Size = new System.Drawing.Size(846, 349);
            this.dtGridList.TabIndex = 37;
            this.dtGridList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridList_CellDoubleClick);
            // 
            // groupBox4
            // 
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
            this.groupBox4.Controls.Add(this.dtGridItem);
            this.groupBox4.Controls.Add(this.txtDescription);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(785, 210);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Item info";
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
            // dtGridItem
            // 
            this.dtGridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridItem.Location = new System.Drawing.Point(395, 19);
            this.dtGridItem.Name = "dtGridItem";
            this.dtGridItem.Size = new System.Drawing.Size(375, 181);
            this.dtGridItem.TabIndex = 30;
            this.dtGridItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridItem_CellDoubleClick);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(87, 56);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(166, 52);
            this.txtDescription.TabIndex = 0;
            // 
            // txtOrderDetailtemId
            // 
            this.txtOrderDetailtemId.Enabled = false;
            this.txtOrderDetailtemId.Location = new System.Drawing.Point(87, 46);
            this.txtOrderDetailtemId.Name = "txtOrderDetailtemId";
            this.txtOrderDetailtemId.Size = new System.Drawing.Size(169, 20);
            this.txtOrderDetailtemId.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Item id";
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
            // OrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 583);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtGridList);
            this.Name = "OrderDetailForm";
            this.Text = "Order Detail Form";
            this.Load += new System.EventHandler(this.OrderDetailForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridList)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtGridList;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTax;
        private System.Windows.Forms.Label lblSubWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnItemDelete;
        private System.Windows.Forms.Button btnItemCreate;
        private System.Windows.Forms.Button btnItemUpdate;
        private System.Windows.Forms.DataGridView dtGridItem;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrderDetailtemId;
        private System.Windows.Forms.Label lblGetWeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPriceForQuantity;
        private System.Windows.Forms.Label label14;
    }
}