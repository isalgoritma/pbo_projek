namespace Tugas_Akhir_PBO
{
    partial class Penjadwalan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Penjadwalan));
            Done = new Button();
            Kembali = new Button();
            dateTimePicker2 = new DateTimePicker();
            pasienID = new TextBox();
            ObatIsi = new TextBox();
            DosisIsi = new TextBox();
            idpasien = new Label();
            isiObat = new Label();
            isiDosis = new Label();
            isiDiagnosis = new Label();
            DiagnosaIsi = new TextBox();
            jadwalinput = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Done
            // 
            Done.Location = new Point(676, 404);
            Done.Name = "Done";
            Done.Size = new Size(112, 34);
            Done.TabIndex = 0;
            Done.Text = "Done";
            Done.UseVisualStyleBackColor = true;
            Done.Click += Done_Click;
            // 
            // Kembali
            // 
            Kembali.Location = new Point(558, 404);
            Kembali.Name = "Kembali";
            Kembali.Size = new Size(112, 34);
            Kembali.TabIndex = 1;
            Kembali.Text = "Back";
            Kembali.UseVisualStyleBackColor = true;
            Kembali.Click += Kembali_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(254, 102);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 2;
            dateTimePicker2.Value = new DateTime(2025, 6, 13, 19, 4, 29, 0);
            // 
            // pasienID
            // 
            pasienID.Location = new Point(269, 158);
            pasienID.Name = "pasienID";
            pasienID.Size = new Size(347, 31);
            pasienID.TabIndex = 4;
            // 
            // ObatIsi
            // 
            ObatIsi.Location = new Point(237, 210);
            ObatIsi.Name = "ObatIsi";
            ObatIsi.Size = new Size(379, 31);
            ObatIsi.TabIndex = 5;
            // 
            // DosisIsi
            // 
            DosisIsi.Location = new Point(237, 256);
            DosisIsi.Name = "DosisIsi";
            DosisIsi.Size = new Size(379, 31);
            DosisIsi.TabIndex = 6;
            // 
            // idpasien
            // 
            idpasien.AutoSize = true;
            idpasien.Location = new Point(179, 162);
            idpasien.Name = "idpasien";
            idpasien.Size = new Size(84, 25);
            idpasien.TabIndex = 8;
            idpasien.Text = "ID Pasien";
            idpasien.Click += label2_Click;
            // 
            // isiObat
            // 
            isiObat.AutoSize = true;
            isiObat.Location = new Point(179, 213);
            isiObat.Name = "isiObat";
            isiObat.Size = new Size(52, 25);
            isiObat.TabIndex = 9;
            isiObat.Text = "Obat";
            // 
            // isiDosis
            // 
            isiDosis.AutoSize = true;
            isiDosis.Location = new Point(179, 259);
            isiDosis.Name = "isiDosis";
            isiDosis.Size = new Size(56, 25);
            isiDosis.TabIndex = 10;
            isiDosis.Text = "Dosis";
            // 
            // isiDiagnosis
            // 
            isiDiagnosis.AutoSize = true;
            isiDiagnosis.Location = new Point(179, 305);
            isiDiagnosis.Name = "isiDiagnosis";
            isiDiagnosis.Size = new Size(188, 25);
            isiDiagnosis.TabIndex = 11;
            isiDiagnosis.Text = "Penyakit yang Diderita";
            // 
            // DiagnosaIsi
            // 
            DiagnosaIsi.Location = new Point(373, 302);
            DiagnosaIsi.Name = "DiagnosaIsi";
            DiagnosaIsi.Size = new Size(243, 31);
            DiagnosaIsi.TabIndex = 12;
            // 
            // jadwalinput
            // 
            jadwalinput.AutoSize = true;
            jadwalinput.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jadwalinput.ForeColor = SystemColors.HotTrack;
            jadwalinput.Location = new Point(157, 30);
            jadwalinput.Name = "jadwalinput";
            jadwalinput.Size = new Size(490, 44);
            jadwalinput.TabIndex = 13;
            jadwalinput.Text = "Penjadwalan Konsumsi Obat";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Penjadwalan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(jadwalinput);
            Controls.Add(DiagnosaIsi);
            Controls.Add(isiDiagnosis);
            Controls.Add(isiDosis);
            Controls.Add(isiObat);
            Controls.Add(idpasien);
            Controls.Add(DosisIsi);
            Controls.Add(ObatIsi);
            Controls.Add(pasienID);
            Controls.Add(dateTimePicker2);
            Controls.Add(Kembali);
            Controls.Add(Done);
            Name = "Penjadwalan";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Done;
        private Button Kembali;
        private DateTimePicker dateTimePicker2;
        private TextBox pasienID;
        private TextBox ObatIsi;
        private TextBox DosisIsi;
        private Label idpasien;
        private Label isiObat;
        private Label isiDosis;
        private Label isiDiagnosis;
        private TextBox DiagnosaIsi;
        private Label jadwalinput;
        private PictureBox pictureBox1;
    }
}