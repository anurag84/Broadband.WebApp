using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadband.Data
{
   public class SqlClient : ISqlDataProvider
    {
        public int OpenDb()
        {
            Console.WriteLine("Sql Connection opened.");
            return 1;
        }
        public int CloseDb()
        {
            Console.WriteLine("Sql Connection closed.");
            return 1;
        }
        public int ExecuteSQLCommand()
        {
            Console.WriteLine("Sql command executed.");
            return 1;
        } 
    }
}
