using System.Data.SqlClient;

namespace Taller.DataAccess
{
    public class BdComun
    {

       public static SqlConnection ObtenerConexion()
       {
           SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-QN49N6K\\DANIELDB;Initial Catalog=Taller;Integrated Security=true;");

           conectar.Open();
           return conectar;
       }

    }
}
