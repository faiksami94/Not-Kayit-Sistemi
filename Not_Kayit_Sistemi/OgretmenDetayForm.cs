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
    public partial class OgretmenDetayForm : Form
    {
        public OgretmenDetayForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-MDBPHIJH\\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True");

        private void OgretmenDetayForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbNotKayitDataSet.DersTablosu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dersTablosuTableAdapter.Fill(this.dbNotKayitDataSet.DersTablosu);

        }

        private void OgrenciKaydet_btn(object sender, EventArgs e)
        {

        }

        private void OgrNotGuncelle_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
