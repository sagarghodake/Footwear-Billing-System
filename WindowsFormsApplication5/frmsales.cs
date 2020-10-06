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
    public partial class frmsales : Form
    {
        public frmsales()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-S1EMRLVI\\sqlexpress;Initial Catalog=footwear;Integrated Security=True;Pooling=False");

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "insert into sales values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" +textBox5.Text +"','" + textBox6.Text + "','" + textBox4.Text + "')";
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
