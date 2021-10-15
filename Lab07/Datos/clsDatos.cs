using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class clsDatos
    {
        public SqlConnection con;

        public clsDatos() 
        {
            String str = "Server=DESKTOP-09R8VQE\\SQLEXPRESS;Database=School;Integrated Security=true;";
            con = new SqlConnection(str);
        }
    }
}
