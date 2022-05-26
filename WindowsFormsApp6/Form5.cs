using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        //insert
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HP-TIGER-LAKE\\SQLEXPRESS;Initial Catalog=SC_AMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into EMP_TABLE values ( @EMP_NAME, @DESIGNATION, @BIKE_NO)",con);
            
            cmd.Parameters.AddWithValue("@EMP_NAME", textBox2.Text);
            cmd.Parameters.AddWithValue("@DESIGNATION", textBox3.Text);
            cmd.Parameters.AddWithValue("@BIKE_NO", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Inserted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HP-TIGER_LAKE\\SQLEXPRESS;Initial Catalog=SC_AMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update from EMP_TABLE set EMP_NAME=@EMP_NAME, DESIGNATION=@DESIGNTAION, BIKE_NO=@BIKE_NO where EMP_ID=@EMP_ID",con);
            cmd.Parameters.AddWithValue("@EMP_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@EMP_NAME", textBox2.Text);
            cmd.Parameters.AddWithValue("@DESIGNATION", textBox3.Text);
            cmd.Parameters.AddWithValue("@BIKE_NO", textBox4.Text);
           
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");
        }

        //update
        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HP-TIGER-LAKE\\SQLEXPRESS;Initial Catalog=SC_AMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update EMP_TABLE set EMP_NAME=@EMP_NAME, DESIGNATION=@DESIGNATION, BIKE_NO=@BIKE_NO where EMP_ID=@EMP_ID", con);
            cmd.Parameters.AddWithValue("@EMP_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@EMP_NAME", textBox2.Text);
            cmd.Parameters.AddWithValue("@DESIGNATION", textBox3.Text);
            cmd.Parameters.AddWithValue("@BIKE_NO", textBox4.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HP-TIGER-LAKE\\SQLEXPRESS;Initial Catalog=SC_AMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete EMP_TABLE where EMP_ID=@EMP_ID", con);
            cmd.Parameters.AddWithValue("@EMP_ID", int.Parse(textBox1.Text));
           
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HP-TIGER-LAKE\\SQLEXPRESS;Initial Catalog=SC_AMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from EMP_TABLE where EMP_ID=@EMP_ID", con);
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.AddWithValue("@EMP_ID", int.Parse(textBox1.Text));
            //cmd.ExecuteNonQuery();
            //con.Close();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
    }
}
