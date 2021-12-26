using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne_projesi
{
    class items
    {
        public static List<items> ite = new List<items>();
        public int urunID { get; set; }

        public int customerId { get; set; }
        public float amount { get; set; }
        public string urunAd { get; set; }
    }
}
