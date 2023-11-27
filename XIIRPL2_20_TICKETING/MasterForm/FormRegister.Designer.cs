namespace XIIRPL2_20_TICKETING.MasterForm
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "DAFTAR AKUN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 44);
            label2.Name = "label2";
            label2.Size = new Size(330, 17);
            label2.TabIndex = 1;
            label2.Text = "Daftarkan Diri Anda Untuk Menggunakan Layanan Kami";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 97);
            label3.Name = "label3";
            label3.Size = new Size(76, 17);
            label3.TabIndex = 2;
            label3.Text = "USERNAME";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(135, 209);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(220, 23);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(135, 248);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(220, 23);
            textBox5.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 134);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 8;
            label4.Text = "NAMA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 177);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 9;
            label5.Text = "TANGGAL LAHIR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 217);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 10;
            label6.Text = "NO TELP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 256);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 11;
            label7.Text = "PASSWORD";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(144, 388);
            label8.Name = "label8";
            label8.Size = new Size(113, 15);
            label8.TabIndex = 12;
            label8.Text = "Belum Punya Akun?";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Location = new Point(330, 322);
            button1.Name = "button1";
            button1.Size = new Size(89, 34);
            button1.TabIndex = 13;
            button1.Text = "DAFTAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(276, 388);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(42, 15);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "LOGIN";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(484, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 218);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(135, 169);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegister";
            Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
    }
}