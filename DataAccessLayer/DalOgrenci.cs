using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
namespace DataAccessLayer
{
    
    public class DalOgrenci
    {
        public static List<EntityOgrenci> ogrenciListele()
        {       
            List<EntityOgrenci> liste = new List<EntityOgrenci>();
            SqlCommand cmd1 = new SqlCommand("select * from Ogrenci", Connection.con);
            if (cmd1.Connection.State != ConnectionState.Open)
            {
                cmd1.Connection.Open();
            }
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.OgrId = Convert.ToInt32(dr["ogrId"].ToString());
                ent.OgrAd = dr["ogrAd"].ToString();
                ent.OgrSoyad = dr["ogrSoyad"].ToString();
                ent.OgrNumara = dr["ogrNumara"].ToString();
                ent.OgrFotograf = dr["ogrFotograf"].ToString();
                ent.OgrSifre = dr["ogrSifre"].ToString();
                ent.OgrBakiye = Convert.ToDouble(dr["ogrBakiye"].ToString());
                liste.Add(ent);
            }
            dr.Close();
            return liste;

        }

        public static int ogrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand cmd2 = new SqlCommand("insert into Ogrenci (ogrAd,ogrSoyad,ogrNumara,ogrFotograf,ogrSifre) values (@p1,@p2,@p3,@p4,@p5)", Connection.con);
            cmd2.Parameters.AddWithValue("@p1", parametre.OgrAd);
            cmd2.Parameters.AddWithValue("@p2", parametre.OgrSoyad);
            cmd2.Parameters.AddWithValue("@p3", parametre.OgrNumara);
            cmd2.Parameters.AddWithValue("@p4", parametre.OgrFotograf);
            cmd2.Parameters.AddWithValue("@p5", parametre.OgrSifre);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
           
            return cmd2.ExecuteNonQuery();
        }

        public static bool ogrenciSil(int id)
        {
            SqlCommand cmd3 = new SqlCommand("delete from Ogrenci where ogrId=@p1", Connection.con);
            cmd3.Parameters.AddWithValue("@p1", id);
            if (cmd3.Connection.State != ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }
            return cmd3.ExecuteNonQuery() > 0;
        }

        public static EntityOgrenci ogrenciDetay(int id)
        {
            EntityOgrenci ent = new EntityOgrenci();
            SqlCommand cmd1 = new SqlCommand("select * from Ogrenci where ogrId=@ogrId", Connection.con);
            cmd1.Parameters.AddWithValue("@ogrId", id);
            if (cmd1.Connection.State != ConnectionState.Open)
            {
                cmd1.Connection.Open();
            }
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {            
                ent.OgrAd = dr["ogrAd"].ToString();
                ent.OgrSoyad = dr["ogrSoyad"].ToString();
                ent.OgrNumara = dr["ogrNumara"].ToString();
                ent.OgrFotograf = dr["ogrFotograf"].ToString();
                ent.OgrSifre = dr["ogrSifre"].ToString();
                ent.OgrBakiye = Convert.ToDouble(dr["ogrBakiye"].ToString());              
            }
            dr.Close();
            return ent;

        }


        public static int ogrenciGuncelle(EntityOgrenci nesne)
        {
            SqlCommand cmd2 = new SqlCommand("update Ogrenci set ogrAd=@p1,ogrSoyad=@p2,ogrNumara=@p3,ogrFotograf=@p4,ogrSifre=@p5 where OgrId=@p6", Connection.con);
            cmd2.Parameters.AddWithValue("@p1", nesne.OgrAd);
            cmd2.Parameters.AddWithValue("@p2", nesne.OgrSoyad);
            cmd2.Parameters.AddWithValue("@p3", nesne.OgrNumara);
            cmd2.Parameters.AddWithValue("@p4", nesne.OgrFotograf);
            cmd2.Parameters.AddWithValue("@p5", nesne.OgrSifre);
            cmd2.Parameters.AddWithValue("@p6", nesne.OgrId);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }

            return cmd2.ExecuteNonQuery();
        }

        public static List<EntityDersler> dersListele()
        {
            List<EntityDersler> liste = new List<EntityDersler>();
            SqlCommand cmd1 = new SqlCommand("select * from Dersler", Connection.con);
            if (cmd1.Connection.State != ConnectionState.Open)
            {
                cmd1.Connection.Open();
            }
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {        
                EntityDersler ent = new EntityDersler();
                ent.DersId = Convert.ToInt32(dr["dersId"]);
                ent.DersAd = dr["dersAd"].ToString();
                ent.MinKontenjan = Convert.ToInt32(dr["dersMinKontenjan"]);
                ent.MaxKontenjan = Convert.ToInt32(dr["dersMaxKontenjan"]);
                liste.Add(ent);
            }
            dr.Close();
            return liste;

        }


    }
}
