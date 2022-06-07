using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Prelab_1.SQLVariables
{
    public class SQLOperations
    {
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-G9N5CHK;Initial Catalog=OOP2_Lab;Integrated Security=True");
        
        public static void CheckConnection(SqlConnection tempConnection)
        {
            if (tempConnection.State == ConnectionState.Closed)
            {
                tempConnection.Open();
            }
            else
            { 

            }
        }
    }
}
