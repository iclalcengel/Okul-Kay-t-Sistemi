namespace okulkayit
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(110, 72);
            label1.Name = "label1";
            label1.Size = new Size(254, 33);
            label1.TabIndex = 0;
            label1.Text = "ÖĞRENCİ BİLGİ GİRİŞİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(715, 72);
            label2.Name = "label2";
            label2.Size = new Size(189, 33);
            label2.TabIndex = 1;
            label2.Text = "NOT İŞLEMLERİ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(48, 327);
            label3.Name = "label3";
            label3.Size = new Size(391, 33);
            label3.TabIndex = 2;
            label3.Text = "ÖĞRETİM ÜYESİ-DERS İŞLEMLERİ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(673, 327);
            label4.Name = "label4";
            label4.Size = new Size(285, 33);
            label4.TabIndex = 3;
            label4.Text = "SORGULAMA İŞLEMLERİ";
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            button1.Location = new Point(147, 154);
            button1.Name = "button1";
            button1.Size = new Size(174, 83);
            button1.TabIndex = 4;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            button2.Location = new Point(730, 154);
            button2.Name = "button2";
            button2.Size = new Size(174, 83);
            button2.TabIndex = 5;
            button2.Text = "GİRİŞ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Tan;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            button3.Location = new Point(147, 407);
            button3.Name = "button3";
            button3.Size = new Size(174, 83);
            button3.TabIndex = 6;
            button3.Text = "GİRİŞ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Tan;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            button4.Location = new Point(730, 407);
            button4.Name = "button4";
            button4.Size = new Size(174, 83);
            button4.TabIndex = 7;
            button4.Text = "GİRİŞ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1055, 588);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
