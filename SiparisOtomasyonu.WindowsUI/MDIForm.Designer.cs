namespace SiparisOtomasyonu.WindowsUI
{
    partial class MDIForm
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnUserManager = new System.Windows.Forms.Button();
            this.btnItemManager = new System.Windows.Forms.Button();
            this.btnOrderManager = new System.Windows.Forms.Button();
            this.btnAdminForm = new System.Windows.Forms.Button();
            this.btnCustomerManager = new System.Windows.Forms.Button();
            this.btnPaymentManager = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnLogin);
            this.pnlMenu.Controls.Add(this.btnClear);
            this.pnlMenu.Controls.Add(this.btnPaymentManager);
            this.pnlMenu.Controls.Add(this.btnUserManager);
            this.pnlMenu.Controls.Add(this.btnItemManager);
            this.pnlMenu.Controls.Add(this.btnOrderManager);
            this.pnlMenu.Controls.Add(this.btnAdminForm);
            this.pnlMenu.Controls.Add(this.btnCustomerManager);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMenu.Location = new System.Drawing.Point(0, 798);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1924, 69);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogin.Enabled = false;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Location = new System.Drawing.Point(1549, 7);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(234, 54);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Application Lock";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnUserManager
            // 
            this.btnUserManager.Enabled = false;
            this.btnUserManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserManager.Location = new System.Drawing.Point(1048, 7);
            this.btnUserManager.Name = "btnUserManager";
            this.btnUserManager.Size = new System.Drawing.Size(234, 54);
            this.btnUserManager.TabIndex = 0;
            this.btnUserManager.Text = "User Manager";
            this.btnUserManager.UseVisualStyleBackColor = true;
            this.btnUserManager.Click += new System.EventHandler(this.btnUserManager_Click);
            // 
            // btnItemManager
            // 
            this.btnItemManager.Enabled = false;
            this.btnItemManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnItemManager.Location = new System.Drawing.Point(808, 7);
            this.btnItemManager.Name = "btnItemManager";
            this.btnItemManager.Size = new System.Drawing.Size(234, 54);
            this.btnItemManager.TabIndex = 0;
            this.btnItemManager.Text = "Item Manager";
            this.btnItemManager.UseVisualStyleBackColor = true;
            this.btnItemManager.Click += new System.EventHandler(this.btnItemManager_Click);
            // 
            // btnOrderManager
            // 
            this.btnOrderManager.Enabled = false;
            this.btnOrderManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrderManager.Location = new System.Drawing.Point(500, 7);
            this.btnOrderManager.Name = "btnOrderManager";
            this.btnOrderManager.Size = new System.Drawing.Size(302, 54);
            this.btnOrderManager.TabIndex = 0;
            this.btnOrderManager.Text = "Order Detail Manager";
            this.btnOrderManager.UseVisualStyleBackColor = true;
            this.btnOrderManager.Click += new System.EventHandler(this.btnOrderManager_Click);
            // 
            // btnAdminForm
            // 
            this.btnAdminForm.Enabled = false;
            this.btnAdminForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminForm.Location = new System.Drawing.Point(12, 7);
            this.btnAdminForm.Name = "btnAdminForm";
            this.btnAdminForm.Size = new System.Drawing.Size(196, 54);
            this.btnAdminForm.TabIndex = 0;
            this.btnAdminForm.Text = "Admin Form";
            this.btnAdminForm.UseVisualStyleBackColor = true;
            this.btnAdminForm.Click += new System.EventHandler(this.btnAdminForm_Click);
            // 
            // btnCustomerManager
            // 
            this.btnCustomerManager.Enabled = false;
            this.btnCustomerManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerManager.Location = new System.Drawing.Point(214, 7);
            this.btnCustomerManager.Name = "btnCustomerManager";
            this.btnCustomerManager.Size = new System.Drawing.Size(280, 54);
            this.btnCustomerManager.TabIndex = 0;
            this.btnCustomerManager.Text = "Customer Manager";
            this.btnCustomerManager.UseVisualStyleBackColor = true;
            this.btnCustomerManager.Click += new System.EventHandler(this.btnCustomerManager_Click);
            // 
            // btnPaymentManager
            // 
            this.btnPaymentManager.Enabled = false;
            this.btnPaymentManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPaymentManager.Location = new System.Drawing.Point(1288, 7);
            this.btnPaymentManager.Name = "btnPaymentManager";
            this.btnPaymentManager.Size = new System.Drawing.Size(255, 54);
            this.btnPaymentManager.TabIndex = 0;
            this.btnPaymentManager.Text = "Payment Manager";
            this.btnPaymentManager.UseVisualStyleBackColor = true;
            this.btnPaymentManager.Click += new System.EventHandler(this.btnPaymentManager_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Enabled = false;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Location = new System.Drawing.Point(1789, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 54);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 867);
            this.Controls.Add(this.pnlMenu);
            this.IsMdiContainer = true;
            this.Name = "MDIForm";
            this.Text = "MDI Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnItemManager;
        private System.Windows.Forms.Button btnOrderManager;
        private System.Windows.Forms.Button btnAdminForm;
        private System.Windows.Forms.Button btnCustomerManager;
        private System.Windows.Forms.Button btnUserManager;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPaymentManager;
    }
}