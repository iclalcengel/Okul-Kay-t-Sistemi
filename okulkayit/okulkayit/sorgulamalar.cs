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
    public partial class sorgulamalar : Form
    {

        System.Data.SqlClient.SqlConnection baglanti = new System.Data.SqlClient.SqlConnection(@"Data Source=ICLAL\SQLEXPRESS;Initial Catalog=okulkayit;Integrated Security=True");

        public sorgulamalar()
        {
            InitializeComponent();
        }

        private void sorgulamalar_Load(object sender, EventArgs e)
        {
            baglanti = new System.Data.SqlClient.SqlConnection(@"Data Source=ICLAL\SQLEXPRESS;Initial Catalog=okulkayit;Integrated Security=True");
            DataTable tablo1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT DISTINCT DogumYeri FROM Ogrenciler", baglanti);
            da1.Fill(tablo1);
            comboBox1.ValueMember = "DogumYeri";
            comboBox1.DisplayMember = "DogumYeri";
            comboBox1.DataSource = tablo1;

            DataTable tablo2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Dersler", baglanti);
            da2.Fill(tablo2);
            comboBox2.ValueMember = "DersID";
            comboBox2.DisplayMember = "DersID";
            comboBox2.DataSource = tablo2;

            DataTable tablo3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Select * From Ogretmenler", baglanti);
            da3.Fill(tablo3);
            comboBox3.ValueMember = "OgretmenAdi";
            comboBox3.DisplayMember = "OgretmenAdi";
            comboBox3.DataSource = tablo3;
        }

        private void button2_Click(object sender, EventArgs e)  //seçilen dersten  50'nin altında not alanlar
        {
            int dersID = Convert.ToInt32(comboBox2.SelectedValue);

            // Sorgu ile 50'nin altında not alanları çekilir
            string sorgu = "SELECT * FROM Notlar WHERE DersID = @DersID AND [Not] < 50";
            SqlCommand sqlCommand = new SqlCommand(sorgu, baglanti);
            sqlCommand.Parameters.AddWithValue("@DersID", dersID);

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e) //dogum tarihi
        {
            string secilenDogumTarihi = dateTimePicker1.Value.ToString("yyyy-MM-dd"); // YYYY-MM-DD formatına dönüştürme

            string sorgu = "SELECT * FROM Ogrenciler WHERE DogumTarihi = @DogumTarihi";
            SqlCommand sqlCommand = new SqlCommand(sorgu, baglanti);
            sqlCommand.Parameters.AddWithValue("@DogumTarihi", secilenDogumTarihi);

            SqlDataAdapter da5 = new SqlDataAdapter(sqlCommand);
            DataTable tablo = new DataTable();
            da5.Fill(tablo);

            dataGridView1.DataSource = tablo;
        }

        private void button4_Click(object sender, EventArgs e) //dogum yeri
        {
            string secilenDogumYeri = comboBox1.Text;

            // Veritabanından doğum yeri aynı olan öğrencileri sorgulama
            DataTable sonuclarTablosu = new DataTable();
            SqlDataAdapter sorgu = new SqlDataAdapter("SELECT * FROM Ogrenciler WHERE DogumYeri = @DogumYeri", baglanti);
            sorgu.SelectCommand.Parameters.AddWithValue("@DogumYeri", secilenDogumYeri);
            sorgu.Fill(sonuclarTablosu);

            // Elde edilen sonuçları göstermek için bir DataGridView kullanabilirsiniz
            dataGridView1.DataSource = sonuclarTablosu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secilenSehir = comboBox1.Text;
            int girilenNot = Convert.ToInt32(textBox1.Text);

            // Sorgu ile seçilen şehirdeki ve belirtilen not değerinden yüksek not alan öğrenciler çekilir
            string sorgu = "SELECT * FROM Ogrenciler O INNER JOIN Notlar N ON O.OgrenciNo = N.OgrenciNo WHERE O.DogumYeri = @DogumYeri AND N.[Not] > @Not";
            SqlCommand sqlCommand = new SqlCommand(sorgu, baglanti);
            sqlCommand.Parameters.AddWithValue("@DogumYeri", secilenSehir);
            sqlCommand.Parameters.AddWithValue("@Not", girilenNot);

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e) //Geçen-kalan Öğrenci Sayısı
        {
            try
            {
                baglanti.Open();

                int secilenDersID = Convert.ToInt32(comboBox2.SelectedValue);

                // Seçilen ders ID'sine göre 50'nin altında not alan öğrencilerin sayısını bulma sorgusu
                string gecenOgrenciSorgu = "SELECT COUNT(*) FROM Notlar WHERE DersID = @DersID AND [Not] >= 50";
                SqlCommand gecenOgrenciCommand = new SqlCommand(gecenOgrenciSorgu, baglanti);
                gecenOgrenciCommand.Parameters.AddWithValue("@DersID", secilenDersID);

                int gecenOgrenciSayisi = (int)gecenOgrenciCommand.ExecuteScalar();

                // Seçilen ders ID'sine göre 50'nin üstünde not alan öğrencilerin sayısını bulma sorgusu
                string kalanOgrenciSorgu = "SELECT COUNT(*) FROM Notlar WHERE DersID = @DersID AND [Not] < 50";
                SqlCommand kalanOgrenciCommand = new SqlCommand(kalanOgrenciSorgu, baglanti);
                kalanOgrenciCommand.Parameters.AddWithValue("@DersID", secilenDersID);

                int kalanOgrenciSayisi = (int)kalanOgrenciCommand.ExecuteScalar();

                label6.Text = gecenOgrenciSayisi.ToString();
                label9.Text = kalanOgrenciSayisi.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State != ConnectionState.Closed)
                    baglanti.Close();
            }
        }
    }
}
