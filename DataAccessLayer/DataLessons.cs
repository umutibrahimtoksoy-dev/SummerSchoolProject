using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
   public class DataLessons
    {
        public static int dersTalep(EntityBasvurular nesne)
        {
            SqlCommand cmd2 = new SqlCommand("insert into DersBasvurular (OgrId,DersId) values (@p1,@p2)", Connection.con);
            cmd2.Parameters.AddWithValue("@p1", nesne.OgrId);
            cmd2.Parameters.AddWithValue("@p2", nesne.DersId);         
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }

            return cmd2.ExecuteNonQuery();
        }
    }
}
