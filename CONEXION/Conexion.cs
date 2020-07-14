using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONEXION
{
    public class Conexion
    {
        public static string CadenaSql()
        {
            var conn = "Data Source=.;Initial Catalog=DBMONITORWEB;Integrated Security=True";
            return conn;
        }
    }
}
