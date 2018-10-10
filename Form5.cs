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
    public partial class Form5 : Form
    {
        String ConnectionString = "Server=localhost;Database=project;Uid=root;Pwd=rvce;";
        MySqlConnection con;
        public Form5()
        {
            InitializeComponent();
            con = new MySqlConnection(ConnectionString);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select bin from happy;", con);
            DataSet ds = new DataSet();//Creating the data set
            adapter.Fill(ds, "happy");
            dataGridView1.DataSource = ds.Tables["happy"];//Filling the grid  with values in table

            MySqlDataAdapter adapter1 = new MySqlDataAdapter("select * from random;", con);
            DataSet ds1 = new DataSet();//Creating the data set
            adapter1.Fill(ds1, "random");
            dataGridView2.DataSource = ds1.Tables["random"];//Filling the grid  with values in table

            MySqlDataAdapter adapter2 = new MySqlDataAdapter("select * from random;", con);
            DataSet ds2 = new DataSet();//Creating the data set
            adapter2.Fill(ds2, "random");
            dataGridView4.DataSource = ds2.Tables["random"];//Filling the grid  with values in table

            MySqlDataAdapter adapter3 = new MySqlDataAdapter("select * from random;", con);
            DataSet ds3 = new DataSet();//Creating the data set
            adapter3.Fill(ds3, "random");
            dataGridView5.DataSource = ds3.Tables["random"];//Filling the grid  with values in table

            MySqlDataAdapter adapter4 = new MySqlDataAdapter("select * from random;", con);
            DataSet ds4 = new DataSet();//Creating the data set
            adapter4.Fill(ds4, "random");
            dataGridView6.DataSource = ds4.Tables["random"];//Filling the grid  with values in table

            MySqlDataAdapter adapter5 = new MySqlDataAdapter("select * from random;", con);
            DataSet ds5 = new DataSet();//Creating the data set
            adapter5.Fill(ds5, "random");
            dataGridView7.DataSource = ds5.Tables["random"];//Filling the grid  with values in table

            MySqlDataAdapter adapter6 = new MySqlDataAdapter("select * from random;", con);
            DataSet ds6 = new DataSet();//Creating the data set
            adapter6.Fill(ds6, "random");
            dataGridView8.DataSource = ds6.Tables["random"];//Filling the grid  with values in table

            MySqlDataAdapter adapter7 = new MySqlDataAdapter("select * from random;", con);
            DataSet ds7 = new DataSet();//Creating the data set
            adapter7.Fill(ds7, "random");
            dataGridView9.DataSource = ds7.Tables["random6"];//Filling the grid  with values in table

            MySqlDataAdapter adapter8 = new MySqlDataAdapter("select * from random;", con);
            DataSet ds8 = new DataSet();//Creating the data set
            adapter8.Fill(ds8, "random");
            dataGridView10.DataSource = ds8.Tables["random"];//Filling the grid  with values in table

            MySqlDataAdapter adapter9 = new MySqlDataAdapter("select * from random;", con);
            DataSet ds9 = new DataSet();//Creating the data set
            adapter9.Fill(ds9, "random");
            dataGridView11.DataSource = ds9.Tables["random"];//Filling the grid  with values in table

            MySqlDataAdapter adapter10 = new MySqlDataAdapter("select * from random;", con);
            DataSet ds10 = new DataSet();//Creating the data set
            adapter10.Fill(ds10, "random");
            dataGridView12.DataSource = ds10.Tables["random"];//Filling the grid  with values in table

           //foreach (DataGridViewRow item in dataGridView1.Rows)
            //{
                //int n = item.Index;
                //dataGridView3.Rows[1].Cells[1].Value = ((int.Parse(dataGridView1.Rows[1].Cells[1].Value.ToString())) + (Double.Parse(dataGridView2.Rows[1].Cells[1].Value.ToString()))).ToString();

           // }

            con.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int m = dataGridView3.Rows.Add();
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    dataGridView3.Rows.Add();
                    dataGridView3.Rows[i].Cells[j].Value = (Double.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString()) 
                        * Double.Parse(dataGridView2.Rows[i].Cells[j].Value.ToString())).ToString();
                }
            }

            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    dataGridView13.Rows.Add();
                    dataGridView13.Rows[i].Cells[j].Value = (Double.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString())
                        * Double.Parse(dataGridView4.Rows[i].Cells[j].Value.ToString())).ToString();
                }
            }

            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    dataGridView14.Rows.Add();
                    dataGridView14.Rows[i].Cells[j].Value = (Double.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString())
                        * Double.Parse(dataGridView5.Rows[i].Cells[j].Value.ToString())).ToString();
                }
            }

            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    dataGridView15.Rows.Add();
                    dataGridView15.Rows[i].Cells[j].Value = (Double.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString())
                        * Double.Parse(dataGridView6.Rows[i].Cells[j].Value.ToString())).ToString();
                }
            }

            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    dataGridView16.Rows.Add();
                    dataGridView16.Rows[i].Cells[j].Value = (Double.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString())
                        * Double.Parse(dataGridView7.Rows[i].Cells[j].Value.ToString())).ToString();
                }
            }

            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    dataGridView17.Rows.Add();
                    dataGridView17.Rows[i].Cells[j].Value = (Double.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString())
                        * Double.Parse(dataGridView8.Rows[i].Cells[j].Value.ToString())).ToString();
                }
            }

            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    dataGridView18.Rows.Add();
                    dataGridView18.Rows[i].Cells[j].Value = (Double.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString())
                        * Double.Parse(dataGridView9.Rows[i].Cells[j].Value.ToString())).ToString();
                }
            }

            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    dataGridView19.Rows.Add();
                    dataGridView19.Rows[i].Cells[j].Value = (Double.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString())
                        * Double.Parse(dataGridView10.Rows[i].Cells[j].Value.ToString())).ToString();
                }
            }

            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    dataGridView20.Rows.Add();
                    dataGridView20.Rows[i].Cells[j].Value = (Double.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString())
                        * Double.Parse(dataGridView11.Rows[i].Cells[j].Value.ToString())).ToString();
                }
            }

            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    dataGridView21.Rows.Add();
                    dataGridView21.Rows[i].Cells[j].Value = (Double.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString())
                        * Double.Parse(dataGridView12.Rows[i].Cells[j].Value.ToString())).ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double sum = 0;
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    sum+=(Double.Parse(dataGridView3.Rows[i].Cells[j].Value.ToString()));
                }
            }
            textBox1.Text = sum.ToString();

            Double sum1 = 0;
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    sum1 += (Double.Parse(dataGridView13.Rows[i].Cells[j].Value.ToString()));
                }
            }
            textBox2.Text = sum1.ToString();

            Double sum2 = 0;
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    sum2 += (Double.Parse(dataGridView14.Rows[i].Cells[j].Value.ToString()));
                }
            }
            textBox3.Text = sum2.ToString();

            Double sum3 = 0;
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    sum3 += (Double.Parse(dataGridView15.Rows[i].Cells[j].Value.ToString()));
                }
            }
            textBox4.Text = sum3.ToString();

            Double sum4 = 0;
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    sum4 += (Double.Parse(dataGridView16.Rows[i].Cells[j].Value.ToString()));
                }
            }
            textBox5.Text = sum4.ToString();

            Double sum5 = 0;
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    sum5 += (Double.Parse(dataGridView17.Rows[i].Cells[j].Value.ToString()));
                }
            }
            textBox6.Text = sum5.ToString();

            Double sum6 = 0;
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    sum6 += (Double.Parse(dataGridView18.Rows[i].Cells[j].Value.ToString()));
                }
            }
            textBox7.Text = sum6.ToString();

            Double sum7 = 0;
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    sum7 += (Double.Parse(dataGridView19.Rows[i].Cells[j].Value.ToString()));
                }
            }
            textBox8.Text = sum7.ToString();

            Double sum8 = 0;
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    sum8 += (Double.Parse(dataGridView20.Rows[i].Cells[j].Value.ToString()));
                }
            }
            textBox9.Text = sum8.ToString();

            Double sum9 = 0;
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    sum9 += (Double.Parse(dataGridView21.Rows[i].Cells[j].Value.ToString()));
                }
            }
            textBox10.Text = sum9.ToString();

            textBox11.Text = (((Convert.ToDouble(textBox1.Text)*0.55) + (Convert.ToDouble(textBox2.Text)*0.36) + 
                (Convert.ToDouble(textBox3.Text)*0.17) + (Convert.ToDouble(textBox4.Text)*0.26) + 
                (Convert.ToDouble(textBox5.Text)*0.69) + (Convert.ToDouble(textBox6.Text)*0.95) + 
                (Convert.ToDouble(textBox7.Text)*0.46) + (Convert.ToDouble(textBox8.Text)*0.01) + 
                (Convert.ToDouble(textBox9.Text)*0.72) + (Convert.ToDouble(textBox10.Text))*0.67).ToString());

            textBox12.Text = (((Convert.ToDouble(textBox1.Text) * 0.95) + (Convert.ToDouble(textBox2.Text) * 0.66) + (Convert.ToDouble(textBox3.Text) * 0.07) + (Convert.ToDouble(textBox4.Text) * 0.56) + (Convert.ToDouble(textBox5.Text) * 0.79) + (Convert.ToDouble(textBox6.Text) * 0.45) + (Convert.ToDouble(textBox7.Text) * 0.16) + (Convert.ToDouble(textBox8.Text) * 0.51) + (Convert.ToDouble(textBox9.Text) * 0.22) + (Convert.ToDouble(textBox10.Text)) * 0.37).ToString());

            textBox13.Text = (((Convert.ToDouble(textBox1.Text) * 0.65) + (Convert.ToDouble(textBox2.Text) * 0.26) + (Convert.ToDouble(textBox3.Text) * 0.37) + (Convert.ToDouble(textBox4.Text) * 0.86) + (Convert.ToDouble(textBox5.Text) * 0.59) + (Convert.ToDouble(textBox6.Text) * 0.05) + (Convert.ToDouble(textBox7.Text) * 0.46) + (Convert.ToDouble(textBox8.Text) * 0.71) + (Convert.ToDouble(textBox9.Text) * 0.62) + (Convert.ToDouble(textBox10.Text)) * 0.17).ToString());

            //textBox13.Text = 1 / 1 + e ^ (-Convert.ToDouble(textBox1.Text));
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
