using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;


namespace WindowsFormsApplication5
{
    public partial class frmloginform : Form
    {
        public frmloginform()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-S1EMRLVI\\sqlexpress;Initial Catalog=footwear;Integrated Security=True;Pooling=False");


        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string u, p;
            u = textBox1.Text;
            p = textBox2.Text;
            if (u.Equals("admin") && p.Equals("admin"))
            {
                frmMain ss = new frmMain();
                ss.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("username or password incorrect......!!!");
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
