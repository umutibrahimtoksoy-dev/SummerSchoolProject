using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvurular
    {
        private int basvuruId;
        private int ogrId;
        private int dersId;

        public int BasvuruId { get => basvuruId; set => basvuruId = value; }
        public int OgrId { get => ogrId; set => ogrId = value; }
        public int DersId { get => dersId; set => dersId = value; }

    }
}
