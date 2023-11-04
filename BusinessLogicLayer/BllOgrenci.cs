using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;


namespace BusinessLogicLayer
{
    public class BllOgrenci
    {
       
        public static int ogrenciEkle(EntityOgrenci p)
        {
            if (p.OgrAd != "" && p.OgrSoyad !="" && p.OgrNumara != "" && p.OgrFotograf != "" && p.OgrSifre!="")
            {
                return DalOgrenci.ogrenciEkle(p);
            }
            return -1;
        }

        public static List<EntityOgrenci> ogrenciListele()
        {
            return DalOgrenci.ogrenciListele();
        }


        public static bool ogrenciSil(int id)
        {
            if (id > 0)
            {
               return DalOgrenci.ogrenciSil(id);
            }
            return false;
        }

        public static EntityOgrenci ogrenciDetay(int id)
        {                    
                return DalOgrenci.ogrenciDetay(id);            
        }

        public static int ogrenciGuncelle(EntityOgrenci p)
        {
            if (p.OgrAd != "" && p.OgrSoyad != "" && p.OgrNumara != "" && p.OgrFotograf != "" && p.OgrSifre != "")
            {
                return DalOgrenci.ogrenciGuncelle(p);
            }
            return -1;
        }

        public static List<EntityDersler> dersListele()
        {

            return DalOgrenci.dersListele();
        }

        public static int dersTalep(EntityBasvurular nesne)
        {
            if (nesne.OgrId >0 && nesne.DersId > 0)
            {
                return DataLessons.dersTalep(nesne);
            }
            return -1;
        }
    }
}
