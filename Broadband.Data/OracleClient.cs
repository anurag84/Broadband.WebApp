using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadband.Data
{
    class OracleClient : IOracleDataProvider
    {
        public  int OpenDb()
        {
            Console.WriteLine("Oracle Connection opened.");
            return 1;
        }
        public  int CloseDb()
        {
            Console.WriteLine("Oracle Connection closed.");
            return 1;
        }
        public  int ExecuteOracleCommand()
        {
            Console.WriteLine("Oracle command executed");
            return 1;
        }
    }
}
