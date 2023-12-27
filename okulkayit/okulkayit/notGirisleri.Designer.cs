namespace okulkayit
{
    partial class notGirisleri
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
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(56, 65);
            label1.Name = "label1";
            label1.Size = new Size(189, 28);
            label1.TabIndex = 4;
            label1.Text = "Kayıtlı Öğrenciler :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(56, 179);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 5;
            label2.Text = "Ders ID :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(56, 298);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 7;
            label4.Text = "NOT :";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ScrollBar;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(267, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.ScrollBar;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(267, 174);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(267, 298);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 31);
            textBox1.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkKhaki;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(267, 423);
            button2.Name = "button2";
            button2.Size = new Size(226, 74);
            button2.TabIndex = 12;
            button2.Text = "KAYDET";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // notGirisleri
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(845, 587);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "notGirisleri";
            Text = "NOT GİRİŞİ İŞLEMLERİ";
            Load += notGirisleri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Button button2;
    }
}