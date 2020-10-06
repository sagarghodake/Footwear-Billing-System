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
    public partial class frmcustomer : Form
    {
        public frmcustomer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-S1EMRLVI\\sqlexpress;Initial Catalog=footwear;Integrated Security=True;Pooling=False");

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "insert into cust values('" + textBox1.Text + "','" + textBox2.Text + "','" + richTextBox1.Text +"','" + textBox3.Text + "' )";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Save !!!!!!!");
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
