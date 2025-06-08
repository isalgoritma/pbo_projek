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

            if (isiID.Text == idCorrect && isiPassword.Text == passwordCorrect)
            {
                StartForm startForm = new StartForm(); 
                this.Hide();
            }
            else
            {
                MessageBox.Show("ID atau Password salah, silakan coba lagi.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    public partial class  StartForm : Form
    {
        public StartForm()
        {
            this.Text = "Login";
            this.Size = new System.Drawing.Size(400, 300);
            Label welcomeLabel = new Label();
            welcomeLabel.Text = "Welcome to Medipop!";
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new System.Drawing.Point(120, 120);
            this.Controls.Add(welcomeLabel);
        }
    }
}
