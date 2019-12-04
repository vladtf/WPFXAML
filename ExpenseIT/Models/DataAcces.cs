using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ExpenseIT.Models
{
    class DataAcces
    {
        /// <summary>
        /// Return a list of People retrieved from a database
        /// </summary>
        /// <returns></returns>
        public static List<PersonModel> GetPeople()
        {
            //Creates a new connection by a connection string.
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection("Data Source=work.database.windows.net;Initial Catalog=work;User ID=worker;Password=Employees123;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                //Query our connection and convert it to a list.
                var output = connection.Query<PersonModel>("select * from [dbo].[employees];").ToList();
                return output;
            }
        }
    }
}
