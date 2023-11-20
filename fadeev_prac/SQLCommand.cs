using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using fadeev_prac.modelDB;
using System.Data;

namespace fadeev_prac
{
    public class SQLCommand
    {
        static string connectionString = @"Data Source=CLS-RDS01\SQLEXPRESS;Initial Catalog=fadeev_prac;Integrated Security=True";

        static SqlConnection SqlConnect()
        {
           SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
        static void SqlInsert(string tableName)
        {

        }
        public IList<string> GetNameTable()
        {
            List<string> tables = new List<string>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            DataTable dt = sqlConnection.GetSchema("Tables");
            foreach (DataRow row in dt.Rows)
            {
                string tablename = (string)row[2];
                tables.Add(tablename);
            }
            return tables;
        }

        private void MainWindow_Loaded(object sender, SqlConnection sqlConnection)
        {
            
        }
    }
}
