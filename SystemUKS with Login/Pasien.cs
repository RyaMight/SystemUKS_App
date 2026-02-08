using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SystemUKS_with_Login
{
    public partial class Pasien : Form
    {
        class DataPasien
        {
            public string NamaPasien { get; set; }
            public int Umur { get; set; }
            public float BeratBadan { get; set; }
            public float TinggiBadan { get; set; }
            public string GolonganDarah { get; set; }
            public string ID { get; set; }

            public DataPasien(string nama, int umur, float berat, float tinggi, string goldar, string id)
            {
                NamaPasien = nama;
                Umur = umur;
                BeratBadan = berat;
                TinggiBadan = tinggi;
                GolonganDarah = goldar;
                ID = id;
            }
        }

        List<DataPasien> daftarPasien = new List<DataPasien>();

        Dashboard dash;

        public Pasien(Dashboard dashboard)
        {
            InitializeComponent();
            dash = dashboard;
            this.Load += Pasien_Load;
        }

        private void Pasien_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;

            dataGridView1.Columns[0].Name = "Nama";
            dataGridView1.Columns[1].Name = "Umur";
            dataGridView1.Columns[2].Name = "Berat Badan";
            dataGridView1.Columns[3].Name = "Tinggi Badan";
            dataGridView1.Columns[4].Name = "Golongan Darah";
            dataGridView1.Columns[5].Name = "ID";

            daftarPasien.Add(new DataPasien("MYMY", 15, 56, 168, "B", "001"));
            daftarPasien.Add(new DataPasien("Waguri", 17, 60, 170, "B", "002"));
            daftarPasien.Add(new DataPasien("Artemiz", 14, 48, 150, "Anomaly", "003"));
            daftarPasien.Add(new DataPasien("IDK MAN", 34, 50, 168, "67", "004"));

            foreach (var p in daftarPasien)
            {
                dataGridView1.Rows.Add(
                    p.NamaPasien,
                    p.Umur,
                    p.BeratBadan,
                    p.TinggiBadan,
                    p.GolonganDarah,
                    p.ID
                );
            }

            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dash.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
