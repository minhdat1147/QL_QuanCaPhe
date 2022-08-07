using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-SOF5J9B\SQLEXPRESS;Initial Catalog=QL_QUANCAPHE;Integrated Security=True");
    }
}
