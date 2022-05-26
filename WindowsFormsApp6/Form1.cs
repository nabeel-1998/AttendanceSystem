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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=HP-TIGER-LAKE\\SQLEXPRESS;Initial Catalog=SC_AMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from AdminTable where name=@name and password=@password", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.AddWithValue("@name", textBox_ID.Text);
            cmd.Parameters.AddWithValue("@password", textBox_PASS.Text);
            adapter.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                Form2 f = new Form2();
                this.Hide();
                f.Show();


            }
            else
            {
                MessageBox.Show("invalid username or password!");
            }
        }
    }
}
