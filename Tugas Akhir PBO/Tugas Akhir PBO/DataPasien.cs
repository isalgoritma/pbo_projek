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
    public partial class DataPasien: Form
    {
        public DataPasien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data Pasien Berhasil Disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Kembali5_Click(object sender, EventArgs e)
        {
            Laporan laporan = new Laporan();
            laporan.Show();

            this.Hide();
        }
    }
}
