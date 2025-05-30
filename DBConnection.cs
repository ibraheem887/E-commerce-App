using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace E_Commerce
{
    class DBConnection
    {

        public OracleConnection GetConnection()
        {
            string connectionstring = "User Id= project; Password = project; Data Source=//localhost:1521/XE";
            return new OracleConnection(connectionstring);
        }
    }

}
