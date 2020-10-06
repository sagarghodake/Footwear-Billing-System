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
    public partial class frmproductbill : Form
    {
        public frmproductbill()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-S1EMRLVI\\sqlexpress;Initial Catalog=footwear;Integrated Security=True;Pooling=False");


        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "insert into productbill values('" + textBox1.Text + "','" + textBox4.Text + "','"+ dateTimePicker1.Text +"','" + textBox2.Text + "','"+ textBox3.Text +"','" + textBox6.Text +"','"+ textBox5.Text +"','"+ textBox7.Text +"','"+ textBox8 +"')";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Save !!!!!!!");
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = new string[7];
            row[0] = textBox3.Text;
            row[1] = textBox6.Text;

            dataGridView1.Rows.Add(row);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
