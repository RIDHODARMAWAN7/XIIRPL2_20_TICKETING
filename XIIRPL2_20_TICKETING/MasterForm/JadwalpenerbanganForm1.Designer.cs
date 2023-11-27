namespace XIIRPL2_20_TICKETING.MasterForm
{
    partial class JadwalpenerbanganForm1
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown2 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(120, 9);
            label1.Name = "label1";
            label1.Size = new Size(265, 21);
            label1.TabIndex = 0;
            label1.Text = "MASTER JADWAL PENERBANGAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 40);
            label2.Name = "label2";
            label2.Size = new Size(263, 15);
            label2.TabIndex = 1;
            label2.Text = "Semua Jadwal Penerbangan Akan  Muncul Disini";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(58, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(624, 206);
            dataGridView1.TabIndex = 2;
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
            label3.Location = new Point(58, 316);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 3;
            label3.Text = "KODE PENERBANGAN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 351);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 4;
            label4.Text = "DARI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 380);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 5;
            label5.Text = "KE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 409);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 6;
            label6.Text = "MASKAPAI";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(233, 343);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(233, 372);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 8;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(233, 401);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(411, 316);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 10;
            label7.Text = "TANGGAL";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(561, 346);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(561, 377);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(411, 354);
            label8.Name = "label8";
            label8.Size = new Size(144, 15);
            label8.TabIndex = 14;
            label8.Text = "WAKTU KEBERANGKATAN";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(411, 385);
            label9.Name = "label9";
            label9.Size = new Size(134, 15);
            label9.TabIndex = 15;
            label9.Text = "DURASI PENERBANGAN";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(411, 414);
            label10.Name = "label10";
            label10.Size = new Size(101, 15);
            label10.TabIndex = 16;
            label10.Text = "HARGA PER TIKET";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(561, 310);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(561, 406);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(200, 23);
            numericUpDown2.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Location = new Point(561, 458);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 20;
            button1.Text = "BATAL";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.Location = new Point(686, 458);
            button2.Name = "button2";
            button2.Size = new Size(75, 28);
            button2.TabIndex = 21;
            button2.Text = "SIMPAN";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // JadwalpenerbanganForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 530);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "JadwalpenerbanganForm1";
            Text = "JadwalpenerbanganForm1";
            Load += JadwalpenerbanganForm1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown2;
        private Button button1;
        private Button button2;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}