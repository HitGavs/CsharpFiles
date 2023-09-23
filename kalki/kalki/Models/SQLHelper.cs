using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using Microsoft.Data.SqlClient;

namespace kalki.Models
{
    public class SQLHelper
    {
        public static SqlConnection CreateConnection()
        {
            var connString = @"server=200411LTP2889\SQLEXPRESS; database = htdb; integrated security = true; Encrypt = false; ";


           SqlConnection sqlcn = new SqlConnection(connString);
            return sqlcn;
        }
    }

    
}
