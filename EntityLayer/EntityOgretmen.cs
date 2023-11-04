using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgretmen
    {
        private int ogretmenId;
        private string ogretmenAdSoyad;
        private int ogretmenBrans;

        public int OgretmenId { get => ogretmenId; set => ogretmenId = value; }
        public string OgretmenAdSoyad { get => ogretmenAdSoyad; set => ogretmenAdSoyad = value; }
        public int OgretmenBrans { get => ogretmenBrans; set => ogretmenBrans = value; }
    }
}
