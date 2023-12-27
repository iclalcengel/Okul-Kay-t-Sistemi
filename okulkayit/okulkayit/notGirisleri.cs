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
    public partial class notGirisleri : Form
    {

        System.Data.SqlClient.SqlConnection baglanti = new System.Data.SqlClient.SqlConnection(@"Data Source=ICLAL\SQLEXPRESS;Initial Catalog=okulkayit;Integrated Security=True");

        public notGirisleri()
        {
            InitializeComponent();
        }

        private void notGirisleri_Load(object sender, EventArgs e)
        {
            baglanti = new System.Data.SqlClient.SqlConnection(@"Data Source=ICLAL\SQLEXPRESS;Initial Catalog=okulkayit;Integrated Security=True");
            DataTable tablo3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Select * From Ogrenciler", baglanti);
            da3.Fill(tablo3);
            comboBox1.ValueMember = "OgrenciNo";
            comboBox1.DisplayMember = "OgrenciNo";
            comboBox1.DataSource = tablo3;

            DataTable tablo4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Select * From Dersler", baglanti);
            da4.Fill(tablo4);
            comboBox2.ValueMember = "DersID";
            comboBox2.DisplayMember = "DersID";
            comboBox2.DataSource = tablo4;

        }

        private void button2_Click(object sender, EventArgs e) //kaydet butonu
        {
            try
            {
                if (int.TryParse(textBox1.Text, out int not))
                {
                    int ogrenciNo = Convert.ToInt32(comboBox1.SelectedValue);
                    int dersID = Convert.ToInt32(comboBox2.SelectedValue);

                    baglanti.Open();
                    string sqlcumlesi = "INSERT INTO Notlar (OgrenciNo, DersID, [Not]) VALUES (@OgrenciNo, @DersID, @Not)";
                    SqlCommand sqlCommand = new SqlCommand(sqlcumlesi, baglanti);

                    sqlCommand.Parameters.AddWithValue("@OgrenciNo", ogrenciNo);
                    sqlCommand.Parameters.AddWithValue("@DersID", dersID);
                    sqlCommand.Parameters.AddWithValue("@Not", not);



                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Not kaydedildi!");
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir not girin!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not kaydedilirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State != ConnectionState.Closed)
                    baglanti.Close();
            }
        }




    }
}
