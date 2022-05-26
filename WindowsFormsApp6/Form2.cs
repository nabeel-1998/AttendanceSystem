using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            this.Hide();
            f.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PopulateDataGridViewRecord();
        }
        void PopulateDataGridViewRecord()
        {
            dgvEmployees.AutoGenerateColumns = false;
            using (DBEntities dbR = new DBEntities())
            {
                dgvEmployees.DataSource = dbR.EMP_TABLE.ToList<EMP_TABLE>();


            }
        }
      

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 F = new Form3();
            this.Hide();
            F.Show();
        }
    }
}
