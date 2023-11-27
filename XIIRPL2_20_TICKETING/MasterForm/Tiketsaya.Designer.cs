namespace XIIRPL2_20_TICKETING.MasterForm
{
    partial class Tiketsaya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tiketsaya));
            button3 = new Button();
            label5 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 41);
            button3.TabIndex = 24;
            button3.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(104, 17);
            label5.Name = "label5";
            label5.Size = new Size(114, 25);
            label5.TabIndex = 25;
            label5.Text = "TIKET SAYA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(104, 42);
            label7.Name = "label7";
            label7.Size = new Size(259, 15);
            label7.TabIndex = 28;
            label7.Text = "Semua tiket anda yang aktif akan muncul di sini";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Location = new Point(27, 113);
            panel3.Name = "panel3";
            panel3.Size = new Size(746, 257);
            panel3.TabIndex = 29;
            // 
            // Tiketsaya
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(button3);
            Name = "Tiketsaya";
            Text = "Tiketsaya";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label5;
        private Label label7;
        private Panel panel3;
    }
}