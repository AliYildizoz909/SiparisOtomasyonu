namespace SiparisOtomasyonu.WindowsUI
{
    partial class AdminMainForm
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
            this.dtGridItem = new System.Windows.Forms.DataGridView();
            this.dtGridOrderDetail = new System.Windows.Forms.DataGridView();
            this.btnItemManager = new System.Windows.Forms.Button();
            this.btnOrderManager = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCustomerSurname = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCustomerUserName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCustomerPassword = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblItemSubWeight = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblItemId = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
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
            this.lblOrderId = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblOrderDetailId = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCustomerManager = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridOrderDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridItem
            // 
            this.dtGridItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridItem.Location = new System.Drawing.Point(12, 49);
            this.dtGridItem.Name = "dtGridItem";
            this.dtGridItem.Size = new System.Drawing.Size(249, 553);
            this.dtGridItem.TabIndex = 0;
            this.dtGridItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridItem_CellDoubleClick);
            // 
            // dtGridOrderDetail
            // 
            this.dtGridOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtGridOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridOrderDetail.Location = new System.Drawing.Point(267, 49);
            this.dtGridOrderDetail.Name = "dtGridOrderDetail";
            this.dtGridOrderDetail.Size = new System.Drawing.Size(956, 213);
            this.dtGridOrderDetail.TabIndex = 0;
            this.dtGridOrderDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridOrderDetail_CellDoubleClick);
            // 
            // btnItemManager
            // 
            this.btnItemManager.Location = new System.Drawing.Point(121, 12);
            this.btnItemManager.Name = "btnItemManager";
            this.btnItemManager.Size = new System.Drawing.Size(140, 31);
            this.btnItemManager.TabIndex = 1;
            this.btnItemManager.Text = "Go to Item Manager";
            this.btnItemManager.UseVisualStyleBackColor = true;
            this.btnItemManager.Click += new System.EventHandler(this.btnItemManager_Click);
            // 
            // btnOrderManager
            // 
            this.btnOrderManager.Location = new System.Drawing.Point(1020, 12);
            this.btnOrderManager.Name = "btnOrderManager";
            this.btnOrderManager.Size = new System.Drawing.Size(203, 31);
            this.btnOrderManager.TabIndex = 1;
            this.btnOrderManager.Text = "Go to Order Detail Manager";
            this.btnOrderManager.UseVisualStyleBackColor = true;
            this.btnOrderManager.Click += new System.EventHandler(this.btnOrderManager_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Items";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCustomerName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblCustomerSurname);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblCustomerId);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblCustomerAddress);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblCustomerUserName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblCustomerPassword);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(267, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(956, 334);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer info";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerName.Location = new System.Drawing.Point(125, 73);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(30, 24);
            this.lblCustomerName.TabIndex = 33;
            this.lblCustomerName.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(50, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 24);
            this.label11.TabIndex = 33;
            this.label11.Text = "Name :";
            // 
            // lblCustomerSurname
            // 
            this.lblCustomerSurname.AutoSize = true;
            this.lblCustomerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerSurname.Location = new System.Drawing.Point(125, 108);
            this.lblCustomerSurname.Name = "lblCustomerSurname";
            this.lblCustomerSurname.Size = new System.Drawing.Size(30, 24);
            this.lblCustomerSurname.TabIndex = 31;
            this.lblCustomerSurname.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(24, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 24);
            this.label10.TabIndex = 31;
            this.label10.Text = "Surname :";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerId.Location = new System.Drawing.Point(125, 36);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(30, 24);
            this.lblCustomerId.TabIndex = 32;
            this.lblCustomerId.Text = "00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(86, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 24);
            this.label12.TabIndex = 32;
            this.label12.Text = "Id :";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerAddress.Location = new System.Drawing.Point(125, 142);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(30, 24);
            this.lblCustomerAddress.TabIndex = 30;
            this.lblCustomerAddress.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(31, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 24);
            this.label9.TabIndex = 30;
            this.label9.Text = "Address :";
            // 
            // lblCustomerUserName
            // 
            this.lblCustomerUserName.AutoSize = true;
            this.lblCustomerUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerUserName.Location = new System.Drawing.Point(125, 177);
            this.lblCustomerUserName.Name = "lblCustomerUserName";
            this.lblCustomerUserName.Size = new System.Drawing.Size(30, 24);
            this.lblCustomerUserName.TabIndex = 29;
            this.lblCustomerUserName.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(9, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "User name :";
            // 
            // lblCustomerPassword
            // 
            this.lblCustomerPassword.AutoSize = true;
            this.lblCustomerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerPassword.Location = new System.Drawing.Point(125, 213);
            this.lblCustomerPassword.Name = "lblCustomerPassword";
            this.lblCustomerPassword.Size = new System.Drawing.Size(30, 24);
            this.lblCustomerPassword.TabIndex = 28;
            this.lblCustomerPassword.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(19, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "Password :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDescription);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lblItemSubWeight);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lblItemId);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.lblPriceForQuantity);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(481, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 304);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item info";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.Location = new System.Drawing.Point(165, 89);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(27, 20);
            this.lblDescription.TabIndex = 42;
            this.lblDescription.Text = "00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(62, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 20);
            this.label16.TabIndex = 43;
            this.label16.Text = "Description :";
            // 
            // lblItemSubWeight
            // 
            this.lblItemSubWeight.AutoSize = true;
            this.lblItemSubWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblItemSubWeight.Location = new System.Drawing.Point(165, 54);
            this.lblItemSubWeight.Name = "lblItemSubWeight";
            this.lblItemSubWeight.Size = new System.Drawing.Size(27, 20);
            this.lblItemSubWeight.TabIndex = 38;
            this.lblItemSubWeight.Text = "00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(23, 54);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(136, 20);
            this.label18.TabIndex = 39;
            this.label18.Text = "Item Sub Weight :";
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblItemId.Location = new System.Drawing.Point(428, 16);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(27, 20);
            this.lblItemId.TabIndex = 40;
            this.lblItemId.Text = "00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(394, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 20);
            this.label20.TabIndex = 41;
            this.label20.Text = "Id :";
            // 
            // lblPriceForQuantity
            // 
            this.lblPriceForQuantity.AutoSize = true;
            this.lblPriceForQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPriceForQuantity.Location = new System.Drawing.Point(165, 17);
            this.lblPriceForQuantity.Name = "lblPriceForQuantity";
            this.lblPriceForQuantity.Size = new System.Drawing.Size(27, 20);
            this.lblPriceForQuantity.TabIndex = 36;
            this.lblPriceForQuantity.Text = "00";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(16, 17);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(143, 20);
            this.label22.TabIndex = 37;
            this.label22.Text = "Price For Quantity :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSubWeight);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.lblSubTotal);
            this.groupBox3.Controls.Add(this.label40);
            this.groupBox3.Controls.Add(this.lblWeight);
            this.groupBox3.Controls.Add(this.lblTaxStatus);
            this.groupBox3.Controls.Add(this.lblPrice);
            this.groupBox3.Controls.Add(this.lblQuantity);
            this.groupBox3.Controls.Add(this.lblOrderId);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.lblOrderDetailId);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(6, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 175);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Detail info";
            // 
            // lblSubWeight
            // 
            this.lblSubWeight.AutoSize = true;
            this.lblSubWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubWeight.Location = new System.Drawing.Point(275, 120);
            this.lblSubWeight.Name = "lblSubWeight";
            this.lblSubWeight.Size = new System.Drawing.Size(22, 16);
            this.lblSubWeight.TabIndex = 48;
            this.lblSubWeight.Text = "00";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label38.Location = new System.Drawing.Point(187, 120);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(73, 16);
            this.label38.TabIndex = 49;
            this.label38.Text = "Sub weight";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubTotal.Location = new System.Drawing.Point(275, 150);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(22, 16);
            this.lblSubTotal.TabIndex = 46;
            this.lblSubTotal.Text = "00";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label40.Location = new System.Drawing.Point(200, 150);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(60, 16);
            this.label40.TabIndex = 47;
            this.label40.Text = "Sub total";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWeight.Location = new System.Drawing.Point(275, 89);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(22, 16);
            this.lblWeight.TabIndex = 34;
            this.lblWeight.Text = "00";
            // 
            // lblTaxStatus
            // 
            this.lblTaxStatus.AutoSize = true;
            this.lblTaxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaxStatus.Location = new System.Drawing.Point(275, 65);
            this.lblTaxStatus.Name = "lblTaxStatus";
            this.lblTaxStatus.Size = new System.Drawing.Size(22, 16);
            this.lblTaxStatus.TabIndex = 35;
            this.lblTaxStatus.Text = "00";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(275, 39);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(22, 16);
            this.lblPrice.TabIndex = 36;
            this.lblPrice.Text = "00";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.Location = new System.Drawing.Point(275, 12);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(22, 16);
            this.lblQuantity.TabIndex = 37;
            this.lblQuantity.Text = "00";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderId.Location = new System.Drawing.Point(85, 39);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(22, 16);
            this.lblOrderId.TabIndex = 39;
            this.lblOrderId.Text = "00";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(220, 39);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(39, 16);
            this.label23.TabIndex = 45;
            this.label23.Text = "Price";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(13, 41);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 16);
            this.label24.TabIndex = 44;
            this.label24.Text = "Order ıd";
            // 
            // lblOrderDetailId
            // 
            this.lblOrderDetailId.AutoSize = true;
            this.lblOrderDetailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderDetailId.Location = new System.Drawing.Point(85, 16);
            this.lblOrderDetailId.Name = "lblOrderDetailId";
            this.lblOrderDetailId.Size = new System.Drawing.Size(22, 16);
            this.lblOrderDetailId.TabIndex = 38;
            this.lblOrderDetailId.Text = "00";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.Location = new System.Drawing.Point(209, 89);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(50, 16);
            this.label28.TabIndex = 38;
            this.label28.Text = "Weight";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(203, 12);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 16);
            this.label25.TabIndex = 42;
            this.label25.Text = "Quantity";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(50, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(19, 16);
            this.label26.TabIndex = 43;
            this.label26.Text = "Id";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.Location = new System.Drawing.Point(190, 65);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(69, 16);
            this.label27.TabIndex = 41;
            this.label27.Text = "Tax status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(267, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 39);
            this.label4.TabIndex = 2;
            this.label4.Text = "Order Details";
            // 
            // btnCustomerManager
            // 
            this.btnCustomerManager.Location = new System.Drawing.Point(824, 12);
            this.btnCustomerManager.Name = "btnCustomerManager";
            this.btnCustomerManager.Size = new System.Drawing.Size(190, 31);
            this.btnCustomerManager.TabIndex = 1;
            this.btnCustomerManager.Text = "Go to Customer Manager";
            this.btnCustomerManager.UseVisualStyleBackColor = true;
            this.btnCustomerManager.Click += new System.EventHandler(this.btnCustomerManager_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 609);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrderManager);
            this.Controls.Add(this.btnCustomerManager);
            this.Controls.Add(this.btnItemManager);
            this.Controls.Add(this.dtGridOrderDetail);
            this.Controls.Add(this.dtGridItem);
            this.Name = "AdminMainForm";
            this.Text = "Admin Main Form";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridOrderDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridItem;
        private System.Windows.Forms.DataGridView dtGridOrderDetail;
        private System.Windows.Forms.Button btnItemManager;
        private System.Windows.Forms.Button btnOrderManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCustomerSurname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCustomerUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCustomerPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblItemSubWeight;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblPriceForQuantity;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblTaxStatus;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblOrderDetailId;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblSubWeight;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button btnCustomerManager;
    }
}