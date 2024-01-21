namespace VTYS
{
    partial class Form5
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewComboBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column9, Column2, Column3, Column4, Column6, Column5, Column8, Column7, Column10 });
            dataGridView1.Location = new Point(39, 107);
            dataGridView1.Margin = new Padding(6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1688, 625);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Project ID";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 90;
            // 
            // Column9
            // 
            Column9.HeaderText = "Project Name";
            Column9.MinimumWidth = 10;
            Column9.Name = "Column9";
            Column9.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Task ID";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 70;
            // 
            // Column3
            // 
            Column3.HeaderText = "Task Name";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Start Date";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column6
            // 
            Column6.HeaderText = "End Date";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            Column6.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "A/G Value";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.Width = 80;
            // 
            // Column8
            // 
            Column8.HeaderText = "Personel Name";
            Column8.MinimumWidth = 10;
            Column8.Name = "Column8";
            Column8.Width = 200;
            // 
            // Column7
            // 
            Column7.HeaderText = "Status";
            Column7.Items.AddRange(new object[] { "Tamamlanacak", "Devam Ediyor", "Tamamlandı" });
            Column7.MinimumWidth = 10;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 160;
            // 
            // Column10
            // 
            Column10.HeaderText = "Finish Date";
            Column10.MinimumWidth = 10;
            Column10.Name = "Column10";
            Column10.Width = 200;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(284, 26);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(251, 62);
            button1.TabIndex = 10;
            button1.Text = "Durum Güncelle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(22, 26);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(251, 62);
            button2.TabIndex = 11;
            button2.Text = "Görev Ekle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(1414, 26);
            button4.Margin = new Padding(6);
            button4.Name = "button4";
            button4.Size = new Size(251, 62);
            button4.TabIndex = 13;
            button4.Text = "Geri Dön";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1756, 747);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(6);
            Name = "Form5";
            Text = "Görev Listesi";
            FormClosing += Form5_FormClosing;
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewComboBoxColumn Column7;
        private DataGridViewTextBoxColumn Column10;
    }
}