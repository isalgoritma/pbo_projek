using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Akhir_PBO
{
    public partial class Penjadwalan : Form
    {
        private TextBox textBoxisiPasien;
        private TextBox textBoxisiObat;
        private TextBox textBoxisikamar;
        private TextBox textBoxisipenyakit;
        private TextBox textBoxisiDosis;
        private DateTimePicker dateTimePicker1;

        public Penjadwalan()
        {
            InitializeComponent();
        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            Laporan laporan = new Laporan();
            laporan.Show();
            this.Hide();


        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Done_Click(object sender, EventArgs e)
        {
            string waktu = dateTimePicker2.Value.ToString("HH:mm");
            string idPasien = pasienID.Text;
            string obat = ObatIsi.Text;
            string dosis = DosisIsi.Text;
            string diagnosa = DiagnosaIsi.Text;

            //if (!Program.jadwal.Visible)
            //{
            //    Program.jadwal.Show();
            //}

            //Program.jadwal.TambahData(waktu, obat, idPasien, dosis, diagnosa);

            Jadwal jadwal = new Jadwal();
            jadwal.Show();
            this.Hide();
        }



    }
}
