using System;
using System.Windows.Forms;

namespace Tugas_Akhir_PBO
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            isiPassword.PasswordChar = '*';
        }

        private void isiID_TextChanged(object sender, EventArgs e)
        {
        }

        private void isiPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void tombolLogin_Click_1(object sender, EventArgs e)
        {
            string idCorrect = "101AD";
            string passwordCorrect = "adminpw123";
            string id = isiID.Text.Trim();
            string password = isiPassword.Text.Trim();

            try
            {
                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("ID dan Password tidak boleh kosong.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (id == idCorrect && password == passwordCorrect)
                {
                    // Buka Dashboard  
                    Laporan laporan = new Laporan();
                    laporan.Show();

                    // Sembunyikan LoginForm  
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ID atau Password salah, silakan coba lagi.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void login_Click(object sender, EventArgs e)
        {
        }

        private void medipop_Click(object sender, EventArgs e)
        {
        }
    }
   
}