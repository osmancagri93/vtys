namespace VTYS
{
    partial class Form4
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ControlText;
            textBox1.Location = new Point(352, 143);
            textBox1.Margin = new Padding(6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(436, 43);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.875F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(41, 125);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(257, 61);
            label1.TabIndex = 3;
            label1.Text = "Proje Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 19.875F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(41, 210);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(405, 61);
            label2.TabIndex = 4;
            label2.Text = "Başlangıç Tarihi :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(593, 217);
            dateTimePicker1.Margin = new Padding(6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(195, 50);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2024, 1, 15, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(300, 400);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(251, 62);
            button1.TabIndex = 10;
            button1.Text = "Proje Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(537, 21);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(251, 62);
            button2.TabIndex = 11;
            button2.Text = "Geri Dön";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 19.875F);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(41, 307);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(296, 61);
            label3.TabIndex = 12;
            label3.Text = "Bitiş Tarihi :";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(593, 307);
            dateTimePicker2.Margin = new Padding(6);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(195, 50);
            dateTimePicker2.TabIndex = 13;
            dateTimePicker2.Value = new DateTime(2024, 1, 15, 0, 0, 0, 0);
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(815, 497);
            Controls.Add(dateTimePicker2);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(6);
            Name = "Form4";
            Text = "Proje Ekle";
            FormClosing += Form4_FormClosing;
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Label label3;
        private DateTimePicker dateTimePicker2;
    }
}