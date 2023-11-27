namespace XIIRPL2_20_TICKETING.MasterForm
{
    partial class Mastermaskapai
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
            label3 = new Label();
            txtPerusahaan = new TextBox();
            label4 = new Label();
            txtNama = new TextBox();
            label5 = new Label();
            txtJml_kru = new NumericUpDown();
            label8 = new Label();
            txtDeskripsi = new TextBox();
            button1 = new Button();
            btnSimpan = new Button();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJml_kru).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(277, 9);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 1;
            label1.Text = "MASTER MASKAPAI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 45);
            label2.Name = "label2";
            label2.Size = new Size(274, 15);
            label2.TabIndex = 2;
            label2.Text = "Semua Maskapai Yng Terdaftar Akan Muncul Disini";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(267, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(521, 206);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 315);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 10;
            label3.Text = "NAMA";
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(356, 347);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(169, 23);
            txtPerusahaan.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(267, 350);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 11;
            label4.Text = "PERUSAHAAN";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(356, 307);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(169, 23);
            txtNama.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(267, 384);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 14;
            label5.Text = "JUMLAH KRU";
            // 
            // txtJml_kru
            // 
            txtJml_kru.Location = new Point(356, 376);
            txtJml_kru.Name = "txtJml_kru";
            txtJml_kru.Size = new Size(169, 23);
            txtJml_kru.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(555, 315);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 21;
            label8.Text = "DESKRIPSI";
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(619, 307);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(169, 63);
            txtDeskripsi.TabIndex = 22;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Location = new Point(619, 423);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 23;
            button1.Text = "BATAL";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = SystemColors.ButtonShadow;
            btnSimpan.Location = new Point(713, 423);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 28);
            btnSimpan.TabIndex = 24;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
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
            // Mastermaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 472);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtDeskripsi);
            Controls.Add(label8);
            Controls.Add(txtJml_kru);
            Controls.Add(label5);
            Controls.Add(txtNama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPerusahaan);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Mastermaskapai";
            Text = "Mastermaskapai";
            Load += Mastermaskapai_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJml_kru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox txtPerusahaan;
        private Label label4;
        private TextBox txtNama;
        private Label label5;
        private NumericUpDown txtJml_kru;
        private Label label8;
        private TextBox txtDeskripsi;
        private Button button1;
        private Button btnSimpan;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}