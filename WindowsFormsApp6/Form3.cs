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
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from SC1 where NAME=@NAME", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.AddWithValue("NAME", textBox1.Text);
            //cmd.ExecuteNonQuery();
            //con.Close();
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            
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
