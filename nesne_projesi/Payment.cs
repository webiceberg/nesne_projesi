using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesne_projesi
{
    public partial class Payment : Form
    {
        Database dataBase = new Database();
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            Amount.Text = Sepet.totals.ToString(); 
        }

        private void CreditCard_Click(object sender, EventArgs e)
        {
            Credit credit = new Credit();
            credit.Show();

        }

        private void Cash_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            List<items> item3 = new List<items>();
            item3 = items.ite;

            foreach (var item in item3)
            {
                database.Updating(Form1.currentId, item.urunID);
                MessageBox.Show("Ürünler Kargoya verilmiştir.");
            }

            
        }

        private void CouponEnter_Click(object sender, EventArgs e)
        {

        }

    


    }
}
