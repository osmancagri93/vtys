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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=vtys;Integrated Security=True;Encrypt=False");
        SqlCommand cm = new SqlCommand();

        private void Form10_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 personelekran = new Form8();
            personelekran.Show();
            this.Hide();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
             SqlDataReader oku2;
             con.Open();
             cm.Connection = con;
             cm.CommandText = "select * from personel";
             oku2 = cm.ExecuteReader();
             while (oku2.Read())
             {
                 comboBox1.Items.Add(oku2[1].ToString() + " " + oku2[2].ToString());
             }
             con.Close();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = comboBox1.SelectedItem.ToString(); // "Adı Soyadı" formatında bir değer varsayalım
            string[] adSoyad = metin.Split(' ');


            string adi = adSoyad[0];
            string soyadi = adSoyad[1];

            con.Open();
            string sorgu = $"SELECT personel_id FROM personel WHERE personel_name = '{adi}' AND personel_lastname = '{soyadi}'";
            SqlCommand cmd2 = new SqlCommand(sorgu, con);
            int cid = Convert.ToInt32(cmd2.ExecuteScalar());

            string sorgu2 = $"SELECT COUNT(*) AS tamamlanan_task_sayisi FROM task WHERE personel_id = '{cid}' AND task_status = 'Tamamlandı'";
            SqlCommand cmd = new SqlCommand(sorgu2, con);
            int tamamlanantaskSayisi = Convert.ToInt32(cmd.ExecuteScalar());
            textBox1.Text = tamamlanantaskSayisi.ToString();

            string sorgu3 = $"SELECT COUNT(*) AS tamamlanan_task_sayisi FROM task WHERE personel_id = '{cid}' AND task_status = 'Tamamlanacak'";
            SqlCommand cmd3 = new SqlCommand(sorgu3, con);
            int tamamlanacaktaskSayisi = Convert.ToInt32(cmd3.ExecuteScalar());
            textBox2.Text = tamamlanacaktaskSayisi.ToString();

            string sorgu4 = $"SELECT COUNT(*) AS tamamlanan_task_sayisi FROM task WHERE personel_id = '{cid}' AND task_status = 'Devam Ediyor'";
            SqlCommand cmd4 = new SqlCommand(sorgu4,con);
            int devamedentaskSayisi = Convert.ToInt32(cmd4.ExecuteScalar());
            textBox3.Text = devamedentaskSayisi.ToString();

            string sorgu5 = $"SELECT task.task_name, project.project_name FROM task INNER JOIN project ON task.project_id = project.project_id WHERE task.personel_id ='{cid}'";
            SqlCommand cmd5 = new SqlCommand(sorgu5,con);
            using (SqlDataReader reader = cmd5.ExecuteReader())
                {
    
                    // ListBox'ı temizleyin
                    listBox1.Items.Clear();

                    // Her bir kayıt için işlem yapın
                    while (reader.Read())
                    {
                        // 'task_name' ve 'project_name' değerini ListBox'a ekleyin
                        listBox1.Items.Add(reader["task_name"].ToString()+ " ---> " + reader["project_name"].ToString());
                    }
                }
            con.Close();
        }
    }
}
