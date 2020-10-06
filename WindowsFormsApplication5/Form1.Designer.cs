namespace WindowsFormsApplication5
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchsaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diliveryOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.transctionToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.productToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.generalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(96, 34);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(175, 34);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(175, 34);
            this.supplierToolStripMenuItem.Text = "Supplier";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(175, 34);
            this.productToolStripMenuItem.Text = "Products";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // transctionToolStripMenuItem
            // 
            this.transctionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerBillToolStripMenuItem,
            this.purchsaseOrderToolStripMenuItem,
            this.diliveryOrderToolStripMenuItem,
            this.purchaseReturnToolStripMenuItem,
            this.paymentEntryToolStripMenuItem,
            this.exutToolStripMenuItem});
            this.transctionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transctionToolStripMenuItem.Name = "transctionToolStripMenuItem";
            this.transctionToolStripMenuItem.Size = new System.Drawing.Size(119, 34);
            this.transctionToolStripMenuItem.Text = "Transction";
            // 
            // customerBillToolStripMenuItem
            // 
            this.customerBillToolStripMenuItem.Name = "customerBillToolStripMenuItem";
            this.customerBillToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.customerBillToolStripMenuItem.Text = "Customer Bill";
            // 
            // purchsaseOrderToolStripMenuItem
            // 
            this.purchsaseOrderToolStripMenuItem.Name = "purchsaseOrderToolStripMenuItem";
            this.purchsaseOrderToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.purchsaseOrderToolStripMenuItem.Text = "Purchsase Order";
            // 
            // diliveryOrderToolStripMenuItem
            // 
            this.diliveryOrderToolStripMenuItem.Name = "diliveryOrderToolStripMenuItem";
            this.diliveryOrderToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.diliveryOrderToolStripMenuItem.Text = "Delivery Order";
            // 
            // purchaseReturnToolStripMenuItem
            // 
            this.purchaseReturnToolStripMenuItem.Name = "purchaseReturnToolStripMenuItem";
            this.purchaseReturnToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.purchaseReturnToolStripMenuItem.Text = "Purchase Return";
            // 
            // paymentEntryToolStripMenuItem
            // 
            this.paymentEntryToolStripMenuItem.Name = "paymentEntryToolStripMenuItem";
            this.paymentEntryToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.paymentEntryToolStripMenuItem.Text = "Payment Entry";
            // 
            // exutToolStripMenuItem
            // 
            this.exutToolStripMenuItem.Name = "exutToolStripMenuItem";
            this.exutToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.exutToolStripMenuItem.Text = "Exit";
            this.exutToolStripMenuItem.Click += new System.EventHandler(this.exutToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerInformationToolStripMenuItem,
            this.supplierInformationToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(86, 34);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // customerInformationToolStripMenuItem
            // 
            this.customerInformationToolStripMenuItem.Name = "customerInformationToolStripMenuItem";
            this.customerInformationToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this.customerInformationToolStripMenuItem.Text = "Customer Information";
            // 
            // supplierInformationToolStripMenuItem
            // 
            this.supplierInformationToolStripMenuItem.Name = "supplierInformationToolStripMenuItem";
            this.supplierInformationToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this.supplierInformationToolStripMenuItem.Text = "Supplier Information";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.createNewUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.calculatorToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 34);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
            this.aboutUsToolStripMenuItem.Text = "About us";
            // 
            // createNewUserToolStripMenuItem
            // 
            this.createNewUserToolStripMenuItem.Name = "createNewUserToolStripMenuItem";
            this.createNewUserToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
            this.createNewUserToolStripMenuItem.Text = "Create New User";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(90, 34);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchsaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diliveryOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}

