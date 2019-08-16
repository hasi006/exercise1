using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PholymophrismDBConnectionEx
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var orcleConnection = new OracleConnection("oracle connection string");
                var cmd =new DbCommand(orcleConnection, "select x");
                cmd.Execute();

                Console.ReadLine();

                var sqlConnection = new SqlConnectin("sql connection string");
                //sqlConnection.Open();
                //sqlConnection.Close();
                var cmdsql=new DbCommand(sqlConnection, "select x");
                cmdsql.Execute();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
