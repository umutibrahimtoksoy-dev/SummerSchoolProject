using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDersler
    {
        private int dersId;
        private string dersAd;
        private int minKontenjan;
        private int maxKontenjan;

        public int DersId { get => dersId; set => dersId = value; }
        public string DersAd { get => dersAd; set => dersAd = value; }
        public int MinKontenjan { get => minKontenjan; set => minKontenjan = value; }
        public int MaxKontenjan { get => maxKontenjan; set => maxKontenjan = value; }
    }
}
