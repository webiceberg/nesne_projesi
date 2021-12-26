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
    public partial class Form1 : Form
    {
       public static int currentId;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {

            kayitEkrani kayit = new kayitEkrani();
            kayit.Show();
            this.Hide();

        }

        private void BtnGirisYap_Click_1(object sender, EventArgs e)//kullanıcı adı şifre kontrolü
        {

            if (TxtMailGiris.Text == "" || TxtSifreGiris.Text == "")
            {
                MessageBox.Show("Tüm alanları doldurduğunuzdan emin olun.", "baby krafty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                if (TxtMailGiris.Text == "admin" || TxtSifreGiris.Text == "admin")
                {
                    AdminEkrani admin = new AdminEkrani();
                    admin.Show();
                    this.Hide();

                }
                else
                {
                    Database dataBase = new Database();
                    
                    if (dataBase.giris(TxtMailGiris.Text, TxtSifreGiris.Text))// Eğer bağlantı başarı ile sağlanıp kullanıcı adı ve şifre doğru olması durumunda yapılacak işlemler.
                    {
                        Customer a = new Customer();
                        a.customerİd = "";
                        a.customerPass = "";

                        Database database = new Database();
                        a.customerİd = TxtMailGiris.Text;
                        a.customerPass = TxtSifreGiris.Text;

                        currentId = Convert.ToInt32(dataBase.idBulucu(a.customerİd, a.customerPass));

                        




                        musteriArayuzu form = new musteriArayuzu();
                        form.Show();
                        this.Hide();

                    }

                    else
                    {
                        MessageBox.Show("Hatalı kullanıcı adı veya şifre tekrar deneyiniz.", "baby krafty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    dataBase.kapat();

                }



            }
        }
    }
}
