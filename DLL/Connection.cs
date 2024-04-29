using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP_DLL_Mysql;
using MySql.Data.MySqlClient;


namespace AP_Mysql
{
    public class Connection
    {
        string Connection = "server=localhost;uid=root;database=dll";
        MySqlConnection conn = new MySqlConnection(Connection);
    }
}
 