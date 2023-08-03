using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection sql = new SqlConnection(@"Data Source=ONUR-BILGISAYAR;Initial Catalog=Db_YazOkulu;Integrated Security=True");

    }
}
