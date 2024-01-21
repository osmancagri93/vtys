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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 loginpage = new Form1();
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            loginpage.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false; textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true; textBox3.UseSystemPasswordChar = true;
            }
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=vtys;Integrated Security=True;Encrypt=False");
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    if (textBox2.Text == textBox3.Text)
                    {
                        int v = check(textBox1.Text);
                        if (v != 1)
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("INSERT INTO member values (@member_name, @member_password)", con);
                            cmd.Parameters.AddWithValue("@member_name", textBox1.Text);
                            cmd.Parameters.AddWithValue("@member_password", textBox2.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Kayıt Başarılı");
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("Zaten kayıtlısınız");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler eşleşmiyor");
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
        int check(string member_name)
        {
            con.Open();
            string query = "select count (*) from member where member_name='" + member_name + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            int v = (int)cmd.ExecuteScalar();
            con.Close();
            return v;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginpage.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
