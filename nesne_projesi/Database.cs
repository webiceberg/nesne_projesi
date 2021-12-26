using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace nesne_projesi
{
    public class Database
    {
        public OleDbConnection baglan;
        //public OleDbCommand ara;
        public void baglanti() // veritabanını bağlama
        {
            baglan = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\win10\OneDrive\Desktop\armut\nesne_projesi\bin\Debug\kullaniciVerileri.mdb");
            baglan.Open();
        }

        public void kapat()
        {
            baglan.Close();
        }

        public void Kayit(string ad, string soyad, string adres, string mail, string sifre) //kullanici verilerini sisteme kaydetme
        {
            baglanti();
            OleDbCommand ekle = new OleDbCommand("insert into veriler(ad, soyad, adres, mail, sifre) values(@p1, @p2, @p3, @p4, @p5)", baglan);
            ekle.Connection = baglan;

            ekle.Parameters.AddWithValue("@p1", ad);
            ekle.Parameters.AddWithValue("@p2", soyad);
            ekle.Parameters.AddWithValue("@p3", adres);
            ekle.Parameters.AddWithValue("@p4", mail);
            ekle.Parameters.AddWithValue("@p5", sifre);
            ekle.ExecuteNonQuery();
            kapat();

        }


        public string kullaniciID = "";
        public bool giris(string mail, string sifre)//kullanici giris verilerinin databaseden sorgulanmasi
        {

            baglanti();
            OleDbCommand kontrol = new OleDbCommand("SELECT * From veriler Where mail=@p1 and sifre=@p2", baglan);

            kontrol.Parameters.AddWithValue("@p1", mail);
            kontrol.Parameters.AddWithValue("@p2", sifre);
            OleDbDataReader oku = kontrol.ExecuteReader();
            return oku.Read();
        }


        public string idBulucu(string mail, string sifre)//kullanici id alma
        {
            baglanti();

            OleDbCommand kontrol = new OleDbCommand("SELECT * From veriler Where mail=@p1 and sifre=@p2", baglan);

            kontrol.Parameters.AddWithValue("@p1", mail);
            kontrol.Parameters.AddWithValue("@p2", sifre);
            OleDbDataReader bul = kontrol.ExecuteReader();
            bul.Read();
            kullaniciID = bul["ID"].ToString();
            return kullaniciID;
        }


        public void urunKayit(string ad, string kategori, string renk, string cinsiyet, string beden, string aciklama, float fiyat, string satildi)//ürünleri sisteme kaydetme
        {
            baglanti();
            OleDbCommand urunEkle = new OleDbCommand("insert into urunler(urunAd, urunKategori, urunRenk, urunCinsiyet, urunBeden, urunAciklama, urunFiyat, satildi) values(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", baglan);
            urunEkle.Connection = baglan;

            urunEkle.Parameters.AddWithValue("@p1", ad);
            urunEkle.Parameters.AddWithValue("@p2", kategori);
            urunEkle.Parameters.AddWithValue("@p3", renk);
            urunEkle.Parameters.AddWithValue("@p4", cinsiyet);
            urunEkle.Parameters.AddWithValue("@p5", beden);
            urunEkle.Parameters.AddWithValue("@p6", aciklama);
            urunEkle.Parameters.AddWithValue("@p7", fiyat);
            urunEkle.Parameters.AddWithValue("@p8", satildi);

            urunEkle.ExecuteNonQuery();
            kapat();

        }
        public void urunSil(int ID) // urun silme
        {
            baglanti();
            OleDbCommand urunSil = new OleDbCommand("Delete From urunler where urunID = @p1", baglan);
            urunSil.Parameters.AddWithValue("@p1", ID);
            urunSil.ExecuteNonQuery();
            kapat();
        }

        public void urunGuncelle(string ad, string kategori, string renk, string cinsiyet, string beden, string aciklama, float fiyat, string satildi, int ID)//ürünü güncelleme
        {
            baglanti();
            OleDbCommand urunGuncelle = new OleDbCommand("update urunler set urunAd = @p1, urunKategori = @p2, urunRenk = @p3, urunCinsiyet = @p4, urunBeden = @p5, urunAciklama = @p6, urunFiyat = @p7, satildi = @p8 where (urunID = @p9)", baglan);

            urunGuncelle.Parameters.AddWithValue("@p1", ad);
            urunGuncelle.Parameters.AddWithValue("@p2", kategori);
            urunGuncelle.Parameters.AddWithValue("@p3", renk);
            urunGuncelle.Parameters.AddWithValue("@p4", cinsiyet);
            urunGuncelle.Parameters.AddWithValue("@p5", beden);
            urunGuncelle.Parameters.AddWithValue("@p6", aciklama);
            urunGuncelle.Parameters.AddWithValue("@p7", fiyat);
            urunGuncelle.Parameters.AddWithValue("@p8", satildi);
            urunGuncelle.Parameters.AddWithValue("@p9", ID);

            urunGuncelle.ExecuteNonQuery();
            kapat();
        }
        public void Updating(int alıcıID, int urunID)
        {

            baglanti();
            OleDbCommand urunGuncelle = new OleDbCommand("update urunler set  satildi = '1',aliciID=@p1, kargoDurumu= 'kargo hazırlanıyor'  where (urunID = @p2)", baglan);

            urunGuncelle.Parameters.AddWithValue("@p1", alıcıID);
            urunGuncelle.Parameters.AddWithValue("@p2", urunID);

            urunGuncelle.ExecuteNonQuery();
            kapat();

        }


    }
}
