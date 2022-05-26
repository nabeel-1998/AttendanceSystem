
namespace WindowsFormsApp6
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.EMP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMP_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESIGNATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIKE_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(371, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "RECORD";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "ATTENDANCE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::WindowsFormsApp6.Properties.Resources.icons8_close_64;
            this.pictureBox2.Location = new System.Drawing.Point(701, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp6.Properties.Resources.Khayal_Hai_Logo_06;
            this.pictureBox1.Location = new System.Drawing.Point(191, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EMP_ID,
            this.EMP_NAME,
            this.DESIGNATION,
            this.BIKE_NO});
            this.dgvEmployees.Location = new System.Drawing.Point(12, 285);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.Size = new System.Drawing.Size(718, 98);
            this.dgvEmployees.TabIndex = 11;
            // 
            // EMP_ID
            // 
            this.EMP_ID.DataPropertyName = "EMP_ID";
            this.EMP_ID.HeaderText = "EMP_ID";
            this.EMP_ID.Name = "EMP_ID";
            this.EMP_ID.ReadOnly = true;
            // 
            // EMP_NAME
            // 
            this.EMP_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMP_NAME.DataPropertyName = "EMP_NAME";
            this.EMP_NAME.HeaderText = "EMP_NAME";
            this.EMP_NAME.Name = "EMP_NAME";
            this.EMP_NAME.ReadOnly = true;
            // 
            // DESIGNATION
            // 
            this.DESIGNATION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESIGNATION.DataPropertyName = "DESIGNATION";
            this.DESIGNATION.HeaderText = "DESIGNATION";
            this.DESIGNATION.Name = "DESIGNATION";
            this.DESIGNATION.ReadOnly = true;
            // 
            // BIKE_NO
            // 
            this.BIKE_NO.DataPropertyName = "BIKE_NO";
            this.BIKE_NO.HeaderText = "BIKE_NO";
            this.BIKE_NO.Name = "BIKE_NO";
            this.BIKE_NO.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 397);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMP_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMP_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESIGNATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIKE_NO;
    }
}