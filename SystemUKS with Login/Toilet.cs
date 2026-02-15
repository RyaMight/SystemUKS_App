using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SystemUKS_with_Login
{
    public partial class Toilet : Form
    {

        class DataToilet
        {
            public string Ruang { get; set; }
            public int ID { get; set; }
            public string Kondisi { get; set; }
            public float Luas { get; set; }
            public int Wastafel { get; set; }
            public int Shower { get; set; }

            public DataToilet(
                string ruang,
                int ID,
                string Kondisi,
                string Luas,
                string Wastafel,
                string Shower)
            {
                Ruang = ruang;
                ID = ID;
                Kondisi = Kondisi;
                Luas = Luas;
                Wastafel = Wastafel;
                Shower = Shower;
            }
        }

        List<DataToilet> daftarRuang = new List<DataToilet>();

        Dashboard dash;

        public Toilet(Dashboard dashboard)
        {
            InitializeComponent();
            dash = dashboard;
            this.Load += Toilet_Load;
        }

        private void Toilet_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;

            dataGridView1.Columns[0].Name = "Ruang";
            dataGridView1.Columns[1].Name = "ID";
            dataGridView1.Columns[2].Name = "Kondisi";
            dataGridView1.Columns[3].Name = "Luas";
            dataGridView1.Columns[4].Name = "Wastafel";
            dataGridView1.Columns[5].Name = "Shower";

            daftarRuang.Add(new DataToilet(
                "Ruang 1", 001, "Bersih", "20m", "Ada", "Ada" ));

            foreach (var r in daftarRuang)
            {
                dataGridView1.Rows.Add(
                    r.Ruang,
                    r.ID,
                    r.Kondisi,
                    r.Luas,
                    r.Wastafel,
                    r.Shower
                );
            }

            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = true;
        }
        public Toilet()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
