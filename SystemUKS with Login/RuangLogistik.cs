using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SystemUKS_with_Login
{
    public partial class RuangLogistik : Form
    {
        public RuangLogistik()
        {
            InitializeComponent();
        }
        class DataLogistik
        {
            public string NamaRuang { get; set; }
            public int Kapasitas { get; set; }
            public float Luas { get; set; }
            public string PenanggungJawab { get; set; }
            public string DaftarBarang { get; set; }
            public string ID { get; set; }

            public DataLogistik(string nama, float Meteran, string Daftar, int Kapsitas, string petugas, string id)
            {
                NamaRuang = nama;
                Luas = Meteran;
                DaftarBarang = Daftar;
                Kapasitas = Kapsitas;
                PenanggungJawab = petugas;
                ID = id;
            }
        }

        List<DataLogistik> daftarLogistik = new List<DataLogistik>();

        Dashboard dash;

        public RuangLogistik(Dashboard dashboard)
        {
            InitializeComponent();
            dash = dashboard;
            this.Load += RuangLogistik_Load;
        }

        private void RuangLogistik_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;

            dataGridView1.Columns[0].Name = "Nama Ruang";
            dataGridView1.Columns[1].Name = "Luas(M)";
            dataGridView1.Columns[2].Name = "Kapasitas";
            dataGridView1.Columns[3].Name = "Daftar Barang";
            dataGridView1.Columns[4].Name = "Penanggung Jawab";
            dataGridView1.Columns[5].Name = "ID";

            daftarLogistik.Add(new DataLogistik("Ruang A", 20, "5", 40, "Raya", "L001"));
            daftarLogistik.Add(new DataLogistik("Ruang B", 20, "5", 25, "Lita", "L002"));
            daftarLogistik.Add(new DataLogistik("Ruang A", 20, "5", 40, "Raya", "L001"));
            daftarLogistik.Add(new DataLogistik("Ruang B", 20, "5", 25, "Lita", "L002"));


            foreach (var p in daftarLogistik) //untuk membaca semua data (loop) NOTE for Raya
            {
                dataGridView1.Rows.Add(
                    p.NamaRuang,
                    p.Luas,
                    p.DaftarBarang,
                    p.Kapasitas,
                    p.PenanggungJawab,
                    p.ID
                );
            }

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
