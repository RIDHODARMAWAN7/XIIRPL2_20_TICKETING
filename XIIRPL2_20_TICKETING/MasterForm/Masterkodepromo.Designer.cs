namespace XIIRPL2_20_TICKETING.MasterForm
{
    partial class Masterkodepromo
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
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            label3 = new Label();
            Kodepromo = new TextBox();
            label4 = new Label();
            Berlakusampai = new DateTimePicker();
            label5 = new Label();
            Persentasediskon = new NumericUpDown();
            label6 = new Label();
            Maksimumdiskon = new NumericUpDown();
            label7 = new Label();
            Deskripsi = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Persentasediskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Maksimumdiskon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 21);
            label1.TabIndex = 2;
            label1.Text = "MASTER KODE PROMO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(301, 15);
            label2.TabIndex = 3;
            label2.Text = "Semua Kode Transfer Yang Terdaftar Akan Muncul Disini";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(267, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(521, 206);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 315);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 5;
            label3.Text = "KODE PROMO";
            // 
            // Kodepromo
            // 
            Kodepromo.Location = new Point(316, 307);
            Kodepromo.Name = "Kodepromo";
            Kodepromo.Size = new Size(200, 23);
            Kodepromo.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 352);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 14;
            label4.Text = "BERLAKU SAMPAI";
            // 
            // Berlakusampai
            // 
            Berlakusampai.Location = new Point(316, 344);
            Berlakusampai.Name = "Berlakusampai";
            Berlakusampai.Size = new Size(200, 23);
            Berlakusampai.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(195, 395);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 16;
            label5.Text = "PERSENTASE DISKON";
            label5.Click += label5_Click;
            // 
            // Persentasediskon
            // 
            Persentasediskon.Location = new Point(318, 387);
            Persentasediskon.Name = "Persentasediskon";
            Persentasediskon.Size = new Size(200, 23);
            Persentasediskon.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(195, 431);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 23;
            label6.Text = "MAKSIMUM DISKON";
            // 
            // Maksimumdiskon
            // 
            Maksimumdiskon.Location = new Point(318, 423);
            Maksimumdiskon.Name = "Maksimumdiskon";
            Maksimumdiskon.Size = new Size(200, 23);
            Maksimumdiskon.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(545, 315);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 25;
            label7.Text = "DESKRIPSI";
            // 
            // Deskripsi
            // 
            Deskripsi.Location = new Point(611, 307);
            Deskripsi.Multiline = true;
            Deskripsi.Name = "Deskripsi";
            Deskripsi.Size = new Size(169, 63);
            Deskripsi.TabIndex = 26;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Location = new Point(611, 431);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 27;
            button1.Text = "BATAL";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.Location = new Point(705, 431);
            button2.Name = "button2";
            button2.Size = new Size(75, 28);
            button2.TabIndex = 28;
            button2.Text = "SIMPAN";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Masterkodepromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 486);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Deskripsi);
            Controls.Add(label7);
            Controls.Add(Maksimumdiskon);
            Controls.Add(label6);
            Controls.Add(Persentasediskon);
            Controls.Add(label5);
            Controls.Add(Berlakusampai);
            Controls.Add(label4);
            Controls.Add(Kodepromo);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Masterkodepromo";
            Text = "Masterkodepromo";
            Load += Masterkodepromo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Persentasediskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)Maksimumdiskon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox Kodepromo;
        private Label label4;
        private DateTimePicker Berlakusampai;
        private Label label5;
        private NumericUpDown Persentasediskon;
        private Label label6;
        private NumericUpDown Maksimumdiskon;
        private Label label7;
        private TextBox Deskripsi;
        private Button button1;
        private Button button2;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}