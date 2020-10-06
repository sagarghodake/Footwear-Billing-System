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
    public partial class frmaddcust : Form
    {
        public frmaddcust()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-S1EMRLVI\\sqlexpress;Initial Catalog=footwear;Integrated Security=True;Pooling=False");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "insert into addcust values('" + textBox1.Text + "','" + textBox2.Text + "')";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Save !!!!!!!");
            con.Close();


        }
    }
}
