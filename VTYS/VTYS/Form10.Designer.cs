namespace VTYS
{
    partial class Form10
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(372, 504);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(296, 101);
            button1.TabIndex = 11;
            button1.Text = "İstatistikleri Görüntüle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1214, 31);
            button2.Margin = new Padding(6, 6, 6, 6);
            button2.Name = "button2";
            button2.Size = new Size(251, 62);
            button2.TabIndex = 12;
            button2.Text = "Geri Dön";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(644, 70);
            comboBox1.Margin = new Padding(6, 6, 6, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(247, 53);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(797, 402);
            textBox1.Margin = new Padding(6, 6, 6, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 50);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(797, 288);
            textBox2.Margin = new Padding(6, 6, 6, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(94, 50);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(797, 179);
            textBox3.Margin = new Padding(6, 6, 6, 6);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(94, 50);
            textBox3.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.875F);
            label1.Location = new Point(22, 168);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(531, 61);
            label1.TabIndex = 17;
            label1.Text = "Devam Eden Görevler :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 19.875F);
            label2.Location = new Point(22, 279);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(576, 61);
            label2.TabIndex = 18;
            label2.Text = "Tamamlanacak Görevler :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 19.875F);
            label3.Location = new Point(22, 393);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(542, 61);
            label3.TabIndex = 19;
            label3.Text = "Tamamlanan Görevler : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 19.875F);
            label4.Location = new Point(22, 62);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(345, 61);
            label4.TabIndex = 20;
            label4.Text = "Çalışanın Adı :";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(936, 267);
            listBox1.Margin = new Padding(6, 6, 6, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(472, 260);
            listBox1.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 19.875F);
            label5.Location = new Point(936, 179);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(489, 61);
            label5.TabIndex = 22;
            label5.Text = "Görevler ve Projeler :";
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1844, 642);
            Controls.Add(label5);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form10";
            Text = "İstatistik Sayfası";
            FormClosing += Form10_FormClosing;
            Load += Form10_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private Label label5;
    }
}