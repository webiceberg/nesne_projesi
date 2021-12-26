using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace nesne_projesi
{
    public partial class kayitEkrani : Form
    {
        public kayitEkrani()
        {
            InitializeComponent();
           
        }
        
        private void BtnKayitOl_Click(object sender, EventArgs e)//kullanıcı bilgilerini veri tabanına kaydetme
        {
            if (TxtAd.Text == "" || TxtSoyad.Text == "" || TxtAdres.Text == "" || TxtMail.Text == "" || TxtSifre.Text == "")//tum alanlarin dolu oldugunun sorgulanmasi
            {
                MessageBox.Show("Tüm alanları doldurduğunuzdan emin olun.", "baby krafty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                Database dataBase = new Database();
                dataBase.Kayit(TxtAd.Text, TxtSoyad.Text, TxtAdres.Text, TxtMail.Text, TxtSifre.Text);
                MessageBox.Show("Sisteme kaydınız başarıyla gerçekleşmiştir.\nLütfen giriş yapınız.", "baby krafty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form = new Form1();
                form.Show();
                this.Hide();

            }

        }
    }
}
