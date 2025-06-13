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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Dashboard));
            konfirmasinya = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            masukkanID = new TextBox();
            pictureBox1 = new PictureBox();
            this.kembali4 = new Button();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // konfirmasinya
            // 
            konfirmasinya.AutoSize = true;
            konfirmasinya.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            konfirmasinya.ForeColor = Color.FromArgb(0, 64, 64);
            konfirmasinya.Location = new Point(254, 108);
            konfirmasinya.Name = "konfirmasinya";
            konfirmasinya.Size = new Size(290, 44);
            konfirmasinya.TabIndex = 0;
            konfirmasinya.Text = "Status Konsumsi";
            // 
            // button1
            // 
            button1.Location = new Point(340, 262);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Done";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(244, 216);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 2;
            // 
            // masukkanID
            // 
            masukkanID.ForeColor = SystemColors.WindowFrame;
            masukkanID.Location = new Point(320, 170);
            masukkanID.Name = "masukkanID";
            masukkanID.Size = new Size(150, 31);
            masukkanID.TabIndex = 3;
            masukkanID.Text = "ID Pasien";
            masukkanID.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // kembali4
            // 
            this.kembali4.Location = new Point(687, 414);
            this.kembali4.Name = "kembali4";
            this.kembali4.Size = new Size(112, 34);
            this.kembali4.TabIndex = 6;
            this.kembali4.Text = "Back";
            this.kembali4.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(this.kembali4);
            Controls.Add(pictureBox1);
            Controls.Add(masukkanID);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(konfirmasinya);
            Name = "Dashboard";
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
    }
}
