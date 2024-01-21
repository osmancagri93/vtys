namespace VTYS
{
    partial class Form6
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
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox3 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(573, 398);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(204, 77);
            button1.TabIndex = 6;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(1014, 27);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(204, 63);
            button2.TabIndex = 7;
            button2.Text = "Geri Dön";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(292, 152);
            comboBox1.Margin = new Padding(6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(388, 53);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(292, 240);
            comboBox2.Margin = new Padding(6);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(388, 53);
            comboBox2.TabIndex = 9;
            comboBox2.SelectedValueChanged += comboBox2_SelectedValueChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(1014, 144);
            textBox1.Margin = new Padding(6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 50);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(1014, 240);
            textBox2.Margin = new Padding(6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 50);
            textBox2.TabIndex = 11;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 12F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Tamamlanacak", "Devam Ediyor", "Tamamlandı" });
            comboBox3.Location = new Point(515, 310);
            comboBox3.Margin = new Padding(6);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(388, 53);
            comboBox3.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.875F);
            label1.Location = new Point(15, 144);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(257, 61);
            label1.TabIndex = 13;
            label1.Text = "Proje Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 19.875F);
            label2.Location = new Point(735, 144);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(236, 61);
            label2.TabIndex = 14;
            label2.Text = "Proje ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 19.875F);
            label3.Location = new Point(15, 240);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(276, 61);
            label3.TabIndex = 15;
            label3.Text = "Görev Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 19.875F);
            label4.Location = new Point(735, 232);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(255, 61);
            label4.TabIndex = 16;
            label4.Text = "Görev ID :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 19.875F);
            label5.Location = new Point(299, 301);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(204, 61);
            label5.TabIndex = 17;
            label5.Text = "Durum :";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1261, 520);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(6);
            Name = "Form6";
            Text = "Görev Güncelle";
            FormClosing += Form6_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}