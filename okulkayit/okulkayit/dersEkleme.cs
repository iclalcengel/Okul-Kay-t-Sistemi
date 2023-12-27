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

namespace okulkayit
{
    public partial class dersEkleme : Form
    {

        System.Data.SqlClient.SqlConnection baglanti = new System.Data.SqlClient.SqlConnection(@"Data Source=ICLAL\SQLEXPRESS;Initial Catalog=okulkayit;Integrated Security=True");

        public dersEkleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //ogretmen ekleme
        {
            try
            {
                baglanti.Open();
                string sqlcumlesi = "INSERT INTO Ogretmenler (OgretmenAdi, OgretmenID) VALUES (@OgretmenAdi, @OgretmenID)";
                SqlCommand sqlCommand = new SqlCommand(sqlcumlesi, baglanti);

                sqlCommand.Parameters.AddWithValue("@OgretmenAdi", textBox1.Text);
                sqlCommand.Parameters.AddWithValue("@OgretmenID", textBox2.Text);


                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Öğretim üyesi bilgileri başarıyla kaydedildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğretim üyesi eklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) //ders ekleme
        {
            try
            {
                baglanti.Open();
                string sqlcumlesi = "INSERT INTO Dersler (DersID, DersAdi, OgretmenID) VALUES (@DersID, @DersAdi, @OgretmenID)";
                SqlCommand sqlCommand = new SqlCommand(sqlcumlesi, baglanti);

                sqlCommand.Parameters.AddWithValue("@DersID", textBox3.Text);
                sqlCommand.Parameters.AddWithValue("@DersAdi", textBox4.Text);
                sqlCommand.Parameters.AddWithValue("@OgretmenID", textBox2.Text);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Ders bilgileri başarıyla kaydedildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ders eklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)   //ogretim uyesi sil
        {
            try
            {
                string ogretmenAdi = comboBox1.Text;

                baglanti.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Ogretmenler WHERE OgretmenAdi = @OgretmenAdi", baglanti);
                cmd.Parameters.AddWithValue("@OgretmenAdi", ogretmenAdi);

                int affectedRows = cmd.ExecuteNonQuery();
                baglanti.Close();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Seçilen öğretmen başarıyla silindi!");
                    // Yenileme işlemi gerekirse burada comboBox1'in yenilenmesi yapılabilir.
                }
                else
                {
                    MessageBox.Show("Öğretmen silinemedi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğretmen silinirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State != ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dersEkleme_Load(object sender, EventArgs e)
        {
            baglanti = new System.Data.SqlClient.SqlConnection(@"Data Source=ICLAL\SQLEXPRESS;Initial Catalog=okulkayit;Integrated Security=True");
            DataTable tablo1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Ogretmenler", baglanti);
            da1.Fill(tablo1);
            comboBox1.ValueMember = "OgretmenID";
            comboBox1.DisplayMember = "OgretmenAdi";
            comboBox1.DataSource = tablo1;

            DataTable tablo2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Dersler", baglanti);
            da2.Fill(tablo2);
            comboBox2.ValueMember = "DersID";
            comboBox2.DisplayMember = "DersAdi";
            comboBox2.ValueMember = "OgretmenID";
            comboBox2.DataSource = tablo2;
        }

        private void button4_Click(object sender, EventArgs e)  //ders silme
        {
            try
            {
                string dersAdi = comboBox2.Text;

                baglanti.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Dersler WHERE DersAdi = @DersAdi", baglanti);
                cmd.Parameters.AddWithValue("@DersAdi", dersAdi);

                int affectedRows = cmd.ExecuteNonQuery();
                baglanti.Close();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Seçilen ders başarıyla silindi!");
                    // Yenileme işlemi gerekirse burada comboBox2'nin yenilenmesi yapılabilir.
                }
                else
                {
                    MessageBox.Show("Ders silinemedi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ders silinirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State != ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e) //ogretim uyesi güncelleme
        {
            try
            {
                baglanti.Open();
                string sqlcumlesi = "UPDATE Ogretmenler SET OgretmenAdi = @OgretmenAdi WHERE OgretmenID = @OgretmenID";
                SqlCommand sqlCommand = new SqlCommand(sqlcumlesi, baglanti);

                sqlCommand.Parameters.AddWithValue("@OgretmenAdi", textBox1.Text);
                sqlCommand.Parameters.AddWithValue("@OgretmenID", textBox2.Text);

                int affectedRows = sqlCommand.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Öğretim üyesi bilgileri başarıyla güncellendi!");
                }
                else
                {
                    MessageBox.Show("Güncellenecek öğretim üyesi bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğretim üyesi güncellenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e) //ders güncelleme
        {
            try
            {
                baglanti.Open();
                string sqlcumlesi = "UPDATE Dersler SET DersAdi = @DersAdi, OgretmenID = @OgretmenID WHERE DersID = @DersID";
                SqlCommand sqlCommand = new SqlCommand(sqlcumlesi, baglanti);

                sqlCommand.Parameters.AddWithValue("@DersID", textBox3.Text);
                sqlCommand.Parameters.AddWithValue("@DersAdi", textBox4.Text);
                sqlCommand.Parameters.AddWithValue("@OgretmenID", textBox2.Text);

                int affectedRows = sqlCommand.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Ders bilgileri başarıyla güncellendi!");
                }
                else
                {
                    MessageBox.Show("Güncellenecek ders bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ders güncellenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }
    }
}
