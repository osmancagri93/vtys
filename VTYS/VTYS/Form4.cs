﻿using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker2.MinDate = DateTime.Now;
        }
        Form3 anasayfa = new Form3();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            anasayfa.Show();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=vtys;Integrated Security=True;Encrypt=False");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    int v = check(textBox1.Text);
                    if (v != 1)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into project (project_name,project_startDate,project_endDate) values (@project_name, @project_startDate,@project_endDate)", con);
                        cmd.Parameters.AddWithValue("@project_name", textBox1.Text);
                        cmd.Parameters.AddWithValue("@project_startDate", dateTimePicker1.Text);
                        cmd.Parameters.AddWithValue("@project_endDate", dateTimePicker2.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Proje Ekleme Başarılı");
                        textBox1.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Bu isimde bir proje zaten var. Lütfen proje adınızı kontrol edin ve yeniden deneyin.");
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen proje adı giriniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int check(string project_name)
        {
            con.Open();
            string query = "select count (*) from project where project_name = '" + project_name + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            int v = (int)cmd.ExecuteScalar();
            con.Close();
            return v;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
        }
    }
}
