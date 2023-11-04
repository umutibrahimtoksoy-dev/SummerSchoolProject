using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Connection
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-8U8104Q;Initial Catalog=YazOkulu;Integrated Security=True");
    }
}
