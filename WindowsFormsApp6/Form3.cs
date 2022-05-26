using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HP-TIGER-LAKE\\SQLEXPRESS;Initial Catalog=SC_AMS;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("Select * from SC1 where NAME=@NAME", con);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //cmd.Parameters.AddWithValue("NAME", textBox1.Text);
            ////cmd.ExecuteNonQuery();
            ////con.Close();
            //da.Fill(dt);
            //dataGridView4.DataSource = dt;

            //absent
            if (checkBox1.Checked)
            {
                SqlCommand cmdA = new SqlCommand("Select * from SC1 where NAME=@NAME and STATUS='Absent'", con);
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                DataTable dtA = new DataTable();
                cmdA.Parameters.AddWithValue("@NAME", comboBoxName.Text);
                cmdA.Parameters.AddWithValue("@STATUS", checkBox1.Text);
                //cmd.ExecuteNonQuery();
                //con.Close();
                daA.Fill(dtA);
                dataGridView4.DataSource = dtA;

            }
            //late
            else if (checkBox2.Checked)
            {
                SqlCommand cmdL = new SqlCommand("Select * from SC1 where NAME=@NAME and STATUS='Absent'", con);
                SqlDataAdapter daL = new SqlDataAdapter(cmdL);
                DataTable dtL = new DataTable();
                cmdL.Parameters.AddWithValue("@NAME", comboBoxName.Text);
                cmdL.Parameters.AddWithValue("@STATUS", checkBox2.Text);
                //cmd.ExecuteNonQuery();
                //con.Close();
                daL.Fill(dtL);
                dataGridView4.DataSource = dtL;
            }
            //Half Day
            else if (checkBox2.Checked)
            {
                SqlCommand cmdH = new SqlCommand("Select * from SC1 where NAME=@NAME and STATUS='Half Day'", con);
                SqlDataAdapter daH = new SqlDataAdapter(cmdH);
                DataTable dtH = new DataTable();
                cmdH.Parameters.AddWithValue("@NAME", comboBoxName.Text);
                cmdH.Parameters.AddWithValue("@STATUS", checkBox3.Text);
                //cmd.ExecuteNonQuery();
                //con.Close();
                daH.Fill(dtH);
                dataGridView4.DataSource = dtH;
            }
             if (checkBox1.Checked )
            {
                 if (checkBox2.Checked)
                {
                     if (checkBox3.Checked)
                    {
                        SqlCommand cmdH = new SqlCommand("Select * from SC1 where NAME=@NAME and STATUS!='Present'", con);
                        SqlDataAdapter daH = new SqlDataAdapter(cmdH);
                        DataTable dtH = new DataTable();
                        cmdH.Parameters.AddWithValue("@NAME", comboBoxName.Text);
                        //cmdH.Parameters.AddWithValue("@STATUS", checkBox1.Text=checkBox2.Text=checkBox3.Text);
                        //cmd.ExecuteNonQuery();
                        //con.Close();
                        daH.Fill(dtH);
                        dataGridView4.DataSource = dtH;
                    }
                }
               
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from SC1 where NAME=@NAME", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cmd.Parameters.AddWithValue("NAME", comboBoxName.Text);
                //cmd.ExecuteNonQuery();
                //con.Close();
                da.Fill(dt);
                dataGridView4.DataSource = dt;
            }
        }
  
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();   
            this.Hide();
            form.Show();
        }
    }
}
