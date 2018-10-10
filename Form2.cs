using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project
{
    public partial class Form2 : Form
    {
        String ConnectionString = "Server=localhost;Database=project;Uid=root;Pwd=mysql;";
        MySqlConnection con;
        //MySqlCommand cmd;

        public Form2()
        {
            InitializeComponent();
            con = new MySqlConnection(ConnectionString);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "OPEN IMAGE";
            dlg.Filter = "Pictures|*.jpg; *.bmp; *.png|Documents|*.txt; *.doc; *.log|All|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlg.FileName);
            }
            dlg.Dispose();

            con.Open();

            string tt = textBox1.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from "+ tt +" ;",con);
            DataSet ds = new DataSet();//Creating the data set
            adapter.Fill(ds,"tt");
            dataGridView1.DataSource = ds.Tables["tt"];//Filling the grid  with values in table
            con.Close();


            Form5 f = new Form5();
            f.Show();
            this.Hide();
           // button1.Enabled = false;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
    }
}
