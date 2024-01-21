using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace VTYS
{
    public partial class Form3 : Form
    {
        ArrayList planlanan = new ArrayList();

        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=vtys;Integrated Security=True;Encrypt=False");

        private void Form3_Load(object sender, EventArgs e)
        {


            SqlDataAdapter da = new SqlDataAdapter("SELECT project.*, MAX(task.task_finishDate) AS enBuyuktaskBitisTarihi FROM project INNER JOIN task ON task.project_id = project.project_id WHERE project.project_id = task.project_id GROUP BY project.project_id, project.project_name, project.project_startDate, project.project_endDate, project.project_delay", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                con.Open();
                string query = "SELECT project.*, MAX(task.task_finishDate) AS enBuyuktaskBitisTarihi FROM project INNER JOIN task ON task.project_id = project.project_id WHERE project.project_id = task.project_id GROUP BY project.project_id, project.project_name, project.project_startDate, project.project_endDate, project.project_delay";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            // project_endDate sütunundan string değeri al
                            string projeBitisTarihiString = reader["project_endDate"].ToString();

                            // "enBuyuktaskBitisTarihi" ve "project_endDate" arasındaki farkı hesapla
                            if (DateTime.TryParse(item["enBuyuktaskBitisTarihi"].ToString(), out DateTime enBuyuktaskBitisTarihi) &&
                            DateTime.TryParse(item["project_endDate"].ToString(), out DateTime yeniDegisken))
                            {
                                TimeSpan fark = enBuyuktaskBitisTarihi - yeniDegisken;


                                // Fark 0'dan büyükse, gün olarak DataGridView'e ekle
                                if (fark.TotalDays > 0)
                                {
                                    dataGridView1.Rows[n].Cells[4].Value = fark.TotalDays.ToString() + " " + "gün";
                                    int farkInt = Convert.ToInt32(fark.TotalDays);

                                    // SQL sorgusu
                                    string updateQuery = $"UPDATE project SET project_delay = {farkInt} WHERE project_id = {item["project_id"]}";

                                    // SqlConnection ve SqlCommand kullanarak sorguyu çalıştırın
                                    using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=vtys;Integrated Security=True;Encrypt=False"))
                                    {
                                        connection.Open();

                                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                        {
                                            updateCommand.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz tarih formatı");
                            }


                        }
                    }

                }
                con.Close();

            }

        }







        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 projeekle = new Form4();
            projeekle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 taskpage = new Form5();
            taskpage.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 personelekran = new Form8();
            personelekran.Show();
            this.Hide();
        }
    }
}

