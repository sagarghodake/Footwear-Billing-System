﻿using System;
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
    public partial class frmproduct : Form
    {
        public frmproduct()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-S1EMRLVI\\sqlexpress;Initial Catalog=footwear;Integrated Security=True;Pooling=False");


        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


           

       }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "insert into prodinfo values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text +"','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + richTextBox1.Text +"')";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Save !!!!!!!");
            con.Close();

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
