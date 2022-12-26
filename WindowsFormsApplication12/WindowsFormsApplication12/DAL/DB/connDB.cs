using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WindowsFormsApplication12.DAL
{
    class connDB
    {
       static string conntionst = "serve= .;Database= ex4;integated seuurty=True";
       public static SqlConnection con = new SqlConnection(conntionst);

       public static void open() {
           if (con.State == System.Data.ConnectionState.Closed)
               con.Open();
       
       }
       public static void closed() {

           if (con.State == System.Data.ConnectionState.Open)
               con.Close();
       
       }

    }
}
 