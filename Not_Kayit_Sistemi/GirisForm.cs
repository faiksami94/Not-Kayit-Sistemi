using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Not_Kayit_Sistemi
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void Giris_Yap_Btn_Click(object sender, EventArgs e)
        {
            OgrenciFormDetay ogrenciForm = new OgrenciFormDetay();
            ogrenciForm.numara = maskedTextBox1.Text;
            ogrenciForm.Show();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "1111")
            {
                OgretmenDetayForm ogretmen = new OgretmenDetayForm();

                ogretmen.Show();
            }
        }
    }
}
