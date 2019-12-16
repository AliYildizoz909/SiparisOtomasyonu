namespace SiparisOtomasyonu.WindowsUI
{
    partial class PaymentForm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCashId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCashAmount = new System.Windows.Forms.TextBox();
            this.dtGridCash = new System.Windows.Forms.DataGridView();
            this.btnCashCreate = new System.Windows.Forms.Button();
            this.btnCashUpdate = new System.Windows.Forms.Button();
            this.btnCashDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCheckId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtGridCheckList = new System.Windows.Forms.DataGridView();
            this.txtCheckAmount = new System.Windows.Forms.TextBox();
            this.btnCheckClear = new System.Windows.Forms.Button();
            this.btCheckUpdate = new System.Windows.Forms.Button();
            this.btnCheckDelete = new System.Windows.Forms.Button();
            this.btnCheckCreate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBankId = new System.Windows.Forms.TextBox();
            this.txtCheckSurname = new System.Windows.Forms.TextBox();
            this.txtCheckName = new System.Windows.Forms.TextBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtGridCreditList = new System.Windows.Forms.DataGridView();
            this.txtCreditId = new System.Windows.Forms.TextBox();
            this.btnCreditClear = new System.Windows.Forms.Button();
            this.txtCreditAmount = new System.Windows.Forms.TextBox();
            this.btnCreditUpdate = new System.Windows.Forms.Button();
            this.btnCreditDelete = new System.Windows.Forms.Button();
            this.btnCreditCreate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.txtCreditSurname = new System.Windows.Forms.TextBox();
            this.txtCreditName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCash)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCheckList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCreditList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtOrderId);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1090, 745);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment info";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtCashId);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtCashAmount);
            this.groupBox4.Controls.Add(this.dtGridCash);
            this.groupBox4.Controls.Add(this.btnCashCreate);
            this.groupBox4.Controls.Add(this.btnCashUpdate);
            this.groupBox4.Controls.Add(this.btnCashDelete);
            this.groupBox4.Location = new System.Drawing.Point(5, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(642, 179);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cash info";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Id";
            // 
            // txtCashId
            // 
            this.txtCashId.Enabled = false;
            this.txtCashId.Location = new System.Drawing.Point(107, 19);
            this.txtCashId.Name = "txtCashId";
            this.txtCashId.Size = new System.Drawing.Size(169, 20);
            this.txtCashId.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Amount";
            // 
            // txtCashAmount
            // 
            this.txtCashAmount.Location = new System.Drawing.Point(107, 45);
            this.txtCashAmount.Name = "txtCashAmount";
            this.txtCashAmount.Size = new System.Drawing.Size(169, 20);
            this.txtCashAmount.TabIndex = 41;
            // 
            // dtGridCash
            // 
            this.dtGridCash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCash.Location = new System.Drawing.Point(289, 19);
            this.dtGridCash.Name = "dtGridCash";
            this.dtGridCash.Size = new System.Drawing.Size(345, 154);
            this.dtGridCash.TabIndex = 40;
            this.dtGridCash.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridCash_CellDoubleClick);
            // 
            // btnCashCreate
            // 
            this.btnCashCreate.Location = new System.Drawing.Point(121, 135);
            this.btnCashCreate.Name = "btnCashCreate";
            this.btnCashCreate.Size = new System.Drawing.Size(102, 28);
            this.btnCashCreate.TabIndex = 31;
            this.btnCashCreate.Text = "Create";
            this.btnCashCreate.UseVisualStyleBackColor = true;
            this.btnCashCreate.Click += new System.EventHandler(this.btnCashCreate_Click);
            // 
            // btnCashUpdate
            // 
            this.btnCashUpdate.Location = new System.Drawing.Point(169, 91);
            this.btnCashUpdate.Name = "btnCashUpdate";
            this.btnCashUpdate.Size = new System.Drawing.Size(102, 28);
            this.btnCashUpdate.TabIndex = 31;
            this.btnCashUpdate.Text = "Update";
            this.btnCashUpdate.UseVisualStyleBackColor = true;
            this.btnCashUpdate.Click += new System.EventHandler(this.btnCashUpdate_Click);
            // 
            // btnCashDelete
            // 
            this.btnCashDelete.Location = new System.Drawing.Point(74, 91);
            this.btnCashDelete.Name = "btnCashDelete";
            this.btnCashDelete.Size = new System.Drawing.Size(89, 28);
            this.btnCashDelete.TabIndex = 32;
            this.btnCashDelete.Text = "Delete";
            this.btnCashDelete.UseVisualStyleBackColor = true;
            this.btnCashDelete.Click += new System.EventHandler(this.btnCashDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Order ıd";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtCheckId);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dtGridCheckList);
            this.groupBox3.Controls.Add(this.txtCheckAmount);
            this.groupBox3.Controls.Add(this.btnCheckClear);
            this.groupBox3.Controls.Add(this.btCheckUpdate);
            this.groupBox3.Controls.Add(this.btnCheckDelete);
            this.groupBox3.Controls.Add(this.btnCheckCreate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtBankId);
            this.groupBox3.Controls.Add(this.txtCheckSurname);
            this.groupBox3.Controls.Add(this.txtCheckName);
            this.groupBox3.Location = new System.Drawing.Point(6, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(942, 237);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Check info";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 65;
            this.label13.Text = "Id";
            // 
            // txtCheckId
            // 
            this.txtCheckId.Enabled = false;
            this.txtCheckId.Location = new System.Drawing.Point(106, 28);
            this.txtCheckId.Name = "txtCheckId";
            this.txtCheckId.Size = new System.Drawing.Size(169, 20);
            this.txtCheckId.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Amount";
            // 
            // dtGridCheckList
            // 
            this.dtGridCheckList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridCheckList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCheckList.Location = new System.Drawing.Point(288, 28);
            this.dtGridCheckList.Name = "dtGridCheckList";
            this.dtGridCheckList.Size = new System.Drawing.Size(646, 194);
            this.dtGridCheckList.TabIndex = 40;
            this.dtGridCheckList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridCheckList_CellDoubleClick);
            // 
            // txtCheckAmount
            // 
            this.txtCheckAmount.Location = new System.Drawing.Point(106, 54);
            this.txtCheckAmount.Name = "txtCheckAmount";
            this.txtCheckAmount.Size = new System.Drawing.Size(169, 20);
            this.txtCheckAmount.TabIndex = 41;
            // 
            // btnCheckClear
            // 
            this.btnCheckClear.Location = new System.Drawing.Point(5, 194);
            this.btnCheckClear.Name = "btnCheckClear";
            this.btnCheckClear.Size = new System.Drawing.Size(58, 23);
            this.btnCheckClear.TabIndex = 63;
            this.btnCheckClear.Text = "Clear";
            this.btnCheckClear.UseVisualStyleBackColor = true;
            this.btnCheckClear.Click += new System.EventHandler(this.btnCheckClear_Click);
            // 
            // btCheckUpdate
            // 
            this.btCheckUpdate.Location = new System.Drawing.Point(173, 160);
            this.btCheckUpdate.Name = "btCheckUpdate";
            this.btCheckUpdate.Size = new System.Drawing.Size(102, 28);
            this.btCheckUpdate.TabIndex = 31;
            this.btCheckUpdate.Text = "Update";
            this.btCheckUpdate.UseVisualStyleBackColor = true;
            this.btCheckUpdate.Click += new System.EventHandler(this.btCheckUpdate_Click);
            // 
            // btnCheckDelete
            // 
            this.btnCheckDelete.Location = new System.Drawing.Point(78, 160);
            this.btnCheckDelete.Name = "btnCheckDelete";
            this.btnCheckDelete.Size = new System.Drawing.Size(89, 28);
            this.btnCheckDelete.TabIndex = 32;
            this.btnCheckDelete.Text = "Delete";
            this.btnCheckDelete.UseVisualStyleBackColor = true;
            this.btnCheckDelete.Click += new System.EventHandler(this.btnCheckDelete_Click);
            // 
            // btnCheckCreate
            // 
            this.btnCheckCreate.Location = new System.Drawing.Point(120, 194);
            this.btnCheckCreate.Name = "btnCheckCreate";
            this.btnCheckCreate.Size = new System.Drawing.Size(102, 28);
            this.btnCheckCreate.TabIndex = 31;
            this.btnCheckCreate.Text = "Create";
            this.btnCheckCreate.UseVisualStyleBackColor = true;
            this.btnCheckCreate.Click += new System.EventHandler(this.btnCheckCreate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Surname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Bank id";
            // 
            // txtBankId
            // 
            this.txtBankId.Location = new System.Drawing.Point(106, 80);
            this.txtBankId.Name = "txtBankId";
            this.txtBankId.Size = new System.Drawing.Size(169, 20);
            this.txtBankId.TabIndex = 0;
            // 
            // txtCheckSurname
            // 
            this.txtCheckSurname.Location = new System.Drawing.Point(106, 130);
            this.txtCheckSurname.Name = "txtCheckSurname";
            this.txtCheckSurname.Size = new System.Drawing.Size(169, 20);
            this.txtCheckSurname.TabIndex = 0;
            // 
            // txtCheckName
            // 
            this.txtCheckName.Location = new System.Drawing.Point(106, 104);
            this.txtCheckName.Name = "txtCheckName";
            this.txtCheckName.Size = new System.Drawing.Size(169, 20);
            this.txtCheckName.TabIndex = 0;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Enabled = false;
            this.txtOrderId.Location = new System.Drawing.Point(112, 19);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(169, 20);
            this.txtOrderId.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dtGridCreditList);
            this.groupBox2.Controls.Add(this.txtCreditId);
            this.groupBox2.Controls.Add(this.btnCreditClear);
            this.groupBox2.Controls.Add(this.txtCreditAmount);
            this.groupBox2.Controls.Add(this.btnCreditUpdate);
            this.groupBox2.Controls.Add(this.btnCreditDelete);
            this.groupBox2.Controls.Add(this.btnCreditCreate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCardNumber);
            this.groupBox2.Controls.Add(this.txtCVC);
            this.groupBox2.Controls.Add(this.txtCreditSurname);
            this.groupBox2.Controls.Add(this.txtCreditName);
            this.groupBox2.Location = new System.Drawing.Point(5, 490);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1038, 249);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credit info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Id";
            // 
            // dtGridCreditList
            // 
            this.dtGridCreditList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridCreditList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCreditList.Location = new System.Drawing.Point(289, 19);
            this.dtGridCreditList.Name = "dtGridCreditList";
            this.dtGridCreditList.Size = new System.Drawing.Size(739, 224);
            this.dtGridCreditList.TabIndex = 40;
            this.dtGridCreditList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridCreditList_CellDoubleClick);
            // 
            // txtCreditId
            // 
            this.txtCreditId.Enabled = false;
            this.txtCreditId.Location = new System.Drawing.Point(113, 25);
            this.txtCreditId.Name = "txtCreditId";
            this.txtCreditId.Size = new System.Drawing.Size(169, 20);
            this.txtCreditId.TabIndex = 0;
            // 
            // btnCreditClear
            // 
            this.btnCreditClear.Location = new System.Drawing.Point(12, 215);
            this.btnCreditClear.Name = "btnCreditClear";
            this.btnCreditClear.Size = new System.Drawing.Size(58, 23);
            this.btnCreditClear.TabIndex = 63;
            this.btnCreditClear.Text = "Clear";
            this.btnCreditClear.UseVisualStyleBackColor = true;
            this.btnCreditClear.Click += new System.EventHandler(this.btnCreditClear_Click);
            // 
            // txtCreditAmount
            // 
            this.txtCreditAmount.Location = new System.Drawing.Point(113, 51);
            this.txtCreditAmount.Name = "txtCreditAmount";
            this.txtCreditAmount.Size = new System.Drawing.Size(169, 20);
            this.txtCreditAmount.TabIndex = 41;
            // 
            // btnCreditUpdate
            // 
            this.btnCreditUpdate.Location = new System.Drawing.Point(180, 181);
            this.btnCreditUpdate.Name = "btnCreditUpdate";
            this.btnCreditUpdate.Size = new System.Drawing.Size(102, 28);
            this.btnCreditUpdate.TabIndex = 31;
            this.btnCreditUpdate.Text = "Update";
            this.btnCreditUpdate.UseVisualStyleBackColor = true;
            this.btnCreditUpdate.Click += new System.EventHandler(this.btnCreditUpdate_Click);
            // 
            // btnCreditDelete
            // 
            this.btnCreditDelete.Location = new System.Drawing.Point(85, 181);
            this.btnCreditDelete.Name = "btnCreditDelete";
            this.btnCreditDelete.Size = new System.Drawing.Size(89, 28);
            this.btnCreditDelete.TabIndex = 32;
            this.btnCreditDelete.Text = "Delete";
            this.btnCreditDelete.UseVisualStyleBackColor = true;
            this.btnCreditDelete.Click += new System.EventHandler(this.btnCreditDelete_Click);
            // 
            // btnCreditCreate
            // 
            this.btnCreditCreate.Location = new System.Drawing.Point(127, 215);
            this.btnCreditCreate.Name = "btnCreditCreate";
            this.btnCreditCreate.Size = new System.Drawing.Size(102, 28);
            this.btnCreditCreate.TabIndex = 31;
            this.btnCreditCreate.Text = "Create";
            this.btnCreditCreate.UseVisualStyleBackColor = true;
            this.btnCreditCreate.Click += new System.EventHandler(this.btnCreditCreate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Card number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "CVC";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(113, 77);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(169, 20);
            this.txtCardNumber.TabIndex = 0;
            // 
            // txtCVC
            // 
            this.txtCVC.Location = new System.Drawing.Point(113, 103);
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(169, 20);
            this.txtCVC.TabIndex = 0;
            // 
            // txtCreditSurname
            // 
            this.txtCreditSurname.Location = new System.Drawing.Point(113, 155);
            this.txtCreditSurname.Name = "txtCreditSurname";
            this.txtCreditSurname.Size = new System.Drawing.Size(169, 20);
            this.txtCreditSurname.TabIndex = 0;
            // 
            // txtCreditName
            // 
            this.txtCreditName.Location = new System.Drawing.Point(113, 129);
            this.txtCreditName.Name = "txtCreditName";
            this.txtCreditName.Size = new System.Drawing.Size(169, 20);
            this.txtCreditName.TabIndex = 0;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 769);
            this.Controls.Add(this.groupBox1);
            this.Name = "PaymentForm";
            this.Text = "Payment Form";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCash)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCheckList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCreditList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreditClear;
        private System.Windows.Forms.Button btnCreditUpdate;
        private System.Windows.Forms.Button btnCreditDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCreditId;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreditCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCreditName;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.DataGridView dtGridCreditList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCreditSurname;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtGridCheckList;
        private System.Windows.Forms.Button btnCheckClear;
        private System.Windows.Forms.Button btCheckUpdate;
        private System.Windows.Forms.Button btnCheckDelete;
        private System.Windows.Forms.Button btnCheckCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBankId;
        private System.Windows.Forms.TextBox txtCheckSurname;
        private System.Windows.Forms.TextBox txtCheckName;
        private System.Windows.Forms.Button btnCashCreate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCreditAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCheckAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCashAmount;
        private System.Windows.Forms.DataGridView dtGridCash;
        private System.Windows.Forms.Button btnCashUpdate;
        private System.Windows.Forms.Button btnCashDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCheckId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCashId;
    }
}