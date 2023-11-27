namespace XIIRPL2_20_TICKETING.MasterForm
{
    partial class Masterbandara
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
            button2 = new Button();
            button1 = new Button();
            txtAlamat = new TextBox();
            label8 = new Label();
            txtJmlTerminal = new NumericUpDown();
            label5 = new Label();
            txtNama = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtkode_iata = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            txtKota = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtNegara = new ComboBox();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)txtJmlTerminal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.Location = new Point(629, 437);
            button2.Name = "button2";
            button2.Size = new Size(75, 28);
            button2.TabIndex = 37;
            button2.Text = "SIMPAN";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Location = new Point(517, 437);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 36;
            button1.Text = "BATAL";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(535, 350);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(169, 63);
            txtAlamat.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(435, 350);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 34;
            label8.Text = "ALAMAT";
            // 
            // txtJmlTerminal
            // 
            txtJmlTerminal.Location = new Point(535, 302);
            txtJmlTerminal.Name = "txtJmlTerminal";
            txtJmlTerminal.Size = new Size(169, 23);
            txtJmlTerminal.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(417, 304);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 32;
            label5.Text = "JUMLAH TERMINAL";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(229, 302);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(169, 23);
            txtNama.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 345);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 30;
            label4.Text = "KODE TA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 310);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 29;
            label3.Text = "NAMA";
            // 
            // txtkode_iata
            // 
            txtkode_iata.Location = new Point(229, 342);
            txtkode_iata.Name = "txtkode_iata";
            txtkode_iata.Size = new Size(169, 23);
            txtkode_iata.TabIndex = 28;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(140, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(521, 206);
            dataGridView1.TabIndex = 27;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 40);
            label2.Name = "label2";
            label2.Size = new Size(273, 15);
            label2.TabIndex = 26;
            label2.Text = "Semua Bandara Yang Terdaftar Akan Muncul Disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(150, 4);
            label1.Name = "label1";
            label1.Size = new Size(155, 21);
            label1.TabIndex = 25;
            label1.Text = "MASTER BANDARA";
            // 
            // txtKota
            // 
            txtKota.Location = new Point(229, 385);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(169, 23);
            txtKota.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(140, 388);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 39;
            label6.Text = "KOTA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(140, 427);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 41;
            label7.Text = "NEGARA";
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(229, 424);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(169, 23);
            txtNegara.TabIndex = 42;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Text = "Edit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // Masterbandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 507);
            Controls.Add(txtNegara);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtKota);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtAlamat);
            Controls.Add(label8);
            Controls.Add(txtJmlTerminal);
            Controls.Add(label5);
            Controls.Add(txtNama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtkode_iata);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Masterbandara";
            Text = "Masterbandara";
            Load += Masterbandara_Load;
            ((System.ComponentModel.ISupportInitialize)txtJmlTerminal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private Label label8;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private ComboBox comboBox2;
        private TextBox t;
        private TextBox txtNama;
        private TextBox txtkode_iata;
        private TextBox txtKota;
        private ComboBox txtNegara;
        private NumericUpDown txtJmlTerminal;
        private TextBox txtAlamat;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}