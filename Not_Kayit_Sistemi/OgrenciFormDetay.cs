using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Not_Kayit_Sistemi
{
    public partial class OgrenciFormDetay : Form
    {
        public OgrenciFormDetay()
        {
            InitializeComponent();
        }

        public string numara;

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-MDBPHIJH\\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True");
        
        
        private void OgrenciFormDetay_Load(object sender, EventArgs e)
        {
            OgrNumaraLabel.Text = numara;

            baglanti.Open();

            SqlCommand command = new SqlCommand("Select * From DersTablosu where OgrNo=@p1", baglanti);
            command.Parameters.AddWithValue("@p1",numara);
            SqlDataReader reader= command.ExecuteReader();
            while(reader.Read())
            {
                AdSoyadLabel.Text = reader[2].ToString()+ " " + reader[3].ToString();
                Sinav1_Label.Text = reader[4].ToString();
                Sinav2_Label.Text = reader[5].ToString();
                Sinav3_Label.Text = reader[6].ToString();
                Ortalama_Label.Text = reader[7].ToString();
                Durum_Label.Text = reader[8].ToString();
            }
            baglanti.Close();
        }
        
    }
}
