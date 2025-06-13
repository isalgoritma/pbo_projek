namespace Tugas_Akhir_PBO
{
    partial class DataPasien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataPasien));
            nama = new Label();
            nohp = new Label();
            identitas = new Label();
            umurnya = new Label();
            kamar = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            data = new Label();
            pictureBox1 = new PictureBox();
            Done2 = new Button();
            Kembali5 = new Button();
            pasienID = new Label();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nama
            // 
            nama.AutoSize = true;
            nama.Location = new Point(46, 165);
            nama.Name = "nama";
            nama.Size = new Size(113, 25);
            nama.TabIndex = 0;
            nama.Text = "Nama Pasien";
            // 
            // nohp
            // 
            nohp.AutoSize = true;
            nohp.Location = new Point(46, 240);
            nohp.Name = "nohp";
            nohp.Size = new Size(64, 25);
            nohp.TabIndex = 1;
            nohp.Text = "No HP";
            // 
            // identitas
            // 
            identitas.AutoSize = true;
            identitas.Location = new Point(46, 277);
            identitas.Name = "identitas";
            identitas.Size = new Size(74, 25);
            identitas.TabIndex = 2;
            identitas.Text = "Keluhan";
            // 
            // umurnya
            // 
            umurnya.AutoSize = true;
            umurnya.Location = new Point(46, 203);
            umurnya.Name = "umurnya";
            umurnya.Size = new Size(56, 25);
            umurnya.TabIndex = 3;
            umurnya.Text = "Umur";
            // 
            // kamar
            // 
            kamar.AutoSize = true;
            kamar.Location = new Point(46, 314);
            kamar.Name = "kamar";
            kamar.Size = new Size(0, 25);
            kamar.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(126, 378);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 237);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(308, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(131, 274);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(293, 31);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(165, 162);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(259, 31);
            textBox6.TabIndex = 11;
            // 
            // data
            // 
            data.AutoSize = true;
            data.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            data.ForeColor = Color.FromArgb(0, 64, 64);
            data.Location = new Point(125, 73);
            data.Name = "data";
            data.Size = new Size(212, 44);
            data.TabIndex = 12;
            data.Text = "Data Pasien";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(491, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 340);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Done2
            // 
            Done2.Location = new Point(225, 404);
            Done2.Name = "Done2";
            Done2.Size = new Size(112, 34);
            Done2.TabIndex = 14;
            Done2.Text = "Done";
            Done2.UseVisualStyleBackColor = true;
            // 
            // Kembali5
            // 
            Kembali5.Location = new Point(107, 404);
            Kembali5.Name = "Kembali5";
            Kembali5.Size = new Size(112, 34);
            Kembali5.TabIndex = 15;
            Kembali5.Text = "Back";
            Kembali5.UseVisualStyleBackColor = true;
            Kembali5.Click += Kembali5_Click;
            // 
            // pasienID
            // 
            pasienID.AutoSize = true;
            pasienID.Location = new Point(46, 314);
            pasienID.Name = "pasienID";
            pasienID.Size = new Size(84, 25);
            pasienID.TabIndex = 16;
            pasienID.Text = "ID Pasien";
            pasienID.Click += this.label1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 311);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(288, 31);
            textBox3.TabIndex = 17;
            // 
            // DataPasien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(pasienID);
            Controls.Add(Kembali5);
            Controls.Add(Done2);
            Controls.Add(pictureBox1);
            Controls.Add(data);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(kamar);
            Controls.Add(umurnya);
            Controls.Add(identitas);
            Controls.Add(nohp);
            Controls.Add(nama);
            Name = "DataPasien";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nama;
        private Label nohp;
        private Label identitas;
        private Label umurnya;
        private Label kamar;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label data;
        private PictureBox pictureBox1;
        private Button Done2;
        private Button Kembali5;
        private Label pasienID;
        private TextBox textBox3;
    }
}