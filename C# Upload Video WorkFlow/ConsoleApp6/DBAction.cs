using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace ConsoleApp6
{
    public class DBAction
    {
        // SqlConnection con = new SqlConnection(<<connection string>>)
        public void DBconnect()
        {
            // con.open()
            Console.WriteLine("\nConnecting to DB...\nConnected to DB.\nListening on port 3306..");
        }
        public void DBclose()
        {
            // con.Close()
            Console.WriteLine("\nConnection clsoed successfully.");
        }

        public void DBcmd()
        {
            // SqlCommand cmd = new SqlCommand("Update VideoTable SET Status = \"Processing\"");
            // cmd.ExecuteNonQuery();
            Console.WriteLine("\nExecuting command..\nUpdating status to processing...\nCompleted Successfully.");
        }
        public void Execute()
        {
            DBconnect();
            DBcmd();
            DBclose();
        }
    }
}
