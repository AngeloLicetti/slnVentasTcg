using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcgGestionDatos
{
    public class ConexionBD
    {
        public static string CadenaConexion
        {
            get
            {
                 return "Data source=LAPTOP-MH9EOD8T\\SQLEXPRESS01;initial catalog=DBVENTASTCG;integrated security = SSPI;";
                 //return "Data source=(local);initial catalog=DBVENTASTCG;integrated security = SSPI;";
            }
        }
    }
}
