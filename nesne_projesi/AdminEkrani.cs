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
    public partial class AdminEkrani : Form
    {
        public AdminEkrani() 
        {
            InitializeComponent();
            listele();
        } 
        Database data = new Database();

        string satildi = "";
 
        private void RdbSatildi_CheckedChanged(object sender, EventArgs e)
        {

            satildi = "1";
        }

        private void RdbSatilmadi_CheckedChanged(object sender, EventArgs e)
        {
            satildi = "0";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // datagridviewe tıklandığında verileri textboxlara aktarma
        {
            int secilen = DgvAdmin.SelectedCells[0].RowIndex;

            TxtUrunID.Text = DgvAdmin.Rows[secilen].Cells[0].Value.ToString();
            TxtUrunAd.Text = DgvAdmin.Rows[secilen].Cells[1].Value.ToString();
            CmdUrunKategori.Text = DgvAdmin.Rows[secilen].Cells[2].Value.ToString();
            TxtUrunRenk.Text = DgvAdmin.Rows[secilen].Cells[3].Value.ToString();
            CmdUrunCinsiyet.Text = DgvAdmin.Rows[secilen].Cells[4].Value.ToString();
            TxtUrunBeden.Text = DgvAdmin.Rows[secilen].Cells[5].Value.ToString();
            TxtUrunAciklama.Text = DgvAdmin.Rows[secilen].Cells[6].Value.ToString();
            TxtUrunFiyat.Text = DgvAdmin.Rows[secilen].Cells[7].Value.ToString();
            if (DgvAdmin.Rows[secilen].Cells[8].Value.ToString() == "True")
            {
                RdbSatildi.Checked = true;
            }
            else
            {
                RdbSatilmadi.Checked = true;
            }

        }
        private void BtnUrunEkle_Click(object sender, EventArgs e) //yeni ürün ekleme
        {
            
            data.urunKayit(TxtUrunAd.Text, CmdUrunKategori.Text, TxtUrunRenk.Text, CmdUrunCinsiyet.Text, TxtUrunBeden.Text, TxtUrunAciklama.Text, Convert.ToInt64(TxtUrunFiyat.Text), satildi);
            MessageBox.Show("Ürünlerin kaydı sisteme başarıyla gerçekleşmiştir", "baby krafty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void BtnUrunGuncelle_Click(object sender, EventArgs e) //ürün güncelleme
        {
            data.urunGuncelle(TxtUrunAd.Text, CmdUrunKategori.Text, TxtUrunRenk.Text, CmdUrunCinsiyet.Text, TxtUrunBeden.Text, TxtUrunAciklama.Text, Convert.ToInt64(TxtUrunFiyat.Text), satildi, Convert.ToInt32(TxtUrunID.Text));
            MessageBox.Show("Ürün  başarıyla güncellenmiştir", "baby krafty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }


        private void BtnUrunSil_Click(object sender, EventArgs e) //ürün silme
        {
            if (MessageBox.Show("Ürünü silmek istiyor musunuz?", "baby krafty", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                data.urunSil(Convert.ToInt32(TxtUrunID.Text));
                listele();
            }

        }

        private void BtnUrunAra_Click(object sender, EventArgs e) // urun arama
        {
            OleDbCommand ara = new OleDbCommand("select * from urunler where urunAd = @p1 or urunKategori = @p1 or urunRenk = @p1 or urunCinsiyet = @p1 or urunBeden = @p1 or urunAciklama = @p1", data.baglan);
            ara.Parameters.AddWithValue("@p1", TxtUrunAra.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(ara);
            da.Fill(dt);
            DgvAdmin.DataSource = dt;
        }

        public void listele() //tüm ürünleri listeleme
        {
            data.baglanti();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select urunID, urunAd, urunKategori, urunRenk, urunCinsiyet, urunBeden, urunAciklama, urunFiyat, satildi, aliciID, kargoDurumu  from urunler", data.baglan);
            da.Fill(dt);
            DgvAdmin.DataSource = dt;

        }
        

        private void BtnTumunuListele_Click(object sender, EventArgs e) // tüm ürünleri listeleme
        {
            listele();
        }

        private void BtnSatilanListele_Click(object sender, EventArgs e) // satılanları listeleme<
        {
            data.baglanti();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select urunID, urunAd, urunKategori, urunRenk, urunCinsiyet, urunBeden, urunAciklama, urunFiyat, satildi, aliciID, kargoDurumu from urunler Where satildi = True", data.baglan);
            da.Fill(dt);
            DgvAdmin.DataSource = dt;
        }

        private void BtnSatilmayanListele_Click(object sender, EventArgs e) // satılmayanları listeleme
        {
            data.baglanti();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select urunID, urunAd, urunKategori, urunRenk, urunCinsiyet, urunBeden, urunAciklama, urunFiyat, satildi, aliciID, kargoDurumu from urunler Where satildi = False", data.baglan);
            da.Fill(dt);
            DgvAdmin.DataSource = dt;
        }

        private void TxtCikis_Click(object sender, EventArgs e) //giriş ekranına geri dönme
        {
            if (MessageBox.Show("Çıkış Yapmak İstiyor musunuz?", "baby krafty", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }

        }

        private void TxtUrunFiyat_KeyPress(object sender, KeyPressEventArgs e) //fiyat kısmına sadece sayı girmeyi sağlıyor
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void TxtUrunAra_KeyPress(object sender, KeyPressEventArgs e) // arama kısmına sadece harf gırmeyı saglıyor
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
