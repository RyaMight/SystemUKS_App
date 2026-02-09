using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SystemUKS_with_Login
{
    public partial class Ruangperiksa : Form
    {

        class DataRuangPeriksa
        {
            public string Ruang { get; set; }
            public int Jumlah { get; set; }
            public int Kursi { get; set; }
            public string JenisObat { get; set; }
            public string RanjangUks { get; set; }
            public int Wastafel { get; set; }
            public int HandSanitizer { get; set; }

            public DataRuangPeriksa(
                string ruang,
                int jumlah,
                int kursi,
                string jenisObat,
                string ranjangUks,
                int wastafel,
                int handSanitizer)
            {
                Ruang = ruang;
                Jumlah = jumlah;
                Kursi = kursi;
                JenisObat = jenisObat;
                RanjangUks = ranjangUks;
                Wastafel = wastafel;
                HandSanitizer = handSanitizer;
            }
        }

        List<DataRuangPeriksa> daftarRuang = new List<DataRuangPeriksa>();

        Dashboard dash;

        public Ruangperiksa(Dashboard dashboard)
        {
            InitializeComponent();
            dash = dashboard;
            this.Load += RuangPeriksa_Load;
        }

        private void RuangPeriksa_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 7;

            dataGridView1.Columns[0].Name = "Ruang";
            dataGridView1.Columns[1].Name = "Jumlah";
            dataGridView1.Columns[2].Name = "Kursi";
            dataGridView1.Columns[3].Name = "Jenis Obat";
            dataGridView1.Columns[4].Name = "Ranjang UKS";
            dataGridView1.Columns[5].Name = "Wastafel";
            dataGridView1.Columns[6].Name = "Hand Sanitizer";

            daftarRuang.Add(new DataRuangPeriksa(
                "Ruang 1", 2, 1, "Paracetamol", "Bersih", 1, 1));

            daftarRuang.Add(new DataRuangPeriksa(
                "Ruang 2", 3, 2, "OBH", "Siap", 1, 2));

            foreach (var r in daftarRuang)
            {
                dataGridView1.Rows.Add(
                    r.Ruang,
                    r.Jumlah,
                    r.Kursi,
                    r.JenisObat,
                    r.RanjangUks,
                    r.Wastafel,
                    r.HandSanitizer
                );
            }

            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = true;
        }
        public Ruangperiksa()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
