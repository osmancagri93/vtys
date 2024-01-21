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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            LoadProjeData();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=vtys;Integrated Security=True;Encrypt=False");
        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 taskpage = new Form5();
            taskpage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            

            try
            {
                // ComboBox3'teki seçili durumu al
                string yeniDurum = comboBox3.SelectedItem.ToString();

                // ComboBox2'den seçilen görev_id'sini al
                int selectedtaskID = Convert.ToInt32(comboBox2.SelectedValue);

                // Görev durumunu güncelle
                UpdatetaskDurum(selectedtaskID, yeniDurum);

                // Kullanıcıya güncelleme başarılı mesajını göster
                MessageBox.Show("Görev durumu güncellendi.");

                // ComboBox2'yi ve TextBox'ları yeniden yükle
                LoadtaskData(Convert.ToInt32(comboBox2.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Görev durumu güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void UpdatetaskDurum(int taskID, string yeniDurum)
        {
            try
            {
                con.Open();
                DateTime bugun = new DateTime();
                bugun = DateTime.Now;
                
                

                // Görev durumunu güncelle
                string updateQuery = "UPDATE task SET task_status = @task_status WHERE task_id = @task_id";
                SqlCommand updateCommand = new SqlCommand(updateQuery, con);
                updateCommand.Parameters.AddWithValue("@task_status", yeniDurum);
                updateCommand.Parameters.AddWithValue("@task_id", taskID);
                updateCommand.ExecuteNonQuery();
                if(yeniDurum == "Tamamlandı")
                {
                    string updateDate = "UPDATE task SET task_finishDate = @task_finishDate WHERE task_id = @task_id";
                    SqlCommand updateDatecmd = new SqlCommand(updateDate, con);
                    updateDatecmd.Parameters.AddWithValue("@task_finishDate", bugun);
                    updateDatecmd.Parameters.AddWithValue("@task_id", taskID);
                    updateDatecmd.ExecuteNonQuery();
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("Görev durumu güncellenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void LoadProjeData()
        {
            try
            {
                con.Open();

                // ComboBox1'e project_id'leri yükle
                string projeQuery = "SELECT project_id, project_name FROM project";
                SqlDataAdapter projeAdapter = new SqlDataAdapter(projeQuery, con);
                DataTable projeTable = new DataTable();
                projeAdapter.Fill(projeTable);

                comboBox1.DataSource = projeTable;
                comboBox1.ValueMember = "project_id";
                comboBox1.DisplayMember = "project_name";

                // ComboBox1'de seçim değiştiğinde olayı tanımla
                comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Proje verileri yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void LoadtaskData(int projeID)
        {
            try
            {
                con.Open();

                // ComboBox2'ye project_id'ye ait görev_id'leri yükle
                string taskQuery = "SELECT task_id, task_name FROM task WHERE project_id = @project_id";
                SqlDataAdapter taskAdapter = new SqlDataAdapter(taskQuery, con);
                taskAdapter.SelectCommand.Parameters.AddWithValue("@project_id", projeID);
                DataTable taskTable = new DataTable();
                taskAdapter.Fill(taskTable);

                comboBox2.DataSource = taskTable;
                comboBox2.ValueMember = "task_id";
                comboBox2.DisplayMember = "task_name";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Görev verileri yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ComboBox2'den seçilen görev_id'sini al
            int selectedtaskID = Convert.ToInt32(comboBox2.SelectedValue);

            // TextBox'a seçilen görevin bilgilerini yükle
            LoadtaskDetails(selectedtaskID);
        }
        private void LoadtaskDetails(int taskID)
        {
            try
            {
                con.Open();

                // Seçilen görev_id'ye ait görev detaylarını al
                string detailsQuery = "SELECT * FROM task WHERE task_id = @task_id";
                SqlDataAdapter detailsAdapter = new SqlDataAdapter(detailsQuery, con);
                detailsAdapter.SelectCommand.Parameters.AddWithValue("@task_id", taskID);
                DataTable detailsTable = new DataTable();
                detailsAdapter.Fill(detailsTable);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Görev detayları yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ComboBox1'den seçilen project_id'sini al
            int selectedProjeID = Convert.ToInt32(comboBox1.SelectedValue);

            // ComboBox2'ye seçilen project_id'ye ait görev_id'leri yükle
            LoadtaskData(selectedProjeID);
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedValue.ToString();
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = comboBox2.SelectedValue.ToString();
        }
    }
}
