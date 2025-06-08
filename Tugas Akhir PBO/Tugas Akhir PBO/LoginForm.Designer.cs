namespace Tugas_Akhir_PBO
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            isiID = new TextBox();
            isiPassword = new TextBox();
            btntombolsignIn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            putihbox = new GroupBox();
            login = new Label();
            medipop = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            putihbox.SuspendLayout();
            SuspendLayout();
            // 
            // isiID
            // 
            isiID.BackColor = SystemColors.InactiveBorder;
            isiID.ForeColor = SystemColors.WindowFrame;
            isiID.Location = new Point(38, 151);
            isiID.Multiline = true;
            isiID.Name = "isiID";
            isiID.Size = new Size(300, 40);
            isiID.TabIndex = 0;
            isiID.Text = "ID";
            // 
            // isiPassword
            // 
            isiPassword.BackColor = SystemColors.InactiveBorder;
            isiPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isiPassword.ForeColor = SystemColors.WindowFrame;
            isiPassword.Location = new Point(38, 223);
            isiPassword.Multiline = true;
            isiPassword.Name = "isiPassword";
            isiPassword.Size = new Size(300, 40);
            isiPassword.TabIndex = 1;
            isiPassword.Text = "Password";
            isiPassword.TextChanged += isiPassword_TextChanged;
            // 
            // btntombolsignIn
            // 
            btntombolsignIn.BackColor = SystemColors.Highlight;
            btntombolsignIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntombolsignIn.ForeColor = Color.White;
            btntombolsignIn.ImageAlign = ContentAlignment.MiddleRight;
            btntombolsignIn.Location = new Point(135, 345);
            btntombolsignIn.Name = "btntombolsignIn";
            btntombolsignIn.Size = new Size(98, 40);
            btntombolsignIn.TabIndex = 3;
            btntombolsignIn.Text = "Sign in";
            btntombolsignIn.UseVisualStyleBackColor = false;
            btntombolsignIn.Click += tombolLogin_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(560, 392);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 340);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // putihbox
            // 
            putihbox.BackColor = SystemColors.ButtonHighlight;
            putihbox.Controls.Add(isiID);
            putihbox.Controls.Add(isiPassword);
            putihbox.Controls.Add(btntombolsignIn);
            putihbox.Controls.Add(login);
            putihbox.Location = new Point(414, 12);
            putihbox.Name = "putihbox";
            putihbox.Size = new Size(374, 426);
            putihbox.TabIndex = 6;
            putihbox.TabStop = false;
            // 
            // login
            // 
            login.AutoSize = true;
            login.BackColor = SystemColors.ButtonHighlight;
            login.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login.ForeColor = SystemColors.ActiveCaption;
            login.Location = new Point(113, 27);
            login.Name = "login";
            login.Size = new Size(147, 38);
            login.TabIndex = 2;
            login.Text = "Welcome!";
            login.Click += login_Click;
            // 
            // medipop
            // 
            medipop.AutoSize = true;
            medipop.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            medipop.ForeColor = Color.FromArgb(47, 84, 104);
            medipop.Location = new Point(83, 347);
            medipop.Name = "medipop";
            medipop.Size = new Size(208, 50);
            medipop.TabIndex = 7;
            medipop.Text = "MEDIPOP";
            //medipop.Click += label2_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(medipop);
            Controls.Add(putihbox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            putihbox.ResumeLayout(false);
            putihbox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox isiID;
        private TextBox isiPassword;
        private Button btntombolsignIn;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox putihbox;
        public Label login;
        private Label medipop;
    }
}
