using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaddcust frm = new frmaddcust();
            frm.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcustomer frm = new frmcustomer();
            frm.Show();

            
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplier frm = new frmSupplier();
            frm.Show();

        }

        private void productInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmproduct frm = new frmproduct();
            frm.Show();

        }

        private void customerBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsales frm = new frmsales();
            frm.Show();

                    }

        private void purchaseReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmproductbill frm = new frmproductbill();
            frm.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
             frmabout frm = new frmabout();
            frm.Show();
           
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
