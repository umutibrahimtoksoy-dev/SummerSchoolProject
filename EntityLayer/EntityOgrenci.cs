using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private int ogrId;
        private string ogrAd;
        private string ogrSoyad;
        private string ogrNumara;
        private string ogrSifre;
        private string ogrFotograf;
        private double ogrBakiye;

        public int OgrId { get => ogrId; set => ogrId = value; }
        public string OgrAd { get => ogrAd; set => ogrAd = value; }
        public string OgrSoyad { get => ogrSoyad; set => ogrSoyad = value; }
        public string OgrNumara { get => ogrNumara; set => ogrNumara = value; }
        public string OgrSifre { get => ogrSifre; set => ogrSifre = value; }
        public string OgrFotograf { get => ogrFotograf; set => ogrFotograf = value; }
        public double OgrBakiye { get => ogrBakiye; set => ogrBakiye = value; }
       
    }
}
