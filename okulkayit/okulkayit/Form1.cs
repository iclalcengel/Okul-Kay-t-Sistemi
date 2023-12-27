using System.Data.SqlClient;

namespace okulkayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=ICLAL\SQLEXPRESS;Initial Catalog=okulkayit;Integrated Security=True;Trust Server Certificate=True");
        

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciBilgileri ogrenciBilgileri = new ogrenciBilgileri();
            ogrenciBilgileri.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            notGirisleri notGirisleri = new notGirisleri();
            notGirisleri.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dersEkleme dersEkleme = new dersEkleme();
            dersEkleme.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sorgulamalar sorgulamalar = new sorgulamalar();
            sorgulamalar.Show();
        }
    }
}
