namespace VTYS
{
    partial class Form2
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
            panel2 = new Panel();
            textBox2 = new TextBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            panel3 = new Panel();
            textBox3 = new TextBox();
            button3 = new Button();
            checkBox1 = new CheckBox();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(56, 213);
            panel2.Margin = new Padding(6, 6, 6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(488, 70);
            panel2.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gray;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.ForeColor = SystemColors.Menu;
            textBox2.Location = new Point(14, 6);
            textBox2.Margin = new Padding(6, 6, 6, 6);
            textBox2.MaxLength = 16;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(422, 50);
            textBox2.TabIndex = 3;
            textBox2.Text = "Şifre";
            textBox2.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(56, 70);
            panel1.Margin = new Padding(6, 6, 6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 70);
            panel1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gray;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.ForeColor = SystemColors.Menu;
            textBox1.Location = new Point(14, 6);
            textBox1.Margin = new Padding(6, 6, 6, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(422, 50);
            textBox1.TabIndex = 1;
            textBox1.Text = "User Name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(textBox3);
            panel3.Location = new Point(56, 329);
            panel3.Margin = new Padding(6, 6, 6, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(488, 70);
            panel3.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Gray;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 14F);
            textBox3.ForeColor = SystemColors.Menu;
            textBox3.Location = new Point(14, 6);
            textBox3.Margin = new Padding(6, 6, 6, 6);
            textBox3.MaxLength = 16;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(422, 50);
            textBox3.TabIndex = 3;
            textBox3.Text = "Şifre";
            textBox3.UseSystemPasswordChar = true;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(91, 521);
            button3.Margin = new Padding(6, 6, 6, 6);
            button3.Name = "button3";
            button3.Size = new Size(139, 66);
            button3.TabIndex = 11;
            button3.Text = "Register";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.Gray;
            checkBox1.Location = new Point(56, 442);
            checkBox1.Margin = new Padding(6, 6, 6, 6);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(208, 36);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(341, 521);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(151, 66);
            button1.TabIndex = 13;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(596, 676);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form2";
            Text = "Register";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private TextBox textBox2;
        private Panel panel1;
        private TextBox textBox1;
        private Panel panel3;
        private TextBox textBox3;
        private Button button3;
        private CheckBox checkBox1;
        private Button button1;
    }
}