using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp6
{
        
    public partial class Form4 : Form
    {
        SC1 model = new SC1();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //calculate();
            //status();
            
           // timer1.Start();
            Clear();
            PopulateDataGridView();
            date();
        }
        void date()
        {
            txtDate.Text = DateTime.Today.ToString("ddd MM/dd/yy");
            txtDate.ReadOnly = true;
            
            
        }
        void Clear()
        {
            comboBox2.Text = comboBox1.Text = txtTimeIn.Text = txtTimeOut.Text= comboBox3.Text= "";
            //txtReason.Enabled= false;
            btnSAVE.Text = "Save";
            model.ID = 0;
        }
        void PopulateDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                //dataGridView1.DataSource = db.SC1.ToList<SC1>();
               dataGridView1.DataSource=db.SC1.OrderByDescending(s => s.DATE).ToList<SC1>();
              // dataGridView1.DataSource=db.SC1.Concat(db.SC1.OrderByDescending(s => s.DATE)).ToList<SC1>();
                

            }

        }
        //void calculate()
        //{
        //    string startTime = "9:00 AM";
        //    string timeIn = txtTimeIn.Text.ToString();
        //    string lateTime = "10:15 AM";
        //    string halfDay = "11:15 AM";

        //    label7.Text = label8.Text = "";
            
        //    //TimeSpan duration = DateTime.Parse(lateTime).Subtract(DateTime.Parse(startTime));
        //    //label7.Text = duration.ToString();//late time

        //    //TimeSpan durationHalfDay = DateTime.Parse(halfDay).Subtract(DateTime.Parse(startTime));
        //    //label8.Text = durationHalfDay.ToString();//Half time

          

        //}
       

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                using (DBEntities db = new DBEntities())
                {
                    model = db.SC1.Where(x => x.ID == model.ID).FirstOrDefault();
                    comboBox2.Text = model.NAME;
                    comboBox1.Text = model.STATUS;
                    txtTimeIn.Text = model.TIME_IN;
                    txtTimeOut.Text = model.TIME_OUT;
                    txtDate.Text = model.DATE;
                    
                    comboBox3.Text=model.REASON;
                }
                btnSAVE.Text = "Update";
                
            }
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            model.NAME = comboBox2.Text.Trim();
            model.STATUS = comboBox1.Text.Trim();
            model.TIME_IN = txtTimeIn.Text.Trim();
            model.TIME_OUT = txtTimeOut.Text.Trim();
            model.DATE = txtDate.Text.Trim();
           
            model.REASON = comboBox3.Text.Trim();
            using (DBEntities db = new DBEntities())
            {
                if (model.ID == 0)//Insert
                    db.SC1.Add(model);
                else //Update
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitted Successfully");
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
        Form2 f2 = new Form2();

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //txtTimeIn.Text = DateTime.Now.ToLongTimeString();
            //txtTimeIn.ReadOnly = true;
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
           
            
        }

        private void txtTimeIn_TextChanged(object sender, EventArgs e)
        {

        }
        //void status()
        //{

        //    if (txtTimeIn.Text == "10:16")
        //    {
        //        comboBox1.Text = "Late";

        //    }
        //}
    }
}
