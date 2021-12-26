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
    public partial class musteriArayuzu : Form
    {
        List<items> a = new List<items>();
        public musteriArayuzu()
        {
            InitializeComponent();
            listele();
        }
        Database data = new Database();
        private void listele() //tüm ürünleri listeleme
        {
            data.baglanti();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select urunID, urunAd, urunKategori, urunRenk, urunCinsiyet, urunBeden, urunAciklama, urunFiyat from urunler Where satildi = False ", data.baglan);
            da.Fill(dt);
            DgvMusteri.DataSource = dt;

        }
        private void KategoriListele(string p1) //katagorilere gore listeleme
        {
            data.baglanti();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select urunID, urunAd, urunKategori, urunRenk, urunCinsiyet, urunBeden, urunAciklama, urunFiyat from urunler Where satildi = False and urunKategori = @p1", data.baglan);
            da.SelectCommand.Parameters.AddWithValue("@p1", p1);
            da.Fill(dt);
            DgvMusteri.DataSource = dt;

        }

        private void BtnTumunuGoster_Click(object sender, EventArgs e)
        {
            listele();
        }

        //kategorilere göre listeleme
        private void BtnPantolon_Click(object sender, EventArgs e)
        {
            KategoriListele("pantolon");
        }

        private void BtnElbise_Click(object sender, EventArgs e)
        {
            KategoriListele("elbise");
        }

        private void BtnTshirt_Click(object sender, EventArgs e)
        {
            KategoriListele("tshirt");
        }

        private void BtnTulum_Click(object sender, EventArgs e)
        {
            KategoriListele("tulum");
        }

        private void BtnDisGiyim_Click(object sender, EventArgs e)
        {
            KategoriListele("dış giyim");
        }



        private void BtnCikis_Click(object sender, EventArgs e) //çıkış butonu
        {
            if (MessageBox.Show("Çıkış Yapmak İstiyor musunuz?", "baby krafty", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }

        private void TxtArama_Click(object sender, EventArgs e)
        {
            TxtArama.Text = "";
        }

        private void TxtArama_KeyPress(object sender, KeyPressEventArgs e) // arama kısmına sadece harf yazdırmak ıcın
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void BtnAra_Click(object sender, EventArgs e) // ürün arama
        {
            OleDbCommand ara = new OleDbCommand("select * from urunler where urunAd = @p1 or urunKategori = @p1 or urunRenk = @p1 or urunCinsiyet = @p1 or urunBeden = @p1 or urunAciklama = @p1", data.baglan);
            ara.Parameters.AddWithValue("@p1", TxtArama.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(ara);
            da.Fill(dt);
            DgvMusteri.DataSource = dt;
        }

        private void BtnSepet_Click(object sender, EventArgs e)
        {
            Sepet s1 = new Sepet();


            s1.Show();
        }

        public int geciciID = 0;
        public float geciciAmount = 0;
        public string geciciAd = "";
        public int secilen;
 

        private void BtnSepeteEkle_Click(object sender, EventArgs e)
        {

            a = items.ite;
            

            items i1 = new items();



            i1.amount = geciciAmount;
            i1.urunID = geciciID;
            i1.urunAd = geciciAd;
            i1.customerId = Form1.currentId;
            a.Add(i1);
            MessageBox.Show("Ürününüz Başarıyla Sepete Eklendi!");       
            

            items.ite = a;
        }

        private void DgvMusteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = DgvMusteri.SelectedCells[0].RowIndex;

            geciciID = Convert.ToInt32(DgvMusteri.Rows[secilen].Cells[0].Value.ToString());

            geciciAmount = Convert.ToInt64(DgvMusteri.Rows[secilen].Cells[7].Value.ToString());

            geciciAd = DgvMusteri.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
