using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SystemUKS_with_Login
{
    public partial class Petugas : Form
    {
        class DataPetugas
        {
            public string NamaPetugas { get; set; }
            public int Umur { get; set; }
            public float BeratBadan { get; set; }
            public float TinggiBadan { get; set; }
            public string GolonganDarah { get; set; }
            public string ID { get; set; }

            public DataPetugas(string nama, int umur, float berat, float tinggi, string goldar, string id)
            {
                NamaPetugas = nama;
                Umur = umur;
                BeratBadan = berat;
                TinggiBadan = tinggi;
                GolonganDarah = goldar;
                ID = id;
            }
        }

        List<DataPetugas> daftarPetugas = new List<DataPetugas>();

        Dashboard dash;

        public Petugas(Dashboard dashboard)
        {
            InitializeComponent();
            dash = dashboard;
            this.Load += Petugas_Load;
        }

        private void Petugas_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;

            dataGridView1.Columns[0].Name = "Nama";
            dataGridView1.Columns[1].Name = "Umur";
            dataGridView1.Columns[2].Name = "Berat Badan";
            dataGridView1.Columns[3].Name = "Tinggi Badan";
            dataGridView1.Columns[4].Name = "Golongan Darah";
            dataGridView1.Columns[5].Name = "ID";

            daftarPetugas.Add(new DataPetugas("Lita", 15, 56, 168, "A", "001"));
            daftarPetugas.Add(new DataPetugas("Raya", 17, 60, 170, "O", "002"));
            daftarPetugas.Add(new DataPetugas("Vel", 14, 48, 155, "B", "003"));
            daftarPetugas.Add(new DataPetugas("BAPAKNYA", 34, 50, 168, "AB", "004"));

            foreach (var p in daftarPetugas) //untuk membaca semua data (loop) NOTE for Raya
            {
                dataGridView1.Rows.Add(
                    p.NamaPetugas,
                    p.Umur,
                    p.BeratBadan,
                    p.TinggiBadan,
                    p.GolonganDarah,
                    p.ID
                );
            }

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
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
