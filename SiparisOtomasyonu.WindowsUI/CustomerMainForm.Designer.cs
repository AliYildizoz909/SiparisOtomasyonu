namespace SiparisOtomasyonu.WindowsUI
{
    partial class CustomerMainForm
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
            this.dtGridOrderDetail = new System.Windows.Forms.DataGridView();
            this.dtGridItem = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblItemSubWeight = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblPriceForQuantity = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSubWeight = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblTaxStatus = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblItemId = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblOrderDetailId = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridItem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridOrderDetail
            // 
            this.dtGridOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridOrderDetail.Location = new System.Drawing.Point(262, 51);
            this.dtGridOrderDetail.Name = "dtGridOrderDetail";
            this.dtGridOrderDetail.Size = new System.Drawing.Size(798, 213);
            this.dtGridOrderDetail.TabIndex = 1;
            this.dtGridOrderDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridOrderDetail_CellDoubleClick);
            // 
            // dtGridItem
            // 
            this.dtGridItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridItem.Location = new System.Drawing.Point(7, 51);
            this.dtGridItem.Name = "dtGridItem";
            this.dtGridItem.Size = new System.Drawing.Size(249, 377);
            this.dtGridItem.TabIndex = 2;
            this.dtGridItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridItem_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(264, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "My Order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "My Items";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblItemId);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.lblDescription);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lblItemSubWeight);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lblPriceForQuantity);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(262, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 158);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item info";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.Location = new System.Drawing.Point(154, 22);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(27, 20);
            this.lblDescription.TabIndex = 42;
            this.lblDescription.Text = "00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(51, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 20);
            this.label16.TabIndex = 43;
            this.label16.Text = "Description :";
            // 
            // lblItemSubWeight
            // 
            this.lblItemSubWeight.AutoSize = true;
            this.lblItemSubWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblItemSubWeight.Location = new System.Drawing.Point(154, 95);
            this.lblItemSubWeight.Name = "lblItemSubWeight";
            this.lblItemSubWeight.Size = new System.Drawing.Size(27, 20);
            this.lblItemSubWeight.TabIndex = 38;
            this.lblItemSubWeight.Text = "00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(12, 95);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(136, 20);
            this.label18.TabIndex = 39;
            this.label18.Text = "Item Sub Weight :";
            // 
            // lblPriceForQuantity
            // 
            this.lblPriceForQuantity.AutoSize = true;
            this.lblPriceForQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPriceForQuantity.Location = new System.Drawing.Point(154, 58);
            this.lblPriceForQuantity.Name = "lblPriceForQuantity";
            this.lblPriceForQuantity.Size = new System.Drawing.Size(27, 20);
            this.lblPriceForQuantity.TabIndex = 36;
            this.lblPriceForQuantity.Text = "00";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(5, 58);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(143, 20);
            this.label22.TabIndex = 37;
            this.label22.Text = "Price For Quantity :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSubWeight);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.lblOrderDetailId);
            this.groupBox3.Controls.Add(this.lblSubTotal);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label40);
            this.groupBox3.Controls.Add(this.lblWeight);
            this.groupBox3.Controls.Add(this.lblTaxStatus);
            this.groupBox3.Controls.Add(this.lblPrice);
            this.groupBox3.Controls.Add(this.lblQuantity);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(335, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 94);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Detail info";
            // 
            // lblSubWeight
            // 
            this.lblSubWeight.AutoSize = true;
            this.lblSubWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubWeight.Location = new System.Drawing.Point(391, 44);
            this.lblSubWeight.Name = "lblSubWeight";
            this.lblSubWeight.Size = new System.Drawing.Size(22, 16);
            this.lblSubWeight.TabIndex = 48;
            this.lblSubWeight.Text = "00";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label38.Location = new System.Drawing.Point(303, 44);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(73, 16);
            this.label38.TabIndex = 49;
            this.label38.Text = "Sub weight";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubTotal.Location = new System.Drawing.Point(391, 74);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(22, 16);
            this.lblSubTotal.TabIndex = 46;
            this.lblSubTotal.Text = "00";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label40.Location = new System.Drawing.Point(316, 74);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(60, 16);
            this.label40.TabIndex = 47;
            this.label40.Text = "Sub total";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWeight.Location = new System.Drawing.Point(391, 13);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(22, 16);
            this.lblWeight.TabIndex = 34;
            this.lblWeight.Text = "00";
            // 
            // lblTaxStatus
            // 
            this.lblTaxStatus.AutoSize = true;
            this.lblTaxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaxStatus.Location = new System.Drawing.Point(213, 74);
            this.lblTaxStatus.Name = "lblTaxStatus";
            this.lblTaxStatus.Size = new System.Drawing.Size(22, 16);
            this.lblTaxStatus.TabIndex = 35;
            this.lblTaxStatus.Text = "00";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(213, 48);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(22, 16);
            this.lblPrice.TabIndex = 36;
            this.lblPrice.Text = "00";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.Location = new System.Drawing.Point(213, 21);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(22, 16);
            this.lblQuantity.TabIndex = 37;
            this.lblQuantity.Text = "00";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(158, 48);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(39, 16);
            this.label23.TabIndex = 45;
            this.label23.Text = "Price";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.Location = new System.Drawing.Point(325, 13);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(50, 16);
            this.label28.TabIndex = 38;
            this.label28.Text = "Weight";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(141, 21);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 16);
            this.label25.TabIndex = 42;
            this.label25.Text = "Quantity";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.Location = new System.Drawing.Point(128, 74);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(69, 16);
            this.label27.TabIndex = 41;
            this.label27.Text = "Tax status";
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblItemId.Location = new System.Drawing.Point(154, 128);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(27, 20);
            this.lblItemId.TabIndex = 45;
            this.lblItemId.Text = "00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(117, 128);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 20);
            this.label20.TabIndex = 46;
            this.label20.Text = "Id :";
            // 
            // lblOrderDetailId
            // 
            this.lblOrderDetailId.AutoSize = true;
            this.lblOrderDetailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderDetailId.Location = new System.Drawing.Point(54, 21);
            this.lblOrderDetailId.Name = "lblOrderDetailId";
            this.lblOrderDetailId.Size = new System.Drawing.Size(22, 16);
            this.lblOrderDetailId.TabIndex = 44;
            this.lblOrderDetailId.Text = "00";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(19, 21);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(19, 16);
            this.label26.TabIndex = 47;
            this.label26.Text = "Id";
            // 
            // CustomerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 436);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGridOrderDetail);
            this.Controls.Add(this.dtGridItem);
            this.Name = "CustomerMainForm";
            this.Text = "CustomerMainForm";
            this.Load += new System.EventHandler(this.CustomerMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridItem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridOrderDetail;
        private System.Windows.Forms.DataGridView dtGridItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblItemSubWeight;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblPriceForQuantity;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSubWeight;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblTaxStatus;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblOrderDetailId;
        private System.Windows.Forms.Label label26;
    }
}