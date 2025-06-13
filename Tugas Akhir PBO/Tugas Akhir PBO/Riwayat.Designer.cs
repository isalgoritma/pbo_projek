namespace Tugas_Akhir_PBO
{
    partial class Riwayat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Riwayat));
            dataGridView1 = new DataGridView();
            refrsh = new Button();
            Kembali2 = new Button();
            RiwayatKesehatan = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(801, 347);
            dataGridView1.TabIndex = 0;
            // 
            // refrsh
            // 
            refrsh.ForeColor = SystemColors.HotTrack;
            refrsh.Location = new Point(677, 416);
            refrsh.Name = "refrsh";
            refrsh.Size = new Size(112, 34);
            refrsh.TabIndex = 1;
            refrsh.Text = "Refresh";
            refrsh.UseVisualStyleBackColor = true;
            // 
            // Kembali2
            // 
            Kembali2.ForeColor = SystemColors.HotTrack;
            Kembali2.Location = new Point(559, 416);
            Kembali2.Name = "Kembali2";
            Kembali2.Size = new Size(112, 34);
            Kembali2.TabIndex = 2;
            Kembali2.Text = "Back";
            Kembali2.UseVisualStyleBackColor = true;
            Kembali2.Click += button1_Click;
            // 
            // RiwayatKesehatan
            // 
            RiwayatKesehatan.AutoSize = true;
            RiwayatKesehatan.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RiwayatKesehatan.ForeColor = Color.FromArgb(0, 64, 64);
            RiwayatKesehatan.Location = new Point(236, 9);
            RiwayatKesehatan.Name = "RiwayatKesehatan";
            RiwayatKesehatan.Size = new Size(336, 44);
            RiwayatKesehatan.TabIndex = 3;
            RiwayatKesehatan.Text = "Riwayat Kesehatan";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Riwayat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(RiwayatKesehatan);
            Controls.Add(Kembali2);
            Controls.Add(refrsh);
            Controls.Add(dataGridView1);
            Name = "Riwayat";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button refrsh;
        private Button Kembali2;
        private Label RiwayatKesehatan;
        private PictureBox pictureBox1;
    }
}