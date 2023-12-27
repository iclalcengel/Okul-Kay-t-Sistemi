using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace okulkayit
{
    public partial class ogrenciBilgileri : Form
    {
        System.Data.SqlClient.SqlConnection baglanti = new System.Data.SqlClient.SqlConnection(@"Data Source=ICLAL\SQLEXPRESS;Initial Catalog=okulkayit;Integrated Security=True");

        public ogrenciBilgileri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sqlcumlesi = "INSERT INTO Ogrenciler (OgrenciNo, OgrenciAd, DogumYeri, DogumTarihi) VALUES (@OgrenciNo, @OgrenciAd, @DogumYeri, @DogumTarihi)";
                SqlCommand sqlCommand = new SqlCommand(sqlcumlesi, baglanti);

                sqlCommand.Parameters.AddWithValue("@OgrenciNo", textBox1.Text);
                sqlCommand.Parameters.AddWithValue("@OgrenciAd", textBox2.Text);
                sqlCommand.Parameters.AddWithValue("@DogumYeri", textBox3.Text);
                sqlCommand.Parameters.AddWithValue("@DogumTarihi", dateTimePicker1.Value);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Öğrenci bilgileri başarıyla kaydedilmiştir!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci eklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sqlcumlesi = "UPDATE Ogrenciler SET OgrenciAd = @OgrenciAd, DogumYeri = @DogumYeri, DogumTarihi = @DogumTarihi WHERE OgrenciNo = @OgrenciNo";
                SqlCommand sqlCommand = new SqlCommand(sqlcumlesi, baglanti);

                sqlCommand.Parameters.AddWithValue("@OgrenciAd", textBox2.Text);
                sqlCommand.Parameters.AddWithValue("@DogumYeri", textBox3.Text);
                sqlCommand.Parameters.AddWithValue("@DogumTarihi", dateTimePicker1.Value);
                sqlCommand.Parameters.AddWithValue("@OgrenciNo", textBox1.Text);

                int affectedRows = sqlCommand.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Öğrenci bilgileri başarıyla güncellendi!");
                }
                else
                {
                    MessageBox.Show("Güncellenecek öğrenci bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci güncellenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        private void ogrenciBilgileri_Load(object sender, EventArgs e)
        {
            baglanti = new System.Data.SqlClient.SqlConnection(@"Data Source=ICLAL\SQLEXPRESS;Initial Catalog=okulkayit;Integrated Security=True");
            DataTable tablo3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Select * From Ogrenciler", baglanti);
            da3.Fill(tablo3);
            comboBox1.ValueMember = "OgrenciNo";
            comboBox1.DisplayMember = "OgrenciAd";
            comboBox1.DataSource = tablo3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string ogrenciAd = comboBox1.Text;

                baglanti.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Ogrenciler WHERE OgrenciAd = @OgrenciAd", baglanti);
                cmd.Parameters.AddWithValue("@OgrenciAd", ogrenciAd);

                int affectedRows = cmd.ExecuteNonQuery();
                baglanti.Close();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Seçilen öğrenci başarıyla silindi!");
                    // Yenileme işlemi gerekirse burada comboBox1'in yenilenmesi yapılabilir.
                }
                else
                {
                    MessageBox.Show("Öğrenci silinemedi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci silinirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State != ConnectionState.Closed)
                    baglanti.Close();
            }
        }
    }
}
