using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SystemUKS_with_Login
{
    public partial class Dashboard : Form
    {

        private Size originalFormSize;
        private Dictionary<Control, Rectangle> ControlBounds = new Dictionary<Control, Rectangle>();

        public Dashboard()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Petugas(this));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Pasien(this));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new RuangLogistik(this));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadform(new Ruangperiksa(this));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadform(new Toilet(this));
        }
    }
}
