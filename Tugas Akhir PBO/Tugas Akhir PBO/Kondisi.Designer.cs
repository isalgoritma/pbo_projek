namespace Tugas_Akhir_PBO
{
    partial class Kondisi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kondisi));
            textBox1 = new TextBox();
            suhu = new Label();
            Jantung = new Label();
            textBox2 = new TextBox();
            Darah = new Label();
            textBox3 = new TextBox();
            NamePasien = new Label();
            textBox4 = new TextBox();
            noKamar = new Label();
            textBox5 = new TextBox();
            kondisiKesehatan = new Label();
            pictureBox1 = new PictureBox();
            sudah = new Button();
            Kembali3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 31);
            textBox1.TabIndex = 0;
            // 
            // suhu
            // 
            suhu.AutoSize = true;
            suhu.Location = new Point(59, 202);
            suhu.Name = "suhu";
            suhu.Size = new Size(104, 25);
            suhu.TabIndex = 1;
            suhu.Text = "Suhu tubuh";
            // 
            // Jantung
            // 
            Jantung.AutoSize = true;
            Jantung.Location = new Point(409, 199);
            Jantung.Name = "Jantung";
            Jantung.Size = new Size(125, 25);
            Jantung.TabIndex = 2;
            Jantung.Text = "Detak Jantung";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(540, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 31);
            textBox2.TabIndex = 3;
            // 
            // Darah
            // 
            Darah.AutoSize = true;
            Darah.Location = new Point(59, 257);
            Darah.Name = "Darah";
            Darah.Size = new Size(127, 25);
            Darah.TabIndex = 4;
            Darah.Text = "Tekanan Darah";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(190, 251);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(168, 31);
            textBox3.TabIndex = 5;
            // 
            // NamePasien
            // 
            NamePasien.AutoSize = true;
            NamePasien.Location = new Point(59, 153);
            NamePasien.Name = "NamePasien";
            NamePasien.Size = new Size(113, 25);
            NamePasien.TabIndex = 6;
            NamePasien.Text = "Nama Pasien";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(178, 150);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(180, 31);
            textBox4.TabIndex = 7;
            // 
            // noKamar
            // 
            noKamar.AutoSize = true;
            noKamar.Location = new Point(409, 153);
            noKamar.Name = "noKamar";
            noKamar.Size = new Size(95, 25);
            noKamar.TabIndex = 8;
            noKamar.Text = "No. Kamar";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(510, 150);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(198, 31);
            textBox5.TabIndex = 9;
            // 
            // kondisiKesehatan
            // 
            kondisiKesehatan.AutoSize = true;
            kondisiKesehatan.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kondisiKesehatan.ForeColor = SystemColors.HotTrack;
            kondisiKesehatan.Location = new Point(223, 58);
            kondisiKesehatan.Name = "kondisiKesehatan";
            kondisiKesehatan.Size = new Size(326, 44);
            kondisiKesehatan.TabIndex = 10;
            kondisiKesehatan.Text = "Kondisi Kesehatan";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // sudah
            // 
            sudah.Location = new Point(687, 415);
            sudah.Name = "sudah";
            sudah.Size = new Size(112, 34);
            sudah.TabIndex = 17;
            sudah.Text = "Done";
            sudah.UseVisualStyleBackColor = true;
            // 
            // Kembali3
            // 
            Kembali3.Location = new Point(569, 415);
            Kembali3.Name = "Kembali3";
            Kembali3.Size = new Size(112, 34);
            Kembali3.TabIndex = 18;
            Kembali3.Text = "Back";
            Kembali3.UseVisualStyleBackColor = true;
            Kembali3.Click += Kembali3_Click;
            // 
            // Kondisi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Kembali3);
            Controls.Add(sudah);
            Controls.Add(pictureBox1);
            Controls.Add(kondisiKesehatan);
            Controls.Add(textBox5);
            Controls.Add(noKamar);
            Controls.Add(textBox4);
            Controls.Add(NamePasien);
            Controls.Add(textBox3);
            Controls.Add(Darah);
            Controls.Add(textBox2);
            Controls.Add(Jantung);
            Controls.Add(suhu);
            Controls.Add(textBox1);
            Name = "Kondisi";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label suhu;
        private Label Jantung;
        private TextBox textBox2;
        private Label Darah;
        private TextBox textBox3;
        private Label NamePasien;
        private TextBox textBox4;
        private Label noKamar;
        private TextBox textBox5;
        private Label kondisiKesehatan;
        private PictureBox pictureBox1;
        private Button sudah;
        private Button Kembali3;
    }
}