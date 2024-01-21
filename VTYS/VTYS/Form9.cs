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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=vtys;Integrated Security=True;Encrypt=False");
        private void button2_Click(object sender, EventArgs e)
        {
            Form8 personelekran = new Form8();
            personelekran.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    int v = checkad(textBox1.Text);
                    int c = checksoyad(textBox2.Text);
                    
                    if (v != 1)
                    {
                        if(c != 1)
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("insert into personel (personel_name, personel_lastname) values (@personel_name, @personel_lastname)", con);
                            cmd.Parameters.AddWithValue("@personel_name", textBox1.Text);
                            cmd.Parameters.AddWithValue("@personel_lastname", textBox2.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Ekleme Başarılı");
                            textBox1.Text = "";
                            textBox2.Text = "";
                        }
                        


                    }
                    else
                    {
                        MessageBox.Show("Zaten kayıtlısınız");
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        int checkad(string personel_name)
        {
            con.Open();
            string queryad = "select count (*) from personel where personel_name='" + personel_name + "'";
            SqlCommand cmd = new SqlCommand(queryad, con);
            int v = (int)cmd.ExecuteScalar();
            con.Close();
            return v;
        }
        int checksoyad(string personel_lastname)
        {
            con.Open();
            string querysoyad = "select count (*) from personel where personel_lastname = '" + personel_lastname + "'";
            SqlCommand cmd = new SqlCommand(querysoyad, con);
            int c = (int)cmd.ExecuteScalar();
            con.Close();
            return c;
        }

        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

